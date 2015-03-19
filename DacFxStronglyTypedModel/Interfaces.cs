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

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
	using System;
	using System.Linq; 
	using Microsoft.SqlServer.Server;
	using Microsoft.SqlServer.Dac.Model;
	using System.Collections.Generic;
	public interface ISql90TSqlColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql90TSqlTableValuedFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlScalarFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlAggregate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql90TSqlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90TSqlAssembly : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql90TSqlAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql90TSqlAsymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90TSqlAuditAction : ISqlModelElement
	{		
	}
	public interface ISql90TSqlAuditActionGroup : ISqlModelElement
	{		
	}
	public interface ISql90TSqlAuditActionSpecification : ISqlModelElement
	{		
	}
	public interface ISql90TSqlBrokerPriority : ISqlModelElement
	{		
	}
	public interface ISql90TSqlBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql90TSqlDataType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql90TSqlCertificate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql90TSqlCheckConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql90TSqlClrTypeMethod : ISqlModelElement
	{		
		String MethodName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> ReturnType 
		{
			get;
		}
	}
	public interface ISql90TSqlClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String ParameterName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISql90TSqlClrTypeProperty : ISqlModelElement
	{		
		String PropertyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> ClrType 
		{
			get;
		}
	}
	public interface ISql90TSqlColumnStoreIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90TSqlContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlMessageType> Messages 
		{
			get;
		}
	}
	public interface ISql90TSqlCredential : ISqlModelElement
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
	public interface ISql90TSqlCryptographicProvider : ISqlModelElement
	{		
	}
	public interface ISql90TSqlDatabaseAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISql90TSqlDatabaseDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlDatabaseEncryptionKey : ISqlModelElement
	{		
	}
	public interface ISql90TSqlDatabaseEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql90TSqlDatabaseMirroringLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql90TSqlDatabaseOptions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> DefaultFilegroup 
		{
			get;
		}
	}
	public interface ISql90TSqlDataCompressionOption : ISqlModelElement
	{		
	}
	public interface ISql90TSqlDefault : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql90TSqlDmlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlEndpoint : ISqlModelElement
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
	public interface ISql90TSqlErrorMessage : ISqlModelElement
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
	public interface ISql90TSqlEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql90TSqlEventSession : ISqlModelElement
	{		
	}
	public interface ISql90TSqlEventSessionAction : ISqlModelElement
	{		
	}
	public interface ISql90TSqlEventSessionDefinitions : ISqlModelElement
	{		
	}
	public interface ISql90TSqlEventSessionSetting : ISqlModelElement
	{		
	}
	public interface ISql90TSqlEventSessionTarget : ISqlModelElement
	{		
	}
	public interface ISql90TSqlEventTypeSpecifier : ISqlModelElement
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
	public interface ISql90TSqlExtendedProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlExtendedProperty : ISqlModelElement
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
	public interface ISql90TSqlSqlFile : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql90TSqlFilegroup : ISqlModelElement
	{		
		Boolean ReadOnly 
		{
			get;
		}
	}
	public interface ISql90TSqlForeignKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql90TSqlFullTextCatalog : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql90TSqlFullTextIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> UniqueIndexName 
		{
			get;
		}
	}
	public interface ISql90TSqlFullTextIndexColumnSpecifier : ISqlModelElement
	{		
		Int32? LanguageId 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> TypeColumn 
		{
			get;
		}
	}
	public interface ISql90TSqlFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90TSqlHttpProtocolSpecifier : ISqlModelElement
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
	public interface ISql90TSqlLinkedServer : ISqlModelElement
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
	public interface ISql90TSqlLinkedServerLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> LocalLogin 
		{
			get;
		}
	}
	public interface ISql90TSqlLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCredential> Credential 
		{
			get;
		}
	}
	public interface ISql90TSqlMasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql90TSqlMessageType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql90TSqlPartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> ParameterType 
		{
			get;
		}
	}
	public interface ISql90TSqlPartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql90TSqlPartitionValue : ISqlModelElement
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
	public interface ISql90TSqlPermission : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> ExcludedColumns 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql90TSqlPrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90TSqlProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlProcedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlQueue : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlProcedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlQueueEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql90TSqlRemoteServiceBinding : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlResourceGovernor : ISqlModelElement
	{		
	}
	public interface ISql90TSqlResourcePool : ISqlModelElement
	{		
	}
	public interface ISql90TSqlRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90TSqlRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql90TSqlRoute : ISqlModelElement
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
	public interface ISql90TSqlRule : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90TSqlSearchProperty : ISqlModelElement
	{		
	}
	public interface ISql90TSqlSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90TSqlSequence : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlServerAudit : ISqlModelElement
	{		
	}
	public interface ISql90TSqlServerAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISql90TSqlServerDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql90TSqlServerEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql90TSqlServerOptions : ISqlModelElement
	{		
	}
	public interface ISql90TSqlServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql90TSqlService : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlContract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql90TSqlServiceBrokerLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql90TSqlSignature : ISqlModelElement
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
	public interface ISql90TSqlSignatureEncryptionMechanism : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql90TSqlSoapLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSoapMethodSpecification> WebMethods 
		{
			get;
		}
	}
	public interface ISql90TSqlSoapMethodSpecification : ISqlModelElement
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
	public interface ISql90TSqlSpatialIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90TSqlStatistics : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> OnObject 
		{
			get;
		}
	}
	public interface ISql90TSqlParameter : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql90TSqlSymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCertificate> Certificates 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> Passwords 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql90TSqlSymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql90TSqlSynonym : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlFileTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlTableType : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlTableTypeCheckConstraint : ISqlModelElement
	{		
	}
	public interface ISql90TSqlTableTypeColumn : ISqlModelElement
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
	public interface ISql90TSqlTableTypeDefaultConstraint : ISqlModelElement
	{		
	}
	public interface ISql90TSqlTableTypeIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql90TSqlTableTypePrimaryKeyConstraint : ISqlModelElement
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
	public interface ISql90TSqlTableTypeUniqueConstraint : ISqlModelElement
	{		
	}
	public interface ISql90TSqlTcpProtocolSpecifier : ISqlModelElement
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
	public interface ISql90TSqlUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql90TSqlUser : ISqlModelElement
	{		
		AuthenticationType AuthenticationType 
		{
			get;
		}
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlLogin> Login 
		{
			get;
		}
	}
	public interface ISql90TSqlUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql90TSqlUserDefinedType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlAssembly> Assembly 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlView : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql90TSqlWorkloadGroup : ISqlModelElement
	{		
	}
	public interface ISql90TSqlXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlXmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql90TSqlSelectiveXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISql90TSqlXmlNamespace : ISqlModelElement
	{		
	}
	public interface ISql90TSqlPromotedNodePathForXQueryType : ISqlModelElement
	{		
	}
	public interface ISql90TSqlPromotedNodePathForSqlType : ISqlModelElement
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
	public interface ISql90TSqlXmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql90TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100TSqlTableValuedFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlScalarFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlAggregate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql100TSqlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100TSqlAssembly : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql100TSqlAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql100TSqlAsymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
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
	public interface ISql100TSqlAuditAction : ISqlModelElement
	{		
		DatabaseAuditAction Action 
		{
			get;
		}
	}
	public interface ISql100TSqlAuditActionGroup : ISqlModelElement
	{		
		AuditActionGroupType ActionGroup 
		{
			get;
		}
	}
	public interface ISql100TSqlAuditActionSpecification : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAuditAction> AuditActions 
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
	public interface ISql100TSqlBrokerPriority : ISqlModelElement
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
	public interface ISql100TSqlBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql100TSqlDataType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql100TSqlCertificate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql100TSqlCheckConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql100TSqlClrTypeMethod : ISqlModelElement
	{		
		String MethodName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> ReturnType 
		{
			get;
		}
	}
	public interface ISql100TSqlClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String ParameterName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISql100TSqlClrTypeProperty : ISqlModelElement
	{		
		String PropertyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> ClrType 
		{
			get;
		}
	}
	public interface ISql100TSqlColumnStoreIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100TSqlContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlMessageType> Messages 
		{
			get;
		}
	}
	public interface ISql100TSqlCredential : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCryptographicProvider> CryptographicProvider 
		{
			get;
		}
	}
	public interface ISql100TSqlCryptographicProvider : ISqlModelElement
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
	public interface ISql100TSqlDatabaseAuditSpecification : ISqlModelElement
	{		
		Boolean WithState 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql100TSqlDatabaseDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlDatabaseEncryptionKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql100TSqlDatabaseEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql100TSqlDatabaseMirroringLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql100TSqlDatabaseOptions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> DefaultFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> DefaultFileStreamFilegroup 
		{
			get;
		}
	}
	public interface ISql100TSqlDataCompressionOption : ISqlModelElement
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
	public interface ISql100TSqlDefault : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql100TSqlDmlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlEndpoint : ISqlModelElement
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
	public interface ISql100TSqlErrorMessage : ISqlModelElement
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
	public interface ISql100TSqlEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql100TSqlEventSession : ISqlModelElement
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
	public interface ISql100TSqlEventSessionAction : ISqlModelElement
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
	public interface ISql100TSqlEventSessionDefinitions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlEventSessionAction> Actions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> AttributeSettings 
		{
			get;
		}
	}
	public interface ISql100TSqlEventSessionSetting : ISqlModelElement
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
	public interface ISql100TSqlEventSessionTarget : ISqlModelElement
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
	public interface ISql100TSqlEventTypeSpecifier : ISqlModelElement
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
	public interface ISql100TSqlExtendedProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlExtendedProperty : ISqlModelElement
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
	public interface ISql100TSqlSqlFile : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql100TSqlFilegroup : ISqlModelElement
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
	public interface ISql100TSqlForeignKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql100TSqlFullTextCatalog : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql100TSqlFullTextIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
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
	public interface ISql100TSqlFullTextIndexColumnSpecifier : ISqlModelElement
	{		
		Int32? LanguageId 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> TypeColumn 
		{
			get;
		}
	}
	public interface ISql100TSqlFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100TSqlHttpProtocolSpecifier : ISqlModelElement
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
	public interface ISql100TSqlLinkedServer : ISqlModelElement
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
	public interface ISql100TSqlLinkedServerLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> LocalLogin 
		{
			get;
		}
	}
	public interface ISql100TSqlLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCredential> Credential 
		{
			get;
		}
	}
	public interface ISql100TSqlMasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql100TSqlMessageType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100TSqlPartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> ParameterType 
		{
			get;
		}
	}
	public interface ISql100TSqlPartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql100TSqlPartitionValue : ISqlModelElement
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
	public interface ISql100TSqlPermission : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> ExcludedColumns 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql100TSqlPrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100TSqlProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlProcedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlQueue : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlProcedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlQueueEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql100TSqlRemoteServiceBinding : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlResourceGovernor : ISqlModelElement
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
	public interface ISql100TSqlResourcePool : ISqlModelElement
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
	public interface ISql100TSqlRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100TSqlRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql100TSqlRoute : ISqlModelElement
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
	public interface ISql100TSqlRule : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100TSqlSearchProperty : ISqlModelElement
	{		
	}
	public interface ISql100TSqlSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100TSqlSequence : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlServerAudit : ISqlModelElement
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
	public interface ISql100TSqlServerAuditSpecification : ISqlModelElement
	{		
		Boolean StateOn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql100TSqlServerDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql100TSqlServerEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql100TSqlServerOptions : ISqlModelElement
	{		
	}
	public interface ISql100TSqlServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql100TSqlService : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlContract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql100TSqlServiceBrokerLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql100TSqlSignature : ISqlModelElement
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
	public interface ISql100TSqlSignatureEncryptionMechanism : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql100TSqlSoapLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSoapMethodSpecification> WebMethods 
		{
			get;
		}
	}
	public interface ISql100TSqlSoapMethodSpecification : ISqlModelElement
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
	public interface ISql100TSqlSpatialIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100TSqlStatistics : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
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
	public interface ISql100TSqlParameter : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100TSqlSymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> Certificates 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql100TSqlSymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql100TSqlSynonym : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlFileTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlTableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTableTypeColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlTableTypeCheckConstraint : ISqlModelElement
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
	public interface ISql100TSqlTableTypeColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql100TSqlTableTypeDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql100TSqlTableTypeIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql100TSqlTableTypePrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql100TSqlTableTypeUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql100TSqlTcpProtocolSpecifier : ISqlModelElement
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
	public interface ISql100TSqlUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql100TSqlUser : ISqlModelElement
	{		
		AuthenticationType AuthenticationType 
		{
			get;
		}
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlLogin> Login 
		{
			get;
		}
	}
	public interface ISql100TSqlUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql100TSqlUserDefinedType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlAssembly> Assembly 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlView : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql100TSqlWorkloadGroup : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlResourcePool> ResourcePool 
		{
			get;
		}
	}
	public interface ISql100TSqlXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlXmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql100TSqlSelectiveXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISql100TSqlXmlNamespace : ISqlModelElement
	{		
	}
	public interface ISql100TSqlPromotedNodePathForXQueryType : ISqlModelElement
	{		
	}
	public interface ISql100TSqlPromotedNodePathForSqlType : ISqlModelElement
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
	public interface ISql100TSqlXmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql100TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableValuedFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlScalarFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlAggregate : ISqlModelElement
	{		
		String ClassName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlApplicationRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlAssembly : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlAsymmetricKey : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlAuditAction : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlAuditActionGroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlAuditActionSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlBrokerPriority : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDataType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlCertificate : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlCheckConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTable> Host 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlClrTypeMethod : ISqlModelElement
	{		
		String MethodName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> ReturnType 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String ParameterName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlClrTypeProperty : ISqlModelElement
	{		
		String PropertyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> ClrType 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlColumnStoreIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlCredential : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlCryptographicProvider : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDatabaseAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDatabaseDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlDatabaseEncryptionKey : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDatabaseEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDatabaseOptions : ISqlModelElement
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
	public interface ISqlAzureTSqlDataCompressionOption : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlDefault : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlDmlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlEndpoint : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlErrorMessage : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlEventSession : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlEventSessionAction : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlEventSessionDefinitions : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlEventSessionSetting : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlEventSessionTarget : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlEventTypeSpecifier : ISqlModelElement
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
	public interface ISqlAzureTSqlExtendedProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlExtendedProperty : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSqlFile : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlFilegroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlForeignKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTable> Host 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlFullTextCatalog : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlFullTextIndex : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlFullTextIndexColumnSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlHttpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlLinkedServer : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlLinkedServerLogin : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlLogin : ISqlModelElement
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
	public interface ISqlAzureTSqlMasterKey : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlMessageType : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlPartitionFunction : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlPartitionScheme : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlPartitionValue : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlPermission : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> ExcludedColumns 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlPrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTable> Host 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlQueue : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlQueueEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlRemoteServiceBinding : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlResourceGovernor : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlResourcePool : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlRole> Role 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlRoute : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlRule : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlSearchProperty : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlSequence : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlServerAudit : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlServerAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlServerDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlServerEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlServerOptions : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlRole> Role 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlService : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSignature : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSignatureEncryptionMechanism : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSoapLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSoapMethodSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSpatialIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlStatistics : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
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
	public interface ISqlAzureTSqlParameter : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlSymmetricKey : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlSymmetricKeyPassword : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlSynonym : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlFileTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTableTypeColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableTypeCheckConstraint : ISqlModelElement
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
	public interface ISqlAzureTSqlTableTypeColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableTypeDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableTypeIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableTypePrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTableTypeUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlTcpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlTable> Host 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlUser : ISqlModelElement
	{		
		AuthenticationType AuthenticationType 
		{
			get;
		}
		Boolean WithoutLogin 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlLogin> Login 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlUserDefinedType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlAssembly> Assembly 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlView : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlWorkloadGroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlSelectiveXmlIndex : ISqlModelElement
	{		
		Boolean Disabled 
		{
			get;
		}
	}
	public interface ISqlAzureTSqlXmlNamespace : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlPromotedNodePathForXQueryType : ISqlModelElement
	{		
	}
	public interface ISqlAzureTSqlPromotedNodePathForSqlType : ISqlModelElement
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
	public interface ISqlAzureTSqlXmlSchemaCollection : ISqlModelElement
	{		
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureTSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110TSqlTableValuedFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlScalarFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlAggregate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql110TSqlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110TSqlAssembly : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql110TSqlAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql110TSqlAsymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
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
	public interface ISql110TSqlAuditAction : ISqlModelElement
	{		
		DatabaseAuditAction Action 
		{
			get;
		}
	}
	public interface ISql110TSqlAuditActionGroup : ISqlModelElement
	{		
		AuditActionGroupType ActionGroup 
		{
			get;
		}
	}
	public interface ISql110TSqlAuditActionSpecification : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAuditAction> AuditActions 
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
	public interface ISql110TSqlBrokerPriority : ISqlModelElement
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
	public interface ISql110TSqlBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql110TSqlDataType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql110TSqlCertificate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql110TSqlCheckConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql110TSqlClrTypeMethod : ISqlModelElement
	{		
		String MethodName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> ReturnType 
		{
			get;
		}
	}
	public interface ISql110TSqlClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String ParameterName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISql110TSqlClrTypeProperty : ISqlModelElement
	{		
		String PropertyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> ClrType 
		{
			get;
		}
	}
	public interface ISql110TSqlColumnStoreIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110TSqlContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlMessageType> Messages 
		{
			get;
		}
	}
	public interface ISql110TSqlCredential : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCryptographicProvider> CryptographicProvider 
		{
			get;
		}
	}
	public interface ISql110TSqlCryptographicProvider : ISqlModelElement
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
	public interface ISql110TSqlDatabaseAuditSpecification : ISqlModelElement
	{		
		Boolean WithState 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql110TSqlDatabaseDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlDatabaseEncryptionKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql110TSqlDatabaseEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql110TSqlDatabaseMirroringLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql110TSqlDatabaseOptions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> DefaultFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> DefaultFileStreamFilegroup 
		{
			get;
		}
	}
	public interface ISql110TSqlDataCompressionOption : ISqlModelElement
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
	public interface ISql110TSqlDefault : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql110TSqlDmlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlEndpoint : ISqlModelElement
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
	public interface ISql110TSqlErrorMessage : ISqlModelElement
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
	public interface ISql110TSqlEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql110TSqlEventSession : ISqlModelElement
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
	public interface ISql110TSqlEventSessionAction : ISqlModelElement
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
	public interface ISql110TSqlEventSessionDefinitions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlEventSessionAction> Actions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> AttributeSettings 
		{
			get;
		}
	}
	public interface ISql110TSqlEventSessionSetting : ISqlModelElement
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
	public interface ISql110TSqlEventSessionTarget : ISqlModelElement
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
	public interface ISql110TSqlEventTypeSpecifier : ISqlModelElement
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
	public interface ISql110TSqlExtendedProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlExtendedProperty : ISqlModelElement
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
	public interface ISql110TSqlSqlFile : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql110TSqlFilegroup : ISqlModelElement
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
	public interface ISql110TSqlForeignKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql110TSqlFullTextCatalog : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql110TSqlFullTextIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSearchPropertyList> SearchPropertyList 
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
	public interface ISql110TSqlFullTextIndexColumnSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> TypeColumn 
		{
			get;
		}
	}
	public interface ISql110TSqlFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110TSqlHttpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISql110TSqlLinkedServer : ISqlModelElement
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
	public interface ISql110TSqlLinkedServerLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> LocalLogin 
		{
			get;
		}
	}
	public interface ISql110TSqlLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCredential> Credential 
		{
			get;
		}
	}
	public interface ISql110TSqlMasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql110TSqlMessageType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110TSqlPartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> ParameterType 
		{
			get;
		}
	}
	public interface ISql110TSqlPartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql110TSqlPartitionValue : ISqlModelElement
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
	public interface ISql110TSqlPermission : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> ExcludedColumns 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql110TSqlPrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110TSqlProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlProcedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlQueue : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlProcedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlQueueEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql110TSqlRemoteServiceBinding : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlResourceGovernor : ISqlModelElement
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
	public interface ISql110TSqlResourcePool : ISqlModelElement
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
	public interface ISql110TSqlRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110TSqlRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql110TSqlRoute : ISqlModelElement
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
	public interface ISql110TSqlRule : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110TSqlSearchProperty : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSearchPropertyList> SearchPropertyList 
		{
			get;
		}
	}
	public interface ISql110TSqlSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110TSqlSequence : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> DataType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlServerAudit : ISqlModelElement
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
	public interface ISql110TSqlServerAuditSpecification : ISqlModelElement
	{		
		Boolean StateOn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql110TSqlServerDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql110TSqlServerEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql110TSqlServerOptions : ISqlModelElement
	{		
	}
	public interface ISql110TSqlServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql110TSqlService : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlContract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql110TSqlServiceBrokerLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql110TSqlSignature : ISqlModelElement
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
	public interface ISql110TSqlSignatureEncryptionMechanism : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql110TSqlSoapLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISql110TSqlSoapMethodSpecification : ISqlModelElement
	{		
	}
	public interface ISql110TSqlSpatialIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110TSqlStatistics : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
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
	public interface ISql110TSqlParameter : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110TSqlSymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> Certificates 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql110TSqlSymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql110TSqlSynonym : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlFileTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlTableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTableTypeColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlTableTypeCheckConstraint : ISqlModelElement
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
	public interface ISql110TSqlTableTypeColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql110TSqlTableTypeDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql110TSqlTableTypeIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql110TSqlTableTypePrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql110TSqlTableTypeUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql110TSqlTcpProtocolSpecifier : ISqlModelElement
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
	public interface ISql110TSqlUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql110TSqlUser : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlLogin> Login 
		{
			get;
		}
	}
	public interface ISql110TSqlUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql110TSqlUserDefinedType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlAssembly> Assembly 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlView : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql110TSqlWorkloadGroup : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlResourcePool> ResourcePool 
		{
			get;
		}
	}
	public interface ISql110TSqlXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlXmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql110TSqlSelectiveXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PrimaryPromotedPath 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSelectiveXmlIndex> PrimarySelectiveXmlIndex 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PromotedPaths 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlXmlNamespace> XmlNamespaces 
		{
			get;
		}
	}
	public interface ISql110TSqlXmlNamespace : ISqlModelElement
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
	public interface ISql110TSqlPromotedNodePathForXQueryType : ISqlModelElement
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
	public interface ISql110TSqlPromotedNodePathForSqlType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISql110TSqlXmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql110TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120TSqlTableValuedFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlScalarFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlAggregate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISql120TSqlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120TSqlAssembly : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISql120TSqlAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISql120TSqlAsymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
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
	public interface ISql120TSqlAuditAction : ISqlModelElement
	{		
		DatabaseAuditAction Action 
		{
			get;
		}
	}
	public interface ISql120TSqlAuditActionGroup : ISqlModelElement
	{		
		AuditActionGroupType ActionGroup 
		{
			get;
		}
	}
	public interface ISql120TSqlAuditActionSpecification : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAuditAction> AuditActions 
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
	public interface ISql120TSqlBrokerPriority : ISqlModelElement
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
	public interface ISql120TSqlBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISql120TSqlDataType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISql120TSqlCertificate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> ExistingKeysAssembly 
		{
			get;
		}
	}
	public interface ISql120TSqlCheckConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql120TSqlClrTypeMethod : ISqlModelElement
	{		
		String MethodName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> ReturnType 
		{
			get;
		}
	}
	public interface ISql120TSqlClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String ParameterName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISql120TSqlClrTypeProperty : ISqlModelElement
	{		
		String PropertyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> ClrType 
		{
			get;
		}
	}
	public interface ISql120TSqlColumnStoreIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120TSqlContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlMessageType> Messages 
		{
			get;
		}
	}
	public interface ISql120TSqlCredential : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCryptographicProvider> CryptographicProvider 
		{
			get;
		}
	}
	public interface ISql120TSqlCryptographicProvider : ISqlModelElement
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
	public interface ISql120TSqlDatabaseAuditSpecification : ISqlModelElement
	{		
		Boolean WithState 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAuditAction> AuditActions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql120TSqlDatabaseDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlDatabaseEncryptionKey : ISqlModelElement
	{		
		SymmetricKeyAlgorithm Algorithm 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql120TSqlDatabaseEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql120TSqlDatabaseMirroringLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql120TSqlDatabaseOptions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> DefaultFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> DefaultFileStreamFilegroup 
		{
			get;
		}
	}
	public interface ISql120TSqlDataCompressionOption : ISqlModelElement
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
	public interface ISql120TSqlDefault : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql120TSqlDmlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlEndpoint : ISqlModelElement
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
	public interface ISql120TSqlErrorMessage : ISqlModelElement
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
	public interface ISql120TSqlEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISql120TSqlEventSession : ISqlModelElement
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
	public interface ISql120TSqlEventSessionAction : ISqlModelElement
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
	public interface ISql120TSqlEventSessionDefinitions : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlEventSessionAction> Actions 
		{
			get;
		}
		//Composing
		IEnumerable<TSqlObject> AttributeSettings 
		{
			get;
		}
	}
	public interface ISql120TSqlEventSessionSetting : ISqlModelElement
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
	public interface ISql120TSqlEventSessionTarget : ISqlModelElement
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
	public interface ISql120TSqlEventTypeSpecifier : ISqlModelElement
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
	public interface ISql120TSqlExtendedProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlExtendedProperty : ISqlModelElement
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
	public interface ISql120TSqlSqlFile : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql120TSqlFilegroup : ISqlModelElement
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
	public interface ISql120TSqlForeignKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISql120TSqlFullTextCatalog : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISql120TSqlFullTextIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSearchPropertyList> SearchPropertyList 
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
	public interface ISql120TSqlFullTextIndexColumnSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> TypeColumn 
		{
			get;
		}
	}
	public interface ISql120TSqlFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120TSqlHttpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISql120TSqlLinkedServer : ISqlModelElement
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
	public interface ISql120TSqlLinkedServerLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLinkedServer> LinkedServer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> LocalLogin 
		{
			get;
		}
	}
	public interface ISql120TSqlLogin : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCredential> Credential 
		{
			get;
		}
	}
	public interface ISql120TSqlMasterKey : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql120TSqlMessageType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120TSqlPartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> ParameterType 
		{
			get;
		}
	}
	public interface ISql120TSqlPartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISql120TSqlPartitionValue : ISqlModelElement
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
	public interface ISql120TSqlPermission : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> ExcludedColumns 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISql120TSqlPrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120TSqlProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlProcedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlQueue : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlProcedure> ActivationProcedure 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlQueueEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql120TSqlRemoteServiceBinding : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlResourceGovernor : ISqlModelElement
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
	public interface ISql120TSqlResourcePool : ISqlModelElement
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
	public interface ISql120TSqlRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120TSqlRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql120TSqlRoute : ISqlModelElement
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
	public interface ISql120TSqlRule : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120TSqlSearchProperty : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSearchPropertyList> SearchPropertyList 
		{
			get;
		}
	}
	public interface ISql120TSqlSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120TSqlSequence : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> DataType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlServerAudit : ISqlModelElement
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
	public interface ISql120TSqlServerAuditSpecification : ISqlModelElement
	{		
		Boolean StateOn 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAuditActionGroup> AuditActionGroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlServerAudit> ServerAudit 
		{
			get;
		}
	}
	public interface ISql120TSqlServerDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlUser> User 
		{
			get;
		}
	}
	public interface ISql120TSqlServerEventNotification : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
	}
	public interface ISql120TSqlServerOptions : ISqlModelElement
	{		
	}
	public interface ISql120TSqlServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISql120TSqlService : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlContract> Contracts 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlQueue> Queue 
		{
			get;
		}
	}
	public interface ISql120TSqlServiceBrokerLanguageSpecifier : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> AuthenticationCertificate 
		{
			get;
		}
	}
	public interface ISql120TSqlSignature : ISqlModelElement
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
	public interface ISql120TSqlSignatureEncryptionMechanism : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> Certificate 
		{
			get;
		}
	}
	public interface ISql120TSqlSoapLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISql120TSqlSoapMethodSpecification : ISqlModelElement
	{		
	}
	public interface ISql120TSqlSpatialIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120TSqlStatistics : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
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
	public interface ISql120TSqlParameter : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120TSqlSymmetricKey : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAsymmetricKey> AsymmetricKeys 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> Certificates 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSymmetricKey> SymmetricKeys 
		{
			get;
		}
	}
	public interface ISql120TSqlSymmetricKeyPassword : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
	}
	public interface ISql120TSqlSynonym : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> FilegroupForTextImage 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlFileTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlTableType : ISqlModelElement
	{		
		Boolean MemoryOptimized 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTableTypeColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.TSqlTableTypeIndex> Indexes 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlTableTypeCheckConstraint : ISqlModelElement
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
	public interface ISql120TSqlTableTypeColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISql120TSqlTableTypeDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISql120TSqlTableTypeIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql120TSqlTableTypePrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql120TSqlTableTypeUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISql120TSqlTcpProtocolSpecifier : ISqlModelElement
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
	public interface ISql120TSqlUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlFilegroup> FileStreamFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> FileStreamPartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISql120TSqlUser : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAsymmetricKey> AsymmetricKey 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlCertificate> Certificate 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlLogin> Login 
		{
			get;
		}
	}
	public interface ISql120TSqlUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISql120TSqlUserDefinedType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlAssembly> Assembly 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlView : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISql120TSqlWorkloadGroup : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlResourcePool> ResourcePool 
		{
			get;
		}
	}
	public interface ISql120TSqlXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlXmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISql120TSqlSelectiveXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PrimaryPromotedPath 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSelectiveXmlIndex> PrimarySelectiveXmlIndex 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PromotedPaths 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlXmlNamespace> XmlNamespaces 
		{
			get;
		}
	}
	public interface ISql120TSqlXmlNamespace : ISqlModelElement
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
	public interface ISql120TSqlPromotedNodePathForXQueryType : ISqlModelElement
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
	public interface ISql120TSqlPromotedNodePathForSqlType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISql120TSqlXmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISql120TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlColumn : ISqlModelElement
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
		Boolean Sparse 
		{
			get;
		}
		XmlStyle XmlStyle 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableValuedFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> OrderColumns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlScalarFunction : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlAggregate : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> ReturnType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlApplicationRole : ISqlModelElement
	{		
		String Password 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> DefaultSchema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> IncludedColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlAssembly : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssemblySource> AssemblySources 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> ReferencedAssemblies 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlAssemblySource : ISqlModelElement
	{		
		String Source 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlAsymmetricKey : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlAuditAction : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlAuditActionGroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlAuditActionSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlBrokerPriority : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlBuiltInServerRole : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlDataType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<System.Type> Type 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlCertificate : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlCheckConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlClrTypeMethod : ISqlModelElement
	{		
		String MethodName 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlParameter> Parameters 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> ReturnType 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlClrTypeMethodParameter : ISqlModelElement
	{		
		Boolean IsOutput 
		{
			get;
		}
		String ParameterName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlClrTypeProperty : ISqlModelElement
	{		
		String PropertyName 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> ClrType 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlColumnStoreIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlContract : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlCredential : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlCryptographicProvider : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlDatabaseAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlDatabaseDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlDatabaseEncryptionKey : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlDatabaseEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlDatabaseMirroringLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlDatabaseOptions : ISqlModelElement
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
		Boolean CursorCloseOnCommit 
		{
			get;
		}
		Boolean DateCorrelationOptimizationOn 
		{
			get;
		}
		Boolean NumericRoundAbortOn 
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
		Boolean RecursiveTriggersOn 
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
	}
	public interface ISqlAzureV12TSqlDataCompressionOption : ISqlModelElement
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
	public interface ISqlAzureV12TSqlDefault : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlDmlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Hierarchical
		IEnumerable<TSqlObject> TriggerObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlEndpoint : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlErrorMessage : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlEventGroup : ISqlModelElement
	{		
		EventGroupType Group 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlEventSession : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlEventSessionAction : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlEventSessionDefinitions : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlEventSessionSetting : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlEventSessionTarget : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlEventTypeSpecifier : ISqlModelElement
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
	public interface ISqlAzureV12TSqlExtendedProcedure : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlParameter> Parameters 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlExtendedProperty : ISqlModelElement
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
	public interface ISqlAzureV12TSqlSqlFile : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlFilegroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlForeignKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> ForeignColumns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTable> ForeignTable 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTable> Host 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlFullTextCatalog : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlFullTextIndex : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlFullTextIndexColumnSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlFullTextStopList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlHttpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlLinkedServer : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlLinkedServerLogin : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlLogin : ISqlModelElement
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
	public interface ISqlAzureV12TSqlMasterKey : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlMessageType : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlPartitionFunction : ISqlModelElement
	{		
		PartitionRange Range 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionValue> BoundaryValues 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> ParameterType 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlPartitionScheme : ISqlModelElement
	{		
		Boolean AllToOneFilegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroups 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionFunction> PartitionFunction 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlPartitionValue : ISqlModelElement
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
	public interface ISqlAzureV12TSqlPermission : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> ExcludedColumns 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> RevokedGrantOptionColumns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlPrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlProcedure : ISqlModelElement
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
		Boolean WithEncryption 
		{
			get;
		}
		Boolean WithRecompile 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlParameter> Parameters 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlProcedure> ParentProcedure 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlQueue : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlQueueEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlRemoteServiceBinding : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlResourceGovernor : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlResourcePool : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlRoute : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlRule : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlSchema : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlSearchProperty : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSearchPropertyList : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlSequence : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> DataType 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlServerAudit : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlServerAuditSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlServerDdlTrigger : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> BodyDependencies 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlEventGroup> EventGroup 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlUser> User 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlServerEventNotification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlServerOptions : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlServerRoleMembership : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlRole> Role 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlService : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlServiceBrokerLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSignature : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSignatureEncryptionMechanism : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSoapLanguageSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSoapMethodSpecification : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSpatialIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Column 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlStatistics : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
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
	public interface ISqlAzureV12TSqlParameter : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlSymmetricKey : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlSymmetricKeyPassword : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlSynonym : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTable : ISqlModelElement
	{		
		Boolean? AnsiNullsOn 
		{
			get;
		}
		Boolean ChangeTrackingEnabled 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlFileTable : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableType : ISqlModelElement
	{		
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTableTypeColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.TSqlTableTypeIndex> Indexes 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableTypeCheckConstraint : ISqlModelElement
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
	public interface ISqlAzureV12TSqlTableTypeColumn : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> DataType 
		{
			get;
		}
		//Peer
		IEnumerable<TSqlObject> ExpressionDependencies 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlXmlSchemaCollection> XmlSchemaCollection 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableTypeDefaultConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> TargetColumn 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableTypeIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableTypePrimaryKeyConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTableTypeUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlTcpProtocolSpecifier : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlUniqueConstraint : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataCompressionOption> DataCompressionOptions 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlFilegroup> Filegroup 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlTable> Host 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> PartitionColumn 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlPartitionScheme> PartitionScheme 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlUser : ISqlModelElement
	{		
		AuthenticationType AuthenticationType 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> DefaultSchema 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlLogin> Login 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlUserDefinedServerRole : ISqlModelElement
	{		
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlUserDefinedType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlAssembly> Assembly 
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlView : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Columns 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlWorkloadGroup : ISqlModelElement
	{		
	}
	public interface ISqlAzureV12TSqlXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlXmlIndex> PrimaryXmlIndex 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlSelectiveXmlIndex : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlColumn> Column 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISpecifiesIndex> IndexedObject 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PrimaryPromotedPath 
		{
			get;
		}
		//Peer
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSelectiveXmlIndex> PrimarySelectiveXmlIndex 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PromotedPaths 
		{
			get;
		}
		//Composing
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlXmlNamespace> XmlNamespaces 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlXmlNamespace : ISqlModelElement
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
	public interface ISqlAzureV12TSqlPromotedNodePathForXQueryType : ISqlModelElement
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
	public interface ISqlAzureV12TSqlPromotedNodePathForSqlType : ISqlModelElement
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
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlDataType> DataType 
		{
			get;
		}
	}
	public interface ISqlAzureV12TSqlXmlSchemaCollection : ISqlModelElement
	{		
		String Expression 
		{
			get;
		}
		//Hierarchical
		IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlAzureV12TSqlSchema> Schema 
		{
			get;
		}
	}
}