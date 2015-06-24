
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
    public class TestDeploymentStoppingContributor
    {
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

        [TestMethod]
        public void TestStopDeployment()
        {

            // Given database name
            string dbName = TestContext.TestName;

            // Delete any existing artifacts from a previous run
            TestUtils.DropDatabase(TestUtils.ServerConnectionString, dbName);

            // When deploying using the deployment stopping contributor
            try
            {
                DacDeployOptions options = new DacDeployOptions
                {
                    AdditionalDeploymentContributors = DeploymentStoppingContributor.ContributorId
                };

                using (DacPackage dacpac = DacPackage.Load(_dacpacPath, DacSchemaModelStorageType.Memory))
                {
                    DacServices dacServices = new DacServices(TestUtils.ServerConnectionString);

                    // Script then deploy, to support debugging of the generated plan
                    try
                    {
                        dacServices.GenerateDeployScript(dacpac, dbName, options);
                        Assert.Fail("Expected Deployment to fail and exception to be thrown");
                    }
                    catch (DacServicesException expectedException)
                    {
                        Assert.IsTrue(expectedException.Message.Contains(DeploymentStoppingContributor.ErrorViaPublishMessage),
                            "Expected Severity.Error message passed to base.PublishMessage to block deployment");
                        Assert.IsTrue(expectedException.Message.Contains(DeploymentStoppingContributor.ErrorViaThrownException),
                            "Expected thrown exception to block deployment");
                    }
                }

                // Also expect the deployment to fail
                AssertDeployFailed(TestUtils.ServerConnectionString, dbName);
            }
            finally
            {
                TestUtils.DropDatabase(TestUtils.ServerConnectionString, dbName);
            }
        }
        
        private void AssertDeployFailed(string dbConnectionString, string dbName)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder(dbConnectionString);
            scsb.InitialCatalog = "master";
            scsb.Pooling = false;
            using (SqlConnection conn = new SqlConnection(scsb.ConnectionString))
            {
                conn.Open();
                Assert.IsFalse(TestUtils.DoesDatabaseExist(conn, dbName));
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
