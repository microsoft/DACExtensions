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
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql100, null))
            {

                Assert.IsNotNull(Table.TypeClass, "Type class cannot be null");

                Assert.IsTrue(UtilityMethods.ImplementsType(TSqlTable.TypeClass, typeof(ISqlColumnSource)),
                    "TSqlTable should implement ISqlColumnSource");

                Assert.IsTrue(UtilityMethods.ImplementsType(TSqlTable.TypeClass, typeof(ISql90TSqlTable)),
                    "TSqlTable should implement ISql90TSqlTable");

                Assert.IsTrue(UtilityMethods.ImplementsType(TSqlTable.TypeClass, typeof(TSqlTable)),
                    "TSqlTable should implement TSqlTable");
            }
        }
        [TestMethod]
        public void TestIndexIncludedColumns()
        {
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
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

                Assert.IsNotNull(index, "Index should not be null");
                Assert.AreEqual(1, index.IncludedColumns.Count(), "Incorrect number of included columns");
            }
        }

        [TestMethod]
        public void TestTSqlDataType()
        {
            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
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

                foreach (var parameterType in function.ParameterType)
                {
                    Assert.AreEqual(SqlDataType.Int, parameterType.SqlDataType, "DataType on partition function is not correct");
                }
                var boundaryValues = function.BoundaryValues.ToList();

                Assert.AreEqual(3, boundaryValues.Count, "Incorrect number of boundary values");
                Assert.AreEqual("1", boundaryValues[0].Expression, "incorrect boundary value");
                Assert.AreEqual("100", boundaryValues[1].Expression, "incorrect boundary value");
                Assert.AreEqual("1000", boundaryValues[2].Expression, "incorrect boundary value");
            }
        }

        [TestMethod]
        public void TestTableValuedFunction()
        {
            string assemblyScript = @"CREATE ASSEMBLY [CLR_TVF]
    AUTHORIZATION [dbo]
    FROM 0x4D5A90000300000004000000FFFF0000B800000000000000400000000000000000000000000000000000000000000000000000000000000000000000800000000E1FBA0E00B409CD21B8014CCD21546869732070726F6772616D2063616E6E6F742062652072756E20696E20444F53206D6F64652E0D0D0A2400000000000000504500004C0103006D425E550000000000000000E00002210B010B000008000000060000000000002E270000002000000040000000000010002000000002000004000000000000000600000000000000008000000002000000000000030060850000100000100000000010000010000000000000100000000000000000000000D42600005700000000400000A002000000000000000000000000000000000000006000000C0000009C2500001C0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000200000080000000000000000000000082000004800000000000000000000002E7465787400000034070000002000000008000000020000000000000000000000000000200000602E72737263000000A00200000040000000040000000A0000000000000000000000000000400000402E72656C6F6300000C0000000060000000020000000E0000000000000000000000000000400000420000000000000000000000000000000010270000000000004800000002000500C0200000DC0400000100000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000133004003600000001000011000214FE0116FE010C082D0A00168D0A0000010B2B1E02178D0B0000010D0916039D096F0600000A0A06280100002B00060B2B00072A00001330020016000000020000110002740A0000010A0306280800000A730900000A512A1E02280A00000A2A000042534A4201000100000000000C00000076342E302E33303331390000000005006C00000098010000237E000004020000E801000023537472696E677300000000EC0300000800000023555300F403000010000000234755494400000004040000D800000023426C6F620000000000000002000001471502000908000000FA253300160000010000000D0000000200000003000000040000000A000000040000000200000001000000020000000100000000000A00010000000000060037003000060051003E000A00890074000600D900BA000600F900E60017000D01000006003C011C0106005C011C010A009D0182010600B20130000600B90130000600C40130000A00CF0174000000000001000000000001000100010010001600000005000100010050200000000096005D000A0001009420000000009600920011000300B6200000000086189A001900050000000100A00000000200A60000000100B00002000200B40021009A00190029009A001D0039009A00230041009A00190049009A0019005100BE0178006100CA017F006900D901950019009A009B0009009A00190020002B0028002E001300A5002E001B00AE002E002300B7008B00A1000480000000000000000000000000000000007A010000040000000000000000000000010027000000000004000000000000000000000001006800000000000F00870000000000003C4D6F64756C653E00434C525F5456462E646C6C00546162756C61724576656E744C6F6742006D73636F726C69620053797374656D004F626A6563740053797374656D2E436F6C6C656374696F6E730049456E756D657261626C6500496E69744D6574686F640053797374656D2E446174610053797374656D2E446174612E53716C54797065730053716C43686172730046696C6C526F77002E63746F7200696E70757400736570617261746F72006F626A0076616C75650053797374656D2E52756E74696D652E496E7465726F705365727669636573004F75744174747269627574650053797374656D2E446961676E6F73746963730044656275676761626C6541747472696275746500446562756767696E674D6F6465730053797374656D2E52756E74696D652E436F6D70696C6572536572766963657300436F6D70696C6174696F6E52656C61786174696F6E734174747269627574650052756E74696D65436F6D7061746962696C69747941747472696275746500434C525F545646004D6963726F736F66742E53716C5365727665722E5365727665720053716C46756E6374696F6E41747472696275746500537472696E6700436861720053706C697400417272617900536F72740053716C537472696E67006F705F496D706C696369740000000000032000000000006A03DD2B8352F240A89BC91F5A7890600008B77A5C561934E08906000212090E03070002011C10120D0320000105200101111904200101084F01000200540E1146696C6C526F774D6574686F644E616D650D53706C6974416E644F72646572540E0F5461626C65446566696E6974696F6E165B76616C75655D206E766172636861722834303030290620011D0E1D0307100101011D1E00030A010E0907041D0E1209021D0305000111350E0520010111350307010E0801000701000000000801000800000000001E01000100540216577261704E6F6E457863657074696F6E5468726F7773010000000000006D425E5500000000020000001C010000B8250000B807000052534453FC017B641174E84696DA41D68EB73EFA03000000633A5C55736572735C6C6F6E6E79625C446F63756D656E74735C56697375616C2053747564696F20323031335C50726F6A656374735C434C52205456535C434C52205456535C6F626A5C44656275675C434C525F5456462E70646200000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FC26000000000000000000001E270000002000000000000000000000000000000000000000000000102700000000000000000000000000000000000000005F436F72446C6C4D61696E006D73636F7265652E646C6C0000000000FF250020001000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000100100000001800008000000000000000000000000000000100010000003000008000000000000000000000000000000100000000004800000058400000440200000000000000000000440234000000560053005F00560045005200530049004F004E005F0049004E0046004F0000000000BD04EFFE00000100000000000000000000000000000000003F000000000000000400000002000000000000000000000000000000440000000100560061007200460069006C00650049006E0066006F00000000002400040000005400720061006E0073006C006100740069006F006E00000000000000B004A4010000010053007400720069006E006700460069006C00650049006E0066006F0000008001000001003000300030003000300034006200300000002C0002000100460069006C0065004400650073006300720069007000740069006F006E000000000020000000300008000100460069006C006500560065007200730069006F006E000000000030002E0030002E0030002E003000000038000C00010049006E007400650072006E0061006C004E0061006D006500000043004C0052005F005400560046002E0064006C006C0000002800020001004C006500670061006C0043006F00700079007200690067006800740000002000000040000C0001004F0072006900670069006E0061006C00460069006C0065006E0061006D006500000043004C0052005F005400560046002E0064006C006C000000340008000100500072006F006400750063007400560065007200730069006F006E00000030002E0030002E0030002E003000000038000800010041007300730065006D0062006C0079002000560065007200730069006F006E00000030002E0030002E0030002E00300000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000002000000C000000303700000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000;";
            
            string functionScript = @"
CREATE FUNCTION [dbo].[SplitAndOrder]
(@input NVARCHAR (MAX), @separator NCHAR (1))
RETURNS 
     TABLE (
        [value] NVARCHAR (4000) NULL)
ORDER ([value])
AS
 EXTERNAL NAME [CLR_TVF].[TabularEventLogB].[InitMethod]";

            using (TSqlTypedModel model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
                model.AddObjects(assemblyScript);
                model.AddObjects(functionScript);
                var function = model.GetObject<TSqlTableValuedFunction>(new ObjectIdentifier("dbo", "SplitAndOrder"), DacQueryScopes.UserDefined);
                Assert.AreEqual(1, function.Columns.Count(), "Incorrect number of columns");
                Assert.AreEqual(1, function.TableOption.First().OrderColumns.Count(), "Incorrect number of Order columns");
                ClrTableOptionOrderColumnsReference orderColumn = function.TableOption.First().OrderColumns.First();
                Assert.AreEqual("value", orderColumn.Name.Parts[2], "Incorrect number of Order columns");
                Assert.AreEqual(true, orderColumn.Ascending, "Incorrect Ascending metadata value");
            }


        }

        [TestMethod]
        public void TestSignatures()
        {
            using (TSqlTypedModel model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
                model.AddObjects(@"CREATE CERTIFICATE cert_signature_demo 
    ENCRYPTION BY PASSWORD = 'pGFD4bb925DGvbd2439587y'
    WITH SUBJECT = 'ADD SIGNATURE demo';");
                model.AddObjects(@"CREATE PROC [sp_signature_demo]
AS
    PRINT 'This is the content of the procedure.' ;
GO");
                model.AddObjects(@"ADD SIGNATURE TO [sp_signature_demo] 
    BY CERTIFICATE [cert_signature_demo] 
    WITH PASSWORD = 'pGFD4bb925DGvbd2439587y' ;");

                var signatures = model.GetObjects<TSqlSignature>( DacQueryScopes.UserDefined);
                var signature = signatures.First();
                TSqlSignatureEncryptionMechanism encryption = signature.EncryptionMechanism.FirstOrDefault() as TSqlSignatureEncryptionMechanism;
                Assert.IsNotNull(encryption, " Encryption Mechanism is null or missing");
                Assert.AreEqual(1, encryption.Certificate.Count(), "Missing Certificate on signature");
                TSqlCertificateReference certifcate = encryption.Certificate.First() as TSqlCertificateReference;
                Assert.AreEqual("ADD SIGNATURE demo", certifcate.Subject, "Incorrect Subject");   
            }
        }

        [TestMethod]
        public void TestTableType()
        {
            using (TSqlTypedModel model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
                model.AddObjects(@"CREATE TYPE [dbo].[UserDefinedTableType1] AS TABLE
(
	Id INT PRIMARY KEY, 
	Name VARCHAR(128) CHECK( Id <> ' '),
	MI char(1) DEFAULT (' '),
	UniqueValue int UNIQUE,
    ComputedColumn AS ( Name + ' ' + MI + ' ' + UniqueValue),
	INDEX IX_1 (Name)
)");


                var tableType1 = model.GetObject<TSqlTableType>(
                    new ObjectIdentifier("dbo", "UserDefinedTableType1"), DacQueryScopes.UserDefined);
                Assert.IsNotNull(tableType1, "table type should not be null");
                Assert.AreEqual(4, tableType1.Constraints.Count(), "Incorrect number of constraints");
                Assert.AreEqual(1, tableType1.DefaultConstraints.Count(), "Incorrect number of Default constraints");
                Assert.AreEqual(1, tableType1.CheckConstraints.Count(), "Incorrect number of Check constraints");
                Assert.AreEqual(1, tableType1.PrimaryKeyConstraints.Count(), "Incorrect number of Primary Key constraints");
                Assert.AreEqual(1, tableType1.UniqueConstraints.Count(), "Incorrect number of Unique Key constraints");
                Assert.AreEqual(1, tableType1.Indexes.Count(), "Incorrect number of indexes");
                Assert.AreEqual(5, tableType1.Columns.Count(), "Incorrect number of columns");
                TSqlTableTypeColumn computedColumn = tableType1.Columns
                    .SingleOrDefault(c => c.Name.Parts[2] == "ComputedColumn");
                Assert.IsNotNull(computedColumn, "computed column ComputedColumn missing");
                Assert.AreEqual(3, computedColumn.ExpressionDependencies.Count(), "incorrect number of dependencies");
            }
        }
        [TestMethod]
        public void BasicInstantiation()
        {

            using (TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
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
                for (int i = 0; i < genericColumns.Count; i++)
                {
                    TSqlColumn col = genericColumns[i];
                    ISql90TSqlColumn sql90Col = sql90Columns[i];
                    Assert.AreEqual(ColumnType.Column, col.ColumnType, "Invalid metadata ColumnType");
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

        [TestMethod]
        public void TestFullTextIndex()
        {
            using (var model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {

                string createIndex = @"CREATE UNIQUE INDEX ui_ukJobCand ON HumanResources.JobCandidate(JobCandidateID)";
                string createCatalog = "CREATE FULLTEXT CATALOG ft AS DEFAULT";
                string createFTIIndex = @"
    CREATE FULLTEXT INDEX ON HumanResources.JobCandidate(Resume) 
       KEY INDEX ui_ukJobCand 
       WITH STOPLIST = SYSTEM";
                model.AddObjects(createIndex);
                model.AddObjects(createCatalog);
                model.AddObjects(createFTIIndex);


                var indexes = model.GetObjects<TSqlFullTextIndex>(DacQueryScopes.UserDefined).ToList();
                Assert.AreEqual(1, indexes.Count, "Incorrect number of full Text Indexes");
                TSqlFullTextIndex ftIndex = indexes[0];
                var ftColumns = ftIndex.Columns.ToList();
                Assert.AreEqual(1, ftColumns.Count, "Incorrect number of columns");
            }
        }
        [TestMethod]
        public void TestFullTextIndexWithTypeColumn()
        {
            using (var model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {

                string createIndex = @"CREATE FULLTEXT INDEX ON Production.Document
  ( 
  Title
      Language 1033, 
  DocumentSummary
      Language 1033, 
  Document 
      TYPE COLUMN FileExtension
      Language 1033 
  )
  KEY INDEX PK_Document_DocumentID
          WITH STOPLIST = SYSTEM, SEARCH PROPERTY LIST = DocumentPropertyList, CHANGE_TRACKING OFF, NO POPULATION";
                model.AddObjects(createIndex);

                var tc = Column.TypeClass;
                var indexes = model.GetObjects<TSqlFullTextIndex>(DacQueryScopes.UserDefined).ToList();
                Assert.AreEqual(1, indexes.Count, "Incorrect number of full Text Indexes");
                TSqlFullTextIndex ftIndex = indexes[0];
                var ftColumns = ftIndex.Columns.ToList();
                Assert.AreEqual(3, ftColumns.Count, "Incorrect number of columns");
            }
        }

        private static string GetPropertyTypeName(Type dataType, out bool useGenericGetter)
        {
            useGenericGetter = true;
            string typeName;
            if (dataType.IsGenericType)
            {
                Type[] genericTypes = dataType.GetGenericArguments();
                typeName = genericTypes[0].Name + "?";
            }
            else if (dataType.Name == "SqlScriptProperty")
            {
                // SqlScriptProperty is an internal type. The property getter should
                // return a string
                typeName = "String";
                useGenericGetter = false;
            }
            else
            {
                typeName = dataType.Name;
            }

            return typeName;
        }

        [TestMethod]
        public void TestIndexColumnMetadata()
        {

            
            
            using (TSqlTypedModel model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
                string createTable = @"
CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL,
    [two] AS (ID +1),
    columnSet1 int sparse,
    columnSet2 int sparse,
    cs xml column_set for all_sparse_columns
)
"; 

                model.AddObjects(createTable);
                model.AddObjects("CREATE INDEX IX ON Table1 (Id ASC, two DESC)");

                TSqlIndex index = model.GetObject<TSqlIndex>(new ObjectIdentifier("dbo", "Table1", "IX"), DacQueryScopes.UserDefined);
                var columns = index.Columns.ToList();
                Assert.AreEqual(2, columns.Count, "Incorrect number of index columns");
                Assert.AreEqual(true, columns[0].Ascending, "Incorrect Ascending value");
                Assert.AreEqual(false, columns[1].Ascending, "Incorrect Ascending value");
            }
        }
        [TestMethod]
        public void TestTableColumnMetadataProperties()
        {

            using (TSqlTypedModel model = new TSqlTypedModel(SqlServerVersion.Sql120, new TSqlModelOptions() { }))
            {
                string createTable = @"
CREATE TABLE [dbo].[Table1]
(
	[Id] INT NOT NULL,
    [two] AS (ID +1),
    columnSet1 int sparse,
    columnSet2 int sparse,
    cs xml column_set for all_sparse_columns
)
";               
                model.AddObjects(createTable);

                List<TSqlTable> tables = model.GetObjects<TSqlTable>(DacQueryScopes.Default).ToList();
                Assert.AreEqual(1, tables.Count(), "Incorrect number of tables");
                List<TSqlColumn> columns = tables[0].Columns.ToList();

                TSqlColumn col = columns[0];
                Assert.AreEqual(ColumnType.Column, col.ColumnType, "Incorrect ColumnType Metadata for column "  + col.Name.Parts[2]);
                col = columns[1];
                Assert.AreEqual(ColumnType.ComputedColumn, col.ColumnType, "Incorrect ColumnType Metadata for column " + col.Name.Parts[2]);
                col = columns[2];
                Assert.AreEqual(ColumnType.Column, col.ColumnType, "Incorrect ColumnType Metadata for column " + col.Name.Parts[2]);
                col = columns[3];
                Assert.AreEqual(ColumnType.Column, col.ColumnType, "Incorrect ColumnType Metadata for column " + col.Name.Parts[2]);
                col = columns[4];
                Assert.AreEqual(ColumnType.ColumnSet, col.ColumnType, "Incorrect ColumnType Metadata for column " + col.Name.Parts[2]);
            }
          
        }
        /*
         ;

         */
        //public void CompareAPI()
        //{
        //    TSqlModel model = new TSqlModel(SqlServerVersion.Sql120, new TSqlModelOptions(){});

        //    TSqlTypedModel typedModel = new TSqlTypedModel(model);


        //    // Create Identifier for the dbo.users table
        //    ObjectIdentifier tableId = new ObjectIdentifier("dbo", "users");
        //    // Query the model for the dbo.users table
        //    // Note the return type is the generic TSqlObject not a Table object
        //    TSqlObject table = model.GetObject(Table.TypeClass, tableId, DacQueryScopes.UserDefined);
        //    // Get all the columns that do not support NULL values
        //    IEnumerable<TSqlObject> column = table
        //        .GetReferenced(Table.Columns)
        //            // Note the use of GetProperty and the explicity cast
        //            .Where(c => !((bool)c.GetProperty(Column.Nullable)));

        //}
        //public void CompareAPI()
        //{
        //    TSqlTypedModel model = new TSqlTypedModel(SqlServerVersion.Sql90, new TSqlModelOptions() { });

        //    // Create Identifier for the l1 login
        //    ObjectIdentifier loginId = new ObjectIdentifier("l1");
        //    // Get the login from the model
        //    TSqlLogin login = model.GetObject<TSqlLogin>(loginId, DacQueryScopes.UserDefined);
        //    // Downcast login to ISql90TSqlLogin to ensure only SQL 2005 properties
        //    // and references are used
        //    ISql90TSqlLogin sql90Login = (ISql90TSqlLogin)login;
        //    // Downcast login to ISqlAzureTSqlLogin to ensure only Microsoft Azure SQLDB properties
        //    // and referneces are used
        //    ISqlAzureTSqlLogin sqlAzureLogin = (ISqlAzureTSqlLogin)login;
            
        //    // Create Identifier for the dbo.users table
        //    ObjectIdentifier tableId = new ObjectIdentifier("dbo", "users");
        //    // Query the model for the dbo.users table
        //    TSqlTable table = model.GetObject<TSqlTable>(tableId, DacQueryScopes.UserDefined);
        //    // Get all the columns that do not support NULL values
        //    IEnumerable<TSqlColumn> column = table.Columns.Where(c => !c.Nullable);



        //}


    }
}
