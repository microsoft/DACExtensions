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
using Microsoft.SqlServer.Dac.Deployment;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Public.Dac.Samples;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Public.Dac.Sample.Tests
{
    [TestClass]
    public class TestFiltering
    {
        // Count of the tables, views and schema objects in each of the schemas.
        private const int TopLevelProdElementCount = 3;
        private const int TopLevelDevElementCount = 3;
        private const int TopLevelTestElementCount = 2;

        private readonly string[] _testScripts = new string[]
        {
            // Prod
            "CREATE SCHEMA [prod]",
            "CREATE TABLE [prod].[t1] (c1 INT NOT NULL PRIMARY KEY)",
            "CREATE VIEW [prod].[v1] AS SELECT c1 FROM [prod].[t1]",

            // Dev
            "CREATE SCHEMA [dev]",
            "CREATE TABLE [dev].[t2] (c2 INT NOT NULL PRIMARY KEY)",
            "CREATE VIEW [dev].[v2] AS SELECT c2 FROM [dev].[t2]",

            // Test - include reference to production table to highlight errors if filtering breaks references
            "CREATE SCHEMA [test]",
            "CREATE VIEW [test].[v3] AS SELECT c1 FROM [prod].[t1]",
        };

        private DisposableList _trash;

        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void InitializeTest()
        {
            _trash = new DisposableList();
        }

        [TestCleanup]
        public void CleanupTest()
        {
            _trash.Dispose();
        }

        [TestMethod]
        public void TestSchemaFilterExcludingSchemas()
        {
            // Given a model with objects that use "dev", "test" and "prod" schemas
            var model = CreateTestModel();

            // When deploying to production (filtering to exclude "dev" and "test" schemas)
            var schemaFilter = new SchemaBasedFilter("dev", "test");
            var filteredModel = CreateFilteredModel(schemaFilter, model);

            // Then expect only the "prod" schema objects to remain
            Assert.AreEqual(TopLevelProdElementCount, CountTablesViewsAndSchemas(filteredModel));
            AssertAllObjectsHaveSchemaName(filteredModel, "prod");
        }

        private int CountTablesViewsAndSchemas(TSqlModel model)
        {
            return GetTablesViewsAndSchemas(model).Count();
        }

        private IEnumerable<TSqlObject> GetTablesViewsAndSchemas(TSqlModel model)
        {
            return model.GetObjects(DacQueryScopes.UserDefined,
                Table.TypeClass,
                View.TypeClass,
                Schema.TypeClass);
        }

        private void AssertAllObjectsHaveSchemaName(TSqlModel model, string schema)
        {
            // Looks for any named object that doesn't have the specified schema name
            foreach (TSqlObject tsqlObject in GetTablesViewsAndSchemas(model))
            {
                if (tsqlObject.Name.HasName && tsqlObject.Name.Parts.Count > 0)
                {
                    Assert.AreEqual(schema, tsqlObject.Name.Parts[0], "Expected all objects to have schema {0} after filter", schema);
                }
            }
        }

        private TSqlModel CreateFilteredModel(SchemaBasedFilter schemaFilter, TSqlModel model)
        {
            ModelFilterer modelFilterer = new ModelFilterer(schemaFilter);

            TSqlModel filteredModel = modelFilterer.CreateFilteredModel(model);
            _trash.Add(filteredModel);
            return filteredModel;
        }

        private TSqlModel CreateTestModel()
        {
            var scripts = _testScripts;
            TSqlModel model = _trash.Add(new TSqlModel(SqlServerVersion.Sql110, new TSqlModelOptions()));
            AddScriptsToModel(model, scripts);
            return model;
        }

        private void AddScriptsToModel(TSqlModel model, IEnumerable<string> scripts)
        {
            foreach (string script in scripts)
            {
                model.AddObjects(script);
            }
        }


        [TestMethod]
        public void TestSchemaFilterIncludingSchemas()
        {
            // Given a model with objects that use "dev", "test" and "prod" schemas
            var model = CreateTestModel();

            // When filtering to include "dev" and "production" schemas
            var schemaFilter = new SchemaBasedFilter("dev", "prod");
            schemaFilter.Filtering = SchemaBasedFilter.FilterType.Include;

            var filteredModel = CreateFilteredModel(schemaFilter, model);

            // Then expect only "test" schema objects to be excluded
            Assert.AreEqual(TopLevelProdElementCount + TopLevelDevElementCount, CountTablesViewsAndSchemas(filteredModel));
        }


        [TestMethod]
        public void TestValidationErrorsIfExcludeReferencedSchema()
        {
            // Given a set of scripts with "dev", "test" and "production" filters
            var model = CreateTestModel();

            // When filtering to only incude "test" filters
            var schemaFilter = new SchemaBasedFilter("test");
            schemaFilter.Filtering = SchemaBasedFilter.FilterType.Include;

            var filteredModel = CreateFilteredModel(schemaFilter, model);

            // Then expect validation of the model to fail since "test" objects depend on elements in the "prod" schema
            IList<DacModelMessage> validationResults = filteredModel.Validate();
            Assert.IsTrue(validationResults.Any(message => message.MessageType == DacMessageType.Error), "Expect validation errors");
        }

        [TestMethod]
        public void TestSaveNewDacpacWithFilteredModel()
        {
            // Given a model with objects that use "dev", "test" and "prod" schemas
            var model = CreateTestModel();
            string existingPackagePath = GetTestFilePath("original.dacpac");
            BuildPackage(model, existingPackagePath);

            string filteredPackagePath = GetTestFilePath("filtered.dacpac");

            // When saving a dacpac for deployment to production (filtering to exclude "dev" and "test" schemas)
            var schemaFilter = new SchemaBasedFilter("dev", "test");
            ModelFilterer modelFilterer = new ModelFilterer(schemaFilter);

            modelFilterer.CreateFilteredDacpac(existingPackagePath, filteredPackagePath);

            // Then expect only the "prod" schema objects to remain in the new package
            var filteredModel = _trash.Add(new TSqlModel(filteredPackagePath));
            Assert.AreEqual(TopLevelProdElementCount, CountTablesViewsAndSchemas(filteredModel));
        }

        private void BuildPackage(TSqlModel model, string path)
        {
            DacPackageExtensions.BuildPackage(path, model, new PackageMetadata());
        }

        private string GetTestFilePath(string fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, TestContext.TestName + "_" + fileName);
        }

        [TestMethod]
        public void TestUpdateDacpacWithFilteredModel()
        {
            // Given a model with objects that use "dev", "test" and "prod" schemas
            var model = CreateTestModel();
            string existingPackagePath = GetTestFilePath("original.dacpac");
            BuildPackage(model, existingPackagePath);

            // When saving a dacpac for deployment to production (filtering to exclude "dev" and "test" schemas)
            var schemaFilter = new SchemaBasedFilter("dev", "test");
            ModelFilterer modelFilterer = new ModelFilterer(schemaFilter);

            modelFilterer.UpdateDacpacModelWithFilter(existingPackagePath);

            // Then expect only the "prod" schema objects to remain in the new package
            var filteredModel = _trash.Add(new TSqlModel(existingPackagePath));
            Assert.AreEqual(TopLevelProdElementCount, CountTablesViewsAndSchemas(filteredModel));
        }


        [TestMethod]
        public void TestFilterPlanWhenPublishing()
        {
            // Given a model with objects that use "dev", "test" and "prod" schemas
            var model = CreateTestModel();
            string existingPackagePath = GetTestFilePath("original.dacpac");
            BuildPackage(model, existingPackagePath);

            DacServices services = new DacServices("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;");

            // When publishing to production (filtering to exclude "dev" and "test" schemas)
            string productionDbName = "ProductionDB";
            using (DacPackage package = DacPackage.Load(existingPackagePath, DacSchemaModelStorageType.Memory))
            {
                // Deploy the dacpac with an additional "filter" contributor.
                DacDeployOptions options = new DacDeployOptions();
                options.AdditionalDeploymentContributors = PlanFilterer.PlanFiltererContributorId;

                // Specify the filter to use and what arguments it needs. Note that this is a little limited by
                // having to pass string-based arguments. This could be worked around by serializing arguments to a 
                // file and passing the file path to the contributor if you need to do anything advanced.
                options.AdditionalDeploymentContributorArguments =
                    PlanFilterer.BuildPlanFiltererArgumentString("SchemaBasedFilter", new Dictionary<string, string>()
                    {
                        {"Schema1", "dev"},
                        {"Schema2", "test"},
                    });

                // For test purposes, always create a new database (otherwise previous failures might mess up our result)
                options.CreateNewDatabase = true;

                // Run the deployment with the options as specified
                services.Deploy(package, productionDbName, upgradeExisting: true, options: options);
            }

            // Then expect only the "prod" schema objects to remain in the new package
            // Extract the dacpac back from the database and ensure that only production elements are there

            string extractedPackagePath = GetTestFilePath("extracted.dacpac");
            services.Extract(extractedPackagePath, productionDbName, "AppName", new Version(1, 0));
            var extractedModel = _trash.Add(new TSqlModel(extractedPackagePath, DacSchemaModelStorageType.Memory));

            Assert.AreEqual(TopLevelProdElementCount, CountTablesViewsAndSchemas(extractedModel));
            AssertAllObjectsHaveSchemaName(extractedModel, "prod");

        }

        /// <summary>
        /// This test illustrates how you can include a requirement for a specific contributor when building the dacpac,
        /// but add specific arguments such as the schemas to be filtered at deployment time. 
        /// 
        /// It builds the dacpac with the contributor ID specified, which means that contributor must be present 
        /// on the computer that the deployment is being run from. However the arguments specifying which schemas are to be filtered
        /// are left to deployment-time. This might be useful in the case where deployment should be blocked unless some schema is
        /// filtered.
        /// </summary>
        [TestMethod]
        public void TestIncludePlanFiltererInDacpac()
        {
            // Given a model with objects that use "dev", "test" and "prod" schemas
            // and the contributor information built in
            var model = CreateTestModel();
            string existingPackagePath = GetTestFilePath("includesContributor.dacpac");
            Console.WriteLine("Build dacpac to \n" + existingPackagePath);
            DacPackageExtensions.BuildPackage(existingPackagePath, model, new PackageMetadata(), new PackageOptions()
            {
                DeploymentContributors = new[] { new DeploymentContributorInformation() { ExtensionId = PlanFilterer.PlanFiltererContributorId } }
            });

            DacServices services = new DacServices("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;");

            // When publishing to production (filtering to exclude "dev" and "test" schemas)
            string productionDbName = "ProductionDB";
            using (DacPackage package = DacPackage.Load(existingPackagePath, DacSchemaModelStorageType.Memory))
            {
                DacDeployOptions options = new DacDeployOptions();

                // Specify the filter to use and what arguments it needs. Note that this is a little limited by
                // having to pass string-based arguments. This could be worked around by serializing arguments to a 
                // file and passing the file path to the contributor if you need to do anything advanced.
                options.AdditionalDeploymentContributorArguments =
                    PlanFilterer.BuildPlanFiltererArgumentString("SchemaBasedFilter", new Dictionary<string, string>()
                    {
                        {"Schema1", "dev"},
                        {"Schema2", "test"},
                    });

                // For test purposes, always create a new database (otherwise previous failures might mess up our result)
                options.CreateNewDatabase = true;

                // Run the deployment with the options as specified
                services.Deploy(package, productionDbName, upgradeExisting: true, options: options);
            }

            // Then expect only the "prod" schema objects to remain in the new package
            // Extract the dacpac back from the database and ensure that only production elements are there

            string extractedPackagePath = GetTestFilePath("extracted.dacpac");
            services.Extract(extractedPackagePath, productionDbName, "AppName", new Version(1, 0));
            var extractedModel = _trash.Add(new TSqlModel(extractedPackagePath, DacSchemaModelStorageType.Memory));

            Assert.AreEqual(TopLevelProdElementCount, CountTablesViewsAndSchemas(extractedModel));
            AssertAllObjectsHaveSchemaName(extractedModel, "prod");

        }
    }
}
