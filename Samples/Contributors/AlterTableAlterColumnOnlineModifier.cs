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
    /// This deployment contributor allows ALTER TABLE...ALTER COLUMN operations to be done online (this is a new feature supported in SQL 2016 and in Azure SQL DB)
    /// </summary>
    /// <remarks>
    /// This sample was created based on an actual customer scenario where deployments happen when the workload is still active. In those cases, any ALTER TABLE...ALTER COLUMN 
    /// operations took the table 'offline' and caused blocking. Using this deployment contributor leverages the new online alter column functionality and minimizes such blocking.
    /// </remarks>
    [ExportDeploymentPlanModifier(ContributorId, "1.0.0.0")]
    public class AlterTableAlterColumnOnlineModifier : DeploymentPlanModifier
    {
        public const string ContributorId = "Public.Dac.Samples.Contributors.AlterTableAlterColumnOnlineModifier";
        
        protected override void OnExecute(DeploymentPlanContributorContext context)
        {
            this.FindAndMakeAlterColumnsOnline(context);
        }

        private void FindAndMakeAlterColumnsOnline(DeploymentPlanContributorContext context)
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

                // We need to care about AlterElementSteps. 
                DeploymentScriptDomStep domStep = currentStep as DeploymentScriptDomStep;
                TSqlObject elementObject = null;

                if (domStep is AlterElementStep)
                {
                    elementObject = ((AlterElementStep)domStep).SourceElement;
                }

                if (elementObject != null)
                {
                    TSqlFragment fragment = domStep.Script;

                    // call the visitor, which in turn will auto-name these constraints
                    var visitor = new AlterTableAlterColumnVisitor();
                    fragment.Accept(visitor);
                }
            }
        }

        private class AlterTableAlterColumnVisitor : TSqlConcreteFragmentVisitor
        {
            /// <summary>
            /// This visitor looks for ALTER TABLE...ALTER COLUMN statements and overrides by adding ONLINE = ON attribute
            /// </summary>
            public override void ExplicitVisit(AlterTableAlterColumnStatement node)
            {
                bool isAlreadyOnline = false;

                // check if the statement already has ONLINE = ON
                foreach(var option in node.Options)
                {
                    if (option is OnlineIndexOption)
                    {
                        isAlreadyOnline = true;
                    }                        
                }

                if (!isAlreadyOnline)
                {
                    node.Options.Add(new OnlineIndexOption()
                    {
                        OptionKind = IndexOptionKind.Online,
                        OptionState = OptionState.On
                    });
                }
            }
        }
    }
}
