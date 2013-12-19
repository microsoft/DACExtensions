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
using Microsoft.SqlServer.Dac.Model;
using System.Collections.Generic;

namespace Public.Dac.Samples
{
    /// <summary>
    /// A Filter should take in a set of TSqlObjects, filter them based on some criteria,
    /// and return a (smaller) set of objects.
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Filter a stream of TSqlObjects based on some criteria
        /// </summary>
        /// <param name="tSqlObjects">the objects to filter</param>
        /// <returns>some filtered set of objects</returns>
        IEnumerable<TSqlObject> Filter(IEnumerable<TSqlObject> tSqlObjects);

        /// <summary>
        /// Provides a chance to initialize the filter based on some set of key-value pairs.
        /// Note that this kind of method would be better in an abstract parent class than in an interface
        /// since only some filters would need this. This would be something to improve on if using this in a real application
        /// </summary>
        /// <param name="filterArguments">set of key value pairs that can be used to initialize the filter</param>
        void Initialize(Dictionary<string, string> filterArguments);
    }
}
