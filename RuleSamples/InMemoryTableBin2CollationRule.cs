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

using Microsoft.SqlServer.Dac.CodeAnalysis;
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// This is a SQL rule which warns if an Index on a Memory Optimized table targets a character column that does
    /// not use BIN2 collation. This would cause an error at deployment time so this is an important rule to support.
    /// 
    /// </summary>
    [LocalizedExportCodeAnalysisRule(InMemoryTableBin2CollationRule.RuleId,
        RuleConstants.ResourceBaseName,                         // Name of the resource file to look up displayname and description in
        RuleConstants.InMemoryBinCollection_RuleName,           // ID used to look up the display name inside the resources file
        RuleConstants.InMemoryBinCollection_ProblemDescription, // ID used to look up the description inside the resources file
        Category = RuleConstants.CategoryPerformance,           // Rule category (e.g. "Design", "Naming")
        RuleScope = SqlRuleScope.Element)]                      // This rule targets specific elements rather than the whole model
    public sealed class InMemoryTableBin2CollationRule : SqlCodeAnalysisRule
    {
        public const string RuleId = "Public.Dac.Samples.SR1101";
        private const string Bin2Ending = "BIN2";

        private readonly static HashSet<SqlDataType> CharacterDataTypes = new HashSet<SqlDataType>()
        {
            SqlDataType.Char,
            SqlDataType.NChar,
            SqlDataType.VarChar,
            SqlDataType.NVarChar,

            //Text and NText are not currently supported. If this changes in future versions, would also check for these
            // SqlDataType.Text,
            // SqlDataType.NText
        }; 

        public InMemoryTableBin2CollationRule()
        {
            // Mark what types of element this rule should be passed. In this case we care about indexes, but we
            // choose to disable FullTextIndex and ColumnStoreIndex as these are not currently supported on in-memory tables.
            // If this changes in the future these may need to be enabled.
            SupportedElementTypes = new[]
            {
                ModelSchema.Index,
                // ModelSchema.FullTextIndex,
                // ModelSchema.ColumnStoreIndex,
            };
        }

        public override IList<SqlRuleProblem> Analyze(SqlRuleExecutionContext context)
        {
            IList<SqlRuleProblem> problems = new List<SqlRuleProblem>();
            TSqlObject index = context.ModelElement;

            if (!IsIndexOnMemoryOptimizedTable(index))
            {
                // Only examining memory optimized tables, anything else can be ignored
                // Note the call to the Table.MemoryOptimized property: this is where we verify the in-memory behavior
                return problems;
            }

            TSqlObject databaseOptions = context.SchemaModel
                .GetObjects(DacQueryScopes.UserDefined, DatabaseOptions.TypeClass).SingleOrDefault();

            if (databaseOptions == null)
            {
                // This should never happen as the database options are automatically created
                return problems;
            }

            string defaultCollation = databaseOptions.GetProperty<string>(DatabaseOptions.Collation);

            AnalyzeColumns(context, index, defaultCollation, problems);

            return problems;
        }

        private static void AnalyzeColumns(
            SqlRuleExecutionContext context,
            TSqlObject index, 
            string defaultCollation,
            IList<SqlRuleProblem> problems)
        {
            foreach (TSqlObject column in index.GetReferenced(Index.Columns)
                                               .Where(column => IsCharacterColumn(column)))
            {
                // Fall back on the default project collation if none is defined for the specific column
                 string collation = column.GetProperty<string>(Column.Collation) ?? defaultCollation ?? string.Empty;
                if (!collation.EndsWith(Bin2Ending, StringComparison.OrdinalIgnoreCase))
                {
                    // Error looks liks "Index <name> on column <name> should have a BIN2 collation instead of <collation>"
                    // Choosing to add 1 problem per-column. This will cause more warnings in the error manager but is more precise
                    string errorMsg = string.Format(CultureInfo.CurrentCulture,
                        context.RuleDescriptor.DisplayDescription,
                        RuleUtils.GetElementName(index, context, ElementNameStyle.EscapedFullyQualifiedName),
                        RuleUtils.GetElementName(column, context, ElementNameStyle.EscapedFullyQualifiedName),
                        collation);

                    SqlRuleProblem problem = new SqlRuleProblem(errorMsg, index);
                    problems.Add(problem);
                }
            }
        }

        private static bool IsIndexOnMemoryOptimizedTable(TSqlObject index)
        {
            TSqlObject targetTable = index.GetReferenced(Index.IndexedObject).SingleOrDefault();
            return targetTable != null
                    && Table.TypeClass.Equals(targetTable.ObjectType)
                    && targetTable.GetProperty<bool>(Table.MemoryOptimized);
        }

        private static bool IsCharacterColumn(TSqlObject column)
        {
            TSqlObject dataType = column.GetReferenced(Column.DataType).SingleOrDefault();

            if (dataType == null)
            {
                return false;
            }

            // Note: User Defined Data Types (UDDTs) are not supported during deployment of memory optimized tables. 
            // The code below handles UDDTs in order to show how properties of a UDDT should be accessed and because
            // the model validation does not actually block this syntax at present there are tests that validate this behavior. 
 
            // User Defined Data Types and built in types are merged in the public model.
            // We want to examine the built in type: for user defined data types this will be
            // found by accessing the DataType.Type object, which will not exist for a built in type
            TSqlObject builtInType = dataType.GetReferenced(DataType.Type).SingleOrDefault();
            if (builtInType != null)
            {
                dataType = builtInType;
            }

            SqlDataType sqlDataType = dataType.GetProperty<SqlDataType>(DataType.SqlDataType);
            return CharacterDataTypes.Contains(sqlDataType);
        }
    }
}
