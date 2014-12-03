using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.SqlServer.Dac.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.SqlServer.Dac.Extensions.Prototype;
namespace Public.Dac.Sample.Tests
{
    [TestClass]
    public class TestStronglyTypeModel
    {

        [TestMethod]
        public void ValideImplementsType()
        {
            // ISSUE: If I don't create a model first the Table.TypeClass property is null.
            TSqlModel model = new TSqlModel(SqlServerVersion.Sql100, null);

            Assert.IsNotNull(Table.TypeClass, "Type class cannot be null");
            
            Assert.IsTrue(UtilityMethods.ImplementsType(TSqlTable.TypeClass, typeof(ISqlColumnSource)),
                "TSqlTable should implement ISqlColumnSource");

            Assert.IsTrue(UtilityMethods.ImplementsType(TSqlTable.TypeClass, typeof(ISql90TSqlTable)),
                "TSqlTable should implement ISql90TSqlTable");

            Assert.IsTrue(UtilityMethods.ImplementsType(TSqlTable.TypeClass, typeof(TSqlTable)),
                "TSqlTable should implement TSqlTable");

        }

        [TestMethod]
        public void BasicInstantiation()
        {

            TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { });
            string createTable = @"
CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY
)
";

            string createCheck = @"
ALTER TABLE [dbo].[Table1]
	ADD CONSTRAINT [check1]
	CHECK (1 > 0)
";

            model.AddObjects(createTable);
            model.AddObjects(createCheck);

            IEnumerable<TSqlObject> tables = model.GetObjects(DacQueryScopes.Default, Table.TypeClass);            
            tables.Single().GetReferencing(View.BodyDependencies);

            TSqlTypedModel typedModel = new TSqlTypedModel(model);

            var genericTables = typedModel.GetObjects<TSqlTable>(DacQueryScopes.Default);
            var sql90Tables = typedModel.GetObjects<ISql90TSqlTable>(DacQueryScopes.Default);
            TSqlTable genericTable = genericTables.First();            
            ISql90TSqlTable sql90Table = sql90Tables.First();

            IList<TSqlColumn> genericColumns = genericTable.Columns.ToList();
            IList<ISql90TSqlColumn> sql90Columns = sql90Table.Columns.ToList();

            Assert.AreEqual(genericColumns.Count, sql90Columns.Count, "Column counts should not be different between implementations");
            
            // iterate of generic columns
            for (int i = 0; i < genericColumns.Count; i++ )
            {                
                TSqlColumn col = genericColumns[i];
                ISql90TSqlColumn sql90Col = sql90Columns[i];
                Assert.AreEqual(col.Collation, sql90Col.Collation, "Collation is not the same");
                Assert.AreEqual(col.Expression, sql90Col.Expression, "Expression is not equal");                
            }

            Assert.AreEqual(2, genericTable.AllConstraints.Count(), "Incorrect number of constraints");
            Assert.AreEqual(1, genericTable.CheckConstraints.Count(), "Incorrect number of check constraints");
            Assert.AreEqual(1, genericTable.PrimaryKeyConstraints.Count(), "Incorrect number of Primary Key Constraints");

            //TODO: Code gen the Reverse relationships for all explicitly implemented interfaces
            Assert.AreEqual(2, ((TSqlTable)sql90Table).AllConstraints.Count(), "Incorrect number of constraints");
            Assert.AreEqual(1, ((TSqlTable)sql90Table).CheckConstraints.Count(), "Incorrect number of check constraints");
            Assert.AreEqual(1, ((TSqlTable)sql90Table).PrimaryKeyConstraints.Count(), "Incorrect number of Primary Key Constraints");            
        }
    }
}
