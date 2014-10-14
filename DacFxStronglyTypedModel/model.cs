
namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
	using System;
	using System.Linq;
	using Microsoft.SqlServer.Server;
	using Microsoft.SqlServer.Dac.Model;
	using System.Collections.Generic;
public partial class TSqlModelElement
{
	///<summary>
	///  Returns a strongly typed wrapper for the TSqlObject instance.
	///</summary>
	public static TSqlModelElement AdaptInstance(TSqlObject obj)
    {
		if(obj == null)
		{
			throw new ArgumentNullException("obj");
		}
		else if(obj.ObjectType == Column.TypeClass)
        {
            return new Column(obj);
        }
		else if(obj.ObjectType == TableValuedFunction.TypeClass)
        {
            return new TableValuedFunction(obj);
        }
		else if(obj.ObjectType == ScalarFunction.TypeClass)
        {
            return new ScalarFunction(obj);
        }
		else if(obj.ObjectType == Aggregate.TypeClass)
        {
            return new Aggregate(obj);
        }
		else if(obj.ObjectType == ApplicationRole.TypeClass)
        {
            return new ApplicationRole(obj);
        }
		else if(obj.ObjectType == Index.TypeClass)
        {
            return new Index(obj);
        }
		else if(obj.ObjectType == Assembly.TypeClass)
        {
            return new Assembly(obj);
        }
		else if(obj.ObjectType == AssemblySource.TypeClass)
        {
            return new AssemblySource(obj);
        }
		else if(obj.ObjectType == AsymmetricKey.TypeClass)
        {
            return new AsymmetricKey(obj);
        }
		else if(obj.ObjectType == AuditAction.TypeClass)
        {
            return new AuditAction(obj);
        }
		else if(obj.ObjectType == AuditActionGroup.TypeClass)
        {
            return new AuditActionGroup(obj);
        }
		else if(obj.ObjectType == AuditActionSpecification.TypeClass)
        {
            return new AuditActionSpecification(obj);
        }
		else if(obj.ObjectType == BrokerPriority.TypeClass)
        {
            return new BrokerPriority(obj);
        }
		else if(obj.ObjectType == BuiltInServerRole.TypeClass)
        {
            return new BuiltInServerRole(obj);
        }
		else if(obj.ObjectType == DataType.TypeClass)
        {
            return new DataType(obj);
        }
		else if(obj.ObjectType == Certificate.TypeClass)
        {
            return new Certificate(obj);
        }
		else if(obj.ObjectType == CheckConstraint.TypeClass)
        {
            return new CheckConstraint(obj);
        }
		else if(obj.ObjectType == ClrTypeMethod.TypeClass)
        {
            return new ClrTypeMethod(obj);
        }
		else if(obj.ObjectType == ClrTypeMethodParameter.TypeClass)
        {
            return new ClrTypeMethodParameter(obj);
        }
		else if(obj.ObjectType == ClrTypeProperty.TypeClass)
        {
            return new ClrTypeProperty(obj);
        }
		else if(obj.ObjectType == ColumnStoreIndex.TypeClass)
        {
            return new ColumnStoreIndex(obj);
        }
		else if(obj.ObjectType == Contract.TypeClass)
        {
            return new Contract(obj);
        }
		else if(obj.ObjectType == Credential.TypeClass)
        {
            return new Credential(obj);
        }
		else if(obj.ObjectType == CryptographicProvider.TypeClass)
        {
            return new CryptographicProvider(obj);
        }
		else if(obj.ObjectType == DatabaseAuditSpecification.TypeClass)
        {
            return new DatabaseAuditSpecification(obj);
        }
		else if(obj.ObjectType == DatabaseDdlTrigger.TypeClass)
        {
            return new DatabaseDdlTrigger(obj);
        }
		else if(obj.ObjectType == DatabaseEncryptionKey.TypeClass)
        {
            return new DatabaseEncryptionKey(obj);
        }
		else if(obj.ObjectType == DatabaseEventNotification.TypeClass)
        {
            return new DatabaseEventNotification(obj);
        }
		else if(obj.ObjectType == DatabaseMirroringLanguageSpecifier.TypeClass)
        {
            return new DatabaseMirroringLanguageSpecifier(obj);
        }
		else if(obj.ObjectType == DatabaseOptions.TypeClass)
        {
            return new DatabaseOptions(obj);
        }
		else if(obj.ObjectType == DataCompressionOption.TypeClass)
        {
            return new DataCompressionOption(obj);
        }
		else if(obj.ObjectType == Default.TypeClass)
        {
            return new Default(obj);
        }
		else if(obj.ObjectType == DefaultConstraint.TypeClass)
        {
            return new DefaultConstraint(obj);
        }
		else if(obj.ObjectType == DmlTrigger.TypeClass)
        {
            return new DmlTrigger(obj);
        }
		else if(obj.ObjectType == Endpoint.TypeClass)
        {
            return new Endpoint(obj);
        }
		else if(obj.ObjectType == ErrorMessage.TypeClass)
        {
            return new ErrorMessage(obj);
        }
		else if(obj.ObjectType == EventGroup.TypeClass)
        {
            return new EventGroup(obj);
        }
		else if(obj.ObjectType == EventSession.TypeClass)
        {
            return new EventSession(obj);
        }
		else if(obj.ObjectType == EventSessionAction.TypeClass)
        {
            return new EventSessionAction(obj);
        }
		else if(obj.ObjectType == EventSessionDefinitions.TypeClass)
        {
            return new EventSessionDefinitions(obj);
        }
		else if(obj.ObjectType == EventSessionSetting.TypeClass)
        {
            return new EventSessionSetting(obj);
        }
		else if(obj.ObjectType == EventSessionTarget.TypeClass)
        {
            return new EventSessionTarget(obj);
        }
		else if(obj.ObjectType == EventTypeSpecifier.TypeClass)
        {
            return new EventTypeSpecifier(obj);
        }
		else if(obj.ObjectType == ExtendedProcedure.TypeClass)
        {
            return new ExtendedProcedure(obj);
        }
		else if(obj.ObjectType == ExtendedProperty.TypeClass)
        {
            return new ExtendedProperty(obj);
        }
		else if(obj.ObjectType == SqlFile.TypeClass)
        {
            return new SqlFile(obj);
        }
		else if(obj.ObjectType == Filegroup.TypeClass)
        {
            return new Filegroup(obj);
        }
		else if(obj.ObjectType == ForeignKeyConstraint.TypeClass)
        {
            return new ForeignKeyConstraint(obj);
        }
		else if(obj.ObjectType == FullTextCatalog.TypeClass)
        {
            return new FullTextCatalog(obj);
        }
		else if(obj.ObjectType == FullTextIndex.TypeClass)
        {
            return new FullTextIndex(obj);
        }
		else if(obj.ObjectType == FullTextIndexColumnSpecifier.TypeClass)
        {
            return new FullTextIndexColumnSpecifier(obj);
        }
		else if(obj.ObjectType == FullTextStopList.TypeClass)
        {
            return new FullTextStopList(obj);
        }
		else if(obj.ObjectType == HttpProtocolSpecifier.TypeClass)
        {
            return new HttpProtocolSpecifier(obj);
        }
		else if(obj.ObjectType == LinkedServer.TypeClass)
        {
            return new LinkedServer(obj);
        }
		else if(obj.ObjectType == LinkedServerLogin.TypeClass)
        {
            return new LinkedServerLogin(obj);
        }
		else if(obj.ObjectType == Login.TypeClass)
        {
            return new Login(obj);
        }
		else if(obj.ObjectType == MasterKey.TypeClass)
        {
            return new MasterKey(obj);
        }
		else if(obj.ObjectType == MessageType.TypeClass)
        {
            return new MessageType(obj);
        }
		else if(obj.ObjectType == PartitionFunction.TypeClass)
        {
            return new PartitionFunction(obj);
        }
		else if(obj.ObjectType == PartitionScheme.TypeClass)
        {
            return new PartitionScheme(obj);
        }
		else if(obj.ObjectType == PartitionValue.TypeClass)
        {
            return new PartitionValue(obj);
        }
		else if(obj.ObjectType == Permission.TypeClass)
        {
            return new Permission(obj);
        }
		else if(obj.ObjectType == PrimaryKeyConstraint.TypeClass)
        {
            return new PrimaryKeyConstraint(obj);
        }
		else if(obj.ObjectType == Procedure.TypeClass)
        {
            return new Procedure(obj);
        }
		else if(obj.ObjectType == Queue.TypeClass)
        {
            return new Queue(obj);
        }
		else if(obj.ObjectType == QueueEventNotification.TypeClass)
        {
            return new QueueEventNotification(obj);
        }
		else if(obj.ObjectType == RemoteServiceBinding.TypeClass)
        {
            return new RemoteServiceBinding(obj);
        }
		else if(obj.ObjectType == ResourceGovernor.TypeClass)
        {
            return new ResourceGovernor(obj);
        }
		else if(obj.ObjectType == ResourcePool.TypeClass)
        {
            return new ResourcePool(obj);
        }
		else if(obj.ObjectType == Role.TypeClass)
        {
            return new Role(obj);
        }
		else if(obj.ObjectType == RoleMembership.TypeClass)
        {
            return new RoleMembership(obj);
        }
		else if(obj.ObjectType == Route.TypeClass)
        {
            return new Route(obj);
        }
		else if(obj.ObjectType == Rule.TypeClass)
        {
            return new Rule(obj);
        }
		else if(obj.ObjectType == Schema.TypeClass)
        {
            return new Schema(obj);
        }
		else if(obj.ObjectType == SearchProperty.TypeClass)
        {
            return new SearchProperty(obj);
        }
		else if(obj.ObjectType == SearchPropertyList.TypeClass)
        {
            return new SearchPropertyList(obj);
        }
		else if(obj.ObjectType == Sequence.TypeClass)
        {
            return new Sequence(obj);
        }
		else if(obj.ObjectType == ServerAudit.TypeClass)
        {
            return new ServerAudit(obj);
        }
		else if(obj.ObjectType == ServerAuditSpecification.TypeClass)
        {
            return new ServerAuditSpecification(obj);
        }
		else if(obj.ObjectType == ServerDdlTrigger.TypeClass)
        {
            return new ServerDdlTrigger(obj);
        }
		else if(obj.ObjectType == ServerEventNotification.TypeClass)
        {
            return new ServerEventNotification(obj);
        }
		else if(obj.ObjectType == ServerOptions.TypeClass)
        {
            return new ServerOptions(obj);
        }
		else if(obj.ObjectType == ServerRoleMembership.TypeClass)
        {
            return new ServerRoleMembership(obj);
        }
		else if(obj.ObjectType == Service.TypeClass)
        {
            return new Service(obj);
        }
		else if(obj.ObjectType == ServiceBrokerLanguageSpecifier.TypeClass)
        {
            return new ServiceBrokerLanguageSpecifier(obj);
        }
		else if(obj.ObjectType == Signature.TypeClass)
        {
            return new Signature(obj);
        }
		else if(obj.ObjectType == SignatureEncryptionMechanism.TypeClass)
        {
            return new SignatureEncryptionMechanism(obj);
        }
		else if(obj.ObjectType == SoapLanguageSpecifier.TypeClass)
        {
            return new SoapLanguageSpecifier(obj);
        }
		else if(obj.ObjectType == SoapMethodSpecification.TypeClass)
        {
            return new SoapMethodSpecification(obj);
        }
		else if(obj.ObjectType == SpatialIndex.TypeClass)
        {
            return new SpatialIndex(obj);
        }
		else if(obj.ObjectType == Statistics.TypeClass)
        {
            return new Statistics(obj);
        }
		else if(obj.ObjectType == Parameter.TypeClass)
        {
            return new Parameter(obj);
        }
		else if(obj.ObjectType == SymmetricKey.TypeClass)
        {
            return new SymmetricKey(obj);
        }
		else if(obj.ObjectType == SymmetricKeyPassword.TypeClass)
        {
            return new SymmetricKeyPassword(obj);
        }
		else if(obj.ObjectType == Synonym.TypeClass)
        {
            return new Synonym(obj);
        }
		else if(obj.ObjectType == Table.TypeClass)
        {
            return new Table(obj);
        }
		else if(obj.ObjectType == FileTable.TypeClass)
        {
            return new FileTable(obj);
        }
		else if(obj.ObjectType == TableType.TypeClass)
        {
            return new TableType(obj);
        }
		else if(obj.ObjectType == TableTypeCheckConstraint.TypeClass)
        {
            return new TableTypeCheckConstraint(obj);
        }
		else if(obj.ObjectType == TableTypeColumn.TypeClass)
        {
            return new TableTypeColumn(obj);
        }
		else if(obj.ObjectType == TableTypeDefaultConstraint.TypeClass)
        {
            return new TableTypeDefaultConstraint(obj);
        }
		else if(obj.ObjectType == TableTypeIndex.TypeClass)
        {
            return new TableTypeIndex(obj);
        }
		else if(obj.ObjectType == TableTypePrimaryKeyConstraint.TypeClass)
        {
            return new TableTypePrimaryKeyConstraint(obj);
        }
		else if(obj.ObjectType == TableTypeUniqueConstraint.TypeClass)
        {
            return new TableTypeUniqueConstraint(obj);
        }
		else if(obj.ObjectType == TcpProtocolSpecifier.TypeClass)
        {
            return new TcpProtocolSpecifier(obj);
        }
		else if(obj.ObjectType == UniqueConstraint.TypeClass)
        {
            return new UniqueConstraint(obj);
        }
		else if(obj.ObjectType == User.TypeClass)
        {
            return new User(obj);
        }
		else if(obj.ObjectType == UserDefinedServerRole.TypeClass)
        {
            return new UserDefinedServerRole(obj);
        }
		else if(obj.ObjectType == UserDefinedType.TypeClass)
        {
            return new UserDefinedType(obj);
        }
		else if(obj.ObjectType == View.TypeClass)
        {
            return new View(obj);
        }
		else if(obj.ObjectType == WorkloadGroup.TypeClass)
        {
            return new WorkloadGroup(obj);
        }
		else if(obj.ObjectType == XmlIndex.TypeClass)
        {
            return new XmlIndex(obj);
        }
		else if(obj.ObjectType == SelectiveXmlIndex.TypeClass)
        {
            return new SelectiveXmlIndex(obj);
        }
		else if(obj.ObjectType == XmlNamespace.TypeClass)
        {
            return new XmlNamespace(obj);
        }
		else if(obj.ObjectType == PromotedNodePathForXQueryType.TypeClass)
        {
            return new PromotedNodePathForXQueryType(obj);
        }
		else if(obj.ObjectType == PromotedNodePathForSqlType.TypeClass)
        {
            return new PromotedNodePathForSqlType(obj);
        }
		else if(obj.ObjectType == XmlSchemaCollection.TypeClass)
        {
            return new XmlSchemaCollection(obj);
        }
		else
		{
			throw new ArgumentException("No type mapping exists for " + obj.ObjectType.Name);
		}
	}
}
	public partial class Column : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Column.TypeClass;

		/// <summary>
		///	Create a strongly typed class Column to adapt the TSqlObject 
		/// </summary>
		public Column(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Collation 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Column.Collation);}
		}

		public String Expression 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Column.Expression);}
		}

		public String IdentityIncrement 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Column.IdentityIncrement);}
		}

		public String IdentitySeed 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Column.IdentitySeed);}
		}

		public Boolean IsFileStream 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.IsFileStream);}
		}

		public Boolean IsIdentity 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.IsIdentity);}
		}

		public Boolean IsIdentityNotForReplication 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.IsIdentityNotForReplication);}
		}

		public Boolean IsMax 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.IsMax);}
		}

		public Boolean IsRowGuidCol 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.IsRowGuidCol);}
		}

		public Int32 Length 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Column.Length);}
		}

		public Boolean Nullable 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.Nullable);}
		}

		public Boolean Persisted 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.Persisted);}
		}

		public Boolean? PersistedNullable 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Column.PersistedNullable);}
		}

		public Int32 Precision 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Column.Precision);}
		}

		public Int32 Scale 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Column.Scale);}
		}

		public Boolean Sparse 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Column.Sparse);}
		}

		public XmlStyle XmlStyle 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<XmlStyle>(Microsoft.SqlServer.Dac.Model.Column.XmlStyle);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataType> DataType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Column.DataType).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataType)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Column.ExpressionDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection> XmlSchemaCollection 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Column.XmlSchemaCollection).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableValuedFunction : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableValuedFunction.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableValuedFunction to adapt the TSqlObject 
		/// </summary>
		public TableValuedFunction(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.AnsiNullsOn);}
		}

		public Boolean CalledOnNullInput 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.CalledOnNullInput);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ClassName);}
		}

		public DataAccessKind? DataAccess 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<DataAccessKind?>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.DataAccess);}
		}

		public Boolean? Deterministic 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.Deterministic);}
		}

		public Boolean ExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ExecuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ExecuteAsSelf);}
		}

		public String FillRowMethodName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.FillRowMethodName);}
		}

		public Boolean IsReplicated 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.IsReplicated);}
		}

		public String MethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.MethodName);}
		}

		public Boolean? Precise 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.Precise);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.QuotedIdentifierOn);}
		}

		public Boolean ReturnsNullOnNullInput 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ReturnsNullOnNullInput);}
		}

		public String ReturnTableVariableName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ReturnTableVariableName);}
		}

		public SystemDataAccessKind? SystemDataAccess 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SystemDataAccessKind?>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.SystemDataAccess);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.WithEncryption);}
		}

		public Boolean WithSchemaBinding 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableValuedFunction.WithSchemaBinding);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.BodyDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> OrderColumns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.OrderColumns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter> Parameters 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.Parameters).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.ReturnType).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase>();
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableValuedFunction.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ScalarFunction : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ScalarFunction.TypeClass;

		/// <summary>
		///	Create a strongly typed class ScalarFunction to adapt the TSqlObject 
		/// </summary>
		public ScalarFunction(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ScalarFunction.AnsiNullsOn);}
		}

		public Boolean CalledOnNullInput 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.CalledOnNullInput);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ScalarFunction.ClassName);}
		}

		public DataAccessKind? DataAccess 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<DataAccessKind?>(Microsoft.SqlServer.Dac.Model.ScalarFunction.DataAccess);}
		}

		public Boolean? Deterministic 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ScalarFunction.Deterministic);}
		}

		public Boolean ExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.ExecuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.ExecuteAsSelf);}
		}

		public String FillRowMethodName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ScalarFunction.FillRowMethodName);}
		}

		public Boolean IsReplicated 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.IsReplicated);}
		}

		public String MethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ScalarFunction.MethodName);}
		}

		public Boolean? Precise 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ScalarFunction.Precise);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ScalarFunction.QuotedIdentifierOn);}
		}

		public Boolean ReturnsNullOnNullInput 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.ReturnsNullOnNullInput);}
		}

		public SystemDataAccessKind? SystemDataAccess 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SystemDataAccessKind?>(Microsoft.SqlServer.Dac.Model.ScalarFunction.SystemDataAccess);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.WithEncryption);}
		}

		public Boolean WithSchemaBinding 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ScalarFunction.WithSchemaBinding);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.BodyDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter> Parameters 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.Parameters).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.ReturnType).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase>();
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ScalarFunction.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Aggregate : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Aggregate.TypeClass;

		/// <summary>
		///	Create a strongly typed class Aggregate to adapt the TSqlObject 
		/// </summary>
		public Aggregate(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Aggregate.ClassName);}
		}

		public Format Format 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Format>(Microsoft.SqlServer.Dac.Model.Aggregate.Format);}
		}

		public Boolean? InvariantToDuplicates 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Aggregate.InvariantToDuplicates);}
		}

		public Boolean? InvariantToNulls 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Aggregate.InvariantToNulls);}
		}

		public Int32? MaxByteSize 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.Aggregate.MaxByteSize);}
		}

		public Boolean? NullIfEmpty 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Aggregate.NullIfEmpty);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Aggregate.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter> Parameters 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Aggregate.Parameters).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Aggregate.ReturnType).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase>();
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Aggregate.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ApplicationRole : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ApplicationRole.TypeClass;

		/// <summary>
		///	Create a strongly typed class ApplicationRole to adapt the TSqlObject 
		/// </summary>
		public ApplicationRole(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Password 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ApplicationRole.Password);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> DefaultSchema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ApplicationRole.DefaultSchema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Index : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Index.TypeClass;

		/// <summary>
		///	Create a strongly typed class Index to adapt the TSqlObject 
		/// </summary>
		public Index(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowPageLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.AllowPageLocks);}
		}

		public Boolean AllowRowLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.AllowRowLocks);}
		}

		public Int32? BucketCount 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.Index.BucketCount);}
		}

		public Boolean Clustered 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.Clustered);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.Disabled);}
		}

		public Boolean? FileStreamNull 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Index.FileStreamNull);}
		}

		public Int32? FillFactor 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.Index.FillFactor);}
		}

		public String FilterPredicate 
		{
		// Supported platforms = 30
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Index.FilterPredicate);}
		}

		public Boolean Hash 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.Hash);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.IgnoreDuplicateKey);}
		}

		public Boolean IncrementalStatistics 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.IncrementalStatistics);}
		}

		public Boolean RecomputeStatistics 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.RecomputeStatistics);}
		}

		public Boolean Unique 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.Unique);}
		}

		public Boolean WithPadIndex 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Index.WithPadIndex);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.BodyDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption> DataCompressionOptions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.DataCompressionOptions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> FileStreamFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.FileStreamFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> FileStreamPartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.FileStreamPartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> IncludedColumns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.IncludedColumns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.IndexedObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Index.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Assembly : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Assembly.TypeClass;

		/// <summary>
		///	Create a strongly typed class Assembly to adapt the TSqlObject 
		/// </summary>
		public Assembly(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public AssemblyPermissionSet PermissionSet 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<AssemblyPermissionSet>(Microsoft.SqlServer.Dac.Model.Assembly.PermissionSet);}
		}

		public Boolean Visible 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Assembly.Visible);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AssemblySource> AssemblySources 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Assembly.AssemblySources).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AssemblySource)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Assembly.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> ReferencedAssemblies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Assembly.ReferencedAssemblies).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class AssemblySource : TSqlModelElement
	{
		private static ModelTypeClass typeClass = AssemblySource.TypeClass;

		/// <summary>
		///	Create a strongly typed class AssemblySource to adapt the TSqlObject 
		/// </summary>
		public AssemblySource(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Source 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.AssemblySource.Source);}
		}


}
	public partial class AsymmetricKey : TSqlModelElement
	{
		private static ModelTypeClass typeClass = AsymmetricKey.TypeClass;

		/// <summary>
		///	Create a strongly typed class AsymmetricKey to adapt the TSqlObject 
		/// </summary>
		public AsymmetricKey(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public AsymmetricKeyAlgorithm Algorithm 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<AsymmetricKeyAlgorithm>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.Algorithm);}
		}

		public SymmetricKeyCreationDisposition CreationDisposition 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<SymmetricKeyCreationDisposition>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.CreationDisposition);}
		}

		public Boolean EncryptedWithPassword 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.EncryptedWithPassword);}
		}

		public String ExecutableFile 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.ExecutableFile);}
		}

		public String File 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.File);}
		}

		public String Password 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.Password);}
		}

		public String ProviderKeyName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.AsymmetricKey.ProviderKeyName);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.AsymmetricKey.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.AsymmetricKey.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> Provider 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.AsymmetricKey.Provider);
			}
		}
	
}
	public partial class AuditAction : TSqlModelElement
	{
		private static ModelTypeClass typeClass = AuditAction.TypeClass;

		/// <summary>
		///	Create a strongly typed class AuditAction to adapt the TSqlObject 
		/// </summary>
		public AuditAction(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public DatabaseAuditAction Action 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<DatabaseAuditAction>(Microsoft.SqlServer.Dac.Model.AuditAction.Action);}
		}


}
	public partial class AuditActionGroup : TSqlModelElement
	{
		private static ModelTypeClass typeClass = AuditActionGroup.TypeClass;

		/// <summary>
		///	Create a strongly typed class AuditActionGroup to adapt the TSqlObject 
		/// </summary>
		public AuditActionGroup(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public AuditActionGroupType ActionGroup 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<AuditActionGroupType>(Microsoft.SqlServer.Dac.Model.AuditActionGroup.ActionGroup);}
		}


}
	public partial class AuditActionSpecification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = AuditActionSpecification.TypeClass;

		/// <summary>
		///	Create a strongly typed class AuditActionSpecification to adapt the TSqlObject 
		/// </summary>
		public AuditActionSpecification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AuditAction> AuditActions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.AuditActionSpecification.AuditActions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AuditAction)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Principals 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.AuditActionSpecification.Principals).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.AuditActionSpecification.SecuredObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable>();
			}
		}
	
}
	public partial class BrokerPriority : TSqlModelElement
	{
		private static ModelTypeClass typeClass = BrokerPriority.TypeClass;

		/// <summary>
		///	Create a strongly typed class BrokerPriority to adapt the TSqlObject 
		/// </summary>
		public BrokerPriority(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32 PriorityLevel 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.BrokerPriority.PriorityLevel);}
		}

		public String RemoteServiceName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.BrokerPriority.RemoteServiceName);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ContractName 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.BrokerPriority.ContractName);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> LocalServiceName 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.BrokerPriority.LocalServiceName);
			}
		}
	
}
	public partial class BuiltInServerRole : TSqlModelElement
	{
		private static ModelTypeClass typeClass = BuiltInServerRole.TypeClass;

		/// <summary>
		///	Create a strongly typed class BuiltInServerRole to adapt the TSqlObject 
		/// </summary>
		public BuiltInServerRole(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}

}
	public partial class DataType : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DataType.TypeClass;

		/// <summary>
		///	Create a strongly typed class DataType to adapt the TSqlObject 
		/// </summary>
		public DataType(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public SqlDataType SqlDataType 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<SqlDataType>(Microsoft.SqlServer.Dac.Model.DataType.SqlDataType);}
		}

		public Boolean UddtIsMax 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DataType.UddtIsMax);}
		}

		public Int32 UddtLength 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DataType.UddtLength);}
		}

		public Boolean UddtNullable 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DataType.UddtNullable);}
		}

		public Int32 UddtPrecision 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DataType.UddtPrecision);}
		}

		public Int32 UddtScale 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DataType.UddtScale);}
		}

		//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DataType.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<System.Type> Type 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DataType.Type).Cast<System.Type>();
			}
		}
	
}
	public partial class Certificate : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Certificate.TypeClass;

		/// <summary>
		///	Create a strongly typed class Certificate to adapt the TSqlObject 
		/// </summary>
		public Certificate(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean ActiveForBeginDialog 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Certificate.ActiveForBeginDialog);}
		}

		public Boolean EncryptedWithPassword 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Certificate.EncryptedWithPassword);}
		}

		public String EncryptionPassword 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.EncryptionPassword);}
		}

		public String ExistingKeysFilePath 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.ExistingKeysFilePath);}
		}

		public String ExpiryDate 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.ExpiryDate);}
		}

		public Boolean IsExistingKeyFileExecutable 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Certificate.IsExistingKeyFileExecutable);}
		}

		public String PrivateKeyDecryptionPassword 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.PrivateKeyDecryptionPassword);}
		}

		public String PrivateKeyEncryptionPassword 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.PrivateKeyEncryptionPassword);}
		}

		public String PrivateKeyFilePath 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.PrivateKeyFilePath);}
		}

		public String StartDate 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.StartDate);}
		}

		public String Subject 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Certificate.Subject);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Certificate.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> ExistingKeysAssembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Certificate.ExistingKeysAssembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class CheckConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = CheckConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class CheckConstraint to adapt the TSqlObject 
		/// </summary>
		public CheckConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.CheckConstraint.Disabled);}
		}

		public String Expression 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.CheckConstraint.Expression);}
		}

		public Boolean NotForReplication 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.CheckConstraint.NotForReplication);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.CheckConstraint.ExpressionDependencies);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty> Host 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.CheckConstraint.Host).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ClrTypeMethod : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ClrTypeMethod.TypeClass;

		/// <summary>
		///	Create a strongly typed class ClrTypeMethod to adapt the TSqlObject 
		/// </summary>
		public ClrTypeMethod(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Name 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ClrTypeMethod.Name);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter> Parameters 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ClrTypeMethod.Parameters).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ReturnType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ClrTypeMethod.ReturnType).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase>();
			}
		}
	
}
	public partial class ClrTypeMethodParameter : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ClrTypeMethodParameter.TypeClass;

		/// <summary>
		///	Create a strongly typed class ClrTypeMethodParameter to adapt the TSqlObject 
		/// </summary>
		public ClrTypeMethodParameter(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean IsOutput 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ClrTypeMethodParameter.IsOutput);}
		}

		public String Name 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ClrTypeMethodParameter.Name);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataType> DataType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ClrTypeMethodParameter.DataType).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataType)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ClrTypeProperty : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ClrTypeProperty.TypeClass;

		/// <summary>
		///	Create a strongly typed class ClrTypeProperty to adapt the TSqlObject 
		/// </summary>
		public ClrTypeProperty(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Name 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ClrTypeProperty.Name);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ClrType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ClrTypeProperty.ClrType).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase>();
			}
		}
	
}
	public partial class ColumnStoreIndex : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ColumnStoreIndex.TypeClass;

		/// <summary>
		///	Create a strongly typed class ColumnStoreIndex to adapt the TSqlObject 
		/// </summary>
		public ColumnStoreIndex(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean Clustered 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.Clustered);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.Disabled);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption> DataCompressionOptions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.DataCompressionOptions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.IndexedObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ColumnStoreIndex.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Contract : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Contract.TypeClass;

		/// <summary>
		///	Create a strongly typed class Contract to adapt the TSqlObject 
		/// </summary>
		public Contract(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Contract.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.MessageType> Messages 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Contract.Messages).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.MessageType)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Credential : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Credential.TypeClass;

		/// <summary>
		///	Create a strongly typed class Credential to adapt the TSqlObject 
		/// </summary>
		public Credential(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Identity 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Credential.Identity);}
		}

		public String Secret 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Credential.Secret);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.CryptographicProvider> CryptographicProvider 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Credential.CryptographicProvider).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.CryptographicProvider)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class CryptographicProvider : TSqlModelElement
	{
		private static ModelTypeClass typeClass = CryptographicProvider.TypeClass;

		/// <summary>
		///	Create a strongly typed class CryptographicProvider to adapt the TSqlObject 
		/// </summary>
		public CryptographicProvider(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String DllPath 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.CryptographicProvider.DllPath);}
		}

		public Boolean Enabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.CryptographicProvider.Enabled);}
		}


}
	public partial class DatabaseAuditSpecification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DatabaseAuditSpecification.TypeClass;

		/// <summary>
		///	Create a strongly typed class DatabaseAuditSpecification to adapt the TSqlObject 
		/// </summary>
		public DatabaseAuditSpecification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean WithState 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseAuditSpecification.WithState);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AuditActionGroup> AuditActionGroups 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseAuditSpecification.AuditActionGroups).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AuditActionGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AuditAction> AuditActions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseAuditSpecification.AuditActions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AuditAction)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ServerAudit> ServerAudit 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseAuditSpecification.ServerAudit).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ServerAudit)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DatabaseDdlTrigger : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DatabaseDdlTrigger.TypeClass;

		/// <summary>
		///	Create a strongly typed class DatabaseDdlTrigger to adapt the TSqlObject 
		/// </summary>
		public DatabaseDdlTrigger(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.AnsiNullsOn);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.ClassName);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.Disabled);}
		}

		public Boolean ExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.ExecuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.ExecuteAsSelf);}
		}

		public String MethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.MethodName);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.QuotedIdentifierOn);}
		}

		public TriggerType TriggerType 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<TriggerType>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.TriggerType);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.WithEncryption);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.BodyDependencies);
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup> EventGroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.EventGroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.EventType).Cast<Microsoft.SqlServer.Dac.Model.EventType>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseDdlTrigger.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DatabaseEncryptionKey : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DatabaseEncryptionKey.TypeClass;

		/// <summary>
		///	Create a strongly typed class DatabaseEncryptionKey to adapt the TSqlObject 
		/// </summary>
		public DatabaseEncryptionKey(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public SymmetricKeyAlgorithm Algorithm 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<SymmetricKeyAlgorithm>(Microsoft.SqlServer.Dac.Model.DatabaseEncryptionKey.Algorithm);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey> AsymmetricKey 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseEncryptionKey.AsymmetricKey).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> Certificate 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseEncryptionKey.Certificate).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DatabaseEventNotification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DatabaseEventNotification.TypeClass;

		/// <summary>
		///	Create a strongly typed class DatabaseEventNotification to adapt the TSqlObject 
		/// </summary>
		public DatabaseEventNotification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String BrokerInstanceSpecifier 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseEventNotification.BrokerInstanceSpecifier);}
		}

		public String BrokerService 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseEventNotification.BrokerService);}
		}

		public Boolean WithFanIn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseEventNotification.WithFanIn);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup> EventGroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseEventNotification.EventGroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseEventNotification.EventType).Cast<Microsoft.SqlServer.Dac.Model.EventType>();
			}
		}
	
}
	public partial class DatabaseMirroringLanguageSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DatabaseMirroringLanguageSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class DatabaseMirroringLanguageSpecifier to adapt the TSqlObject 
		/// </summary>
		public DatabaseMirroringLanguageSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ServiceBrokerEncryptionAlgorithm>(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart1);}
		}

		public ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ServiceBrokerEncryptionAlgorithm>(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.EncryptionAlgorithmPart2);}
		}

		public EncryptionMode EncryptionMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<EncryptionMode>(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.EncryptionMode);}
		}

		public DatabaseMirroringRole RoleType 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<DatabaseMirroringRole>(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.RoleType);}
		}

		public Boolean UseCertificateFirst 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.UseCertificateFirst);}
		}

		public AuthenticationModes WindowsAuthenticationMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<AuthenticationModes>(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.WindowsAuthenticationMode);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> AuthenticationCertificate 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseMirroringLanguageSpecifier.AuthenticationCertificate).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DatabaseOptions : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DatabaseOptions.TypeClass;

		/// <summary>
		///	Create a strongly typed class DatabaseOptions to adapt the TSqlObject 
		/// </summary>
		public DatabaseOptions(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowSnapshotIsolation 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AllowSnapshotIsolation);}
		}

		public Boolean AnsiNullDefaultOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AnsiNullDefaultOn);}
		}

		public Boolean AnsiNullsOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AnsiNullsOn);}
		}

		public Boolean AnsiPaddingOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AnsiPaddingOn);}
		}

		public Boolean AnsiWarningsOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AnsiWarningsOn);}
		}

		public Boolean ArithAbortOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ArithAbortOn);}
		}

		public Boolean AutoClose 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AutoClose);}
		}

		public Boolean AutoCreateStatistics 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AutoCreateStatistics);}
		}

		public Boolean AutoCreateStatisticsIncremental 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AutoCreateStatisticsIncremental);}
		}

		public Boolean AutoShrink 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AutoShrink);}
		}

		public Boolean AutoUpdateStatistics 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AutoUpdateStatistics);}
		}

		public Boolean AutoUpdateStatisticsAsync 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.AutoUpdateStatisticsAsync);}
		}

		public Boolean ChangeTrackingAutoCleanup 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ChangeTrackingAutoCleanup);}
		}

		public Boolean ChangeTrackingEnabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ChangeTrackingEnabled);}
		}

		public Int32 ChangeTrackingRetentionPeriod 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ChangeTrackingRetentionPeriod);}
		}

		public TimeUnit ChangeTrackingRetentionUnit 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<TimeUnit>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ChangeTrackingRetentionUnit);}
		}

		public String Collation 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.Collation);}
		}

		public Int32 CompatibilityLevel 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.CompatibilityLevel);}
		}

		public Boolean ConcatNullYieldsNull 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ConcatNullYieldsNull);}
		}

		public Containment Containment 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Containment>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.Containment);}
		}

		public Boolean CursorCloseOnCommit 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.CursorCloseOnCommit);}
		}

		public Boolean CursorDefaultGlobalScope 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.CursorDefaultGlobalScope);}
		}

		public Boolean DatabaseStateOffline 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DatabaseStateOffline);}
		}

		public Boolean DateCorrelationOptimizationOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DateCorrelationOptimizationOn);}
		}

		public Boolean DBChainingOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DBChainingOn);}
		}

		public String DefaultFullTextLanguage 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DefaultFullTextLanguage);}
		}

		public String DefaultLanguage 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DefaultLanguage);}
		}

		public DelayedDurabilityMode DelayedDurabilityMode 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<DelayedDurabilityMode>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DelayedDurabilityMode);}
		}

		public String FileStreamDirectoryName 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.FileStreamDirectoryName);}
		}

		public Boolean FullTextEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.FullTextEnabled);}
		}

		public Boolean HonorBrokerPriority 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.HonorBrokerPriority);}
		}

		public Boolean MemoryOptimizedElevateToSnapshot 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.MemoryOptimizedElevateToSnapshot);}
		}

		public Boolean NestedTriggersOn 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.NestedTriggersOn);}
		}

		public NonTransactedFileStreamAccess NonTransactedFileStreamAccess 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<NonTransactedFileStreamAccess>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.NonTransactedFileStreamAccess);}
		}

		public Boolean NumericRoundAbortOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.NumericRoundAbortOn);}
		}

		public PageVerifyMode PageVerifyMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<PageVerifyMode>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.PageVerifyMode);}
		}

		public ParameterizationOption ParameterizationOption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ParameterizationOption>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ParameterizationOption);}
		}

		public Boolean QuotedIdentifierOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.QuotedIdentifierOn);}
		}

		public Boolean ReadOnly 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ReadOnly);}
		}

		public RecoveryMode RecoveryMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<RecoveryMode>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.RecoveryMode);}
		}

		public Boolean RecursiveTriggersOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.RecursiveTriggersOn);}
		}

		public ServiceBrokerOption ServiceBrokerOption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ServiceBrokerOption>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.ServiceBrokerOption);}
		}

		public Boolean SupplementalLoggingOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.SupplementalLoggingOn);}
		}

		public Int32 TargetRecoveryTimePeriod 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.TargetRecoveryTimePeriod);}
		}

		public TimeUnit TargetRecoveryTimeUnit 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<TimeUnit>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.TargetRecoveryTimeUnit);}
		}

		public Boolean TornPageProtectionOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.TornPageProtectionOn);}
		}

		public Boolean TransactionIsolationReadCommittedSnapshot 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.TransactionIsolationReadCommittedSnapshot);}
		}

		public Boolean TransformNoiseWords 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.TransformNoiseWords);}
		}

		public Boolean Trustworthy 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.Trustworthy);}
		}

		public Int16 TwoDigitYearCutoff 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int16>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.TwoDigitYearCutoff);}
		}

		public UserAccessOption UserAccessOption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<UserAccessOption>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.UserAccessOption);}
		}

		public Boolean VardecimalStorageFormatOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.VardecimalStorageFormatOn);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DatabaseOptions.WithEncryption);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> DefaultFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DefaultFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> DefaultFileStreamFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DatabaseOptions.DefaultFileStreamFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DataCompressionOption : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DataCompressionOption.TypeClass;

		/// <summary>
		///	Create a strongly typed class DataCompressionOption to adapt the TSqlObject 
		/// </summary>
		public DataCompressionOption(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public CompressionLevel CompressionLevel 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<CompressionLevel>(Microsoft.SqlServer.Dac.Model.DataCompressionOption.CompressionLevel);}
		}

		public Int32 PartitionNumber 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.DataCompressionOption.PartitionNumber);}
		}


}
	public partial class Default : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Default.TypeClass;

		/// <summary>
		///	Create a strongly typed class Default to adapt the TSqlObject 
		/// </summary>
		public Default(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Expression 
		{
		// Supported platforms = 27
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Default.Expression);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BoundObjects 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Default.BoundObjects);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Default.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DefaultConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DefaultConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class DefaultConstraint to adapt the TSqlObject 
		/// </summary>
		public DefaultConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DefaultConstraint.Disabled);}
		}

		public String Expression 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.DefaultConstraint.Expression);}
		}

		public Boolean WithValues 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DefaultConstraint.WithValues);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DefaultConstraint.ExpressionDependencies);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty> Host 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DefaultConstraint.Host).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> TargetColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DefaultConstraint.TargetColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class DmlTrigger : TSqlModelElement
	{
		private static ModelTypeClass typeClass = DmlTrigger.TypeClass;

		/// <summary>
		///	Create a strongly typed class DmlTrigger to adapt the TSqlObject 
		/// </summary>
		public DmlTrigger(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.DmlTrigger.AnsiNullsOn);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DmlTrigger.ClassName);}
		}

		public OrderRestriction DeleteOrderRestriction 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<OrderRestriction>(Microsoft.SqlServer.Dac.Model.DmlTrigger.DeleteOrderRestriction);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.Disabled);}
		}

		public Boolean ExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.ExecuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.ExecuteAsSelf);}
		}

		public OrderRestriction InsertOrderRestriction 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<OrderRestriction>(Microsoft.SqlServer.Dac.Model.DmlTrigger.InsertOrderRestriction);}
		}

		public Boolean IsDeleteTrigger 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.IsDeleteTrigger);}
		}

		public Boolean IsInsertTrigger 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.IsInsertTrigger);}
		}

		public Boolean IsUpdateTrigger 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.IsUpdateTrigger);}
		}

		public String MethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.DmlTrigger.MethodName);}
		}

		public Boolean NotForReplication 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.NotForReplication);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.DmlTrigger.QuotedIdentifierOn);}
		}

		public TriggerType TriggerType 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<TriggerType>(Microsoft.SqlServer.Dac.Model.DmlTrigger.TriggerType);}
		}

		public OrderRestriction UpdateOrderRestriction 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<OrderRestriction>(Microsoft.SqlServer.Dac.Model.DmlTrigger.UpdateOrderRestriction);}
		}

		public Boolean WithAppend 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.WithAppend);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.DmlTrigger.WithEncryption);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DmlTrigger.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DmlTrigger.BodyDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DmlTrigger.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> TriggerObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DmlTrigger.TriggerObject);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.DmlTrigger.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Endpoint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Endpoint.TypeClass;

		/// <summary>
		///	Create a strongly typed class Endpoint to adapt the TSqlObject 
		/// </summary>
		public Endpoint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Payload Payload 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Payload>(Microsoft.SqlServer.Dac.Model.Endpoint.Payload);}
		}

		public Protocol Protocol 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Protocol>(Microsoft.SqlServer.Dac.Model.Endpoint.Protocol);}
		}

		public State State 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<State>(Microsoft.SqlServer.Dac.Model.Endpoint.State);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Endpoint.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier> PayloadSpecifier 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Endpoint.PayloadSpecifier).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.IEndpointLanguageSpecifier>();
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier > ProtocolSpecifier 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Endpoint.ProtocolSpecifier).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.IProtocolSpecifier >();
			}
		}
	
}
	public partial class ErrorMessage : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ErrorMessage.TypeClass;

		/// <summary>
		///	Create a strongly typed class ErrorMessage to adapt the TSqlObject 
		/// </summary>
		public ErrorMessage(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Language 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ErrorMessage.Language);}
		}

		public Int32 MessageNumber 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ErrorMessage.MessageNumber);}
		}

		public String MessageText 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ErrorMessage.MessageText);}
		}

		public Int32 Severity 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ErrorMessage.Severity);}
		}

		public Boolean WithLog 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ErrorMessage.WithLog);}
		}


}
	public partial class EventGroup : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventGroup.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventGroup to adapt the TSqlObject 
		/// </summary>
		public EventGroup(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public EventGroupType Group 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<EventGroupType>(Microsoft.SqlServer.Dac.Model.EventGroup.Group);}
		}


}
	public partial class EventSession : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventSession.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventSession to adapt the TSqlObject 
		/// </summary>
		public EventSession(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public EventRetentionMode EventRetentionMode 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<EventRetentionMode>(Microsoft.SqlServer.Dac.Model.EventSession.EventRetentionMode);}
		}

		public Int32 MaxDispatchLatency 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.EventSession.MaxDispatchLatency);}
		}

		public Int32 MaxEventSize 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.EventSession.MaxEventSize);}
		}

		public MemoryUnit MaxEventSizeUnit 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<MemoryUnit>(Microsoft.SqlServer.Dac.Model.EventSession.MaxEventSizeUnit);}
		}

		public Int32 MaxMemory 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.EventSession.MaxMemory);}
		}

		public MemoryUnit MaxMemoryUnit 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<MemoryUnit>(Microsoft.SqlServer.Dac.Model.EventSession.MaxMemoryUnit);}
		}

		public MemoryPartitionMode MemoryPartitionMode 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<MemoryPartitionMode>(Microsoft.SqlServer.Dac.Model.EventSession.MemoryPartitionMode);}
		}

		public Boolean StartupState 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.EventSession.StartupState);}
		}

		public Boolean TrackCausality 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.EventSession.TrackCausality);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> EventDefinitions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.EventSession.EventDefinitions);
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> EventTargets 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.EventSession.EventTargets);
			}
		}
	
}
	public partial class EventSessionAction : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventSessionAction.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventSessionAction to adapt the TSqlObject 
		/// </summary>
		public EventSessionAction(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String ActionName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionAction.ActionName);}
		}

		public String EventModuleGuid 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionAction.EventModuleGuid);}
		}

		public String EventPackageName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionAction.EventPackageName);}
		}


}
	public partial class EventSessionDefinitions : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventSessionDefinitions.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventSessionDefinitions to adapt the TSqlObject 
		/// </summary>
		public EventSessionDefinitions(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String EventModuleGuid 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionDefinitions.EventModuleGuid);}
		}

		public String EventName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionDefinitions.EventName);}
		}

		public String EventPackageName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionDefinitions.EventPackageName);}
		}

		public String WhereExpression 
		{
		// Supported platforms = 26
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.EventSessionDefinitions.WhereExpression);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.EventSessionAction> Actions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.EventSessionDefinitions.Actions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.EventSessionAction)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> AttributeSettings 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.EventSessionDefinitions.AttributeSettings);
			}
		}
	
}
	public partial class EventSessionSetting : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventSessionSetting.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventSessionSetting to adapt the TSqlObject 
		/// </summary>
		public EventSessionSetting(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String SettingName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionSetting.SettingName);}
		}

		public String SettingValue 
		{
		// Supported platforms = 26
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.EventSessionSetting.SettingValue);}
		}


}
	public partial class EventSessionTarget : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventSessionTarget.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventSessionTarget to adapt the TSqlObject 
		/// </summary>
		public EventSessionTarget(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String EventModuleGuid 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionTarget.EventModuleGuid);}
		}

		public String EventPackageName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionTarget.EventPackageName);}
		}

		public String TargetName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.EventSessionTarget.TargetName);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ParameterSettings 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.EventSessionTarget.ParameterSettings);
			}
		}
	
}
	public partial class EventTypeSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = EventTypeSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class EventTypeSpecifier to adapt the TSqlObject 
		/// </summary>
		public EventTypeSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public EventType EventType 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<EventType>(Microsoft.SqlServer.Dac.Model.EventTypeSpecifier.EventType);}
		}

		public OrderRestriction Order 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<OrderRestriction>(Microsoft.SqlServer.Dac.Model.EventTypeSpecifier.Order);}
		}


}
	public partial class ExtendedProcedure : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ExtendedProcedure.TypeClass;

		/// <summary>
		///	Create a strongly typed class ExtendedProcedure to adapt the TSqlObject 
		/// </summary>
		public ExtendedProcedure(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean ExeccuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.ExeccuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.ExecuteAsSelf);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.WithEncryption);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter> Parameters 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.Parameters).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ExtendedProcedure.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ExtendedProperty : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ExtendedProperty.TypeClass;

		/// <summary>
		///	Create a strongly typed class ExtendedProperty to adapt the TSqlObject 
		/// </summary>
		public ExtendedProperty(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Value 
		{
		// Supported platforms = 27
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.ExtendedProperty.Value);}
		}

		//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost> Host 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ExtendedProperty.Host).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.IExtendedPropertyHost>();
			}
		}
	
}
	public partial class SqlFile : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SqlFile.TypeClass;

		/// <summary>
		///	Create a strongly typed class SqlFile to adapt the TSqlObject 
		/// </summary>
		public SqlFile(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32? FileGrowth 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.SqlFile.FileGrowth);}
		}

		public MemoryUnit FileGrowthUnit 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<MemoryUnit>(Microsoft.SqlServer.Dac.Model.SqlFile.FileGrowthUnit);}
		}

		public String FileName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SqlFile.FileName);}
		}

		public Boolean IsLogFile 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SqlFile.IsLogFile);}
		}

		public Int32? MaxSize 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.SqlFile.MaxSize);}
		}

		public MemoryUnit MaxSizeUnit 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<MemoryUnit>(Microsoft.SqlServer.Dac.Model.SqlFile.MaxSizeUnit);}
		}

		public Boolean Offline 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SqlFile.Offline);}
		}

		public Int32? Size 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.SqlFile.Size);}
		}

		public MemoryUnit SizeUnit 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<MemoryUnit>(Microsoft.SqlServer.Dac.Model.SqlFile.SizeUnit);}
		}

		public Boolean Unlimited 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SqlFile.Unlimited);}
		}

		//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SqlFile.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Filegroup : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Filegroup.TypeClass;

		/// <summary>
		///	Create a strongly typed class Filegroup to adapt the TSqlObject 
		/// </summary>
		public Filegroup(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean ContainsFileStream 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Filegroup.ContainsFileStream);}
		}

		public Boolean ContainsMemoryOptimizedData 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Filegroup.ContainsMemoryOptimizedData);}
		}

		public Boolean ReadOnly 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Filegroup.ReadOnly);}
		}


}
	public partial class ForeignKeyConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ForeignKeyConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class ForeignKeyConstraint to adapt the TSqlObject 
		/// </summary>
		public ForeignKeyConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public ForeignKeyAction DeleteAction 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<ForeignKeyAction>(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.DeleteAction);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.Disabled);}
		}

		public Boolean NotForReplication 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.NotForReplication);}
		}

		public ForeignKeyAction UpdateAction 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<ForeignKeyAction>(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.UpdateAction);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> ForeignColumns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.ForeignColumns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Table> ForeignTable 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.ForeignTable).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Table)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty> Host 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ForeignKeyConstraint.Host).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class FullTextCatalog : TSqlModelElement
	{
		private static ModelTypeClass typeClass = FullTextCatalog.TypeClass;

		/// <summary>
		///	Create a strongly typed class FullTextCatalog to adapt the TSqlObject 
		/// </summary>
		public FullTextCatalog(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AccentSensitivity 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.FullTextCatalog.AccentSensitivity);}
		}

		public Boolean IsDefault 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FullTextCatalog.IsDefault);}
		}

		public String Path 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.FullTextCatalog.Path);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextCatalog.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextCatalog.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class FullTextIndex : TSqlModelElement
	{
		private static ModelTypeClass typeClass = FullTextIndex.TypeClass;

		/// <summary>
		///	Create a strongly typed class FullTextIndex to adapt the TSqlObject 
		/// </summary>
		public FullTextIndex(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public ChangeTrackingOption ChangeTracking 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ChangeTrackingOption>(Microsoft.SqlServer.Dac.Model.FullTextIndex.ChangeTracking);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FullTextIndex.Disabled);}
		}

		public Boolean Replicated 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FullTextIndex.Replicated);}
		}

		public Boolean StopListOff 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FullTextIndex.StopListOff);}
		}

		public Boolean UseSystemStopList 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FullTextIndex.UseSystemStopList);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> Catalog 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.Catalog);
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.IndexedObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.SearchPropertyList> SearchPropertyList 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.SearchPropertyList).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.SearchPropertyList)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> StopList 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.StopList);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> UniqueIndexName 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndex.UniqueIndexName);
			}
		}
	
}
	public partial class FullTextIndexColumnSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = FullTextIndexColumnSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class FullTextIndexColumnSpecifier to adapt the TSqlObject 
		/// </summary>
		public FullTextIndexColumnSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32? LanguageId 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.FullTextIndexColumnSpecifier.LanguageId);}
		}

		public Boolean PartOfStatisticalSemantics 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FullTextIndexColumnSpecifier.PartOfStatisticalSemantics);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Column 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndexColumnSpecifier.Column).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> TypeColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextIndexColumnSpecifier.TypeColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class FullTextStopList : TSqlModelElement
	{
		private static ModelTypeClass typeClass = FullTextStopList.TypeClass;

		/// <summary>
		///	Create a strongly typed class FullTextStopList to adapt the TSqlObject 
		/// </summary>
		public FullTextStopList(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FullTextStopList.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
	
}
	public partial class HttpProtocolSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = HttpProtocolSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class HttpProtocolSpecifier to adapt the TSqlObject 
		/// </summary>
		public HttpProtocolSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public AuthenticationModes AuthenticationMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<AuthenticationModes>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.AuthenticationMode);}
		}

		public String AuthenticationRealm 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.AuthenticationRealm);}
		}

		public Int32? ClearPort 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.ClearPort);}
		}

		public Boolean CompressionEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.CompressionEnabled);}
		}

		public String DefaultLogonDomain 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.DefaultLogonDomain);}
		}

		public Boolean ListeningOnAllNoneReservedSites 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.ListeningOnAllNoneReservedSites);}
		}

		public Boolean ListeningOnAllSites 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.ListeningOnAllSites);}
		}

		public String Path 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.Path);}
		}

		public HttpPorts Ports 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<HttpPorts>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.Ports);}
		}

		public Int32? SslPort 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.SslPort);}
		}

		public String Website 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.HttpProtocolSpecifier.Website);}
		}


}
	public partial class LinkedServer : TSqlModelElement
	{
		private static ModelTypeClass typeClass = LinkedServer.TypeClass;

		/// <summary>
		///	Create a strongly typed class LinkedServer to adapt the TSqlObject 
		/// </summary>
		public LinkedServer(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Catalog 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.Catalog);}
		}

		public Boolean CollationCompatible 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.CollationCompatible);}
		}

		public String CollationName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.CollationName);}
		}

		public Int32 ConnectTimeout 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.LinkedServer.ConnectTimeout);}
		}

		public Boolean DataAccess 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.DataAccess);}
		}

		public String DataSource 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.DataSource);}
		}

		public Boolean IsDistributor 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.IsDistributor);}
		}

		public Boolean IsPublisher 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.IsPublisher);}
		}

		public Boolean IsSubscriber 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.IsSubscriber);}
		}

		public Boolean LazySchemaValidationEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.LazySchemaValidationEnabled);}
		}

		public String Location 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.Location);}
		}

		public String ProductName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.ProductName);}
		}

		public String ProviderName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.ProviderName);}
		}

		public String ProviderString 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServer.ProviderString);}
		}

		public Int32 QueryTimeout 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.LinkedServer.QueryTimeout);}
		}

		public Boolean RemoteProcTransactionPromotionEnabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.RemoteProcTransactionPromotionEnabled);}
		}

		public Boolean RpcEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.RpcEnabled);}
		}

		public Boolean RpcOutEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.RpcOutEnabled);}
		}

		public Boolean UseRemoteCollation 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServer.UseRemoteCollation);}
		}


}
	public partial class LinkedServerLogin : TSqlModelElement
	{
		private static ModelTypeClass typeClass = LinkedServerLogin.TypeClass;

		/// <summary>
		///	Create a strongly typed class LinkedServerLogin to adapt the TSqlObject 
		/// </summary>
		public LinkedServerLogin(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String LinkedServerLoginName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServerLogin.LinkedServerLoginName);}
		}

		public String LinkedServerPassword 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.LinkedServerLogin.LinkedServerPassword);}
		}

		public Boolean UseSelf 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.LinkedServerLogin.UseSelf);}
		}

		//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.LinkedServer> LinkedServer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.LinkedServerLogin.LinkedServer).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.LinkedServer)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> LocalLogin 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.LinkedServerLogin.LocalLogin).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Login : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Login.TypeClass;

		/// <summary>
		///	Create a strongly typed class Login to adapt the TSqlObject 
		/// </summary>
		public Login(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean CheckExpiration 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Login.CheckExpiration);}
		}

		public Boolean CheckPolicy 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Login.CheckPolicy);}
		}

		public String DefaultDatabase 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Login.DefaultDatabase);}
		}

		public String DefaultLanguage 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Login.DefaultLanguage);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Login.Disabled);}
		}

		public LoginEncryptionOption EncryptionOption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<LoginEncryptionOption>(Microsoft.SqlServer.Dac.Model.Login.EncryptionOption);}
		}

		public Boolean MappedToWindowsLogin 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Login.MappedToWindowsLogin);}
		}

		public String Password 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Login.Password);}
		}

		public Boolean PasswordHashed 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Login.PasswordHashed);}
		}

		public Boolean PasswordMustChange 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Login.PasswordMustChange);}
		}

		public String Sid 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Login.Sid);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey> AsymmetricKey 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Login.AsymmetricKey).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> Certificate 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Login.Certificate).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Credential> Credential 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Login.Credential).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Credential)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class MasterKey : TSqlModelElement
	{
		private static ModelTypeClass typeClass = MasterKey.TypeClass;

		/// <summary>
		///	Create a strongly typed class MasterKey to adapt the TSqlObject 
		/// </summary>
		public MasterKey(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Password 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.MasterKey.Password);}
		}


}
	public partial class MessageType : TSqlModelElement
	{
		private static ModelTypeClass typeClass = MessageType.TypeClass;

		/// <summary>
		///	Create a strongly typed class MessageType to adapt the TSqlObject 
		/// </summary>
		public MessageType(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public ValidationMethod ValidationMethod 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ValidationMethod>(Microsoft.SqlServer.Dac.Model.MessageType.ValidationMethod);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.MessageType.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection> XmlSchemaCollection 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.MessageType.XmlSchemaCollection).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class PartitionFunction : TSqlModelElement
	{
		private static ModelTypeClass typeClass = PartitionFunction.TypeClass;

		/// <summary>
		///	Create a strongly typed class PartitionFunction to adapt the TSqlObject 
		/// </summary>
		public PartitionFunction(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public PartitionRange Range 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<PartitionRange>(Microsoft.SqlServer.Dac.Model.PartitionFunction.Range);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionValue> BoundaryValues 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PartitionFunction.BoundaryValues).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionValue)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase> ParameterType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PartitionFunction.ParameterType).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlTypeSpecifierBase>();
			}
		}
	
}
	public partial class PartitionScheme : TSqlModelElement
	{
		private static ModelTypeClass typeClass = PartitionScheme.TypeClass;

		/// <summary>
		///	Create a strongly typed class PartitionScheme to adapt the TSqlObject 
		/// </summary>
		public PartitionScheme(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllToOneFilegroup 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PartitionScheme.AllToOneFilegroup);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroups 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PartitionScheme.Filegroups).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionFunction> PartitionFunction 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PartitionScheme.PartitionFunction).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionFunction)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class PartitionValue : TSqlModelElement
	{
		private static ModelTypeClass typeClass = PartitionValue.TypeClass;

		/// <summary>
		///	Create a strongly typed class PartitionValue to adapt the TSqlObject 
		/// </summary>
		public PartitionValue(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Expression 
		{
		// Supported platforms = 27
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.PartitionValue.Expression);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PartitionValue.ExpressionDependencies);
			}
		}
	
}
	public partial class Permission : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Permission.TypeClass;

		/// <summary>
		///	Create a strongly typed class Permission to adapt the TSqlObject 
		/// </summary>
		public Permission(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public PermissionAction PermissionAction 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<PermissionAction>(Microsoft.SqlServer.Dac.Model.Permission.PermissionAction);}
		}

		public PermissionType PermissionType 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<PermissionType>(Microsoft.SqlServer.Dac.Model.Permission.PermissionType);}
		}

		public Boolean WithAllPrivileges 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Permission.WithAllPrivileges);}
		}

		public Boolean WithGrantOption 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Permission.WithGrantOption);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> ExcludedColumns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Permission.ExcludedColumns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantee 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Permission.Grantee).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal >();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal > Grantor 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Permission.Grantor).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurityPrincipal >();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> RevokedGrantOptionColumns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Permission.RevokedGrantOptionColumns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable> SecuredObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Permission.SecuredObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlSecurable>();
			}
		}
	
}
	public partial class PrimaryKeyConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = PrimaryKeyConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class PrimaryKeyConstraint to adapt the TSqlObject 
		/// </summary>
		public PrimaryKeyConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowPageLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.AllowPageLocks);}
		}

		public Boolean AllowRowLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.AllowRowLocks);}
		}

		public Int32? BucketCount 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.BucketCount);}
		}

		public Boolean Clustered 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.Clustered);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.Disabled);}
		}

		public Boolean? FileStreamNull 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.FileStreamNull);}
		}

		public Int32? FillFactor 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.FillFactor);}
		}

		public Boolean Hash 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.Hash);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.IgnoreDuplicateKey);}
		}

		public Boolean RecomputeStatistics 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.RecomputeStatistics);}
		}

		public Boolean WithPadIndex 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.WithPadIndex);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption> DataCompressionOptions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.DataCompressionOptions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> FileStreamFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.FileStreamFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> FileStreamPartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.FileStreamPartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty> Host 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.Host).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PrimaryKeyConstraint.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Procedure : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Procedure.TypeClass;

		/// <summary>
		///	Create a strongly typed class Procedure to adapt the TSqlObject 
		/// </summary>
		public Procedure(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Procedure.AnsiNullsOn);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Procedure.ClassName);}
		}

		public Boolean ExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.ExecuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.ExecuteAsSelf);}
		}

		public Boolean ForReplication 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.ForReplication);}
		}

		public Boolean IsReplicated 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.IsReplicated);}
		}

		public String MethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Procedure.MethodName);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Procedure.QuotedIdentifierOn);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.WithEncryption);}
		}

		public Boolean WithNativeCompilation 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.WithNativeCompilation);}
		}

		public Boolean WithRecompile 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.WithRecompile);}
		}

		public Boolean WithSchemaBinding 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Procedure.WithSchemaBinding);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.BodyDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter> Parameters 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.Parameters).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Parameter)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Procedure> ParentProcedure 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.ParentProcedure).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Procedure)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Procedure.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Queue : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Queue.TypeClass;

		/// <summary>
		///	Create a strongly typed class Queue to adapt the TSqlObject 
		/// </summary>
		public Queue(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean ActivationExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Queue.ActivationExecuteAsCaller);}
		}

		public Boolean ActivationExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Queue.ActivationExecuteAsOwner);}
		}

		public Boolean ActivationExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Queue.ActivationExecuteAsSelf);}
		}

		public Int32? ActivationMaxQueueReaders 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.Queue.ActivationMaxQueueReaders);}
		}

		public Boolean? ActivationStatusOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Queue.ActivationStatusOn);}
		}

		public Boolean PoisonMessageHandlingStatusOn 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Queue.PoisonMessageHandlingStatusOn);}
		}

		public Boolean RetentionOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Queue.RetentionOn);}
		}

		public Boolean StatusOn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Queue.StatusOn);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Procedure> ActivationProcedure 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.ActivationProcedure).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Procedure)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Queue.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class QueueEventNotification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = QueueEventNotification.TypeClass;

		/// <summary>
		///	Create a strongly typed class QueueEventNotification to adapt the TSqlObject 
		/// </summary>
		public QueueEventNotification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String BrokerInstanceSpecifier 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.QueueEventNotification.BrokerInstanceSpecifier);}
		}

		public String BrokerService 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.QueueEventNotification.BrokerService);}
		}

		public Boolean WithFanIn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.QueueEventNotification.WithFanIn);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup> EventGroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.QueueEventNotification.EventGroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.QueueEventNotification.EventType).Cast<Microsoft.SqlServer.Dac.Model.EventType>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Queue> Queue 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.QueueEventNotification.Queue).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Queue)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class RemoteServiceBinding : TSqlModelElement
	{
		private static ModelTypeClass typeClass = RemoteServiceBinding.TypeClass;

		/// <summary>
		///	Create a strongly typed class RemoteServiceBinding to adapt the TSqlObject 
		/// </summary>
		public RemoteServiceBinding(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean Anonymous 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.RemoteServiceBinding.Anonymous);}
		}

		public String Service 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.RemoteServiceBinding.Service);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.RemoteServiceBinding.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.RemoteServiceBinding.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ResourceGovernor : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ResourceGovernor.TypeClass;

		/// <summary>
		///	Create a strongly typed class ResourceGovernor to adapt the TSqlObject 
		/// </summary>
		public ResourceGovernor(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? Enabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ResourceGovernor.Enabled);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ClassifierFunction 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ResourceGovernor.ClassifierFunction);
			}
		}
	
}
	public partial class ResourcePool : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ResourcePool.TypeClass;

		/// <summary>
		///	Create a strongly typed class ResourcePool to adapt the TSqlObject 
		/// </summary>
		public ResourcePool(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32 CapCpuPercent 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.CapCpuPercent);}
		}

		public Int32 MaxCpuPercent 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.MaxCpuPercent);}
		}

		public Int32 MaxIopsPerVolume 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.MaxIopsPerVolume);}
		}

		public Int32 MaxMemoryPercent 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.MaxMemoryPercent);}
		}

		public Int32 MinCpuPercent 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.MinCpuPercent);}
		}

		public Int32 MinIopsPerVolume 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.MinIopsPerVolume);}
		}

		public Int32 MinMemoryPercent 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ResourcePool.MinMemoryPercent);}
		}


}
	public partial class Role : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Role.TypeClass;

		/// <summary>
		///	Create a strongly typed class Role to adapt the TSqlObject 
		/// </summary>
		public Role(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Role.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
	
}
	public partial class RoleMembership : TSqlModelElement
	{
		private static ModelTypeClass typeClass = RoleMembership.TypeClass;

		/// <summary>
		///	Create a strongly typed class RoleMembership to adapt the TSqlObject 
		/// </summary>
		public RoleMembership(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal> Member 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.RoleMembership.Member).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlDatabaseSecurityPrincipal>();
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Role> Role 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.RoleMembership.Role).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Role)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Route : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Route.TypeClass;

		/// <summary>
		///	Create a strongly typed class Route to adapt the TSqlObject 
		/// </summary>
		public Route(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Address 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Route.Address);}
		}

		public String BrokerInstance 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Route.BrokerInstance);}
		}

		public Int32? Lifetime 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.Route.Lifetime);}
		}

		public String MirrorAddress 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Route.MirrorAddress);}
		}

		public String ServiceName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Route.ServiceName);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Route.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
	
}
	public partial class Rule : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Rule.TypeClass;

		/// <summary>
		///	Create a strongly typed class Rule to adapt the TSqlObject 
		/// </summary>
		public Rule(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Expression 
		{
		// Supported platforms = 27
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Rule.Expression);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BoundObjects 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Rule.BoundObjects);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Rule.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Schema : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Schema.TypeClass;

		/// <summary>
		///	Create a strongly typed class Schema to adapt the TSqlObject 
		/// </summary>
		public Schema(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Schema.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
	
}
	public partial class SearchProperty : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SearchProperty.TypeClass;

		/// <summary>
		///	Create a strongly typed class SearchProperty to adapt the TSqlObject 
		/// </summary>
		public SearchProperty(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Description 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SearchProperty.Description);}
		}

		public Int32 Identifier 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.SearchProperty.Identifier);}
		}

		public String PropertySetGuid 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SearchProperty.PropertySetGuid);}
		}

		//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.SearchPropertyList> SearchPropertyList 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SearchProperty.SearchPropertyList).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.SearchPropertyList)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class SearchPropertyList : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SearchPropertyList.TypeClass;

		/// <summary>
		///	Create a strongly typed class SearchPropertyList to adapt the TSqlObject 
		/// </summary>
		public SearchPropertyList(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SearchPropertyList.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
	
}
	public partial class Sequence : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Sequence.TypeClass;

		/// <summary>
		///	Create a strongly typed class Sequence to adapt the TSqlObject 
		/// </summary>
		public Sequence(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32? CacheSize 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.Sequence.CacheSize);}
		}

		public String IncrementValue 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Sequence.IncrementValue);}
		}

		public Boolean IsCached 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Sequence.IsCached);}
		}

		public Boolean IsCycling 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Sequence.IsCycling);}
		}

		public String MaxValue 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Sequence.MaxValue);}
		}

		public String MinValue 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Sequence.MinValue);}
		}

		public Boolean NoMaxValue 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Sequence.NoMaxValue);}
		}

		public Boolean NoMinValue 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Sequence.NoMinValue);}
		}

		public String StartValue 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Sequence.StartValue);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataType> DataType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Sequence.DataType).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataType)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Sequence.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ServerAudit : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServerAudit.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServerAudit to adapt the TSqlObject 
		/// </summary>
		public ServerAudit(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String AuditGuid 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ServerAudit.AuditGuid);}
		}

		public AuditTarget AuditTarget 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<AuditTarget>(Microsoft.SqlServer.Dac.Model.ServerAudit.AuditTarget);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerAudit.Disabled);}
		}

		public String FilePath 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ServerAudit.FilePath);}
		}

		public Int32? MaxFiles 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.ServerAudit.MaxFiles);}
		}

		public Int32? MaxRolloverFiles 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.ServerAudit.MaxRolloverFiles);}
		}

		public Int32? MaxSize 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.ServerAudit.MaxSize);}
		}

		public MemoryUnit MaxSizeUnit 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<MemoryUnit>(Microsoft.SqlServer.Dac.Model.ServerAudit.MaxSizeUnit);}
		}

		public FailureAction OnFailure 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<FailureAction>(Microsoft.SqlServer.Dac.Model.ServerAudit.OnFailure);}
		}

		public String PredicateExpression 
		{
		// Supported platforms = 24
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.ServerAudit.PredicateExpression);}
		}

		public Int32 QueueDelay 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ServerAudit.QueueDelay);}
		}

		public Boolean ReserveDiskSpace 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerAudit.ReserveDiskSpace);}
		}

		public Boolean UnlimitedFileSize 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerAudit.UnlimitedFileSize);}
		}

		public Boolean UnlimitedMaxRolloverFiles 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerAudit.UnlimitedMaxRolloverFiles);}
		}


}
	public partial class ServerAuditSpecification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServerAuditSpecification.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServerAuditSpecification to adapt the TSqlObject 
		/// </summary>
		public ServerAuditSpecification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean StateOn 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerAuditSpecification.StateOn);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AuditActionGroup> AuditActionGroups 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerAuditSpecification.AuditActionGroups).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AuditActionGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ServerAudit> ServerAudit 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerAuditSpecification.ServerAudit).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ServerAudit)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ServerDdlTrigger : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServerDdlTrigger.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServerDdlTrigger to adapt the TSqlObject 
		/// </summary>
		public ServerDdlTrigger(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.AnsiNullsOn);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.ClassName);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.Disabled);}
		}

		public Boolean ExecuteAsCaller 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.ExecuteAsCaller);}
		}

		public Boolean ExecuteAsOwner 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.ExecuteAsOwner);}
		}

		public Boolean ExecuteAsSelf 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.ExecuteAsSelf);}
		}

		public Boolean IsLogon 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.IsLogon);}
		}

		public String MethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.MethodName);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.QuotedIdentifierOn);}
		}

		public TriggerType TriggerType 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<TriggerType>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.TriggerType);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.WithEncryption);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.BodyDependencies);
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup> EventGroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.EventGroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.EventType).Cast<Microsoft.SqlServer.Dac.Model.EventType>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.User> User 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerDdlTrigger.User).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.User)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ServerEventNotification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServerEventNotification.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServerEventNotification to adapt the TSqlObject 
		/// </summary>
		public ServerEventNotification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String BrokerInstanceSpecifier 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ServerEventNotification.BrokerInstanceSpecifier);}
		}

		public String BrokerService 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.ServerEventNotification.BrokerService);}
		}

		public Boolean WithFanIn 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServerEventNotification.WithFanIn);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup> EventGroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerEventNotification.EventGroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.EventGroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.EventType> EventType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerEventNotification.EventType).Cast<Microsoft.SqlServer.Dac.Model.EventType>();
			}
		}
	
}
	public partial class ServerOptions : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServerOptions.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServerOptions to adapt the TSqlObject 
		/// </summary>
		public ServerOptions(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}

}
	public partial class ServerRoleMembership : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServerRoleMembership.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServerRoleMembership to adapt the TSqlObject 
		/// </summary>
		public ServerRoleMembership(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal> Member 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerRoleMembership.Member).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.IServerSecurityPrincipal>();
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Role> Role 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServerRoleMembership.Role).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Role)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Service : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Service.TypeClass;

		/// <summary>
		///	Create a strongly typed class Service to adapt the TSqlObject 
		/// </summary>
		public Service(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean UseDefaultContract 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Service.UseDefaultContract);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Service.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Contract> Contracts 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Service.Contracts).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Contract)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Queue> Queue 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Service.Queue).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Queue)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class ServiceBrokerLanguageSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = ServiceBrokerLanguageSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class ServiceBrokerLanguageSpecifier to adapt the TSqlObject 
		/// </summary>
		public ServiceBrokerLanguageSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart1 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ServiceBrokerEncryptionAlgorithm>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart1);}
		}

		public ServiceBrokerEncryptionAlgorithm EncryptionAlgorithmPart2 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<ServiceBrokerEncryptionAlgorithm>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.EncryptionAlgorithmPart2);}
		}

		public EncryptionMode EncryptionMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<EncryptionMode>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.EncryptionMode);}
		}

		public Boolean MessageForwardingEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.MessageForwardingEnabled);}
		}

		public Int32 MessageForwardSize 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.MessageForwardSize);}
		}

		public Boolean UseCertificateFirst 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.UseCertificateFirst);}
		}

		public AuthenticationModes WindowsAuthenticationMode 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<AuthenticationModes>(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.WindowsAuthenticationMode);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> AuthenticationCertificate 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.ServiceBrokerLanguageSpecifier.AuthenticationCertificate).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Signature : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Signature.TypeClass;

		/// <summary>
		///	Create a strongly typed class Signature to adapt the TSqlObject 
		/// </summary>
		public Signature(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean IsCounterSignature 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Signature.IsCounterSignature);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> EncryptionMechanism 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Signature.EncryptionMechanism);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> SignedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Signature.SignedObject);
			}
		}
	
}
	public partial class SignatureEncryptionMechanism : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SignatureEncryptionMechanism.TypeClass;

		/// <summary>
		///	Create a strongly typed class SignatureEncryptionMechanism to adapt the TSqlObject 
		/// </summary>
		public SignatureEncryptionMechanism(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Password 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SignatureEncryptionMechanism.Password);}
		}

		public String SignedBlob 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SignatureEncryptionMechanism.SignedBlob);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey> AsymmetricKey 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SignatureEncryptionMechanism.AsymmetricKey).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> Certificate 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SignatureEncryptionMechanism.Certificate).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class SoapLanguageSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SoapLanguageSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class SoapLanguageSpecifier to adapt the TSqlObject 
		/// </summary>
		public SoapLanguageSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean BatchesEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.BatchesEnabled);}
		}

		public CharacterSet CharacterSet 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<CharacterSet>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.CharacterSet);}
		}

		public String DatabaseName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.DatabaseName);}
		}

		public Int32 HeaderLimit 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.HeaderLimit);}
		}

		public Boolean IsDefaultDatabase 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.IsDefaultDatabase);}
		}

		public Boolean IsDefaultNamespace 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.IsDefaultNamespace);}
		}

		public Boolean IsDefaultWsdlSpName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.IsDefaultWsdlSpName);}
		}

		public SoapLoginType LoginType 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SoapLoginType>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.LoginType);}
		}

		public String Namespace 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.Namespace);}
		}

		public SoapSchema SchemaType 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SoapSchema>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.SchemaType);}
		}

		public Boolean SessionsEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.SessionsEnabled);}
		}

		public Int32 SessionTimeout 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.SessionTimeout);}
		}

		public Boolean SessionTimeoutNever 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.SessionTimeoutNever);}
		}

		public String WsdlSpName 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.WsdlSpName);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.SoapMethodSpecification> WebMethods 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SoapLanguageSpecifier.WebMethods).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.SoapMethodSpecification)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class SoapMethodSpecification : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SoapMethodSpecification.TypeClass;

		/// <summary>
		///	Create a strongly typed class SoapMethodSpecification to adapt the TSqlObject 
		/// </summary>
		public SoapMethodSpecification(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public SoapFormat Format 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SoapFormat>(Microsoft.SqlServer.Dac.Model.SoapMethodSpecification.Format);}
		}

		public SoapSchema SchemaType 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SoapSchema>(Microsoft.SqlServer.Dac.Model.SoapMethodSpecification.SchemaType);}
		}

		public String WebMethodAlias 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SoapMethodSpecification.WebMethodAlias);}
		}

		public String WebMethodNamespace 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SoapMethodSpecification.WebMethodNamespace);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> RelatedMethod 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SoapMethodSpecification.RelatedMethod);
			}
		}
	
}
	public partial class SpatialIndex : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SpatialIndex.TypeClass;

		/// <summary>
		///	Create a strongly typed class SpatialIndex to adapt the TSqlObject 
		/// </summary>
		public SpatialIndex(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowPageLocks 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SpatialIndex.AllowPageLocks);}
		}

		public Boolean AllowRowLocks 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SpatialIndex.AllowRowLocks);}
		}

		public Int32? CellsPerObject 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.SpatialIndex.CellsPerObject);}
		}

		public CompressionLevel DataCompression 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<CompressionLevel>(Microsoft.SqlServer.Dac.Model.SpatialIndex.DataCompression);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SpatialIndex.Disabled);}
		}

		public Int32 FillFactor 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.SpatialIndex.FillFactor);}
		}

		public Degree GridLevel1Density 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Degree>(Microsoft.SqlServer.Dac.Model.SpatialIndex.GridLevel1Density);}
		}

		public Degree GridLevel2Density 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Degree>(Microsoft.SqlServer.Dac.Model.SpatialIndex.GridLevel2Density);}
		}

		public Degree GridLevel3Density 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Degree>(Microsoft.SqlServer.Dac.Model.SpatialIndex.GridLevel3Density);}
		}

		public Degree GridLevel4Density 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Degree>(Microsoft.SqlServer.Dac.Model.SpatialIndex.GridLevel4Density);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SpatialIndex.IgnoreDuplicateKey);}
		}

		public Boolean RecomputeStatistics 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SpatialIndex.RecomputeStatistics);}
		}

		public Tessellation Tessellation 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Tessellation>(Microsoft.SqlServer.Dac.Model.SpatialIndex.Tessellation);}
		}

		public Boolean WithPadIndex 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SpatialIndex.WithPadIndex);}
		}

		public Double? XMax 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Double?>(Microsoft.SqlServer.Dac.Model.SpatialIndex.XMax);}
		}

		public Double? XMin 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Double?>(Microsoft.SqlServer.Dac.Model.SpatialIndex.XMin);}
		}

		public Double? YMax 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Double?>(Microsoft.SqlServer.Dac.Model.SpatialIndex.YMax);}
		}

		public Double? YMin 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Double?>(Microsoft.SqlServer.Dac.Model.SpatialIndex.YMin);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Column 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SpatialIndex.Column).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SpatialIndex.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SpatialIndex.IndexedObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SpatialIndex.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SpatialIndex.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Statistics : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Statistics.TypeClass;

		/// <summary>
		///	Create a strongly typed class Statistics to adapt the TSqlObject 
		/// </summary>
		public Statistics(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String FilterPredicate 
		{
		// Supported platforms = 30
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Statistics.FilterPredicate);}
		}

		public Boolean Incremental 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Statistics.Incremental);}
		}

		public Boolean NoRecompute 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Statistics.NoRecompute);}
		}

		public Int32 SampleSize 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Statistics.SampleSize);}
		}

		public SamplingStyle SamplingStyle 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<SamplingStyle>(Microsoft.SqlServer.Dac.Model.Statistics.SamplingStyle);}
		}

		public String StatsStream 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.Statistics.StatsStream);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Statistics.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Statistics.ExpressionDependencies);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> OnObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Statistics.OnObject);
			}
		}
	
}
	public partial class Parameter : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Parameter.TypeClass;

		/// <summary>
		///	Create a strongly typed class Parameter to adapt the TSqlObject 
		/// </summary>
		public Parameter(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String DefaultExpression 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Parameter.DefaultExpression);}
		}

		public Boolean IsMax 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Parameter.IsMax);}
		}

		public Boolean IsOutput 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Parameter.IsOutput);}
		}

		public Int32 Length 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Parameter.Length);}
		}

		public Int32 Precision 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Parameter.Precision);}
		}

		public Boolean ReadOnly 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Parameter.ReadOnly);}
		}

		public Int32 Scale 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Parameter.Scale);}
		}

		public Boolean Varying 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Parameter.Varying);}
		}

		public XmlStyle XmlStyle 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<XmlStyle>(Microsoft.SqlServer.Dac.Model.Parameter.XmlStyle);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataType> DataType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Parameter.DataType).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataType)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection> XmlSchemaCollection 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Parameter.XmlSchemaCollection).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class SymmetricKey : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SymmetricKey.TypeClass;

		/// <summary>
		///	Create a strongly typed class SymmetricKey to adapt the TSqlObject 
		/// </summary>
		public SymmetricKey(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public SymmetricKeyAlgorithm Algorithm 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SymmetricKeyAlgorithm>(Microsoft.SqlServer.Dac.Model.SymmetricKey.Algorithm);}
		}

		public SymmetricKeyCreationDisposition CreationDisposition 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<SymmetricKeyCreationDisposition>(Microsoft.SqlServer.Dac.Model.SymmetricKey.CreationDisposition);}
		}

		public String IdentityValue 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SymmetricKey.IdentityValue);}
		}

		public String KeySource 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SymmetricKey.KeySource);}
		}

		public String ProviderKeyName 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SymmetricKey.ProviderKeyName);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey> AsymmetricKeys 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SymmetricKey.AsymmetricKeys).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SymmetricKey.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> Certificates 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SymmetricKey.Certificates).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> Passwords 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SymmetricKey.Passwords);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> Provider 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SymmetricKey.Provider);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.SymmetricKey> SymmetricKeys 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SymmetricKey.SymmetricKeys).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.SymmetricKey)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class SymmetricKeyPassword : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SymmetricKeyPassword.TypeClass;

		/// <summary>
		///	Create a strongly typed class SymmetricKeyPassword to adapt the TSqlObject 
		/// </summary>
		public SymmetricKeyPassword(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Password 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.SymmetricKeyPassword.Password);}
		}


}
	public partial class Synonym : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Synonym.TypeClass;

		/// <summary>
		///	Create a strongly typed class Synonym to adapt the TSqlObject 
		/// </summary>
		public Synonym(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String ForObjectName 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.Synonym.ForObjectName);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ForObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Synonym.ForObject);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Synonym.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class Table : TSqlModelElement
	{
		private static ModelTypeClass typeClass = Table.TypeClass;

		/// <summary>
		///	Create a strongly typed class Table to adapt the TSqlObject 
		/// </summary>
		public Table(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Table.AnsiNullsOn);}
		}

		public Boolean ChangeDataCaptureEnabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.ChangeDataCaptureEnabled);}
		}

		public Boolean ChangeTrackingEnabled 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.ChangeTrackingEnabled);}
		}

		public Durability Durability 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Durability>(Microsoft.SqlServer.Dac.Model.Table.Durability);}
		}

		public Boolean? FileStreamNull 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Table.FileStreamNull);}
		}

		public Boolean IsReplicated 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.IsReplicated);}
		}

		public Boolean LargeValueTypesOutOfRow 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.LargeValueTypesOutOfRow);}
		}

		public LockEscalationMethod LockEscalation 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<LockEscalationMethod>(Microsoft.SqlServer.Dac.Model.Table.LockEscalation);}
		}

		public Boolean MemoryOptimized 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.MemoryOptimized);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.Table.QuotedIdentifierOn);}
		}

		public Boolean TableLockOnBulkLoad 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.TableLockOnBulkLoad);}
		}

		public Int32 TextInRowSize 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.Table.TextInRowSize);}
		}

		public Boolean TrackColumnsUpdated 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.TrackColumnsUpdated);}
		}

		public Boolean VardecimalStorageFormatEnabled 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.Table.VardecimalStorageFormatEnabled);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption> DataCompressionOptions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.DataCompressionOptions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> FilegroupForTextImage 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.FilegroupForTextImage).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> FileStreamFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.FileStreamFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> FileStreamPartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.FileStreamPartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.Table.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class FileTable : TSqlModelElement
	{
		private static ModelTypeClass typeClass = FileTable.TypeClass;

		/// <summary>
		///	Create a strongly typed class FileTable to adapt the TSqlObject 
		/// </summary>
		public FileTable(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.FileTable.AnsiNullsOn);}
		}

		public Boolean? FileStreamNull 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.FileTable.FileStreamNull);}
		}

		public String FileTableCollateFilename 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.FileTable.FileTableCollateFilename);}
		}

		public String FileTableDirectory 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.FileTable.FileTableDirectory);}
		}

		public Boolean FileTableNamespaceEnabled 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FileTable.FileTableNamespaceEnabled);}
		}

		public LockEscalationMethod LockEscalation 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<LockEscalationMethod>(Microsoft.SqlServer.Dac.Model.FileTable.LockEscalation);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.FileTable.QuotedIdentifierOn);}
		}

		public Boolean TableLockOnBulkLoad 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.FileTable.TableLockOnBulkLoad);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption> DataCompressionOptions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.DataCompressionOptions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> FileStreamFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.FileStreamFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> FileStreamPartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.FileStreamPartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.FileTable.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableType : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableType.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableType to adapt the TSqlObject 
		/// </summary>
		public TableType(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean MemoryOptimized 
		{
		// Supported platforms = 16
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableType.MemoryOptimized);}
		}

		//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableType.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint> Constraints 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableType.Constraints).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ITableTypeConstraint>();
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlIndex> Indexes 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableType.Indexes).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlIndex>();
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableType.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableTypeCheckConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableTypeCheckConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableTypeCheckConstraint to adapt the TSqlObject 
		/// </summary>
		public TableTypeCheckConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Expression 
		{
		// Supported platforms = 30
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.TableTypeCheckConstraint.Expression);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeCheckConstraint.ExpressionDependencies);
			}
		}
	
}
	public partial class TableTypeColumn : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableTypeColumn.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableTypeColumn to adapt the TSqlObject 
		/// </summary>
		public TableTypeColumn(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Collation 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Collation);}
		}

		public String Expression 
		{
		// Supported platforms = 30
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Expression);}
		}

		public String IdentityIncrement 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.IdentityIncrement);}
		}

		public String IdentitySeed 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.IdentitySeed);}
		}

		public Boolean IsIdentity 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.IsIdentity);}
		}

		public Boolean IsMax 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.IsMax);}
		}

		public Boolean IsRowGuidCol 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.IsRowGuidCol);}
		}

		public Int32 Length 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Length);}
		}

		public Boolean Nullable 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Nullable);}
		}

		public Boolean Persisted 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Persisted);}
		}

		public Boolean? PersistedNullable 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.PersistedNullable);}
		}

		public Int32 Precision 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Precision);}
		}

		public Int32 Scale 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.Scale);}
		}

		public XmlStyle XmlStyle 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<XmlStyle>(Microsoft.SqlServer.Dac.Model.TableTypeColumn.XmlStyle);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataType> DataType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeColumn.DataType).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataType)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeColumn.ExpressionDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection> XmlSchemaCollection 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeColumn.XmlSchemaCollection).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.XmlSchemaCollection)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableTypeDefaultConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableTypeDefaultConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableTypeDefaultConstraint to adapt the TSqlObject 
		/// </summary>
		public TableTypeDefaultConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Expression 
		{
		// Supported platforms = 30
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.TableTypeDefaultConstraint.Expression);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> ExpressionDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeDefaultConstraint.ExpressionDependencies);
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> TargetColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeDefaultConstraint.TargetColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableTypeIndex : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableTypeIndex.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableTypeIndex to adapt the TSqlObject 
		/// </summary>
		public TableTypeIndex(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32? BucketCount 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.TableTypeIndex.BucketCount);}
		}

		public Boolean Hash 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeIndex.Hash);}
		}

		public Boolean IsDisabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeIndex.IsDisabled);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeIndex.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableTypePrimaryKeyConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableTypePrimaryKeyConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableTypePrimaryKeyConstraint to adapt the TSqlObject 
		/// </summary>
		public TableTypePrimaryKeyConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32? BucketCount 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.TableTypePrimaryKeyConstraint.BucketCount);}
		}

		public Boolean Clustered 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypePrimaryKeyConstraint.Clustered);}
		}

		public Boolean Hash 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypePrimaryKeyConstraint.Hash);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypePrimaryKeyConstraint.IgnoreDuplicateKey);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypePrimaryKeyConstraint.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TableTypeUniqueConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TableTypeUniqueConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class TableTypeUniqueConstraint to adapt the TSqlObject 
		/// </summary>
		public TableTypeUniqueConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean Clustered 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeUniqueConstraint.Clustered);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 30
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TableTypeUniqueConstraint.IgnoreDuplicateKey);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.TableTypeUniqueConstraint.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class TcpProtocolSpecifier : TSqlModelElement
	{
		private static ModelTypeClass typeClass = TcpProtocolSpecifier.TypeClass;

		/// <summary>
		///	Create a strongly typed class TcpProtocolSpecifier to adapt the TSqlObject 
		/// </summary>
		public TcpProtocolSpecifier(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String ListenerIPv4 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TcpProtocolSpecifier.ListenerIPv4);}
		}

		public String ListenerIPv6 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.TcpProtocolSpecifier.ListenerIPv6);}
		}

		public Int32 ListenerPort 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.TcpProtocolSpecifier.ListenerPort);}
		}

		public Boolean ListeningOnAllIPs 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.TcpProtocolSpecifier.ListeningOnAllIPs);}
		}


}
	public partial class UniqueConstraint : TSqlModelElement
	{
		private static ModelTypeClass typeClass = UniqueConstraint.TypeClass;

		/// <summary>
		///	Create a strongly typed class UniqueConstraint to adapt the TSqlObject 
		/// </summary>
		public UniqueConstraint(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowPageLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.AllowPageLocks);}
		}

		public Boolean AllowRowLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.AllowRowLocks);}
		}

		public Boolean Clustered 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.Clustered);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.Disabled);}
		}

		public Boolean? FileStreamNull 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.FileStreamNull);}
		}

		public Int32? FillFactor 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.FillFactor);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.IgnoreDuplicateKey);}
		}

		public Boolean RecomputeStatistics 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.RecomputeStatistics);}
		}

		public Boolean WithPadIndex 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.UniqueConstraint.WithPadIndex);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption> DataCompressionOptions 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.DataCompressionOptions).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataCompressionOption)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> Filegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.Filegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup> FileStreamFilegroup 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.FileStreamFilegroup).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Filegroup)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> FileStreamPartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.FileStreamPartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty> Host 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.Host).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ExtendedProperty)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> PartitionColumn 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.PartitionColumn).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme> PartitionScheme 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UniqueConstraint.PartitionScheme).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.PartitionScheme)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class User : TSqlModelElement
	{
		private static ModelTypeClass typeClass = User.TypeClass;

		/// <summary>
		///	Create a strongly typed class User to adapt the TSqlObject 
		/// </summary>
		public User(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public AuthenticationType AuthenticationType 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<AuthenticationType>(Microsoft.SqlServer.Dac.Model.User.AuthenticationType);}
		}

		public String DefaultLanguage 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.User.DefaultLanguage);}
		}

		public String Password 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.User.Password);}
		}

		public String Sid 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.User.Sid);}
		}

		public Boolean WithoutLogin 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.User.WithoutLogin);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey> AsymmetricKey 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.User.AsymmetricKey).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.AsymmetricKey)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate> Certificate 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.User.Certificate).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Certificate)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> DefaultSchema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.User.DefaultSchema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Login> Login 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.User.Login).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Login)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class UserDefinedServerRole : TSqlModelElement
	{
		private static ModelTypeClass typeClass = UserDefinedServerRole.TypeClass;

		/// <summary>
		///	Create a strongly typed class UserDefinedServerRole to adapt the TSqlObject 
		/// </summary>
		public UserDefinedServerRole(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer> Authorizer 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UserDefinedServerRole.Authorizer).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlObjectAuthorizer>();
			}
		}
	
}
	public partial class UserDefinedType : TSqlModelElement
	{
		private static ModelTypeClass typeClass = UserDefinedType.TypeClass;

		/// <summary>
		///	Create a strongly typed class UserDefinedType to adapt the TSqlObject 
		/// </summary>
		public UserDefinedType(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? ByteOrdered 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.UserDefinedType.ByteOrdered);}
		}

		public String ClassName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.UserDefinedType.ClassName);}
		}

		public Boolean? FixedLength 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.UserDefinedType.FixedLength);}
		}

		public Format Format 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Format>(Microsoft.SqlServer.Dac.Model.UserDefinedType.Format);}
		}

		public Int32? MaxByteSize 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.UserDefinedType.MaxByteSize);}
		}

		public String ValidationMethodName 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.UserDefinedType.ValidationMethodName);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly> Assembly 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UserDefinedType.Assembly).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Assembly)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> Methods 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UserDefinedType.Methods);
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> Properties 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UserDefinedType.Properties);
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.UserDefinedType.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class View : TSqlModelElement
	{
		private static ModelTypeClass typeClass = View.TypeClass;

		/// <summary>
		///	Create a strongly typed class View to adapt the TSqlObject 
		/// </summary>
		public View(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean? AnsiNullsOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.View.AnsiNullsOn);}
		}

		public Boolean? QuotedIdentifierOn 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean?>(Microsoft.SqlServer.Dac.Model.View.QuotedIdentifierOn);}
		}

		public Boolean Replicated 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.View.Replicated);}
		}

		public String SelectStatement 
		{
		// Supported platforms = 31
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.View.SelectStatement);}
		}

		public Boolean WithCheckOption 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.View.WithCheckOption);}
		}

		public Boolean WithEncryption 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.View.WithEncryption);}
		}

		public Boolean WithSchemaBinding 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.View.WithSchemaBinding);}
		}

		public Boolean WithViewMetadata 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.View.WithViewMetadata);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Model.TSqlObject> BodyDependencies 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.View.BodyDependencies);
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Columns 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.View.Columns).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.View.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class WorkloadGroup : TSqlModelElement
	{
		private static ModelTypeClass typeClass = WorkloadGroup.TypeClass;

		/// <summary>
		///	Create a strongly typed class WorkloadGroup to adapt the TSqlObject 
		/// </summary>
		public WorkloadGroup(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Int32 GroupMaxRequests 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.WorkloadGroup.GroupMaxRequests);}
		}

		public Degree Importance 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Degree>(Microsoft.SqlServer.Dac.Model.WorkloadGroup.Importance);}
		}

		public Int32 MaxDop 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.WorkloadGroup.MaxDop);}
		}

		public Int32 RequestMaxCpuTimeSec 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.WorkloadGroup.RequestMaxCpuTimeSec);}
		}

		public Int32 RequestMaxMemoryGrantPercent 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.WorkloadGroup.RequestMaxMemoryGrantPercent);}
		}

		public Int32 RequestMemoryGrantTimeoutSec 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.WorkloadGroup.RequestMemoryGrantTimeoutSec);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ResourcePool> ResourcePool 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.WorkloadGroup.ResourcePool).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.ResourcePool)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class XmlIndex : TSqlModelElement
	{
		private static ModelTypeClass typeClass = XmlIndex.TypeClass;

		/// <summary>
		///	Create a strongly typed class XmlIndex to adapt the TSqlObject 
		/// </summary>
		public XmlIndex(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowPageLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.AllowPageLocks);}
		}

		public Boolean AllowRowLocks 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.AllowRowLocks);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.Disabled);}
		}

		public Int32? FillFactor 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.XmlIndex.FillFactor);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 26
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.IgnoreDuplicateKey);}
		}

		public Boolean IsPrimary 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.IsPrimary);}
		}

		public Boolean RecomputeStatistics 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.RecomputeStatistics);}
		}

		public SecondaryXmlIndexType SecondaryXmlIndexType 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<SecondaryXmlIndexType>(Microsoft.SqlServer.Dac.Model.XmlIndex.SecondaryXmlIndexType);}
		}

		public Boolean WithPadIndex 
		{
		// Supported platforms = 27
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.XmlIndex.WithPadIndex);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Column 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.XmlIndex.Column).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.XmlIndex.IndexedObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.XmlIndex> PrimaryXmlIndex 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.XmlIndex.PrimaryXmlIndex).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.XmlIndex)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class SelectiveXmlIndex : TSqlModelElement
	{
		private static ModelTypeClass typeClass = SelectiveXmlIndex.TypeClass;

		/// <summary>
		///	Create a strongly typed class SelectiveXmlIndex to adapt the TSqlObject 
		/// </summary>
		public SelectiveXmlIndex(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean AllowPageLocks 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.AllowPageLocks);}
		}

		public Boolean AllowRowLocks 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.AllowRowLocks);}
		}

		public Boolean Disabled 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.Disabled);}
		}

		public Int32? FillFactor 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.FillFactor);}
		}

		public Boolean IgnoreDuplicateKey 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.IgnoreDuplicateKey);}
		}

		public Boolean IsPrimary 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.IsPrimary);}
		}

		public Boolean RecomputeStatistics 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.RecomputeStatistics);}
		}

		public Boolean WithPadIndex 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.WithPadIndex);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Column> Column 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.Column).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Column)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource> IndexedObject 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.IndexedObject).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlColumnSource>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PrimaryPromotedPath 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.PrimaryPromotedPath).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath>();
			}
		}
			//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.SelectiveXmlIndex> PrimarySelectiveXmlIndex 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.PrimarySelectiveXmlIndex).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.SelectiveXmlIndex)TSqlModelElement.AdaptInstance(o));
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath> PromotedPaths 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.PromotedPaths).Cast<Microsoft.SqlServer.Dac.Extensions.Prototype.ISqlPromotedNodePath>();
			}
		}
			//Composing
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.XmlNamespace> XmlNamespaces 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.SelectiveXmlIndex.XmlNamespaces).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.XmlNamespace)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class XmlNamespace : TSqlModelElement
	{
		private static ModelTypeClass typeClass = XmlNamespace.TypeClass;

		/// <summary>
		///	Create a strongly typed class XmlNamespace to adapt the TSqlObject 
		/// </summary>
		public XmlNamespace(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String NamespaceUri 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.XmlNamespace.NamespaceUri);}
		}

		public String Prefix 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.XmlNamespace.Prefix);}
		}


}
	public partial class PromotedNodePathForXQueryType : TSqlModelElement
	{
		private static ModelTypeClass typeClass = PromotedNodePathForXQueryType.TypeClass;

		/// <summary>
		///	Create a strongly typed class PromotedNodePathForXQueryType to adapt the TSqlObject 
		/// </summary>
		public PromotedNodePathForXQueryType(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean IsSingleton 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForXQueryType.IsSingleton);}
		}

		public Int32? MaxLength 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Int32?>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForXQueryType.MaxLength);}
		}

		public String NodePath 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForXQueryType.NodePath);}
		}

		public String Type 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForXQueryType.Type);}
		}


}
	public partial class PromotedNodePathForSqlType : TSqlModelElement
	{
		private static ModelTypeClass typeClass = PromotedNodePathForSqlType.TypeClass;

		/// <summary>
		///	Create a strongly typed class PromotedNodePathForSqlType to adapt the TSqlObject 
		/// </summary>
		public PromotedNodePathForSqlType(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public Boolean IsMax 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.IsMax);}
		}

		public Boolean IsSingleton 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<Boolean>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.IsSingleton);}
		}

		public Int32 Length 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.Length);}
		}

		public String NodePath 
		{
		// Supported platforms = 24
			get { return Element.GetProperty<String>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.NodePath);}
		}

		public Int32 Precision 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.Precision);}
		}

		public Int32 Scale 
		{
		// Supported platforms = 31
			get { return Element.GetProperty<Int32>(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.Scale);}
		}

		//Peer
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.DataType> DataType 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.PromotedNodePathForSqlType.DataType).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.DataType)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
	public partial class XmlSchemaCollection : TSqlModelElement
	{
		private static ModelTypeClass typeClass = XmlSchemaCollection.TypeClass;

		/// <summary>
		///	Create a strongly typed class XmlSchemaCollection to adapt the TSqlObject 
		/// </summary>
		public XmlSchemaCollection(TSqlObject obj)  : base(obj)
		{
		}

		public static ModelTypeClass TypeClass 
		{
			get { return typeClass;}
		}
		public String Expression 
		{
		// Supported platforms = 27
			get { return (String)Element.GetProperty(Microsoft.SqlServer.Dac.Model.XmlSchemaCollection.Expression);}
		}

		//Hierarchical
		public IEnumerable<Microsoft.SqlServer.Dac.Extensions.Prototype.Schema> Schema 
		{
			get 
			{
				return Element.GetReferenced(Microsoft.SqlServer.Dac.Model.XmlSchemaCollection.Schema).Select(o => (Microsoft.SqlServer.Dac.Extensions.Prototype.Schema)TSqlModelElement.AdaptInstance(o));
			}
		}
	
}
}