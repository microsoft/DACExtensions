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
        public void TestIndexIncludedColumns()
        {
            TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { });
            model.AddObjects(@"CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    col1 int not null,
	[c] AS (Id + ' ')
);
GO
CREATE INDEX ix_1 on Table1 (c) INCLUDE ( col1)
");
            TSqlTypedModel typedModel = new TSqlTypedModel(model);

            var index = typedModel.GetObject<TSqlIndex>(new ObjectIdentifier("dbo", "Table1", "ix_1"), DacQueryScopes.UserDefined);

            Assert.IsNotNull(index,"Index should not be null");
            Assert.AreEqual(1, index.IncludedColumns.Count(), "Incorrect number of included columns");
        }

        [TestMethod]
        public void TestTSqlDataType()
        {
            TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { });
              model.AddObjects(@"
CREATE PARTITION FUNCTION [pf1]
	(
		int
	)
	AS RANGE LEFT
	FOR VALUES (1,100,1000)
");
              model.AddObjects(@"
");

              TSqlTypedModel typedModel = new TSqlTypedModel(model);

              TSqlPartitionFunction function = typedModel.GetObject<TSqlPartitionFunction>(
                  new ObjectIdentifier("pf1"), DacQueryScopes.UserDefined);
                
                foreach(var parameterType in function.ParameterType)
                {
                    Assert.AreEqual(SqlDataType.Int, parameterType.SqlDataType, "DataType on partition function is not correct");                 
                }


        }

        [TestMethod]
        public void TestTableType()
        {
            TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { });
            model.AddObjects(@"CREATE TYPE [dbo].[UserDefinedTableType1] AS TABLE
(
	Id INT PRIMARY KEY, 
	Name VARCHAR(128) CHECK( Id <> ' '),
	MI char(1) DEFAULT (' '),
	UniqueValue int UNIQUE,
    ComputedColumn AS ( Name + ' ' + MI + ' ' + UniqueValue),
	INDEX IX_1 (Name)
)");

            TSqlTypedModel typedModel = new TSqlTypedModel(model);
          
            var tableType1 = typedModel.GetObject<TSqlTableType>(
                new ObjectIdentifier("dbo","UserDefinedTableType1"), DacQueryScopes.UserDefined);
            Assert.IsNotNull(tableType1, "table type should not be null");
            Assert.AreEqual(4, tableType1.Constraints.Count(),"Incorrect number of constraints");
            Assert.AreEqual(1, tableType1.DefaultConstraints.Count(), "Incorrect number of Default constraints");
            Assert.AreEqual(1, tableType1.CheckConstraints.Count(), "Incorrect number of Check constraints");
            Assert.AreEqual(1, tableType1.PrimaryKeyConstraints.Count(), "Incorrect number of Primary Key constraints");
            Assert.AreEqual(1, tableType1.UniqueConstraints.Count(), "Incorrect number of Unique Key constraints");
            Assert.AreEqual(1, tableType1.Indexes.Count(), "Incorrect number of indexes");
            Assert.AreEqual(5, tableType1.Columns.Count(), "Incorrect number of columns");
            TSqlTableTypeColumn computedColumn = tableType1.Columns
                .SingleOrDefault(c => c.Name.Parts[2] == "ComputedColumn");
            Assert.IsNotNull(computedColumn, "computed column ComputedColumn missing");
            Assert.AreEqual(2, computedColumn.ExpressionDependencies, "incorrect number of dependencies");
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
