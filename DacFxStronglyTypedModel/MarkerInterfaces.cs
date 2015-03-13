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

    public interface ISpecifiesStorage
    {
        IEnumerable<TSqlDataCompressionOption> DataCompressionOptions { get; }

    }
}

