//------------------------------------------------------------------------------
// <copyright company="Microsoft">
//   Copyright 2014 Microsoft
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
// </copyright>
//------------------------------------------------------------------------------
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

    public interface ISpecifiesIndex
    {
        IEnumerable<ISqlIndex> Indexes { get; }
    }

    public interface ISpecifiesDmlTrigger
    {
        IEnumerable<TSqlDmlTrigger> Triggers { get; }
    }

    public interface ISqlColumnSource 
    {
        IEnumerable<TSqlColumn> Columns { get; }        
    }
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

