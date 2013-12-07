using System;
using System.Runtime.Remoting.Messaging;
using Microsoft.SqlServer.Dac.Model;
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
