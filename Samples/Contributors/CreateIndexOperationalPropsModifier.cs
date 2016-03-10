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

using Microsoft.SqlServer.Dac.Deployment;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Public.Dac.Samples.Contributors
{
    /// <summary>
    /// Supports specifying operational properties on a CreateIndex statement. These are not modeled in DacFx but
    /// can have an effect on the performance of index creation.
    /// </summary>
    /// <remarks>
    /// This contributor solves a real-world problem that users have asked about. Operational properties
    /// can have an impact on 
    /// </remarks>
    [ExportDeploymentPlanModifier(ContributorId, "1.0.0.0")]
    public class CreateIndexOperationalPropsModifier : DeploymentPlanModifier
    {
        public const string ContributorId = "Public.Dac.Samples.Contributors.CreateIndexOperationalPropsModifier";
        
        public const string OnlineArg = "CreateIndexOperationalPropsModifier.Online";

        public const string MaxDopArg = "CreateIndexOperationalPropsModifier.MAXDOP";
        
        public const string OptionOn = "ON";
        public const string OptionOff = "OFF";

        private readonly Dictionary<string, OptionDefinition> _optionArgumentMap = 
            new Dictionary<string, OptionDefinition>
        {
            {OnlineArg, new OptionDefinition(IndexOptionKind.Online, true)},
            {MaxDopArg, new OptionDefinition(IndexOptionKind.MaxDop, false)},
        };

        protected override void OnExecute(DeploymentPlanContributorContext context)
        {
            IList<IndexOption> options = ConvertArgsToOptions(context);
            if (options.Count > 0)
            {
                ChangeCreateIndexOperationalProps(context, options);
            }
        }

        private IList<IndexOption> ConvertArgsToOptions(DeploymentPlanContributorContext context)
        {
            List<IndexOption> options = new List<IndexOption>();

            foreach(var entry in context.Arguments)
            {
                OptionDefinition optionDefinition;
                if (_optionArgumentMap.TryGetValue(entry.Key, out optionDefinition))
                {
                    IndexOption option = optionDefinition.CreateOption(entry.Value);
                    if (option != null)
                    {
                        options.Add(option);
                    }
                }
            }

            return options;
        }


        private void ChangeCreateIndexOperationalProps(DeploymentPlanContributorContext context, 
            IList<IndexOption> options)
        {
            DeploymentStep nextStep = context.PlanHandle.Head;

            // Loop through all steps in the deployment plan
            bool foundMainSection = false;
            while (nextStep != null)
            {
                DeploymentStep currentStep = nextStep;
                nextStep = currentStep.Next;

                // We only want to analyze the main part of the deployment script - we'll skip 
                // any steps until we pass the end of the predeployment section, and stop once
                // we hit the start of the postdeployment section
                if (currentStep is EndPreDeploymentScriptStep)
                {
                    foundMainSection = true;
                    continue;
                }

                if (!foundMainSection)
                {
                    // Haven't gotten past predeployment yet
                    continue;
                }

                if (currentStep is BeginPostDeploymentScriptStep)
                {
                    break;
                }

                // We need to care about CreateElementSteps and AlterElementSteps for Indexes. 
                DeploymentScriptDomStep domStep = currentStep as DeploymentScriptDomStep;
                TSqlObject elementObject = null;

                if (domStep is CreateElementStep)
                {
                    elementObject = ((CreateElementStep)domStep).SourceElement;
                    
                }
                else if (domStep is AlterElementStep)
                {
                    elementObject = ((AlterElementStep)domStep).SourceElement;
                }

                if (elementObject != null)
                {
                    if (Index.TypeClass.Equals(elementObject.ObjectType) && !(View.TypeClass.Equals(elementObject.GetParent().ObjectType)))
                    {
                        TSqlFragment fragment = domStep.Script;

                        IndexStatementVisitor visitor = new IndexStatementVisitor(options);
                        fragment.Accept(visitor);
                    }
                }
            }
        }

        /// <summary>
        /// A <see cref="TSqlConcreteFragmentVisitor"/> that updates the index options on a Create or Alter Index statement
        /// </summary>
        private class IndexStatementVisitor : TSqlConcreteFragmentVisitor
        {
            private readonly Dictionary<IndexOptionKind, IndexOption> _optionKindToOptionMap;
            public IndexStatementVisitor(IEnumerable<IndexOption> indexOptions)
            {
                _optionKindToOptionMap = new Dictionary<IndexOptionKind, IndexOption>();
                foreach (IndexOption option in indexOptions)
                {
                    _optionKindToOptionMap[option.OptionKind] = option;
                }
            }

            /// <summary>
            /// Add all options to the list of index options, overriding existing values if present
            /// </summary>
            public override void ExplicitVisit(CreateIndexStatement node)
            {
                IndexExplicitVisit(node);
            }

            /// <summary>
            /// Add all options to the list of index options, overriding existing values if present
            /// </summary>
            public override void ExplicitVisit(AlterIndexStatement node)
            {
                IndexExplicitVisit(node);
            }

            /// <summary>
            /// Cannot override the sealed method ExplicitIndex(IndexStatement node) in TSqlConcreteFragmentVisitor so working around that
            /// with this method that the create and alter overrides can call.
            /// </summary>
            /// <param name="node">IndexStatement node to change options on</param>
            private void IndexExplicitVisit(IndexStatement node)
            {
                // IndexOptions is not expected to be null, since it can't be overridden
                if (node.IndexOptions != null)
                {

                    // Remove existing values if we need to overwrite them
                    List<IndexOption> existingOptions = new List<IndexOption>(node.IndexOptions);
                    foreach (IndexOption option in existingOptions)
                    {
                        IndexOption updatedOption;
                        if (_optionKindToOptionMap.TryGetValue(option.OptionKind, out updatedOption))
                        {
                            node.IndexOptions.Remove(option);
                        }
                    }

                    // Add the new values
                    foreach (var option in _optionKindToOptionMap.Values)
                    {
                        node.IndexOptions.Add(option);
                    }
                }
            }
        }

        private class OptionDefinition
        {
            private IndexOptionKind _kind;
            private bool _isStateOption;

            public OptionDefinition(IndexOptionKind kind, bool isStateOption)
            {
                _kind = kind;
                _isStateOption = isStateOption;
            }

            public IndexOption CreateOption(string argumentValue)
            {
                if (_isStateOption)
                {
                    return CreateStateOption(argumentValue);
                }
                return CreateExpressionOption(argumentValue);
            }

            private IndexOption CreateExpressionOption(string argumentValue)
            {
                int value;
                if (int.TryParse(argumentValue, out value))
                {
                    return new IndexExpressionOption
                    {
                        OptionKind = _kind,
                        Expression = new IntegerLiteral { Value = argumentValue }
                    };
                }

                return null;
            }

            private IndexOption CreateStateOption(string argumentValue)
            {
                OptionState state;
                if (string.Compare(OptionOn, argumentValue, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    state = OptionState.On;
                }
                else if (string.Compare(OptionOff, argumentValue, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    state = OptionState.Off;
                }
                else
                {
                    return null;
                }

                return new IndexStateOption
                {
                    OptionKind = _kind,
                    OptionState = state
                };
            }
        }
    }
}
