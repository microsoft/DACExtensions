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
using Microsoft.SqlServer.Dac.Extensions.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
    // All additions here are to fill  in gaps in the mapping of the public model.
    // These issues should be fixed by the product team
    public partial class TSqlTableValuedFunction
    {
        public IEnumerable<TSqlColumn> Columns
        {
            get
            {
                //Microsoft.SqlServer.Dac.Model.TableValuedFunction
                throw new NotImplementedException("Columns in not implmeneted on TablueValuedFunctions");
            }
        }
    }   
}
