using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.IO;
using System.Linq;

namespace Public.Dac.Samples.App
{
    /// <summary>
    /// Basic demo class showing end to end usage of the model
    /// </summary>
    internal class ModelEndToEnd
    {
        public static void Run()
        {
            string dacpacPath = "relativePath.dacpac";

            // Note that you could read scripts from a file or use TSqlScript objects that are taken from other models.
            // Hand-crafting TSqlScript is quite awkard but could be done programmatically (we do it internally).
            // If you need examples for this let us know and we can look into that too.
            string[] scripts = new[]
            {
                "CREATE TABLE t1 (c1 NVARCHAR(30) NOT NULL)",
                "CREATE TABLE t2 (c2 INT NOT NULL)",
                "CREATE TABLE t3 (c3 INT NOT NULL)",
                "CREATE TABLE t4 (c4 INT NOT NULL)",
            };
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql110, new TSqlModelOptions { }))
            {
                // Adding objects to the model. 
                foreach (string script in scripts)
                {
                    model.AddObjects(script);
                }

                ReadTheModel(model);

                CopyFromTheModel(model);

                // save the model to a new .dacpac
                // Note that the PackageOptions can be used to specify RefactorLog and contributors to include
                DacPackageExtensions.BuildPackage(
                    dacpacPath,
                    model,
                    new PackageMetadata { Name = "MyPackageName", Description = "This is usually ignored", Version = "1.0" },
                    new PackageOptions() 
                    );
            }

            // Load from a dacpac
            using (TSqlModel modelFromDacpac = new TSqlModel(dacpacPath))
            {
                // Show that all the elements were saved successfully
                ReadTheModel(modelFromDacpac);

                // You can update the model in the dacpac. Other parts of a dacpac can't be updated yet (pre/post deployment scripts)
                modelFromDacpac.AddObjects("CREATE VIEW V1 AS SELECT * FROM T1");

                using (DacPackage dacPackage = DacPackage.Load(dacpacPath, 
                                                    DacSchemaModelStorageType.Memory,
                                                    FileAccess.ReadWrite))
                {
                    // Note how it's a bit awkward to load a dac package and update the model in it right now, since
                    // both load the same path.
                    DacPackageExtensions.UpdateModel(dacPackage, modelFromDacpac, null);
                }
            }

            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }

        private static void ReadTheModel(TSqlModel model)
        {
            // This will get all tables. 
            var tables = model.GetObjects(DacQueryScopes.Default, Table.TypeClass).ToList();

            // Look up a specific table by ID. Note that if no schema is defined when creating an element, the default "dbo" schema is used
            var t1 = model.GetObjects(Table.TypeClass, new ObjectIdentifier("dbo", "t1"), DacQueryScopes.UserDefined).FirstOrDefault();

            // Get a the column referenced by this table, and query its length
            TSqlObject column = t1.GetReferenced(Table.Columns).First(col => col.Name.Parts[2].Equals("c1"));
            int columnLength = column.GetProperty<int>(Column.Length);
            Console.WriteLine("Column c1 has length {0}", columnLength); 
        }

        private static void CopyFromTheModel(TSqlModel model)
        {
            // Copy all tables from 1 model to another - could be useful for filtering, say when you load from 1 model
            // And copy to another
            using (TSqlModel copiedModel = new TSqlModel(SqlServerVersion.Sql110, null))
            {
                foreach (var table in model.GetObjects(DacQueryScopes.Default, Table.TypeClass))
                {
                    TSqlScript script;
                    if (table.TryGetAst(out script))
                    {
                        copiedModel.AddObjects(script);
                    }
                }
            }
        }
    }
}
