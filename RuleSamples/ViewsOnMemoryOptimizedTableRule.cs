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
using Microsoft.SqlServer.Dac.Extensibility;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System.Collections.Generic;
using System.Globalization;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// This is a SQL rule which warns if an View references a memory optimized table but does not include a SCHEMABINDING view attribute.
    /// In many ways this is more of a validation rule than a code analysis rule, since these issues will block deployment.
    /// While at some point these rules might be incorporated into the core product, they provide useful examples of how to implement
    /// a code analysis rule and hence are included in these samples.
    /// 
    /// An interesting coding challenge is to abstract this method to check for other elements referencing a memory optimized table
    /// and verify that all of these references are supported in SQL Server 2014.
    /// 
    /// This rule will only be visible if running against SQL Server 2014 (version 12.0 or Sql120) as it is not relevant in earlier platforms.
    /// </summary>
    [LocalizedExportCodeAnalysisRule(ViewsOnMemoryOptimizedTableRule.RuleId,
        RuleConstants.ResourceBaseName,                         
        RuleConstants.ViewsOnMemoryOptimizedTable_RuleName,           
        null,   // In this case we will use the description lookup directly from the resources file, as it's easier and we have more than 1
                // possible problem description depending on the issue found
        RuleScope = SqlRuleScope.Element,
        PlatformCompatibility = TSqlPlatformCompatibility.Sql120)]         // Only allow this rule against SQL Server 2014             
    public sealed class ViewsOnMemoryOptimizedTableRule : SqlCodeAnalysisRule
    {
        public const string RuleId = "Public.Dac.Samples.SR1102";

        public ViewsOnMemoryOptimizedTableRule()
        {
            // Even though we care about views, we will navigate from Tables to referencing views. 
            // This is a little easier since we start at a memory-optimized table and work out to examine
            // any relevant objects that reference it
            SupportedElementTypes = new[]
            {
                ModelSchema.Table,
            };
        }

        public override IList<SqlRuleProblem> Analyze(SqlRuleExecutionContext context)
        {
            IList<SqlRuleProblem> problems = new List<SqlRuleProblem>();
            TSqlObject table = context.ModelElement;

            if (table.GetProperty<bool>(Table.MemoryOptimized))
            {
                // In this case we look up "Referencing" relationships. This is a way to iterate 
                // over the objects that reference the current object. Note how the actual relationship
                // that we care about is defined on the View class rather than on the table.
                foreach (TSqlObject view in table.GetReferencing(View.BodyDependencies))
                {
                    ValidateViewHasSchemaBinding(context, view, table, problems);
                    ValidateViewHasNoIndexes(context, view, table, problems);
                }
            }
            
            return problems;
        }

        /// <summary>
        // Views must be schema bound if they reference a memory optimized table
        /// </summary>
        private static void ValidateViewHasSchemaBinding(SqlRuleExecutionContext context, TSqlObject view, TSqlObject table,
            IList<SqlRuleProblem> problems)
        {
            if (!view.GetProperty<bool>(View.WithSchemaBinding))
            {
                string description = string.Format(CultureInfo.CurrentCulture,
                    RuleResources.ViewsOnMemoryOptimizedTable_SchemaBindingProblemDescription,
                    RuleUtils.GetElementName(context, view),
                    RuleUtils.GetElementName(context, table));
                TSqlFragment nameFragment = TsqlScriptDomUtils.LookupSchemaObjectName(view);
                problems.Add(new SqlRuleProblem(description, view, nameFragment));
            }
        }

        /// <summary>
        /// No Indexes of any kind are allowed on Views that reference a memory optimized table.
        /// </summary>
        private void ValidateViewHasNoIndexes(SqlRuleExecutionContext context, TSqlObject view, TSqlObject table, IList<SqlRuleProblem> problems)
        {
            foreach (TSqlObject index in view.GetReferencing(Index.IndexedObject))
            {
                string description = string.Format(CultureInfo.CurrentCulture,
                    RuleResources.ViewsOnMemoryOptimizedTable_IndexProblemDescription,
                    RuleUtils.GetElementName(context, index),
                    RuleUtils.GetElementName(context, view),
                    RuleUtils.GetElementName(context, table));
                TSqlFragment nameFragment = TsqlScriptDomUtils.LookupSchemaObjectName(index);

                // Note that nameFragment can be null - in this case the index's position information will be used.
                // This is just a little less precise than pointing to the position of the name for that index
                problems.Add(new SqlRuleProblem(description, index, nameFragment));

            }
        }

    }
}
