
//------------------------------------------------------------------------------
// <copyright company="Microsoft">
//   Copyright 2013 Microsoft
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//------------------------------------------------------------------------------

using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Public.Dac.Samples;
using Public.Dac.Samples.Contributors;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;

namespace Public.Dac.Sample.Tests
{
    [TestClass]
    public class TestCreateIndexOperationalPropsModifier
    {
        private const string DataSourceName = "(localdb)\\MSSQLLocalDB";
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
                model.AddObjects("CREATE TABLE [dbo].[t1] (c1 INT NOT NULL)");
                model.AddObjects("CREATE UNIQUE CLUSTERED INDEX Idx1 ON [dbo].[t1] (c1)");
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
        /// Tests setting the online option on an index. Note that a more robust implemenation
        /// for testing using baseline test scripts is recommended, but this is a quick and simple
        /// sample test case
        /// </summary>
        [TestMethod]
        public void TestOperationalOptions()
        {
            int iteration = 0;

            // Given no online option, do not expect script to contain ONLINE
            RunTestAndVerifyResult(new DacDeployOptions(),
                    deployScript => Assert.IsFalse(deployScript.Contains("WITH (ONLINE ="), "Expected no ONLINE option to be set"),
                    iteration++);

            // Given invalid option value, expect no ONLINE setting
            DacDeployOptions options = SetCreateIndexContributorOptions("INVALID", null);
            RunTestAndVerifyResult(options,
                    deployScript => Assert.IsFalse(deployScript.Contains("WITH (ONLINE ="), "Expected no ONLINE option to be set"),
                    iteration++);

            // Given online option ON, expect deployment script to contain "ONLINE=ON"
            options = SetCreateIndexContributorOptions("ON", null);
            RunTestAndVerifyResult(options,
                    deployScript => Assert.IsTrue(deployScript.Contains("WITH (ONLINE = ON)"), "Expected ONLINE option to be 'ON'"),
                    iteration++);

            // Given online option OFF, expect deployment script to contain "ONLINE=OFF"
            options = SetCreateIndexContributorOptions("OFF", null);
            RunTestAndVerifyResult(options,
                deployScript => Assert.IsTrue(deployScript.Contains("WITH (ONLINE = OFF)"), "Expected ONLINE option to be 'OFF'"),
                iteration++);

            // Given MAXDOP option specified, expect it to be included in the settings
            options = SetCreateIndexContributorOptions(null, "ON");
            RunTestAndVerifyResult(options,
                deployScript => Assert.IsTrue(deployScript.Contains("WITH (MAXDOP = ON)"), "Expected MAXDOP option to be 'ON'"),
                iteration++);

            // Given MAXDOP and ONLINE option specified, expect both to be included in the settings
            options = SetCreateIndexContributorOptions("OFF", "ON");
            RunTestAndVerifyResult(options,
                deployScript => Assert.IsTrue(deployScript.Contains("WITH (ONLINE = OFF, MAXDOP = ON)"), "Expected both options to be defined"),
                iteration++);
        }

        private static DacDeployOptions SetCreateIndexContributorOptions(string onlineOption, string maxDopOption)
        {
            var optionsDictionary = new Dictionary<string, string>();
            AddKeyIfValueNotNull(CreateIndexOperationalPropsModifier.OnlineArg, onlineOption, optionsDictionary);
            AddKeyIfValueNotNull(CreateIndexOperationalPropsModifier.MaxDopArg, maxDopOption, optionsDictionary);

            DacDeployOptions options = new DacDeployOptions();
            options.AdditionalDeploymentContributors = CreateIndexOperationalPropsModifier.ContributorId;
            options.AdditionalDeploymentContributorArguments = Utils.BuildContributorArguments(optionsDictionary);
            return options;
        }
        private static void AddKeyIfValueNotNull(string key, string value, Dictionary<string, string> dictionary)
        {
            if (value != null)
            {
                dictionary[key] = value;
            }
        }

        private void RunTestAndVerifyResult(DacDeployOptions options, Action<string> verifyAction, int currentIteration)
        {
            // Given database name, and path to save to
            string dbName = TestContext.TestName;

            // Delete any existing artifacts from a previous run
            DropDbAndDeleteFiles(dbName);

            // NOTE: Cannot turn on deployment by default in the sample test since we target LocalDB and the "Online" option
            // being tested is only supported in enterprise editions. To fully validate that the output of this
            // contributor is correct, change the DataSourceName to target an enterprise server and change 
            // runDeployment to true
            bool runDeployment = false;

            try
            {
                string deployScript = GenerateScriptAndOptionallyDeploy(dbName, options, runDeployment, currentIteration);
                
                verifyAction(deployScript);
            }
            finally
            {
                if (runDeployment)
                {
                    DropDbAndDeleteFiles(dbName);
                }
            }
        }
        
        private static void DropDbAndDeleteFiles(string dbName, string mdfFilePath = null, string ldfFilePath = null)
        {
            TestUtils.DropDatabase(ServerConnectionString, dbName);
            DeleteIfExists(mdfFilePath);
            DeleteIfExists(ldfFilePath);
        }

        private string GenerateScriptAndOptionallyDeploy(string dbName, DacDeployOptions options, bool runDeployment, int currentIteration)
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
                string filePath = GetTestFilePath(string.Format(CultureInfo.CurrentCulture, "deployscript{0}.sql", currentIteration));
                File.WriteAllText(filePath, script);
                Console.WriteLine("Deployment script written to {0}", filePath);

                if (runDeployment)
                {
                    dacServices.Deploy(dacpac, dbName, true, options);
                    AssertDeploySucceeded(ServerConnectionString, dbName);
                }

                return script;
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
            if (!string.IsNullOrWhiteSpace(filePath)
                && File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }
    }
}
