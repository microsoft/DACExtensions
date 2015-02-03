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
