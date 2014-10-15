using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
   
    public interface ISqlSecurityPrincipal { }

    public interface IServerSecurityPrincipal : ISqlSecurityPrincipal { }

    public interface ISqlDatabaseSecurityPrincipal : ISqlSecurityPrincipal, ISqlObjectAuthorizer{ }

    public interface ISqlSecurable { }
    public interface ISqlColumnSource { }
    public interface ISqlPromotedNodePath{ }
    public interface ISqlIndex { }
    public interface ITableTypeConstraint { }
    public interface IProtocolSpecifier { }
    public interface IEndpointLanguageSpecifier { }

    #region ISqlTypeSpecifierBase
    public interface ISqlTypeSpecifierBase
    {
    }
    //XmlTypeSpecifier seems to be missing from model
    public partial class XmlTypeSpecifier : ISqlTypeSpecifierBase
    { }
    //TypeSpecificier seems to be missing from model
    public partial class TypeSpecificier : ISqlTypeSpecifierBase
    {
    }
    #endregion

    #region IExtendedProprtyHost
    public interface IExtendedPropertyHost { }

    //TODO: Collect all extended property hosts. Some added but lots missing
    #endregion

    #region ISqlObjectAuthorizer
    public interface ISqlObjectAuthorizer { }
    // TODO: Collect all Authorizers
    #endregion

}

