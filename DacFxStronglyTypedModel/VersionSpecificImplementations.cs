
namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
	using System;
	using System.Linq;
	using Microsoft.SqlServer.Server;
	using Microsoft.SqlServer.Dac.Model;
	using System.Collections.Generic;
	public partial class Column : ISql90Column
	{		
		String ISql90Column.Collation 
		{
			get { return this.Collation;}
		}
		String ISql90Column.Expression 
		{
			get { return this.Expression;}
		}
		String ISql90Column.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql90Column.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql90Column.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql90Column.IsIdentityNotForReplication 
		{
			get { return this.IsIdentityNotForReplication;}
		}
		Boolean ISql90Column.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql90Column.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql90Column.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql90Column.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql90Column.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql90Column.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql90Column.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql90Column.Scale 
		{
			get { return this.Scale;}
		}
		XmlStyle ISql90Column.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90DataType> ISql90Column.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90Column.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlSchemaCollection> ISql90Column.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableValuedFunction : ISql90TableValuedFunction
	{		
		Boolean? ISql90TableValuedFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql90TableValuedFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql90TableValuedFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql90TableValuedFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql90TableValuedFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql90TableValuedFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql90TableValuedFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90TableValuedFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql90TableValuedFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql90TableValuedFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql90TableValuedFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql90TableValuedFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql90TableValuedFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90TableValuedFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		String ISql90TableValuedFunction.ReturnTableVariableName 
		{
			get { return this.ReturnTableVariableName;}
		}
		SystemDataAccessKind? ISql90TableValuedFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql90TableValuedFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql90TableValuedFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90TableValuedFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90TableValuedFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90TableValuedFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90TableValuedFunction.OrderColumns 
		{
			get 
			{
				return this.OrderColumns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> ISql90TableValuedFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql90TableValuedFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90TableValuedFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90TableValuedFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ScalarFunction : ISql90ScalarFunction
	{		
		Boolean? ISql90ScalarFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql90ScalarFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql90ScalarFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql90ScalarFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql90ScalarFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql90ScalarFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql90ScalarFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90ScalarFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql90ScalarFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql90ScalarFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql90ScalarFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql90ScalarFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql90ScalarFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90ScalarFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		SystemDataAccessKind? ISql90ScalarFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql90ScalarFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql90ScalarFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90ScalarFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90ScalarFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90ScalarFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> ISql90ScalarFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql90ScalarFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90ScalarFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90ScalarFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Aggregate : ISql90Aggregate
	{		
		String ISql90Aggregate.ClassName 
		{
			get { return this.ClassName;}
		}
		Format ISql90Aggregate.Format 
		{
			get { return this.Format;}
		}
		Boolean? ISql90Aggregate.InvariantToDuplicates 
		{
			get { return this.InvariantToDuplicates;}
		}
		Boolean? ISql90Aggregate.InvariantToNulls 
		{
			get { return this.InvariantToNulls;}
		}
		Int32? ISql90Aggregate.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		Boolean? ISql90Aggregate.NullIfEmpty 
		{
			get { return this.NullIfEmpty;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90Aggregate.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> ISql90Aggregate.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql90Aggregate.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Aggregate.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ApplicationRole : ISql90ApplicationRole
	{		
		String ISql90ApplicationRole.Password 
		{
			get { return this.Password;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90ApplicationRole.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}
	}
	public partial class Index : ISql90Index
	{		
		Boolean ISql90Index.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql90Index.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql90Index.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql90Index.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql90Index.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql90Index.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql90Index.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql90Index.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql90Index.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql90Index.Unique 
		{
			get { return this.Unique;}
		}
		Boolean ISql90Index.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Index.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90Index.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Index.IncludedColumns 
		{
			get 
			{
				return this.IncludedColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql90Index.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Index.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90Index.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Assembly : ISql90Assembly
	{		
		AssemblyPermissionSet ISql90Assembly.PermissionSet 
		{
			get { return this.PermissionSet;}
		}
		Boolean ISql90Assembly.Visible 
		{
			get { return this.Visible;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AssemblySource> ISql90Assembly.AssemblySources 
		{
			get 
			{
				return this.AssemblySources;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Assembly.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90Assembly.ReferencedAssemblies 
		{
			get 
			{
				return this.ReferencedAssemblies;
			}
		}
	}
	public partial class AssemblySource : ISql90AssemblySource
	{		
		String ISql90AssemblySource.Source 
		{
			get { return this.Source;}
		}
	}
	public partial class AsymmetricKey : ISql90AsymmetricKey
	{		
		AsymmetricKeyAlgorithm ISql90AsymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		Boolean ISql90AsymmetricKey.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql90AsymmetricKey.ExecutableFile 
		{
			get { return this.ExecutableFile;}
		}
		String ISql90AsymmetricKey.File 
		{
			get { return this.File;}
		}
		String ISql90AsymmetricKey.Password 
		{
			get { return this.Password;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90AsymmetricKey.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90AsymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class AuditAction : ISql90AuditAction
	{		
	}
	public partial class AuditActionGroup : ISql90AuditActionGroup
	{		
	}
	public partial class AuditActionSpecification : ISql90AuditActionSpecification
	{		
	}
	public partial class BrokerPriority : ISql90BrokerPriority
	{		
	}
	public partial class BuiltInServerRole : ISql90BuiltInServerRole
	{		
	}
	public partial class DataType : ISql90DataType
	{		
		SqlDataType ISql90DataType.SqlDataType 
		{
			get { return this.SqlDataType;}
		}
		Boolean ISql90DataType.UddtIsMax 
		{
			get { return this.UddtIsMax;}
		}
		Int32 ISql90DataType.UddtLength 
		{
			get { return this.UddtLength;}
		}
		Boolean ISql90DataType.UddtNullable 
		{
			get { return this.UddtNullable;}
		}
		Int32 ISql90DataType.UddtPrecision 
		{
			get { return this.UddtPrecision;}
		}
		Int32 ISql90DataType.UddtScale 
		{
			get { return this.UddtScale;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90DataType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<System.Type> ISql90DataType.Type 
		{
			get 
			{
				return this.Type;
			}
		}
	}
	public partial class Certificate : ISql90Certificate
	{		
		Boolean ISql90Certificate.ActiveForBeginDialog 
		{
			get { return this.ActiveForBeginDialog;}
		}
		Boolean ISql90Certificate.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql90Certificate.EncryptionPassword 
		{
			get { return this.EncryptionPassword;}
		}
		String ISql90Certificate.ExistingKeysFilePath 
		{
			get { return this.ExistingKeysFilePath;}
		}
		String ISql90Certificate.ExpiryDate 
		{
			get { return this.ExpiryDate;}
		}
		Boolean ISql90Certificate.IsExistingKeyFileExecutable 
		{
			get { return this.IsExistingKeyFileExecutable;}
		}
		String ISql90Certificate.PrivateKeyDecryptionPassword 
		{
			get { return this.PrivateKeyDecryptionPassword;}
		}
		String ISql90Certificate.PrivateKeyEncryptionPassword 
		{
			get { return this.PrivateKeyEncryptionPassword;}
		}
		String ISql90Certificate.PrivateKeyFilePath 
		{
			get { return this.PrivateKeyFilePath;}
		}
		String ISql90Certificate.StartDate 
		{
			get { return this.StartDate;}
		}
		String ISql90Certificate.Subject 
		{
			get { return this.Subject;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Certificate.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90Certificate.ExistingKeysAssembly 
		{
			get 
			{
				return this.ExistingKeysAssembly;
			}
		}
	}
	public partial class CheckConstraint : ISql90CheckConstraint
	{		
		Boolean ISql90CheckConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql90CheckConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql90CheckConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90CheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> ISql90CheckConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class ClrTypeMethod : ISql90ClrTypeMethod
	{		
		String ISql90ClrTypeMethod.Name 
		{
			get { return this.Name;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> ISql90ClrTypeMethod.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql90ClrTypeMethod.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}
	}
	public partial class ClrTypeMethodParameter : ISql90ClrTypeMethodParameter
	{		
		Boolean ISql90ClrTypeMethodParameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		String ISql90ClrTypeMethodParameter.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90DataType> ISql90ClrTypeMethodParameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class ClrTypeProperty : ISql90ClrTypeProperty
	{		
		String ISql90ClrTypeProperty.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql90ClrTypeProperty.ClrType 
		{
			get 
			{
				return this.ClrType;
			}
		}
	}
	public partial class ColumnStoreIndex : ISql90ColumnStoreIndex
	{		
		Boolean ISql90ColumnStoreIndex.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql90ColumnStoreIndex.Disabled 
		{
			get { return this.Disabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90ColumnStoreIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql90ColumnStoreIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90ColumnStoreIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90ColumnStoreIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Contract : ISql90Contract
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Contract.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90MessageType> ISql90Contract.Messages 
		{
			get 
			{
				return this.Messages;
			}
		}
	}
	public partial class Credential : ISql90Credential
	{		
		String ISql90Credential.Identity 
		{
			get { return this.Identity;}
		}
		String ISql90Credential.Secret 
		{
			get { return this.Secret;}
		}
	}
	public partial class CryptographicProvider : ISql90CryptographicProvider
	{		
	}
	public partial class DatabaseAuditSpecification : ISql90DatabaseAuditSpecification
	{		
	}
	public partial class DatabaseDdlTrigger : ISql90DatabaseDdlTrigger
	{		
		Boolean? ISql90DatabaseDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql90DatabaseDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql90DatabaseDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql90DatabaseDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql90DatabaseDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90DatabaseDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql90DatabaseDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql90DatabaseDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql90DatabaseDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql90DatabaseDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90DatabaseDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90DatabaseDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> ISql90DatabaseDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql90DatabaseDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90DatabaseDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90DatabaseDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class DatabaseEncryptionKey : ISql90DatabaseEncryptionKey
	{		
	}
	public partial class DatabaseEventNotification : ISql90DatabaseEventNotification
	{		
		String ISql90DatabaseEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql90DatabaseEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql90DatabaseEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> ISql90DatabaseEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql90DatabaseEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class DatabaseMirroringLanguageSpecifier : ISql90DatabaseMirroringLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql90DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql90DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql90DatabaseMirroringLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		DatabaseMirroringRole ISql90DatabaseMirroringLanguageSpecifier.RoleType 
		{
			get { return this.RoleType;}
		}
		Boolean ISql90DatabaseMirroringLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql90DatabaseMirroringLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> ISql90DatabaseMirroringLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class DatabaseOptions : ISql90DatabaseOptions
	{		
		Boolean ISql90DatabaseOptions.AllowSnapshotIsolation 
		{
			get { return this.AllowSnapshotIsolation;}
		}
		Boolean ISql90DatabaseOptions.AnsiNullDefaultOn 
		{
			get { return this.AnsiNullDefaultOn;}
		}
		Boolean ISql90DatabaseOptions.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql90DatabaseOptions.AnsiPaddingOn 
		{
			get { return this.AnsiPaddingOn;}
		}
		Boolean ISql90DatabaseOptions.AnsiWarningsOn 
		{
			get { return this.AnsiWarningsOn;}
		}
		Boolean ISql90DatabaseOptions.ArithAbortOn 
		{
			get { return this.ArithAbortOn;}
		}
		Boolean ISql90DatabaseOptions.AutoClose 
		{
			get { return this.AutoClose;}
		}
		Boolean ISql90DatabaseOptions.AutoCreateStatistics 
		{
			get { return this.AutoCreateStatistics;}
		}
		Boolean ISql90DatabaseOptions.AutoShrink 
		{
			get { return this.AutoShrink;}
		}
		Boolean ISql90DatabaseOptions.AutoUpdateStatistics 
		{
			get { return this.AutoUpdateStatistics;}
		}
		Boolean ISql90DatabaseOptions.AutoUpdateStatisticsAsync 
		{
			get { return this.AutoUpdateStatisticsAsync;}
		}
		String ISql90DatabaseOptions.Collation 
		{
			get { return this.Collation;}
		}
		Int32 ISql90DatabaseOptions.CompatibilityLevel 
		{
			get { return this.CompatibilityLevel;}
		}
		Boolean ISql90DatabaseOptions.ConcatNullYieldsNull 
		{
			get { return this.ConcatNullYieldsNull;}
		}
		Boolean ISql90DatabaseOptions.CursorCloseOnCommit 
		{
			get { return this.CursorCloseOnCommit;}
		}
		Boolean ISql90DatabaseOptions.CursorDefaultGlobalScope 
		{
			get { return this.CursorDefaultGlobalScope;}
		}
		Boolean ISql90DatabaseOptions.DatabaseStateOffline 
		{
			get { return this.DatabaseStateOffline;}
		}
		Boolean ISql90DatabaseOptions.DateCorrelationOptimizationOn 
		{
			get { return this.DateCorrelationOptimizationOn;}
		}
		Boolean ISql90DatabaseOptions.DBChainingOn 
		{
			get { return this.DBChainingOn;}
		}
		Boolean ISql90DatabaseOptions.FullTextEnabled 
		{
			get { return this.FullTextEnabled;}
		}
		Boolean ISql90DatabaseOptions.MemoryOptimizedElevateToSnapshot 
		{
			get { return this.MemoryOptimizedElevateToSnapshot;}
		}
		Boolean ISql90DatabaseOptions.NumericRoundAbortOn 
		{
			get { return this.NumericRoundAbortOn;}
		}
		PageVerifyMode ISql90DatabaseOptions.PageVerifyMode 
		{
			get { return this.PageVerifyMode;}
		}
		ParameterizationOption ISql90DatabaseOptions.ParameterizationOption 
		{
			get { return this.ParameterizationOption;}
		}
		Boolean ISql90DatabaseOptions.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90DatabaseOptions.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		RecoveryMode ISql90DatabaseOptions.RecoveryMode 
		{
			get { return this.RecoveryMode;}
		}
		Boolean ISql90DatabaseOptions.RecursiveTriggersOn 
		{
			get { return this.RecursiveTriggersOn;}
		}
		ServiceBrokerOption ISql90DatabaseOptions.ServiceBrokerOption 
		{
			get { return this.ServiceBrokerOption;}
		}
		Boolean ISql90DatabaseOptions.SupplementalLoggingOn 
		{
			get { return this.SupplementalLoggingOn;}
		}
		Boolean ISql90DatabaseOptions.TornPageProtectionOn 
		{
			get { return this.TornPageProtectionOn;}
		}
		Boolean ISql90DatabaseOptions.TransactionIsolationReadCommittedSnapshot 
		{
			get { return this.TransactionIsolationReadCommittedSnapshot;}
		}
		Boolean ISql90DatabaseOptions.Trustworthy 
		{
			get { return this.Trustworthy;}
		}
		UserAccessOption ISql90DatabaseOptions.UserAccessOption 
		{
			get { return this.UserAccessOption;}
		}
		Boolean ISql90DatabaseOptions.VardecimalStorageFormatOn 
		{
			get { return this.VardecimalStorageFormatOn;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90DatabaseOptions.DefaultFilegroup 
		{
			get 
			{
				return this.DefaultFilegroup;
			}
		}
	}
	public partial class DataCompressionOption : ISql90DataCompressionOption
	{		
	}
	public partial class Default : ISql90Default
	{		
		String ISql90Default.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90Default.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Default.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class DefaultConstraint : ISql90DefaultConstraint
	{		
		Boolean ISql90DefaultConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql90DefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql90DefaultConstraint.WithValues 
		{
			get { return this.WithValues;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90DefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> ISql90DefaultConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90DefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class DmlTrigger : ISql90DmlTrigger
	{		
		Boolean? ISql90DmlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql90DmlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		OrderRestriction ISql90DmlTrigger.DeleteOrderRestriction 
		{
			get { return this.DeleteOrderRestriction;}
		}
		Boolean ISql90DmlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql90DmlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql90DmlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90DmlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		OrderRestriction ISql90DmlTrigger.InsertOrderRestriction 
		{
			get { return this.InsertOrderRestriction;}
		}
		Boolean ISql90DmlTrigger.IsDeleteTrigger 
		{
			get { return this.IsDeleteTrigger;}
		}
		Boolean ISql90DmlTrigger.IsInsertTrigger 
		{
			get { return this.IsInsertTrigger;}
		}
		Boolean ISql90DmlTrigger.IsUpdateTrigger 
		{
			get { return this.IsUpdateTrigger;}
		}
		String ISql90DmlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean ISql90DmlTrigger.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		Boolean? ISql90DmlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql90DmlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		OrderRestriction ISql90DmlTrigger.UpdateOrderRestriction 
		{
			get { return this.UpdateOrderRestriction;}
		}
		Boolean ISql90DmlTrigger.WithAppend 
		{
			get { return this.WithAppend;}
		}
		Boolean ISql90DmlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90DmlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90DmlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90DmlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql90DmlTrigger.TriggerObject 
		{
			get 
			{
				return this.TriggerObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90DmlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Endpoint : ISql90Endpoint
	{		
		Payload ISql90Endpoint.Payload 
		{
			get { return this.Payload;}
		}
		Protocol ISql90Endpoint.Protocol 
		{
			get { return this.Protocol;}
		}
		State ISql90Endpoint.State 
		{
			get { return this.State;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Endpoint.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> ISql90Endpoint.PayloadSpecifier 
		{
			get 
			{
				return this.PayloadSpecifier;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ISql90Endpoint.ProtocolSpecifier 
		{
			get 
			{
				return this.ProtocolSpecifier;
			}
		}
	}
	public partial class ErrorMessage : ISql90ErrorMessage
	{		
		String ISql90ErrorMessage.Language 
		{
			get { return this.Language;}
		}
		Int32 ISql90ErrorMessage.MessageNumber 
		{
			get { return this.MessageNumber;}
		}
		String ISql90ErrorMessage.MessageText 
		{
			get { return this.MessageText;}
		}
		Int32 ISql90ErrorMessage.Severity 
		{
			get { return this.Severity;}
		}
		Boolean ISql90ErrorMessage.WithLog 
		{
			get { return this.WithLog;}
		}
	}
	public partial class EventGroup : ISql90EventGroup
	{		
		EventGroupType ISql90EventGroup.Group 
		{
			get { return this.Group;}
		}
	}
	public partial class EventSession : ISql90EventSession
	{		
	}
	public partial class EventSessionAction : ISql90EventSessionAction
	{		
	}
	public partial class EventSessionDefinitions : ISql90EventSessionDefinitions
	{		
	}
	public partial class EventSessionSetting : ISql90EventSessionSetting
	{		
	}
	public partial class EventSessionTarget : ISql90EventSessionTarget
	{		
	}
	public partial class EventTypeSpecifier : ISql90EventTypeSpecifier
	{		
		EventType ISql90EventTypeSpecifier.EventType 
		{
			get { return this.EventType;}
		}
		OrderRestriction ISql90EventTypeSpecifier.Order 
		{
			get { return this.Order;}
		}
	}
	public partial class ExtendedProcedure : ISql90ExtendedProcedure
	{		
		Boolean ISql90ExtendedProcedure.ExeccuteAsCaller 
		{
			get { return this.ExeccuteAsCaller;}
		}
		Boolean ISql90ExtendedProcedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90ExtendedProcedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql90ExtendedProcedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90ExtendedProcedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> ISql90ExtendedProcedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90ExtendedProcedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90ExtendedProcedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ExtendedProperty : ISql90ExtendedProperty
	{		
		String ISql90ExtendedProperty.Value 
		{
			get { return this.Value;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> ISql90ExtendedProperty.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class SqlFile : ISql90SqlFile
	{		
		Int32? ISql90SqlFile.FileGrowth 
		{
			get { return this.FileGrowth;}
		}
		MemoryUnit ISql90SqlFile.FileGrowthUnit 
		{
			get { return this.FileGrowthUnit;}
		}
		String ISql90SqlFile.FileName 
		{
			get { return this.FileName;}
		}
		Boolean ISql90SqlFile.IsLogFile 
		{
			get { return this.IsLogFile;}
		}
		Int32? ISql90SqlFile.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql90SqlFile.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		Boolean ISql90SqlFile.Offline 
		{
			get { return this.Offline;}
		}
		Int32? ISql90SqlFile.Size 
		{
			get { return this.Size;}
		}
		MemoryUnit ISql90SqlFile.SizeUnit 
		{
			get { return this.SizeUnit;}
		}
		Boolean ISql90SqlFile.Unlimited 
		{
			get { return this.Unlimited;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90SqlFile.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class Filegroup : ISql90Filegroup
	{		
		Boolean ISql90Filegroup.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
	}
	public partial class ForeignKeyConstraint : ISql90ForeignKeyConstraint
	{		
		ForeignKeyAction ISql90ForeignKeyConstraint.DeleteAction 
		{
			get { return this.DeleteAction;}
		}
		Boolean ISql90ForeignKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql90ForeignKeyConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		ForeignKeyAction ISql90ForeignKeyConstraint.UpdateAction 
		{
			get { return this.UpdateAction;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90ForeignKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90ForeignKeyConstraint.ForeignColumns 
		{
			get 
			{
				return this.ForeignColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Table> ISql90ForeignKeyConstraint.ForeignTable 
		{
			get 
			{
				return this.ForeignTable;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> ISql90ForeignKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class FullTextCatalog : ISql90FullTextCatalog
	{		
		Boolean? ISql90FullTextCatalog.AccentSensitivity 
		{
			get { return this.AccentSensitivity;}
		}
		Boolean ISql90FullTextCatalog.IsDefault 
		{
			get { return this.IsDefault;}
		}
		String ISql90FullTextCatalog.Path 
		{
			get { return this.Path;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90FullTextCatalog.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90FullTextCatalog.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class FullTextIndex : ISql90FullTextIndex
	{		
		ChangeTrackingOption ISql90FullTextIndex.ChangeTracking 
		{
			get { return this.ChangeTracking;}
		}
		Boolean ISql90FullTextIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql90FullTextIndex.Replicated 
		{
			get { return this.Replicated;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90FullTextIndex.Catalog 
		{
			get 
			{
				return this.Catalog;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90FullTextIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql90FullTextIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90FullTextIndex.UniqueIndexName 
		{
			get 
			{
				return this.UniqueIndexName;
			}
		}
	}
	public partial class FullTextIndexColumnSpecifier : ISql90FullTextIndexColumnSpecifier
	{		
		Int32? ISql90FullTextIndexColumnSpecifier.LanguageId 
		{
			get { return this.LanguageId;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90FullTextIndexColumnSpecifier.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90FullTextIndexColumnSpecifier.TypeColumn 
		{
			get 
			{
				return this.TypeColumn;
			}
		}
	}
	public partial class FullTextStopList : ISql90FullTextStopList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90FullTextStopList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class HttpProtocolSpecifier : ISql90HttpProtocolSpecifier
	{		
		AuthenticationModes ISql90HttpProtocolSpecifier.AuthenticationMode 
		{
			get { return this.AuthenticationMode;}
		}
		String ISql90HttpProtocolSpecifier.AuthenticationRealm 
		{
			get { return this.AuthenticationRealm;}
		}
		Int32? ISql90HttpProtocolSpecifier.ClearPort 
		{
			get { return this.ClearPort;}
		}
		Boolean ISql90HttpProtocolSpecifier.CompressionEnabled 
		{
			get { return this.CompressionEnabled;}
		}
		String ISql90HttpProtocolSpecifier.DefaultLogonDomain 
		{
			get { return this.DefaultLogonDomain;}
		}
		Boolean ISql90HttpProtocolSpecifier.ListeningOnAllNoneReservedSites 
		{
			get { return this.ListeningOnAllNoneReservedSites;}
		}
		Boolean ISql90HttpProtocolSpecifier.ListeningOnAllSites 
		{
			get { return this.ListeningOnAllSites;}
		}
		String ISql90HttpProtocolSpecifier.Path 
		{
			get { return this.Path;}
		}
		HttpPorts ISql90HttpProtocolSpecifier.Ports 
		{
			get { return this.Ports;}
		}
		Int32? ISql90HttpProtocolSpecifier.SslPort 
		{
			get { return this.SslPort;}
		}
		String ISql90HttpProtocolSpecifier.Website 
		{
			get { return this.Website;}
		}
	}
	public partial class LinkedServer : ISql90LinkedServer
	{		
		String ISql90LinkedServer.Catalog 
		{
			get { return this.Catalog;}
		}
		Boolean ISql90LinkedServer.CollationCompatible 
		{
			get { return this.CollationCompatible;}
		}
		String ISql90LinkedServer.CollationName 
		{
			get { return this.CollationName;}
		}
		Int32 ISql90LinkedServer.ConnectTimeout 
		{
			get { return this.ConnectTimeout;}
		}
		Boolean ISql90LinkedServer.DataAccess 
		{
			get { return this.DataAccess;}
		}
		String ISql90LinkedServer.DataSource 
		{
			get { return this.DataSource;}
		}
		Boolean ISql90LinkedServer.IsDistributor 
		{
			get { return this.IsDistributor;}
		}
		Boolean ISql90LinkedServer.IsPublisher 
		{
			get { return this.IsPublisher;}
		}
		Boolean ISql90LinkedServer.IsSubscriber 
		{
			get { return this.IsSubscriber;}
		}
		Boolean ISql90LinkedServer.LazySchemaValidationEnabled 
		{
			get { return this.LazySchemaValidationEnabled;}
		}
		String ISql90LinkedServer.Location 
		{
			get { return this.Location;}
		}
		String ISql90LinkedServer.ProductName 
		{
			get { return this.ProductName;}
		}
		String ISql90LinkedServer.ProviderName 
		{
			get { return this.ProviderName;}
		}
		String ISql90LinkedServer.ProviderString 
		{
			get { return this.ProviderString;}
		}
		Int32 ISql90LinkedServer.QueryTimeout 
		{
			get { return this.QueryTimeout;}
		}
		Boolean ISql90LinkedServer.RpcEnabled 
		{
			get { return this.RpcEnabled;}
		}
		Boolean ISql90LinkedServer.RpcOutEnabled 
		{
			get { return this.RpcOutEnabled;}
		}
		Boolean ISql90LinkedServer.UseRemoteCollation 
		{
			get { return this.UseRemoteCollation;}
		}
	}
	public partial class LinkedServerLogin : ISql90LinkedServerLogin
	{		
		String ISql90LinkedServerLogin.LinkedServerLoginName 
		{
			get { return this.LinkedServerLoginName;}
		}
		String ISql90LinkedServerLogin.LinkedServerPassword 
		{
			get { return this.LinkedServerPassword;}
		}
		Boolean ISql90LinkedServerLogin.UseSelf 
		{
			get { return this.UseSelf;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90LinkedServer> ISql90LinkedServerLogin.LinkedServer 
		{
			get 
			{
				return this.LinkedServer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90LinkedServerLogin.LocalLogin 
		{
			get 
			{
				return this.LocalLogin;
			}
		}
	}
	public partial class Login : ISql90Login
	{		
		Boolean ISql90Login.CheckExpiration 
		{
			get { return this.CheckExpiration;}
		}
		Boolean ISql90Login.CheckPolicy 
		{
			get { return this.CheckPolicy;}
		}
		String ISql90Login.DefaultDatabase 
		{
			get { return this.DefaultDatabase;}
		}
		String ISql90Login.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		Boolean ISql90Login.Disabled 
		{
			get { return this.Disabled;}
		}
		LoginEncryptionOption ISql90Login.EncryptionOption 
		{
			get { return this.EncryptionOption;}
		}
		Boolean ISql90Login.MappedToWindowsLogin 
		{
			get { return this.MappedToWindowsLogin;}
		}
		String ISql90Login.Password 
		{
			get { return this.Password;}
		}
		Boolean ISql90Login.PasswordHashed 
		{
			get { return this.PasswordHashed;}
		}
		Boolean ISql90Login.PasswordMustChange 
		{
			get { return this.PasswordMustChange;}
		}
		String ISql90Login.Sid 
		{
			get { return this.Sid;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> ISql90Login.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> ISql90Login.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Credential> ISql90Login.Credential 
		{
			get 
			{
				return this.Credential;
			}
		}
	}
	public partial class MasterKey : ISql90MasterKey
	{		
		String ISql90MasterKey.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class MessageType : ISql90MessageType
	{		
		ValidationMethod ISql90MessageType.ValidationMethod 
		{
			get { return this.ValidationMethod;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90MessageType.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlSchemaCollection> ISql90MessageType.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class PartitionFunction : ISql90PartitionFunction
	{		
		PartitionRange ISql90PartitionFunction.Range 
		{
			get { return this.Range;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionValue> ISql90PartitionFunction.BoundaryValues 
		{
			get 
			{
				return this.BoundaryValues;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql90PartitionFunction.ParameterType 
		{
			get 
			{
				return this.ParameterType;
			}
		}
	}
	public partial class PartitionScheme : ISql90PartitionScheme
	{		
		Boolean ISql90PartitionScheme.AllToOneFilegroup 
		{
			get { return this.AllToOneFilegroup;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90PartitionScheme.Filegroups 
		{
			get 
			{
				return this.Filegroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionFunction> ISql90PartitionScheme.PartitionFunction 
		{
			get 
			{
				return this.PartitionFunction;
			}
		}
	}
	public partial class PartitionValue : ISql90PartitionValue
	{		
		String ISql90PartitionValue.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90PartitionValue.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class Permission : ISql90Permission
	{		
		PermissionAction ISql90Permission.PermissionAction 
		{
			get { return this.PermissionAction;}
		}
		PermissionType ISql90Permission.PermissionType 
		{
			get { return this.PermissionType;}
		}
		Boolean ISql90Permission.WithAllPrivileges 
		{
			get { return this.WithAllPrivileges;}
		}
		Boolean ISql90Permission.WithGrantOption 
		{
			get { return this.WithGrantOption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Permission.ExcludedColumns 
		{
			get 
			{
				return this.ExcludedColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql90Permission.Grantee 
		{
			get 
			{
				return this.Grantee;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql90Permission.Grantor 
		{
			get 
			{
				return this.Grantor;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Permission.RevokedGrantOptionColumns 
		{
			get 
			{
				return this.RevokedGrantOptionColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql90Permission.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class PrimaryKeyConstraint : ISql90PrimaryKeyConstraint
	{		
		Boolean ISql90PrimaryKeyConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql90PrimaryKeyConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql90PrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql90PrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql90PrimaryKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql90PrimaryKeyConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql90PrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql90PrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql90PrimaryKeyConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql90PrimaryKeyConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90PrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90PrimaryKeyConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> ISql90PrimaryKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90PrimaryKeyConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90PrimaryKeyConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Procedure : ISql90Procedure
	{		
		Boolean? ISql90Procedure.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql90Procedure.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql90Procedure.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql90Procedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90Procedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql90Procedure.ForReplication 
		{
			get { return this.ForReplication;}
		}
		Boolean ISql90Procedure.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql90Procedure.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql90Procedure.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90Procedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql90Procedure.WithRecompile 
		{
			get { return this.WithRecompile;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90Procedure.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90Procedure.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90Procedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> ISql90Procedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Procedure> ISql90Procedure.ParentProcedure 
		{
			get 
			{
				return this.ParentProcedure;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Procedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90Procedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Queue : ISql90Queue
	{		
		Boolean ISql90Queue.ActivationExecuteAsCaller 
		{
			get { return this.ActivationExecuteAsCaller;}
		}
		Boolean ISql90Queue.ActivationExecuteAsOwner 
		{
			get { return this.ActivationExecuteAsOwner;}
		}
		Boolean ISql90Queue.ActivationExecuteAsSelf 
		{
			get { return this.ActivationExecuteAsSelf;}
		}
		Int32? ISql90Queue.ActivationMaxQueueReaders 
		{
			get { return this.ActivationMaxQueueReaders;}
		}
		Boolean? ISql90Queue.ActivationStatusOn 
		{
			get { return this.ActivationStatusOn;}
		}
		Boolean ISql90Queue.RetentionOn 
		{
			get { return this.RetentionOn;}
		}
		Boolean ISql90Queue.StatusOn 
		{
			get { return this.StatusOn;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Procedure> ISql90Queue.ActivationProcedure 
		{
			get 
			{
				return this.ActivationProcedure;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Queue.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90Queue.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90Queue.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Queue.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90Queue.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Queue.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90Queue.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class QueueEventNotification : ISql90QueueEventNotification
	{		
		String ISql90QueueEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql90QueueEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql90QueueEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> ISql90QueueEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql90QueueEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Queue> ISql90QueueEventNotification.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class RemoteServiceBinding : ISql90RemoteServiceBinding
	{		
		Boolean ISql90RemoteServiceBinding.Anonymous 
		{
			get { return this.Anonymous;}
		}
		String ISql90RemoteServiceBinding.Service 
		{
			get { return this.Service;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90RemoteServiceBinding.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90RemoteServiceBinding.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ResourceGovernor : ISql90ResourceGovernor
	{		
	}
	public partial class ResourcePool : ISql90ResourcePool
	{		
	}
	public partial class Role : ISql90Role
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Role.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class RoleMembership : ISql90RoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql90RoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Role> ISql90RoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Route : ISql90Route
	{		
		String ISql90Route.Address 
		{
			get { return this.Address;}
		}
		String ISql90Route.BrokerInstance 
		{
			get { return this.BrokerInstance;}
		}
		Int32? ISql90Route.Lifetime 
		{
			get { return this.Lifetime;}
		}
		String ISql90Route.MirrorAddress 
		{
			get { return this.MirrorAddress;}
		}
		String ISql90Route.ServiceName 
		{
			get { return this.ServiceName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Route.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Rule : ISql90Rule
	{		
		String ISql90Rule.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90Rule.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Rule.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Schema : ISql90Schema
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Schema.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class SearchProperty : ISql90SearchProperty
	{		
	}
	public partial class SearchPropertyList : ISql90SearchPropertyList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90SearchPropertyList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Sequence : ISql90Sequence
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Sequence.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ServerAudit : ISql90ServerAudit
	{		
	}
	public partial class ServerAuditSpecification : ISql90ServerAuditSpecification
	{		
	}
	public partial class ServerDdlTrigger : ISql90ServerDdlTrigger
	{		
		Boolean? ISql90ServerDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql90ServerDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql90ServerDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql90ServerDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql90ServerDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql90ServerDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql90ServerDdlTrigger.IsLogon 
		{
			get { return this.IsLogon;}
		}
		String ISql90ServerDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql90ServerDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql90ServerDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql90ServerDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90ServerDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90ServerDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> ISql90ServerDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql90ServerDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90ServerDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> ISql90ServerDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ServerEventNotification : ISql90ServerEventNotification
	{		
		String ISql90ServerEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql90ServerEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql90ServerEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> ISql90ServerEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql90ServerEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class ServerOptions : ISql90ServerOptions
	{		
	}
	public partial class ServerRoleMembership : ISql90ServerRoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> ISql90ServerRoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Role> ISql90ServerRoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Service : ISql90Service
	{		
		Boolean ISql90Service.UseDefaultContract 
		{
			get { return this.UseDefaultContract;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90Service.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Contract> ISql90Service.Contracts 
		{
			get 
			{
				return this.Contracts;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Queue> ISql90Service.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class ServiceBrokerLanguageSpecifier : ISql90ServiceBrokerLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql90ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql90ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql90ServiceBrokerLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		Boolean ISql90ServiceBrokerLanguageSpecifier.MessageForwardingEnabled 
		{
			get { return this.MessageForwardingEnabled;}
		}
		Int32 ISql90ServiceBrokerLanguageSpecifier.MessageForwardSize 
		{
			get { return this.MessageForwardSize;}
		}
		Boolean ISql90ServiceBrokerLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql90ServiceBrokerLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> ISql90ServiceBrokerLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class Signature : ISql90Signature
	{		
		Boolean ISql90Signature.IsCounterSignature 
		{
			get { return this.IsCounterSignature;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql90Signature.EncryptionMechanism 
		{
			get 
			{
				return this.EncryptionMechanism;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql90Signature.SignedObject 
		{
			get 
			{
				return this.SignedObject;
			}
		}
	}
	public partial class SignatureEncryptionMechanism : ISql90SignatureEncryptionMechanism
	{		
		String ISql90SignatureEncryptionMechanism.Password 
		{
			get { return this.Password;}
		}
		String ISql90SignatureEncryptionMechanism.SignedBlob 
		{
			get { return this.SignedBlob;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> ISql90SignatureEncryptionMechanism.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> ISql90SignatureEncryptionMechanism.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class SoapLanguageSpecifier : ISql90SoapLanguageSpecifier
	{		
		Boolean ISql90SoapLanguageSpecifier.BatchesEnabled 
		{
			get { return this.BatchesEnabled;}
		}
		CharacterSet ISql90SoapLanguageSpecifier.CharacterSet 
		{
			get { return this.CharacterSet;}
		}
		String ISql90SoapLanguageSpecifier.DatabaseName 
		{
			get { return this.DatabaseName;}
		}
		Int32 ISql90SoapLanguageSpecifier.HeaderLimit 
		{
			get { return this.HeaderLimit;}
		}
		Boolean ISql90SoapLanguageSpecifier.IsDefaultDatabase 
		{
			get { return this.IsDefaultDatabase;}
		}
		Boolean ISql90SoapLanguageSpecifier.IsDefaultNamespace 
		{
			get { return this.IsDefaultNamespace;}
		}
		Boolean ISql90SoapLanguageSpecifier.IsDefaultWsdlSpName 
		{
			get { return this.IsDefaultWsdlSpName;}
		}
		SoapLoginType ISql90SoapLanguageSpecifier.LoginType 
		{
			get { return this.LoginType;}
		}
		String ISql90SoapLanguageSpecifier.Namespace 
		{
			get { return this.Namespace;}
		}
		SoapSchema ISql90SoapLanguageSpecifier.SchemaType 
		{
			get { return this.SchemaType;}
		}
		Boolean ISql90SoapLanguageSpecifier.SessionsEnabled 
		{
			get { return this.SessionsEnabled;}
		}
		Int32 ISql90SoapLanguageSpecifier.SessionTimeout 
		{
			get { return this.SessionTimeout;}
		}
		Boolean ISql90SoapLanguageSpecifier.SessionTimeoutNever 
		{
			get { return this.SessionTimeoutNever;}
		}
		String ISql90SoapLanguageSpecifier.WsdlSpName 
		{
			get { return this.WsdlSpName;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90SoapMethodSpecification> ISql90SoapLanguageSpecifier.WebMethods 
		{
			get 
			{
				return this.WebMethods;
			}
		}
	}
	public partial class SoapMethodSpecification : ISql90SoapMethodSpecification
	{		
		SoapFormat ISql90SoapMethodSpecification.Format 
		{
			get { return this.Format;}
		}
		SoapSchema ISql90SoapMethodSpecification.SchemaType 
		{
			get { return this.SchemaType;}
		}
		String ISql90SoapMethodSpecification.WebMethodAlias 
		{
			get { return this.WebMethodAlias;}
		}
		String ISql90SoapMethodSpecification.WebMethodNamespace 
		{
			get { return this.WebMethodNamespace;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90SoapMethodSpecification.RelatedMethod 
		{
			get 
			{
				return this.RelatedMethod;
			}
		}
	}
	public partial class SpatialIndex : ISql90SpatialIndex
	{		
		Boolean ISql90SpatialIndex.Disabled 
		{
			get { return this.Disabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90SpatialIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90SpatialIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90SpatialIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Statistics : ISql90Statistics
	{		
		Boolean ISql90Statistics.NoRecompute 
		{
			get { return this.NoRecompute;}
		}
		Int32 ISql90Statistics.SampleSize 
		{
			get { return this.SampleSize;}
		}
		SamplingStyle ISql90Statistics.SamplingStyle 
		{
			get { return this.SamplingStyle;}
		}
		String ISql90Statistics.StatsStream 
		{
			get { return this.StatsStream;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Statistics.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql90Statistics.OnObject 
		{
			get 
			{
				return this.OnObject;
			}
		}
	}
	public partial class Parameter : ISql90Parameter
	{		
		String ISql90Parameter.DefaultExpression 
		{
			get { return this.DefaultExpression;}
		}
		Boolean ISql90Parameter.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql90Parameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		Int32 ISql90Parameter.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql90Parameter.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql90Parameter.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql90Parameter.Varying 
		{
			get { return this.Varying;}
		}
		XmlStyle ISql90Parameter.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90DataType> ISql90Parameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlSchemaCollection> ISql90Parameter.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class SymmetricKey : ISql90SymmetricKey
	{		
		SymmetricKeyAlgorithm ISql90SymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		String ISql90SymmetricKey.IdentityValue 
		{
			get { return this.IdentityValue;}
		}
		String ISql90SymmetricKey.KeySource 
		{
			get { return this.KeySource;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> ISql90SymmetricKey.AsymmetricKeys 
		{
			get 
			{
				return this.AsymmetricKeys;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90SymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> ISql90SymmetricKey.Certificates 
		{
			get 
			{
				return this.Certificates;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql90SymmetricKey.Passwords 
		{
			get 
			{
				return this.Passwords;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90SymmetricKey> ISql90SymmetricKey.SymmetricKeys 
		{
			get 
			{
				return this.SymmetricKeys;
			}
		}
	}
	public partial class SymmetricKeyPassword : ISql90SymmetricKeyPassword
	{		
		String ISql90SymmetricKeyPassword.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class Synonym : ISql90Synonym
	{		
		String ISql90Synonym.ForObjectName 
		{
			get { return this.ForObjectName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90Synonym.ForObject 
		{
			get 
			{
				return this.ForObject;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Synonym.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Table : ISql90Table
	{		
		Boolean? ISql90Table.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql90Table.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		Boolean ISql90Table.LargeValueTypesOutOfRow 
		{
			get { return this.LargeValueTypesOutOfRow;}
		}
		Boolean? ISql90Table.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90Table.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}
		Int32 ISql90Table.TextInRowSize 
		{
			get { return this.TextInRowSize;}
		}
		Boolean ISql90Table.VardecimalStorageFormatEnabled 
		{
			get { return this.VardecimalStorageFormatEnabled;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Table.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90Table.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90Table.FilegroupForTextImage 
		{
			get 
			{
				return this.FilegroupForTextImage;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90Table.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90Table.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90Table.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class FileTable : ISql90FileTable
	{		
		Boolean? ISql90FileTable.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql90FileTable.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90FileTable.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90FileTable.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90FileTable.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90FileTable.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90FileTable.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90FileTable.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableType : ISql90TableType
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90TableType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableTypeCheckConstraint : ISql90TableTypeCheckConstraint
	{		
	}
	public partial class TableTypeColumn : ISql90TableTypeColumn
	{		
		Boolean ISql90TableTypeColumn.IsMax 
		{
			get { return this.IsMax;}
		}
		Int32 ISql90TableTypeColumn.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql90TableTypeColumn.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql90TableTypeColumn.Scale 
		{
			get { return this.Scale;}
		}
		XmlStyle ISql90TableTypeColumn.XmlStyle 
		{
			get { return this.XmlStyle;}
		}
	}
	public partial class TableTypeDefaultConstraint : ISql90TableTypeDefaultConstraint
	{		
	}
	public partial class TableTypeIndex : ISql90TableTypeIndex
	{		
		Int32? ISql90TableTypeIndex.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql90TableTypeIndex.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql90TableTypeIndex.IsDisabled 
		{
			get { return this.IsDisabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90TableTypeIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypePrimaryKeyConstraint : ISql90TableTypePrimaryKeyConstraint
	{		
		Int32? ISql90TableTypePrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql90TableTypePrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
	}
	public partial class TableTypeUniqueConstraint : ISql90TableTypeUniqueConstraint
	{		
	}
	public partial class TcpProtocolSpecifier : ISql90TcpProtocolSpecifier
	{		
		String ISql90TcpProtocolSpecifier.ListenerIPv4 
		{
			get { return this.ListenerIPv4;}
		}
		String ISql90TcpProtocolSpecifier.ListenerIPv6 
		{
			get { return this.ListenerIPv6;}
		}
		Int32 ISql90TcpProtocolSpecifier.ListenerPort 
		{
			get { return this.ListenerPort;}
		}
		Boolean ISql90TcpProtocolSpecifier.ListeningOnAllIPs 
		{
			get { return this.ListeningOnAllIPs;}
		}
	}
	public partial class UniqueConstraint : ISql90UniqueConstraint
	{		
		Boolean ISql90UniqueConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql90UniqueConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql90UniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql90UniqueConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql90UniqueConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql90UniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql90UniqueConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql90UniqueConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90UniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> ISql90UniqueConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> ISql90UniqueConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90UniqueConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> ISql90UniqueConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class User : ISql90User
	{		
		Boolean ISql90User.WithoutLogin 
		{
			get { return this.WithoutLogin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> ISql90User.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> ISql90User.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90User.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> ISql90User.Login 
		{
			get 
			{
				return this.Login;
			}
		}
	}
	public partial class UserDefinedServerRole : ISql90UserDefinedServerRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql90UserDefinedServerRole.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class UserDefinedType : ISql90UserDefinedType
	{		
		Boolean? ISql90UserDefinedType.ByteOrdered 
		{
			get { return this.ByteOrdered;}
		}
		String ISql90UserDefinedType.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean? ISql90UserDefinedType.FixedLength 
		{
			get { return this.FixedLength;}
		}
		Format ISql90UserDefinedType.Format 
		{
			get { return this.Format;}
		}
		Int32? ISql90UserDefinedType.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		String ISql90UserDefinedType.ValidationMethodName 
		{
			get { return this.ValidationMethodName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ISql90UserDefinedType.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql90UserDefinedType.Methods 
		{
			get 
			{
				return this.Methods;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql90UserDefinedType.Properties 
		{
			get 
			{
				return this.Properties;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90UserDefinedType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class View : ISql90View
	{		
		Boolean? ISql90View.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql90View.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql90View.Replicated 
		{
			get { return this.Replicated;}
		}
		String ISql90View.SelectStatement 
		{
			get { return this.SelectStatement;}
		}
		Boolean ISql90View.WithCheckOption 
		{
			get { return this.WithCheckOption;}
		}
		Boolean ISql90View.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql90View.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}
		Boolean ISql90View.WithViewMetadata 
		{
			get { return this.WithViewMetadata;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql90View.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90View.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90View.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class WorkloadGroup : ISql90WorkloadGroup
	{		
	}
	public partial class XmlIndex : ISql90XmlIndex
	{		
		Boolean ISql90XmlIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql90XmlIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql90XmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql90XmlIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql90XmlIndex.IsPrimary 
		{
			get { return this.IsPrimary;}
		}
		Boolean ISql90XmlIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		SecondaryXmlIndexType ISql90XmlIndex.SecondaryXmlIndexType 
		{
			get { return this.SecondaryXmlIndexType;}
		}
		Boolean ISql90XmlIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ISql90XmlIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql90XmlIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlIndex> ISql90XmlIndex.PrimaryXmlIndex 
		{
			get 
			{
				return this.PrimaryXmlIndex;
			}
		}
	}
	public partial class SelectiveXmlIndex : ISql90SelectiveXmlIndex
	{		
		Boolean ISql90SelectiveXmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
	}
	public partial class XmlNamespace : ISql90XmlNamespace
	{		
	}
	public partial class PromotedNodePathForXQueryType : ISql90PromotedNodePathForXQueryType
	{		
	}
	public partial class PromotedNodePathForSqlType : ISql90PromotedNodePathForSqlType
	{		
		Boolean ISql90PromotedNodePathForSqlType.IsMax 
		{
			get { return this.IsMax;}
		}
		Int32 ISql90PromotedNodePathForSqlType.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql90PromotedNodePathForSqlType.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql90PromotedNodePathForSqlType.Scale 
		{
			get { return this.Scale;}
		}
	}
	public partial class XmlSchemaCollection : ISql90XmlSchemaCollection
	{		
		String ISql90XmlSchemaCollection.Expression 
		{
			get { return this.Expression;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> ISql90XmlSchemaCollection.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Column : ISql100Column
	{		
		String ISql100Column.Collation 
		{
			get { return this.Collation;}
		}
		String ISql100Column.Expression 
		{
			get { return this.Expression;}
		}
		String ISql100Column.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql100Column.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql100Column.IsFileStream 
		{
			get { return this.IsFileStream;}
		}
		Boolean ISql100Column.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql100Column.IsIdentityNotForReplication 
		{
			get { return this.IsIdentityNotForReplication;}
		}
		Boolean ISql100Column.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql100Column.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql100Column.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql100Column.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql100Column.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql100Column.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql100Column.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql100Column.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql100Column.Sparse 
		{
			get { return this.Sparse;}
		}
		XmlStyle ISql100Column.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> ISql100Column.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Column.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> ISql100Column.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableValuedFunction : ISql100TableValuedFunction
	{		
		Boolean? ISql100TableValuedFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql100TableValuedFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql100TableValuedFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql100TableValuedFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql100TableValuedFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql100TableValuedFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql100TableValuedFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100TableValuedFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql100TableValuedFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql100TableValuedFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql100TableValuedFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql100TableValuedFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql100TableValuedFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100TableValuedFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		String ISql100TableValuedFunction.ReturnTableVariableName 
		{
			get { return this.ReturnTableVariableName;}
		}
		SystemDataAccessKind? ISql100TableValuedFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql100TableValuedFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql100TableValuedFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100TableValuedFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100TableValuedFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100TableValuedFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100TableValuedFunction.OrderColumns 
		{
			get 
			{
				return this.OrderColumns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> ISql100TableValuedFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql100TableValuedFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100TableValuedFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100TableValuedFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ScalarFunction : ISql100ScalarFunction
	{		
		Boolean? ISql100ScalarFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql100ScalarFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql100ScalarFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql100ScalarFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql100ScalarFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql100ScalarFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql100ScalarFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100ScalarFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql100ScalarFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql100ScalarFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql100ScalarFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql100ScalarFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql100ScalarFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100ScalarFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		SystemDataAccessKind? ISql100ScalarFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql100ScalarFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql100ScalarFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100ScalarFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100ScalarFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100ScalarFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> ISql100ScalarFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql100ScalarFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100ScalarFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100ScalarFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Aggregate : ISql100Aggregate
	{		
		String ISql100Aggregate.ClassName 
		{
			get { return this.ClassName;}
		}
		Format ISql100Aggregate.Format 
		{
			get { return this.Format;}
		}
		Boolean? ISql100Aggregate.InvariantToDuplicates 
		{
			get { return this.InvariantToDuplicates;}
		}
		Boolean? ISql100Aggregate.InvariantToNulls 
		{
			get { return this.InvariantToNulls;}
		}
		Int32? ISql100Aggregate.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		Boolean? ISql100Aggregate.NullIfEmpty 
		{
			get { return this.NullIfEmpty;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100Aggregate.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> ISql100Aggregate.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql100Aggregate.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Aggregate.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ApplicationRole : ISql100ApplicationRole
	{		
		String ISql100ApplicationRole.Password 
		{
			get { return this.Password;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100ApplicationRole.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}
	}
	public partial class Index : ISql100Index
	{		
		Boolean ISql100Index.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql100Index.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql100Index.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql100Index.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql100Index.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql100Index.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql100Index.FillFactor 
		{
			get { return this.FillFactor;}
		}
		String ISql100Index.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISql100Index.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql100Index.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql100Index.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql100Index.Unique 
		{
			get { return this.Unique;}
		}
		Boolean ISql100Index.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Index.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Index.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> ISql100Index.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100Index.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100Index.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100Index.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Index.IncludedColumns 
		{
			get 
			{
				return this.IncludedColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql100Index.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Index.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100Index.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Assembly : ISql100Assembly
	{		
		AssemblyPermissionSet ISql100Assembly.PermissionSet 
		{
			get { return this.PermissionSet;}
		}
		Boolean ISql100Assembly.Visible 
		{
			get { return this.Visible;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AssemblySource> ISql100Assembly.AssemblySources 
		{
			get 
			{
				return this.AssemblySources;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Assembly.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100Assembly.ReferencedAssemblies 
		{
			get 
			{
				return this.ReferencedAssemblies;
			}
		}
	}
	public partial class AssemblySource : ISql100AssemblySource
	{		
		String ISql100AssemblySource.Source 
		{
			get { return this.Source;}
		}
	}
	public partial class AsymmetricKey : ISql100AsymmetricKey
	{		
		AsymmetricKeyAlgorithm ISql100AsymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		SymmetricKeyCreationDisposition ISql100AsymmetricKey.CreationDisposition 
		{
			get { return this.CreationDisposition;}
		}
		Boolean ISql100AsymmetricKey.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql100AsymmetricKey.ExecutableFile 
		{
			get { return this.ExecutableFile;}
		}
		String ISql100AsymmetricKey.File 
		{
			get { return this.File;}
		}
		String ISql100AsymmetricKey.Password 
		{
			get { return this.Password;}
		}
		String ISql100AsymmetricKey.ProviderKeyName 
		{
			get { return this.ProviderKeyName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100AsymmetricKey.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100AsymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100AsymmetricKey.Provider 
		{
			get 
			{
				return this.Provider;
			}
		}
	}
	public partial class AuditAction : ISql100AuditAction
	{		
		DatabaseAuditAction ISql100AuditAction.Action 
		{
			get { return this.Action;}
		}
	}
	public partial class AuditActionGroup : ISql100AuditActionGroup
	{		
		AuditActionGroupType ISql100AuditActionGroup.ActionGroup 
		{
			get { return this.ActionGroup;}
		}
	}
	public partial class AuditActionSpecification : ISql100AuditActionSpecification
	{		

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditAction> ISql100AuditActionSpecification.AuditActions 
		{
			get 
			{
				return this.AuditActions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql100AuditActionSpecification.Principals 
		{
			get 
			{
				return this.Principals;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql100AuditActionSpecification.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class BrokerPriority : ISql100BrokerPriority
	{		
		Int32 ISql100BrokerPriority.PriorityLevel 
		{
			get { return this.PriorityLevel;}
		}
		String ISql100BrokerPriority.RemoteServiceName 
		{
			get { return this.RemoteServiceName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100BrokerPriority.ContractName 
		{
			get 
			{
				return this.ContractName;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100BrokerPriority.LocalServiceName 
		{
			get 
			{
				return this.LocalServiceName;
			}
		}
	}
	public partial class BuiltInServerRole : ISql100BuiltInServerRole
	{		
	}
	public partial class DataType : ISql100DataType
	{		
		SqlDataType ISql100DataType.SqlDataType 
		{
			get { return this.SqlDataType;}
		}
		Boolean ISql100DataType.UddtIsMax 
		{
			get { return this.UddtIsMax;}
		}
		Int32 ISql100DataType.UddtLength 
		{
			get { return this.UddtLength;}
		}
		Boolean ISql100DataType.UddtNullable 
		{
			get { return this.UddtNullable;}
		}
		Int32 ISql100DataType.UddtPrecision 
		{
			get { return this.UddtPrecision;}
		}
		Int32 ISql100DataType.UddtScale 
		{
			get { return this.UddtScale;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100DataType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<System.Type> ISql100DataType.Type 
		{
			get 
			{
				return this.Type;
			}
		}
	}
	public partial class Certificate : ISql100Certificate
	{		
		Boolean ISql100Certificate.ActiveForBeginDialog 
		{
			get { return this.ActiveForBeginDialog;}
		}
		Boolean ISql100Certificate.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql100Certificate.EncryptionPassword 
		{
			get { return this.EncryptionPassword;}
		}
		String ISql100Certificate.ExistingKeysFilePath 
		{
			get { return this.ExistingKeysFilePath;}
		}
		String ISql100Certificate.ExpiryDate 
		{
			get { return this.ExpiryDate;}
		}
		Boolean ISql100Certificate.IsExistingKeyFileExecutable 
		{
			get { return this.IsExistingKeyFileExecutable;}
		}
		String ISql100Certificate.PrivateKeyDecryptionPassword 
		{
			get { return this.PrivateKeyDecryptionPassword;}
		}
		String ISql100Certificate.PrivateKeyEncryptionPassword 
		{
			get { return this.PrivateKeyEncryptionPassword;}
		}
		String ISql100Certificate.PrivateKeyFilePath 
		{
			get { return this.PrivateKeyFilePath;}
		}
		String ISql100Certificate.StartDate 
		{
			get { return this.StartDate;}
		}
		String ISql100Certificate.Subject 
		{
			get { return this.Subject;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Certificate.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100Certificate.ExistingKeysAssembly 
		{
			get 
			{
				return this.ExistingKeysAssembly;
			}
		}
	}
	public partial class CheckConstraint : ISql100CheckConstraint
	{		
		Boolean ISql100CheckConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql100CheckConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql100CheckConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100CheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> ISql100CheckConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class ClrTypeMethod : ISql100ClrTypeMethod
	{		
		String ISql100ClrTypeMethod.Name 
		{
			get { return this.Name;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> ISql100ClrTypeMethod.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql100ClrTypeMethod.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}
	}
	public partial class ClrTypeMethodParameter : ISql100ClrTypeMethodParameter
	{		
		Boolean ISql100ClrTypeMethodParameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		String ISql100ClrTypeMethodParameter.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> ISql100ClrTypeMethodParameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class ClrTypeProperty : ISql100ClrTypeProperty
	{		
		String ISql100ClrTypeProperty.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql100ClrTypeProperty.ClrType 
		{
			get 
			{
				return this.ClrType;
			}
		}
	}
	public partial class ColumnStoreIndex : ISql100ColumnStoreIndex
	{		
		Boolean ISql100ColumnStoreIndex.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql100ColumnStoreIndex.Disabled 
		{
			get { return this.Disabled;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> ISql100ColumnStoreIndex.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100ColumnStoreIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql100ColumnStoreIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100ColumnStoreIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100ColumnStoreIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Contract : ISql100Contract
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Contract.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100MessageType> ISql100Contract.Messages 
		{
			get 
			{
				return this.Messages;
			}
		}
	}
	public partial class Credential : ISql100Credential
	{		
		String ISql100Credential.Identity 
		{
			get { return this.Identity;}
		}
		String ISql100Credential.Secret 
		{
			get { return this.Secret;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100CryptographicProvider> ISql100Credential.CryptographicProvider 
		{
			get 
			{
				return this.CryptographicProvider;
			}
		}
	}
	public partial class CryptographicProvider : ISql100CryptographicProvider
	{		
		String ISql100CryptographicProvider.DllPath 
		{
			get { return this.DllPath;}
		}
		Boolean ISql100CryptographicProvider.Enabled 
		{
			get { return this.Enabled;}
		}
	}
	public partial class DatabaseAuditSpecification : ISql100DatabaseAuditSpecification
	{		
		Boolean ISql100DatabaseAuditSpecification.WithState 
		{
			get { return this.WithState;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditActionGroup> ISql100DatabaseAuditSpecification.AuditActionGroups 
		{
			get 
			{
				return this.AuditActionGroups;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditAction> ISql100DatabaseAuditSpecification.AuditActions 
		{
			get 
			{
				return this.AuditActions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ServerAudit> ISql100DatabaseAuditSpecification.ServerAudit 
		{
			get 
			{
				return this.ServerAudit;
			}
		}
	}
	public partial class DatabaseDdlTrigger : ISql100DatabaseDdlTrigger
	{		
		Boolean? ISql100DatabaseDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql100DatabaseDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql100DatabaseDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql100DatabaseDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql100DatabaseDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100DatabaseDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql100DatabaseDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql100DatabaseDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql100DatabaseDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql100DatabaseDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100DatabaseDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100DatabaseDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> ISql100DatabaseDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql100DatabaseDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100DatabaseDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100DatabaseDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class DatabaseEncryptionKey : ISql100DatabaseEncryptionKey
	{		
		SymmetricKeyAlgorithm ISql100DatabaseEncryptionKey.Algorithm 
		{
			get { return this.Algorithm;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> ISql100DatabaseEncryptionKey.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100DatabaseEncryptionKey.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class DatabaseEventNotification : ISql100DatabaseEventNotification
	{		
		String ISql100DatabaseEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql100DatabaseEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql100DatabaseEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> ISql100DatabaseEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql100DatabaseEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class DatabaseMirroringLanguageSpecifier : ISql100DatabaseMirroringLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql100DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql100DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql100DatabaseMirroringLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		DatabaseMirroringRole ISql100DatabaseMirroringLanguageSpecifier.RoleType 
		{
			get { return this.RoleType;}
		}
		Boolean ISql100DatabaseMirroringLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql100DatabaseMirroringLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100DatabaseMirroringLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class DatabaseOptions : ISql100DatabaseOptions
	{		
		Boolean ISql100DatabaseOptions.AllowSnapshotIsolation 
		{
			get { return this.AllowSnapshotIsolation;}
		}
		Boolean ISql100DatabaseOptions.AnsiNullDefaultOn 
		{
			get { return this.AnsiNullDefaultOn;}
		}
		Boolean ISql100DatabaseOptions.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql100DatabaseOptions.AnsiPaddingOn 
		{
			get { return this.AnsiPaddingOn;}
		}
		Boolean ISql100DatabaseOptions.AnsiWarningsOn 
		{
			get { return this.AnsiWarningsOn;}
		}
		Boolean ISql100DatabaseOptions.ArithAbortOn 
		{
			get { return this.ArithAbortOn;}
		}
		Boolean ISql100DatabaseOptions.AutoClose 
		{
			get { return this.AutoClose;}
		}
		Boolean ISql100DatabaseOptions.AutoCreateStatistics 
		{
			get { return this.AutoCreateStatistics;}
		}
		Boolean ISql100DatabaseOptions.AutoShrink 
		{
			get { return this.AutoShrink;}
		}
		Boolean ISql100DatabaseOptions.AutoUpdateStatistics 
		{
			get { return this.AutoUpdateStatistics;}
		}
		Boolean ISql100DatabaseOptions.AutoUpdateStatisticsAsync 
		{
			get { return this.AutoUpdateStatisticsAsync;}
		}
		Boolean ISql100DatabaseOptions.ChangeTrackingAutoCleanup 
		{
			get { return this.ChangeTrackingAutoCleanup;}
		}
		Boolean ISql100DatabaseOptions.ChangeTrackingEnabled 
		{
			get { return this.ChangeTrackingEnabled;}
		}
		Int32 ISql100DatabaseOptions.ChangeTrackingRetentionPeriod 
		{
			get { return this.ChangeTrackingRetentionPeriod;}
		}
		TimeUnit ISql100DatabaseOptions.ChangeTrackingRetentionUnit 
		{
			get { return this.ChangeTrackingRetentionUnit;}
		}
		String ISql100DatabaseOptions.Collation 
		{
			get { return this.Collation;}
		}
		Int32 ISql100DatabaseOptions.CompatibilityLevel 
		{
			get { return this.CompatibilityLevel;}
		}
		Boolean ISql100DatabaseOptions.ConcatNullYieldsNull 
		{
			get { return this.ConcatNullYieldsNull;}
		}
		Boolean ISql100DatabaseOptions.CursorCloseOnCommit 
		{
			get { return this.CursorCloseOnCommit;}
		}
		Boolean ISql100DatabaseOptions.CursorDefaultGlobalScope 
		{
			get { return this.CursorDefaultGlobalScope;}
		}
		Boolean ISql100DatabaseOptions.DatabaseStateOffline 
		{
			get { return this.DatabaseStateOffline;}
		}
		Boolean ISql100DatabaseOptions.DateCorrelationOptimizationOn 
		{
			get { return this.DateCorrelationOptimizationOn;}
		}
		Boolean ISql100DatabaseOptions.DBChainingOn 
		{
			get { return this.DBChainingOn;}
		}
		Boolean ISql100DatabaseOptions.FullTextEnabled 
		{
			get { return this.FullTextEnabled;}
		}
		Boolean ISql100DatabaseOptions.HonorBrokerPriority 
		{
			get { return this.HonorBrokerPriority;}
		}
		Boolean ISql100DatabaseOptions.MemoryOptimizedElevateToSnapshot 
		{
			get { return this.MemoryOptimizedElevateToSnapshot;}
		}
		Boolean ISql100DatabaseOptions.NumericRoundAbortOn 
		{
			get { return this.NumericRoundAbortOn;}
		}
		PageVerifyMode ISql100DatabaseOptions.PageVerifyMode 
		{
			get { return this.PageVerifyMode;}
		}
		ParameterizationOption ISql100DatabaseOptions.ParameterizationOption 
		{
			get { return this.ParameterizationOption;}
		}
		Boolean ISql100DatabaseOptions.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100DatabaseOptions.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		RecoveryMode ISql100DatabaseOptions.RecoveryMode 
		{
			get { return this.RecoveryMode;}
		}
		Boolean ISql100DatabaseOptions.RecursiveTriggersOn 
		{
			get { return this.RecursiveTriggersOn;}
		}
		ServiceBrokerOption ISql100DatabaseOptions.ServiceBrokerOption 
		{
			get { return this.ServiceBrokerOption;}
		}
		Boolean ISql100DatabaseOptions.SupplementalLoggingOn 
		{
			get { return this.SupplementalLoggingOn;}
		}
		Boolean ISql100DatabaseOptions.TornPageProtectionOn 
		{
			get { return this.TornPageProtectionOn;}
		}
		Boolean ISql100DatabaseOptions.TransactionIsolationReadCommittedSnapshot 
		{
			get { return this.TransactionIsolationReadCommittedSnapshot;}
		}
		Boolean ISql100DatabaseOptions.Trustworthy 
		{
			get { return this.Trustworthy;}
		}
		UserAccessOption ISql100DatabaseOptions.UserAccessOption 
		{
			get { return this.UserAccessOption;}
		}
		Boolean ISql100DatabaseOptions.VardecimalStorageFormatOn 
		{
			get { return this.VardecimalStorageFormatOn;}
		}
		Boolean ISql100DatabaseOptions.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100DatabaseOptions.DefaultFilegroup 
		{
			get 
			{
				return this.DefaultFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100DatabaseOptions.DefaultFileStreamFilegroup 
		{
			get 
			{
				return this.DefaultFileStreamFilegroup;
			}
		}
	}
	public partial class DataCompressionOption : ISql100DataCompressionOption
	{		
		CompressionLevel ISql100DataCompressionOption.CompressionLevel 
		{
			get { return this.CompressionLevel;}
		}
		Int32 ISql100DataCompressionOption.PartitionNumber 
		{
			get { return this.PartitionNumber;}
		}
	}
	public partial class Default : ISql100Default
	{		
		String ISql100Default.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Default.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Default.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class DefaultConstraint : ISql100DefaultConstraint
	{		
		Boolean ISql100DefaultConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql100DefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql100DefaultConstraint.WithValues 
		{
			get { return this.WithValues;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100DefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> ISql100DefaultConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100DefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class DmlTrigger : ISql100DmlTrigger
	{		
		Boolean? ISql100DmlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql100DmlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		OrderRestriction ISql100DmlTrigger.DeleteOrderRestriction 
		{
			get { return this.DeleteOrderRestriction;}
		}
		Boolean ISql100DmlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql100DmlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql100DmlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100DmlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		OrderRestriction ISql100DmlTrigger.InsertOrderRestriction 
		{
			get { return this.InsertOrderRestriction;}
		}
		Boolean ISql100DmlTrigger.IsDeleteTrigger 
		{
			get { return this.IsDeleteTrigger;}
		}
		Boolean ISql100DmlTrigger.IsInsertTrigger 
		{
			get { return this.IsInsertTrigger;}
		}
		Boolean ISql100DmlTrigger.IsUpdateTrigger 
		{
			get { return this.IsUpdateTrigger;}
		}
		String ISql100DmlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean ISql100DmlTrigger.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		Boolean? ISql100DmlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql100DmlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		OrderRestriction ISql100DmlTrigger.UpdateOrderRestriction 
		{
			get { return this.UpdateOrderRestriction;}
		}
		Boolean ISql100DmlTrigger.WithAppend 
		{
			get { return this.WithAppend;}
		}
		Boolean ISql100DmlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100DmlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100DmlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100DmlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql100DmlTrigger.TriggerObject 
		{
			get 
			{
				return this.TriggerObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100DmlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Endpoint : ISql100Endpoint
	{		
		Payload ISql100Endpoint.Payload 
		{
			get { return this.Payload;}
		}
		Protocol ISql100Endpoint.Protocol 
		{
			get { return this.Protocol;}
		}
		State ISql100Endpoint.State 
		{
			get { return this.State;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Endpoint.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> ISql100Endpoint.PayloadSpecifier 
		{
			get 
			{
				return this.PayloadSpecifier;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ISql100Endpoint.ProtocolSpecifier 
		{
			get 
			{
				return this.ProtocolSpecifier;
			}
		}
	}
	public partial class ErrorMessage : ISql100ErrorMessage
	{		
		String ISql100ErrorMessage.Language 
		{
			get { return this.Language;}
		}
		Int32 ISql100ErrorMessage.MessageNumber 
		{
			get { return this.MessageNumber;}
		}
		String ISql100ErrorMessage.MessageText 
		{
			get { return this.MessageText;}
		}
		Int32 ISql100ErrorMessage.Severity 
		{
			get { return this.Severity;}
		}
		Boolean ISql100ErrorMessage.WithLog 
		{
			get { return this.WithLog;}
		}
	}
	public partial class EventGroup : ISql100EventGroup
	{		
		EventGroupType ISql100EventGroup.Group 
		{
			get { return this.Group;}
		}
	}
	public partial class EventSession : ISql100EventSession
	{		
		EventRetentionMode ISql100EventSession.EventRetentionMode 
		{
			get { return this.EventRetentionMode;}
		}
		Int32 ISql100EventSession.MaxDispatchLatency 
		{
			get { return this.MaxDispatchLatency;}
		}
		Int32 ISql100EventSession.MaxEventSize 
		{
			get { return this.MaxEventSize;}
		}
		MemoryUnit ISql100EventSession.MaxEventSizeUnit 
		{
			get { return this.MaxEventSizeUnit;}
		}
		Int32 ISql100EventSession.MaxMemory 
		{
			get { return this.MaxMemory;}
		}
		MemoryUnit ISql100EventSession.MaxMemoryUnit 
		{
			get { return this.MaxMemoryUnit;}
		}
		MemoryPartitionMode ISql100EventSession.MemoryPartitionMode 
		{
			get { return this.MemoryPartitionMode;}
		}
		Boolean ISql100EventSession.StartupState 
		{
			get { return this.StartupState;}
		}
		Boolean ISql100EventSession.TrackCausality 
		{
			get { return this.TrackCausality;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100EventSession.EventDefinitions 
		{
			get 
			{
				return this.EventDefinitions;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100EventSession.EventTargets 
		{
			get 
			{
				return this.EventTargets;
			}
		}
	}
	public partial class EventSessionAction : ISql100EventSessionAction
	{		
		String ISql100EventSessionAction.ActionName 
		{
			get { return this.ActionName;}
		}
		String ISql100EventSessionAction.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql100EventSessionAction.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
	}
	public partial class EventSessionDefinitions : ISql100EventSessionDefinitions
	{		
		String ISql100EventSessionDefinitions.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql100EventSessionDefinitions.EventName 
		{
			get { return this.EventName;}
		}
		String ISql100EventSessionDefinitions.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
		String ISql100EventSessionDefinitions.WhereExpression 
		{
			get { return this.WhereExpression;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventSessionAction> ISql100EventSessionDefinitions.Actions 
		{
			get 
			{
				return this.Actions;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100EventSessionDefinitions.AttributeSettings 
		{
			get 
			{
				return this.AttributeSettings;
			}
		}
	}
	public partial class EventSessionSetting : ISql100EventSessionSetting
	{		
		String ISql100EventSessionSetting.SettingName 
		{
			get { return this.SettingName;}
		}
		String ISql100EventSessionSetting.SettingValue 
		{
			get { return this.SettingValue;}
		}
	}
	public partial class EventSessionTarget : ISql100EventSessionTarget
	{		
		String ISql100EventSessionTarget.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql100EventSessionTarget.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
		String ISql100EventSessionTarget.TargetName 
		{
			get { return this.TargetName;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100EventSessionTarget.ParameterSettings 
		{
			get 
			{
				return this.ParameterSettings;
			}
		}
	}
	public partial class EventTypeSpecifier : ISql100EventTypeSpecifier
	{		
		EventType ISql100EventTypeSpecifier.EventType 
		{
			get { return this.EventType;}
		}
		OrderRestriction ISql100EventTypeSpecifier.Order 
		{
			get { return this.Order;}
		}
	}
	public partial class ExtendedProcedure : ISql100ExtendedProcedure
	{		
		Boolean ISql100ExtendedProcedure.ExeccuteAsCaller 
		{
			get { return this.ExeccuteAsCaller;}
		}
		Boolean ISql100ExtendedProcedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100ExtendedProcedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql100ExtendedProcedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100ExtendedProcedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> ISql100ExtendedProcedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100ExtendedProcedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100ExtendedProcedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ExtendedProperty : ISql100ExtendedProperty
	{		
		String ISql100ExtendedProperty.Value 
		{
			get { return this.Value;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> ISql100ExtendedProperty.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class SqlFile : ISql100SqlFile
	{		
		Int32? ISql100SqlFile.FileGrowth 
		{
			get { return this.FileGrowth;}
		}
		MemoryUnit ISql100SqlFile.FileGrowthUnit 
		{
			get { return this.FileGrowthUnit;}
		}
		String ISql100SqlFile.FileName 
		{
			get { return this.FileName;}
		}
		Boolean ISql100SqlFile.IsLogFile 
		{
			get { return this.IsLogFile;}
		}
		Int32? ISql100SqlFile.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql100SqlFile.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		Boolean ISql100SqlFile.Offline 
		{
			get { return this.Offline;}
		}
		Int32? ISql100SqlFile.Size 
		{
			get { return this.Size;}
		}
		MemoryUnit ISql100SqlFile.SizeUnit 
		{
			get { return this.SizeUnit;}
		}
		Boolean ISql100SqlFile.Unlimited 
		{
			get { return this.Unlimited;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100SqlFile.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class Filegroup : ISql100Filegroup
	{		
		Boolean ISql100Filegroup.ContainsFileStream 
		{
			get { return this.ContainsFileStream;}
		}
		Boolean ISql100Filegroup.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
	}
	public partial class ForeignKeyConstraint : ISql100ForeignKeyConstraint
	{		
		ForeignKeyAction ISql100ForeignKeyConstraint.DeleteAction 
		{
			get { return this.DeleteAction;}
		}
		Boolean ISql100ForeignKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql100ForeignKeyConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		ForeignKeyAction ISql100ForeignKeyConstraint.UpdateAction 
		{
			get { return this.UpdateAction;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100ForeignKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100ForeignKeyConstraint.ForeignColumns 
		{
			get 
			{
				return this.ForeignColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Table> ISql100ForeignKeyConstraint.ForeignTable 
		{
			get 
			{
				return this.ForeignTable;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> ISql100ForeignKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class FullTextCatalog : ISql100FullTextCatalog
	{		
		Boolean? ISql100FullTextCatalog.AccentSensitivity 
		{
			get { return this.AccentSensitivity;}
		}
		Boolean ISql100FullTextCatalog.IsDefault 
		{
			get { return this.IsDefault;}
		}
		String ISql100FullTextCatalog.Path 
		{
			get { return this.Path;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100FullTextCatalog.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100FullTextCatalog.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class FullTextIndex : ISql100FullTextIndex
	{		
		ChangeTrackingOption ISql100FullTextIndex.ChangeTracking 
		{
			get { return this.ChangeTracking;}
		}
		Boolean ISql100FullTextIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql100FullTextIndex.Replicated 
		{
			get { return this.Replicated;}
		}
		Boolean ISql100FullTextIndex.StopListOff 
		{
			get { return this.StopListOff;}
		}
		Boolean ISql100FullTextIndex.UseSystemStopList 
		{
			get { return this.UseSystemStopList;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100FullTextIndex.Catalog 
		{
			get 
			{
				return this.Catalog;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100FullTextIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100FullTextIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql100FullTextIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100FullTextIndex.StopList 
		{
			get 
			{
				return this.StopList;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100FullTextIndex.UniqueIndexName 
		{
			get 
			{
				return this.UniqueIndexName;
			}
		}
	}
	public partial class FullTextIndexColumnSpecifier : ISql100FullTextIndexColumnSpecifier
	{		
		Int32? ISql100FullTextIndexColumnSpecifier.LanguageId 
		{
			get { return this.LanguageId;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100FullTextIndexColumnSpecifier.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100FullTextIndexColumnSpecifier.TypeColumn 
		{
			get 
			{
				return this.TypeColumn;
			}
		}
	}
	public partial class FullTextStopList : ISql100FullTextStopList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100FullTextStopList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class HttpProtocolSpecifier : ISql100HttpProtocolSpecifier
	{		
		AuthenticationModes ISql100HttpProtocolSpecifier.AuthenticationMode 
		{
			get { return this.AuthenticationMode;}
		}
		String ISql100HttpProtocolSpecifier.AuthenticationRealm 
		{
			get { return this.AuthenticationRealm;}
		}
		Int32? ISql100HttpProtocolSpecifier.ClearPort 
		{
			get { return this.ClearPort;}
		}
		Boolean ISql100HttpProtocolSpecifier.CompressionEnabled 
		{
			get { return this.CompressionEnabled;}
		}
		String ISql100HttpProtocolSpecifier.DefaultLogonDomain 
		{
			get { return this.DefaultLogonDomain;}
		}
		Boolean ISql100HttpProtocolSpecifier.ListeningOnAllNoneReservedSites 
		{
			get { return this.ListeningOnAllNoneReservedSites;}
		}
		Boolean ISql100HttpProtocolSpecifier.ListeningOnAllSites 
		{
			get { return this.ListeningOnAllSites;}
		}
		String ISql100HttpProtocolSpecifier.Path 
		{
			get { return this.Path;}
		}
		HttpPorts ISql100HttpProtocolSpecifier.Ports 
		{
			get { return this.Ports;}
		}
		Int32? ISql100HttpProtocolSpecifier.SslPort 
		{
			get { return this.SslPort;}
		}
		String ISql100HttpProtocolSpecifier.Website 
		{
			get { return this.Website;}
		}
	}
	public partial class LinkedServer : ISql100LinkedServer
	{		
		String ISql100LinkedServer.Catalog 
		{
			get { return this.Catalog;}
		}
		Boolean ISql100LinkedServer.CollationCompatible 
		{
			get { return this.CollationCompatible;}
		}
		String ISql100LinkedServer.CollationName 
		{
			get { return this.CollationName;}
		}
		Int32 ISql100LinkedServer.ConnectTimeout 
		{
			get { return this.ConnectTimeout;}
		}
		Boolean ISql100LinkedServer.DataAccess 
		{
			get { return this.DataAccess;}
		}
		String ISql100LinkedServer.DataSource 
		{
			get { return this.DataSource;}
		}
		Boolean ISql100LinkedServer.IsDistributor 
		{
			get { return this.IsDistributor;}
		}
		Boolean ISql100LinkedServer.IsPublisher 
		{
			get { return this.IsPublisher;}
		}
		Boolean ISql100LinkedServer.IsSubscriber 
		{
			get { return this.IsSubscriber;}
		}
		Boolean ISql100LinkedServer.LazySchemaValidationEnabled 
		{
			get { return this.LazySchemaValidationEnabled;}
		}
		String ISql100LinkedServer.Location 
		{
			get { return this.Location;}
		}
		String ISql100LinkedServer.ProductName 
		{
			get { return this.ProductName;}
		}
		String ISql100LinkedServer.ProviderName 
		{
			get { return this.ProviderName;}
		}
		String ISql100LinkedServer.ProviderString 
		{
			get { return this.ProviderString;}
		}
		Int32 ISql100LinkedServer.QueryTimeout 
		{
			get { return this.QueryTimeout;}
		}
		Boolean ISql100LinkedServer.RemoteProcTransactionPromotionEnabled 
		{
			get { return this.RemoteProcTransactionPromotionEnabled;}
		}
		Boolean ISql100LinkedServer.RpcEnabled 
		{
			get { return this.RpcEnabled;}
		}
		Boolean ISql100LinkedServer.RpcOutEnabled 
		{
			get { return this.RpcOutEnabled;}
		}
		Boolean ISql100LinkedServer.UseRemoteCollation 
		{
			get { return this.UseRemoteCollation;}
		}
	}
	public partial class LinkedServerLogin : ISql100LinkedServerLogin
	{		
		String ISql100LinkedServerLogin.LinkedServerLoginName 
		{
			get { return this.LinkedServerLoginName;}
		}
		String ISql100LinkedServerLogin.LinkedServerPassword 
		{
			get { return this.LinkedServerPassword;}
		}
		Boolean ISql100LinkedServerLogin.UseSelf 
		{
			get { return this.UseSelf;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100LinkedServer> ISql100LinkedServerLogin.LinkedServer 
		{
			get 
			{
				return this.LinkedServer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100LinkedServerLogin.LocalLogin 
		{
			get 
			{
				return this.LocalLogin;
			}
		}
	}
	public partial class Login : ISql100Login
	{		
		Boolean ISql100Login.CheckExpiration 
		{
			get { return this.CheckExpiration;}
		}
		Boolean ISql100Login.CheckPolicy 
		{
			get { return this.CheckPolicy;}
		}
		String ISql100Login.DefaultDatabase 
		{
			get { return this.DefaultDatabase;}
		}
		String ISql100Login.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		Boolean ISql100Login.Disabled 
		{
			get { return this.Disabled;}
		}
		LoginEncryptionOption ISql100Login.EncryptionOption 
		{
			get { return this.EncryptionOption;}
		}
		Boolean ISql100Login.MappedToWindowsLogin 
		{
			get { return this.MappedToWindowsLogin;}
		}
		String ISql100Login.Password 
		{
			get { return this.Password;}
		}
		Boolean ISql100Login.PasswordHashed 
		{
			get { return this.PasswordHashed;}
		}
		Boolean ISql100Login.PasswordMustChange 
		{
			get { return this.PasswordMustChange;}
		}
		String ISql100Login.Sid 
		{
			get { return this.Sid;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> ISql100Login.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100Login.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Credential> ISql100Login.Credential 
		{
			get 
			{
				return this.Credential;
			}
		}
	}
	public partial class MasterKey : ISql100MasterKey
	{		
		String ISql100MasterKey.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class MessageType : ISql100MessageType
	{		
		ValidationMethod ISql100MessageType.ValidationMethod 
		{
			get { return this.ValidationMethod;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100MessageType.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> ISql100MessageType.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class PartitionFunction : ISql100PartitionFunction
	{		
		PartitionRange ISql100PartitionFunction.Range 
		{
			get { return this.Range;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionValue> ISql100PartitionFunction.BoundaryValues 
		{
			get 
			{
				return this.BoundaryValues;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql100PartitionFunction.ParameterType 
		{
			get 
			{
				return this.ParameterType;
			}
		}
	}
	public partial class PartitionScheme : ISql100PartitionScheme
	{		
		Boolean ISql100PartitionScheme.AllToOneFilegroup 
		{
			get { return this.AllToOneFilegroup;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100PartitionScheme.Filegroups 
		{
			get 
			{
				return this.Filegroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionFunction> ISql100PartitionScheme.PartitionFunction 
		{
			get 
			{
				return this.PartitionFunction;
			}
		}
	}
	public partial class PartitionValue : ISql100PartitionValue
	{		
		String ISql100PartitionValue.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100PartitionValue.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class Permission : ISql100Permission
	{		
		PermissionAction ISql100Permission.PermissionAction 
		{
			get { return this.PermissionAction;}
		}
		PermissionType ISql100Permission.PermissionType 
		{
			get { return this.PermissionType;}
		}
		Boolean ISql100Permission.WithAllPrivileges 
		{
			get { return this.WithAllPrivileges;}
		}
		Boolean ISql100Permission.WithGrantOption 
		{
			get { return this.WithGrantOption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Permission.ExcludedColumns 
		{
			get 
			{
				return this.ExcludedColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql100Permission.Grantee 
		{
			get 
			{
				return this.Grantee;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql100Permission.Grantor 
		{
			get 
			{
				return this.Grantor;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Permission.RevokedGrantOptionColumns 
		{
			get 
			{
				return this.RevokedGrantOptionColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql100Permission.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class PrimaryKeyConstraint : ISql100PrimaryKeyConstraint
	{		
		Boolean ISql100PrimaryKeyConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql100PrimaryKeyConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql100PrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql100PrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql100PrimaryKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql100PrimaryKeyConstraint.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql100PrimaryKeyConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql100PrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql100PrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql100PrimaryKeyConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql100PrimaryKeyConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100PrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> ISql100PrimaryKeyConstraint.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100PrimaryKeyConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100PrimaryKeyConstraint.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100PrimaryKeyConstraint.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> ISql100PrimaryKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100PrimaryKeyConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100PrimaryKeyConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Procedure : ISql100Procedure
	{		
		Boolean? ISql100Procedure.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql100Procedure.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql100Procedure.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql100Procedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100Procedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql100Procedure.ForReplication 
		{
			get { return this.ForReplication;}
		}
		Boolean ISql100Procedure.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql100Procedure.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql100Procedure.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100Procedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql100Procedure.WithRecompile 
		{
			get { return this.WithRecompile;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100Procedure.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Procedure.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100Procedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> ISql100Procedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Procedure> ISql100Procedure.ParentProcedure 
		{
			get 
			{
				return this.ParentProcedure;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Procedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100Procedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Queue : ISql100Queue
	{		
		Boolean ISql100Queue.ActivationExecuteAsCaller 
		{
			get { return this.ActivationExecuteAsCaller;}
		}
		Boolean ISql100Queue.ActivationExecuteAsOwner 
		{
			get { return this.ActivationExecuteAsOwner;}
		}
		Boolean ISql100Queue.ActivationExecuteAsSelf 
		{
			get { return this.ActivationExecuteAsSelf;}
		}
		Int32? ISql100Queue.ActivationMaxQueueReaders 
		{
			get { return this.ActivationMaxQueueReaders;}
		}
		Boolean? ISql100Queue.ActivationStatusOn 
		{
			get { return this.ActivationStatusOn;}
		}
		Boolean ISql100Queue.PoisonMessageHandlingStatusOn 
		{
			get { return this.PoisonMessageHandlingStatusOn;}
		}
		Boolean ISql100Queue.RetentionOn 
		{
			get { return this.RetentionOn;}
		}
		Boolean ISql100Queue.StatusOn 
		{
			get { return this.StatusOn;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Procedure> ISql100Queue.ActivationProcedure 
		{
			get 
			{
				return this.ActivationProcedure;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Queue.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100Queue.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100Queue.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Queue.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100Queue.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Queue.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100Queue.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class QueueEventNotification : ISql100QueueEventNotification
	{		
		String ISql100QueueEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql100QueueEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql100QueueEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> ISql100QueueEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql100QueueEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Queue> ISql100QueueEventNotification.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class RemoteServiceBinding : ISql100RemoteServiceBinding
	{		
		Boolean ISql100RemoteServiceBinding.Anonymous 
		{
			get { return this.Anonymous;}
		}
		String ISql100RemoteServiceBinding.Service 
		{
			get { return this.Service;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100RemoteServiceBinding.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100RemoteServiceBinding.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ResourceGovernor : ISql100ResourceGovernor
	{		
		Boolean? ISql100ResourceGovernor.Enabled 
		{
			get { return this.Enabled;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100ResourceGovernor.ClassifierFunction 
		{
			get 
			{
				return this.ClassifierFunction;
			}
		}
	}
	public partial class ResourcePool : ISql100ResourcePool
	{		
		Int32 ISql100ResourcePool.MaxCpuPercent 
		{
			get { return this.MaxCpuPercent;}
		}
		Int32 ISql100ResourcePool.MaxMemoryPercent 
		{
			get { return this.MaxMemoryPercent;}
		}
		Int32 ISql100ResourcePool.MinCpuPercent 
		{
			get { return this.MinCpuPercent;}
		}
		Int32 ISql100ResourcePool.MinMemoryPercent 
		{
			get { return this.MinMemoryPercent;}
		}
	}
	public partial class Role : ISql100Role
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Role.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class RoleMembership : ISql100RoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql100RoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Role> ISql100RoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Route : ISql100Route
	{		
		String ISql100Route.Address 
		{
			get { return this.Address;}
		}
		String ISql100Route.BrokerInstance 
		{
			get { return this.BrokerInstance;}
		}
		Int32? ISql100Route.Lifetime 
		{
			get { return this.Lifetime;}
		}
		String ISql100Route.MirrorAddress 
		{
			get { return this.MirrorAddress;}
		}
		String ISql100Route.ServiceName 
		{
			get { return this.ServiceName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Route.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Rule : ISql100Rule
	{		
		String ISql100Rule.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Rule.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Rule.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Schema : ISql100Schema
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Schema.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class SearchProperty : ISql100SearchProperty
	{		
	}
	public partial class SearchPropertyList : ISql100SearchPropertyList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100SearchPropertyList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Sequence : ISql100Sequence
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Sequence.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ServerAudit : ISql100ServerAudit
	{		
		String ISql100ServerAudit.AuditGuid 
		{
			get { return this.AuditGuid;}
		}
		AuditTarget ISql100ServerAudit.AuditTarget 
		{
			get { return this.AuditTarget;}
		}
		Boolean ISql100ServerAudit.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql100ServerAudit.FilePath 
		{
			get { return this.FilePath;}
		}
		Int32? ISql100ServerAudit.MaxRolloverFiles 
		{
			get { return this.MaxRolloverFiles;}
		}
		Int32? ISql100ServerAudit.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql100ServerAudit.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		FailureAction ISql100ServerAudit.OnFailure 
		{
			get { return this.OnFailure;}
		}
		Int32 ISql100ServerAudit.QueueDelay 
		{
			get { return this.QueueDelay;}
		}
		Boolean ISql100ServerAudit.ReserveDiskSpace 
		{
			get { return this.ReserveDiskSpace;}
		}
		Boolean ISql100ServerAudit.UnlimitedFileSize 
		{
			get { return this.UnlimitedFileSize;}
		}
		Boolean ISql100ServerAudit.UnlimitedMaxRolloverFiles 
		{
			get { return this.UnlimitedMaxRolloverFiles;}
		}
	}
	public partial class ServerAuditSpecification : ISql100ServerAuditSpecification
	{		
		Boolean ISql100ServerAuditSpecification.StateOn 
		{
			get { return this.StateOn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditActionGroup> ISql100ServerAuditSpecification.AuditActionGroups 
		{
			get 
			{
				return this.AuditActionGroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ServerAudit> ISql100ServerAuditSpecification.ServerAudit 
		{
			get 
			{
				return this.ServerAudit;
			}
		}
	}
	public partial class ServerDdlTrigger : ISql100ServerDdlTrigger
	{		
		Boolean? ISql100ServerDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql100ServerDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql100ServerDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql100ServerDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql100ServerDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql100ServerDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql100ServerDdlTrigger.IsLogon 
		{
			get { return this.IsLogon;}
		}
		String ISql100ServerDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql100ServerDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql100ServerDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql100ServerDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100ServerDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100ServerDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> ISql100ServerDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql100ServerDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100ServerDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> ISql100ServerDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ServerEventNotification : ISql100ServerEventNotification
	{		
		String ISql100ServerEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql100ServerEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql100ServerEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> ISql100ServerEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql100ServerEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class ServerOptions : ISql100ServerOptions
	{		
	}
	public partial class ServerRoleMembership : ISql100ServerRoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> ISql100ServerRoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Role> ISql100ServerRoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Service : ISql100Service
	{		
		Boolean ISql100Service.UseDefaultContract 
		{
			get { return this.UseDefaultContract;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100Service.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Contract> ISql100Service.Contracts 
		{
			get 
			{
				return this.Contracts;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Queue> ISql100Service.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class ServiceBrokerLanguageSpecifier : ISql100ServiceBrokerLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql100ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql100ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql100ServiceBrokerLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		Boolean ISql100ServiceBrokerLanguageSpecifier.MessageForwardingEnabled 
		{
			get { return this.MessageForwardingEnabled;}
		}
		Int32 ISql100ServiceBrokerLanguageSpecifier.MessageForwardSize 
		{
			get { return this.MessageForwardSize;}
		}
		Boolean ISql100ServiceBrokerLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql100ServiceBrokerLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100ServiceBrokerLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class Signature : ISql100Signature
	{		
		Boolean ISql100Signature.IsCounterSignature 
		{
			get { return this.IsCounterSignature;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100Signature.EncryptionMechanism 
		{
			get 
			{
				return this.EncryptionMechanism;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql100Signature.SignedObject 
		{
			get 
			{
				return this.SignedObject;
			}
		}
	}
	public partial class SignatureEncryptionMechanism : ISql100SignatureEncryptionMechanism
	{		
		String ISql100SignatureEncryptionMechanism.Password 
		{
			get { return this.Password;}
		}
		String ISql100SignatureEncryptionMechanism.SignedBlob 
		{
			get { return this.SignedBlob;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> ISql100SignatureEncryptionMechanism.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100SignatureEncryptionMechanism.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class SoapLanguageSpecifier : ISql100SoapLanguageSpecifier
	{		
		Boolean ISql100SoapLanguageSpecifier.BatchesEnabled 
		{
			get { return this.BatchesEnabled;}
		}
		CharacterSet ISql100SoapLanguageSpecifier.CharacterSet 
		{
			get { return this.CharacterSet;}
		}
		String ISql100SoapLanguageSpecifier.DatabaseName 
		{
			get { return this.DatabaseName;}
		}
		Int32 ISql100SoapLanguageSpecifier.HeaderLimit 
		{
			get { return this.HeaderLimit;}
		}
		Boolean ISql100SoapLanguageSpecifier.IsDefaultDatabase 
		{
			get { return this.IsDefaultDatabase;}
		}
		Boolean ISql100SoapLanguageSpecifier.IsDefaultNamespace 
		{
			get { return this.IsDefaultNamespace;}
		}
		Boolean ISql100SoapLanguageSpecifier.IsDefaultWsdlSpName 
		{
			get { return this.IsDefaultWsdlSpName;}
		}
		SoapLoginType ISql100SoapLanguageSpecifier.LoginType 
		{
			get { return this.LoginType;}
		}
		String ISql100SoapLanguageSpecifier.Namespace 
		{
			get { return this.Namespace;}
		}
		SoapSchema ISql100SoapLanguageSpecifier.SchemaType 
		{
			get { return this.SchemaType;}
		}
		Boolean ISql100SoapLanguageSpecifier.SessionsEnabled 
		{
			get { return this.SessionsEnabled;}
		}
		Int32 ISql100SoapLanguageSpecifier.SessionTimeout 
		{
			get { return this.SessionTimeout;}
		}
		Boolean ISql100SoapLanguageSpecifier.SessionTimeoutNever 
		{
			get { return this.SessionTimeoutNever;}
		}
		String ISql100SoapLanguageSpecifier.WsdlSpName 
		{
			get { return this.WsdlSpName;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100SoapMethodSpecification> ISql100SoapLanguageSpecifier.WebMethods 
		{
			get 
			{
				return this.WebMethods;
			}
		}
	}
	public partial class SoapMethodSpecification : ISql100SoapMethodSpecification
	{		
		SoapFormat ISql100SoapMethodSpecification.Format 
		{
			get { return this.Format;}
		}
		SoapSchema ISql100SoapMethodSpecification.SchemaType 
		{
			get { return this.SchemaType;}
		}
		String ISql100SoapMethodSpecification.WebMethodAlias 
		{
			get { return this.WebMethodAlias;}
		}
		String ISql100SoapMethodSpecification.WebMethodNamespace 
		{
			get { return this.WebMethodNamespace;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100SoapMethodSpecification.RelatedMethod 
		{
			get 
			{
				return this.RelatedMethod;
			}
		}
	}
	public partial class SpatialIndex : ISql100SpatialIndex
	{		
		Boolean ISql100SpatialIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql100SpatialIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql100SpatialIndex.CellsPerObject 
		{
			get { return this.CellsPerObject;}
		}
		Boolean ISql100SpatialIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32 ISql100SpatialIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Degree ISql100SpatialIndex.GridLevel1Density 
		{
			get { return this.GridLevel1Density;}
		}
		Degree ISql100SpatialIndex.GridLevel2Density 
		{
			get { return this.GridLevel2Density;}
		}
		Degree ISql100SpatialIndex.GridLevel3Density 
		{
			get { return this.GridLevel3Density;}
		}
		Degree ISql100SpatialIndex.GridLevel4Density 
		{
			get { return this.GridLevel4Density;}
		}
		Boolean ISql100SpatialIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql100SpatialIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Tessellation ISql100SpatialIndex.Tessellation 
		{
			get { return this.Tessellation;}
		}
		Boolean ISql100SpatialIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}
		Double? ISql100SpatialIndex.XMax 
		{
			get { return this.XMax;}
		}
		Double? ISql100SpatialIndex.XMin 
		{
			get { return this.XMin;}
		}
		Double? ISql100SpatialIndex.YMax 
		{
			get { return this.YMax;}
		}
		Double? ISql100SpatialIndex.YMin 
		{
			get { return this.YMin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100SpatialIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100SpatialIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql100SpatialIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100SpatialIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100SpatialIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Statistics : ISql100Statistics
	{		
		String ISql100Statistics.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISql100Statistics.NoRecompute 
		{
			get { return this.NoRecompute;}
		}
		Int32 ISql100Statistics.SampleSize 
		{
			get { return this.SampleSize;}
		}
		SamplingStyle ISql100Statistics.SamplingStyle 
		{
			get { return this.SamplingStyle;}
		}
		String ISql100Statistics.StatsStream 
		{
			get { return this.StatsStream;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Statistics.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Statistics.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql100Statistics.OnObject 
		{
			get 
			{
				return this.OnObject;
			}
		}
	}
	public partial class Parameter : ISql100Parameter
	{		
		String ISql100Parameter.DefaultExpression 
		{
			get { return this.DefaultExpression;}
		}
		Boolean ISql100Parameter.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql100Parameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		Int32 ISql100Parameter.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql100Parameter.Precision 
		{
			get { return this.Precision;}
		}
		Boolean ISql100Parameter.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		Int32 ISql100Parameter.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql100Parameter.Varying 
		{
			get { return this.Varying;}
		}
		XmlStyle ISql100Parameter.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> ISql100Parameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> ISql100Parameter.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class SymmetricKey : ISql100SymmetricKey
	{		
		SymmetricKeyAlgorithm ISql100SymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		SymmetricKeyCreationDisposition ISql100SymmetricKey.CreationDisposition 
		{
			get { return this.CreationDisposition;}
		}
		String ISql100SymmetricKey.IdentityValue 
		{
			get { return this.IdentityValue;}
		}
		String ISql100SymmetricKey.KeySource 
		{
			get { return this.KeySource;}
		}
		String ISql100SymmetricKey.ProviderKeyName 
		{
			get { return this.ProviderKeyName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> ISql100SymmetricKey.AsymmetricKeys 
		{
			get 
			{
				return this.AsymmetricKeys;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100SymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100SymmetricKey.Certificates 
		{
			get 
			{
				return this.Certificates;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100SymmetricKey.Passwords 
		{
			get 
			{
				return this.Passwords;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100SymmetricKey.Provider 
		{
			get 
			{
				return this.Provider;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100SymmetricKey> ISql100SymmetricKey.SymmetricKeys 
		{
			get 
			{
				return this.SymmetricKeys;
			}
		}
	}
	public partial class SymmetricKeyPassword : ISql100SymmetricKeyPassword
	{		
		String ISql100SymmetricKeyPassword.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class Synonym : ISql100Synonym
	{		
		String ISql100Synonym.ForObjectName 
		{
			get { return this.ForObjectName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100Synonym.ForObject 
		{
			get 
			{
				return this.ForObject;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Synonym.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Table : ISql100Table
	{		
		Boolean? ISql100Table.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql100Table.ChangeDataCaptureEnabled 
		{
			get { return this.ChangeDataCaptureEnabled;}
		}
		Boolean ISql100Table.ChangeTrackingEnabled 
		{
			get { return this.ChangeTrackingEnabled;}
		}
		Boolean? ISql100Table.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Boolean ISql100Table.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		Boolean ISql100Table.LargeValueTypesOutOfRow 
		{
			get { return this.LargeValueTypesOutOfRow;}
		}
		LockEscalationMethod ISql100Table.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISql100Table.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100Table.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}
		Int32 ISql100Table.TextInRowSize 
		{
			get { return this.TextInRowSize;}
		}
		Boolean ISql100Table.TrackColumnsUpdated 
		{
			get { return this.TrackColumnsUpdated;}
		}
		Boolean ISql100Table.VardecimalStorageFormatEnabled 
		{
			get { return this.VardecimalStorageFormatEnabled;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Table.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> ISql100Table.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100Table.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100Table.FilegroupForTextImage 
		{
			get 
			{
				return this.FilegroupForTextImage;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100Table.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100Table.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100Table.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100Table.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100Table.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class FileTable : ISql100FileTable
	{		
		Boolean? ISql100FileTable.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql100FileTable.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		LockEscalationMethod ISql100FileTable.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISql100FileTable.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100FileTable.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100FileTable.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> ISql100FileTable.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100FileTable.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100FileTable.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100FileTable.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100FileTable.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100FileTable.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100FileTable.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableType : ISql100TableType
	{		

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100TableType.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> ISql100TableType.Constraints 
		{
			get 
			{
				return this.Constraints;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100TableType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableTypeCheckConstraint : ISql100TableTypeCheckConstraint
	{		
		String ISql100TableTypeCheckConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100TableTypeCheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class TableTypeColumn : ISql100TableTypeColumn
	{		
		String ISql100TableTypeColumn.Collation 
		{
			get { return this.Collation;}
		}
		String ISql100TableTypeColumn.Expression 
		{
			get { return this.Expression;}
		}
		String ISql100TableTypeColumn.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql100TableTypeColumn.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql100TableTypeColumn.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql100TableTypeColumn.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql100TableTypeColumn.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql100TableTypeColumn.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql100TableTypeColumn.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql100TableTypeColumn.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql100TableTypeColumn.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql100TableTypeColumn.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql100TableTypeColumn.Scale 
		{
			get { return this.Scale;}
		}
		XmlStyle ISql100TableTypeColumn.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> ISql100TableTypeColumn.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100TableTypeColumn.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> ISql100TableTypeColumn.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableTypeDefaultConstraint : ISql100TableTypeDefaultConstraint
	{		
		String ISql100TableTypeDefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100TableTypeDefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100TableTypeDefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class TableTypeIndex : ISql100TableTypeIndex
	{		
		Int32? ISql100TableTypeIndex.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql100TableTypeIndex.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql100TableTypeIndex.IsDisabled 
		{
			get { return this.IsDisabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100TableTypeIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypePrimaryKeyConstraint : ISql100TableTypePrimaryKeyConstraint
	{		
		Int32? ISql100TableTypePrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql100TableTypePrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql100TableTypePrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql100TableTypePrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100TableTypePrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypeUniqueConstraint : ISql100TableTypeUniqueConstraint
	{		
		Boolean ISql100TableTypeUniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql100TableTypeUniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100TableTypeUniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TcpProtocolSpecifier : ISql100TcpProtocolSpecifier
	{		
		String ISql100TcpProtocolSpecifier.ListenerIPv4 
		{
			get { return this.ListenerIPv4;}
		}
		String ISql100TcpProtocolSpecifier.ListenerIPv6 
		{
			get { return this.ListenerIPv6;}
		}
		Int32 ISql100TcpProtocolSpecifier.ListenerPort 
		{
			get { return this.ListenerPort;}
		}
		Boolean ISql100TcpProtocolSpecifier.ListeningOnAllIPs 
		{
			get { return this.ListeningOnAllIPs;}
		}
	}
	public partial class UniqueConstraint : ISql100UniqueConstraint
	{		
		Boolean ISql100UniqueConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql100UniqueConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql100UniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql100UniqueConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql100UniqueConstraint.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql100UniqueConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql100UniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql100UniqueConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql100UniqueConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100UniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> ISql100UniqueConstraint.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100UniqueConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> ISql100UniqueConstraint.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100UniqueConstraint.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> ISql100UniqueConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100UniqueConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> ISql100UniqueConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class User : ISql100User
	{		
		Boolean ISql100User.WithoutLogin 
		{
			get { return this.WithoutLogin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> ISql100User.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> ISql100User.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100User.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> ISql100User.Login 
		{
			get 
			{
				return this.Login;
			}
		}
	}
	public partial class UserDefinedServerRole : ISql100UserDefinedServerRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql100UserDefinedServerRole.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class UserDefinedType : ISql100UserDefinedType
	{		
		Boolean? ISql100UserDefinedType.ByteOrdered 
		{
			get { return this.ByteOrdered;}
		}
		String ISql100UserDefinedType.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean? ISql100UserDefinedType.FixedLength 
		{
			get { return this.FixedLength;}
		}
		Format ISql100UserDefinedType.Format 
		{
			get { return this.Format;}
		}
		Int32? ISql100UserDefinedType.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		String ISql100UserDefinedType.ValidationMethodName 
		{
			get { return this.ValidationMethodName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ISql100UserDefinedType.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100UserDefinedType.Methods 
		{
			get 
			{
				return this.Methods;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql100UserDefinedType.Properties 
		{
			get 
			{
				return this.Properties;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100UserDefinedType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class View : ISql100View
	{		
		Boolean? ISql100View.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql100View.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql100View.Replicated 
		{
			get { return this.Replicated;}
		}
		String ISql100View.SelectStatement 
		{
			get { return this.SelectStatement;}
		}
		Boolean ISql100View.WithCheckOption 
		{
			get { return this.WithCheckOption;}
		}
		Boolean ISql100View.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql100View.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}
		Boolean ISql100View.WithViewMetadata 
		{
			get { return this.WithViewMetadata;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql100View.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100View.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100View.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class WorkloadGroup : ISql100WorkloadGroup
	{		
		Int32 ISql100WorkloadGroup.GroupMaxRequests 
		{
			get { return this.GroupMaxRequests;}
		}
		Degree ISql100WorkloadGroup.Importance 
		{
			get { return this.Importance;}
		}
		Int32 ISql100WorkloadGroup.MaxDop 
		{
			get { return this.MaxDop;}
		}
		Int32 ISql100WorkloadGroup.RequestMaxCpuTimeSec 
		{
			get { return this.RequestMaxCpuTimeSec;}
		}
		Int32 ISql100WorkloadGroup.RequestMaxMemoryGrantPercent 
		{
			get { return this.RequestMaxMemoryGrantPercent;}
		}
		Int32 ISql100WorkloadGroup.RequestMemoryGrantTimeoutSec 
		{
			get { return this.RequestMemoryGrantTimeoutSec;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ResourcePool> ISql100WorkloadGroup.ResourcePool 
		{
			get 
			{
				return this.ResourcePool;
			}
		}
	}
	public partial class XmlIndex : ISql100XmlIndex
	{		
		Boolean ISql100XmlIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql100XmlIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql100XmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql100XmlIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql100XmlIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql100XmlIndex.IsPrimary 
		{
			get { return this.IsPrimary;}
		}
		Boolean ISql100XmlIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		SecondaryXmlIndexType ISql100XmlIndex.SecondaryXmlIndexType 
		{
			get { return this.SecondaryXmlIndexType;}
		}
		Boolean ISql100XmlIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ISql100XmlIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql100XmlIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlIndex> ISql100XmlIndex.PrimaryXmlIndex 
		{
			get 
			{
				return this.PrimaryXmlIndex;
			}
		}
	}
	public partial class SelectiveXmlIndex : ISql100SelectiveXmlIndex
	{		
		Boolean ISql100SelectiveXmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
	}
	public partial class XmlNamespace : ISql100XmlNamespace
	{		
	}
	public partial class PromotedNodePathForXQueryType : ISql100PromotedNodePathForXQueryType
	{		
	}
	public partial class PromotedNodePathForSqlType : ISql100PromotedNodePathForSqlType
	{		
		Boolean ISql100PromotedNodePathForSqlType.IsMax 
		{
			get { return this.IsMax;}
		}
		Int32 ISql100PromotedNodePathForSqlType.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql100PromotedNodePathForSqlType.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql100PromotedNodePathForSqlType.Scale 
		{
			get { return this.Scale;}
		}
	}
	public partial class XmlSchemaCollection : ISql100XmlSchemaCollection
	{		
		String ISql100XmlSchemaCollection.Expression 
		{
			get { return this.Expression;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> ISql100XmlSchemaCollection.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Column : ISqlAzureColumn
	{		
		String ISqlAzureColumn.Collation 
		{
			get { return this.Collation;}
		}
		String ISqlAzureColumn.Expression 
		{
			get { return this.Expression;}
		}
		String ISqlAzureColumn.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISqlAzureColumn.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISqlAzureColumn.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISqlAzureColumn.IsMax 
		{
			get { return this.IsMax;}
		}
		Int32 ISqlAzureColumn.Length 
		{
			get { return this.Length;}
		}
		Boolean ISqlAzureColumn.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISqlAzureColumn.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISqlAzureColumn.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISqlAzureColumn.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISqlAzureColumn.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISqlAzureColumn.Sparse 
		{
			get { return this.Sparse;}
		}
		XmlStyle ISqlAzureColumn.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> ISqlAzureColumn.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureColumn.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureXmlSchemaCollection> ISqlAzureColumn.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableValuedFunction : ISqlAzureTableValuedFunction
	{		
		Boolean? ISqlAzureTableValuedFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISqlAzureTableValuedFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISqlAzureTableValuedFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISqlAzureTableValuedFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISqlAzureTableValuedFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureTableValuedFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISqlAzureTableValuedFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISqlAzureTableValuedFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISqlAzureTableValuedFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		String ISqlAzureTableValuedFunction.ReturnTableVariableName 
		{
			get { return this.ReturnTableVariableName;}
		}
		Boolean ISqlAzureTableValuedFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureTableValuedFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureTableValuedFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureTableValuedFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTableValuedFunction.OrderColumns 
		{
			get 
			{
				return this.OrderColumns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> ISqlAzureTableValuedFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISqlAzureTableValuedFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureTableValuedFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureTableValuedFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ScalarFunction : ISqlAzureScalarFunction
	{		
		Boolean? ISqlAzureScalarFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISqlAzureScalarFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISqlAzureScalarFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISqlAzureScalarFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISqlAzureScalarFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureScalarFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISqlAzureScalarFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISqlAzureScalarFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISqlAzureScalarFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		Boolean ISqlAzureScalarFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureScalarFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureScalarFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureScalarFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> ISqlAzureScalarFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISqlAzureScalarFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureScalarFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureScalarFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Aggregate : ISqlAzureAggregate
	{		
		String ISqlAzureAggregate.ClassName 
		{
			get { return this.ClassName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureAggregate.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> ISqlAzureAggregate.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureAggregate.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ApplicationRole : ISqlAzureApplicationRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureApplicationRole.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}
	}
	public partial class Index : ISqlAzureIndex
	{		
		Int32? ISqlAzureIndex.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISqlAzureIndex.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISqlAzureIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISqlAzureIndex.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISqlAzureIndex.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISqlAzureIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISqlAzureIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISqlAzureIndex.Unique 
		{
			get { return this.Unique;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureIndex.IncludedColumns 
		{
			get 
			{
				return this.IncludedColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISqlAzureIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}
	}
	public partial class Assembly : ISqlAzureAssembly
	{		
		AssemblyPermissionSet ISqlAzureAssembly.PermissionSet 
		{
			get { return this.PermissionSet;}
		}
		Boolean ISqlAzureAssembly.Visible 
		{
			get { return this.Visible;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssemblySource> ISqlAzureAssembly.AssemblySources 
		{
			get 
			{
				return this.AssemblySources;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureAssembly.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureAssembly.ReferencedAssemblies 
		{
			get 
			{
				return this.ReferencedAssemblies;
			}
		}
	}
	public partial class AssemblySource : ISqlAzureAssemblySource
	{		
		String ISqlAzureAssemblySource.Source 
		{
			get { return this.Source;}
		}
	}
	public partial class AsymmetricKey : ISqlAzureAsymmetricKey
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureAsymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class AuditAction : ISqlAzureAuditAction
	{		
	}
	public partial class AuditActionGroup : ISqlAzureAuditActionGroup
	{		
	}
	public partial class AuditActionSpecification : ISqlAzureAuditActionSpecification
	{		
	}
	public partial class BrokerPriority : ISqlAzureBrokerPriority
	{		
	}
	public partial class BuiltInServerRole : ISqlAzureBuiltInServerRole
	{		
	}
	public partial class DataType : ISqlAzureDataType
	{		
		SqlDataType ISqlAzureDataType.SqlDataType 
		{
			get { return this.SqlDataType;}
		}
		Boolean ISqlAzureDataType.UddtIsMax 
		{
			get { return this.UddtIsMax;}
		}
		Int32 ISqlAzureDataType.UddtLength 
		{
			get { return this.UddtLength;}
		}
		Boolean ISqlAzureDataType.UddtNullable 
		{
			get { return this.UddtNullable;}
		}
		Int32 ISqlAzureDataType.UddtPrecision 
		{
			get { return this.UddtPrecision;}
		}
		Int32 ISqlAzureDataType.UddtScale 
		{
			get { return this.UddtScale;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureDataType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<System.Type> ISqlAzureDataType.Type 
		{
			get 
			{
				return this.Type;
			}
		}
	}
	public partial class Certificate : ISqlAzureCertificate
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureCertificate.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class CheckConstraint : ISqlAzureCheckConstraint
	{		
		Boolean ISqlAzureCheckConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISqlAzureCheckConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureCheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> ISqlAzureCheckConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class ClrTypeMethod : ISqlAzureClrTypeMethod
	{		
		String ISqlAzureClrTypeMethod.Name 
		{
			get { return this.Name;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> ISqlAzureClrTypeMethod.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISqlAzureClrTypeMethod.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}
	}
	public partial class ClrTypeMethodParameter : ISqlAzureClrTypeMethodParameter
	{		
		Boolean ISqlAzureClrTypeMethodParameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		String ISqlAzureClrTypeMethodParameter.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> ISqlAzureClrTypeMethodParameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class ClrTypeProperty : ISqlAzureClrTypeProperty
	{		
		String ISqlAzureClrTypeProperty.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISqlAzureClrTypeProperty.ClrType 
		{
			get 
			{
				return this.ClrType;
			}
		}
	}
	public partial class ColumnStoreIndex : ISqlAzureColumnStoreIndex
	{		
		Boolean ISqlAzureColumnStoreIndex.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISqlAzureColumnStoreIndex.Disabled 
		{
			get { return this.Disabled;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISqlAzureColumnStoreIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}
	}
	public partial class Contract : ISqlAzureContract
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureContract.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Credential : ISqlAzureCredential
	{		
	}
	public partial class CryptographicProvider : ISqlAzureCryptographicProvider
	{		
	}
	public partial class DatabaseAuditSpecification : ISqlAzureDatabaseAuditSpecification
	{		
	}
	public partial class DatabaseDdlTrigger : ISqlAzureDatabaseDdlTrigger
	{		
		Boolean? ISqlAzureDatabaseDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISqlAzureDatabaseDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISqlAzureDatabaseDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISqlAzureDatabaseDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISqlAzureDatabaseDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureDatabaseDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISqlAzureDatabaseDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISqlAzureDatabaseDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISqlAzureDatabaseDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureDatabaseDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureDatabaseDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureEventGroup> ISqlAzureDatabaseDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISqlAzureDatabaseDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureDatabaseDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureDatabaseDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class DatabaseEncryptionKey : ISqlAzureDatabaseEncryptionKey
	{		
	}
	public partial class DatabaseEventNotification : ISqlAzureDatabaseEventNotification
	{		
	}
	public partial class DatabaseMirroringLanguageSpecifier : ISqlAzureDatabaseMirroringLanguageSpecifier
	{		
	}
	public partial class DatabaseOptions : ISqlAzureDatabaseOptions
	{		
		String ISqlAzureDatabaseOptions.Collation 
		{
			get { return this.Collation;}
		}
		Boolean ISqlAzureDatabaseOptions.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
	}
	public partial class DataCompressionOption : ISqlAzureDataCompressionOption
	{		
	}
	public partial class Default : ISqlAzureDefault
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureDefault.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class DefaultConstraint : ISqlAzureDefaultConstraint
	{		
		Boolean ISqlAzureDefaultConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISqlAzureDefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISqlAzureDefaultConstraint.WithValues 
		{
			get { return this.WithValues;}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureDefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> ISqlAzureDefaultConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureDefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class DmlTrigger : ISqlAzureDmlTrigger
	{		
		Boolean? ISqlAzureDmlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISqlAzureDmlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		OrderRestriction ISqlAzureDmlTrigger.DeleteOrderRestriction 
		{
			get { return this.DeleteOrderRestriction;}
		}
		Boolean ISqlAzureDmlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISqlAzureDmlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISqlAzureDmlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureDmlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		OrderRestriction ISqlAzureDmlTrigger.InsertOrderRestriction 
		{
			get { return this.InsertOrderRestriction;}
		}
		Boolean ISqlAzureDmlTrigger.IsDeleteTrigger 
		{
			get { return this.IsDeleteTrigger;}
		}
		Boolean ISqlAzureDmlTrigger.IsInsertTrigger 
		{
			get { return this.IsInsertTrigger;}
		}
		Boolean ISqlAzureDmlTrigger.IsUpdateTrigger 
		{
			get { return this.IsUpdateTrigger;}
		}
		String ISqlAzureDmlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISqlAzureDmlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISqlAzureDmlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		OrderRestriction ISqlAzureDmlTrigger.UpdateOrderRestriction 
		{
			get { return this.UpdateOrderRestriction;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureDmlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureDmlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureDmlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISqlAzureDmlTrigger.TriggerObject 
		{
			get 
			{
				return this.TriggerObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureDmlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Endpoint : ISqlAzureEndpoint
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureEndpoint.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class ErrorMessage : ISqlAzureErrorMessage
	{		
	}
	public partial class EventGroup : ISqlAzureEventGroup
	{		
		EventGroupType ISqlAzureEventGroup.Group 
		{
			get { return this.Group;}
		}
	}
	public partial class EventSession : ISqlAzureEventSession
	{		
	}
	public partial class EventSessionAction : ISqlAzureEventSessionAction
	{		
	}
	public partial class EventSessionDefinitions : ISqlAzureEventSessionDefinitions
	{		
	}
	public partial class EventSessionSetting : ISqlAzureEventSessionSetting
	{		
	}
	public partial class EventSessionTarget : ISqlAzureEventSessionTarget
	{		
	}
	public partial class EventTypeSpecifier : ISqlAzureEventTypeSpecifier
	{		
		EventType ISqlAzureEventTypeSpecifier.EventType 
		{
			get { return this.EventType;}
		}
		OrderRestriction ISqlAzureEventTypeSpecifier.Order 
		{
			get { return this.Order;}
		}
	}
	public partial class ExtendedProcedure : ISqlAzureExtendedProcedure
	{		
		Boolean ISqlAzureExtendedProcedure.ExeccuteAsCaller 
		{
			get { return this.ExeccuteAsCaller;}
		}
		Boolean ISqlAzureExtendedProcedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureExtendedProcedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureExtendedProcedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> ISqlAzureExtendedProcedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureExtendedProcedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureExtendedProcedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ExtendedProperty : ISqlAzureExtendedProperty
	{		
	}
	public partial class SqlFile : ISqlAzureSqlFile
	{		
	}
	public partial class Filegroup : ISqlAzureFilegroup
	{		
	}
	public partial class ForeignKeyConstraint : ISqlAzureForeignKeyConstraint
	{		
		ForeignKeyAction ISqlAzureForeignKeyConstraint.DeleteAction 
		{
			get { return this.DeleteAction;}
		}
		Boolean ISqlAzureForeignKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		ForeignKeyAction ISqlAzureForeignKeyConstraint.UpdateAction 
		{
			get { return this.UpdateAction;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureForeignKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureForeignKeyConstraint.ForeignColumns 
		{
			get 
			{
				return this.ForeignColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTable> ISqlAzureForeignKeyConstraint.ForeignTable 
		{
			get 
			{
				return this.ForeignTable;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> ISqlAzureForeignKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class FullTextCatalog : ISqlAzureFullTextCatalog
	{		
		Boolean? ISqlAzureFullTextCatalog.AccentSensitivity 
		{
			get { return this.AccentSensitivity;}
		}
		Boolean ISqlAzureFullTextCatalog.IsDefault 
		{
			get { return this.IsDefault;}
		}
		String ISqlAzureFullTextCatalog.Path 
		{
			get { return this.Path;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureFullTextCatalog.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureFilegroup> ISqlAzureFullTextCatalog.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class FullTextIndex : ISqlAzureFullTextIndex
	{		
	}
	public partial class FullTextIndexColumnSpecifier : ISqlAzureFullTextIndexColumnSpecifier
	{		
	}
	public partial class FullTextStopList : ISqlAzureFullTextStopList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureFullTextStopList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class HttpProtocolSpecifier : ISqlAzureHttpProtocolSpecifier
	{		
	}
	public partial class LinkedServer : ISqlAzureLinkedServer
	{		
	}
	public partial class LinkedServerLogin : ISqlAzureLinkedServerLogin
	{		
	}
	public partial class Login : ISqlAzureLogin
	{		
		Boolean ISqlAzureLogin.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISqlAzureLogin.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class MasterKey : ISqlAzureMasterKey
	{		
	}
	public partial class MessageType : ISqlAzureMessageType
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureMessageType.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class PartitionFunction : ISqlAzurePartitionFunction
	{		
	}
	public partial class PartitionScheme : ISqlAzurePartitionScheme
	{		
	}
	public partial class PartitionValue : ISqlAzurePartitionValue
	{		
	}
	public partial class Permission : ISqlAzurePermission
	{		
		PermissionAction ISqlAzurePermission.PermissionAction 
		{
			get { return this.PermissionAction;}
		}
		PermissionType ISqlAzurePermission.PermissionType 
		{
			get { return this.PermissionType;}
		}
		Boolean ISqlAzurePermission.WithAllPrivileges 
		{
			get { return this.WithAllPrivileges;}
		}
		Boolean ISqlAzurePermission.WithGrantOption 
		{
			get { return this.WithGrantOption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzurePermission.ExcludedColumns 
		{
			get 
			{
				return this.ExcludedColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISqlAzurePermission.Grantee 
		{
			get 
			{
				return this.Grantee;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISqlAzurePermission.Grantor 
		{
			get 
			{
				return this.Grantor;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzurePermission.RevokedGrantOptionColumns 
		{
			get 
			{
				return this.RevokedGrantOptionColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISqlAzurePermission.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class PrimaryKeyConstraint : ISqlAzurePrimaryKeyConstraint
	{		
		Int32? ISqlAzurePrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISqlAzurePrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISqlAzurePrimaryKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISqlAzurePrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISqlAzurePrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISqlAzurePrimaryKeyConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzurePrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> ISqlAzurePrimaryKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class Procedure : ISqlAzureProcedure
	{		
		Boolean? ISqlAzureProcedure.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISqlAzureProcedure.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISqlAzureProcedure.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISqlAzureProcedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureProcedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISqlAzureProcedure.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISqlAzureProcedure.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISqlAzureProcedure.WithRecompile 
		{
			get { return this.WithRecompile;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureProcedure.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureProcedure.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureProcedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> ISqlAzureProcedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureProcedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureProcedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Queue : ISqlAzureQueue
	{		
		Boolean ISqlAzureQueue.ActivationExecuteAsCaller 
		{
			get { return this.ActivationExecuteAsCaller;}
		}
		Boolean ISqlAzureQueue.ActivationExecuteAsOwner 
		{
			get { return this.ActivationExecuteAsOwner;}
		}
		Boolean ISqlAzureQueue.ActivationExecuteAsSelf 
		{
			get { return this.ActivationExecuteAsSelf;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureQueue.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureQueue.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureQueue.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureQueue.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class QueueEventNotification : ISqlAzureQueueEventNotification
	{		
	}
	public partial class RemoteServiceBinding : ISqlAzureRemoteServiceBinding
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureRemoteServiceBinding.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class ResourceGovernor : ISqlAzureResourceGovernor
	{		
	}
	public partial class ResourcePool : ISqlAzureResourcePool
	{		
	}
	public partial class Role : ISqlAzureRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureRole.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class RoleMembership : ISqlAzureRoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISqlAzureRoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureRole> ISqlAzureRoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Route : ISqlAzureRoute
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureRoute.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Rule : ISqlAzureRule
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureRule.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Schema : ISqlAzureSchema
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureSchema.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class SearchProperty : ISqlAzureSearchProperty
	{		
	}
	public partial class SearchPropertyList : ISqlAzureSearchPropertyList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureSearchPropertyList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Sequence : ISqlAzureSequence
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureSequence.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ServerAudit : ISqlAzureServerAudit
	{		
	}
	public partial class ServerAuditSpecification : ISqlAzureServerAuditSpecification
	{		
	}
	public partial class ServerDdlTrigger : ISqlAzureServerDdlTrigger
	{		
		Boolean? ISqlAzureServerDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISqlAzureServerDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISqlAzureServerDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISqlAzureServerDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISqlAzureServerDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISqlAzureServerDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISqlAzureServerDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISqlAzureServerDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISqlAzureServerDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureServerDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureServerDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureEventGroup> ISqlAzureServerDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISqlAzureServerDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureServerDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> ISqlAzureServerDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ServerEventNotification : ISqlAzureServerEventNotification
	{		
	}
	public partial class ServerOptions : ISqlAzureServerOptions
	{		
	}
	public partial class ServerRoleMembership : ISqlAzureServerRoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> ISqlAzureServerRoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureRole> ISqlAzureServerRoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Service : ISqlAzureService
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureService.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class ServiceBrokerLanguageSpecifier : ISqlAzureServiceBrokerLanguageSpecifier
	{		
	}
	public partial class Signature : ISqlAzureSignature
	{		
	}
	public partial class SignatureEncryptionMechanism : ISqlAzureSignatureEncryptionMechanism
	{		
	}
	public partial class SoapLanguageSpecifier : ISqlAzureSoapLanguageSpecifier
	{		
	}
	public partial class SoapMethodSpecification : ISqlAzureSoapMethodSpecification
	{		
	}
	public partial class SpatialIndex : ISqlAzureSpatialIndex
	{		
		Int32? ISqlAzureSpatialIndex.CellsPerObject 
		{
			get { return this.CellsPerObject;}
		}
		Boolean ISqlAzureSpatialIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Degree ISqlAzureSpatialIndex.GridLevel1Density 
		{
			get { return this.GridLevel1Density;}
		}
		Degree ISqlAzureSpatialIndex.GridLevel2Density 
		{
			get { return this.GridLevel2Density;}
		}
		Degree ISqlAzureSpatialIndex.GridLevel3Density 
		{
			get { return this.GridLevel3Density;}
		}
		Degree ISqlAzureSpatialIndex.GridLevel4Density 
		{
			get { return this.GridLevel4Density;}
		}
		Boolean ISqlAzureSpatialIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISqlAzureSpatialIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Tessellation ISqlAzureSpatialIndex.Tessellation 
		{
			get { return this.Tessellation;}
		}
		Double? ISqlAzureSpatialIndex.XMax 
		{
			get { return this.XMax;}
		}
		Double? ISqlAzureSpatialIndex.XMin 
		{
			get { return this.XMin;}
		}
		Double? ISqlAzureSpatialIndex.YMax 
		{
			get { return this.YMax;}
		}
		Double? ISqlAzureSpatialIndex.YMin 
		{
			get { return this.YMin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureSpatialIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISqlAzureSpatialIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}
	}
	public partial class Statistics : ISqlAzureStatistics
	{		
		String ISqlAzureStatistics.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISqlAzureStatistics.NoRecompute 
		{
			get { return this.NoRecompute;}
		}
		Int32 ISqlAzureStatistics.SampleSize 
		{
			get { return this.SampleSize;}
		}
		SamplingStyle ISqlAzureStatistics.SamplingStyle 
		{
			get { return this.SamplingStyle;}
		}
		String ISqlAzureStatistics.StatsStream 
		{
			get { return this.StatsStream;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureStatistics.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureStatistics.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISqlAzureStatistics.OnObject 
		{
			get 
			{
				return this.OnObject;
			}
		}
	}
	public partial class Parameter : ISqlAzureParameter
	{		
		String ISqlAzureParameter.DefaultExpression 
		{
			get { return this.DefaultExpression;}
		}
		Boolean ISqlAzureParameter.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISqlAzureParameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		Int32 ISqlAzureParameter.Length 
		{
			get { return this.Length;}
		}
		Int32 ISqlAzureParameter.Precision 
		{
			get { return this.Precision;}
		}
		Boolean ISqlAzureParameter.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		Int32 ISqlAzureParameter.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISqlAzureParameter.Varying 
		{
			get { return this.Varying;}
		}
		XmlStyle ISqlAzureParameter.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> ISqlAzureParameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureXmlSchemaCollection> ISqlAzureParameter.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class SymmetricKey : ISqlAzureSymmetricKey
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureSymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class SymmetricKeyPassword : ISqlAzureSymmetricKeyPassword
	{		
	}
	public partial class Synonym : ISqlAzureSynonym
	{		
		String ISqlAzureSynonym.ForObjectName 
		{
			get { return this.ForObjectName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureSynonym.ForObject 
		{
			get 
			{
				return this.ForObject;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureSynonym.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Table : ISqlAzureTable
	{		
		Boolean? ISqlAzureTable.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISqlAzureTable.LargeValueTypesOutOfRow 
		{
			get { return this.LargeValueTypesOutOfRow;}
		}
		LockEscalationMethod ISqlAzureTable.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISqlAzureTable.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISqlAzureTable.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}
		Int32 ISqlAzureTable.TextInRowSize 
		{
			get { return this.TextInRowSize;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTable.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureTable.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class FileTable : ISqlAzureFileTable
	{		
		Boolean? ISqlAzureFileTable.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		LockEscalationMethod ISqlAzureFileTable.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISqlAzureFileTable.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISqlAzureFileTable.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureFileTable.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureFileTable.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableType : ISqlAzureTableType
	{		

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTableType.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> ISqlAzureTableType.Constraints 
		{
			get 
			{
				return this.Constraints;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureTableType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableTypeCheckConstraint : ISqlAzureTableTypeCheckConstraint
	{		
		String ISqlAzureTableTypeCheckConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureTableTypeCheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class TableTypeColumn : ISqlAzureTableTypeColumn
	{		
		String ISqlAzureTableTypeColumn.Collation 
		{
			get { return this.Collation;}
		}
		String ISqlAzureTableTypeColumn.Expression 
		{
			get { return this.Expression;}
		}
		String ISqlAzureTableTypeColumn.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISqlAzureTableTypeColumn.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISqlAzureTableTypeColumn.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISqlAzureTableTypeColumn.IsMax 
		{
			get { return this.IsMax;}
		}
		Int32 ISqlAzureTableTypeColumn.Length 
		{
			get { return this.Length;}
		}
		Boolean ISqlAzureTableTypeColumn.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISqlAzureTableTypeColumn.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISqlAzureTableTypeColumn.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISqlAzureTableTypeColumn.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISqlAzureTableTypeColumn.Scale 
		{
			get { return this.Scale;}
		}
		XmlStyle ISqlAzureTableTypeColumn.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> ISqlAzureTableTypeColumn.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureTableTypeColumn.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureXmlSchemaCollection> ISqlAzureTableTypeColumn.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableTypeDefaultConstraint : ISqlAzureTableTypeDefaultConstraint
	{		
		String ISqlAzureTableTypeDefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureTableTypeDefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTableTypeDefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class TableTypeIndex : ISqlAzureTableTypeIndex
	{		
		Int32? ISqlAzureTableTypeIndex.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISqlAzureTableTypeIndex.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISqlAzureTableTypeIndex.IsDisabled 
		{
			get { return this.IsDisabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTableTypeIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypePrimaryKeyConstraint : ISqlAzureTableTypePrimaryKeyConstraint
	{		
		Int32? ISqlAzureTableTypePrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISqlAzureTableTypePrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISqlAzureTableTypePrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISqlAzureTableTypePrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTableTypePrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypeUniqueConstraint : ISqlAzureTableTypeUniqueConstraint
	{		
		Boolean ISqlAzureTableTypeUniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISqlAzureTableTypeUniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureTableTypeUniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TcpProtocolSpecifier : ISqlAzureTcpProtocolSpecifier
	{		
	}
	public partial class UniqueConstraint : ISqlAzureUniqueConstraint
	{		
		Boolean ISqlAzureUniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISqlAzureUniqueConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISqlAzureUniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISqlAzureUniqueConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureUniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> ISqlAzureUniqueConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class User : ISqlAzureUser
	{		
		Boolean ISqlAzureUser.WithoutLogin 
		{
			get { return this.WithoutLogin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureUser.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> ISqlAzureUser.Login 
		{
			get 
			{
				return this.Login;
			}
		}
	}
	public partial class UserDefinedServerRole : ISqlAzureUserDefinedServerRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISqlAzureUserDefinedServerRole.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class UserDefinedType : ISqlAzureUserDefinedType
	{		
		Boolean? ISqlAzureUserDefinedType.ByteOrdered 
		{
			get { return this.ByteOrdered;}
		}
		String ISqlAzureUserDefinedType.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean? ISqlAzureUserDefinedType.FixedLength 
		{
			get { return this.FixedLength;}
		}
		Format ISqlAzureUserDefinedType.Format 
		{
			get { return this.Format;}
		}
		Int32? ISqlAzureUserDefinedType.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		String ISqlAzureUserDefinedType.ValidationMethodName 
		{
			get { return this.ValidationMethodName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ISqlAzureUserDefinedType.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISqlAzureUserDefinedType.Methods 
		{
			get 
			{
				return this.Methods;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISqlAzureUserDefinedType.Properties 
		{
			get 
			{
				return this.Properties;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureUserDefinedType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class View : ISqlAzureView
	{		
		Boolean? ISqlAzureView.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISqlAzureView.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		String ISqlAzureView.SelectStatement 
		{
			get { return this.SelectStatement;}
		}
		Boolean ISqlAzureView.WithCheckOption 
		{
			get { return this.WithCheckOption;}
		}
		Boolean ISqlAzureView.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}
		Boolean ISqlAzureView.WithViewMetadata 
		{
			get { return this.WithViewMetadata;}
		}

		//Peer
		IEnumerable<TSqlObject> ISqlAzureView.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ISqlAzureView.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureView.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class WorkloadGroup : ISqlAzureWorkloadGroup
	{		
	}
	public partial class XmlIndex : ISqlAzureXmlIndex
	{		
		Boolean ISqlAzureXmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
	}
	public partial class SelectiveXmlIndex : ISqlAzureSelectiveXmlIndex
	{		
		Boolean ISqlAzureSelectiveXmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
	}
	public partial class XmlNamespace : ISqlAzureXmlNamespace
	{		
	}
	public partial class PromotedNodePathForXQueryType : ISqlAzurePromotedNodePathForXQueryType
	{		
	}
	public partial class PromotedNodePathForSqlType : ISqlAzurePromotedNodePathForSqlType
	{		
		Boolean ISqlAzurePromotedNodePathForSqlType.IsMax 
		{
			get { return this.IsMax;}
		}
		Int32 ISqlAzurePromotedNodePathForSqlType.Length 
		{
			get { return this.Length;}
		}
		Int32 ISqlAzurePromotedNodePathForSqlType.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISqlAzurePromotedNodePathForSqlType.Scale 
		{
			get { return this.Scale;}
		}
	}
	public partial class XmlSchemaCollection : ISqlAzureXmlSchemaCollection
	{		

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> ISqlAzureXmlSchemaCollection.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Column : ISql110Column
	{		
		String ISql110Column.Collation 
		{
			get { return this.Collation;}
		}
		String ISql110Column.Expression 
		{
			get { return this.Expression;}
		}
		String ISql110Column.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql110Column.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql110Column.IsFileStream 
		{
			get { return this.IsFileStream;}
		}
		Boolean ISql110Column.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql110Column.IsIdentityNotForReplication 
		{
			get { return this.IsIdentityNotForReplication;}
		}
		Boolean ISql110Column.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql110Column.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql110Column.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql110Column.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql110Column.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql110Column.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql110Column.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql110Column.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql110Column.Sparse 
		{
			get { return this.Sparse;}
		}
		XmlStyle ISql110Column.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> ISql110Column.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Column.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> ISql110Column.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableValuedFunction : ISql110TableValuedFunction
	{		
		Boolean? ISql110TableValuedFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql110TableValuedFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql110TableValuedFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql110TableValuedFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql110TableValuedFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql110TableValuedFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql110TableValuedFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110TableValuedFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql110TableValuedFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql110TableValuedFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql110TableValuedFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql110TableValuedFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql110TableValuedFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110TableValuedFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		String ISql110TableValuedFunction.ReturnTableVariableName 
		{
			get { return this.ReturnTableVariableName;}
		}
		SystemDataAccessKind? ISql110TableValuedFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql110TableValuedFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql110TableValuedFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110TableValuedFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110TableValuedFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110TableValuedFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110TableValuedFunction.OrderColumns 
		{
			get 
			{
				return this.OrderColumns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> ISql110TableValuedFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql110TableValuedFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110TableValuedFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110TableValuedFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ScalarFunction : ISql110ScalarFunction
	{		
		Boolean? ISql110ScalarFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql110ScalarFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql110ScalarFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql110ScalarFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql110ScalarFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql110ScalarFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql110ScalarFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110ScalarFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql110ScalarFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql110ScalarFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql110ScalarFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql110ScalarFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql110ScalarFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110ScalarFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		SystemDataAccessKind? ISql110ScalarFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql110ScalarFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql110ScalarFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110ScalarFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110ScalarFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110ScalarFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> ISql110ScalarFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql110ScalarFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110ScalarFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110ScalarFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Aggregate : ISql110Aggregate
	{		
		String ISql110Aggregate.ClassName 
		{
			get { return this.ClassName;}
		}
		Format ISql110Aggregate.Format 
		{
			get { return this.Format;}
		}
		Boolean? ISql110Aggregate.InvariantToDuplicates 
		{
			get { return this.InvariantToDuplicates;}
		}
		Boolean? ISql110Aggregate.InvariantToNulls 
		{
			get { return this.InvariantToNulls;}
		}
		Int32? ISql110Aggregate.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		Boolean? ISql110Aggregate.NullIfEmpty 
		{
			get { return this.NullIfEmpty;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110Aggregate.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> ISql110Aggregate.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql110Aggregate.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Aggregate.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ApplicationRole : ISql110ApplicationRole
	{		
		String ISql110ApplicationRole.Password 
		{
			get { return this.Password;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110ApplicationRole.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}
	}
	public partial class Index : ISql110Index
	{		
		Boolean ISql110Index.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql110Index.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql110Index.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql110Index.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql110Index.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql110Index.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql110Index.FillFactor 
		{
			get { return this.FillFactor;}
		}
		String ISql110Index.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISql110Index.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql110Index.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql110Index.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql110Index.Unique 
		{
			get { return this.Unique;}
		}
		Boolean ISql110Index.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Index.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Index.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> ISql110Index.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110Index.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110Index.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110Index.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Index.IncludedColumns 
		{
			get 
			{
				return this.IncludedColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql110Index.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Index.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110Index.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Assembly : ISql110Assembly
	{		
		AssemblyPermissionSet ISql110Assembly.PermissionSet 
		{
			get { return this.PermissionSet;}
		}
		Boolean ISql110Assembly.Visible 
		{
			get { return this.Visible;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AssemblySource> ISql110Assembly.AssemblySources 
		{
			get 
			{
				return this.AssemblySources;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Assembly.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110Assembly.ReferencedAssemblies 
		{
			get 
			{
				return this.ReferencedAssemblies;
			}
		}
	}
	public partial class AssemblySource : ISql110AssemblySource
	{		
		String ISql110AssemblySource.Source 
		{
			get { return this.Source;}
		}
	}
	public partial class AsymmetricKey : ISql110AsymmetricKey
	{		
		AsymmetricKeyAlgorithm ISql110AsymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		SymmetricKeyCreationDisposition ISql110AsymmetricKey.CreationDisposition 
		{
			get { return this.CreationDisposition;}
		}
		Boolean ISql110AsymmetricKey.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql110AsymmetricKey.ExecutableFile 
		{
			get { return this.ExecutableFile;}
		}
		String ISql110AsymmetricKey.File 
		{
			get { return this.File;}
		}
		String ISql110AsymmetricKey.Password 
		{
			get { return this.Password;}
		}
		String ISql110AsymmetricKey.ProviderKeyName 
		{
			get { return this.ProviderKeyName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110AsymmetricKey.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110AsymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110AsymmetricKey.Provider 
		{
			get 
			{
				return this.Provider;
			}
		}
	}
	public partial class AuditAction : ISql110AuditAction
	{		
		DatabaseAuditAction ISql110AuditAction.Action 
		{
			get { return this.Action;}
		}
	}
	public partial class AuditActionGroup : ISql110AuditActionGroup
	{		
		AuditActionGroupType ISql110AuditActionGroup.ActionGroup 
		{
			get { return this.ActionGroup;}
		}
	}
	public partial class AuditActionSpecification : ISql110AuditActionSpecification
	{		

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditAction> ISql110AuditActionSpecification.AuditActions 
		{
			get 
			{
				return this.AuditActions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql110AuditActionSpecification.Principals 
		{
			get 
			{
				return this.Principals;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql110AuditActionSpecification.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class BrokerPriority : ISql110BrokerPriority
	{		
		Int32 ISql110BrokerPriority.PriorityLevel 
		{
			get { return this.PriorityLevel;}
		}
		String ISql110BrokerPriority.RemoteServiceName 
		{
			get { return this.RemoteServiceName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110BrokerPriority.ContractName 
		{
			get 
			{
				return this.ContractName;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110BrokerPriority.LocalServiceName 
		{
			get 
			{
				return this.LocalServiceName;
			}
		}
	}
	public partial class BuiltInServerRole : ISql110BuiltInServerRole
	{		
	}
	public partial class DataType : ISql110DataType
	{		
		SqlDataType ISql110DataType.SqlDataType 
		{
			get { return this.SqlDataType;}
		}
		Boolean ISql110DataType.UddtIsMax 
		{
			get { return this.UddtIsMax;}
		}
		Int32 ISql110DataType.UddtLength 
		{
			get { return this.UddtLength;}
		}
		Boolean ISql110DataType.UddtNullable 
		{
			get { return this.UddtNullable;}
		}
		Int32 ISql110DataType.UddtPrecision 
		{
			get { return this.UddtPrecision;}
		}
		Int32 ISql110DataType.UddtScale 
		{
			get { return this.UddtScale;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110DataType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<System.Type> ISql110DataType.Type 
		{
			get 
			{
				return this.Type;
			}
		}
	}
	public partial class Certificate : ISql110Certificate
	{		
		Boolean ISql110Certificate.ActiveForBeginDialog 
		{
			get { return this.ActiveForBeginDialog;}
		}
		Boolean ISql110Certificate.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql110Certificate.EncryptionPassword 
		{
			get { return this.EncryptionPassword;}
		}
		String ISql110Certificate.ExistingKeysFilePath 
		{
			get { return this.ExistingKeysFilePath;}
		}
		String ISql110Certificate.ExpiryDate 
		{
			get { return this.ExpiryDate;}
		}
		Boolean ISql110Certificate.IsExistingKeyFileExecutable 
		{
			get { return this.IsExistingKeyFileExecutable;}
		}
		String ISql110Certificate.PrivateKeyDecryptionPassword 
		{
			get { return this.PrivateKeyDecryptionPassword;}
		}
		String ISql110Certificate.PrivateKeyEncryptionPassword 
		{
			get { return this.PrivateKeyEncryptionPassword;}
		}
		String ISql110Certificate.PrivateKeyFilePath 
		{
			get { return this.PrivateKeyFilePath;}
		}
		String ISql110Certificate.StartDate 
		{
			get { return this.StartDate;}
		}
		String ISql110Certificate.Subject 
		{
			get { return this.Subject;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Certificate.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110Certificate.ExistingKeysAssembly 
		{
			get 
			{
				return this.ExistingKeysAssembly;
			}
		}
	}
	public partial class CheckConstraint : ISql110CheckConstraint
	{		
		Boolean ISql110CheckConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql110CheckConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql110CheckConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110CheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> ISql110CheckConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class ClrTypeMethod : ISql110ClrTypeMethod
	{		
		String ISql110ClrTypeMethod.Name 
		{
			get { return this.Name;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> ISql110ClrTypeMethod.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql110ClrTypeMethod.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}
	}
	public partial class ClrTypeMethodParameter : ISql110ClrTypeMethodParameter
	{		
		Boolean ISql110ClrTypeMethodParameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		String ISql110ClrTypeMethodParameter.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> ISql110ClrTypeMethodParameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class ClrTypeProperty : ISql110ClrTypeProperty
	{		
		String ISql110ClrTypeProperty.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql110ClrTypeProperty.ClrType 
		{
			get 
			{
				return this.ClrType;
			}
		}
	}
	public partial class ColumnStoreIndex : ISql110ColumnStoreIndex
	{		
		Boolean ISql110ColumnStoreIndex.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql110ColumnStoreIndex.Disabled 
		{
			get { return this.Disabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110ColumnStoreIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> ISql110ColumnStoreIndex.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110ColumnStoreIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql110ColumnStoreIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110ColumnStoreIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110ColumnStoreIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Contract : ISql110Contract
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Contract.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110MessageType> ISql110Contract.Messages 
		{
			get 
			{
				return this.Messages;
			}
		}
	}
	public partial class Credential : ISql110Credential
	{		
		String ISql110Credential.Identity 
		{
			get { return this.Identity;}
		}
		String ISql110Credential.Secret 
		{
			get { return this.Secret;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110CryptographicProvider> ISql110Credential.CryptographicProvider 
		{
			get 
			{
				return this.CryptographicProvider;
			}
		}
	}
	public partial class CryptographicProvider : ISql110CryptographicProvider
	{		
		String ISql110CryptographicProvider.DllPath 
		{
			get { return this.DllPath;}
		}
		Boolean ISql110CryptographicProvider.Enabled 
		{
			get { return this.Enabled;}
		}
	}
	public partial class DatabaseAuditSpecification : ISql110DatabaseAuditSpecification
	{		
		Boolean ISql110DatabaseAuditSpecification.WithState 
		{
			get { return this.WithState;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditActionGroup> ISql110DatabaseAuditSpecification.AuditActionGroups 
		{
			get 
			{
				return this.AuditActionGroups;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditAction> ISql110DatabaseAuditSpecification.AuditActions 
		{
			get 
			{
				return this.AuditActions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ServerAudit> ISql110DatabaseAuditSpecification.ServerAudit 
		{
			get 
			{
				return this.ServerAudit;
			}
		}
	}
	public partial class DatabaseDdlTrigger : ISql110DatabaseDdlTrigger
	{		
		Boolean? ISql110DatabaseDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql110DatabaseDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql110DatabaseDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql110DatabaseDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql110DatabaseDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110DatabaseDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql110DatabaseDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql110DatabaseDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql110DatabaseDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql110DatabaseDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110DatabaseDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110DatabaseDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> ISql110DatabaseDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql110DatabaseDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110DatabaseDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110DatabaseDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class DatabaseEncryptionKey : ISql110DatabaseEncryptionKey
	{		
		SymmetricKeyAlgorithm ISql110DatabaseEncryptionKey.Algorithm 
		{
			get { return this.Algorithm;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> ISql110DatabaseEncryptionKey.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110DatabaseEncryptionKey.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class DatabaseEventNotification : ISql110DatabaseEventNotification
	{		
		String ISql110DatabaseEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql110DatabaseEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql110DatabaseEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> ISql110DatabaseEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql110DatabaseEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class DatabaseMirroringLanguageSpecifier : ISql110DatabaseMirroringLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql110DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql110DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql110DatabaseMirroringLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		DatabaseMirroringRole ISql110DatabaseMirroringLanguageSpecifier.RoleType 
		{
			get { return this.RoleType;}
		}
		Boolean ISql110DatabaseMirroringLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql110DatabaseMirroringLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110DatabaseMirroringLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class DatabaseOptions : ISql110DatabaseOptions
	{		
		Boolean ISql110DatabaseOptions.AllowSnapshotIsolation 
		{
			get { return this.AllowSnapshotIsolation;}
		}
		Boolean ISql110DatabaseOptions.AnsiNullDefaultOn 
		{
			get { return this.AnsiNullDefaultOn;}
		}
		Boolean ISql110DatabaseOptions.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql110DatabaseOptions.AnsiPaddingOn 
		{
			get { return this.AnsiPaddingOn;}
		}
		Boolean ISql110DatabaseOptions.AnsiWarningsOn 
		{
			get { return this.AnsiWarningsOn;}
		}
		Boolean ISql110DatabaseOptions.ArithAbortOn 
		{
			get { return this.ArithAbortOn;}
		}
		Boolean ISql110DatabaseOptions.AutoClose 
		{
			get { return this.AutoClose;}
		}
		Boolean ISql110DatabaseOptions.AutoCreateStatistics 
		{
			get { return this.AutoCreateStatistics;}
		}
		Boolean ISql110DatabaseOptions.AutoShrink 
		{
			get { return this.AutoShrink;}
		}
		Boolean ISql110DatabaseOptions.AutoUpdateStatistics 
		{
			get { return this.AutoUpdateStatistics;}
		}
		Boolean ISql110DatabaseOptions.AutoUpdateStatisticsAsync 
		{
			get { return this.AutoUpdateStatisticsAsync;}
		}
		Boolean ISql110DatabaseOptions.ChangeTrackingAutoCleanup 
		{
			get { return this.ChangeTrackingAutoCleanup;}
		}
		Boolean ISql110DatabaseOptions.ChangeTrackingEnabled 
		{
			get { return this.ChangeTrackingEnabled;}
		}
		Int32 ISql110DatabaseOptions.ChangeTrackingRetentionPeriod 
		{
			get { return this.ChangeTrackingRetentionPeriod;}
		}
		TimeUnit ISql110DatabaseOptions.ChangeTrackingRetentionUnit 
		{
			get { return this.ChangeTrackingRetentionUnit;}
		}
		String ISql110DatabaseOptions.Collation 
		{
			get { return this.Collation;}
		}
		Int32 ISql110DatabaseOptions.CompatibilityLevel 
		{
			get { return this.CompatibilityLevel;}
		}
		Boolean ISql110DatabaseOptions.ConcatNullYieldsNull 
		{
			get { return this.ConcatNullYieldsNull;}
		}
		Containment ISql110DatabaseOptions.Containment 
		{
			get { return this.Containment;}
		}
		Boolean ISql110DatabaseOptions.CursorCloseOnCommit 
		{
			get { return this.CursorCloseOnCommit;}
		}
		Boolean ISql110DatabaseOptions.CursorDefaultGlobalScope 
		{
			get { return this.CursorDefaultGlobalScope;}
		}
		Boolean ISql110DatabaseOptions.DatabaseStateOffline 
		{
			get { return this.DatabaseStateOffline;}
		}
		Boolean ISql110DatabaseOptions.DateCorrelationOptimizationOn 
		{
			get { return this.DateCorrelationOptimizationOn;}
		}
		Boolean ISql110DatabaseOptions.DBChainingOn 
		{
			get { return this.DBChainingOn;}
		}
		String ISql110DatabaseOptions.DefaultFullTextLanguage 
		{
			get { return this.DefaultFullTextLanguage;}
		}
		String ISql110DatabaseOptions.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		String ISql110DatabaseOptions.FileStreamDirectoryName 
		{
			get { return this.FileStreamDirectoryName;}
		}
		Boolean ISql110DatabaseOptions.FullTextEnabled 
		{
			get { return this.FullTextEnabled;}
		}
		Boolean ISql110DatabaseOptions.HonorBrokerPriority 
		{
			get { return this.HonorBrokerPriority;}
		}
		Boolean ISql110DatabaseOptions.MemoryOptimizedElevateToSnapshot 
		{
			get { return this.MemoryOptimizedElevateToSnapshot;}
		}
		Boolean ISql110DatabaseOptions.NestedTriggersOn 
		{
			get { return this.NestedTriggersOn;}
		}
		NonTransactedFileStreamAccess ISql110DatabaseOptions.NonTransactedFileStreamAccess 
		{
			get { return this.NonTransactedFileStreamAccess;}
		}
		Boolean ISql110DatabaseOptions.NumericRoundAbortOn 
		{
			get { return this.NumericRoundAbortOn;}
		}
		PageVerifyMode ISql110DatabaseOptions.PageVerifyMode 
		{
			get { return this.PageVerifyMode;}
		}
		ParameterizationOption ISql110DatabaseOptions.ParameterizationOption 
		{
			get { return this.ParameterizationOption;}
		}
		Boolean ISql110DatabaseOptions.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110DatabaseOptions.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		RecoveryMode ISql110DatabaseOptions.RecoveryMode 
		{
			get { return this.RecoveryMode;}
		}
		Boolean ISql110DatabaseOptions.RecursiveTriggersOn 
		{
			get { return this.RecursiveTriggersOn;}
		}
		ServiceBrokerOption ISql110DatabaseOptions.ServiceBrokerOption 
		{
			get { return this.ServiceBrokerOption;}
		}
		Boolean ISql110DatabaseOptions.SupplementalLoggingOn 
		{
			get { return this.SupplementalLoggingOn;}
		}
		Int32 ISql110DatabaseOptions.TargetRecoveryTimePeriod 
		{
			get { return this.TargetRecoveryTimePeriod;}
		}
		TimeUnit ISql110DatabaseOptions.TargetRecoveryTimeUnit 
		{
			get { return this.TargetRecoveryTimeUnit;}
		}
		Boolean ISql110DatabaseOptions.TornPageProtectionOn 
		{
			get { return this.TornPageProtectionOn;}
		}
		Boolean ISql110DatabaseOptions.TransactionIsolationReadCommittedSnapshot 
		{
			get { return this.TransactionIsolationReadCommittedSnapshot;}
		}
		Boolean ISql110DatabaseOptions.TransformNoiseWords 
		{
			get { return this.TransformNoiseWords;}
		}
		Boolean ISql110DatabaseOptions.Trustworthy 
		{
			get { return this.Trustworthy;}
		}
		Int16 ISql110DatabaseOptions.TwoDigitYearCutoff 
		{
			get { return this.TwoDigitYearCutoff;}
		}
		UserAccessOption ISql110DatabaseOptions.UserAccessOption 
		{
			get { return this.UserAccessOption;}
		}
		Boolean ISql110DatabaseOptions.VardecimalStorageFormatOn 
		{
			get { return this.VardecimalStorageFormatOn;}
		}
		Boolean ISql110DatabaseOptions.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110DatabaseOptions.DefaultFilegroup 
		{
			get 
			{
				return this.DefaultFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110DatabaseOptions.DefaultFileStreamFilegroup 
		{
			get 
			{
				return this.DefaultFileStreamFilegroup;
			}
		}
	}
	public partial class DataCompressionOption : ISql110DataCompressionOption
	{		
		CompressionLevel ISql110DataCompressionOption.CompressionLevel 
		{
			get { return this.CompressionLevel;}
		}
		Int32 ISql110DataCompressionOption.PartitionNumber 
		{
			get { return this.PartitionNumber;}
		}
	}
	public partial class Default : ISql110Default
	{		
		String ISql110Default.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Default.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Default.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class DefaultConstraint : ISql110DefaultConstraint
	{		
		Boolean ISql110DefaultConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql110DefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql110DefaultConstraint.WithValues 
		{
			get { return this.WithValues;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110DefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> ISql110DefaultConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110DefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class DmlTrigger : ISql110DmlTrigger
	{		
		Boolean? ISql110DmlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql110DmlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		OrderRestriction ISql110DmlTrigger.DeleteOrderRestriction 
		{
			get { return this.DeleteOrderRestriction;}
		}
		Boolean ISql110DmlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql110DmlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql110DmlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110DmlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		OrderRestriction ISql110DmlTrigger.InsertOrderRestriction 
		{
			get { return this.InsertOrderRestriction;}
		}
		Boolean ISql110DmlTrigger.IsDeleteTrigger 
		{
			get { return this.IsDeleteTrigger;}
		}
		Boolean ISql110DmlTrigger.IsInsertTrigger 
		{
			get { return this.IsInsertTrigger;}
		}
		Boolean ISql110DmlTrigger.IsUpdateTrigger 
		{
			get { return this.IsUpdateTrigger;}
		}
		String ISql110DmlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean ISql110DmlTrigger.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		Boolean? ISql110DmlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql110DmlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		OrderRestriction ISql110DmlTrigger.UpdateOrderRestriction 
		{
			get { return this.UpdateOrderRestriction;}
		}
		Boolean ISql110DmlTrigger.WithAppend 
		{
			get { return this.WithAppend;}
		}
		Boolean ISql110DmlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110DmlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110DmlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110DmlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql110DmlTrigger.TriggerObject 
		{
			get 
			{
				return this.TriggerObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110DmlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Endpoint : ISql110Endpoint
	{		
		Payload ISql110Endpoint.Payload 
		{
			get { return this.Payload;}
		}
		Protocol ISql110Endpoint.Protocol 
		{
			get { return this.Protocol;}
		}
		State ISql110Endpoint.State 
		{
			get { return this.State;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Endpoint.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> ISql110Endpoint.PayloadSpecifier 
		{
			get 
			{
				return this.PayloadSpecifier;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ISql110Endpoint.ProtocolSpecifier 
		{
			get 
			{
				return this.ProtocolSpecifier;
			}
		}
	}
	public partial class ErrorMessage : ISql110ErrorMessage
	{		
		String ISql110ErrorMessage.Language 
		{
			get { return this.Language;}
		}
		Int32 ISql110ErrorMessage.MessageNumber 
		{
			get { return this.MessageNumber;}
		}
		String ISql110ErrorMessage.MessageText 
		{
			get { return this.MessageText;}
		}
		Int32 ISql110ErrorMessage.Severity 
		{
			get { return this.Severity;}
		}
		Boolean ISql110ErrorMessage.WithLog 
		{
			get { return this.WithLog;}
		}
	}
	public partial class EventGroup : ISql110EventGroup
	{		
		EventGroupType ISql110EventGroup.Group 
		{
			get { return this.Group;}
		}
	}
	public partial class EventSession : ISql110EventSession
	{		
		EventRetentionMode ISql110EventSession.EventRetentionMode 
		{
			get { return this.EventRetentionMode;}
		}
		Int32 ISql110EventSession.MaxDispatchLatency 
		{
			get { return this.MaxDispatchLatency;}
		}
		Int32 ISql110EventSession.MaxEventSize 
		{
			get { return this.MaxEventSize;}
		}
		MemoryUnit ISql110EventSession.MaxEventSizeUnit 
		{
			get { return this.MaxEventSizeUnit;}
		}
		Int32 ISql110EventSession.MaxMemory 
		{
			get { return this.MaxMemory;}
		}
		MemoryUnit ISql110EventSession.MaxMemoryUnit 
		{
			get { return this.MaxMemoryUnit;}
		}
		MemoryPartitionMode ISql110EventSession.MemoryPartitionMode 
		{
			get { return this.MemoryPartitionMode;}
		}
		Boolean ISql110EventSession.StartupState 
		{
			get { return this.StartupState;}
		}
		Boolean ISql110EventSession.TrackCausality 
		{
			get { return this.TrackCausality;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110EventSession.EventDefinitions 
		{
			get 
			{
				return this.EventDefinitions;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110EventSession.EventTargets 
		{
			get 
			{
				return this.EventTargets;
			}
		}
	}
	public partial class EventSessionAction : ISql110EventSessionAction
	{		
		String ISql110EventSessionAction.ActionName 
		{
			get { return this.ActionName;}
		}
		String ISql110EventSessionAction.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql110EventSessionAction.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
	}
	public partial class EventSessionDefinitions : ISql110EventSessionDefinitions
	{		
		String ISql110EventSessionDefinitions.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql110EventSessionDefinitions.EventName 
		{
			get { return this.EventName;}
		}
		String ISql110EventSessionDefinitions.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
		String ISql110EventSessionDefinitions.WhereExpression 
		{
			get { return this.WhereExpression;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventSessionAction> ISql110EventSessionDefinitions.Actions 
		{
			get 
			{
				return this.Actions;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110EventSessionDefinitions.AttributeSettings 
		{
			get 
			{
				return this.AttributeSettings;
			}
		}
	}
	public partial class EventSessionSetting : ISql110EventSessionSetting
	{		
		String ISql110EventSessionSetting.SettingName 
		{
			get { return this.SettingName;}
		}
		String ISql110EventSessionSetting.SettingValue 
		{
			get { return this.SettingValue;}
		}
	}
	public partial class EventSessionTarget : ISql110EventSessionTarget
	{		
		String ISql110EventSessionTarget.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql110EventSessionTarget.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
		String ISql110EventSessionTarget.TargetName 
		{
			get { return this.TargetName;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110EventSessionTarget.ParameterSettings 
		{
			get 
			{
				return this.ParameterSettings;
			}
		}
	}
	public partial class EventTypeSpecifier : ISql110EventTypeSpecifier
	{		
		EventType ISql110EventTypeSpecifier.EventType 
		{
			get { return this.EventType;}
		}
		OrderRestriction ISql110EventTypeSpecifier.Order 
		{
			get { return this.Order;}
		}
	}
	public partial class ExtendedProcedure : ISql110ExtendedProcedure
	{		
		Boolean ISql110ExtendedProcedure.ExeccuteAsCaller 
		{
			get { return this.ExeccuteAsCaller;}
		}
		Boolean ISql110ExtendedProcedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110ExtendedProcedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql110ExtendedProcedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110ExtendedProcedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> ISql110ExtendedProcedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110ExtendedProcedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110ExtendedProcedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ExtendedProperty : ISql110ExtendedProperty
	{		
		String ISql110ExtendedProperty.Value 
		{
			get { return this.Value;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> ISql110ExtendedProperty.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class SqlFile : ISql110SqlFile
	{		
		Int32? ISql110SqlFile.FileGrowth 
		{
			get { return this.FileGrowth;}
		}
		MemoryUnit ISql110SqlFile.FileGrowthUnit 
		{
			get { return this.FileGrowthUnit;}
		}
		String ISql110SqlFile.FileName 
		{
			get { return this.FileName;}
		}
		Boolean ISql110SqlFile.IsLogFile 
		{
			get { return this.IsLogFile;}
		}
		Int32? ISql110SqlFile.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql110SqlFile.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		Boolean ISql110SqlFile.Offline 
		{
			get { return this.Offline;}
		}
		Int32? ISql110SqlFile.Size 
		{
			get { return this.Size;}
		}
		MemoryUnit ISql110SqlFile.SizeUnit 
		{
			get { return this.SizeUnit;}
		}
		Boolean ISql110SqlFile.Unlimited 
		{
			get { return this.Unlimited;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110SqlFile.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class Filegroup : ISql110Filegroup
	{		
		Boolean ISql110Filegroup.ContainsFileStream 
		{
			get { return this.ContainsFileStream;}
		}
		Boolean ISql110Filegroup.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
	}
	public partial class ForeignKeyConstraint : ISql110ForeignKeyConstraint
	{		
		ForeignKeyAction ISql110ForeignKeyConstraint.DeleteAction 
		{
			get { return this.DeleteAction;}
		}
		Boolean ISql110ForeignKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql110ForeignKeyConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		ForeignKeyAction ISql110ForeignKeyConstraint.UpdateAction 
		{
			get { return this.UpdateAction;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110ForeignKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110ForeignKeyConstraint.ForeignColumns 
		{
			get 
			{
				return this.ForeignColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Table> ISql110ForeignKeyConstraint.ForeignTable 
		{
			get 
			{
				return this.ForeignTable;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> ISql110ForeignKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class FullTextCatalog : ISql110FullTextCatalog
	{		
		Boolean? ISql110FullTextCatalog.AccentSensitivity 
		{
			get { return this.AccentSensitivity;}
		}
		Boolean ISql110FullTextCatalog.IsDefault 
		{
			get { return this.IsDefault;}
		}
		String ISql110FullTextCatalog.Path 
		{
			get { return this.Path;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110FullTextCatalog.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110FullTextCatalog.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class FullTextIndex : ISql110FullTextIndex
	{		
		ChangeTrackingOption ISql110FullTextIndex.ChangeTracking 
		{
			get { return this.ChangeTracking;}
		}
		Boolean ISql110FullTextIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql110FullTextIndex.Replicated 
		{
			get { return this.Replicated;}
		}
		Boolean ISql110FullTextIndex.StopListOff 
		{
			get { return this.StopListOff;}
		}
		Boolean ISql110FullTextIndex.UseSystemStopList 
		{
			get { return this.UseSystemStopList;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110FullTextIndex.Catalog 
		{
			get 
			{
				return this.Catalog;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110FullTextIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110FullTextIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql110FullTextIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SearchPropertyList> ISql110FullTextIndex.SearchPropertyList 
		{
			get 
			{
				return this.SearchPropertyList;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110FullTextIndex.StopList 
		{
			get 
			{
				return this.StopList;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110FullTextIndex.UniqueIndexName 
		{
			get 
			{
				return this.UniqueIndexName;
			}
		}
	}
	public partial class FullTextIndexColumnSpecifier : ISql110FullTextIndexColumnSpecifier
	{		
		Int32? ISql110FullTextIndexColumnSpecifier.LanguageId 
		{
			get { return this.LanguageId;}
		}
		Boolean ISql110FullTextIndexColumnSpecifier.PartOfStatisticalSemantics 
		{
			get { return this.PartOfStatisticalSemantics;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110FullTextIndexColumnSpecifier.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110FullTextIndexColumnSpecifier.TypeColumn 
		{
			get 
			{
				return this.TypeColumn;
			}
		}
	}
	public partial class FullTextStopList : ISql110FullTextStopList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110FullTextStopList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class HttpProtocolSpecifier : ISql110HttpProtocolSpecifier
	{		
		AuthenticationModes ISql110HttpProtocolSpecifier.AuthenticationMode 
		{
			get { return this.AuthenticationMode;}
		}
		String ISql110HttpProtocolSpecifier.AuthenticationRealm 
		{
			get { return this.AuthenticationRealm;}
		}
		Int32? ISql110HttpProtocolSpecifier.ClearPort 
		{
			get { return this.ClearPort;}
		}
		Boolean ISql110HttpProtocolSpecifier.CompressionEnabled 
		{
			get { return this.CompressionEnabled;}
		}
		String ISql110HttpProtocolSpecifier.DefaultLogonDomain 
		{
			get { return this.DefaultLogonDomain;}
		}
		Boolean ISql110HttpProtocolSpecifier.ListeningOnAllNoneReservedSites 
		{
			get { return this.ListeningOnAllNoneReservedSites;}
		}
		Boolean ISql110HttpProtocolSpecifier.ListeningOnAllSites 
		{
			get { return this.ListeningOnAllSites;}
		}
		String ISql110HttpProtocolSpecifier.Path 
		{
			get { return this.Path;}
		}
		HttpPorts ISql110HttpProtocolSpecifier.Ports 
		{
			get { return this.Ports;}
		}
		Int32? ISql110HttpProtocolSpecifier.SslPort 
		{
			get { return this.SslPort;}
		}
		String ISql110HttpProtocolSpecifier.Website 
		{
			get { return this.Website;}
		}
	}
	public partial class LinkedServer : ISql110LinkedServer
	{		
		String ISql110LinkedServer.Catalog 
		{
			get { return this.Catalog;}
		}
		Boolean ISql110LinkedServer.CollationCompatible 
		{
			get { return this.CollationCompatible;}
		}
		String ISql110LinkedServer.CollationName 
		{
			get { return this.CollationName;}
		}
		Int32 ISql110LinkedServer.ConnectTimeout 
		{
			get { return this.ConnectTimeout;}
		}
		Boolean ISql110LinkedServer.DataAccess 
		{
			get { return this.DataAccess;}
		}
		String ISql110LinkedServer.DataSource 
		{
			get { return this.DataSource;}
		}
		Boolean ISql110LinkedServer.IsDistributor 
		{
			get { return this.IsDistributor;}
		}
		Boolean ISql110LinkedServer.IsPublisher 
		{
			get { return this.IsPublisher;}
		}
		Boolean ISql110LinkedServer.IsSubscriber 
		{
			get { return this.IsSubscriber;}
		}
		Boolean ISql110LinkedServer.LazySchemaValidationEnabled 
		{
			get { return this.LazySchemaValidationEnabled;}
		}
		String ISql110LinkedServer.Location 
		{
			get { return this.Location;}
		}
		String ISql110LinkedServer.ProductName 
		{
			get { return this.ProductName;}
		}
		String ISql110LinkedServer.ProviderName 
		{
			get { return this.ProviderName;}
		}
		String ISql110LinkedServer.ProviderString 
		{
			get { return this.ProviderString;}
		}
		Int32 ISql110LinkedServer.QueryTimeout 
		{
			get { return this.QueryTimeout;}
		}
		Boolean ISql110LinkedServer.RemoteProcTransactionPromotionEnabled 
		{
			get { return this.RemoteProcTransactionPromotionEnabled;}
		}
		Boolean ISql110LinkedServer.RpcEnabled 
		{
			get { return this.RpcEnabled;}
		}
		Boolean ISql110LinkedServer.RpcOutEnabled 
		{
			get { return this.RpcOutEnabled;}
		}
		Boolean ISql110LinkedServer.UseRemoteCollation 
		{
			get { return this.UseRemoteCollation;}
		}
	}
	public partial class LinkedServerLogin : ISql110LinkedServerLogin
	{		
		String ISql110LinkedServerLogin.LinkedServerLoginName 
		{
			get { return this.LinkedServerLoginName;}
		}
		String ISql110LinkedServerLogin.LinkedServerPassword 
		{
			get { return this.LinkedServerPassword;}
		}
		Boolean ISql110LinkedServerLogin.UseSelf 
		{
			get { return this.UseSelf;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110LinkedServer> ISql110LinkedServerLogin.LinkedServer 
		{
			get 
			{
				return this.LinkedServer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110LinkedServerLogin.LocalLogin 
		{
			get 
			{
				return this.LocalLogin;
			}
		}
	}
	public partial class Login : ISql110Login
	{		
		Boolean ISql110Login.CheckExpiration 
		{
			get { return this.CheckExpiration;}
		}
		Boolean ISql110Login.CheckPolicy 
		{
			get { return this.CheckPolicy;}
		}
		String ISql110Login.DefaultDatabase 
		{
			get { return this.DefaultDatabase;}
		}
		String ISql110Login.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		Boolean ISql110Login.Disabled 
		{
			get { return this.Disabled;}
		}
		LoginEncryptionOption ISql110Login.EncryptionOption 
		{
			get { return this.EncryptionOption;}
		}
		Boolean ISql110Login.MappedToWindowsLogin 
		{
			get { return this.MappedToWindowsLogin;}
		}
		String ISql110Login.Password 
		{
			get { return this.Password;}
		}
		Boolean ISql110Login.PasswordHashed 
		{
			get { return this.PasswordHashed;}
		}
		Boolean ISql110Login.PasswordMustChange 
		{
			get { return this.PasswordMustChange;}
		}
		String ISql110Login.Sid 
		{
			get { return this.Sid;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> ISql110Login.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110Login.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Credential> ISql110Login.Credential 
		{
			get 
			{
				return this.Credential;
			}
		}
	}
	public partial class MasterKey : ISql110MasterKey
	{		
		String ISql110MasterKey.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class MessageType : ISql110MessageType
	{		
		ValidationMethod ISql110MessageType.ValidationMethod 
		{
			get { return this.ValidationMethod;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110MessageType.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> ISql110MessageType.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class PartitionFunction : ISql110PartitionFunction
	{		
		PartitionRange ISql110PartitionFunction.Range 
		{
			get { return this.Range;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionValue> ISql110PartitionFunction.BoundaryValues 
		{
			get 
			{
				return this.BoundaryValues;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql110PartitionFunction.ParameterType 
		{
			get 
			{
				return this.ParameterType;
			}
		}
	}
	public partial class PartitionScheme : ISql110PartitionScheme
	{		
		Boolean ISql110PartitionScheme.AllToOneFilegroup 
		{
			get { return this.AllToOneFilegroup;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110PartitionScheme.Filegroups 
		{
			get 
			{
				return this.Filegroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionFunction> ISql110PartitionScheme.PartitionFunction 
		{
			get 
			{
				return this.PartitionFunction;
			}
		}
	}
	public partial class PartitionValue : ISql110PartitionValue
	{		
		String ISql110PartitionValue.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110PartitionValue.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class Permission : ISql110Permission
	{		
		PermissionAction ISql110Permission.PermissionAction 
		{
			get { return this.PermissionAction;}
		}
		PermissionType ISql110Permission.PermissionType 
		{
			get { return this.PermissionType;}
		}
		Boolean ISql110Permission.WithAllPrivileges 
		{
			get { return this.WithAllPrivileges;}
		}
		Boolean ISql110Permission.WithGrantOption 
		{
			get { return this.WithGrantOption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Permission.ExcludedColumns 
		{
			get 
			{
				return this.ExcludedColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql110Permission.Grantee 
		{
			get 
			{
				return this.Grantee;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql110Permission.Grantor 
		{
			get 
			{
				return this.Grantor;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Permission.RevokedGrantOptionColumns 
		{
			get 
			{
				return this.RevokedGrantOptionColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql110Permission.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class PrimaryKeyConstraint : ISql110PrimaryKeyConstraint
	{		
		Boolean ISql110PrimaryKeyConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql110PrimaryKeyConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql110PrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql110PrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql110PrimaryKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql110PrimaryKeyConstraint.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql110PrimaryKeyConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql110PrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql110PrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql110PrimaryKeyConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql110PrimaryKeyConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110PrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> ISql110PrimaryKeyConstraint.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110PrimaryKeyConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110PrimaryKeyConstraint.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110PrimaryKeyConstraint.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> ISql110PrimaryKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110PrimaryKeyConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110PrimaryKeyConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Procedure : ISql110Procedure
	{		
		Boolean? ISql110Procedure.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql110Procedure.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql110Procedure.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql110Procedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110Procedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql110Procedure.ForReplication 
		{
			get { return this.ForReplication;}
		}
		Boolean ISql110Procedure.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql110Procedure.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql110Procedure.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110Procedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql110Procedure.WithRecompile 
		{
			get { return this.WithRecompile;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110Procedure.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Procedure.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110Procedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> ISql110Procedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Procedure> ISql110Procedure.ParentProcedure 
		{
			get 
			{
				return this.ParentProcedure;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Procedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110Procedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Queue : ISql110Queue
	{		
		Boolean ISql110Queue.ActivationExecuteAsCaller 
		{
			get { return this.ActivationExecuteAsCaller;}
		}
		Boolean ISql110Queue.ActivationExecuteAsOwner 
		{
			get { return this.ActivationExecuteAsOwner;}
		}
		Boolean ISql110Queue.ActivationExecuteAsSelf 
		{
			get { return this.ActivationExecuteAsSelf;}
		}
		Int32? ISql110Queue.ActivationMaxQueueReaders 
		{
			get { return this.ActivationMaxQueueReaders;}
		}
		Boolean? ISql110Queue.ActivationStatusOn 
		{
			get { return this.ActivationStatusOn;}
		}
		Boolean ISql110Queue.PoisonMessageHandlingStatusOn 
		{
			get { return this.PoisonMessageHandlingStatusOn;}
		}
		Boolean ISql110Queue.RetentionOn 
		{
			get { return this.RetentionOn;}
		}
		Boolean ISql110Queue.StatusOn 
		{
			get { return this.StatusOn;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Procedure> ISql110Queue.ActivationProcedure 
		{
			get 
			{
				return this.ActivationProcedure;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Queue.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110Queue.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110Queue.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Queue.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110Queue.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Queue.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110Queue.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class QueueEventNotification : ISql110QueueEventNotification
	{		
		String ISql110QueueEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql110QueueEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql110QueueEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> ISql110QueueEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql110QueueEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Queue> ISql110QueueEventNotification.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class RemoteServiceBinding : ISql110RemoteServiceBinding
	{		
		Boolean ISql110RemoteServiceBinding.Anonymous 
		{
			get { return this.Anonymous;}
		}
		String ISql110RemoteServiceBinding.Service 
		{
			get { return this.Service;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110RemoteServiceBinding.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110RemoteServiceBinding.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ResourceGovernor : ISql110ResourceGovernor
	{		
		Boolean? ISql110ResourceGovernor.Enabled 
		{
			get { return this.Enabled;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110ResourceGovernor.ClassifierFunction 
		{
			get 
			{
				return this.ClassifierFunction;
			}
		}
	}
	public partial class ResourcePool : ISql110ResourcePool
	{		
		Int32 ISql110ResourcePool.CapCpuPercent 
		{
			get { return this.CapCpuPercent;}
		}
		Int32 ISql110ResourcePool.MaxCpuPercent 
		{
			get { return this.MaxCpuPercent;}
		}
		Int32 ISql110ResourcePool.MaxMemoryPercent 
		{
			get { return this.MaxMemoryPercent;}
		}
		Int32 ISql110ResourcePool.MinCpuPercent 
		{
			get { return this.MinCpuPercent;}
		}
		Int32 ISql110ResourcePool.MinMemoryPercent 
		{
			get { return this.MinMemoryPercent;}
		}
	}
	public partial class Role : ISql110Role
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Role.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class RoleMembership : ISql110RoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql110RoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Role> ISql110RoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Route : ISql110Route
	{		
		String ISql110Route.Address 
		{
			get { return this.Address;}
		}
		String ISql110Route.BrokerInstance 
		{
			get { return this.BrokerInstance;}
		}
		Int32? ISql110Route.Lifetime 
		{
			get { return this.Lifetime;}
		}
		String ISql110Route.MirrorAddress 
		{
			get { return this.MirrorAddress;}
		}
		String ISql110Route.ServiceName 
		{
			get { return this.ServiceName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Route.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Rule : ISql110Rule
	{		
		String ISql110Rule.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Rule.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Rule.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Schema : ISql110Schema
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Schema.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class SearchProperty : ISql110SearchProperty
	{		
		String ISql110SearchProperty.Description 
		{
			get { return this.Description;}
		}
		Int32 ISql110SearchProperty.Identifier 
		{
			get { return this.Identifier;}
		}
		String ISql110SearchProperty.PropertySetGuid 
		{
			get { return this.PropertySetGuid;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SearchPropertyList> ISql110SearchProperty.SearchPropertyList 
		{
			get 
			{
				return this.SearchPropertyList;
			}
		}
	}
	public partial class SearchPropertyList : ISql110SearchPropertyList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110SearchPropertyList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Sequence : ISql110Sequence
	{		
		Int32? ISql110Sequence.CacheSize 
		{
			get { return this.CacheSize;}
		}
		String ISql110Sequence.IncrementValue 
		{
			get { return this.IncrementValue;}
		}
		Boolean ISql110Sequence.IsCached 
		{
			get { return this.IsCached;}
		}
		Boolean ISql110Sequence.IsCycling 
		{
			get { return this.IsCycling;}
		}
		String ISql110Sequence.MaxValue 
		{
			get { return this.MaxValue;}
		}
		String ISql110Sequence.MinValue 
		{
			get { return this.MinValue;}
		}
		Boolean ISql110Sequence.NoMaxValue 
		{
			get { return this.NoMaxValue;}
		}
		Boolean ISql110Sequence.NoMinValue 
		{
			get { return this.NoMinValue;}
		}
		String ISql110Sequence.StartValue 
		{
			get { return this.StartValue;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> ISql110Sequence.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Sequence.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ServerAudit : ISql110ServerAudit
	{		
		String ISql110ServerAudit.AuditGuid 
		{
			get { return this.AuditGuid;}
		}
		AuditTarget ISql110ServerAudit.AuditTarget 
		{
			get { return this.AuditTarget;}
		}
		Boolean ISql110ServerAudit.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql110ServerAudit.FilePath 
		{
			get { return this.FilePath;}
		}
		Int32? ISql110ServerAudit.MaxFiles 
		{
			get { return this.MaxFiles;}
		}
		Int32? ISql110ServerAudit.MaxRolloverFiles 
		{
			get { return this.MaxRolloverFiles;}
		}
		Int32? ISql110ServerAudit.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql110ServerAudit.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		FailureAction ISql110ServerAudit.OnFailure 
		{
			get { return this.OnFailure;}
		}
		String ISql110ServerAudit.PredicateExpression 
		{
			get { return this.PredicateExpression;}
		}
		Int32 ISql110ServerAudit.QueueDelay 
		{
			get { return this.QueueDelay;}
		}
		Boolean ISql110ServerAudit.ReserveDiskSpace 
		{
			get { return this.ReserveDiskSpace;}
		}
		Boolean ISql110ServerAudit.UnlimitedFileSize 
		{
			get { return this.UnlimitedFileSize;}
		}
		Boolean ISql110ServerAudit.UnlimitedMaxRolloverFiles 
		{
			get { return this.UnlimitedMaxRolloverFiles;}
		}
	}
	public partial class ServerAuditSpecification : ISql110ServerAuditSpecification
	{		
		Boolean ISql110ServerAuditSpecification.StateOn 
		{
			get { return this.StateOn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditActionGroup> ISql110ServerAuditSpecification.AuditActionGroups 
		{
			get 
			{
				return this.AuditActionGroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ServerAudit> ISql110ServerAuditSpecification.ServerAudit 
		{
			get 
			{
				return this.ServerAudit;
			}
		}
	}
	public partial class ServerDdlTrigger : ISql110ServerDdlTrigger
	{		
		Boolean? ISql110ServerDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql110ServerDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql110ServerDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql110ServerDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql110ServerDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql110ServerDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql110ServerDdlTrigger.IsLogon 
		{
			get { return this.IsLogon;}
		}
		String ISql110ServerDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql110ServerDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql110ServerDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql110ServerDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110ServerDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110ServerDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> ISql110ServerDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql110ServerDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110ServerDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> ISql110ServerDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ServerEventNotification : ISql110ServerEventNotification
	{		
		String ISql110ServerEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql110ServerEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql110ServerEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> ISql110ServerEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql110ServerEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class ServerOptions : ISql110ServerOptions
	{		
	}
	public partial class ServerRoleMembership : ISql110ServerRoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> ISql110ServerRoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Role> ISql110ServerRoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Service : ISql110Service
	{		
		Boolean ISql110Service.UseDefaultContract 
		{
			get { return this.UseDefaultContract;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110Service.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Contract> ISql110Service.Contracts 
		{
			get 
			{
				return this.Contracts;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Queue> ISql110Service.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class ServiceBrokerLanguageSpecifier : ISql110ServiceBrokerLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql110ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql110ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql110ServiceBrokerLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		Boolean ISql110ServiceBrokerLanguageSpecifier.MessageForwardingEnabled 
		{
			get { return this.MessageForwardingEnabled;}
		}
		Int32 ISql110ServiceBrokerLanguageSpecifier.MessageForwardSize 
		{
			get { return this.MessageForwardSize;}
		}
		Boolean ISql110ServiceBrokerLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql110ServiceBrokerLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110ServiceBrokerLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class Signature : ISql110Signature
	{		
		Boolean ISql110Signature.IsCounterSignature 
		{
			get { return this.IsCounterSignature;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110Signature.EncryptionMechanism 
		{
			get 
			{
				return this.EncryptionMechanism;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql110Signature.SignedObject 
		{
			get 
			{
				return this.SignedObject;
			}
		}
	}
	public partial class SignatureEncryptionMechanism : ISql110SignatureEncryptionMechanism
	{		
		String ISql110SignatureEncryptionMechanism.Password 
		{
			get { return this.Password;}
		}
		String ISql110SignatureEncryptionMechanism.SignedBlob 
		{
			get { return this.SignedBlob;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> ISql110SignatureEncryptionMechanism.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110SignatureEncryptionMechanism.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class SoapLanguageSpecifier : ISql110SoapLanguageSpecifier
	{		
		Boolean ISql110SoapLanguageSpecifier.BatchesEnabled 
		{
			get { return this.BatchesEnabled;}
		}
		CharacterSet ISql110SoapLanguageSpecifier.CharacterSet 
		{
			get { return this.CharacterSet;}
		}
		String ISql110SoapLanguageSpecifier.DatabaseName 
		{
			get { return this.DatabaseName;}
		}
		Int32 ISql110SoapLanguageSpecifier.HeaderLimit 
		{
			get { return this.HeaderLimit;}
		}
		Boolean ISql110SoapLanguageSpecifier.IsDefaultDatabase 
		{
			get { return this.IsDefaultDatabase;}
		}
		Boolean ISql110SoapLanguageSpecifier.IsDefaultNamespace 
		{
			get { return this.IsDefaultNamespace;}
		}
		Boolean ISql110SoapLanguageSpecifier.IsDefaultWsdlSpName 
		{
			get { return this.IsDefaultWsdlSpName;}
		}
		SoapLoginType ISql110SoapLanguageSpecifier.LoginType 
		{
			get { return this.LoginType;}
		}
		String ISql110SoapLanguageSpecifier.Namespace 
		{
			get { return this.Namespace;}
		}
		SoapSchema ISql110SoapLanguageSpecifier.SchemaType 
		{
			get { return this.SchemaType;}
		}
		Boolean ISql110SoapLanguageSpecifier.SessionsEnabled 
		{
			get { return this.SessionsEnabled;}
		}
		Int32 ISql110SoapLanguageSpecifier.SessionTimeout 
		{
			get { return this.SessionTimeout;}
		}
		Boolean ISql110SoapLanguageSpecifier.SessionTimeoutNever 
		{
			get { return this.SessionTimeoutNever;}
		}
		String ISql110SoapLanguageSpecifier.WsdlSpName 
		{
			get { return this.WsdlSpName;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SoapMethodSpecification> ISql110SoapLanguageSpecifier.WebMethods 
		{
			get 
			{
				return this.WebMethods;
			}
		}
	}
	public partial class SoapMethodSpecification : ISql110SoapMethodSpecification
	{		
		SoapFormat ISql110SoapMethodSpecification.Format 
		{
			get { return this.Format;}
		}
		SoapSchema ISql110SoapMethodSpecification.SchemaType 
		{
			get { return this.SchemaType;}
		}
		String ISql110SoapMethodSpecification.WebMethodAlias 
		{
			get { return this.WebMethodAlias;}
		}
		String ISql110SoapMethodSpecification.WebMethodNamespace 
		{
			get { return this.WebMethodNamespace;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110SoapMethodSpecification.RelatedMethod 
		{
			get 
			{
				return this.RelatedMethod;
			}
		}
	}
	public partial class SpatialIndex : ISql110SpatialIndex
	{		
		Boolean ISql110SpatialIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql110SpatialIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql110SpatialIndex.CellsPerObject 
		{
			get { return this.CellsPerObject;}
		}
		CompressionLevel ISql110SpatialIndex.DataCompression 
		{
			get { return this.DataCompression;}
		}
		Boolean ISql110SpatialIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32 ISql110SpatialIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Degree ISql110SpatialIndex.GridLevel1Density 
		{
			get { return this.GridLevel1Density;}
		}
		Degree ISql110SpatialIndex.GridLevel2Density 
		{
			get { return this.GridLevel2Density;}
		}
		Degree ISql110SpatialIndex.GridLevel3Density 
		{
			get { return this.GridLevel3Density;}
		}
		Degree ISql110SpatialIndex.GridLevel4Density 
		{
			get { return this.GridLevel4Density;}
		}
		Boolean ISql110SpatialIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql110SpatialIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Tessellation ISql110SpatialIndex.Tessellation 
		{
			get { return this.Tessellation;}
		}
		Boolean ISql110SpatialIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}
		Double? ISql110SpatialIndex.XMax 
		{
			get { return this.XMax;}
		}
		Double? ISql110SpatialIndex.XMin 
		{
			get { return this.XMin;}
		}
		Double? ISql110SpatialIndex.YMax 
		{
			get { return this.YMax;}
		}
		Double? ISql110SpatialIndex.YMin 
		{
			get { return this.YMin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110SpatialIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110SpatialIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql110SpatialIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110SpatialIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110SpatialIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Statistics : ISql110Statistics
	{		
		String ISql110Statistics.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISql110Statistics.NoRecompute 
		{
			get { return this.NoRecompute;}
		}
		Int32 ISql110Statistics.SampleSize 
		{
			get { return this.SampleSize;}
		}
		SamplingStyle ISql110Statistics.SamplingStyle 
		{
			get { return this.SamplingStyle;}
		}
		String ISql110Statistics.StatsStream 
		{
			get { return this.StatsStream;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Statistics.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Statistics.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql110Statistics.OnObject 
		{
			get 
			{
				return this.OnObject;
			}
		}
	}
	public partial class Parameter : ISql110Parameter
	{		
		String ISql110Parameter.DefaultExpression 
		{
			get { return this.DefaultExpression;}
		}
		Boolean ISql110Parameter.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql110Parameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		Int32 ISql110Parameter.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql110Parameter.Precision 
		{
			get { return this.Precision;}
		}
		Boolean ISql110Parameter.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		Int32 ISql110Parameter.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql110Parameter.Varying 
		{
			get { return this.Varying;}
		}
		XmlStyle ISql110Parameter.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> ISql110Parameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> ISql110Parameter.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class SymmetricKey : ISql110SymmetricKey
	{		
		SymmetricKeyAlgorithm ISql110SymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		SymmetricKeyCreationDisposition ISql110SymmetricKey.CreationDisposition 
		{
			get { return this.CreationDisposition;}
		}
		String ISql110SymmetricKey.IdentityValue 
		{
			get { return this.IdentityValue;}
		}
		String ISql110SymmetricKey.KeySource 
		{
			get { return this.KeySource;}
		}
		String ISql110SymmetricKey.ProviderKeyName 
		{
			get { return this.ProviderKeyName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> ISql110SymmetricKey.AsymmetricKeys 
		{
			get 
			{
				return this.AsymmetricKeys;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110SymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110SymmetricKey.Certificates 
		{
			get 
			{
				return this.Certificates;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110SymmetricKey.Passwords 
		{
			get 
			{
				return this.Passwords;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110SymmetricKey.Provider 
		{
			get 
			{
				return this.Provider;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SymmetricKey> ISql110SymmetricKey.SymmetricKeys 
		{
			get 
			{
				return this.SymmetricKeys;
			}
		}
	}
	public partial class SymmetricKeyPassword : ISql110SymmetricKeyPassword
	{		
		String ISql110SymmetricKeyPassword.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class Synonym : ISql110Synonym
	{		
		String ISql110Synonym.ForObjectName 
		{
			get { return this.ForObjectName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110Synonym.ForObject 
		{
			get 
			{
				return this.ForObject;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Synonym.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Table : ISql110Table
	{		
		Boolean? ISql110Table.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql110Table.ChangeDataCaptureEnabled 
		{
			get { return this.ChangeDataCaptureEnabled;}
		}
		Boolean ISql110Table.ChangeTrackingEnabled 
		{
			get { return this.ChangeTrackingEnabled;}
		}
		Boolean? ISql110Table.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Boolean ISql110Table.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		Boolean ISql110Table.LargeValueTypesOutOfRow 
		{
			get { return this.LargeValueTypesOutOfRow;}
		}
		LockEscalationMethod ISql110Table.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISql110Table.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110Table.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}
		Int32 ISql110Table.TextInRowSize 
		{
			get { return this.TextInRowSize;}
		}
		Boolean ISql110Table.TrackColumnsUpdated 
		{
			get { return this.TrackColumnsUpdated;}
		}
		Boolean ISql110Table.VardecimalStorageFormatEnabled 
		{
			get { return this.VardecimalStorageFormatEnabled;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Table.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> ISql110Table.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110Table.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110Table.FilegroupForTextImage 
		{
			get 
			{
				return this.FilegroupForTextImage;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110Table.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110Table.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110Table.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110Table.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110Table.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class FileTable : ISql110FileTable
	{		
		Boolean? ISql110FileTable.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql110FileTable.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		String ISql110FileTable.FileTableCollateFilename 
		{
			get { return this.FileTableCollateFilename;}
		}
		String ISql110FileTable.FileTableDirectory 
		{
			get { return this.FileTableDirectory;}
		}
		Boolean ISql110FileTable.FileTableNamespaceEnabled 
		{
			get { return this.FileTableNamespaceEnabled;}
		}
		LockEscalationMethod ISql110FileTable.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISql110FileTable.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110FileTable.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110FileTable.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> ISql110FileTable.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110FileTable.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110FileTable.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110FileTable.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110FileTable.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110FileTable.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110FileTable.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableType : ISql110TableType
	{		

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110TableType.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> ISql110TableType.Constraints 
		{
			get 
			{
				return this.Constraints;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110TableType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableTypeCheckConstraint : ISql110TableTypeCheckConstraint
	{		
		String ISql110TableTypeCheckConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110TableTypeCheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class TableTypeColumn : ISql110TableTypeColumn
	{		
		String ISql110TableTypeColumn.Collation 
		{
			get { return this.Collation;}
		}
		String ISql110TableTypeColumn.Expression 
		{
			get { return this.Expression;}
		}
		String ISql110TableTypeColumn.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql110TableTypeColumn.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql110TableTypeColumn.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql110TableTypeColumn.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql110TableTypeColumn.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql110TableTypeColumn.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql110TableTypeColumn.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql110TableTypeColumn.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql110TableTypeColumn.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql110TableTypeColumn.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql110TableTypeColumn.Scale 
		{
			get { return this.Scale;}
		}
		XmlStyle ISql110TableTypeColumn.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> ISql110TableTypeColumn.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110TableTypeColumn.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> ISql110TableTypeColumn.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableTypeDefaultConstraint : ISql110TableTypeDefaultConstraint
	{		
		String ISql110TableTypeDefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110TableTypeDefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110TableTypeDefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class TableTypeIndex : ISql110TableTypeIndex
	{		
		Int32? ISql110TableTypeIndex.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql110TableTypeIndex.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql110TableTypeIndex.IsDisabled 
		{
			get { return this.IsDisabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110TableTypeIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypePrimaryKeyConstraint : ISql110TableTypePrimaryKeyConstraint
	{		
		Int32? ISql110TableTypePrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql110TableTypePrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql110TableTypePrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql110TableTypePrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110TableTypePrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypeUniqueConstraint : ISql110TableTypeUniqueConstraint
	{		
		Boolean ISql110TableTypeUniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql110TableTypeUniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110TableTypeUniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TcpProtocolSpecifier : ISql110TcpProtocolSpecifier
	{		
		String ISql110TcpProtocolSpecifier.ListenerIPv4 
		{
			get { return this.ListenerIPv4;}
		}
		String ISql110TcpProtocolSpecifier.ListenerIPv6 
		{
			get { return this.ListenerIPv6;}
		}
		Int32 ISql110TcpProtocolSpecifier.ListenerPort 
		{
			get { return this.ListenerPort;}
		}
		Boolean ISql110TcpProtocolSpecifier.ListeningOnAllIPs 
		{
			get { return this.ListeningOnAllIPs;}
		}
	}
	public partial class UniqueConstraint : ISql110UniqueConstraint
	{		
		Boolean ISql110UniqueConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql110UniqueConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql110UniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql110UniqueConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql110UniqueConstraint.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql110UniqueConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql110UniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql110UniqueConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql110UniqueConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110UniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> ISql110UniqueConstraint.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110UniqueConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> ISql110UniqueConstraint.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110UniqueConstraint.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> ISql110UniqueConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110UniqueConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> ISql110UniqueConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class User : ISql110User
	{		
		AuthenticationType ISql110User.AuthenticationType 
		{
			get { return this.AuthenticationType;}
		}
		String ISql110User.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		String ISql110User.Password 
		{
			get { return this.Password;}
		}
		String ISql110User.Sid 
		{
			get { return this.Sid;}
		}
		Boolean ISql110User.WithoutLogin 
		{
			get { return this.WithoutLogin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> ISql110User.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> ISql110User.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110User.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> ISql110User.Login 
		{
			get 
			{
				return this.Login;
			}
		}
	}
	public partial class UserDefinedServerRole : ISql110UserDefinedServerRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql110UserDefinedServerRole.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class UserDefinedType : ISql110UserDefinedType
	{		
		Boolean? ISql110UserDefinedType.ByteOrdered 
		{
			get { return this.ByteOrdered;}
		}
		String ISql110UserDefinedType.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean? ISql110UserDefinedType.FixedLength 
		{
			get { return this.FixedLength;}
		}
		Format ISql110UserDefinedType.Format 
		{
			get { return this.Format;}
		}
		Int32? ISql110UserDefinedType.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		String ISql110UserDefinedType.ValidationMethodName 
		{
			get { return this.ValidationMethodName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ISql110UserDefinedType.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110UserDefinedType.Methods 
		{
			get 
			{
				return this.Methods;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql110UserDefinedType.Properties 
		{
			get 
			{
				return this.Properties;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110UserDefinedType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class View : ISql110View
	{		
		Boolean? ISql110View.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql110View.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql110View.Replicated 
		{
			get { return this.Replicated;}
		}
		String ISql110View.SelectStatement 
		{
			get { return this.SelectStatement;}
		}
		Boolean ISql110View.WithCheckOption 
		{
			get { return this.WithCheckOption;}
		}
		Boolean ISql110View.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql110View.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}
		Boolean ISql110View.WithViewMetadata 
		{
			get { return this.WithViewMetadata;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql110View.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110View.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110View.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class WorkloadGroup : ISql110WorkloadGroup
	{		
		Int32 ISql110WorkloadGroup.GroupMaxRequests 
		{
			get { return this.GroupMaxRequests;}
		}
		Degree ISql110WorkloadGroup.Importance 
		{
			get { return this.Importance;}
		}
		Int32 ISql110WorkloadGroup.MaxDop 
		{
			get { return this.MaxDop;}
		}
		Int32 ISql110WorkloadGroup.RequestMaxCpuTimeSec 
		{
			get { return this.RequestMaxCpuTimeSec;}
		}
		Int32 ISql110WorkloadGroup.RequestMaxMemoryGrantPercent 
		{
			get { return this.RequestMaxMemoryGrantPercent;}
		}
		Int32 ISql110WorkloadGroup.RequestMemoryGrantTimeoutSec 
		{
			get { return this.RequestMemoryGrantTimeoutSec;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ResourcePool> ISql110WorkloadGroup.ResourcePool 
		{
			get 
			{
				return this.ResourcePool;
			}
		}
	}
	public partial class XmlIndex : ISql110XmlIndex
	{		
		Boolean ISql110XmlIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql110XmlIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql110XmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql110XmlIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql110XmlIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql110XmlIndex.IsPrimary 
		{
			get { return this.IsPrimary;}
		}
		Boolean ISql110XmlIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		SecondaryXmlIndexType ISql110XmlIndex.SecondaryXmlIndexType 
		{
			get { return this.SecondaryXmlIndexType;}
		}
		Boolean ISql110XmlIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110XmlIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql110XmlIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlIndex> ISql110XmlIndex.PrimaryXmlIndex 
		{
			get 
			{
				return this.PrimaryXmlIndex;
			}
		}
	}
	public partial class SelectiveXmlIndex : ISql110SelectiveXmlIndex
	{		
		Boolean ISql110SelectiveXmlIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql110SelectiveXmlIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql110SelectiveXmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql110SelectiveXmlIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql110SelectiveXmlIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql110SelectiveXmlIndex.IsPrimary 
		{
			get { return this.IsPrimary;}
		}
		Boolean ISql110SelectiveXmlIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql110SelectiveXmlIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ISql110SelectiveXmlIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql110SelectiveXmlIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> ISql110SelectiveXmlIndex.PrimaryPromotedPath 
		{
			get 
			{
				return this.PrimaryPromotedPath;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SelectiveXmlIndex> ISql110SelectiveXmlIndex.PrimarySelectiveXmlIndex 
		{
			get 
			{
				return this.PrimarySelectiveXmlIndex;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> ISql110SelectiveXmlIndex.PromotedPaths 
		{
			get 
			{
				return this.PromotedPaths;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlNamespace> ISql110SelectiveXmlIndex.XmlNamespaces 
		{
			get 
			{
				return this.XmlNamespaces;
			}
		}
	}
	public partial class XmlNamespace : ISql110XmlNamespace
	{		
		String ISql110XmlNamespace.NamespaceUri 
		{
			get { return this.NamespaceUri;}
		}
		String ISql110XmlNamespace.Prefix 
		{
			get { return this.Prefix;}
		}
	}
	public partial class PromotedNodePathForXQueryType : ISql110PromotedNodePathForXQueryType
	{		
		Boolean ISql110PromotedNodePathForXQueryType.IsSingleton 
		{
			get { return this.IsSingleton;}
		}
		Int32? ISql110PromotedNodePathForXQueryType.MaxLength 
		{
			get { return this.MaxLength;}
		}
		String ISql110PromotedNodePathForXQueryType.NodePath 
		{
			get { return this.NodePath;}
		}
		String ISql110PromotedNodePathForXQueryType.Type 
		{
			get { return this.Type;}
		}
	}
	public partial class PromotedNodePathForSqlType : ISql110PromotedNodePathForSqlType
	{		
		Boolean ISql110PromotedNodePathForSqlType.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql110PromotedNodePathForSqlType.IsSingleton 
		{
			get { return this.IsSingleton;}
		}
		Int32 ISql110PromotedNodePathForSqlType.Length 
		{
			get { return this.Length;}
		}
		String ISql110PromotedNodePathForSqlType.NodePath 
		{
			get { return this.NodePath;}
		}
		Int32 ISql110PromotedNodePathForSqlType.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql110PromotedNodePathForSqlType.Scale 
		{
			get { return this.Scale;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> ISql110PromotedNodePathForSqlType.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class XmlSchemaCollection : ISql110XmlSchemaCollection
	{		
		String ISql110XmlSchemaCollection.Expression 
		{
			get { return this.Expression;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> ISql110XmlSchemaCollection.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Column : ISql120Column
	{		
		String ISql120Column.Collation 
		{
			get { return this.Collation;}
		}
		String ISql120Column.Expression 
		{
			get { return this.Expression;}
		}
		String ISql120Column.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql120Column.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql120Column.IsFileStream 
		{
			get { return this.IsFileStream;}
		}
		Boolean ISql120Column.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql120Column.IsIdentityNotForReplication 
		{
			get { return this.IsIdentityNotForReplication;}
		}
		Boolean ISql120Column.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql120Column.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql120Column.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql120Column.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql120Column.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql120Column.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql120Column.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql120Column.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql120Column.Sparse 
		{
			get { return this.Sparse;}
		}
		XmlStyle ISql120Column.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> ISql120Column.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Column.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> ISql120Column.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableValuedFunction : ISql120TableValuedFunction
	{		
		Boolean? ISql120TableValuedFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql120TableValuedFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql120TableValuedFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql120TableValuedFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql120TableValuedFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql120TableValuedFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql120TableValuedFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120TableValuedFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql120TableValuedFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql120TableValuedFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql120TableValuedFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql120TableValuedFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql120TableValuedFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120TableValuedFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		String ISql120TableValuedFunction.ReturnTableVariableName 
		{
			get { return this.ReturnTableVariableName;}
		}
		SystemDataAccessKind? ISql120TableValuedFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql120TableValuedFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql120TableValuedFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120TableValuedFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120TableValuedFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120TableValuedFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120TableValuedFunction.OrderColumns 
		{
			get 
			{
				return this.OrderColumns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> ISql120TableValuedFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql120TableValuedFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120TableValuedFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120TableValuedFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ScalarFunction : ISql120ScalarFunction
	{		
		Boolean? ISql120ScalarFunction.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql120ScalarFunction.CalledOnNullInput 
		{
			get { return this.CalledOnNullInput;}
		}
		String ISql120ScalarFunction.ClassName 
		{
			get { return this.ClassName;}
		}
		DataAccessKind? ISql120ScalarFunction.DataAccess 
		{
			get { return this.DataAccess;}
		}
		Boolean? ISql120ScalarFunction.Deterministic 
		{
			get { return this.Deterministic;}
		}
		Boolean ISql120ScalarFunction.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql120ScalarFunction.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120ScalarFunction.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql120ScalarFunction.FillRowMethodName 
		{
			get { return this.FillRowMethodName;}
		}
		Boolean ISql120ScalarFunction.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql120ScalarFunction.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql120ScalarFunction.Precise 
		{
			get { return this.Precise;}
		}
		Boolean? ISql120ScalarFunction.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120ScalarFunction.ReturnsNullOnNullInput 
		{
			get { return this.ReturnsNullOnNullInput;}
		}
		SystemDataAccessKind? ISql120ScalarFunction.SystemDataAccess 
		{
			get { return this.SystemDataAccess;}
		}
		Boolean ISql120ScalarFunction.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql120ScalarFunction.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120ScalarFunction.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120ScalarFunction.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120ScalarFunction.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> ISql120ScalarFunction.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql120ScalarFunction.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120ScalarFunction.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120ScalarFunction.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Aggregate : ISql120Aggregate
	{		
		String ISql120Aggregate.ClassName 
		{
			get { return this.ClassName;}
		}
		Format ISql120Aggregate.Format 
		{
			get { return this.Format;}
		}
		Boolean? ISql120Aggregate.InvariantToDuplicates 
		{
			get { return this.InvariantToDuplicates;}
		}
		Boolean? ISql120Aggregate.InvariantToNulls 
		{
			get { return this.InvariantToNulls;}
		}
		Int32? ISql120Aggregate.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		Boolean? ISql120Aggregate.NullIfEmpty 
		{
			get { return this.NullIfEmpty;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120Aggregate.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> ISql120Aggregate.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql120Aggregate.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Aggregate.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ApplicationRole : ISql120ApplicationRole
	{		
		String ISql120ApplicationRole.Password 
		{
			get { return this.Password;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120ApplicationRole.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}
	}
	public partial class Index : ISql120Index
	{		
		Boolean ISql120Index.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql120Index.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql120Index.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql120Index.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql120Index.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql120Index.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql120Index.FillFactor 
		{
			get { return this.FillFactor;}
		}
		String ISql120Index.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISql120Index.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql120Index.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql120Index.IncrementalStatistics 
		{
			get { return this.IncrementalStatistics;}
		}
		Boolean ISql120Index.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql120Index.Unique 
		{
			get { return this.Unique;}
		}
		Boolean ISql120Index.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Index.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Index.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> ISql120Index.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120Index.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120Index.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120Index.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Index.IncludedColumns 
		{
			get 
			{
				return this.IncludedColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql120Index.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Index.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120Index.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Assembly : ISql120Assembly
	{		
		AssemblyPermissionSet ISql120Assembly.PermissionSet 
		{
			get { return this.PermissionSet;}
		}
		Boolean ISql120Assembly.Visible 
		{
			get { return this.Visible;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AssemblySource> ISql120Assembly.AssemblySources 
		{
			get 
			{
				return this.AssemblySources;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Assembly.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120Assembly.ReferencedAssemblies 
		{
			get 
			{
				return this.ReferencedAssemblies;
			}
		}
	}
	public partial class AssemblySource : ISql120AssemblySource
	{		
		String ISql120AssemblySource.Source 
		{
			get { return this.Source;}
		}
	}
	public partial class AsymmetricKey : ISql120AsymmetricKey
	{		
		AsymmetricKeyAlgorithm ISql120AsymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		SymmetricKeyCreationDisposition ISql120AsymmetricKey.CreationDisposition 
		{
			get { return this.CreationDisposition;}
		}
		Boolean ISql120AsymmetricKey.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql120AsymmetricKey.ExecutableFile 
		{
			get { return this.ExecutableFile;}
		}
		String ISql120AsymmetricKey.File 
		{
			get { return this.File;}
		}
		String ISql120AsymmetricKey.Password 
		{
			get { return this.Password;}
		}
		String ISql120AsymmetricKey.ProviderKeyName 
		{
			get { return this.ProviderKeyName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120AsymmetricKey.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120AsymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120AsymmetricKey.Provider 
		{
			get 
			{
				return this.Provider;
			}
		}
	}
	public partial class AuditAction : ISql120AuditAction
	{		
		DatabaseAuditAction ISql120AuditAction.Action 
		{
			get { return this.Action;}
		}
	}
	public partial class AuditActionGroup : ISql120AuditActionGroup
	{		
		AuditActionGroupType ISql120AuditActionGroup.ActionGroup 
		{
			get { return this.ActionGroup;}
		}
	}
	public partial class AuditActionSpecification : ISql120AuditActionSpecification
	{		

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditAction> ISql120AuditActionSpecification.AuditActions 
		{
			get 
			{
				return this.AuditActions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql120AuditActionSpecification.Principals 
		{
			get 
			{
				return this.Principals;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql120AuditActionSpecification.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class BrokerPriority : ISql120BrokerPriority
	{		
		Int32 ISql120BrokerPriority.PriorityLevel 
		{
			get { return this.PriorityLevel;}
		}
		String ISql120BrokerPriority.RemoteServiceName 
		{
			get { return this.RemoteServiceName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120BrokerPriority.ContractName 
		{
			get 
			{
				return this.ContractName;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120BrokerPriority.LocalServiceName 
		{
			get 
			{
				return this.LocalServiceName;
			}
		}
	}
	public partial class BuiltInServerRole : ISql120BuiltInServerRole
	{		
	}
	public partial class DataType : ISql120DataType
	{		
		SqlDataType ISql120DataType.SqlDataType 
		{
			get { return this.SqlDataType;}
		}
		Boolean ISql120DataType.UddtIsMax 
		{
			get { return this.UddtIsMax;}
		}
		Int32 ISql120DataType.UddtLength 
		{
			get { return this.UddtLength;}
		}
		Boolean ISql120DataType.UddtNullable 
		{
			get { return this.UddtNullable;}
		}
		Int32 ISql120DataType.UddtPrecision 
		{
			get { return this.UddtPrecision;}
		}
		Int32 ISql120DataType.UddtScale 
		{
			get { return this.UddtScale;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120DataType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<System.Type> ISql120DataType.Type 
		{
			get 
			{
				return this.Type;
			}
		}
	}
	public partial class Certificate : ISql120Certificate
	{		
		Boolean ISql120Certificate.ActiveForBeginDialog 
		{
			get { return this.ActiveForBeginDialog;}
		}
		Boolean ISql120Certificate.EncryptedWithPassword 
		{
			get { return this.EncryptedWithPassword;}
		}
		String ISql120Certificate.EncryptionPassword 
		{
			get { return this.EncryptionPassword;}
		}
		String ISql120Certificate.ExistingKeysFilePath 
		{
			get { return this.ExistingKeysFilePath;}
		}
		String ISql120Certificate.ExpiryDate 
		{
			get { return this.ExpiryDate;}
		}
		Boolean ISql120Certificate.IsExistingKeyFileExecutable 
		{
			get { return this.IsExistingKeyFileExecutable;}
		}
		String ISql120Certificate.PrivateKeyDecryptionPassword 
		{
			get { return this.PrivateKeyDecryptionPassword;}
		}
		String ISql120Certificate.PrivateKeyEncryptionPassword 
		{
			get { return this.PrivateKeyEncryptionPassword;}
		}
		String ISql120Certificate.PrivateKeyFilePath 
		{
			get { return this.PrivateKeyFilePath;}
		}
		String ISql120Certificate.StartDate 
		{
			get { return this.StartDate;}
		}
		String ISql120Certificate.Subject 
		{
			get { return this.Subject;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Certificate.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120Certificate.ExistingKeysAssembly 
		{
			get 
			{
				return this.ExistingKeysAssembly;
			}
		}
	}
	public partial class CheckConstraint : ISql120CheckConstraint
	{		
		Boolean ISql120CheckConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql120CheckConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql120CheckConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120CheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> ISql120CheckConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class ClrTypeMethod : ISql120ClrTypeMethod
	{		
		String ISql120ClrTypeMethod.Name 
		{
			get { return this.Name;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> ISql120ClrTypeMethod.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql120ClrTypeMethod.ReturnType 
		{
			get 
			{
				return this.ReturnType;
			}
		}
	}
	public partial class ClrTypeMethodParameter : ISql120ClrTypeMethodParameter
	{		
		Boolean ISql120ClrTypeMethodParameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		String ISql120ClrTypeMethodParameter.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> ISql120ClrTypeMethodParameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class ClrTypeProperty : ISql120ClrTypeProperty
	{		
		String ISql120ClrTypeProperty.Name 
		{
			get { return this.Name;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql120ClrTypeProperty.ClrType 
		{
			get 
			{
				return this.ClrType;
			}
		}
	}
	public partial class ColumnStoreIndex : ISql120ColumnStoreIndex
	{		
		Boolean ISql120ColumnStoreIndex.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql120ColumnStoreIndex.Disabled 
		{
			get { return this.Disabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120ColumnStoreIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> ISql120ColumnStoreIndex.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120ColumnStoreIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql120ColumnStoreIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120ColumnStoreIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120ColumnStoreIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Contract : ISql120Contract
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Contract.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120MessageType> ISql120Contract.Messages 
		{
			get 
			{
				return this.Messages;
			}
		}
	}
	public partial class Credential : ISql120Credential
	{		
		String ISql120Credential.Identity 
		{
			get { return this.Identity;}
		}
		String ISql120Credential.Secret 
		{
			get { return this.Secret;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120CryptographicProvider> ISql120Credential.CryptographicProvider 
		{
			get 
			{
				return this.CryptographicProvider;
			}
		}
	}
	public partial class CryptographicProvider : ISql120CryptographicProvider
	{		
		String ISql120CryptographicProvider.DllPath 
		{
			get { return this.DllPath;}
		}
		Boolean ISql120CryptographicProvider.Enabled 
		{
			get { return this.Enabled;}
		}
	}
	public partial class DatabaseAuditSpecification : ISql120DatabaseAuditSpecification
	{		
		Boolean ISql120DatabaseAuditSpecification.WithState 
		{
			get { return this.WithState;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditActionGroup> ISql120DatabaseAuditSpecification.AuditActionGroups 
		{
			get 
			{
				return this.AuditActionGroups;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditAction> ISql120DatabaseAuditSpecification.AuditActions 
		{
			get 
			{
				return this.AuditActions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ServerAudit> ISql120DatabaseAuditSpecification.ServerAudit 
		{
			get 
			{
				return this.ServerAudit;
			}
		}
	}
	public partial class DatabaseDdlTrigger : ISql120DatabaseDdlTrigger
	{		
		Boolean? ISql120DatabaseDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql120DatabaseDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql120DatabaseDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql120DatabaseDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql120DatabaseDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120DatabaseDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		String ISql120DatabaseDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql120DatabaseDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql120DatabaseDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql120DatabaseDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120DatabaseDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120DatabaseDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> ISql120DatabaseDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql120DatabaseDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120DatabaseDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120DatabaseDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class DatabaseEncryptionKey : ISql120DatabaseEncryptionKey
	{		
		SymmetricKeyAlgorithm ISql120DatabaseEncryptionKey.Algorithm 
		{
			get { return this.Algorithm;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> ISql120DatabaseEncryptionKey.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120DatabaseEncryptionKey.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class DatabaseEventNotification : ISql120DatabaseEventNotification
	{		
		String ISql120DatabaseEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql120DatabaseEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql120DatabaseEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> ISql120DatabaseEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql120DatabaseEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class DatabaseMirroringLanguageSpecifier : ISql120DatabaseMirroringLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql120DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql120DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql120DatabaseMirroringLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		DatabaseMirroringRole ISql120DatabaseMirroringLanguageSpecifier.RoleType 
		{
			get { return this.RoleType;}
		}
		Boolean ISql120DatabaseMirroringLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql120DatabaseMirroringLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120DatabaseMirroringLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class DatabaseOptions : ISql120DatabaseOptions
	{		
		Boolean ISql120DatabaseOptions.AllowSnapshotIsolation 
		{
			get { return this.AllowSnapshotIsolation;}
		}
		Boolean ISql120DatabaseOptions.AnsiNullDefaultOn 
		{
			get { return this.AnsiNullDefaultOn;}
		}
		Boolean ISql120DatabaseOptions.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql120DatabaseOptions.AnsiPaddingOn 
		{
			get { return this.AnsiPaddingOn;}
		}
		Boolean ISql120DatabaseOptions.AnsiWarningsOn 
		{
			get { return this.AnsiWarningsOn;}
		}
		Boolean ISql120DatabaseOptions.ArithAbortOn 
		{
			get { return this.ArithAbortOn;}
		}
		Boolean ISql120DatabaseOptions.AutoClose 
		{
			get { return this.AutoClose;}
		}
		Boolean ISql120DatabaseOptions.AutoCreateStatistics 
		{
			get { return this.AutoCreateStatistics;}
		}
		Boolean ISql120DatabaseOptions.AutoCreateStatisticsIncremental 
		{
			get { return this.AutoCreateStatisticsIncremental;}
		}
		Boolean ISql120DatabaseOptions.AutoShrink 
		{
			get { return this.AutoShrink;}
		}
		Boolean ISql120DatabaseOptions.AutoUpdateStatistics 
		{
			get { return this.AutoUpdateStatistics;}
		}
		Boolean ISql120DatabaseOptions.AutoUpdateStatisticsAsync 
		{
			get { return this.AutoUpdateStatisticsAsync;}
		}
		Boolean ISql120DatabaseOptions.ChangeTrackingAutoCleanup 
		{
			get { return this.ChangeTrackingAutoCleanup;}
		}
		Boolean ISql120DatabaseOptions.ChangeTrackingEnabled 
		{
			get { return this.ChangeTrackingEnabled;}
		}
		Int32 ISql120DatabaseOptions.ChangeTrackingRetentionPeriod 
		{
			get { return this.ChangeTrackingRetentionPeriod;}
		}
		TimeUnit ISql120DatabaseOptions.ChangeTrackingRetentionUnit 
		{
			get { return this.ChangeTrackingRetentionUnit;}
		}
		String ISql120DatabaseOptions.Collation 
		{
			get { return this.Collation;}
		}
		Int32 ISql120DatabaseOptions.CompatibilityLevel 
		{
			get { return this.CompatibilityLevel;}
		}
		Boolean ISql120DatabaseOptions.ConcatNullYieldsNull 
		{
			get { return this.ConcatNullYieldsNull;}
		}
		Containment ISql120DatabaseOptions.Containment 
		{
			get { return this.Containment;}
		}
		Boolean ISql120DatabaseOptions.CursorCloseOnCommit 
		{
			get { return this.CursorCloseOnCommit;}
		}
		Boolean ISql120DatabaseOptions.CursorDefaultGlobalScope 
		{
			get { return this.CursorDefaultGlobalScope;}
		}
		Boolean ISql120DatabaseOptions.DatabaseStateOffline 
		{
			get { return this.DatabaseStateOffline;}
		}
		Boolean ISql120DatabaseOptions.DateCorrelationOptimizationOn 
		{
			get { return this.DateCorrelationOptimizationOn;}
		}
		Boolean ISql120DatabaseOptions.DBChainingOn 
		{
			get { return this.DBChainingOn;}
		}
		String ISql120DatabaseOptions.DefaultFullTextLanguage 
		{
			get { return this.DefaultFullTextLanguage;}
		}
		String ISql120DatabaseOptions.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		DelayedDurabilityMode ISql120DatabaseOptions.DelayedDurabilityMode 
		{
			get { return this.DelayedDurabilityMode;}
		}
		String ISql120DatabaseOptions.FileStreamDirectoryName 
		{
			get { return this.FileStreamDirectoryName;}
		}
		Boolean ISql120DatabaseOptions.FullTextEnabled 
		{
			get { return this.FullTextEnabled;}
		}
		Boolean ISql120DatabaseOptions.HonorBrokerPriority 
		{
			get { return this.HonorBrokerPriority;}
		}
		Boolean ISql120DatabaseOptions.MemoryOptimizedElevateToSnapshot 
		{
			get { return this.MemoryOptimizedElevateToSnapshot;}
		}
		Boolean ISql120DatabaseOptions.NestedTriggersOn 
		{
			get { return this.NestedTriggersOn;}
		}
		NonTransactedFileStreamAccess ISql120DatabaseOptions.NonTransactedFileStreamAccess 
		{
			get { return this.NonTransactedFileStreamAccess;}
		}
		Boolean ISql120DatabaseOptions.NumericRoundAbortOn 
		{
			get { return this.NumericRoundAbortOn;}
		}
		PageVerifyMode ISql120DatabaseOptions.PageVerifyMode 
		{
			get { return this.PageVerifyMode;}
		}
		ParameterizationOption ISql120DatabaseOptions.ParameterizationOption 
		{
			get { return this.ParameterizationOption;}
		}
		Boolean ISql120DatabaseOptions.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120DatabaseOptions.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		RecoveryMode ISql120DatabaseOptions.RecoveryMode 
		{
			get { return this.RecoveryMode;}
		}
		Boolean ISql120DatabaseOptions.RecursiveTriggersOn 
		{
			get { return this.RecursiveTriggersOn;}
		}
		ServiceBrokerOption ISql120DatabaseOptions.ServiceBrokerOption 
		{
			get { return this.ServiceBrokerOption;}
		}
		Boolean ISql120DatabaseOptions.SupplementalLoggingOn 
		{
			get { return this.SupplementalLoggingOn;}
		}
		Int32 ISql120DatabaseOptions.TargetRecoveryTimePeriod 
		{
			get { return this.TargetRecoveryTimePeriod;}
		}
		TimeUnit ISql120DatabaseOptions.TargetRecoveryTimeUnit 
		{
			get { return this.TargetRecoveryTimeUnit;}
		}
		Boolean ISql120DatabaseOptions.TornPageProtectionOn 
		{
			get { return this.TornPageProtectionOn;}
		}
		Boolean ISql120DatabaseOptions.TransactionIsolationReadCommittedSnapshot 
		{
			get { return this.TransactionIsolationReadCommittedSnapshot;}
		}
		Boolean ISql120DatabaseOptions.TransformNoiseWords 
		{
			get { return this.TransformNoiseWords;}
		}
		Boolean ISql120DatabaseOptions.Trustworthy 
		{
			get { return this.Trustworthy;}
		}
		Int16 ISql120DatabaseOptions.TwoDigitYearCutoff 
		{
			get { return this.TwoDigitYearCutoff;}
		}
		UserAccessOption ISql120DatabaseOptions.UserAccessOption 
		{
			get { return this.UserAccessOption;}
		}
		Boolean ISql120DatabaseOptions.VardecimalStorageFormatOn 
		{
			get { return this.VardecimalStorageFormatOn;}
		}
		Boolean ISql120DatabaseOptions.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120DatabaseOptions.DefaultFilegroup 
		{
			get 
			{
				return this.DefaultFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120DatabaseOptions.DefaultFileStreamFilegroup 
		{
			get 
			{
				return this.DefaultFileStreamFilegroup;
			}
		}
	}
	public partial class DataCompressionOption : ISql120DataCompressionOption
	{		
		CompressionLevel ISql120DataCompressionOption.CompressionLevel 
		{
			get { return this.CompressionLevel;}
		}
		Int32 ISql120DataCompressionOption.PartitionNumber 
		{
			get { return this.PartitionNumber;}
		}
	}
	public partial class Default : ISql120Default
	{		
		String ISql120Default.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Default.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Default.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class DefaultConstraint : ISql120DefaultConstraint
	{		
		Boolean ISql120DefaultConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql120DefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}
		Boolean ISql120DefaultConstraint.WithValues 
		{
			get { return this.WithValues;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120DefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> ISql120DefaultConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120DefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class DmlTrigger : ISql120DmlTrigger
	{		
		Boolean? ISql120DmlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql120DmlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		OrderRestriction ISql120DmlTrigger.DeleteOrderRestriction 
		{
			get { return this.DeleteOrderRestriction;}
		}
		Boolean ISql120DmlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql120DmlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql120DmlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120DmlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		OrderRestriction ISql120DmlTrigger.InsertOrderRestriction 
		{
			get { return this.InsertOrderRestriction;}
		}
		Boolean ISql120DmlTrigger.IsDeleteTrigger 
		{
			get { return this.IsDeleteTrigger;}
		}
		Boolean ISql120DmlTrigger.IsInsertTrigger 
		{
			get { return this.IsInsertTrigger;}
		}
		Boolean ISql120DmlTrigger.IsUpdateTrigger 
		{
			get { return this.IsUpdateTrigger;}
		}
		String ISql120DmlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean ISql120DmlTrigger.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		Boolean? ISql120DmlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql120DmlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		OrderRestriction ISql120DmlTrigger.UpdateOrderRestriction 
		{
			get { return this.UpdateOrderRestriction;}
		}
		Boolean ISql120DmlTrigger.WithAppend 
		{
			get { return this.WithAppend;}
		}
		Boolean ISql120DmlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120DmlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120DmlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120DmlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql120DmlTrigger.TriggerObject 
		{
			get 
			{
				return this.TriggerObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120DmlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Endpoint : ISql120Endpoint
	{		
		Payload ISql120Endpoint.Payload 
		{
			get { return this.Payload;}
		}
		Protocol ISql120Endpoint.Protocol 
		{
			get { return this.Protocol;}
		}
		State ISql120Endpoint.State 
		{
			get { return this.State;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Endpoint.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> ISql120Endpoint.PayloadSpecifier 
		{
			get 
			{
				return this.PayloadSpecifier;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ISql120Endpoint.ProtocolSpecifier 
		{
			get 
			{
				return this.ProtocolSpecifier;
			}
		}
	}
	public partial class ErrorMessage : ISql120ErrorMessage
	{		
		String ISql120ErrorMessage.Language 
		{
			get { return this.Language;}
		}
		Int32 ISql120ErrorMessage.MessageNumber 
		{
			get { return this.MessageNumber;}
		}
		String ISql120ErrorMessage.MessageText 
		{
			get { return this.MessageText;}
		}
		Int32 ISql120ErrorMessage.Severity 
		{
			get { return this.Severity;}
		}
		Boolean ISql120ErrorMessage.WithLog 
		{
			get { return this.WithLog;}
		}
	}
	public partial class EventGroup : ISql120EventGroup
	{		
		EventGroupType ISql120EventGroup.Group 
		{
			get { return this.Group;}
		}
	}
	public partial class EventSession : ISql120EventSession
	{		
		EventRetentionMode ISql120EventSession.EventRetentionMode 
		{
			get { return this.EventRetentionMode;}
		}
		Int32 ISql120EventSession.MaxDispatchLatency 
		{
			get { return this.MaxDispatchLatency;}
		}
		Int32 ISql120EventSession.MaxEventSize 
		{
			get { return this.MaxEventSize;}
		}
		MemoryUnit ISql120EventSession.MaxEventSizeUnit 
		{
			get { return this.MaxEventSizeUnit;}
		}
		Int32 ISql120EventSession.MaxMemory 
		{
			get { return this.MaxMemory;}
		}
		MemoryUnit ISql120EventSession.MaxMemoryUnit 
		{
			get { return this.MaxMemoryUnit;}
		}
		MemoryPartitionMode ISql120EventSession.MemoryPartitionMode 
		{
			get { return this.MemoryPartitionMode;}
		}
		Boolean ISql120EventSession.StartupState 
		{
			get { return this.StartupState;}
		}
		Boolean ISql120EventSession.TrackCausality 
		{
			get { return this.TrackCausality;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120EventSession.EventDefinitions 
		{
			get 
			{
				return this.EventDefinitions;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120EventSession.EventTargets 
		{
			get 
			{
				return this.EventTargets;
			}
		}
	}
	public partial class EventSessionAction : ISql120EventSessionAction
	{		
		String ISql120EventSessionAction.ActionName 
		{
			get { return this.ActionName;}
		}
		String ISql120EventSessionAction.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql120EventSessionAction.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
	}
	public partial class EventSessionDefinitions : ISql120EventSessionDefinitions
	{		
		String ISql120EventSessionDefinitions.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql120EventSessionDefinitions.EventName 
		{
			get { return this.EventName;}
		}
		String ISql120EventSessionDefinitions.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
		String ISql120EventSessionDefinitions.WhereExpression 
		{
			get { return this.WhereExpression;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventSessionAction> ISql120EventSessionDefinitions.Actions 
		{
			get 
			{
				return this.Actions;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120EventSessionDefinitions.AttributeSettings 
		{
			get 
			{
				return this.AttributeSettings;
			}
		}
	}
	public partial class EventSessionSetting : ISql120EventSessionSetting
	{		
		String ISql120EventSessionSetting.SettingName 
		{
			get { return this.SettingName;}
		}
		String ISql120EventSessionSetting.SettingValue 
		{
			get { return this.SettingValue;}
		}
	}
	public partial class EventSessionTarget : ISql120EventSessionTarget
	{		
		String ISql120EventSessionTarget.EventModuleGuid 
		{
			get { return this.EventModuleGuid;}
		}
		String ISql120EventSessionTarget.EventPackageName 
		{
			get { return this.EventPackageName;}
		}
		String ISql120EventSessionTarget.TargetName 
		{
			get { return this.TargetName;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120EventSessionTarget.ParameterSettings 
		{
			get 
			{
				return this.ParameterSettings;
			}
		}
	}
	public partial class EventTypeSpecifier : ISql120EventTypeSpecifier
	{		
		EventType ISql120EventTypeSpecifier.EventType 
		{
			get { return this.EventType;}
		}
		OrderRestriction ISql120EventTypeSpecifier.Order 
		{
			get { return this.Order;}
		}
	}
	public partial class ExtendedProcedure : ISql120ExtendedProcedure
	{		
		Boolean ISql120ExtendedProcedure.ExeccuteAsCaller 
		{
			get { return this.ExeccuteAsCaller;}
		}
		Boolean ISql120ExtendedProcedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120ExtendedProcedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql120ExtendedProcedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120ExtendedProcedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> ISql120ExtendedProcedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120ExtendedProcedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120ExtendedProcedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ExtendedProperty : ISql120ExtendedProperty
	{		
		String ISql120ExtendedProperty.Value 
		{
			get { return this.Value;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> ISql120ExtendedProperty.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class SqlFile : ISql120SqlFile
	{		
		Int32? ISql120SqlFile.FileGrowth 
		{
			get { return this.FileGrowth;}
		}
		MemoryUnit ISql120SqlFile.FileGrowthUnit 
		{
			get { return this.FileGrowthUnit;}
		}
		String ISql120SqlFile.FileName 
		{
			get { return this.FileName;}
		}
		Boolean ISql120SqlFile.IsLogFile 
		{
			get { return this.IsLogFile;}
		}
		Int32? ISql120SqlFile.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql120SqlFile.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		Boolean ISql120SqlFile.Offline 
		{
			get { return this.Offline;}
		}
		Int32? ISql120SqlFile.Size 
		{
			get { return this.Size;}
		}
		MemoryUnit ISql120SqlFile.SizeUnit 
		{
			get { return this.SizeUnit;}
		}
		Boolean ISql120SqlFile.Unlimited 
		{
			get { return this.Unlimited;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120SqlFile.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class Filegroup : ISql120Filegroup
	{		
		Boolean ISql120Filegroup.ContainsFileStream 
		{
			get { return this.ContainsFileStream;}
		}
		Boolean ISql120Filegroup.ContainsMemoryOptimizedData 
		{
			get { return this.ContainsMemoryOptimizedData;}
		}
		Boolean ISql120Filegroup.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
	}
	public partial class ForeignKeyConstraint : ISql120ForeignKeyConstraint
	{		
		ForeignKeyAction ISql120ForeignKeyConstraint.DeleteAction 
		{
			get { return this.DeleteAction;}
		}
		Boolean ISql120ForeignKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql120ForeignKeyConstraint.NotForReplication 
		{
			get { return this.NotForReplication;}
		}
		ForeignKeyAction ISql120ForeignKeyConstraint.UpdateAction 
		{
			get { return this.UpdateAction;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120ForeignKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120ForeignKeyConstraint.ForeignColumns 
		{
			get 
			{
				return this.ForeignColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Table> ISql120ForeignKeyConstraint.ForeignTable 
		{
			get 
			{
				return this.ForeignTable;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> ISql120ForeignKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}
	}
	public partial class FullTextCatalog : ISql120FullTextCatalog
	{		
		Boolean? ISql120FullTextCatalog.AccentSensitivity 
		{
			get { return this.AccentSensitivity;}
		}
		Boolean ISql120FullTextCatalog.IsDefault 
		{
			get { return this.IsDefault;}
		}
		String ISql120FullTextCatalog.Path 
		{
			get { return this.Path;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120FullTextCatalog.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120FullTextCatalog.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}
	}
	public partial class FullTextIndex : ISql120FullTextIndex
	{		
		ChangeTrackingOption ISql120FullTextIndex.ChangeTracking 
		{
			get { return this.ChangeTracking;}
		}
		Boolean ISql120FullTextIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql120FullTextIndex.Replicated 
		{
			get { return this.Replicated;}
		}
		Boolean ISql120FullTextIndex.StopListOff 
		{
			get { return this.StopListOff;}
		}
		Boolean ISql120FullTextIndex.UseSystemStopList 
		{
			get { return this.UseSystemStopList;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120FullTextIndex.Catalog 
		{
			get 
			{
				return this.Catalog;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120FullTextIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120FullTextIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql120FullTextIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SearchPropertyList> ISql120FullTextIndex.SearchPropertyList 
		{
			get 
			{
				return this.SearchPropertyList;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120FullTextIndex.StopList 
		{
			get 
			{
				return this.StopList;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120FullTextIndex.UniqueIndexName 
		{
			get 
			{
				return this.UniqueIndexName;
			}
		}
	}
	public partial class FullTextIndexColumnSpecifier : ISql120FullTextIndexColumnSpecifier
	{		
		Int32? ISql120FullTextIndexColumnSpecifier.LanguageId 
		{
			get { return this.LanguageId;}
		}
		Boolean ISql120FullTextIndexColumnSpecifier.PartOfStatisticalSemantics 
		{
			get { return this.PartOfStatisticalSemantics;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120FullTextIndexColumnSpecifier.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120FullTextIndexColumnSpecifier.TypeColumn 
		{
			get 
			{
				return this.TypeColumn;
			}
		}
	}
	public partial class FullTextStopList : ISql120FullTextStopList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120FullTextStopList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class HttpProtocolSpecifier : ISql120HttpProtocolSpecifier
	{		
		AuthenticationModes ISql120HttpProtocolSpecifier.AuthenticationMode 
		{
			get { return this.AuthenticationMode;}
		}
		String ISql120HttpProtocolSpecifier.AuthenticationRealm 
		{
			get { return this.AuthenticationRealm;}
		}
		Int32? ISql120HttpProtocolSpecifier.ClearPort 
		{
			get { return this.ClearPort;}
		}
		Boolean ISql120HttpProtocolSpecifier.CompressionEnabled 
		{
			get { return this.CompressionEnabled;}
		}
		String ISql120HttpProtocolSpecifier.DefaultLogonDomain 
		{
			get { return this.DefaultLogonDomain;}
		}
		Boolean ISql120HttpProtocolSpecifier.ListeningOnAllNoneReservedSites 
		{
			get { return this.ListeningOnAllNoneReservedSites;}
		}
		Boolean ISql120HttpProtocolSpecifier.ListeningOnAllSites 
		{
			get { return this.ListeningOnAllSites;}
		}
		String ISql120HttpProtocolSpecifier.Path 
		{
			get { return this.Path;}
		}
		HttpPorts ISql120HttpProtocolSpecifier.Ports 
		{
			get { return this.Ports;}
		}
		Int32? ISql120HttpProtocolSpecifier.SslPort 
		{
			get { return this.SslPort;}
		}
		String ISql120HttpProtocolSpecifier.Website 
		{
			get { return this.Website;}
		}
	}
	public partial class LinkedServer : ISql120LinkedServer
	{		
		String ISql120LinkedServer.Catalog 
		{
			get { return this.Catalog;}
		}
		Boolean ISql120LinkedServer.CollationCompatible 
		{
			get { return this.CollationCompatible;}
		}
		String ISql120LinkedServer.CollationName 
		{
			get { return this.CollationName;}
		}
		Int32 ISql120LinkedServer.ConnectTimeout 
		{
			get { return this.ConnectTimeout;}
		}
		Boolean ISql120LinkedServer.DataAccess 
		{
			get { return this.DataAccess;}
		}
		String ISql120LinkedServer.DataSource 
		{
			get { return this.DataSource;}
		}
		Boolean ISql120LinkedServer.IsDistributor 
		{
			get { return this.IsDistributor;}
		}
		Boolean ISql120LinkedServer.IsPublisher 
		{
			get { return this.IsPublisher;}
		}
		Boolean ISql120LinkedServer.IsSubscriber 
		{
			get { return this.IsSubscriber;}
		}
		Boolean ISql120LinkedServer.LazySchemaValidationEnabled 
		{
			get { return this.LazySchemaValidationEnabled;}
		}
		String ISql120LinkedServer.Location 
		{
			get { return this.Location;}
		}
		String ISql120LinkedServer.ProductName 
		{
			get { return this.ProductName;}
		}
		String ISql120LinkedServer.ProviderName 
		{
			get { return this.ProviderName;}
		}
		String ISql120LinkedServer.ProviderString 
		{
			get { return this.ProviderString;}
		}
		Int32 ISql120LinkedServer.QueryTimeout 
		{
			get { return this.QueryTimeout;}
		}
		Boolean ISql120LinkedServer.RemoteProcTransactionPromotionEnabled 
		{
			get { return this.RemoteProcTransactionPromotionEnabled;}
		}
		Boolean ISql120LinkedServer.RpcEnabled 
		{
			get { return this.RpcEnabled;}
		}
		Boolean ISql120LinkedServer.RpcOutEnabled 
		{
			get { return this.RpcOutEnabled;}
		}
		Boolean ISql120LinkedServer.UseRemoteCollation 
		{
			get { return this.UseRemoteCollation;}
		}
	}
	public partial class LinkedServerLogin : ISql120LinkedServerLogin
	{		
		String ISql120LinkedServerLogin.LinkedServerLoginName 
		{
			get { return this.LinkedServerLoginName;}
		}
		String ISql120LinkedServerLogin.LinkedServerPassword 
		{
			get { return this.LinkedServerPassword;}
		}
		Boolean ISql120LinkedServerLogin.UseSelf 
		{
			get { return this.UseSelf;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120LinkedServer> ISql120LinkedServerLogin.LinkedServer 
		{
			get 
			{
				return this.LinkedServer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120LinkedServerLogin.LocalLogin 
		{
			get 
			{
				return this.LocalLogin;
			}
		}
	}
	public partial class Login : ISql120Login
	{		
		Boolean ISql120Login.CheckExpiration 
		{
			get { return this.CheckExpiration;}
		}
		Boolean ISql120Login.CheckPolicy 
		{
			get { return this.CheckPolicy;}
		}
		String ISql120Login.DefaultDatabase 
		{
			get { return this.DefaultDatabase;}
		}
		String ISql120Login.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		Boolean ISql120Login.Disabled 
		{
			get { return this.Disabled;}
		}
		LoginEncryptionOption ISql120Login.EncryptionOption 
		{
			get { return this.EncryptionOption;}
		}
		Boolean ISql120Login.MappedToWindowsLogin 
		{
			get { return this.MappedToWindowsLogin;}
		}
		String ISql120Login.Password 
		{
			get { return this.Password;}
		}
		Boolean ISql120Login.PasswordHashed 
		{
			get { return this.PasswordHashed;}
		}
		Boolean ISql120Login.PasswordMustChange 
		{
			get { return this.PasswordMustChange;}
		}
		String ISql120Login.Sid 
		{
			get { return this.Sid;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> ISql120Login.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120Login.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Credential> ISql120Login.Credential 
		{
			get 
			{
				return this.Credential;
			}
		}
	}
	public partial class MasterKey : ISql120MasterKey
	{		
		String ISql120MasterKey.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class MessageType : ISql120MessageType
	{		
		ValidationMethod ISql120MessageType.ValidationMethod 
		{
			get { return this.ValidationMethod;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120MessageType.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> ISql120MessageType.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class PartitionFunction : ISql120PartitionFunction
	{		
		PartitionRange ISql120PartitionFunction.Range 
		{
			get { return this.Range;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionValue> ISql120PartitionFunction.BoundaryValues 
		{
			get 
			{
				return this.BoundaryValues;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ISql120PartitionFunction.ParameterType 
		{
			get 
			{
				return this.ParameterType;
			}
		}
	}
	public partial class PartitionScheme : ISql120PartitionScheme
	{		
		Boolean ISql120PartitionScheme.AllToOneFilegroup 
		{
			get { return this.AllToOneFilegroup;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120PartitionScheme.Filegroups 
		{
			get 
			{
				return this.Filegroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionFunction> ISql120PartitionScheme.PartitionFunction 
		{
			get 
			{
				return this.PartitionFunction;
			}
		}
	}
	public partial class PartitionValue : ISql120PartitionValue
	{		
		String ISql120PartitionValue.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120PartitionValue.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class Permission : ISql120Permission
	{		
		PermissionAction ISql120Permission.PermissionAction 
		{
			get { return this.PermissionAction;}
		}
		PermissionType ISql120Permission.PermissionType 
		{
			get { return this.PermissionType;}
		}
		Boolean ISql120Permission.WithAllPrivileges 
		{
			get { return this.WithAllPrivileges;}
		}
		Boolean ISql120Permission.WithGrantOption 
		{
			get { return this.WithGrantOption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Permission.ExcludedColumns 
		{
			get 
			{
				return this.ExcludedColumns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql120Permission.Grantee 
		{
			get 
			{
				return this.Grantee;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > ISql120Permission.Grantor 
		{
			get 
			{
				return this.Grantor;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Permission.RevokedGrantOptionColumns 
		{
			get 
			{
				return this.RevokedGrantOptionColumns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> ISql120Permission.SecuredObject 
		{
			get 
			{
				return this.SecuredObject;
			}
		}
	}
	public partial class PrimaryKeyConstraint : ISql120PrimaryKeyConstraint
	{		
		Boolean ISql120PrimaryKeyConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql120PrimaryKeyConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql120PrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql120PrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql120PrimaryKeyConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql120PrimaryKeyConstraint.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql120PrimaryKeyConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql120PrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql120PrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql120PrimaryKeyConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql120PrimaryKeyConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120PrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> ISql120PrimaryKeyConstraint.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120PrimaryKeyConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120PrimaryKeyConstraint.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120PrimaryKeyConstraint.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> ISql120PrimaryKeyConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120PrimaryKeyConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120PrimaryKeyConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Procedure : ISql120Procedure
	{		
		Boolean? ISql120Procedure.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql120Procedure.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql120Procedure.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql120Procedure.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120Procedure.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql120Procedure.ForReplication 
		{
			get { return this.ForReplication;}
		}
		Boolean ISql120Procedure.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		String ISql120Procedure.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql120Procedure.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120Procedure.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql120Procedure.WithNativeCompilation 
		{
			get { return this.WithNativeCompilation;}
		}
		Boolean ISql120Procedure.WithRecompile 
		{
			get { return this.WithRecompile;}
		}
		Boolean ISql120Procedure.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120Procedure.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Procedure.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120Procedure.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> ISql120Procedure.Parameters 
		{
			get 
			{
				return this.Parameters;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Procedure> ISql120Procedure.ParentProcedure 
		{
			get 
			{
				return this.ParentProcedure;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Procedure.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120Procedure.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class Queue : ISql120Queue
	{		
		Boolean ISql120Queue.ActivationExecuteAsCaller 
		{
			get { return this.ActivationExecuteAsCaller;}
		}
		Boolean ISql120Queue.ActivationExecuteAsOwner 
		{
			get { return this.ActivationExecuteAsOwner;}
		}
		Boolean ISql120Queue.ActivationExecuteAsSelf 
		{
			get { return this.ActivationExecuteAsSelf;}
		}
		Int32? ISql120Queue.ActivationMaxQueueReaders 
		{
			get { return this.ActivationMaxQueueReaders;}
		}
		Boolean? ISql120Queue.ActivationStatusOn 
		{
			get { return this.ActivationStatusOn;}
		}
		Boolean ISql120Queue.PoisonMessageHandlingStatusOn 
		{
			get { return this.PoisonMessageHandlingStatusOn;}
		}
		Boolean ISql120Queue.RetentionOn 
		{
			get { return this.RetentionOn;}
		}
		Boolean ISql120Queue.StatusOn 
		{
			get { return this.StatusOn;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Procedure> ISql120Queue.ActivationProcedure 
		{
			get 
			{
				return this.ActivationProcedure;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Queue.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120Queue.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120Queue.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Queue.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120Queue.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Queue.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120Queue.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class QueueEventNotification : ISql120QueueEventNotification
	{		
		String ISql120QueueEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql120QueueEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql120QueueEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> ISql120QueueEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql120QueueEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Queue> ISql120QueueEventNotification.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class RemoteServiceBinding : ISql120RemoteServiceBinding
	{		
		Boolean ISql120RemoteServiceBinding.Anonymous 
		{
			get { return this.Anonymous;}
		}
		String ISql120RemoteServiceBinding.Service 
		{
			get { return this.Service;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120RemoteServiceBinding.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120RemoteServiceBinding.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ResourceGovernor : ISql120ResourceGovernor
	{		
		Boolean? ISql120ResourceGovernor.Enabled 
		{
			get { return this.Enabled;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120ResourceGovernor.ClassifierFunction 
		{
			get 
			{
				return this.ClassifierFunction;
			}
		}
	}
	public partial class ResourcePool : ISql120ResourcePool
	{		
		Int32 ISql120ResourcePool.CapCpuPercent 
		{
			get { return this.CapCpuPercent;}
		}
		Int32 ISql120ResourcePool.MaxCpuPercent 
		{
			get { return this.MaxCpuPercent;}
		}
		Int32 ISql120ResourcePool.MaxIopsPerVolume 
		{
			get { return this.MaxIopsPerVolume;}
		}
		Int32 ISql120ResourcePool.MaxMemoryPercent 
		{
			get { return this.MaxMemoryPercent;}
		}
		Int32 ISql120ResourcePool.MinCpuPercent 
		{
			get { return this.MinCpuPercent;}
		}
		Int32 ISql120ResourcePool.MinIopsPerVolume 
		{
			get { return this.MinIopsPerVolume;}
		}
		Int32 ISql120ResourcePool.MinMemoryPercent 
		{
			get { return this.MinMemoryPercent;}
		}
	}
	public partial class Role : ISql120Role
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Role.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class RoleMembership : ISql120RoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> ISql120RoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Role> ISql120RoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Route : ISql120Route
	{		
		String ISql120Route.Address 
		{
			get { return this.Address;}
		}
		String ISql120Route.BrokerInstance 
		{
			get { return this.BrokerInstance;}
		}
		Int32? ISql120Route.Lifetime 
		{
			get { return this.Lifetime;}
		}
		String ISql120Route.MirrorAddress 
		{
			get { return this.MirrorAddress;}
		}
		String ISql120Route.ServiceName 
		{
			get { return this.ServiceName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Route.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Rule : ISql120Rule
	{		
		String ISql120Rule.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Rule.BoundObjects 
		{
			get 
			{
				return this.BoundObjects;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Rule.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Schema : ISql120Schema
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Schema.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class SearchProperty : ISql120SearchProperty
	{		
		String ISql120SearchProperty.Description 
		{
			get { return this.Description;}
		}
		Int32 ISql120SearchProperty.Identifier 
		{
			get { return this.Identifier;}
		}
		String ISql120SearchProperty.PropertySetGuid 
		{
			get { return this.PropertySetGuid;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SearchPropertyList> ISql120SearchProperty.SearchPropertyList 
		{
			get 
			{
				return this.SearchPropertyList;
			}
		}
	}
	public partial class SearchPropertyList : ISql120SearchPropertyList
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120SearchPropertyList.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class Sequence : ISql120Sequence
	{		
		Int32? ISql120Sequence.CacheSize 
		{
			get { return this.CacheSize;}
		}
		String ISql120Sequence.IncrementValue 
		{
			get { return this.IncrementValue;}
		}
		Boolean ISql120Sequence.IsCached 
		{
			get { return this.IsCached;}
		}
		Boolean ISql120Sequence.IsCycling 
		{
			get { return this.IsCycling;}
		}
		String ISql120Sequence.MaxValue 
		{
			get { return this.MaxValue;}
		}
		String ISql120Sequence.MinValue 
		{
			get { return this.MinValue;}
		}
		Boolean ISql120Sequence.NoMaxValue 
		{
			get { return this.NoMaxValue;}
		}
		Boolean ISql120Sequence.NoMinValue 
		{
			get { return this.NoMinValue;}
		}
		String ISql120Sequence.StartValue 
		{
			get { return this.StartValue;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> ISql120Sequence.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Sequence.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class ServerAudit : ISql120ServerAudit
	{		
		String ISql120ServerAudit.AuditGuid 
		{
			get { return this.AuditGuid;}
		}
		AuditTarget ISql120ServerAudit.AuditTarget 
		{
			get { return this.AuditTarget;}
		}
		Boolean ISql120ServerAudit.Disabled 
		{
			get { return this.Disabled;}
		}
		String ISql120ServerAudit.FilePath 
		{
			get { return this.FilePath;}
		}
		Int32? ISql120ServerAudit.MaxFiles 
		{
			get { return this.MaxFiles;}
		}
		Int32? ISql120ServerAudit.MaxRolloverFiles 
		{
			get { return this.MaxRolloverFiles;}
		}
		Int32? ISql120ServerAudit.MaxSize 
		{
			get { return this.MaxSize;}
		}
		MemoryUnit ISql120ServerAudit.MaxSizeUnit 
		{
			get { return this.MaxSizeUnit;}
		}
		FailureAction ISql120ServerAudit.OnFailure 
		{
			get { return this.OnFailure;}
		}
		String ISql120ServerAudit.PredicateExpression 
		{
			get { return this.PredicateExpression;}
		}
		Int32 ISql120ServerAudit.QueueDelay 
		{
			get { return this.QueueDelay;}
		}
		Boolean ISql120ServerAudit.ReserveDiskSpace 
		{
			get { return this.ReserveDiskSpace;}
		}
		Boolean ISql120ServerAudit.UnlimitedFileSize 
		{
			get { return this.UnlimitedFileSize;}
		}
		Boolean ISql120ServerAudit.UnlimitedMaxRolloverFiles 
		{
			get { return this.UnlimitedMaxRolloverFiles;}
		}
	}
	public partial class ServerAuditSpecification : ISql120ServerAuditSpecification
	{		
		Boolean ISql120ServerAuditSpecification.StateOn 
		{
			get { return this.StateOn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditActionGroup> ISql120ServerAuditSpecification.AuditActionGroups 
		{
			get 
			{
				return this.AuditActionGroups;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ServerAudit> ISql120ServerAuditSpecification.ServerAudit 
		{
			get 
			{
				return this.ServerAudit;
			}
		}
	}
	public partial class ServerDdlTrigger : ISql120ServerDdlTrigger
	{		
		Boolean? ISql120ServerDdlTrigger.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		String ISql120ServerDdlTrigger.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean ISql120ServerDdlTrigger.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean ISql120ServerDdlTrigger.ExecuteAsCaller 
		{
			get { return this.ExecuteAsCaller;}
		}
		Boolean ISql120ServerDdlTrigger.ExecuteAsOwner 
		{
			get { return this.ExecuteAsOwner;}
		}
		Boolean ISql120ServerDdlTrigger.ExecuteAsSelf 
		{
			get { return this.ExecuteAsSelf;}
		}
		Boolean ISql120ServerDdlTrigger.IsLogon 
		{
			get { return this.IsLogon;}
		}
		String ISql120ServerDdlTrigger.MethodName 
		{
			get { return this.MethodName;}
		}
		Boolean? ISql120ServerDdlTrigger.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		TriggerType ISql120ServerDdlTrigger.TriggerType 
		{
			get { return this.TriggerType;}
		}
		Boolean ISql120ServerDdlTrigger.WithEncryption 
		{
			get { return this.WithEncryption;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120ServerDdlTrigger.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120ServerDdlTrigger.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> ISql120ServerDdlTrigger.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql120ServerDdlTrigger.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120ServerDdlTrigger.Login 
		{
			get 
			{
				return this.Login;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> ISql120ServerDdlTrigger.User 
		{
			get 
			{
				return this.User;
			}
		}
	}
	public partial class ServerEventNotification : ISql120ServerEventNotification
	{		
		String ISql120ServerEventNotification.BrokerInstanceSpecifier 
		{
			get { return this.BrokerInstanceSpecifier;}
		}
		String ISql120ServerEventNotification.BrokerService 
		{
			get { return this.BrokerService;}
		}
		Boolean ISql120ServerEventNotification.WithFanIn 
		{
			get { return this.WithFanIn;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> ISql120ServerEventNotification.EventGroup 
		{
			get 
			{
				return this.EventGroup;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> ISql120ServerEventNotification.EventType 
		{
			get 
			{
				return this.EventType;
			}
		}
	}
	public partial class ServerOptions : ISql120ServerOptions
	{		
	}
	public partial class ServerRoleMembership : ISql120ServerRoleMembership
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> ISql120ServerRoleMembership.Member 
		{
			get 
			{
				return this.Member;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Role> ISql120ServerRoleMembership.Role 
		{
			get 
			{
				return this.Role;
			}
		}
	}
	public partial class Service : ISql120Service
	{		
		Boolean ISql120Service.UseDefaultContract 
		{
			get { return this.UseDefaultContract;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120Service.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Contract> ISql120Service.Contracts 
		{
			get 
			{
				return this.Contracts;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Queue> ISql120Service.Queue 
		{
			get 
			{
				return this.Queue;
			}
		}
	}
	public partial class ServiceBrokerLanguageSpecifier : ISql120ServiceBrokerLanguageSpecifier
	{		
		ServiceBrokerEncryptionAlgorithm ISql120ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart1 
		{
			get { return this.EncryptionAlgorithmPart1;}
		}
		ServiceBrokerEncryptionAlgorithm ISql120ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart2 
		{
			get { return this.EncryptionAlgorithmPart2;}
		}
		EncryptionMode ISql120ServiceBrokerLanguageSpecifier.EncryptionMode 
		{
			get { return this.EncryptionMode;}
		}
		Boolean ISql120ServiceBrokerLanguageSpecifier.MessageForwardingEnabled 
		{
			get { return this.MessageForwardingEnabled;}
		}
		Int32 ISql120ServiceBrokerLanguageSpecifier.MessageForwardSize 
		{
			get { return this.MessageForwardSize;}
		}
		Boolean ISql120ServiceBrokerLanguageSpecifier.UseCertificateFirst 
		{
			get { return this.UseCertificateFirst;}
		}
		AuthenticationModes ISql120ServiceBrokerLanguageSpecifier.WindowsAuthenticationMode 
		{
			get { return this.WindowsAuthenticationMode;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120ServiceBrokerLanguageSpecifier.AuthenticationCertificate 
		{
			get 
			{
				return this.AuthenticationCertificate;
			}
		}
	}
	public partial class Signature : ISql120Signature
	{		
		Boolean ISql120Signature.IsCounterSignature 
		{
			get { return this.IsCounterSignature;}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120Signature.EncryptionMechanism 
		{
			get 
			{
				return this.EncryptionMechanism;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql120Signature.SignedObject 
		{
			get 
			{
				return this.SignedObject;
			}
		}
	}
	public partial class SignatureEncryptionMechanism : ISql120SignatureEncryptionMechanism
	{		
		String ISql120SignatureEncryptionMechanism.Password 
		{
			get { return this.Password;}
		}
		String ISql120SignatureEncryptionMechanism.SignedBlob 
		{
			get { return this.SignedBlob;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> ISql120SignatureEncryptionMechanism.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120SignatureEncryptionMechanism.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}
	}
	public partial class SoapLanguageSpecifier : ISql120SoapLanguageSpecifier
	{		
		Boolean ISql120SoapLanguageSpecifier.BatchesEnabled 
		{
			get { return this.BatchesEnabled;}
		}
		CharacterSet ISql120SoapLanguageSpecifier.CharacterSet 
		{
			get { return this.CharacterSet;}
		}
		String ISql120SoapLanguageSpecifier.DatabaseName 
		{
			get { return this.DatabaseName;}
		}
		Int32 ISql120SoapLanguageSpecifier.HeaderLimit 
		{
			get { return this.HeaderLimit;}
		}
		Boolean ISql120SoapLanguageSpecifier.IsDefaultDatabase 
		{
			get { return this.IsDefaultDatabase;}
		}
		Boolean ISql120SoapLanguageSpecifier.IsDefaultNamespace 
		{
			get { return this.IsDefaultNamespace;}
		}
		Boolean ISql120SoapLanguageSpecifier.IsDefaultWsdlSpName 
		{
			get { return this.IsDefaultWsdlSpName;}
		}
		SoapLoginType ISql120SoapLanguageSpecifier.LoginType 
		{
			get { return this.LoginType;}
		}
		String ISql120SoapLanguageSpecifier.Namespace 
		{
			get { return this.Namespace;}
		}
		SoapSchema ISql120SoapLanguageSpecifier.SchemaType 
		{
			get { return this.SchemaType;}
		}
		Boolean ISql120SoapLanguageSpecifier.SessionsEnabled 
		{
			get { return this.SessionsEnabled;}
		}
		Int32 ISql120SoapLanguageSpecifier.SessionTimeout 
		{
			get { return this.SessionTimeout;}
		}
		Boolean ISql120SoapLanguageSpecifier.SessionTimeoutNever 
		{
			get { return this.SessionTimeoutNever;}
		}
		String ISql120SoapLanguageSpecifier.WsdlSpName 
		{
			get { return this.WsdlSpName;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SoapMethodSpecification> ISql120SoapLanguageSpecifier.WebMethods 
		{
			get 
			{
				return this.WebMethods;
			}
		}
	}
	public partial class SoapMethodSpecification : ISql120SoapMethodSpecification
	{		
		SoapFormat ISql120SoapMethodSpecification.Format 
		{
			get { return this.Format;}
		}
		SoapSchema ISql120SoapMethodSpecification.SchemaType 
		{
			get { return this.SchemaType;}
		}
		String ISql120SoapMethodSpecification.WebMethodAlias 
		{
			get { return this.WebMethodAlias;}
		}
		String ISql120SoapMethodSpecification.WebMethodNamespace 
		{
			get { return this.WebMethodNamespace;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120SoapMethodSpecification.RelatedMethod 
		{
			get 
			{
				return this.RelatedMethod;
			}
		}
	}
	public partial class SpatialIndex : ISql120SpatialIndex
	{		
		Boolean ISql120SpatialIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql120SpatialIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Int32? ISql120SpatialIndex.CellsPerObject 
		{
			get { return this.CellsPerObject;}
		}
		CompressionLevel ISql120SpatialIndex.DataCompression 
		{
			get { return this.DataCompression;}
		}
		Boolean ISql120SpatialIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32 ISql120SpatialIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Degree ISql120SpatialIndex.GridLevel1Density 
		{
			get { return this.GridLevel1Density;}
		}
		Degree ISql120SpatialIndex.GridLevel2Density 
		{
			get { return this.GridLevel2Density;}
		}
		Degree ISql120SpatialIndex.GridLevel3Density 
		{
			get { return this.GridLevel3Density;}
		}
		Degree ISql120SpatialIndex.GridLevel4Density 
		{
			get { return this.GridLevel4Density;}
		}
		Boolean ISql120SpatialIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql120SpatialIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Tessellation ISql120SpatialIndex.Tessellation 
		{
			get { return this.Tessellation;}
		}
		Boolean ISql120SpatialIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}
		Double? ISql120SpatialIndex.XMax 
		{
			get { return this.XMax;}
		}
		Double? ISql120SpatialIndex.XMin 
		{
			get { return this.XMin;}
		}
		Double? ISql120SpatialIndex.YMax 
		{
			get { return this.YMax;}
		}
		Double? ISql120SpatialIndex.YMin 
		{
			get { return this.YMin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120SpatialIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120SpatialIndex.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql120SpatialIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120SpatialIndex.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120SpatialIndex.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class Statistics : ISql120Statistics
	{		
		String ISql120Statistics.FilterPredicate 
		{
			get { return this.FilterPredicate;}
		}
		Boolean ISql120Statistics.Incremental 
		{
			get { return this.Incremental;}
		}
		Boolean ISql120Statistics.NoRecompute 
		{
			get { return this.NoRecompute;}
		}
		Int32 ISql120Statistics.SampleSize 
		{
			get { return this.SampleSize;}
		}
		SamplingStyle ISql120Statistics.SamplingStyle 
		{
			get { return this.SamplingStyle;}
		}
		String ISql120Statistics.StatsStream 
		{
			get { return this.StatsStream;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Statistics.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Statistics.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Hierarchical
		IEnumerable<TSqlObject> ISql120Statistics.OnObject 
		{
			get 
			{
				return this.OnObject;
			}
		}
	}
	public partial class Parameter : ISql120Parameter
	{		
		String ISql120Parameter.DefaultExpression 
		{
			get { return this.DefaultExpression;}
		}
		Boolean ISql120Parameter.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql120Parameter.IsOutput 
		{
			get { return this.IsOutput;}
		}
		Int32 ISql120Parameter.Length 
		{
			get { return this.Length;}
		}
		Int32 ISql120Parameter.Precision 
		{
			get { return this.Precision;}
		}
		Boolean ISql120Parameter.ReadOnly 
		{
			get { return this.ReadOnly;}
		}
		Int32 ISql120Parameter.Scale 
		{
			get { return this.Scale;}
		}
		Boolean ISql120Parameter.Varying 
		{
			get { return this.Varying;}
		}
		XmlStyle ISql120Parameter.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> ISql120Parameter.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> ISql120Parameter.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class SymmetricKey : ISql120SymmetricKey
	{		
		SymmetricKeyAlgorithm ISql120SymmetricKey.Algorithm 
		{
			get { return this.Algorithm;}
		}
		SymmetricKeyCreationDisposition ISql120SymmetricKey.CreationDisposition 
		{
			get { return this.CreationDisposition;}
		}
		String ISql120SymmetricKey.IdentityValue 
		{
			get { return this.IdentityValue;}
		}
		String ISql120SymmetricKey.KeySource 
		{
			get { return this.KeySource;}
		}
		String ISql120SymmetricKey.ProviderKeyName 
		{
			get { return this.ProviderKeyName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> ISql120SymmetricKey.AsymmetricKeys 
		{
			get 
			{
				return this.AsymmetricKeys;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120SymmetricKey.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120SymmetricKey.Certificates 
		{
			get 
			{
				return this.Certificates;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120SymmetricKey.Passwords 
		{
			get 
			{
				return this.Passwords;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120SymmetricKey.Provider 
		{
			get 
			{
				return this.Provider;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SymmetricKey> ISql120SymmetricKey.SymmetricKeys 
		{
			get 
			{
				return this.SymmetricKeys;
			}
		}
	}
	public partial class SymmetricKeyPassword : ISql120SymmetricKeyPassword
	{		
		String ISql120SymmetricKeyPassword.Password 
		{
			get { return this.Password;}
		}
	}
	public partial class Synonym : ISql120Synonym
	{		
		String ISql120Synonym.ForObjectName 
		{
			get { return this.ForObjectName;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120Synonym.ForObject 
		{
			get 
			{
				return this.ForObject;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Synonym.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class Table : ISql120Table
	{		
		Boolean? ISql120Table.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean ISql120Table.ChangeDataCaptureEnabled 
		{
			get { return this.ChangeDataCaptureEnabled;}
		}
		Boolean ISql120Table.ChangeTrackingEnabled 
		{
			get { return this.ChangeTrackingEnabled;}
		}
		Durability ISql120Table.Durability 
		{
			get { return this.Durability;}
		}
		Boolean? ISql120Table.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Boolean ISql120Table.IsReplicated 
		{
			get { return this.IsReplicated;}
		}
		Boolean ISql120Table.LargeValueTypesOutOfRow 
		{
			get { return this.LargeValueTypesOutOfRow;}
		}
		LockEscalationMethod ISql120Table.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean ISql120Table.MemoryOptimized 
		{
			get { return this.MemoryOptimized;}
		}
		Boolean? ISql120Table.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120Table.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}
		Int32 ISql120Table.TextInRowSize 
		{
			get { return this.TextInRowSize;}
		}
		Boolean ISql120Table.TrackColumnsUpdated 
		{
			get { return this.TrackColumnsUpdated;}
		}
		Boolean ISql120Table.VardecimalStorageFormatEnabled 
		{
			get { return this.VardecimalStorageFormatEnabled;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Table.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> ISql120Table.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120Table.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120Table.FilegroupForTextImage 
		{
			get 
			{
				return this.FilegroupForTextImage;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120Table.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120Table.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120Table.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120Table.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120Table.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class FileTable : ISql120FileTable
	{		
		Boolean? ISql120FileTable.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql120FileTable.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		String ISql120FileTable.FileTableCollateFilename 
		{
			get { return this.FileTableCollateFilename;}
		}
		String ISql120FileTable.FileTableDirectory 
		{
			get { return this.FileTableDirectory;}
		}
		Boolean ISql120FileTable.FileTableNamespaceEnabled 
		{
			get { return this.FileTableNamespaceEnabled;}
		}
		LockEscalationMethod ISql120FileTable.LockEscalation 
		{
			get { return this.LockEscalation;}
		}
		Boolean? ISql120FileTable.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120FileTable.TableLockOnBulkLoad 
		{
			get { return this.TableLockOnBulkLoad;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120FileTable.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> ISql120FileTable.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120FileTable.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120FileTable.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120FileTable.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120FileTable.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120FileTable.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120FileTable.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableType : ISql120TableType
	{		
		Boolean ISql120TableType.MemoryOptimized 
		{
			get { return this.MemoryOptimized;}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120TableType.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> ISql120TableType.Constraints 
		{
			get 
			{
				return this.Constraints;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlIndex> ISql120TableType.Indexes 
		{
			get 
			{
				return this.Indexes;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120TableType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class TableTypeCheckConstraint : ISql120TableTypeCheckConstraint
	{		
		String ISql120TableTypeCheckConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120TableTypeCheckConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}
	}
	public partial class TableTypeColumn : ISql120TableTypeColumn
	{		
		String ISql120TableTypeColumn.Collation 
		{
			get { return this.Collation;}
		}
		String ISql120TableTypeColumn.Expression 
		{
			get { return this.Expression;}
		}
		String ISql120TableTypeColumn.IdentityIncrement 
		{
			get { return this.IdentityIncrement;}
		}
		String ISql120TableTypeColumn.IdentitySeed 
		{
			get { return this.IdentitySeed;}
		}
		Boolean ISql120TableTypeColumn.IsIdentity 
		{
			get { return this.IsIdentity;}
		}
		Boolean ISql120TableTypeColumn.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql120TableTypeColumn.IsRowGuidCol 
		{
			get { return this.IsRowGuidCol;}
		}
		Int32 ISql120TableTypeColumn.Length 
		{
			get { return this.Length;}
		}
		Boolean ISql120TableTypeColumn.Nullable 
		{
			get { return this.Nullable;}
		}
		Boolean ISql120TableTypeColumn.Persisted 
		{
			get { return this.Persisted;}
		}
		Boolean? ISql120TableTypeColumn.PersistedNullable 
		{
			get { return this.PersistedNullable;}
		}
		Int32 ISql120TableTypeColumn.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql120TableTypeColumn.Scale 
		{
			get { return this.Scale;}
		}
		XmlStyle ISql120TableTypeColumn.XmlStyle 
		{
			get { return this.XmlStyle;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> ISql120TableTypeColumn.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120TableTypeColumn.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> ISql120TableTypeColumn.XmlSchemaCollection 
		{
			get 
			{
				return this.XmlSchemaCollection;
			}
		}
	}
	public partial class TableTypeDefaultConstraint : ISql120TableTypeDefaultConstraint
	{		
		String ISql120TableTypeDefaultConstraint.Expression 
		{
			get { return this.Expression;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120TableTypeDefaultConstraint.ExpressionDependencies 
		{
			get 
			{
				return this.ExpressionDependencies;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120TableTypeDefaultConstraint.TargetColumn 
		{
			get 
			{
				return this.TargetColumn;
			}
		}
	}
	public partial class TableTypeIndex : ISql120TableTypeIndex
	{		
		Int32? ISql120TableTypeIndex.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql120TableTypeIndex.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql120TableTypeIndex.IsDisabled 
		{
			get { return this.IsDisabled;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120TableTypeIndex.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypePrimaryKeyConstraint : ISql120TableTypePrimaryKeyConstraint
	{		
		Int32? ISql120TableTypePrimaryKeyConstraint.BucketCount 
		{
			get { return this.BucketCount;}
		}
		Boolean ISql120TableTypePrimaryKeyConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql120TableTypePrimaryKeyConstraint.Hash 
		{
			get { return this.Hash;}
		}
		Boolean ISql120TableTypePrimaryKeyConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120TableTypePrimaryKeyConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TableTypeUniqueConstraint : ISql120TableTypeUniqueConstraint
	{		
		Boolean ISql120TableTypeUniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql120TableTypeUniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120TableTypeUniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}
	}
	public partial class TcpProtocolSpecifier : ISql120TcpProtocolSpecifier
	{		
		String ISql120TcpProtocolSpecifier.ListenerIPv4 
		{
			get { return this.ListenerIPv4;}
		}
		String ISql120TcpProtocolSpecifier.ListenerIPv6 
		{
			get { return this.ListenerIPv6;}
		}
		Int32 ISql120TcpProtocolSpecifier.ListenerPort 
		{
			get { return this.ListenerPort;}
		}
		Boolean ISql120TcpProtocolSpecifier.ListeningOnAllIPs 
		{
			get { return this.ListeningOnAllIPs;}
		}
	}
	public partial class UniqueConstraint : ISql120UniqueConstraint
	{		
		Boolean ISql120UniqueConstraint.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql120UniqueConstraint.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql120UniqueConstraint.Clustered 
		{
			get { return this.Clustered;}
		}
		Boolean ISql120UniqueConstraint.Disabled 
		{
			get { return this.Disabled;}
		}
		Boolean? ISql120UniqueConstraint.FileStreamNull 
		{
			get { return this.FileStreamNull;}
		}
		Int32? ISql120UniqueConstraint.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql120UniqueConstraint.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql120UniqueConstraint.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql120UniqueConstraint.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120UniqueConstraint.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> ISql120UniqueConstraint.DataCompressionOptions 
		{
			get 
			{
				return this.DataCompressionOptions;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120UniqueConstraint.Filegroup 
		{
			get 
			{
				return this.Filegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> ISql120UniqueConstraint.FileStreamFilegroup 
		{
			get 
			{
				return this.FileStreamFilegroup;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120UniqueConstraint.FileStreamPartitionScheme 
		{
			get 
			{
				return this.FileStreamPartitionScheme;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> ISql120UniqueConstraint.Host 
		{
			get 
			{
				return this.Host;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120UniqueConstraint.PartitionColumn 
		{
			get 
			{
				return this.PartitionColumn;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> ISql120UniqueConstraint.PartitionScheme 
		{
			get 
			{
				return this.PartitionScheme;
			}
		}
	}
	public partial class User : ISql120User
	{		
		AuthenticationType ISql120User.AuthenticationType 
		{
			get { return this.AuthenticationType;}
		}
		String ISql120User.DefaultLanguage 
		{
			get { return this.DefaultLanguage;}
		}
		String ISql120User.Password 
		{
			get { return this.Password;}
		}
		String ISql120User.Sid 
		{
			get { return this.Sid;}
		}
		Boolean ISql120User.WithoutLogin 
		{
			get { return this.WithoutLogin;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> ISql120User.AsymmetricKey 
		{
			get 
			{
				return this.AsymmetricKey;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> ISql120User.Certificate 
		{
			get 
			{
				return this.Certificate;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120User.DefaultSchema 
		{
			get 
			{
				return this.DefaultSchema;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> ISql120User.Login 
		{
			get 
			{
				return this.Login;
			}
		}
	}
	public partial class UserDefinedServerRole : ISql120UserDefinedServerRole
	{		

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> ISql120UserDefinedServerRole.Authorizer 
		{
			get 
			{
				return this.Authorizer;
			}
		}
	}
	public partial class UserDefinedType : ISql120UserDefinedType
	{		
		Boolean? ISql120UserDefinedType.ByteOrdered 
		{
			get { return this.ByteOrdered;}
		}
		String ISql120UserDefinedType.ClassName 
		{
			get { return this.ClassName;}
		}
		Boolean? ISql120UserDefinedType.FixedLength 
		{
			get { return this.FixedLength;}
		}
		Format ISql120UserDefinedType.Format 
		{
			get { return this.Format;}
		}
		Int32? ISql120UserDefinedType.MaxByteSize 
		{
			get { return this.MaxByteSize;}
		}
		String ISql120UserDefinedType.ValidationMethodName 
		{
			get { return this.ValidationMethodName;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ISql120UserDefinedType.Assembly 
		{
			get 
			{
				return this.Assembly;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120UserDefinedType.Methods 
		{
			get 
			{
				return this.Methods;
			}
		}

		//Composing
		IEnumerable<TSqlObject> ISql120UserDefinedType.Properties 
		{
			get 
			{
				return this.Properties;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120UserDefinedType.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class View : ISql120View
	{		
		Boolean? ISql120View.AnsiNullsOn 
		{
			get { return this.AnsiNullsOn;}
		}
		Boolean? ISql120View.QuotedIdentifierOn 
		{
			get { return this.QuotedIdentifierOn;}
		}
		Boolean ISql120View.Replicated 
		{
			get { return this.Replicated;}
		}
		String ISql120View.SelectStatement 
		{
			get { return this.SelectStatement;}
		}
		Boolean ISql120View.WithCheckOption 
		{
			get { return this.WithCheckOption;}
		}
		Boolean ISql120View.WithEncryption 
		{
			get { return this.WithEncryption;}
		}
		Boolean ISql120View.WithSchemaBinding 
		{
			get { return this.WithSchemaBinding;}
		}
		Boolean ISql120View.WithViewMetadata 
		{
			get { return this.WithViewMetadata;}
		}

		//Peer
		IEnumerable<TSqlObject> ISql120View.BodyDependencies 
		{
			get 
			{
				return this.BodyDependencies;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120View.Columns 
		{
			get 
			{
				return this.Columns;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120View.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
	public partial class WorkloadGroup : ISql120WorkloadGroup
	{		
		Int32 ISql120WorkloadGroup.GroupMaxRequests 
		{
			get { return this.GroupMaxRequests;}
		}
		Degree ISql120WorkloadGroup.Importance 
		{
			get { return this.Importance;}
		}
		Int32 ISql120WorkloadGroup.MaxDop 
		{
			get { return this.MaxDop;}
		}
		Int32 ISql120WorkloadGroup.RequestMaxCpuTimeSec 
		{
			get { return this.RequestMaxCpuTimeSec;}
		}
		Int32 ISql120WorkloadGroup.RequestMaxMemoryGrantPercent 
		{
			get { return this.RequestMaxMemoryGrantPercent;}
		}
		Int32 ISql120WorkloadGroup.RequestMemoryGrantTimeoutSec 
		{
			get { return this.RequestMemoryGrantTimeoutSec;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ResourcePool> ISql120WorkloadGroup.ResourcePool 
		{
			get 
			{
				return this.ResourcePool;
			}
		}
	}
	public partial class XmlIndex : ISql120XmlIndex
	{		
		Boolean ISql120XmlIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql120XmlIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql120XmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql120XmlIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql120XmlIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql120XmlIndex.IsPrimary 
		{
			get { return this.IsPrimary;}
		}
		Boolean ISql120XmlIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		SecondaryXmlIndexType ISql120XmlIndex.SecondaryXmlIndexType 
		{
			get { return this.SecondaryXmlIndexType;}
		}
		Boolean ISql120XmlIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120XmlIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql120XmlIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlIndex> ISql120XmlIndex.PrimaryXmlIndex 
		{
			get 
			{
				return this.PrimaryXmlIndex;
			}
		}
	}
	public partial class SelectiveXmlIndex : ISql120SelectiveXmlIndex
	{		
		Boolean ISql120SelectiveXmlIndex.AllowPageLocks 
		{
			get { return this.AllowPageLocks;}
		}
		Boolean ISql120SelectiveXmlIndex.AllowRowLocks 
		{
			get { return this.AllowRowLocks;}
		}
		Boolean ISql120SelectiveXmlIndex.Disabled 
		{
			get { return this.Disabled;}
		}
		Int32? ISql120SelectiveXmlIndex.FillFactor 
		{
			get { return this.FillFactor;}
		}
		Boolean ISql120SelectiveXmlIndex.IgnoreDuplicateKey 
		{
			get { return this.IgnoreDuplicateKey;}
		}
		Boolean ISql120SelectiveXmlIndex.IsPrimary 
		{
			get { return this.IsPrimary;}
		}
		Boolean ISql120SelectiveXmlIndex.RecomputeStatistics 
		{
			get { return this.RecomputeStatistics;}
		}
		Boolean ISql120SelectiveXmlIndex.WithPadIndex 
		{
			get { return this.WithPadIndex;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ISql120SelectiveXmlIndex.Column 
		{
			get 
			{
				return this.Column;
			}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> ISql120SelectiveXmlIndex.IndexedObject 
		{
			get 
			{
				return this.IndexedObject;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> ISql120SelectiveXmlIndex.PrimaryPromotedPath 
		{
			get 
			{
				return this.PrimaryPromotedPath;
			}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SelectiveXmlIndex> ISql120SelectiveXmlIndex.PrimarySelectiveXmlIndex 
		{
			get 
			{
				return this.PrimarySelectiveXmlIndex;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> ISql120SelectiveXmlIndex.PromotedPaths 
		{
			get 
			{
				return this.PromotedPaths;
			}
		}

		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlNamespace> ISql120SelectiveXmlIndex.XmlNamespaces 
		{
			get 
			{
				return this.XmlNamespaces;
			}
		}
	}
	public partial class XmlNamespace : ISql120XmlNamespace
	{		
		String ISql120XmlNamespace.NamespaceUri 
		{
			get { return this.NamespaceUri;}
		}
		String ISql120XmlNamespace.Prefix 
		{
			get { return this.Prefix;}
		}
	}
	public partial class PromotedNodePathForXQueryType : ISql120PromotedNodePathForXQueryType
	{		
		Boolean ISql120PromotedNodePathForXQueryType.IsSingleton 
		{
			get { return this.IsSingleton;}
		}
		Int32? ISql120PromotedNodePathForXQueryType.MaxLength 
		{
			get { return this.MaxLength;}
		}
		String ISql120PromotedNodePathForXQueryType.NodePath 
		{
			get { return this.NodePath;}
		}
		String ISql120PromotedNodePathForXQueryType.Type 
		{
			get { return this.Type;}
		}
	}
	public partial class PromotedNodePathForSqlType : ISql120PromotedNodePathForSqlType
	{		
		Boolean ISql120PromotedNodePathForSqlType.IsMax 
		{
			get { return this.IsMax;}
		}
		Boolean ISql120PromotedNodePathForSqlType.IsSingleton 
		{
			get { return this.IsSingleton;}
		}
		Int32 ISql120PromotedNodePathForSqlType.Length 
		{
			get { return this.Length;}
		}
		String ISql120PromotedNodePathForSqlType.NodePath 
		{
			get { return this.NodePath;}
		}
		Int32 ISql120PromotedNodePathForSqlType.Precision 
		{
			get { return this.Precision;}
		}
		Int32 ISql120PromotedNodePathForSqlType.Scale 
		{
			get { return this.Scale;}
		}

		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> ISql120PromotedNodePathForSqlType.DataType 
		{
			get 
			{
				return this.DataType;
			}
		}
	}
	public partial class XmlSchemaCollection : ISql120XmlSchemaCollection
	{		
		String ISql120XmlSchemaCollection.Expression 
		{
			get { return this.Expression;}
		}

		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> ISql120XmlSchemaCollection.Schema 
		{
			get 
			{
				return this.Schema;
			}
		}
	}
}
