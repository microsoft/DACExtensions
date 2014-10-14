using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{

    #region ISqlSecurityPrincipal

    public interface ISqlSecurityPrincipal { }

    public interface IServerSecurityPrincipal : ISqlSecurityPrincipal { }

    #endregion

    #region ISqlDatabaseSecurityPrincipal
    public interface ISqlDatabaseSecurityPrincipal : ISqlSecurityPrincipal, ISqlObjectAuthorizer
    {

    }

    public partial class Role : ISqlDatabaseSecurityPrincipal
    { }

    public partial class ApplicationRole : ISqlDatabaseSecurityPrincipal
    { }

    public partial class User : ISqlDatabaseSecurityPrincipal
    {     }
    #endregion

    #region ISqlTypeSpecifierBase
    public interface ISqlTypeSpecifierBase
    {
    }

    public partial class XmlTypeSpecifier : ISqlTypeSpecifierBase
    { }

    public partial class TypeSpecificier : ISqlTypeSpecifierBase
    {
    }
    #endregion

    #region ISqlColumnSource
    public interface ISqlColumnSource { }

    public partial class Table : ISqlColumnSource { }
    public partial class FileTable : ISqlColumnSource { }

    public partial class View : ISqlColumnSource { }
    public partial class TableValuedFunction: ISqlColumnSource { }
    public partial class Queue: ISqlColumnSource { }
    #endregion

    #region ISqlSecurable
    public interface ISqlSecurable
    { }
    public partial class ServerSecurityPrincipal : ISqlSecurable { }

    public partial class DatabaseSecurityPrincipal : ISqlSecurable { }

    public partial class Column : ISqlSecurable { }

    public partial class Certificate : ISqlSecurable { }

    public partial class DatabaseOptions : ISqlSecurable { }
    public partial class ServerOptions : ISqlSecurable { }
    public partial class TableType : ISqlSecurable { }
    public partial class Default : ISqlSecurable { }
    public partial class FullTextCatalog : ISqlSecurable { }
    public partial class FullTextStopList : ISqlSecurable { }
    public partial class SearchPropertyList : ISqlSecurable { }
    public partial class XmlSchemaCollection : ISqlSecurable { }
    public partial class Assembly : ISqlSecurable { }
    public partial class UserDefinedType : ISqlSecurable { }
    public partial class Schema : ISqlSecurable { }
    public partial class SymmetricKey : ISqlSecurable { }
    public partial class AsymmetricKey : ISqlSecurable { }
    public partial class Service : ISqlSecurable { }
    public partial class Contract : ISqlSecurable { }
    public partial class MessageType : ISqlSecurable { }
    public partial class Route : ISqlSecurable { }
    public partial class RemoteServiceBinding : ISqlSecurable { }
    public partial class Endpoint : ISqlSecurable { }

    #endregion

    #region SqlPromotedNodePathBase
    public interface ISqlPromotedNodePath
    {
    }

    public partial class PromotedNodePathForXQueryType : ISqlPromotedNodePath { }
    public partial class PromotedNodePathForSqlType : ISqlPromotedNodePath { } 
    #endregion

    #region ISqlIndex
    public interface ISqlIndex { }

    public partial class SqlIndex : ISqlIndex { }
    public partial class XmlIndex : ISqlIndex { }
    public partial class TableTypeIndex : ISqlIndex { }

    public partial class SelectiveXmlIndex : ISqlIndex { }

    public partial class SpatialIndex : ISqlIndex { }

    public partial class ColumnStoreIndex : ISqlIndex { }

    public partial class TableTypeIndex : ISqlIndex { }
    #endregion

    #region IExtendedProprtyHost
    public interface IExtendedPropertyHost { }

    #endregion

    #region ISqlObjectAuthorizer
    public interface ISqlObjectAuthorizer { }

    #endregion

    #region ITableTypeConstraint
    public interface ITableTypeConstraint { }
    public partial class TableTypeCheckConstraint : ITableTypeConstraint { }
    public partial class TableTypeDefaultConstraint : ITableTypeConstraint { }
    public partial class TableTypePrimaryKeyConstraint : ITableTypeConstraint { }
    public partial class TableTypeUniqueConstraint : ITableTypeConstraint { }
    #endregion
    
    #region IProtocolSpecifier

    public interface IProtocolSpecifier {}

    public partial class HttpProtocolSpecifier : IProtocolSpecifier { }

    public partial class TcpProtocolSpecifier : IProtocolSpecifier { }
    #endregion

    #region IEndpointLanguageSpecifier
    public interface IEndpointLanguageSpecifier { }

    public partial class SoapLanguageSpecifier : IEndpointLanguageSpecifier { }

    public partial class ServiceBrokerLanguageSpecifier : IEndpointLanguageSpecifier { }

    public partial class DatabaseMirroringLanguageSpecifier : IEndpointLanguageSpecifier { }
    #endregion
}

