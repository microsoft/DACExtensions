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

using Microsoft.SqlServer.Dac.CodeAnalysis;
using Microsoft.SqlServer.Dac.Model;

namespace Public.Dac.Samples.Rules
{
    internal static class RuleUtils
    {
        /// <summary>
        /// Gets a formatted element name with the default style <see cref="ElementNameStyle.EscapedFullyQualifiedName"/>
        /// </summary>
        public static string GetElementName(SqlRuleExecutionContext ruleExecutionContext, TSqlObject modelElement)
        {
            return GetElementName(modelElement, ruleExecutionContext, ElementNameStyle.EscapedFullyQualifiedName);
        }

        /// <summary>
        /// Gets a formatted element name
        /// </summary>
        public static string GetElementName(TSqlObject modelElement, SqlRuleExecutionContext ruleExecutionContext, ElementNameStyle style)
        {
            // Get the element name using the built in DisplayServices. This provides a number of useful formatting options to
            // make a name user-readable
            var displayServices = ruleExecutionContext.SchemaModel.DisplayServices;
            string elementName = displayServices.GetElementName(modelElement, style);
            return elementName;
        }
    }
}
