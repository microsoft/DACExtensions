//------------------------------------------------------------------------------
// <copyright company="Microsoft">
//   Copyright 2013 Microsoft
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
using System.Collections.Generic;
using Microsoft.SqlServer.Dac.Model;

namespace Public.Dac.Samples
{
    /// <summary>
    /// Combines a bunch of filters together. 
    /// </summary>
    public class CompositeFilter : IFilter
    {
        private readonly IList<IFilter> _filters;

        public CompositeFilter(IList<IFilter> filters)
        {
            _filters = filters;
        }

        public IEnumerable<TSqlObject> Filter(IEnumerable<TSqlObject> tSqlObjects)
        {
            foreach (IFilter filter in _filters)
            {
                tSqlObjects = filter.Filter(tSqlObjects);
            }

            return tSqlObjects;
        }

        public void Initialize(Dictionary<string, string> filterArguments)
        {
            // Do nothing
        }
    }
}