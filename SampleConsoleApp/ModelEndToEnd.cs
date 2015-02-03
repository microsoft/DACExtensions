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
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.IO;
using System.Linq;
using ColumnType = Microsoft.SqlServer.Dac.Model.ColumnType;

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

            // Verify the ColumnType of this column. This can help indicate which properties will return meaningful values.
            // For instance  since Column.Collation is only available on a simple column, and Column.Persisted is only on computed columns
            ColumnType columnType = column.GetMetadata<ColumnType>(Column.ColumnType);
            Console.WriteLine("Column c1 is of type '{0}'", columnType);
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
