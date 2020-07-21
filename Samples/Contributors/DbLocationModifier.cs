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
using System.IO;
using Microsoft.SqlServer.Dac.Deployment;
using System.Collections.Generic;
using System.Text;

namespace Public.Dac.Samples.Contributors
{
    /// <summary>
    /// Supports overriding the location databases are created at. This contributor does so by modifying the 
    /// "DefaultDataPath", "DefaultLogPath" and "DefaultFilePrefix" values used when creating the database. This
    /// is a fairly lightweight solution but works quite well in practice - these are defined near the start of the plan
    /// and so only a few steps are ever examined. It's also easy to implement and reliable in practice. 
    /// </summary>
    /// <remarks>
    /// This contributor solves an actual real-world problem that users have asked about. Normally it's quite hard for
    /// users who want to use DacFx to deploy to a location outside of the normal SQL Server directory. 
    /// This is sometimes the case when defining local databases hat should be deployed alongside an application.
    /// 
    /// This solution can be compared to the <see cref="DbCreateDatabaseModifier"/> contributor, which changes
    /// the contents of the ScriptDom for the Create Database statement. That method provides more power but is
    /// somewhat more brittle and subject to changes in the internal deployment plan implementation 
    /// </remarks>
    [ExportDeploymentPlanModifier(ContributorId, "1.0.0.0")]
    public class DbLocationModifier : DeploymentPlanModifier
    {
        public const string ContributorId = "Public.Dac.Samples.Contributors.DbLocationModifier";

        /// <summary>
        /// Contributor argument defining the directory to save the MDF file for the database
        /// </summary>
        public const string DbSaveDataLocationArg = "DbLocationModifier.SaveDataLocation";

        /// <summary>
        /// Contributor argument defining the directory to save the LDF file for the database
        /// </summary>
        public const string DbSaveLogDataLocationArg = "DbLocationModifier.SaveLogDataLocation";

        /// <summary>
        /// Contributor argument defining the prefix to use for the database files
        /// </summary>
        public const string DbFilePrefixArg = "DbLocationModifier.FilePrefix";
        /// <summary>
        /// Optional contributor argument defining a string the connection string must contain in order to
        /// modify the DB location. This is useful if you wish to only change the location for (localdb) deployments,
        /// for instance.
        /// </summary>
        public const string TargetConnectionStringPatternArg = "DbLocationModifier.TargetConnectionStringPattern";

        /// <summary>
        /// Iterates over the deployment plan to find the definition for 
        /// </summary>
        /// <param name="context"></param>
        protected override void OnExecute(DeploymentPlanContributorContext context)
        { 
            // Run only if a location is defined and we're targeting a serverless (LocalDB) instance
            string datalocation, logdatalocation, filePrefix;
            if (context.Arguments.TryGetValue(DbSaveDataLocationArg, out datalocation)                 
                && context.Arguments.TryGetValue(DbFilePrefixArg, out filePrefix))
            {
                logdatalocation = context.Arguments.TryGetValue(DbSaveLogDataLocationArg, out logdatalocation) ? logdatalocation : datalocation;
                //Assuming the path for SQL Server on Linux starts with "/"
                if (datalocation.StartsWith("/") && logdatalocation.StartsWith("/"))
                {

                    if (TargetConnectionMatchesPattern(context))
                    {                        
                       ChangeNewDatabaseLocation(context, datalocation, logdatalocation, filePrefix);
                    }
                }
                else
                {
                    if (TargetConnectionMatchesPattern(context))
                    {
                        datalocation = new DirectoryInfo(datalocation).FullName + "\\";
                        logdatalocation = new DirectoryInfo(logdatalocation).FullName + "\\";
                        ChangeNewDatabaseLocation(context, datalocation, logdatalocation, filePrefix);
                    }
                }
            }
        }

        private bool TargetConnectionMatchesPattern(DeploymentPlanContributorContext context)
        {
            string targetConnectionStringPattern;
            if (context.Arguments.TryGetValue(TargetConnectionStringPatternArg, out targetConnectionStringPattern))
            {
                string targetConnectionString = context.Options.TargetConnectionString;
                return !string.IsNullOrEmpty(targetConnectionString)
                    && targetConnectionString.Contains(targetConnectionStringPattern);
            }
            return true;
        }
        
        private void ChangeNewDatabaseLocation(DeploymentPlanContributorContext context,  string datalocation, string logdatalocation, string filePrefix)
        {
            DeploymentStep nextStep = context.PlanHandle.Head;

            // Loop through all steps in the deployment plan
            bool foundSetVars = false;
            while (nextStep != null && !foundSetVars)
            {
                // Increment the step pointer, saving both the current and next steps
                DeploymentStep currentStep = nextStep;

                // Only interrogate up to BeginPreDeploymentScriptStep - setvars must be done before that
                // We know this based on debugging a new deployment and examining the output script
                if (currentStep is BeginPreDeploymentScriptStep)
                {
                    break;
                }
                
                DeploymentScriptStep scriptStep = currentStep as DeploymentScriptStep;
                if (scriptStep != null)
                {
                    IList<string> scripts = scriptStep.GenerateTSQL();
                    foreach (string script in scripts)
                    {
                        if (script.Contains("DefaultDataPath"))
                        {
                            // This is the step that sets the default data path and log path.
                            foundSetVars = true;

                            // Override setvars before the deployment begins
                            StringBuilder sb = new StringBuilder();
                            sb.AppendFormat(":setvar DefaultDataPath \"{0}\"", datalocation)
                                .AppendLine()
                                .AppendFormat(":setvar DefaultLogPath \"{0}\"", logdatalocation)
                                .AppendLine()
                                .AppendFormat(":setvar DefaultFilePrefix \"{0}\"", filePrefix)
                                .AppendLine();

                            // Create a new step for the setvar statements, and add it after the existing step.
                            // That ensures that the updated values are used instead of the defaults
                            DeploymentScriptStep setVarsStep = new DeploymentScriptStep(sb.ToString());
                            this.AddAfter(context.PlanHandle, scriptStep, setVarsStep);
                        }
                    }
                }

                nextStep = currentStep.Next;
            }
        }
    }
}
