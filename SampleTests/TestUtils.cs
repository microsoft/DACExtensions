using System;
using System.Data.SqlClient;
using System.Globalization;

namespace Public.Dac.Sample.Tests
{
    /// <summary>
    /// Utility class for test code. Useful for supporting dropping of databases after tests have completed,
    /// verification a particular database exists, etc.
    /// </summary>
    internal static class TestUtils
    {
        public const string MasterDatabaseName = "master";

        const string _setLockTimeoutDefault = "SET LOCK_TIMEOUT {0}"; //value configurable

        const string _queryDatabaseIfExist = @"SELECT COUNT(*) FROM [sys].[databases] WHERE [name] = '{0}'";

        const string _dropDatabaseIfExist = @"
IF EXISTS (SELECT 1 FROM [sys].[databases] WHERE [name] = '{0}') 
BEGIN
    ALTER DATABASE [{0}]
    SET READ_WRITE;
    ALTER DATABASE [{0}]
    SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
    DROP DATABASE [{0}];
END
";

        const string _dropDatabaseIfExistAzure = @"DROP DATABASE [{0}];";

        public static bool DropDatabase(
            string connString, 
            string databaseName, 
            bool displayException = true,
            bool isAzureDb = false)
        {
            bool rc = false;
            int retryCount = 1;

            for (int i = 0; i < retryCount && rc == false; i++)
            {
                SqlConnection conn = null;
                try
                {
                    SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(connString);
                    scsb.InitialCatalog = "master";
                    scsb.Pooling = false;
                    conn = new SqlConnection(scsb.ConnectionString);
                    conn.Open();

                    if (DoesDatabaseExist(conn, databaseName) == true)
                    {
                        string dropStatement;

                        if (isAzureDb)
                        {
                            dropStatement = string.Format(CultureInfo.InvariantCulture,
                                _dropDatabaseIfExistAzure,
                                databaseName);

                            // Attempt a retry due to azure instability
                            retryCount = 2;
                        }
                        else
                        {
                            conn.ChangeDatabase(MasterDatabaseName);
                            dropStatement = string.Format(CultureInfo.InvariantCulture,
                                _dropDatabaseIfExist,
                                databaseName);
                        }

                        Execute(conn, dropStatement);
                    }

                    rc = true;
                }
                catch (SqlException exception)
                {
                    if (displayException)
                    {
                        // Capture exception information, but don't fail test.
                        Console.WriteLine("Exception while dropping database {0}", databaseName);
                        Console.WriteLine(exception);
                    }
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }

            return rc;
        }


        public static bool DoesDatabaseExist(SqlConnection connection, string databaseName)
        {
            string query = string.Format(CultureInfo.InvariantCulture, _queryDatabaseIfExist, databaseName);

            int result = (int)ExecuteScalar(connection, query);

            return (result == 1);
        }

        /// <summary>
        /// Executes the query, and returns the first column of the first row in the 
        /// result set returned by the query. Extra columns or rows are ignored.
        /// </summary>
        public static object ExecuteScalar(SqlConnection connection, string sqlCommandText, int commandTimeOut = 30)
        {

            ArgumentValidation.CheckForEmptyString(sqlCommandText, "sqlCommandText");

            using (SqlCommand cmd = GetCommandObject(connection, sqlCommandText, commandTimeOut))
            {
                return cmd.ExecuteScalar();
            }
        }

        /// <summary>
        /// Executes commands such as Transact-SQL INSERT, DELETE, UPDATE, and SET statements.
        /// </summary>
        public static void Execute(SqlConnection connection, string sqlCommandText, int? commandTimeOut = null)
        {
            ArgumentValidation.CheckForEmptyString(sqlCommandText, "sqlCommandText");

            if (commandTimeOut == null)
            {
                // Assume infinite timeout in this case for now
                commandTimeOut = 0;
            }

            using (SqlCommand cmd = GetCommandObject(connection, sqlCommandText, commandTimeOut.Value))
            {
                cmd.ExecuteNonQuery();
            }
        }

        private static SqlCommand GetCommandObject(SqlConnection conn, string sqlCommandText, int commandTimeOut)
        {
            SqlCommand cmd = conn.CreateCommand();
            // reasonable hard code to prevent hang client.  
            cmd.CommandTimeout = commandTimeOut;
            cmd.CommandText = String.Format(CultureInfo.InvariantCulture, _setLockTimeoutDefault, GetLockTimeoutMS());
            cmd.ExecuteNonQuery();
            cmd.CommandText = sqlCommandText;
            return cmd;
        }

        /// <summary>
        /// Retrieves the default lock timeout in Milliseconds.  This value should
        /// be used to set the lock timeout on a connection.
        /// </summary>
        /// <returns></returns>
        private static int GetLockTimeoutMS()
        {
            // For now defaulting timout to 90 sec. This could be replaced with a better method for calculating a smart timeout
            // To have no timeout, use 0
            int timeoutMS = 90 * 1000;

            return timeoutMS;
        }
    }

    internal class ArgumentValidation
    {
        public static void CheckForEmptyString(string arg, string argName)
        {
            if (string.IsNullOrEmpty(arg))
            {
                throw new ArgumentException(argName);
            }
        }
    }
}
