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
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
    public sealed class TSqlTypedModel
    {
        TSqlModel model;

        public TSqlTypedModel(TSqlModel model)
        {
            this.model = model;
        }

        public IEnumerable<T> GetObjects<T>(DacQueryScopes queryScope) where T : ISqlModelElement
        {
            // Map the System.Type to a set of ModelType classes that extend the type or implement the interface
            foreach( ModelTypeClass modelType in UtilityMethods.GetModelElementTypes(typeof(T)))
            {
                foreach(var element in model.GetObjects(queryScope, modelType))
                {
                    // Adapt instance with strongly type wrapper.
                    yield return (T)TSqlModelElement.AdaptInstance(element);
                }
            }           
        }

        public IEnumerable<T> GetObjects<T>(ObjectIdentifier id, DacQueryScopes queryScope) where T : ISqlModelElement
        {
            // Map the System.Type to a set of ModelType classes that extend the type or implement the interface
            foreach (ModelTypeClass modelType in UtilityMethods.GetModelElementTypes(typeof(T)))
            {
                foreach (var element in model.GetObjects(modelType,id, queryScope))
                {
                    // Adapt instance with strongly type wrapper.
                    yield return (T)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public T GetObject<T>(ObjectIdentifier id, DacQueryScopes queryScope) where T : ISqlModelElement
        {
            return GetObjects<T>(id, queryScope).FirstOrDefault();
        }
    }
}
