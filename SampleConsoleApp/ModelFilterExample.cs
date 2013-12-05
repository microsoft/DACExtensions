using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Public.Dac.Samples.App
{
    internal class ModelFilterExample
    {
        private static readonly string[] SampleScripts = new string[]
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

        private static void AddScriptsToModel(TSqlModel model, IEnumerable<string> scripts)
        {
            foreach (string script in scripts)
            {
                model.AddObjects(script);
            }
        }

        private static string GetFilePathInCurrentDirectory(string fileName)
        {
            return Path.Combine(Environment.CurrentDirectory, fileName);
        }

        public static void RunFilteringExample()
        {

            // Given a model with objects that use "dev", "test" and "prod" schemas
            string existingPackagePath = GetFilePathInCurrentDirectory("original.dacpac");
            var scripts = SampleScripts;
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql110, new TSqlModelOptions()))
            {
                AddScriptsToModel(model, scripts);

                Console.WriteLine("Saving test scripts to package '"+existingPackagePath+"'");
                DacPackageExtensions.BuildPackage(existingPackagePath, model, new PackageMetadata());


                Console.WriteLine("Objects found in original package: '" + existingPackagePath + "'");
                PrintTablesViewsAndSchemas(model);
                
            }

            string filteredPackagePath = GetFilePathInCurrentDirectory("filtered.dacpac");

            // When saving a dacpac for deployment to production (filtering to exclude "dev" and "test" schemas)
            var schemaFilter = new SchemaBasedFilter("dev", "test");
            ModelFilterer modelFilterer = new ModelFilterer(schemaFilter);

            
            Console.WriteLine("Creating filtered package: '"+filteredPackagePath+"'");
            modelFilterer.CreateFilteredDacpac(existingPackagePath, filteredPackagePath);

            // Then expect only the "prod" schema objects to remain in the new package
            using (TSqlModel filteredModel = new TSqlModel(filteredPackagePath))
            {
                Console.WriteLine("Objects found in filtered package: '" + filteredPackagePath + "'");
                PrintTablesViewsAndSchemas(filteredModel);
            }
        }

        private static void PrintTablesViewsAndSchemas(TSqlModel model)
        {
            foreach (TSqlObject tsqlObject in model.GetObjects(DacQueryScopes.UserDefined,
                    Table.TypeClass,
                    View.TypeClass,
                    Schema.TypeClass))
            {
                Console.WriteLine("\t{0}", PrettyPrintObjectName(tsqlObject));
            }
        }

        /// <summary>
        /// Utility method that's unfortunately needed since public model doesn't currently return nicely formatted
        /// strings for an identifier
        /// </summary>
        /// <param name="tsqlObject"></param>
        /// <returns></returns>
        private static string PrettyPrintObjectName(TSqlObject tsqlObject)
        {
            StringBuilder name = new StringBuilder();
            ObjectIdentifier id = tsqlObject.Name;
            if(id.HasName)
            {
                // Models with references may contain objects with external name parts. 
                // These represent things like the "$(RefDatabase)" part of a name like [$(RefDatabase)].[MytSchema].[MyTable]
                if (id.HasExternalParts)
                {
                    foreach (string part in id.ExternalParts)
                    {
                        AddNamePart(name, part);
                    }
                }

                foreach (string part in id.Parts)
                {
                    AddNamePart(name, part);
                }
            }
            else
            {
                name.Append("UnnamedObject");
            }

            return name.ToString();
        }

        private static void AddNamePart(StringBuilder name, string part)
        {
            if (name.Length > 0)
            {
                name.Append('.');
            }
            name.Append('[').Append(part).Append(']');
        }

    }
}
