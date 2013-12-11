using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Text;
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Public.Dac.Samples;
using Public.Dac.Samples.Contributors;

namespace Public.Dac.Sample.Tests
{
    [TestClass]
    public class TestDbLocationModifiers
    {
        private const string DataSourceName = "(localdb)\\v11.0";
        private static string ServerConnectionString
        {
            get { return "Data Source=" + DataSourceName + ";Integrated Security=True"; }
        }

        public TestContext TestContext { get; set; }
        
        private DisposableList _trash;
        private string _dacpacPath;

        [TestInitialize]
        public void InitializeTest()
        {
            Directory.CreateDirectory(GetTestDir());

            _trash = new DisposableList();
            _dacpacPath = GetTestFilePath("myDatabase.dacpac");
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql110, null))
            {
                model.AddObjects("CREATE TABLE [dbo].[t1] (c1 INT NOT NULL PRIMARY KEY)");
                DacPackageExtensions.BuildPackage(_dacpacPath, model, new PackageMetadata());
            }
        }

        [TestCleanup]
        public void CleanupTest()
        {
            _trash.Dispose();
            DeleteIfExists(_dacpacPath);
        }

        private string GetTestFilePath(string fileName)
        {
            return Path.Combine(GetTestDir(), fileName);
        }

        private string GetTestDir()
        {
            return Path.Combine(Environment.CurrentDirectory, TestContext.TestName);
        }

        /// <summary>
        /// Tests the contributor that overrides default paths when creating a database
        /// </summary>
        [TestMethod]
        public void TestDbLocationModifier()
        {

            // Given database name, and path to save to
            string dbName = TestContext.TestName;
            string dataFolder = GetTestDir();
            string filePrefix = "mydb";
            string mdfFilePath = Path.Combine(dataFolder, filePrefix + "_Primary.mdf");
            string ldfFilePath = Path.Combine(dataFolder, filePrefix + "_Primary.ldf");

            // Delete any existing artifacts from a previous run
            DropDbAndDeleteFiles(dbName, mdfFilePath, ldfFilePath);

            // When deploying using the location modifying contributor
            try
            {
                DacDeployOptions options = SetLocationChangingContributorOptions(dataFolder, filePrefix);
                Deploy(dbName, options);

            // Then expect the database to be saved under that path
                AssertDeploySucceeded(ServerConnectionString, dbName);
                Assert.IsTrue(File.Exists(mdfFilePath));
                Assert.IsTrue(File.Exists(ldfFilePath));

                // Note: for a real application, after creating the DB on the server they may want to
                // detach it and reattach using the database path. We are not doing this since it's
                // not relevant to this test
            }
            finally
            {
                DropDbAndDeleteFiles(dbName, mdfFilePath, ldfFilePath);
            }
        }

        private static void DropDbAndDeleteFiles(string dbName, string mdfFilePath, string ldfFilePath)
        {
            TestUtils.DropDatabase(ServerConnectionString, dbName);
            DeleteIfExists(mdfFilePath);
            DeleteIfExists(ldfFilePath);
        }

        private static DacDeployOptions SetLocationChangingContributorOptions(string dataFolder, string filePrefix)
        {
            DacDeployOptions options = new DacDeployOptions();
            options.AdditionalDeploymentContributors = DbLocationModifier.ContributorId;

            options.AdditionalDeploymentContributorArguments =
                Utils.BuildContributorArguments(new Dictionary<string, string>()
                {
                    {DbLocationModifier.DbSaveLocationArg, dataFolder},
                    {DbLocationModifier.DbFilePrefixArg, filePrefix},
                });
            return options;
        }

        /// <summary>
        /// Tests the contributor that changes that CreateDatabaseStatement that specifies
        /// how a DB should be created
        /// </summary>
        [TestMethod]
        public void TestDbCreateDatabaseModifier()
        {
            // Given database name, and paths to save to
            string dbName = TestContext.TestName;
            string dataFolder = GetTestDir();
            string mdfFilePath = Path.Combine(dataFolder, "mydb.mdf");
            string ldfFilePath = Path.Combine(dataFolder, "mydb_log.ldf");

            DeleteIfExists(mdfFilePath);
            DeleteIfExists(ldfFilePath);

            // When deploying using the create database statement changing contributor
            try
            {
                // Deploy to nonexistent database - should work quickly
                DacDeployOptions options = SetCreateDatabaseContributorOptions(mdfFilePath, ldfFilePath);
                Deploy(dbName, options);

                // Then expect the database to be saved under that path
                AssertDeploySucceeded(ServerConnectionString, dbName);
                Assert.IsTrue(File.Exists(mdfFilePath));
                Assert.IsTrue(File.Exists(ldfFilePath));

                // Note: for a real application, after creating the DB on the server they may want to
                // detach it and reattach using the database path. We are not doing this since it's
                // not relevant to this test
            }
            finally
            {
                TestUtils.DropDatabase(ServerConnectionString, dbName);
                DeleteIfExists(mdfFilePath);
                DeleteIfExists(ldfFilePath);
            }
        }

        private static DacDeployOptions SetCreateDatabaseContributorOptions(string mdfFilePath, string ldfFilePath)
        {
            DacDeployOptions options = new DacDeployOptions();
            options.AdditionalDeploymentContributors = DbCreateDatabaseModifier.ContributorId;
            options.AdditionalDeploymentContributorArguments =
                Utils.BuildContributorArguments(new Dictionary<string, string>()
                {
                    {DbCreateDatabaseModifier.MdfFilePathArg, mdfFilePath},
                    {DbCreateDatabaseModifier.LdfFilePathArg, ldfFilePath}
                });
            return options;
        }


        private void Deploy(string dbName, DacDeployOptions options = null)
        {
            if (options == null)
            {
                options = new DacDeployOptions();
            }

            using (DacPackage dacpac = DacPackage.Load(_dacpacPath, DacSchemaModelStorageType.Memory))
            {
                string connectionString = "Data Source=" + DataSourceName + ";Integrated Security=True";

                DacServices dacServices = new DacServices(connectionString);

                // Script then deploy, to support debugging of the generated plan
                string script = dacServices.GenerateDeployScript(dacpac, dbName, options);
                File.WriteAllText(GetTestFilePath("deployscript.sql"), script);
                dacServices.Deploy(dacpac, dbName, true, options);

            }
        }

        private void AssertDeploySucceeded(string dbConnectionString, string dbName)
        {
            string matchingTableCountStatement = @"SELECT COUNT([name])
  FROM [sys].[tables]
  WHERE [name] = 't1'";

            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(dbConnectionString);
            scsb.InitialCatalog = "master";
            scsb.Pooling = false;
            using (SqlConnection conn = new SqlConnection(scsb.ConnectionString))
            {
                conn.Open();
                Assert.IsTrue(TestUtils.DoesDatabaseExist(conn, dbName));
            }

            scsb.InitialCatalog = dbName;
            using (SqlConnection conn = new SqlConnection(scsb.ConnectionString))
            {
                conn.Open();
                Assert.AreEqual(1, TestUtils.ExecuteScalar(conn, matchingTableCountStatement));
            }
        }

        private static void DeleteIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
