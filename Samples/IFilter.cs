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
    }
}
