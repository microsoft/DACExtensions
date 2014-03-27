
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
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// This rule enforces an initial capitalized letter be used to begin every object name in the model.
    /// This rule has <see cref="SqlRuleScope.Model"/> and hence is only called once during analysis, with
    /// the entire model passed in. 
    /// 
    /// This implementation only examines the names of objects in the model. It does not enforce what name
    /// is used when referencing another object, but the built-in validation rules should warn when a name
    /// differs only in capitalization. 
    ///  
    /// </summary>
    [LocalizedExportCodeAnalysisRule(CapitalizedNamesRule.RuleId,
        RuleConstants.ResourceBaseName, // Name of the resource file to look up displayname and description in
        RuleConstants.CapitalizedNames_RuleName, // ID used to look up the display name inside the resources file
        null,
        // ID used to look up the description inside the resources file
        Category = RuleConstants.CategoryNaming, // Rule category (e.g. "Design", "Naming")
        RuleScope = SqlRuleScope.Model)] // This rule targets the whole model
    public sealed class CapitalizedNamesRule : SqlCodeAnalysisRule
    {
        public const string RuleId = "Public.Dac.Samples.SR1103";

        private TSqlModel _model;

        public override IList<SqlRuleProblem> Analyze(SqlRuleExecutionContext context)
        {
            List<SqlRuleProblem> problems = new List<SqlRuleProblem>();
            _model = context.SchemaModel;

            // Query all top level user-defined objects in the model. This restricts scope to objects actually defined
            // in this model, rather than same database references, built in types, or system references
            foreach (TSqlObject tSqlObject in _model.GetObjects(DacQueryScopes.UserDefined))
            {
                AnalyzeObject(tSqlObject, problems);
            }

            return problems;
        }

        private void AnalyzeObject(TSqlObject tSqlObject, List<SqlRuleProblem> problems)
        {
            CheckIfCapitalized(tSqlObject, problems);

            foreach (TSqlObject child in GetComposedChildren(tSqlObject))
            {
                AnalyzeObject(child, problems);
            }
        }

        /// <summary>
        /// Filter referenced objects to only return composed children. These are objects that have a real
        /// parent-child relationship and couldn't be defined on their own. The canonical example is that
        /// a Table->Column is a composing relationship and we'd only get to navigate to the Column via the Table
        /// reference. To avoid loops we don't want to traverse Hierarchical or Peer relationships. Those can refer to other 
        /// top-level objects or objects that are composed children of a different top-level object, and hence would
        /// cause us to iterate multiple times over an object in the model.
        /// 
        /// Note that <see cref="TSqlObject.GetReferencedRelationshipInstances()"/> may return relationships
        /// where there is no object to in the model for the reference. This can happen if the object on that 
        /// side of the relationship is from a referenced dacpac. Hence we check that the 
        /// <see cref="ModelRelationshipInstance.Object"/> is not null when filtering our objects
        /// </summary>
        private IEnumerable<TSqlObject> GetComposedChildren(TSqlObject tSqlObject)
        {
            return from rel
                   in tSqlObject.GetReferencedRelationshipInstances(DacExternalQueryScopes.UserDefined)
                   where rel.Relationship.Type == RelationshipType.Composing && rel.Object != null
                   select rel.Object;
        }

        /// <summary>
        /// Checks if an object is:
        /// - Named
        /// - Starts with a letter or digit. This filters our parameters starting with '@', but may filter out other
        ///   objects you wish to test for. This is where you would extend the logic for more advanced cases
        /// - The first letter is not uppercase.
        /// </summary>
        private void CheckIfCapitalized(TSqlObject tSqlObject, List<SqlRuleProblem> problems)
        {
            ObjectIdentifier name = tSqlObject.Name;
            if (name != null
                && name.HasName
                && name.Parts.Count > 0)    // This check is equivalent to name.HasHame, including in case you don't trust the framework and want to verify yourself
            {
                string actualName = name.Parts[name.Parts.Count - 1];
                if (!string.IsNullOrEmpty(actualName)
                    && Char.IsLetterOrDigit(actualName[0])
                    && !Char.IsUpper(actualName[0]))
                {
                    string description = string.Format(CultureInfo.CurrentCulture,
                        RuleResources.CapitalizedNames_ProblemDescription,
                        _model.DisplayServices.GetElementName(tSqlObject, ElementNameStyle.EscapedFullyQualifiedName));

                    // Name fragment would have more precise location information than the overall object.
                    // This can be null, in which case the object's position will be used.
                    // note that the current implementation does not work for non-top level types as it
                    // relies on the TSqlModelUtils.TryGetFragmentForAnalysis() method which doesn't support these.
                    TSqlFragment nameFragment = TsqlScriptDomUtils.LookupSchemaObjectName(tSqlObject);

                    problems.Add(new SqlRuleProblem(description, tSqlObject, nameFragment));

                }
            }
        }
    }
}
