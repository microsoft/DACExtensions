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
    /// This deployment contributor explicitly names unnamed default constraints with a auto-generated GUID name.
    /// </summary>
    /// <remarks>
    /// This sample was created based on an actual customer scenario where there was a mixture of 'named' and un-named default constraints
    /// The reason 'named' is in quotes is that in that scenario the name was actually a previously auto-generated default constraint name
    /// (for example the 'named' constraint was named DF__Contoso_A__IsOld__3BEC4C22).
    /// 
    /// Due to a non-deterministic order in which these constraints get deployed by DacFX, if the unnamed constraint was deployed first, and then
    /// an named constraint deployed afterwards, in some rare cases the deployment due to a name clash.
    /// 
    /// This sample aims to fix the issue by explicitly naming all unnamed default constraints.
    /// </remarks>
    [ExportDeploymentPlanModifier(ContributorId, "1.0.0.0")]
    public class DefaultConstraintNameModifier : DeploymentPlanModifier
    {
        public const string ContributorId = "Public.Dac.Samples.Contributors.DefaultConstraintNameModifier";
        
        protected override void OnExecute(DeploymentPlanContributorContext context)
        {
            this.FindAndRenameUnnamedDefaultConstraints(context);
        }

        private void FindAndRenameUnnamedDefaultConstraints(DeploymentPlanContributorContext context)
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

                // We need to care about CreateElementSteps and AlterElementSteps for default constraints. 
                DeploymentScriptDomStep domStep = currentStep as DeploymentScriptDomStep;
                TSqlObject elementObject = null;

                // most of the default constraints in the deployment plan seem to be deployed as Alter Table statements, but
                // just in case the default constraint was deployed as part of a Create Table (don't see how it is possible, but just being safe)
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
                    TSqlFragment fragment = domStep.Script;

                    // call the visitor, which in turn will auto-name these constraints
                    var visitor = new DefaultConstraintDefinitionVisitor();
                    fragment.Accept(visitor);
                }
            }
        }

        private class DefaultConstraintDefinitionVisitor : TSqlConcreteFragmentVisitor
        {
            /// <summary>
            /// This visitor looks for default constraints without any identifier (name) and for those explicitly names them.
            /// In the cases where the constraint is unnamed, the ConstraintIdentifier field is null.
            /// </summary>
            public override void ExplicitVisit(DefaultConstraintDefinition node)
            {
                if (node.ConstraintIdentifier == null)
                {
                    node.ConstraintIdentifier = new Identifier()
                    {
                        Value = string.Format("DF_autonamed_{0}", Guid.NewGuid().ToString("N"))
                    };
                }
            }
        }
    }
}
