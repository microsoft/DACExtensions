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

namespace Public.Dac.Samples
{
    /// <summary>
    /// Simple filter that compares to schema name. Note that this does not use the model
    /// collation - for a more robust filter an <see cref="IEqualityComparer{T}"/> would be
    /// used that checked the collation.
    /// </summary>
    public class SchemaBasedFilter : IFilter
    {
        public const string SchemaNameArg = "Schema";

        public enum FilterType
        {
            /// <summary>
            /// Default
            /// </summary>
            Exclude,
            Include
        }

        private HashSet<string> _schemaNames;

        /// <summary>
        /// Creates a filter for the specified <paramref name="schemaNames"/>, with the
        /// default filtering behavior to remove objects with the given schema names.
        /// </summary>
        /// <param name="schemaNames"></param>
        public SchemaBasedFilter(params string[] schemaNames)
            : this((IList<string>) schemaNames)
        {
        }

        /// <summary>
        /// Creates a filter for the specified <paramref name="schemaNames"/>, with the
        /// default filtering behavior to remove objects with the given schema names.
        /// </summary>
        /// <param name="schemaNames"></param>
        public SchemaBasedFilter(IList<string> schemaNames)
        {
            _schemaNames = new HashSet<string>(schemaNames);
            Filtering = FilterType.Exclude;
        }

        /// <summary>
        /// This would be called by a deployment contributor to initialize the filter. The 
        /// assumption is that in the code that runs the deployment, a number of arguments
        /// "Schema1=dev;Schema2=test" would be passed into the contributor arguments
        /// </summary>
        public void Initialize(Dictionary<string, string> filterArguments)
        {
            var schemaNames = filterArguments
                .Where(pair => pair.Key.StartsWith(SchemaNameArg))
                .Select(pair => pair.Value);

            _schemaNames = new HashSet<string>(schemaNames);

            // Currently there is no "FilterType" argument that would allow us to
            // specify the filter's behavior. For now, will always by in "Exclude" mode 
        }

        /// <summary>
        /// What type of filtering to use. Defaults to <see cref="FilterType.Exclude"/>
        /// </summary>
        public FilterType Filtering
        {
            get; 
            set;
        }
        
        public IEnumerable<TSqlObject> Filter(IEnumerable<TSqlObject> tSqlObjects)
        {
            return tSqlObjects.Where(o => ShouldInclude(o));
        }


        private bool ShouldInclude(TSqlObject tsqlObject)
        {
            // almost all top-level TSqlObjects are expected to have a name.
            // The ObjectIdentifier 
            bool found = false;
            ObjectIdentifier id = tsqlObject.Name;
            if (id.HasName && id.Parts.Count >= 1)
            {
                // Assuming schema name is always the first part. 
                string schemaName = id.Parts[0];
                found = _schemaNames.Contains(schemaName, StringComparer.OrdinalIgnoreCase);
            }

            if (Filtering == FilterType.Exclude)
            {
                // exclude any objects whose schema was in the filter list
                return !found;
            }
            return found;
        }
    }
}
