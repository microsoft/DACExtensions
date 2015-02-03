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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// This is probably the simplest possible example of a rule that uses the public model API to analyze properties of elements.
    /// In this case any table whose name ends in "View" is treated as a problem.
    /// 
    /// This does not use a localized export attribute, unlike the <see cref="AvoidWaitForDelayRule"/> and other rules. It is
    /// not recommended that you use this code in a real world scenario
    /// </summary>
    [ExportCodeAnalysisRule(TableNameEndingInViewRule.RuleId,
        TableNameEndingInViewRule.RuleDisplayName,
        Description = "Table names should not end in 'View'",
        Category = "Naming",
        RuleScope = SqlRuleScope.Element)]
    public sealed class TableNameEndingInViewRule : SqlCodeAnalysisRule
    {
        public const string RuleId = "Public.Dac.Samples.Rules.TableNameEndingInViewRule";
        public const string RuleDisplayName = "SqlSampleRule001";
        public const string NameEndingInViewMsgFormat = "Table name {0} ends in View. This can cause confusion and should be avoided";

        /// <summary>
        /// For Element-scoped rules the SupportedElementTypes must be defined, ideally inside the constructor.
        /// Only objects that match one of these types will be passed to the <see cref="Analyze"/> method, so this
        /// helps avoid the need to iterate over the model and select the object to be processed.
        /// 
        /// This rule only operates on regular Tables.
        /// </summary>
        public TableNameEndingInViewRule()
        {
            SupportedElementTypes = new[] { Table.TypeClass };
        }

        /// <summary>
        /// Analysis is quite simple - the table's name is examined and if it ends with "View" then a problem
        /// is created
        /// </summary>
        /// <param name="ruleExecutionContext"></param>
        /// <returns></returns>
        public override IList<SqlRuleProblem> Analyze(SqlRuleExecutionContext ruleExecutionContext)
        {
            List<SqlRuleProblem> problems = new List<SqlRuleProblem>();
            TSqlObject table = ruleExecutionContext.ModelElement;
            if (table != null)
            {
                if (NameEndsInView(table.Name))
                {
                    // DisplayServices is a useful helper service for formatting names
                    DisplayServices displayServices = ruleExecutionContext.SchemaModel.DisplayServices;
                    string formattedName = displayServices.GetElementName(table, ElementNameStyle.FullyQualifiedName);

                    string problemDescription = string.Format(NameEndingInViewMsgFormat,
                                                              formattedName);
                    SqlRuleProblem problem = new SqlRuleProblem(problemDescription, table);
                    problems.Add(problem);
                }
            }

            return problems;
        }

        private bool NameEndsInView(ObjectIdentifier id)
        {
            return id.HasName && id.Parts.Last().EndsWith("View", StringComparison.OrdinalIgnoreCase);
        }
    }
}
