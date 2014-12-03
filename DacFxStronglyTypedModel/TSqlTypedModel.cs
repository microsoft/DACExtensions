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
    }
}
