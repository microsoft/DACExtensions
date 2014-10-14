

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
	using System;
	using System.Linq; 
	using Microsoft.SqlServer.Server;
	using Microsoft.SqlServer.Dac.Model;
	using System.Collections.Generic;
	public interface ISql90Column : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsIdentityNotForReplication 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql90TableValuedFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		String ReturnTableVariableName 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90ScalarFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90Aggregate : ISqlModelElement
	{		
		String ClassName 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Boolean? InvariantToDuplicates 
		{
			get;
		}
		Boolean? InvariantToNulls 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		Boolean? NullIfEmpty 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90ApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql90Index : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean Unique 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90Assembly : ISqlModelElement
	{		
		AssemblyPermissionSet PermissionSet 
		{
			get;
		}
		Boolean Visible 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql90AssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql90AsymmetricKey : ISqlModelElement
	{		
		AsymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String ExecutableFile 
		{
			get;
		}
		String File 
		{
			get;
		}
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90AuditAction : ISqlModelElement
	{		
	}
	public interface ISql90AuditActionGroup : ISqlModelElement
	{		
	}
	public interface ISql90AuditActionSpecification : ISqlModelElement
	{		
	}
	public interface ISql90BrokerPriority : ISqlModelElement
	{		
	}
	public interface ISql90BuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql90DataType : ISqlModelElement
	{		
		SqlDataType SqlDataType 
		{
			get;
		}
		Boolean UddtIsMax 
		{
			get;
		}
		Int32 UddtLength 
		{
			get;
		}
		Boolean UddtNullable 
		{
			get;
		}
		Int32 UddtPrecision 
		{
			get;
		}
		Int32 UddtScale 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql90Certificate : ISqlModelElement
	{		
		Boolean ActiveForBeginDialog 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String EncryptionPassword 
		{
			get;
		}
		String ExistingKeysFilePath 
		{
			get;
		}
		String ExpiryDate 
		{
			get;
		}
		Boolean IsExistingKeyFileExecutable 
		{
			get;
		}
		String PrivateKeyDecryptionPassword 
		{
			get;
		}
		String PrivateKeyEncryptionPassword 
		{
			get;
		}
		String PrivateKeyFilePath 
		{
			get;
		}
		String StartDate 
		{
			get;
		}
		String Subject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql90CheckConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql90ClrTypeMethod : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
	}
	public interface ISql90ClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90DataType> DataType 
		{
			get;
		}
	}
	public interface ISql90ClrTypeProperty : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ClrType 
		{
			get;
		}
	}
	public interface ISql90ColumnStoreIndex : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90Contract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90MessageType> Messages 
		{
			get;
		}
	}
	public interface ISql90Credential : ISqlModelElement
	{		
		String Identity 
		{
			get;
		}
		String Secret 
		{
			get;
		}
	}
	public interface ISql90CryptographicProvider : ISqlModelElement
	{		
	}
	public interface ISql90DatabaseAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISql90DatabaseDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90DatabaseEncryptionKey : ISqlModelElement
	{		
	}
	public interface ISql90DatabaseEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql90DatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		DatabaseMirroringRole RoleType 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql90DatabaseOptions : ISqlModelElement
	{		
		Boolean AllowSnapshotIsolation 
		{
			get;
		}
		Boolean AnsiNullDefaultOn 
		{
			get;
		}
		Boolean AnsiNullsOn 
		{
			get;
		}
		Boolean AnsiPaddingOn 
		{
			get;
		}
		Boolean AnsiWarningsOn 
		{
			get;
		}
		Boolean ArithAbortOn 
		{
			get;
		}
		Boolean AutoClose 
		{
			get;
		}
		Boolean AutoCreateStatistics 
		{
			get;
		}
		Boolean AutoShrink 
		{
			get;
		}
		Boolean AutoUpdateStatistics 
		{
			get;
		}
		Boolean AutoUpdateStatisticsAsync 
		{
			get;
		}
		String Collation 
		{
			get;
		}
		Int32 CompatibilityLevel 
		{
			get;
		}
		Boolean ConcatNullYieldsNull 
		{
			get;
		}
		Boolean CursorCloseOnCommit 
		{
			get;
		}
		Boolean CursorDefaultGlobalScope 
		{
			get;
		}
		Boolean DatabaseStateOffline 
		{
			get;
		}
		Boolean DateCorrelationOptimizationOn 
		{
			get;
		}
		Boolean DBChainingOn 
		{
			get;
		}
		Boolean FullTextEnabled 
		{
			get;
		}
		Boolean MemoryOptimizedElevateToSnapshot 
		{
			get;
		}
		Boolean NumericRoundAbortOn 
		{
			get;
		}
		PageVerifyMode PageVerifyMode 
		{
			get;
		}
		ParameterizationOption ParameterizationOption 
		{
			get;
		}
		Boolean QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		RecoveryMode RecoveryMode 
		{
			get;
		}
		Boolean RecursiveTriggersOn 
		{
			get;
		}
		ServiceBrokerOption ServiceBrokerOption 
		{
			get;
		}
		Boolean SupplementalLoggingOn 
		{
			get;
		}
		Boolean TornPageProtectionOn 
		{
			get;
		}
		Boolean TransactionIsolationReadCommittedSnapshot 
		{
			get;
		}
		Boolean Trustworthy 
		{
			get;
		}
		UserAccessOption UserAccessOption 
		{
			get;
		}
		Boolean VardecimalStorageFormatOn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> DefaultFilegroup 
		{
			get;
		}
	}
	public interface ISql90DataCompressionOption : ISqlModelElement
	{		
	}
	public interface ISql90Default : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90DefaultConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean WithValues 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql90DmlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		OrderRestriction DeleteOrderRestriction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		OrderRestriction InsertOrderRestriction 
		{
			get;
		}
		Boolean IsDeleteTrigger 
		{
			get;
		}
		Boolean IsInsertTrigger 
		{
			get;
		}
		Boolean IsUpdateTrigger 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		OrderRestriction UpdateOrderRestriction 
		{
			get;
		}
		Boolean WithAppend 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90Endpoint : ISqlModelElement
	{		
		Payload Payload 
		{
			get;
		}
		Protocol Protocol 
		{
			get;
		}
		State State 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> PayloadSpecifier 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ProtocolSpecifier 
		{
			get;
		}
	}
	public interface ISql90ErrorMessage : ISqlModelElement
	{		
		String Language 
		{
			get;
		}
		Int32 MessageNumber 
		{
			get;
		}
		String MessageText 
		{
			get;
		}
		Int32 Severity 
		{
			get;
		}
		Boolean WithLog 
		{
			get;
		}
	}
	public interface ISql90EventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql90EventSession : ISqlModelElement
	{		
	}
	public interface ISql90EventSessionAction : ISqlModelElement
	{		
	}
	public interface ISql90EventSessionDefinitions : ISqlModelElement
	{		
	}
	public interface ISql90EventSessionSetting : ISqlModelElement
	{		
	}
	public interface ISql90EventSessionTarget : ISqlModelElement
	{		
	}
	public interface ISql90EventTypeSpecifier : ISqlModelElement
	{		
		EventType EventType 
		{
			get;
		}
		OrderRestriction Order 
		{
			get;
		}
	}
	public interface ISql90ExtendedProcedure : ISqlModelElement
	{		
		Boolean ExeccuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90ExtendedProperty : ISqlModelElement
	{		
		String Value 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> Host 
		{
			get;
		}
	}
	public interface ISql90SqlFile : ISqlModelElement
	{		
		Int32? FileGrowth 
		{
			get;
		}
		MemoryUnit FileGrowthUnit 
		{
			get;
		}
		String FileName 
		{
			get;
		}
		Boolean IsLogFile 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		Boolean Offline 
		{
			get;
		}
		Int32? Size 
		{
			get;
		}
		MemoryUnit SizeUnit 
		{
			get;
		}
		Boolean Unlimited 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql90Filegroup : ISqlModelElement
	{		
		Boolean ReadOnly 
		{
			get;
		}
	}
	public interface ISql90ForeignKeyConstraint : ISqlModelElement
	{		
		ForeignKeyAction DeleteAction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		ForeignKeyAction UpdateAction 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Table> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql90FullTextCatalog : ISqlModelElement
	{		
		Boolean? AccentSensitivity 
		{
			get;
		}
		Boolean IsDefault 
		{
			get;
		}
		String Path 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql90FullTextIndex : ISqlModelElement
	{		
		ChangeTrackingOption ChangeTracking 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Catalog 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> UniqueIndexName 
		{
			get;
		}
	}
	public interface ISql90FullTextIndexColumnSpecifier : ISqlModelElement
	{		
		Int32? LanguageId 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> TypeColumn 
		{
			get;
		}
	}
	public interface ISql90FullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90HttpProtocolSpecifier : ISqlModelElement
	{		
		AuthenticationModes AuthenticationMode 
		{
			get;
		}
		String AuthenticationRealm 
		{
			get;
		}
		Int32? ClearPort 
		{
			get;
		}
		Boolean CompressionEnabled 
		{
			get;
		}
		String DefaultLogonDomain 
		{
			get;
		}
		Boolean ListeningOnAllNoneReservedSites 
		{
			get;
		}
		Boolean ListeningOnAllSites 
		{
			get;
		}
		String Path 
		{
			get;
		}
		HttpPorts Ports 
		{
			get;
		}
		Int32? SslPort 
		{
			get;
		}
		String Website 
		{
			get;
		}
	}
	public interface ISql90LinkedServer : ISqlModelElement
	{		
		String Catalog 
		{
			get;
		}
		Boolean CollationCompatible 
		{
			get;
		}
		String CollationName 
		{
			get;
		}
		Int32 ConnectTimeout 
		{
			get;
		}
		Boolean DataAccess 
		{
			get;
		}
		String DataSource 
		{
			get;
		}
		Boolean IsDistributor 
		{
			get;
		}
		Boolean IsPublisher 
		{
			get;
		}
		Boolean IsSubscriber 
		{
			get;
		}
		Boolean LazySchemaValidationEnabled 
		{
			get;
		}
		String Location 
		{
			get;
		}
		String ProductName 
		{
			get;
		}
		String ProviderName 
		{
			get;
		}
		String ProviderString 
		{
			get;
		}
		Int32 QueryTimeout 
		{
			get;
		}
		Boolean RpcEnabled 
		{
			get;
		}
		Boolean RpcOutEnabled 
		{
			get;
		}
		Boolean UseRemoteCollation 
		{
			get;
		}
	}
	public interface ISql90LinkedServerLogin : ISqlModelElement
	{		
		String LinkedServerLoginName 
		{
			get;
		}
		String LinkedServerPassword 
		{
			get;
		}
		Boolean UseSelf 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90LinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> LocalLogin 
		{
			get;
		}
	}
	public interface ISql90Login : ISqlModelElement
	{		
		Boolean CheckExpiration 
		{
			get;
		}
		Boolean CheckPolicy 
		{
			get;
		}
		String DefaultDatabase 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		LoginEncryptionOption EncryptionOption 
		{
			get;
		}
		Boolean MappedToWindowsLogin 
		{
			get;
		}
		String Password 
		{
			get;
		}
		Boolean PasswordHashed 
		{
			get;
		}
		Boolean PasswordMustChange 
		{
			get;
		}
		String Sid 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Credential> Credential 
		{
			get;
		}
	}
	public interface ISql90MasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql90MessageType : ISqlModelElement
	{		
		ValidationMethod ValidationMethod 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql90PartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ParameterType 
		{
			get;
		}
	}
	public interface ISql90PartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql90PartitionValue : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql90Permission : ISqlModelElement
	{		
		PermissionAction PermissionAction 
		{
			get;
		}
		PermissionType PermissionType 
		{
			get;
		}
		Boolean WithAllPrivileges 
		{
			get;
		}
		Boolean WithGrantOption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> ExcludedColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantee 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantor 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql90PrimaryKeyConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90Procedure : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean ForReplication 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithRecompile 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Procedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90Queue : ISqlModelElement
	{		
		Boolean ActivationExecuteAsCaller 
		{
			get;
		}
		Boolean ActivationExecuteAsOwner 
		{
			get;
		}
		Boolean ActivationExecuteAsSelf 
		{
			get;
		}
		Int32? ActivationMaxQueueReaders 
		{
			get;
		}
		Boolean? ActivationStatusOn 
		{
			get;
		}
		Boolean RetentionOn 
		{
			get;
		}
		Boolean StatusOn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Procedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90QueueEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Queue> Queue 
		{
			get;
		}
	}
	public interface ISql90RemoteServiceBinding : ISqlModelElement
	{		
		Boolean Anonymous 
		{
			get;
		}
		String Service 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90ResourceGovernor : ISqlModelElement
	{		
	}
	public interface ISql90ResourcePool : ISqlModelElement
	{		
	}
	public interface ISql90Role : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90RoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Role> Role 
		{
			get;
		}
	}
	public interface ISql90Route : ISqlModelElement
	{		
		String Address 
		{
			get;
		}
		String BrokerInstance 
		{
			get;
		}
		Int32? Lifetime 
		{
			get;
		}
		String MirrorAddress 
		{
			get;
		}
		String ServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90Rule : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90Schema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90SearchProperty : ISqlModelElement
	{		
	}
	public interface ISql90SearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90Sequence : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90ServerAudit : ISqlModelElement
	{		
	}
	public interface ISql90ServerAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISql90ServerDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean IsLogon 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90User> User 
		{
			get;
		}
	}
	public interface ISql90ServerEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql90ServerOptions : ISqlModelElement
	{		
	}
	public interface ISql90ServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Role> Role 
		{
			get;
		}
	}
	public interface ISql90Service : ISqlModelElement
	{		
		Boolean UseDefaultContract 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Contract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Queue> Queue 
		{
			get;
		}
	}
	public interface ISql90ServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		Boolean MessageForwardingEnabled 
		{
			get;
		}
		Int32 MessageForwardSize 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql90Signature : ISqlModelElement
	{		
		Boolean IsCounterSignature 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EncryptionMechanism 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> SignedObject 
		{
			get;
		}
	}
	public interface ISql90SignatureEncryptionMechanism : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		String SignedBlob 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql90SoapLanguageSpecifier : ISqlModelElement
	{		
		Boolean BatchesEnabled 
		{
			get;
		}
		CharacterSet CharacterSet 
		{
			get;
		}
		String DatabaseName 
		{
			get;
		}
		Int32 HeaderLimit 
		{
			get;
		}
		Boolean IsDefaultDatabase 
		{
			get;
		}
		Boolean IsDefaultNamespace 
		{
			get;
		}
		Boolean IsDefaultWsdlSpName 
		{
			get;
		}
		SoapLoginType LoginType 
		{
			get;
		}
		String Namespace 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		Boolean SessionsEnabled 
		{
			get;
		}
		Int32 SessionTimeout 
		{
			get;
		}
		Boolean SessionTimeoutNever 
		{
			get;
		}
		String WsdlSpName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90SoapMethodSpecification> WebMethods 
		{
			get;
		}
	}
	public interface ISql90SoapMethodSpecification : ISqlModelElement
	{		
		SoapFormat Format 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		String WebMethodAlias 
		{
			get;
		}
		String WebMethodNamespace 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> RelatedMethod 
		{
			get;
		}
	}
	public interface ISql90SpatialIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90Statistics : ISqlModelElement
	{		
		Boolean NoRecompute 
		{
			get;
		}
		Int32 SampleSize 
		{
			get;
		}
		SamplingStyle SamplingStyle 
		{
			get;
		}
		String StatsStream 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> OnObject 
		{
			get;
		}
	}
	public interface ISql90Parameter : ISqlModelElement
	{		
		String DefaultExpression 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsOutput 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Varying 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql90SymmetricKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		String IdentityValue 
		{
			get;
		}
		String KeySource 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> Certificates 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Passwords 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90SymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql90SymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql90Synonym : ISqlModelElement
	{		
		String ForObjectName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ForObject 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90Table : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		Boolean LargeValueTypesOutOfRow 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		Int32 TextInRowSize 
		{
			get;
		}
		Boolean VardecimalStorageFormatEnabled 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90FileTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90TableType : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90TableTypeCheckConstraint : ISqlModelElement
	{		
	}
	public interface ISql90TableTypeColumn : ISqlModelElement
	{		
		Boolean IsMax 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
	}
	public interface ISql90TableTypeDefaultConstraint : ISqlModelElement
	{		
	}
	public interface ISql90TableTypeIndex : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IsDisabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
	}
	public interface ISql90TableTypePrimaryKeyConstraint : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
	}
	public interface ISql90TableTypeUniqueConstraint : ISqlModelElement
	{		
	}
	public interface ISql90TcpProtocolSpecifier : ISqlModelElement
	{		
		String ListenerIPv4 
		{
			get;
		}
		String ListenerIPv6 
		{
			get;
		}
		Int32 ListenerPort 
		{
			get;
		}
		Boolean ListeningOnAllIPs 
		{
			get;
		}
	}
	public interface ISql90UniqueConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90User : ISqlModelElement
	{		
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Login> Login 
		{
			get;
		}
	}
	public interface ISql90UserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90UserDefinedType : ISqlModelElement
	{		
		Boolean? ByteOrdered 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean? FixedLength 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		String ValidationMethodName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Methods 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Properties 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90View : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		String SelectStatement 
		{
			get;
		}
		Boolean WithCheckOption 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		Boolean WithViewMetadata 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql90WorkloadGroup : ISqlModelElement
	{		
	}
	public interface ISql90XmlIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IsPrimary 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		SecondaryXmlIndexType SecondaryXmlIndexType 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Column> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90XmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql90SelectiveXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISql90XmlNamespace : ISqlModelElement
	{		
	}
	public interface ISql90PromotedNodePathForXQueryType : ISqlModelElement
	{		
	}
	public interface ISql90PromotedNodePathForSqlType : ISqlModelElement
	{		
		Boolean IsMax 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
	}
	public interface ISql90XmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100Column : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsFileStream 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsIdentityNotForReplication 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Sparse 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100TableValuedFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		String ReturnTableVariableName 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100ScalarFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100Aggregate : ISqlModelElement
	{		
		String ClassName 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Boolean? InvariantToDuplicates 
		{
			get;
		}
		Boolean? InvariantToNulls 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		Boolean? NullIfEmpty 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100ApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql100Index : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		String FilterPredicate 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean Unique 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100Assembly : ISqlModelElement
	{		
		AssemblyPermissionSet PermissionSet 
		{
			get;
		}
		Boolean Visible 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql100AssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql100AsymmetricKey : ISqlModelElement
	{		
		AsymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		SymmetricKeyCreationDisposition CreationDisposition 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String ExecutableFile 
		{
			get;
		}
		String File 
		{
			get;
		}
		String Password 
		{
			get;
		}
		String ProviderKeyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Provider 
		{
			get;
		}
	}
	public interface ISql100AuditAction : ISqlModelElement
	{		
		DatabaseAuditAction Action 
		{
			get;
		}
	}
	public interface ISql100AuditActionGroup : ISqlModelElement
	{		
		AuditActionGroupType ActionGroup 
		{
			get;
		}
	}
	public interface ISql100AuditActionSpecification : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Principals 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql100BrokerPriority : ISqlModelElement
	{		
		Int32 PriorityLevel 
		{
			get;
		}
		String RemoteServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ContractName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> LocalServiceName 
		{
			get;
		}
	}
	public interface ISql100BuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql100DataType : ISqlModelElement
	{		
		SqlDataType SqlDataType 
		{
			get;
		}
		Boolean UddtIsMax 
		{
			get;
		}
		Int32 UddtLength 
		{
			get;
		}
		Boolean UddtNullable 
		{
			get;
		}
		Int32 UddtPrecision 
		{
			get;
		}
		Int32 UddtScale 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql100Certificate : ISqlModelElement
	{		
		Boolean ActiveForBeginDialog 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String EncryptionPassword 
		{
			get;
		}
		String ExistingKeysFilePath 
		{
			get;
		}
		String ExpiryDate 
		{
			get;
		}
		Boolean IsExistingKeyFileExecutable 
		{
			get;
		}
		String PrivateKeyDecryptionPassword 
		{
			get;
		}
		String PrivateKeyEncryptionPassword 
		{
			get;
		}
		String PrivateKeyFilePath 
		{
			get;
		}
		String StartDate 
		{
			get;
		}
		String Subject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql100CheckConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql100ClrTypeMethod : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
	}
	public interface ISql100ClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> DataType 
		{
			get;
		}
	}
	public interface ISql100ClrTypeProperty : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ClrType 
		{
			get;
		}
	}
	public interface ISql100ColumnStoreIndex : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100Contract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100MessageType> Messages 
		{
			get;
		}
	}
	public interface ISql100Credential : ISqlModelElement
	{		
		String Identity 
		{
			get;
		}
		String Secret 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100CryptographicProvider> CryptographicProvider 
		{
			get;
		}
	}
	public interface ISql100CryptographicProvider : ISqlModelElement
	{		
		String DllPath 
		{
			get;
		}
		Boolean Enabled 
		{
			get;
		}
	}
	public interface ISql100DatabaseAuditSpecification : ISqlModelElement
	{		
		Boolean WithState 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql100DatabaseDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100DatabaseEncryptionKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql100DatabaseEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql100DatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		DatabaseMirroringRole RoleType 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql100DatabaseOptions : ISqlModelElement
	{		
		Boolean AllowSnapshotIsolation 
		{
			get;
		}
		Boolean AnsiNullDefaultOn 
		{
			get;
		}
		Boolean AnsiNullsOn 
		{
			get;
		}
		Boolean AnsiPaddingOn 
		{
			get;
		}
		Boolean AnsiWarningsOn 
		{
			get;
		}
		Boolean ArithAbortOn 
		{
			get;
		}
		Boolean AutoClose 
		{
			get;
		}
		Boolean AutoCreateStatistics 
		{
			get;
		}
		Boolean AutoShrink 
		{
			get;
		}
		Boolean AutoUpdateStatistics 
		{
			get;
		}
		Boolean AutoUpdateStatisticsAsync 
		{
			get;
		}
		Boolean ChangeTrackingAutoCleanup 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
		{
			get;
		}
		Int32 ChangeTrackingRetentionPeriod 
		{
			get;
		}
		TimeUnit ChangeTrackingRetentionUnit 
		{
			get;
		}
		String Collation 
		{
			get;
		}
		Int32 CompatibilityLevel 
		{
			get;
		}
		Boolean ConcatNullYieldsNull 
		{
			get;
		}
		Boolean CursorCloseOnCommit 
		{
			get;
		}
		Boolean CursorDefaultGlobalScope 
		{
			get;
		}
		Boolean DatabaseStateOffline 
		{
			get;
		}
		Boolean DateCorrelationOptimizationOn 
		{
			get;
		}
		Boolean DBChainingOn 
		{
			get;
		}
		Boolean FullTextEnabled 
		{
			get;
		}
		Boolean HonorBrokerPriority 
		{
			get;
		}
		Boolean MemoryOptimizedElevateToSnapshot 
		{
			get;
		}
		Boolean NumericRoundAbortOn 
		{
			get;
		}
		PageVerifyMode PageVerifyMode 
		{
			get;
		}
		ParameterizationOption ParameterizationOption 
		{
			get;
		}
		Boolean QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		RecoveryMode RecoveryMode 
		{
			get;
		}
		Boolean RecursiveTriggersOn 
		{
			get;
		}
		ServiceBrokerOption ServiceBrokerOption 
		{
			get;
		}
		Boolean SupplementalLoggingOn 
		{
			get;
		}
		Boolean TornPageProtectionOn 
		{
			get;
		}
		Boolean TransactionIsolationReadCommittedSnapshot 
		{
			get;
		}
		Boolean Trustworthy 
		{
			get;
		}
		UserAccessOption UserAccessOption 
		{
			get;
		}
		Boolean VardecimalStorageFormatOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> DefaultFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> DefaultFileStreamFilegroup 
		{
			get;
		}
	}
	public interface ISql100DataCompressionOption : ISqlModelElement
	{		
		CompressionLevel CompressionLevel 
		{
			get;
		}
		Int32 PartitionNumber 
		{
			get;
		}
	}
	public interface ISql100Default : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100DefaultConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean WithValues 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql100DmlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		OrderRestriction DeleteOrderRestriction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		OrderRestriction InsertOrderRestriction 
		{
			get;
		}
		Boolean IsDeleteTrigger 
		{
			get;
		}
		Boolean IsInsertTrigger 
		{
			get;
		}
		Boolean IsUpdateTrigger 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		OrderRestriction UpdateOrderRestriction 
		{
			get;
		}
		Boolean WithAppend 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100Endpoint : ISqlModelElement
	{		
		Payload Payload 
		{
			get;
		}
		Protocol Protocol 
		{
			get;
		}
		State State 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> PayloadSpecifier 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ProtocolSpecifier 
		{
			get;
		}
	}
	public interface ISql100ErrorMessage : ISqlModelElement
	{		
		String Language 
		{
			get;
		}
		Int32 MessageNumber 
		{
			get;
		}
		String MessageText 
		{
			get;
		}
		Int32 Severity 
		{
			get;
		}
		Boolean WithLog 
		{
			get;
		}
	}
	public interface ISql100EventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql100EventSession : ISqlModelElement
	{		
		EventRetentionMode EventRetentionMode 
		{
			get;
		}
		Int32 MaxDispatchLatency 
		{
			get;
		}
		Int32 MaxEventSize 
		{
			get;
		}
		MemoryUnit MaxEventSizeUnit 
		{
			get;
		}
		Int32 MaxMemory 
		{
			get;
		}
		MemoryUnit MaxMemoryUnit 
		{
			get;
		}
		MemoryPartitionMode MemoryPartitionMode 
		{
			get;
		}
		Boolean StartupState 
		{
			get;
		}
		Boolean TrackCausality 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EventDefinitions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EventTargets 
		{
			get;
		}
	}
	public interface ISql100EventSessionAction : ISqlModelElement
	{		
		String ActionName 
		{
			get;
		}
		String EventModuleGuid 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
	}
	public interface ISql100EventSessionDefinitions : ISqlModelElement
	{		
		String EventModuleGuid 
		{
			get;
		}
		String EventName 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
		String WhereExpression 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventSessionAction> Actions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> AttributeSettings 
		{
			get;
		}
	}
	public interface ISql100EventSessionSetting : ISqlModelElement
	{		
		String SettingName 
		{
			get;
		}
		String SettingValue 
		{
			get;
		}
	}
	public interface ISql100EventSessionTarget : ISqlModelElement
	{		
		String EventModuleGuid 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
		String TargetName 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> ParameterSettings 
		{
			get;
		}
	}
	public interface ISql100EventTypeSpecifier : ISqlModelElement
	{		
		EventType EventType 
		{
			get;
		}
		OrderRestriction Order 
		{
			get;
		}
	}
	public interface ISql100ExtendedProcedure : ISqlModelElement
	{		
		Boolean ExeccuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100ExtendedProperty : ISqlModelElement
	{		
		String Value 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> Host 
		{
			get;
		}
	}
	public interface ISql100SqlFile : ISqlModelElement
	{		
		Int32? FileGrowth 
		{
			get;
		}
		MemoryUnit FileGrowthUnit 
		{
			get;
		}
		String FileName 
		{
			get;
		}
		Boolean IsLogFile 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		Boolean Offline 
		{
			get;
		}
		Int32? Size 
		{
			get;
		}
		MemoryUnit SizeUnit 
		{
			get;
		}
		Boolean Unlimited 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql100Filegroup : ISqlModelElement
	{		
		Boolean ContainsFileStream 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
	}
	public interface ISql100ForeignKeyConstraint : ISqlModelElement
	{		
		ForeignKeyAction DeleteAction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		ForeignKeyAction UpdateAction 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Table> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql100FullTextCatalog : ISqlModelElement
	{		
		Boolean? AccentSensitivity 
		{
			get;
		}
		Boolean IsDefault 
		{
			get;
		}
		String Path 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql100FullTextIndex : ISqlModelElement
	{		
		ChangeTrackingOption ChangeTracking 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		Boolean StopListOff 
		{
			get;
		}
		Boolean UseSystemStopList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Catalog 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> StopList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> UniqueIndexName 
		{
			get;
		}
	}
	public interface ISql100FullTextIndexColumnSpecifier : ISqlModelElement
	{		
		Int32? LanguageId 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> TypeColumn 
		{
			get;
		}
	}
	public interface ISql100FullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100HttpProtocolSpecifier : ISqlModelElement
	{		
		AuthenticationModes AuthenticationMode 
		{
			get;
		}
		String AuthenticationRealm 
		{
			get;
		}
		Int32? ClearPort 
		{
			get;
		}
		Boolean CompressionEnabled 
		{
			get;
		}
		String DefaultLogonDomain 
		{
			get;
		}
		Boolean ListeningOnAllNoneReservedSites 
		{
			get;
		}
		Boolean ListeningOnAllSites 
		{
			get;
		}
		String Path 
		{
			get;
		}
		HttpPorts Ports 
		{
			get;
		}
		Int32? SslPort 
		{
			get;
		}
		String Website 
		{
			get;
		}
	}
	public interface ISql100LinkedServer : ISqlModelElement
	{		
		String Catalog 
		{
			get;
		}
		Boolean CollationCompatible 
		{
			get;
		}
		String CollationName 
		{
			get;
		}
		Int32 ConnectTimeout 
		{
			get;
		}
		Boolean DataAccess 
		{
			get;
		}
		String DataSource 
		{
			get;
		}
		Boolean IsDistributor 
		{
			get;
		}
		Boolean IsPublisher 
		{
			get;
		}
		Boolean IsSubscriber 
		{
			get;
		}
		Boolean LazySchemaValidationEnabled 
		{
			get;
		}
		String Location 
		{
			get;
		}
		String ProductName 
		{
			get;
		}
		String ProviderName 
		{
			get;
		}
		String ProviderString 
		{
			get;
		}
		Int32 QueryTimeout 
		{
			get;
		}
		Boolean RemoteProcTransactionPromotionEnabled 
		{
			get;
		}
		Boolean RpcEnabled 
		{
			get;
		}
		Boolean RpcOutEnabled 
		{
			get;
		}
		Boolean UseRemoteCollation 
		{
			get;
		}
	}
	public interface ISql100LinkedServerLogin : ISqlModelElement
	{		
		String LinkedServerLoginName 
		{
			get;
		}
		String LinkedServerPassword 
		{
			get;
		}
		Boolean UseSelf 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100LinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> LocalLogin 
		{
			get;
		}
	}
	public interface ISql100Login : ISqlModelElement
	{		
		Boolean CheckExpiration 
		{
			get;
		}
		Boolean CheckPolicy 
		{
			get;
		}
		String DefaultDatabase 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		LoginEncryptionOption EncryptionOption 
		{
			get;
		}
		Boolean MappedToWindowsLogin 
		{
			get;
		}
		String Password 
		{
			get;
		}
		Boolean PasswordHashed 
		{
			get;
		}
		Boolean PasswordMustChange 
		{
			get;
		}
		String Sid 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Credential> Credential 
		{
			get;
		}
	}
	public interface ISql100MasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql100MessageType : ISqlModelElement
	{		
		ValidationMethod ValidationMethod 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100PartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ParameterType 
		{
			get;
		}
	}
	public interface ISql100PartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql100PartitionValue : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql100Permission : ISqlModelElement
	{		
		PermissionAction PermissionAction 
		{
			get;
		}
		PermissionType PermissionType 
		{
			get;
		}
		Boolean WithAllPrivileges 
		{
			get;
		}
		Boolean WithGrantOption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> ExcludedColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantee 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantor 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql100PrimaryKeyConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100Procedure : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean ForReplication 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithRecompile 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Procedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100Queue : ISqlModelElement
	{		
		Boolean ActivationExecuteAsCaller 
		{
			get;
		}
		Boolean ActivationExecuteAsOwner 
		{
			get;
		}
		Boolean ActivationExecuteAsSelf 
		{
			get;
		}
		Int32? ActivationMaxQueueReaders 
		{
			get;
		}
		Boolean? ActivationStatusOn 
		{
			get;
		}
		Boolean PoisonMessageHandlingStatusOn 
		{
			get;
		}
		Boolean RetentionOn 
		{
			get;
		}
		Boolean StatusOn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Procedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100QueueEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Queue> Queue 
		{
			get;
		}
	}
	public interface ISql100RemoteServiceBinding : ISqlModelElement
	{		
		Boolean Anonymous 
		{
			get;
		}
		String Service 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100ResourceGovernor : ISqlModelElement
	{		
		Boolean? Enabled 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ClassifierFunction 
		{
			get;
		}
	}
	public interface ISql100ResourcePool : ISqlModelElement
	{		
		Int32 MaxCpuPercent 
		{
			get;
		}
		Int32 MaxMemoryPercent 
		{
			get;
		}
		Int32 MinCpuPercent 
		{
			get;
		}
		Int32 MinMemoryPercent 
		{
			get;
		}
	}
	public interface ISql100Role : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100RoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Role> Role 
		{
			get;
		}
	}
	public interface ISql100Route : ISqlModelElement
	{		
		String Address 
		{
			get;
		}
		String BrokerInstance 
		{
			get;
		}
		Int32? Lifetime 
		{
			get;
		}
		String MirrorAddress 
		{
			get;
		}
		String ServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100Rule : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100Schema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100SearchProperty : ISqlModelElement
	{		
	}
	public interface ISql100SearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100Sequence : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100ServerAudit : ISqlModelElement
	{		
		String AuditGuid 
		{
			get;
		}
		AuditTarget AuditTarget 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		String FilePath 
		{
			get;
		}
		Int32? MaxRolloverFiles 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		FailureAction OnFailure 
		{
			get;
		}
		Int32 QueueDelay 
		{
			get;
		}
		Boolean ReserveDiskSpace 
		{
			get;
		}
		Boolean UnlimitedFileSize 
		{
			get;
		}
		Boolean UnlimitedMaxRolloverFiles 
		{
			get;
		}
	}
	public interface ISql100ServerAuditSpecification : ISqlModelElement
	{		
		Boolean StateOn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql100ServerDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean IsLogon 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100User> User 
		{
			get;
		}
	}
	public interface ISql100ServerEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql100ServerOptions : ISqlModelElement
	{		
	}
	public interface ISql100ServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Role> Role 
		{
			get;
		}
	}
	public interface ISql100Service : ISqlModelElement
	{		
		Boolean UseDefaultContract 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Contract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Queue> Queue 
		{
			get;
		}
	}
	public interface ISql100ServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		Boolean MessageForwardingEnabled 
		{
			get;
		}
		Int32 MessageForwardSize 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql100Signature : ISqlModelElement
	{		
		Boolean IsCounterSignature 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EncryptionMechanism 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> SignedObject 
		{
			get;
		}
	}
	public interface ISql100SignatureEncryptionMechanism : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		String SignedBlob 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql100SoapLanguageSpecifier : ISqlModelElement
	{		
		Boolean BatchesEnabled 
		{
			get;
		}
		CharacterSet CharacterSet 
		{
			get;
		}
		String DatabaseName 
		{
			get;
		}
		Int32 HeaderLimit 
		{
			get;
		}
		Boolean IsDefaultDatabase 
		{
			get;
		}
		Boolean IsDefaultNamespace 
		{
			get;
		}
		Boolean IsDefaultWsdlSpName 
		{
			get;
		}
		SoapLoginType LoginType 
		{
			get;
		}
		String Namespace 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		Boolean SessionsEnabled 
		{
			get;
		}
		Int32 SessionTimeout 
		{
			get;
		}
		Boolean SessionTimeoutNever 
		{
			get;
		}
		String WsdlSpName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100SoapMethodSpecification> WebMethods 
		{
			get;
		}
	}
	public interface ISql100SoapMethodSpecification : ISqlModelElement
	{		
		SoapFormat Format 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		String WebMethodAlias 
		{
			get;
		}
		String WebMethodNamespace 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> RelatedMethod 
		{
			get;
		}
	}
	public interface ISql100SpatialIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? CellsPerObject 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32 FillFactor 
		{
			get;
		}
		Degree GridLevel1Density 
		{
			get;
		}
		Degree GridLevel2Density 
		{
			get;
		}
		Degree GridLevel3Density 
		{
			get;
		}
		Degree GridLevel4Density 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Tessellation Tessellation 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		Double? XMax 
		{
			get;
		}
		Double? XMin 
		{
			get;
		}
		Double? YMax 
		{
			get;
		}
		Double? YMin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100Statistics : ISqlModelElement
	{		
		String FilterPredicate 
		{
			get;
		}
		Boolean NoRecompute 
		{
			get;
		}
		Int32 SampleSize 
		{
			get;
		}
		SamplingStyle SamplingStyle 
		{
			get;
		}
		String StatsStream 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> OnObject 
		{
			get;
		}
	}
	public interface ISql100Parameter : ISqlModelElement
	{		
		String DefaultExpression 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsOutput 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Varying 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100SymmetricKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		SymmetricKeyCreationDisposition CreationDisposition 
		{
			get;
		}
		String IdentityValue 
		{
			get;
		}
		String KeySource 
		{
			get;
		}
		String ProviderKeyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> Certificates 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Passwords 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Provider 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100SymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql100SymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql100Synonym : ISqlModelElement
	{		
		String ForObjectName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ForObject 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100Table : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean ChangeDataCaptureEnabled 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		Boolean LargeValueTypesOutOfRow 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		Int32 TextInRowSize 
		{
			get;
		}
		Boolean TrackColumnsUpdated 
		{
			get;
		}
		Boolean VardecimalStorageFormatEnabled 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100FileTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100TableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100TableTypeCheckConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql100TableTypeColumn : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100TableTypeDefaultConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql100TableTypeIndex : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IsDisabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
	}
	public interface ISql100TableTypePrimaryKeyConstraint : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
	}
	public interface ISql100TableTypeUniqueConstraint : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
	}
	public interface ISql100TcpProtocolSpecifier : ISqlModelElement
	{		
		String ListenerIPv4 
		{
			get;
		}
		String ListenerIPv6 
		{
			get;
		}
		Int32 ListenerPort 
		{
			get;
		}
		Boolean ListeningOnAllIPs 
		{
			get;
		}
	}
	public interface ISql100UniqueConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100User : ISqlModelElement
	{		
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Login> Login 
		{
			get;
		}
	}
	public interface ISql100UserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100UserDefinedType : ISqlModelElement
	{		
		Boolean? ByteOrdered 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean? FixedLength 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		String ValidationMethodName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Methods 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Properties 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100View : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		String SelectStatement 
		{
			get;
		}
		Boolean WithCheckOption 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		Boolean WithViewMetadata 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISql100WorkloadGroup : ISqlModelElement
	{		
		Int32 GroupMaxRequests 
		{
			get;
		}
		Degree Importance 
		{
			get;
		}
		Int32 MaxDop 
		{
			get;
		}
		Int32 RequestMaxCpuTimeSec 
		{
			get;
		}
		Int32 RequestMaxMemoryGrantPercent 
		{
			get;
		}
		Int32 RequestMemoryGrantTimeoutSec 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100ResourcePool> ResourcePool 
		{
			get;
		}
	}
	public interface ISql100XmlIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean IsPrimary 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		SecondaryXmlIndexType SecondaryXmlIndexType 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Column> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100XmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql100SelectiveXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISql100XmlNamespace : ISqlModelElement
	{		
	}
	public interface ISql100PromotedNodePathForXQueryType : ISqlModelElement
	{		
	}
	public interface ISql100PromotedNodePathForSqlType : ISqlModelElement
	{		
		Boolean IsMax 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
	}
	public interface ISql100XmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100Schema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureColumn : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Sparse 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureTableValuedFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		String ReturnTableVariableName 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureScalarFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureAggregate : ISqlModelElement
	{		
		String ClassName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureApplicationRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISqlAzureIndex : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		String FilterPredicate 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean Unique 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
	}
	public interface ISqlAzureAssembly : ISqlModelElement
	{		
		AssemblyPermissionSet PermissionSet 
		{
			get;
		}
		Boolean Visible 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISqlAzureAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISqlAzureAsymmetricKey : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureAuditAction : ISqlModelElement
	{		
	}
	public interface ISqlAzureAuditActionGroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureAuditActionSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureBrokerPriority : ISqlModelElement
	{		
	}
	public interface ISqlAzureBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISqlAzureDataType : ISqlModelElement
	{		
		SqlDataType SqlDataType 
		{
			get;
		}
		Boolean UddtIsMax 
		{
			get;
		}
		Int32 UddtLength 
		{
			get;
		}
		Boolean UddtNullable 
		{
			get;
		}
		Int32 UddtPrecision 
		{
			get;
		}
		Int32 UddtScale 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISqlAzureCertificate : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureCheckConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISqlAzureClrTypeMethod : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
	}
	public interface ISqlAzureClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> DataType 
		{
			get;
		}
	}
	public interface ISqlAzureClrTypeProperty : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ClrType 
		{
			get;
		}
	}
	public interface ISqlAzureColumnStoreIndex : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
	}
	public interface ISqlAzureContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureCredential : ISqlModelElement
	{		
	}
	public interface ISqlAzureCryptographicProvider : ISqlModelElement
	{		
	}
	public interface ISqlAzureDatabaseAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureDatabaseDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureDatabaseEncryptionKey : ISqlModelElement
	{		
	}
	public interface ISqlAzureDatabaseEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureDatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureDatabaseOptions : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
	}
	public interface ISqlAzureDataCompressionOption : ISqlModelElement
	{		
	}
	public interface ISqlAzureDefault : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureDefaultConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean WithValues 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISqlAzureDmlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		OrderRestriction DeleteOrderRestriction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		OrderRestriction InsertOrderRestriction 
		{
			get;
		}
		Boolean IsDeleteTrigger 
		{
			get;
		}
		Boolean IsInsertTrigger 
		{
			get;
		}
		Boolean IsUpdateTrigger 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		OrderRestriction UpdateOrderRestriction 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureEndpoint : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureErrorMessage : ISqlModelElement
	{		
	}
	public interface ISqlAzureEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISqlAzureEventSession : ISqlModelElement
	{		
	}
	public interface ISqlAzureEventSessionAction : ISqlModelElement
	{		
	}
	public interface ISqlAzureEventSessionDefinitions : ISqlModelElement
	{		
	}
	public interface ISqlAzureEventSessionSetting : ISqlModelElement
	{		
	}
	public interface ISqlAzureEventSessionTarget : ISqlModelElement
	{		
	}
	public interface ISqlAzureEventTypeSpecifier : ISqlModelElement
	{		
		EventType EventType 
		{
			get;
		}
		OrderRestriction Order 
		{
			get;
		}
	}
	public interface ISqlAzureExtendedProcedure : ISqlModelElement
	{		
		Boolean ExeccuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureExtendedProperty : ISqlModelElement
	{		
	}
	public interface ISqlAzureSqlFile : ISqlModelElement
	{		
	}
	public interface ISqlAzureFilegroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureForeignKeyConstraint : ISqlModelElement
	{		
		ForeignKeyAction DeleteAction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		ForeignKeyAction UpdateAction 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISqlAzureFullTextCatalog : ISqlModelElement
	{		
		Boolean? AccentSensitivity 
		{
			get;
		}
		Boolean IsDefault 
		{
			get;
		}
		String Path 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISqlAzureFullTextIndex : ISqlModelElement
	{		
	}
	public interface ISqlAzureFullTextIndexColumnSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureHttpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureLinkedServer : ISqlModelElement
	{		
	}
	public interface ISqlAzureLinkedServerLogin : ISqlModelElement
	{		
	}
	public interface ISqlAzureLogin : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Password 
		{
			get;
		}
	}
	public interface ISqlAzureMasterKey : ISqlModelElement
	{		
	}
	public interface ISqlAzureMessageType : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzurePartitionFunction : ISqlModelElement
	{		
	}
	public interface ISqlAzurePartitionScheme : ISqlModelElement
	{		
	}
	public interface ISqlAzurePartitionValue : ISqlModelElement
	{		
	}
	public interface ISqlAzurePermission : ISqlModelElement
	{		
		PermissionAction PermissionAction 
		{
			get;
		}
		PermissionType PermissionType 
		{
			get;
		}
		Boolean WithAllPrivileges 
		{
			get;
		}
		Boolean WithGrantOption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> ExcludedColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantee 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantor 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISqlAzurePrimaryKeyConstraint : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISqlAzureProcedure : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean WithRecompile 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureQueue : ISqlModelElement
	{		
		Boolean ActivationExecuteAsCaller 
		{
			get;
		}
		Boolean ActivationExecuteAsOwner 
		{
			get;
		}
		Boolean ActivationExecuteAsSelf 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureQueueEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureRemoteServiceBinding : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureResourceGovernor : ISqlModelElement
	{		
	}
	public interface ISqlAzureResourcePool : ISqlModelElement
	{		
	}
	public interface ISqlAzureRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureRole> Role 
		{
			get;
		}
	}
	public interface ISqlAzureRoute : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureRule : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureSearchProperty : ISqlModelElement
	{		
	}
	public interface ISqlAzureSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureSequence : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureServerAudit : ISqlModelElement
	{		
	}
	public interface ISqlAzureServerAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureServerDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureServerEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureServerOptions : ISqlModelElement
	{		
	}
	public interface ISqlAzureServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureRole> Role 
		{
			get;
		}
	}
	public interface ISqlAzureService : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureSignature : ISqlModelElement
	{		
	}
	public interface ISqlAzureSignatureEncryptionMechanism : ISqlModelElement
	{		
	}
	public interface ISqlAzureSoapLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureSoapMethodSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureSpatialIndex : ISqlModelElement
	{		
		Int32? CellsPerObject 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Degree GridLevel1Density 
		{
			get;
		}
		Degree GridLevel2Density 
		{
			get;
		}
		Degree GridLevel3Density 
		{
			get;
		}
		Degree GridLevel4Density 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Tessellation Tessellation 
		{
			get;
		}
		Double? XMax 
		{
			get;
		}
		Double? XMin 
		{
			get;
		}
		Double? YMax 
		{
			get;
		}
		Double? YMin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
	}
	public interface ISqlAzureStatistics : ISqlModelElement
	{		
		String FilterPredicate 
		{
			get;
		}
		Boolean NoRecompute 
		{
			get;
		}
		Int32 SampleSize 
		{
			get;
		}
		SamplingStyle SamplingStyle 
		{
			get;
		}
		String StatsStream 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> OnObject 
		{
			get;
		}
	}
	public interface ISqlAzureParameter : ISqlModelElement
	{		
		String DefaultExpression 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsOutput 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Varying 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureSymmetricKey : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureSymmetricKeyPassword : ISqlModelElement
	{		
	}
	public interface ISqlAzureSynonym : ISqlModelElement
	{		
		String ForObjectName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ForObject 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean LargeValueTypesOutOfRow 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		Int32 TextInRowSize 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureFileTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTableTypeCheckConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISqlAzureTableTypeColumn : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureTableTypeDefaultConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISqlAzureTableTypeIndex : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IsDisabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureTableTypePrimaryKeyConstraint : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureTableTypeUniqueConstraint : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureTcpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureUniqueConstraint : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISqlAzureUser : ISqlModelElement
	{		
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureLogin> Login 
		{
			get;
		}
	}
	public interface ISqlAzureUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureUserDefinedType : ISqlModelElement
	{		
		Boolean? ByteOrdered 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean? FixedLength 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		String ValidationMethodName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Methods 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Properties 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureView : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		String SelectStatement 
		{
			get;
		}
		Boolean WithCheckOption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		Boolean WithViewMetadata 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureWorkloadGroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISqlAzureSelectiveXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISqlAzureXmlNamespace : ISqlModelElement
	{		
	}
	public interface ISqlAzurePromotedNodePathForXQueryType : ISqlModelElement
	{		
	}
	public interface ISqlAzurePromotedNodePathForSqlType : ISqlModelElement
	{		
		Boolean IsMax 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
	}
	public interface ISqlAzureXmlSchemaCollection : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110Column : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsFileStream 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsIdentityNotForReplication 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Sparse 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110TableValuedFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		String ReturnTableVariableName 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110ScalarFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110Aggregate : ISqlModelElement
	{		
		String ClassName 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Boolean? InvariantToDuplicates 
		{
			get;
		}
		Boolean? InvariantToNulls 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		Boolean? NullIfEmpty 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110ApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql110Index : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		String FilterPredicate 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean Unique 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110Assembly : ISqlModelElement
	{		
		AssemblyPermissionSet PermissionSet 
		{
			get;
		}
		Boolean Visible 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql110AssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql110AsymmetricKey : ISqlModelElement
	{		
		AsymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		SymmetricKeyCreationDisposition CreationDisposition 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String ExecutableFile 
		{
			get;
		}
		String File 
		{
			get;
		}
		String Password 
		{
			get;
		}
		String ProviderKeyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Provider 
		{
			get;
		}
	}
	public interface ISql110AuditAction : ISqlModelElement
	{		
		DatabaseAuditAction Action 
		{
			get;
		}
	}
	public interface ISql110AuditActionGroup : ISqlModelElement
	{		
		AuditActionGroupType ActionGroup 
		{
			get;
		}
	}
	public interface ISql110AuditActionSpecification : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Principals 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql110BrokerPriority : ISqlModelElement
	{		
		Int32 PriorityLevel 
		{
			get;
		}
		String RemoteServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ContractName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> LocalServiceName 
		{
			get;
		}
	}
	public interface ISql110BuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql110DataType : ISqlModelElement
	{		
		SqlDataType SqlDataType 
		{
			get;
		}
		Boolean UddtIsMax 
		{
			get;
		}
		Int32 UddtLength 
		{
			get;
		}
		Boolean UddtNullable 
		{
			get;
		}
		Int32 UddtPrecision 
		{
			get;
		}
		Int32 UddtScale 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql110Certificate : ISqlModelElement
	{		
		Boolean ActiveForBeginDialog 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String EncryptionPassword 
		{
			get;
		}
		String ExistingKeysFilePath 
		{
			get;
		}
		String ExpiryDate 
		{
			get;
		}
		Boolean IsExistingKeyFileExecutable 
		{
			get;
		}
		String PrivateKeyDecryptionPassword 
		{
			get;
		}
		String PrivateKeyEncryptionPassword 
		{
			get;
		}
		String PrivateKeyFilePath 
		{
			get;
		}
		String StartDate 
		{
			get;
		}
		String Subject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql110CheckConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql110ClrTypeMethod : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
	}
	public interface ISql110ClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> DataType 
		{
			get;
		}
	}
	public interface ISql110ClrTypeProperty : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ClrType 
		{
			get;
		}
	}
	public interface ISql110ColumnStoreIndex : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110Contract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110MessageType> Messages 
		{
			get;
		}
	}
	public interface ISql110Credential : ISqlModelElement
	{		
		String Identity 
		{
			get;
		}
		String Secret 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110CryptographicProvider> CryptographicProvider 
		{
			get;
		}
	}
	public interface ISql110CryptographicProvider : ISqlModelElement
	{		
		String DllPath 
		{
			get;
		}
		Boolean Enabled 
		{
			get;
		}
	}
	public interface ISql110DatabaseAuditSpecification : ISqlModelElement
	{		
		Boolean WithState 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql110DatabaseDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110DatabaseEncryptionKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql110DatabaseEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql110DatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		DatabaseMirroringRole RoleType 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql110DatabaseOptions : ISqlModelElement
	{		
		Boolean AllowSnapshotIsolation 
		{
			get;
		}
		Boolean AnsiNullDefaultOn 
		{
			get;
		}
		Boolean AnsiNullsOn 
		{
			get;
		}
		Boolean AnsiPaddingOn 
		{
			get;
		}
		Boolean AnsiWarningsOn 
		{
			get;
		}
		Boolean ArithAbortOn 
		{
			get;
		}
		Boolean AutoClose 
		{
			get;
		}
		Boolean AutoCreateStatistics 
		{
			get;
		}
		Boolean AutoShrink 
		{
			get;
		}
		Boolean AutoUpdateStatistics 
		{
			get;
		}
		Boolean AutoUpdateStatisticsAsync 
		{
			get;
		}
		Boolean ChangeTrackingAutoCleanup 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
		{
			get;
		}
		Int32 ChangeTrackingRetentionPeriod 
		{
			get;
		}
		TimeUnit ChangeTrackingRetentionUnit 
		{
			get;
		}
		String Collation 
		{
			get;
		}
		Int32 CompatibilityLevel 
		{
			get;
		}
		Boolean ConcatNullYieldsNull 
		{
			get;
		}
		Containment Containment 
		{
			get;
		}
		Boolean CursorCloseOnCommit 
		{
			get;
		}
		Boolean CursorDefaultGlobalScope 
		{
			get;
		}
		Boolean DatabaseStateOffline 
		{
			get;
		}
		Boolean DateCorrelationOptimizationOn 
		{
			get;
		}
		Boolean DBChainingOn 
		{
			get;
		}
		String DefaultFullTextLanguage 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		String FileStreamDirectoryName 
		{
			get;
		}
		Boolean FullTextEnabled 
		{
			get;
		}
		Boolean HonorBrokerPriority 
		{
			get;
		}
		Boolean MemoryOptimizedElevateToSnapshot 
		{
			get;
		}
		Boolean NestedTriggersOn 
		{
			get;
		}
		NonTransactedFileStreamAccess NonTransactedFileStreamAccess 
		{
			get;
		}
		Boolean NumericRoundAbortOn 
		{
			get;
		}
		PageVerifyMode PageVerifyMode 
		{
			get;
		}
		ParameterizationOption ParameterizationOption 
		{
			get;
		}
		Boolean QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		RecoveryMode RecoveryMode 
		{
			get;
		}
		Boolean RecursiveTriggersOn 
		{
			get;
		}
		ServiceBrokerOption ServiceBrokerOption 
		{
			get;
		}
		Boolean SupplementalLoggingOn 
		{
			get;
		}
		Int32 TargetRecoveryTimePeriod 
		{
			get;
		}
		TimeUnit TargetRecoveryTimeUnit 
		{
			get;
		}
		Boolean TornPageProtectionOn 
		{
			get;
		}
		Boolean TransactionIsolationReadCommittedSnapshot 
		{
			get;
		}
		Boolean TransformNoiseWords 
		{
			get;
		}
		Boolean Trustworthy 
		{
			get;
		}
		Int16 TwoDigitYearCutoff 
		{
			get;
		}
		UserAccessOption UserAccessOption 
		{
			get;
		}
		Boolean VardecimalStorageFormatOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> DefaultFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> DefaultFileStreamFilegroup 
		{
			get;
		}
	}
	public interface ISql110DataCompressionOption : ISqlModelElement
	{		
		CompressionLevel CompressionLevel 
		{
			get;
		}
		Int32 PartitionNumber 
		{
			get;
		}
	}
	public interface ISql110Default : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110DefaultConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean WithValues 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql110DmlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		OrderRestriction DeleteOrderRestriction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		OrderRestriction InsertOrderRestriction 
		{
			get;
		}
		Boolean IsDeleteTrigger 
		{
			get;
		}
		Boolean IsInsertTrigger 
		{
			get;
		}
		Boolean IsUpdateTrigger 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		OrderRestriction UpdateOrderRestriction 
		{
			get;
		}
		Boolean WithAppend 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110Endpoint : ISqlModelElement
	{		
		Payload Payload 
		{
			get;
		}
		Protocol Protocol 
		{
			get;
		}
		State State 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> PayloadSpecifier 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ProtocolSpecifier 
		{
			get;
		}
	}
	public interface ISql110ErrorMessage : ISqlModelElement
	{		
		String Language 
		{
			get;
		}
		Int32 MessageNumber 
		{
			get;
		}
		String MessageText 
		{
			get;
		}
		Int32 Severity 
		{
			get;
		}
		Boolean WithLog 
		{
			get;
		}
	}
	public interface ISql110EventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql110EventSession : ISqlModelElement
	{		
		EventRetentionMode EventRetentionMode 
		{
			get;
		}
		Int32 MaxDispatchLatency 
		{
			get;
		}
		Int32 MaxEventSize 
		{
			get;
		}
		MemoryUnit MaxEventSizeUnit 
		{
			get;
		}
		Int32 MaxMemory 
		{
			get;
		}
		MemoryUnit MaxMemoryUnit 
		{
			get;
		}
		MemoryPartitionMode MemoryPartitionMode 
		{
			get;
		}
		Boolean StartupState 
		{
			get;
		}
		Boolean TrackCausality 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EventDefinitions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EventTargets 
		{
			get;
		}
	}
	public interface ISql110EventSessionAction : ISqlModelElement
	{		
		String ActionName 
		{
			get;
		}
		String EventModuleGuid 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
	}
	public interface ISql110EventSessionDefinitions : ISqlModelElement
	{		
		String EventModuleGuid 
		{
			get;
		}
		String EventName 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
		String WhereExpression 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventSessionAction> Actions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> AttributeSettings 
		{
			get;
		}
	}
	public interface ISql110EventSessionSetting : ISqlModelElement
	{		
		String SettingName 
		{
			get;
		}
		String SettingValue 
		{
			get;
		}
	}
	public interface ISql110EventSessionTarget : ISqlModelElement
	{		
		String EventModuleGuid 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
		String TargetName 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> ParameterSettings 
		{
			get;
		}
	}
	public interface ISql110EventTypeSpecifier : ISqlModelElement
	{		
		EventType EventType 
		{
			get;
		}
		OrderRestriction Order 
		{
			get;
		}
	}
	public interface ISql110ExtendedProcedure : ISqlModelElement
	{		
		Boolean ExeccuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110ExtendedProperty : ISqlModelElement
	{		
		String Value 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> Host 
		{
			get;
		}
	}
	public interface ISql110SqlFile : ISqlModelElement
	{		
		Int32? FileGrowth 
		{
			get;
		}
		MemoryUnit FileGrowthUnit 
		{
			get;
		}
		String FileName 
		{
			get;
		}
		Boolean IsLogFile 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		Boolean Offline 
		{
			get;
		}
		Int32? Size 
		{
			get;
		}
		MemoryUnit SizeUnit 
		{
			get;
		}
		Boolean Unlimited 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql110Filegroup : ISqlModelElement
	{		
		Boolean ContainsFileStream 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
	}
	public interface ISql110ForeignKeyConstraint : ISqlModelElement
	{		
		ForeignKeyAction DeleteAction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		ForeignKeyAction UpdateAction 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Table> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql110FullTextCatalog : ISqlModelElement
	{		
		Boolean? AccentSensitivity 
		{
			get;
		}
		Boolean IsDefault 
		{
			get;
		}
		String Path 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql110FullTextIndex : ISqlModelElement
	{		
		ChangeTrackingOption ChangeTracking 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		Boolean StopListOff 
		{
			get;
		}
		Boolean UseSystemStopList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Catalog 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SearchPropertyList> SearchPropertyList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> StopList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> UniqueIndexName 
		{
			get;
		}
	}
	public interface ISql110FullTextIndexColumnSpecifier : ISqlModelElement
	{		
		Int32? LanguageId 
		{
			get;
		}
		Boolean PartOfStatisticalSemantics 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> TypeColumn 
		{
			get;
		}
	}
	public interface ISql110FullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110HttpProtocolSpecifier : ISqlModelElement
	{		
		AuthenticationModes AuthenticationMode 
		{
			get;
		}
		String AuthenticationRealm 
		{
			get;
		}
		Int32? ClearPort 
		{
			get;
		}
		Boolean CompressionEnabled 
		{
			get;
		}
		String DefaultLogonDomain 
		{
			get;
		}
		Boolean ListeningOnAllNoneReservedSites 
		{
			get;
		}
		Boolean ListeningOnAllSites 
		{
			get;
		}
		String Path 
		{
			get;
		}
		HttpPorts Ports 
		{
			get;
		}
		Int32? SslPort 
		{
			get;
		}
		String Website 
		{
			get;
		}
	}
	public interface ISql110LinkedServer : ISqlModelElement
	{		
		String Catalog 
		{
			get;
		}
		Boolean CollationCompatible 
		{
			get;
		}
		String CollationName 
		{
			get;
		}
		Int32 ConnectTimeout 
		{
			get;
		}
		Boolean DataAccess 
		{
			get;
		}
		String DataSource 
		{
			get;
		}
		Boolean IsDistributor 
		{
			get;
		}
		Boolean IsPublisher 
		{
			get;
		}
		Boolean IsSubscriber 
		{
			get;
		}
		Boolean LazySchemaValidationEnabled 
		{
			get;
		}
		String Location 
		{
			get;
		}
		String ProductName 
		{
			get;
		}
		String ProviderName 
		{
			get;
		}
		String ProviderString 
		{
			get;
		}
		Int32 QueryTimeout 
		{
			get;
		}
		Boolean RemoteProcTransactionPromotionEnabled 
		{
			get;
		}
		Boolean RpcEnabled 
		{
			get;
		}
		Boolean RpcOutEnabled 
		{
			get;
		}
		Boolean UseRemoteCollation 
		{
			get;
		}
	}
	public interface ISql110LinkedServerLogin : ISqlModelElement
	{		
		String LinkedServerLoginName 
		{
			get;
		}
		String LinkedServerPassword 
		{
			get;
		}
		Boolean UseSelf 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110LinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> LocalLogin 
		{
			get;
		}
	}
	public interface ISql110Login : ISqlModelElement
	{		
		Boolean CheckExpiration 
		{
			get;
		}
		Boolean CheckPolicy 
		{
			get;
		}
		String DefaultDatabase 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		LoginEncryptionOption EncryptionOption 
		{
			get;
		}
		Boolean MappedToWindowsLogin 
		{
			get;
		}
		String Password 
		{
			get;
		}
		Boolean PasswordHashed 
		{
			get;
		}
		Boolean PasswordMustChange 
		{
			get;
		}
		String Sid 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Credential> Credential 
		{
			get;
		}
	}
	public interface ISql110MasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql110MessageType : ISqlModelElement
	{		
		ValidationMethod ValidationMethod 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110PartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ParameterType 
		{
			get;
		}
	}
	public interface ISql110PartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql110PartitionValue : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql110Permission : ISqlModelElement
	{		
		PermissionAction PermissionAction 
		{
			get;
		}
		PermissionType PermissionType 
		{
			get;
		}
		Boolean WithAllPrivileges 
		{
			get;
		}
		Boolean WithGrantOption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> ExcludedColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantee 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantor 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql110PrimaryKeyConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110Procedure : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean ForReplication 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithRecompile 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Procedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110Queue : ISqlModelElement
	{		
		Boolean ActivationExecuteAsCaller 
		{
			get;
		}
		Boolean ActivationExecuteAsOwner 
		{
			get;
		}
		Boolean ActivationExecuteAsSelf 
		{
			get;
		}
		Int32? ActivationMaxQueueReaders 
		{
			get;
		}
		Boolean? ActivationStatusOn 
		{
			get;
		}
		Boolean PoisonMessageHandlingStatusOn 
		{
			get;
		}
		Boolean RetentionOn 
		{
			get;
		}
		Boolean StatusOn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Procedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110QueueEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Queue> Queue 
		{
			get;
		}
	}
	public interface ISql110RemoteServiceBinding : ISqlModelElement
	{		
		Boolean Anonymous 
		{
			get;
		}
		String Service 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110ResourceGovernor : ISqlModelElement
	{		
		Boolean? Enabled 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ClassifierFunction 
		{
			get;
		}
	}
	public interface ISql110ResourcePool : ISqlModelElement
	{		
		Int32 CapCpuPercent 
		{
			get;
		}
		Int32 MaxCpuPercent 
		{
			get;
		}
		Int32 MaxMemoryPercent 
		{
			get;
		}
		Int32 MinCpuPercent 
		{
			get;
		}
		Int32 MinMemoryPercent 
		{
			get;
		}
	}
	public interface ISql110Role : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110RoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Role> Role 
		{
			get;
		}
	}
	public interface ISql110Route : ISqlModelElement
	{		
		String Address 
		{
			get;
		}
		String BrokerInstance 
		{
			get;
		}
		Int32? Lifetime 
		{
			get;
		}
		String MirrorAddress 
		{
			get;
		}
		String ServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110Rule : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110Schema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110SearchProperty : ISqlModelElement
	{		
		String Description 
		{
			get;
		}
		Int32 Identifier 
		{
			get;
		}
		String PropertySetGuid 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SearchPropertyList> SearchPropertyList 
		{
			get;
		}
	}
	public interface ISql110SearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110Sequence : ISqlModelElement
	{		
		Int32? CacheSize 
		{
			get;
		}
		String IncrementValue 
		{
			get;
		}
		Boolean IsCached 
		{
			get;
		}
		Boolean IsCycling 
		{
			get;
		}
		String MaxValue 
		{
			get;
		}
		String MinValue 
		{
			get;
		}
		Boolean NoMaxValue 
		{
			get;
		}
		Boolean NoMinValue 
		{
			get;
		}
		String StartValue 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> DataType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110ServerAudit : ISqlModelElement
	{		
		String AuditGuid 
		{
			get;
		}
		AuditTarget AuditTarget 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		String FilePath 
		{
			get;
		}
		Int32? MaxFiles 
		{
			get;
		}
		Int32? MaxRolloverFiles 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		FailureAction OnFailure 
		{
			get;
		}
		String PredicateExpression 
		{
			get;
		}
		Int32 QueueDelay 
		{
			get;
		}
		Boolean ReserveDiskSpace 
		{
			get;
		}
		Boolean UnlimitedFileSize 
		{
			get;
		}
		Boolean UnlimitedMaxRolloverFiles 
		{
			get;
		}
	}
	public interface ISql110ServerAuditSpecification : ISqlModelElement
	{		
		Boolean StateOn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql110ServerDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean IsLogon 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110User> User 
		{
			get;
		}
	}
	public interface ISql110ServerEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql110ServerOptions : ISqlModelElement
	{		
	}
	public interface ISql110ServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Role> Role 
		{
			get;
		}
	}
	public interface ISql110Service : ISqlModelElement
	{		
		Boolean UseDefaultContract 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Contract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Queue> Queue 
		{
			get;
		}
	}
	public interface ISql110ServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		Boolean MessageForwardingEnabled 
		{
			get;
		}
		Int32 MessageForwardSize 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql110Signature : ISqlModelElement
	{		
		Boolean IsCounterSignature 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EncryptionMechanism 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> SignedObject 
		{
			get;
		}
	}
	public interface ISql110SignatureEncryptionMechanism : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		String SignedBlob 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql110SoapLanguageSpecifier : ISqlModelElement
	{		
		Boolean BatchesEnabled 
		{
			get;
		}
		CharacterSet CharacterSet 
		{
			get;
		}
		String DatabaseName 
		{
			get;
		}
		Int32 HeaderLimit 
		{
			get;
		}
		Boolean IsDefaultDatabase 
		{
			get;
		}
		Boolean IsDefaultNamespace 
		{
			get;
		}
		Boolean IsDefaultWsdlSpName 
		{
			get;
		}
		SoapLoginType LoginType 
		{
			get;
		}
		String Namespace 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		Boolean SessionsEnabled 
		{
			get;
		}
		Int32 SessionTimeout 
		{
			get;
		}
		Boolean SessionTimeoutNever 
		{
			get;
		}
		String WsdlSpName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SoapMethodSpecification> WebMethods 
		{
			get;
		}
	}
	public interface ISql110SoapMethodSpecification : ISqlModelElement
	{		
		SoapFormat Format 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		String WebMethodAlias 
		{
			get;
		}
		String WebMethodNamespace 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> RelatedMethod 
		{
			get;
		}
	}
	public interface ISql110SpatialIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? CellsPerObject 
		{
			get;
		}
		CompressionLevel DataCompression 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32 FillFactor 
		{
			get;
		}
		Degree GridLevel1Density 
		{
			get;
		}
		Degree GridLevel2Density 
		{
			get;
		}
		Degree GridLevel3Density 
		{
			get;
		}
		Degree GridLevel4Density 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Tessellation Tessellation 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		Double? XMax 
		{
			get;
		}
		Double? XMin 
		{
			get;
		}
		Double? YMax 
		{
			get;
		}
		Double? YMin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110Statistics : ISqlModelElement
	{		
		String FilterPredicate 
		{
			get;
		}
		Boolean NoRecompute 
		{
			get;
		}
		Int32 SampleSize 
		{
			get;
		}
		SamplingStyle SamplingStyle 
		{
			get;
		}
		String StatsStream 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> OnObject 
		{
			get;
		}
	}
	public interface ISql110Parameter : ISqlModelElement
	{		
		String DefaultExpression 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsOutput 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Varying 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110SymmetricKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		SymmetricKeyCreationDisposition CreationDisposition 
		{
			get;
		}
		String IdentityValue 
		{
			get;
		}
		String KeySource 
		{
			get;
		}
		String ProviderKeyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> Certificates 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Passwords 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Provider 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql110SymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql110Synonym : ISqlModelElement
	{		
		String ForObjectName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ForObject 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110Table : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean ChangeDataCaptureEnabled 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		Boolean LargeValueTypesOutOfRow 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		Int32 TextInRowSize 
		{
			get;
		}
		Boolean TrackColumnsUpdated 
		{
			get;
		}
		Boolean VardecimalStorageFormatEnabled 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110FileTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		String FileTableCollateFilename 
		{
			get;
		}
		String FileTableDirectory 
		{
			get;
		}
		Boolean FileTableNamespaceEnabled 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110TableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110TableTypeCheckConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql110TableTypeColumn : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110TableTypeDefaultConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql110TableTypeIndex : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IsDisabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
	}
	public interface ISql110TableTypePrimaryKeyConstraint : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
	}
	public interface ISql110TableTypeUniqueConstraint : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
	}
	public interface ISql110TcpProtocolSpecifier : ISqlModelElement
	{		
		String ListenerIPv4 
		{
			get;
		}
		String ListenerIPv6 
		{
			get;
		}
		Int32 ListenerPort 
		{
			get;
		}
		Boolean ListeningOnAllIPs 
		{
			get;
		}
	}
	public interface ISql110UniqueConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110User : ISqlModelElement
	{		
		AuthenticationType AuthenticationType 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		String Password 
		{
			get;
		}
		String Sid 
		{
			get;
		}
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Login> Login 
		{
			get;
		}
	}
	public interface ISql110UserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110UserDefinedType : ISqlModelElement
	{		
		Boolean? ByteOrdered 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean? FixedLength 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		String ValidationMethodName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Methods 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Properties 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110View : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		String SelectStatement 
		{
			get;
		}
		Boolean WithCheckOption 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		Boolean WithViewMetadata 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql110WorkloadGroup : ISqlModelElement
	{		
		Int32 GroupMaxRequests 
		{
			get;
		}
		Degree Importance 
		{
			get;
		}
		Int32 MaxDop 
		{
			get;
		}
		Int32 RequestMaxCpuTimeSec 
		{
			get;
		}
		Int32 RequestMaxMemoryGrantPercent 
		{
			get;
		}
		Int32 RequestMemoryGrantTimeoutSec 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110ResourcePool> ResourcePool 
		{
			get;
		}
	}
	public interface ISql110XmlIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean IsPrimary 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		SecondaryXmlIndexType SecondaryXmlIndexType 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql110SelectiveXmlIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean IsPrimary 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Column> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PrimaryPromotedPath 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110SelectiveXmlIndex> PrimarySelectiveXmlIndex 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PromotedPaths 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110XmlNamespace> XmlNamespaces 
		{
			get;
		}
	}
	public interface ISql110XmlNamespace : ISqlModelElement
	{		
		String NamespaceUri 
		{
			get;
		}
		String Prefix 
		{
			get;
		}
	}
	public interface ISql110PromotedNodePathForXQueryType : ISqlModelElement
	{		
		Boolean IsSingleton 
		{
			get;
		}
		Int32? MaxLength 
		{
			get;
		}
		String NodePath 
		{
			get;
		}
		String Type 
		{
			get;
		}
	}
	public interface ISql110PromotedNodePathForSqlType : ISqlModelElement
	{		
		Boolean IsMax 
		{
			get;
		}
		Boolean IsSingleton 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		String NodePath 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110DataType> DataType 
		{
			get;
		}
	}
	public interface ISql110XmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120Column : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsFileStream 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsIdentityNotForReplication 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Sparse 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120TableValuedFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		String ReturnTableVariableName 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120ScalarFunction : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean CalledOnNullInput 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		DataAccessKind? DataAccess 
		{
			get;
		}
		Boolean? Deterministic 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String FillRowMethodName 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? Precise 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReturnsNullOnNullInput 
		{
			get;
		}
		SystemDataAccessKind? SystemDataAccess 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120Aggregate : ISqlModelElement
	{		
		String ClassName 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Boolean? InvariantToDuplicates 
		{
			get;
		}
		Boolean? InvariantToNulls 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		Boolean? NullIfEmpty 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120ApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql120Index : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		String FilterPredicate 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean IncrementalStatistics 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean Unique 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120Assembly : ISqlModelElement
	{		
		AssemblyPermissionSet PermissionSet 
		{
			get;
		}
		Boolean Visible 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql120AssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql120AsymmetricKey : ISqlModelElement
	{		
		AsymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		SymmetricKeyCreationDisposition CreationDisposition 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String ExecutableFile 
		{
			get;
		}
		String File 
		{
			get;
		}
		String Password 
		{
			get;
		}
		String ProviderKeyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Provider 
		{
			get;
		}
	}
	public interface ISql120AuditAction : ISqlModelElement
	{		
		DatabaseAuditAction Action 
		{
			get;
		}
	}
	public interface ISql120AuditActionGroup : ISqlModelElement
	{		
		AuditActionGroupType ActionGroup 
		{
			get;
		}
	}
	public interface ISql120AuditActionSpecification : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Principals 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql120BrokerPriority : ISqlModelElement
	{		
		Int32 PriorityLevel 
		{
			get;
		}
		String RemoteServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ContractName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> LocalServiceName 
		{
			get;
		}
	}
	public interface ISql120BuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql120DataType : ISqlModelElement
	{		
		SqlDataType SqlDataType 
		{
			get;
		}
		Boolean UddtIsMax 
		{
			get;
		}
		Int32 UddtLength 
		{
			get;
		}
		Boolean UddtNullable 
		{
			get;
		}
		Int32 UddtPrecision 
		{
			get;
		}
		Int32 UddtScale 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql120Certificate : ISqlModelElement
	{		
		Boolean ActiveForBeginDialog 
		{
			get;
		}
		Boolean EncryptedWithPassword 
		{
			get;
		}
		String EncryptionPassword 
		{
			get;
		}
		String ExistingKeysFilePath 
		{
			get;
		}
		String ExpiryDate 
		{
			get;
		}
		Boolean IsExistingKeyFileExecutable 
		{
			get;
		}
		String PrivateKeyDecryptionPassword 
		{
			get;
		}
		String PrivateKeyEncryptionPassword 
		{
			get;
		}
		String PrivateKeyFilePath 
		{
			get;
		}
		String StartDate 
		{
			get;
		}
		String Subject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql120CheckConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql120ClrTypeMethod : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get;
		}
	}
	public interface ISql120ClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> DataType 
		{
			get;
		}
	}
	public interface ISql120ClrTypeProperty : ISqlModelElement
	{		
		String Name 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ClrType 
		{
			get;
		}
	}
	public interface ISql120ColumnStoreIndex : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120Contract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120MessageType> Messages 
		{
			get;
		}
	}
	public interface ISql120Credential : ISqlModelElement
	{		
		String Identity 
		{
			get;
		}
		String Secret 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120CryptographicProvider> CryptographicProvider 
		{
			get;
		}
	}
	public interface ISql120CryptographicProvider : ISqlModelElement
	{		
		String DllPath 
		{
			get;
		}
		Boolean Enabled 
		{
			get;
		}
	}
	public interface ISql120DatabaseAuditSpecification : ISqlModelElement
	{		
		Boolean WithState 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql120DatabaseDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120DatabaseEncryptionKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql120DatabaseEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql120DatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		DatabaseMirroringRole RoleType 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql120DatabaseOptions : ISqlModelElement
	{		
		Boolean AllowSnapshotIsolation 
		{
			get;
		}
		Boolean AnsiNullDefaultOn 
		{
			get;
		}
		Boolean AnsiNullsOn 
		{
			get;
		}
		Boolean AnsiPaddingOn 
		{
			get;
		}
		Boolean AnsiWarningsOn 
		{
			get;
		}
		Boolean ArithAbortOn 
		{
			get;
		}
		Boolean AutoClose 
		{
			get;
		}
		Boolean AutoCreateStatistics 
		{
			get;
		}
		Boolean AutoCreateStatisticsIncremental 
		{
			get;
		}
		Boolean AutoShrink 
		{
			get;
		}
		Boolean AutoUpdateStatistics 
		{
			get;
		}
		Boolean AutoUpdateStatisticsAsync 
		{
			get;
		}
		Boolean ChangeTrackingAutoCleanup 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
		{
			get;
		}
		Int32 ChangeTrackingRetentionPeriod 
		{
			get;
		}
		TimeUnit ChangeTrackingRetentionUnit 
		{
			get;
		}
		String Collation 
		{
			get;
		}
		Int32 CompatibilityLevel 
		{
			get;
		}
		Boolean ConcatNullYieldsNull 
		{
			get;
		}
		Containment Containment 
		{
			get;
		}
		Boolean CursorCloseOnCommit 
		{
			get;
		}
		Boolean CursorDefaultGlobalScope 
		{
			get;
		}
		Boolean DatabaseStateOffline 
		{
			get;
		}
		Boolean DateCorrelationOptimizationOn 
		{
			get;
		}
		Boolean DBChainingOn 
		{
			get;
		}
		String DefaultFullTextLanguage 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		DelayedDurabilityMode DelayedDurabilityMode 
		{
			get;
		}
		String FileStreamDirectoryName 
		{
			get;
		}
		Boolean FullTextEnabled 
		{
			get;
		}
		Boolean HonorBrokerPriority 
		{
			get;
		}
		Boolean MemoryOptimizedElevateToSnapshot 
		{
			get;
		}
		Boolean NestedTriggersOn 
		{
			get;
		}
		NonTransactedFileStreamAccess NonTransactedFileStreamAccess 
		{
			get;
		}
		Boolean NumericRoundAbortOn 
		{
			get;
		}
		PageVerifyMode PageVerifyMode 
		{
			get;
		}
		ParameterizationOption ParameterizationOption 
		{
			get;
		}
		Boolean QuotedIdentifierOn 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		RecoveryMode RecoveryMode 
		{
			get;
		}
		Boolean RecursiveTriggersOn 
		{
			get;
		}
		ServiceBrokerOption ServiceBrokerOption 
		{
			get;
		}
		Boolean SupplementalLoggingOn 
		{
			get;
		}
		Int32 TargetRecoveryTimePeriod 
		{
			get;
		}
		TimeUnit TargetRecoveryTimeUnit 
		{
			get;
		}
		Boolean TornPageProtectionOn 
		{
			get;
		}
		Boolean TransactionIsolationReadCommittedSnapshot 
		{
			get;
		}
		Boolean TransformNoiseWords 
		{
			get;
		}
		Boolean Trustworthy 
		{
			get;
		}
		Int16 TwoDigitYearCutoff 
		{
			get;
		}
		UserAccessOption UserAccessOption 
		{
			get;
		}
		Boolean VardecimalStorageFormatOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> DefaultFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> DefaultFileStreamFilegroup 
		{
			get;
		}
	}
	public interface ISql120DataCompressionOption : ISqlModelElement
	{		
		CompressionLevel CompressionLevel 
		{
			get;
		}
		Int32 PartitionNumber 
		{
			get;
		}
	}
	public interface ISql120Default : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120DefaultConstraint : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		Boolean WithValues 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql120DmlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		OrderRestriction DeleteOrderRestriction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		OrderRestriction InsertOrderRestriction 
		{
			get;
		}
		Boolean IsDeleteTrigger 
		{
			get;
		}
		Boolean IsInsertTrigger 
		{
			get;
		}
		Boolean IsUpdateTrigger 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		OrderRestriction UpdateOrderRestriction 
		{
			get;
		}
		Boolean WithAppend 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120Endpoint : ISqlModelElement
	{		
		Payload Payload 
		{
			get;
		}
		Protocol Protocol 
		{
			get;
		}
		State State 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> PayloadSpecifier 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ProtocolSpecifier 
		{
			get;
		}
	}
	public interface ISql120ErrorMessage : ISqlModelElement
	{		
		String Language 
		{
			get;
		}
		Int32 MessageNumber 
		{
			get;
		}
		String MessageText 
		{
			get;
		}
		Int32 Severity 
		{
			get;
		}
		Boolean WithLog 
		{
			get;
		}
	}
	public interface ISql120EventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql120EventSession : ISqlModelElement
	{		
		EventRetentionMode EventRetentionMode 
		{
			get;
		}
		Int32 MaxDispatchLatency 
		{
			get;
		}
		Int32 MaxEventSize 
		{
			get;
		}
		MemoryUnit MaxEventSizeUnit 
		{
			get;
		}
		Int32 MaxMemory 
		{
			get;
		}
		MemoryUnit MaxMemoryUnit 
		{
			get;
		}
		MemoryPartitionMode MemoryPartitionMode 
		{
			get;
		}
		Boolean StartupState 
		{
			get;
		}
		Boolean TrackCausality 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EventDefinitions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EventTargets 
		{
			get;
		}
	}
	public interface ISql120EventSessionAction : ISqlModelElement
	{		
		String ActionName 
		{
			get;
		}
		String EventModuleGuid 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
	}
	public interface ISql120EventSessionDefinitions : ISqlModelElement
	{		
		String EventModuleGuid 
		{
			get;
		}
		String EventName 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
		String WhereExpression 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventSessionAction> Actions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> AttributeSettings 
		{
			get;
		}
	}
	public interface ISql120EventSessionSetting : ISqlModelElement
	{		
		String SettingName 
		{
			get;
		}
		String SettingValue 
		{
			get;
		}
	}
	public interface ISql120EventSessionTarget : ISqlModelElement
	{		
		String EventModuleGuid 
		{
			get;
		}
		String EventPackageName 
		{
			get;
		}
		String TargetName 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> ParameterSettings 
		{
			get;
		}
	}
	public interface ISql120EventTypeSpecifier : ISqlModelElement
	{		
		EventType EventType 
		{
			get;
		}
		OrderRestriction Order 
		{
			get;
		}
	}
	public interface ISql120ExtendedProcedure : ISqlModelElement
	{		
		Boolean ExeccuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120ExtendedProperty : ISqlModelElement
	{		
		String Value 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> Host 
		{
			get;
		}
	}
	public interface ISql120SqlFile : ISqlModelElement
	{		
		Int32? FileGrowth 
		{
			get;
		}
		MemoryUnit FileGrowthUnit 
		{
			get;
		}
		String FileName 
		{
			get;
		}
		Boolean IsLogFile 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		Boolean Offline 
		{
			get;
		}
		Int32? Size 
		{
			get;
		}
		MemoryUnit SizeUnit 
		{
			get;
		}
		Boolean Unlimited 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql120Filegroup : ISqlModelElement
	{		
		Boolean ContainsFileStream 
		{
			get;
		}
		Boolean ContainsMemoryOptimizedData 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
	}
	public interface ISql120ForeignKeyConstraint : ISqlModelElement
	{		
		ForeignKeyAction DeleteAction 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean NotForReplication 
		{
			get;
		}
		ForeignKeyAction UpdateAction 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Table> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> Host 
		{
			get;
		}
	}
	public interface ISql120FullTextCatalog : ISqlModelElement
	{		
		Boolean? AccentSensitivity 
		{
			get;
		}
		Boolean IsDefault 
		{
			get;
		}
		String Path 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql120FullTextIndex : ISqlModelElement
	{		
		ChangeTrackingOption ChangeTracking 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		Boolean StopListOff 
		{
			get;
		}
		Boolean UseSystemStopList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Catalog 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SearchPropertyList> SearchPropertyList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> StopList 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> UniqueIndexName 
		{
			get;
		}
	}
	public interface ISql120FullTextIndexColumnSpecifier : ISqlModelElement
	{		
		Int32? LanguageId 
		{
			get;
		}
		Boolean PartOfStatisticalSemantics 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> TypeColumn 
		{
			get;
		}
	}
	public interface ISql120FullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120HttpProtocolSpecifier : ISqlModelElement
	{		
		AuthenticationModes AuthenticationMode 
		{
			get;
		}
		String AuthenticationRealm 
		{
			get;
		}
		Int32? ClearPort 
		{
			get;
		}
		Boolean CompressionEnabled 
		{
			get;
		}
		String DefaultLogonDomain 
		{
			get;
		}
		Boolean ListeningOnAllNoneReservedSites 
		{
			get;
		}
		Boolean ListeningOnAllSites 
		{
			get;
		}
		String Path 
		{
			get;
		}
		HttpPorts Ports 
		{
			get;
		}
		Int32? SslPort 
		{
			get;
		}
		String Website 
		{
			get;
		}
	}
	public interface ISql120LinkedServer : ISqlModelElement
	{		
		String Catalog 
		{
			get;
		}
		Boolean CollationCompatible 
		{
			get;
		}
		String CollationName 
		{
			get;
		}
		Int32 ConnectTimeout 
		{
			get;
		}
		Boolean DataAccess 
		{
			get;
		}
		String DataSource 
		{
			get;
		}
		Boolean IsDistributor 
		{
			get;
		}
		Boolean IsPublisher 
		{
			get;
		}
		Boolean IsSubscriber 
		{
			get;
		}
		Boolean LazySchemaValidationEnabled 
		{
			get;
		}
		String Location 
		{
			get;
		}
		String ProductName 
		{
			get;
		}
		String ProviderName 
		{
			get;
		}
		String ProviderString 
		{
			get;
		}
		Int32 QueryTimeout 
		{
			get;
		}
		Boolean RemoteProcTransactionPromotionEnabled 
		{
			get;
		}
		Boolean RpcEnabled 
		{
			get;
		}
		Boolean RpcOutEnabled 
		{
			get;
		}
		Boolean UseRemoteCollation 
		{
			get;
		}
	}
	public interface ISql120LinkedServerLogin : ISqlModelElement
	{		
		String LinkedServerLoginName 
		{
			get;
		}
		String LinkedServerPassword 
		{
			get;
		}
		Boolean UseSelf 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120LinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> LocalLogin 
		{
			get;
		}
	}
	public interface ISql120Login : ISqlModelElement
	{		
		Boolean CheckExpiration 
		{
			get;
		}
		Boolean CheckPolicy 
		{
			get;
		}
		String DefaultDatabase 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		LoginEncryptionOption EncryptionOption 
		{
			get;
		}
		Boolean MappedToWindowsLogin 
		{
			get;
		}
		String Password 
		{
			get;
		}
		Boolean PasswordHashed 
		{
			get;
		}
		Boolean PasswordMustChange 
		{
			get;
		}
		String Sid 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Credential> Credential 
		{
			get;
		}
	}
	public interface ISql120MasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql120MessageType : ISqlModelElement
	{		
		ValidationMethod ValidationMethod 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120PartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ParameterType 
		{
			get;
		}
	}
	public interface ISql120PartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql120PartitionValue : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql120Permission : ISqlModelElement
	{		
		PermissionAction PermissionAction 
		{
			get;
		}
		PermissionType PermissionType 
		{
			get;
		}
		Boolean WithAllPrivileges 
		{
			get;
		}
		Boolean WithGrantOption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> ExcludedColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantee 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantor 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql120PrimaryKeyConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120Procedure : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean ForReplication 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithNativeCompilation 
		{
			get;
		}
		Boolean WithRecompile 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Parameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Procedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120Queue : ISqlModelElement
	{		
		Boolean ActivationExecuteAsCaller 
		{
			get;
		}
		Boolean ActivationExecuteAsOwner 
		{
			get;
		}
		Boolean ActivationExecuteAsSelf 
		{
			get;
		}
		Int32? ActivationMaxQueueReaders 
		{
			get;
		}
		Boolean? ActivationStatusOn 
		{
			get;
		}
		Boolean PoisonMessageHandlingStatusOn 
		{
			get;
		}
		Boolean RetentionOn 
		{
			get;
		}
		Boolean StatusOn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Procedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120QueueEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Queue> Queue 
		{
			get;
		}
	}
	public interface ISql120RemoteServiceBinding : ISqlModelElement
	{		
		Boolean Anonymous 
		{
			get;
		}
		String Service 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120ResourceGovernor : ISqlModelElement
	{		
		Boolean? Enabled 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ClassifierFunction 
		{
			get;
		}
	}
	public interface ISql120ResourcePool : ISqlModelElement
	{		
		Int32 CapCpuPercent 
		{
			get;
		}
		Int32 MaxCpuPercent 
		{
			get;
		}
		Int32 MaxIopsPerVolume 
		{
			get;
		}
		Int32 MaxMemoryPercent 
		{
			get;
		}
		Int32 MinCpuPercent 
		{
			get;
		}
		Int32 MinIopsPerVolume 
		{
			get;
		}
		Int32 MinMemoryPercent 
		{
			get;
		}
	}
	public interface ISql120Role : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120RoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Role> Role 
		{
			get;
		}
	}
	public interface ISql120Route : ISqlModelElement
	{		
		String Address 
		{
			get;
		}
		String BrokerInstance 
		{
			get;
		}
		Int32? Lifetime 
		{
			get;
		}
		String MirrorAddress 
		{
			get;
		}
		String ServiceName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120Rule : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BoundObjects 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120Schema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120SearchProperty : ISqlModelElement
	{		
		String Description 
		{
			get;
		}
		Int32 Identifier 
		{
			get;
		}
		String PropertySetGuid 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SearchPropertyList> SearchPropertyList 
		{
			get;
		}
	}
	public interface ISql120SearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120Sequence : ISqlModelElement
	{		
		Int32? CacheSize 
		{
			get;
		}
		String IncrementValue 
		{
			get;
		}
		Boolean IsCached 
		{
			get;
		}
		Boolean IsCycling 
		{
			get;
		}
		String MaxValue 
		{
			get;
		}
		String MinValue 
		{
			get;
		}
		Boolean NoMaxValue 
		{
			get;
		}
		Boolean NoMinValue 
		{
			get;
		}
		String StartValue 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> DataType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120ServerAudit : ISqlModelElement
	{		
		String AuditGuid 
		{
			get;
		}
		AuditTarget AuditTarget 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		String FilePath 
		{
			get;
		}
		Int32? MaxFiles 
		{
			get;
		}
		Int32? MaxRolloverFiles 
		{
			get;
		}
		Int32? MaxSize 
		{
			get;
		}
		MemoryUnit MaxSizeUnit 
		{
			get;
		}
		FailureAction OnFailure 
		{
			get;
		}
		String PredicateExpression 
		{
			get;
		}
		Int32 QueueDelay 
		{
			get;
		}
		Boolean ReserveDiskSpace 
		{
			get;
		}
		Boolean UnlimitedFileSize 
		{
			get;
		}
		Boolean UnlimitedMaxRolloverFiles 
		{
			get;
		}
	}
	public interface ISql120ServerAuditSpecification : ISqlModelElement
	{		
		Boolean StateOn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql120ServerDdlTrigger : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean ExecuteAsCaller 
		{
			get;
		}
		Boolean ExecuteAsOwner 
		{
			get;
		}
		Boolean ExecuteAsSelf 
		{
			get;
		}
		Boolean IsLogon 
		{
			get;
		}
		String MethodName 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		TriggerType TriggerType 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120User> User 
		{
			get;
		}
	}
	public interface ISql120ServerEventNotification : ISqlModelElement
	{		
		String BrokerInstanceSpecifier 
		{
			get;
		}
		String BrokerService 
		{
			get;
		}
		Boolean WithFanIn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120EventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql120ServerOptions : ISqlModelElement
	{		
	}
	public interface ISql120ServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Role> Role 
		{
			get;
		}
	}
	public interface ISql120Service : ISqlModelElement
	{		
		Boolean UseDefaultContract 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Contract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Queue> Queue 
		{
			get;
		}
	}
	public interface ISql120ServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
			get;
		}
		ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
			get;
		}
		EncryptionMode EncryptionMode 
		{
			get;
		}
		Boolean MessageForwardingEnabled 
		{
			get;
		}
		Int32 MessageForwardSize 
		{
			get;
		}
		Boolean UseCertificateFirst 
		{
			get;
		}
		AuthenticationModes WindowsAuthenticationMode 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql120Signature : ISqlModelElement
	{		
		Boolean IsCounterSignature 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> EncryptionMechanism 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> SignedObject 
		{
			get;
		}
	}
	public interface ISql120SignatureEncryptionMechanism : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		String SignedBlob 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> Certificate 
		{
			get;
		}
	}
	public interface ISql120SoapLanguageSpecifier : ISqlModelElement
	{		
		Boolean BatchesEnabled 
		{
			get;
		}
		CharacterSet CharacterSet 
		{
			get;
		}
		String DatabaseName 
		{
			get;
		}
		Int32 HeaderLimit 
		{
			get;
		}
		Boolean IsDefaultDatabase 
		{
			get;
		}
		Boolean IsDefaultNamespace 
		{
			get;
		}
		Boolean IsDefaultWsdlSpName 
		{
			get;
		}
		SoapLoginType LoginType 
		{
			get;
		}
		String Namespace 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		Boolean SessionsEnabled 
		{
			get;
		}
		Int32 SessionTimeout 
		{
			get;
		}
		Boolean SessionTimeoutNever 
		{
			get;
		}
		String WsdlSpName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SoapMethodSpecification> WebMethods 
		{
			get;
		}
	}
	public interface ISql120SoapMethodSpecification : ISqlModelElement
	{		
		SoapFormat Format 
		{
			get;
		}
		SoapSchema SchemaType 
		{
			get;
		}
		String WebMethodAlias 
		{
			get;
		}
		String WebMethodNamespace 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> RelatedMethod 
		{
			get;
		}
	}
	public interface ISql120SpatialIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Int32? CellsPerObject 
		{
			get;
		}
		CompressionLevel DataCompression 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32 FillFactor 
		{
			get;
		}
		Degree GridLevel1Density 
		{
			get;
		}
		Degree GridLevel2Density 
		{
			get;
		}
		Degree GridLevel3Density 
		{
			get;
		}
		Degree GridLevel4Density 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Tessellation Tessellation 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		Double? XMax 
		{
			get;
		}
		Double? XMin 
		{
			get;
		}
		Double? YMax 
		{
			get;
		}
		Double? YMin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120Statistics : ISqlModelElement
	{		
		String FilterPredicate 
		{
			get;
		}
		Boolean Incremental 
		{
			get;
		}
		Boolean NoRecompute 
		{
			get;
		}
		Int32 SampleSize 
		{
			get;
		}
		SamplingStyle SamplingStyle 
		{
			get;
		}
		String StatsStream 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> OnObject 
		{
			get;
		}
	}
	public interface ISql120Parameter : ISqlModelElement
	{		
		String DefaultExpression 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsOutput 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Boolean ReadOnly 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		Boolean Varying 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120SymmetricKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		SymmetricKeyCreationDisposition CreationDisposition 
		{
			get;
		}
		String IdentityValue 
		{
			get;
		}
		String KeySource 
		{
			get;
		}
		String ProviderKeyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> Certificates 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Passwords 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> Provider 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql120SymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql120Synonym : ISqlModelElement
	{		
		String ForObjectName 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ForObject 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120Table : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean ChangeDataCaptureEnabled 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
		{
			get;
		}
		Durability Durability 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Boolean IsReplicated 
		{
			get;
		}
		Boolean LargeValueTypesOutOfRow 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean MemoryOptimized 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		Int32 TextInRowSize 
		{
			get;
		}
		Boolean TrackColumnsUpdated 
		{
			get;
		}
		Boolean VardecimalStorageFormatEnabled 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120FileTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		String FileTableCollateFilename 
		{
			get;
		}
		String FileTableDirectory 
		{
			get;
		}
		Boolean FileTableNamespaceEnabled 
		{
			get;
		}
		LockEscalationMethod LockEscalation 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean TableLockOnBulkLoad 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120TableType : ISqlModelElement
	{		
		Boolean MemoryOptimized 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlIndex> Indexes 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120TableTypeCheckConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
	}
	public interface ISql120TableTypeColumn : ISqlModelElement
	{		
		String Collation 
		{
			get;
		}
		String Expression 
		{
			get;
		}
		String IdentityIncrement 
		{
			get;
		}
		String IdentitySeed 
		{
			get;
		}
		Boolean IsIdentity 
		{
			get;
		}
		Boolean IsMax 
		{
			get;
		}
		Boolean IsRowGuidCol 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		Boolean Nullable 
		{
			get;
		}
		Boolean Persisted 
		{
			get;
		}
		Boolean? PersistedNullable 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120TableTypeDefaultConstraint : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> TargetColumn 
		{
			get;
		}
	}
	public interface ISql120TableTypeIndex : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IsDisabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
	}
	public interface ISql120TableTypePrimaryKeyConstraint : ISqlModelElement
	{		
		Int32? BucketCount 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Hash 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
	}
	public interface ISql120TableTypeUniqueConstraint : ISqlModelElement
	{		
		Boolean Clustered 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
	}
	public interface ISql120TcpProtocolSpecifier : ISqlModelElement
	{		
		String ListenerIPv4 
		{
			get;
		}
		String ListenerIPv6 
		{
			get;
		}
		Int32 ListenerPort 
		{
			get;
		}
		Boolean ListeningOnAllIPs 
		{
			get;
		}
	}
	public interface ISql120UniqueConstraint : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Clustered 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Boolean? FileStreamNull 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Filegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ExtendedProperty> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120PartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120User : ISqlModelElement
	{		
		AuthenticationType AuthenticationType 
		{
			get;
		}
		String DefaultLanguage 
		{
			get;
		}
		String Password 
		{
			get;
		}
		String Sid 
		{
			get;
		}
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120AsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Certificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Login> Login 
		{
			get;
		}
	}
	public interface ISql120UserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120UserDefinedType : ISqlModelElement
	{		
		Boolean? ByteOrdered 
		{
			get;
		}
		String ClassName 
		{
			get;
		}
		Boolean? FixedLength 
		{
			get;
		}
		Format Format 
		{
			get;
		}
		Int32? MaxByteSize 
		{
			get;
		}
		String ValidationMethodName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Assembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Methods 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Properties 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120View : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean? QuotedIdentifierOn 
		{
			get;
		}
		Boolean Replicated 
		{
			get;
		}
		String SelectStatement 
		{
			get;
		}
		Boolean WithCheckOption 
		{
			get;
		}
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithSchemaBinding 
		{
			get;
		}
		Boolean WithViewMetadata 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
	public interface ISql120WorkloadGroup : ISqlModelElement
	{		
		Int32 GroupMaxRequests 
		{
			get;
		}
		Degree Importance 
		{
			get;
		}
		Int32 MaxDop 
		{
			get;
		}
		Int32 RequestMaxCpuTimeSec 
		{
			get;
		}
		Int32 RequestMaxMemoryGrantPercent 
		{
			get;
		}
		Int32 RequestMemoryGrantTimeoutSec 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120ResourcePool> ResourcePool 
		{
			get;
		}
	}
	public interface ISql120XmlIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean IsPrimary 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		SecondaryXmlIndexType SecondaryXmlIndexType 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql120SelectiveXmlIndex : ISqlModelElement
	{		
		Boolean AllowPageLocks 
		{
			get;
		}
		Boolean AllowRowLocks 
		{
			get;
		}
		Boolean Disabled 
		{
			get;
		}
		Int32? FillFactor 
		{
			get;
		}
		Boolean IgnoreDuplicateKey 
		{
			get;
		}
		Boolean IsPrimary 
		{
			get;
		}
		Boolean RecomputeStatistics 
		{
			get;
		}
		Boolean WithPadIndex 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Column> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PrimaryPromotedPath 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120SelectiveXmlIndex> PrimarySelectiveXmlIndex 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PromotedPaths 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120XmlNamespace> XmlNamespaces 
		{
			get;
		}
	}
	public interface ISql120XmlNamespace : ISqlModelElement
	{		
		String NamespaceUri 
		{
			get;
		}
		String Prefix 
		{
			get;
		}
	}
	public interface ISql120PromotedNodePathForXQueryType : ISqlModelElement
	{		
		Boolean IsSingleton 
		{
			get;
		}
		Int32? MaxLength 
		{
			get;
		}
		String NodePath 
		{
			get;
		}
		String Type 
		{
			get;
		}
	}
	public interface ISql120PromotedNodePathForSqlType : ISqlModelElement
	{		
		Boolean IsMax 
		{
			get;
		}
		Boolean IsSingleton 
		{
			get;
		}
		Int32 Length 
		{
			get;
		}
		String NodePath 
		{
			get;
		}
		Int32 Precision 
		{
			get;
		}
		Int32 Scale 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120DataType> DataType 
		{
			get;
		}
	}
	public interface ISql120XmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120Schema> Schema 
		{
			get;
		}
	}
}