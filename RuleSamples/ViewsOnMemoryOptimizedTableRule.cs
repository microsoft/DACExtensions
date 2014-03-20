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

using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.CodeAnalysis;
using Microsoft.SqlServer.Dac.Extensibility;
using Microsoft.SqlServer.Dac.Model;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.SqlServer.TransactSql.ScriptDom;

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
                problems.Add(new SqlRuleProblem(description, index, nameFragment));

            }
        }

    }
}
