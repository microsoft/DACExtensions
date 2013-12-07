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