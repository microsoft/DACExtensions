using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Public.Dac.Samples;

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
        }

        private int CountTablesViewsAndSchemas(TSqlModel model)
        {
            return model.GetObjects(DacQueryScopes.UserDefined, 
                Table.TypeClass,
                View.TypeClass, 
                Schema.TypeClass).Count();
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
    }
}
