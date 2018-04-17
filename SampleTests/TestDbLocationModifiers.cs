//------------------------------------------------------------------------------
//<copyright company="Microsoft">
//
//    The MIT License (MIT)
//    
//    Copyright (c) 2015 Microsoft
//    
//    Permission is hereby granted, free of charge, to any person obtaining a copy
//    of this software and associated documentation files (the "Software"), to deal
//    in the Software without restriction, including without limitation the rights
//    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//    copies of the Software, and to permit persons to whom the Software is
//    furnished to do so, subject to the following conditions:
//    
//    The above copyright notice and this permission notice shall be included in all
//    copies or substantial portions of the Software.
//    
//    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//    SOFTWARE.
//</copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Public.Dac.Samples;
using Public.Dac.Samples.Contributors;
using Public.Dac.Samples.TestUtilities;

namespace Public.Dac.Sample.Tests
{
    [TestClass]
    public class TestDbLocationModifiers
    {
        public TestContext TestContext { get; set; }
        
        private DisposableList _trash;
        private string _dacpacPath;
        private const string CreateOneTable = "CREATE TABLE [dbo].[t1] (c1 INT NOT NULL PRIMARY KEY)";

        [TestInitialize]
        public void InitializeTest()
        {
            Directory.CreateDirectory(GetTestDir());

            _trash = new DisposableList();
            _dacpacPath = GetTestFilePath("myDatabase.dacpac");
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql110, null))
            {
                model.AddObjects(CreateOneTable);
                DacPackageExtensions.BuildPackage(_dacpacPath, model, new PackageMetadata());
            }
        }

        [TestCleanup]
        public void CleanupTest()
        {
            _trash.Dispose();
            TestUtils.DeleteIfExists(_dacpacPath);
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
            TestUtils.DropDbAndDeleteFiles(dbName, mdfFilePath, ldfFilePath);

            // When deploying using the location modifying contributor
            try
            {
                DacDeployOptions options = SetLocationChangingContributorOptions(dataFolder, filePrefix);
                Deploy(dbName, options);

            // Then expect the database to be saved under that path
                AssertDeploySucceeded(TestUtils.ServerConnectionString, dbName);
                Assert.IsTrue(File.Exists(mdfFilePath));
                Assert.IsTrue(File.Exists(ldfFilePath));

                // Note: for a real application, after creating the DB on the server they may want to
                // detach it and reattach using the database path. We are not doing this since it's
                // not relevant to this test
            }
            finally
            {
                TestUtils.DropDbAndDeleteFiles(dbName, mdfFilePath, ldfFilePath);
            }
        }


        /// <summary>
        /// Tests the contributor that overrides default paths when creating a database
        /// </summary>
        [TestMethod]
        public void TestDbLocationModifierForImport()
        {
            // Given database name, and path to save to
            string dbName = TestContext.TestName;
            string dataFolder = GetTestDir();
            string filePrefix = "mydb";
            string bacpacPath = Path.Combine(dataFolder, dbName + ".bacpac");
            string mdfFilePath = Path.Combine(dataFolder, filePrefix + "_Primary.mdf");
            string ldfFilePath = Path.Combine(dataFolder, filePrefix + "_Primary.ldf");
            
            // Delete any existing artifacts from a previous run
            TestUtils.DropDbAndDeleteFiles(dbName, mdfFilePath, ldfFilePath);

            SqlTestDB importedDb = null;
            try
            {
                // Create a DB and export
                SqlTestDB db = _trash.Add(TestUtils.CreateTestDatabase(TestUtils.DefaultInstanceInfo, "MyOriginalDb"));
                db.Execute(CreateOneTable);
                db.ExportBacpac(bacpacPath);
                
                // When deploying using the location modifying contributor
                DacImportOptions options = new DacImportOptions();
                options.ImportContributors = DbLocationModifier.ContributorId;

                options.ImportContributorArguments =
                    Utils.BuildContributorArguments(new Dictionary<string, string>()
                    {
                    {DbLocationModifier.DbSaveDataLocationArg, dataFolder},
                    {DbLocationModifier.DbSaveLogDataLocationArg, dataFolder},
                    {DbLocationModifier.DbFilePrefixArg, filePrefix},
                    });
                
                importedDb = SqlTestDB.CreateFromBacpac(TestUtils.DefaultInstanceInfo, bacpacPath, options, true);
                
                // Then expect the database to be saved under that path
                AssertDeploySucceeded(importedDb.BuildConnectionString(), importedDb.DatabaseName);
                Assert.IsTrue(File.Exists(mdfFilePath));
                Assert.IsTrue(File.Exists(ldfFilePath));

                // Note: for a real application, after creating the DB on the server they may want to
                // detach it and reattach using the database path. We are not doing this since it's
                // not relevant to this test
            }
            finally
            {
                if(importedDb != null)
                {
                    importedDb.Dispose();
                }
                TestUtils.DeleteIfExists(bacpacPath);
                TestUtils.DeleteIfExists(mdfFilePath);
                TestUtils.DeleteIfExists(ldfFilePath);
            }
        }
        
        private static DacDeployOptions SetLocationChangingContributorOptions(string dataFolder, string filePrefix)
        {
            DacDeployOptions options = new DacDeployOptions();
            options.AdditionalDeploymentContributors = DbLocationModifier.ContributorId;

            options.AdditionalDeploymentContributorArguments =
                Utils.BuildContributorArguments(new Dictionary<string, string>()
                {
                    {DbLocationModifier.DbSaveDataLocationArg, dataFolder},
                    {DbLocationModifier.DbSaveLogDataLocationArg, dataFolder},
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

            TestUtils.DeleteIfExists(mdfFilePath);
            TestUtils.DeleteIfExists(ldfFilePath);

            // When deploying using the create database statement changing contributor
            try
            {
                // Deploy to nonexistent database - should work quickly
                DacDeployOptions options = SetCreateDatabaseContributorOptions(mdfFilePath, ldfFilePath);
                Deploy(dbName, options);

                // Then expect the database to be saved under that path
                AssertDeploySucceeded(TestUtils.ServerConnectionString, dbName);
                Assert.IsTrue(File.Exists(mdfFilePath));
                Assert.IsTrue(File.Exists(ldfFilePath));

                // Note: for a real application, after creating the DB on the server they may want to
                // detach it and reattach using the database path. We are not doing this since it's
                // not relevant to this test
            }
            finally
            {
                TestUtils.DropDatabase(TestUtils.ServerConnectionString, dbName);
                TestUtils.DeleteIfExists(mdfFilePath);
                TestUtils.DeleteIfExists(ldfFilePath);
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
                DacServices dacServices = new DacServices(TestUtils.ServerConnectionString);

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
    }
}
