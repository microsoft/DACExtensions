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
using Microsoft.SqlServer.TransactSql.ScriptDom;
using System;
using System.Linq;

namespace Public.Dac.Samples.Contributors
{
    /// <summary>
    /// Supports overriding the location databases are created at. This contributor does so by modifying the 
    /// CreateDatabase step that actually creates the DB. This provides more flexibility and power than alternative
    /// solutions, but it is more brittle - if the internal implementation for creating a database changes this contributor
    /// could potentially interfere with that or stop working. 
    /// </summary>
    /// <remarks>
    /// This contributor solves an actual real-world problem that users have asked about. Normally it's quite hard for
    /// users who want to use DacFx to deploy to a location outside of the normal SQL Server directory. 
    /// This is sometimes the case when defining local databases hat should be deployed alongside an application.
    /// 
    /// This solution can be compared to the <see cref="DbLocationModifier"/> contributor, which changes
    /// the default values used when creating a database. That is a simpler solution, possibly a little slower
    /// in terms of performance and with less flexibility on naming. However it's simpler and better protected
    /// against implementation changes
    /// </remarks>
    [ExportDeploymentPlanModifier(ContributorId, "1.0.0.0")]
    public class DbCreateDatabaseModifier : DeploymentPlanModifier
    {
        public const string ContributorId = "Public.Dac.Samples.Contributors.DbCreateDatabaseModifier";
        /// <summary>
        /// Filepath to save the database file to
        /// </summary>
        public const string MdfFilePathArg = "DbCreateDatabaseModifier.MdfFilePath";

        /// <summary>
        /// Filepath to save the log file to
        /// </summary>
        public const string LdfFilePathArg = "DbCreateDatabaseModifier.LdfFilePath";

        /// <summary>
        /// Optional contributor argument defining a string the connection string must contain in order to
        /// modify the DB location. This is useful if you wish to only change the location for (localdb) deployments,
        /// for instance.
        /// </summary>
        public const string TargetConnectionStringPatternArg = "DbCreateDatabaseModifier.TargetConnectionStringPattern";

        protected override void OnExecute(DeploymentPlanContributorContext context)
        {
            // Run only if a location is defined and we're targeting a serverless (LocalDB) instance
            string databasePath, logPath;
            if (context.Arguments.TryGetValue(MdfFilePathArg, out databasePath)
                && context.Arguments.TryGetValue(LdfFilePathArg, out logPath)
                && context.Options.TargetConnectionString.Contains("(localdb)"))
            {
                if (TargetConnectionMatchesPattern(context))
                {
                    ChangeNewDatabaseLocation(context, databasePath, logPath);
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

        private void ChangeNewDatabaseLocation(DeploymentPlanContributorContext context, string databasePath,
            string logPath)
        {
            DeploymentStep nextStep = context.PlanHandle.Head;

            // Loop through all steps in the deployment plan
            bool finished = false;
            while (nextStep != null && !finished)
            {
                // Increment the step pointer, saving both the current and next steps
                DeploymentStep currentStep = nextStep;

                // Only interrogate up to BeginPreDeploymentScriptStep - setvars must be done before that
                if (currentStep is BeginPreDeploymentScriptStep)
                {
                    finished = true;
                    break;
                }

                SqlCreateDatabaseStep createDbStep = currentStep as SqlCreateDatabaseStep;
                if (createDbStep != null)
                {
                    TSqlFragment fragment = createDbStep.Script;

                    CreateDatabaseStatementVisitor visitor = new CreateDatabaseStatementVisitor(databasePath, logPath);
                    fragment.Accept(visitor);

                    finished = true;
                }

                nextStep = currentStep.Next;
            }
        }

        /// <summary>
        /// A <see cref="TSqlConcreteFragmentVisitor"/> that updates the database and log file names for a
        /// newly created database. The ScriptDom API uses a visitor pattern to support interrogating the 
        /// contents of a TSqlScript. In this case we only care about the CreateDatabaseStatement and wish
        /// to update its definition to no longer rely on the "$(DatabaseName)" defined by DacFx. Instead
        /// we will override this with our own definition.
        /// 
        /// To figure out how this all worked, the basic approach is to debug into a deployment and look for the
        /// step you want to change. In this case, you would debug until you found the CreateDatabaseStep, and
        /// examine what the basic ScriptDom looks like for that step. Once that's done, the next step is to
        /// hook a TSqlConcreteFragmentVisitor up and visit the type of fragment you care about - look at
        /// its properties in the debugger, and look at the API definition to understand what the properties do.
        /// Finally, write some sample code that does what you want (changing the filename for the primary filegroup)
        /// and debug in to verify it works, in addition to writing a unit test that verifies it and catches regressions
        /// </summary>
        private class CreateDatabaseStatementVisitor : TSqlConcreteFragmentVisitor
        {
            private const string DatabaseNameVariable = "$(DatabaseName)";
            private const string DatabaseLogNameVariable = "$(DatabaseName)_log";
            private readonly string _databaseFileName;
            private readonly string _logFileName;
            
            public CreateDatabaseStatementVisitor(string databaseFileName, string logFileName)
            {
                _databaseFileName = databaseFileName;
                _logFileName = logFileName;
            }

            public override void ExplicitVisit(CreateDatabaseStatement node)
            {
                Visit(node);
            }

            public override void Visit(CreateDatabaseStatement node)
            {
                foreach (FileGroupDefinition fg in node.FileGroups)
                {
                    foreach (FileDeclaration fileDecl in fg.FileDeclarations)
                    {
                        // The Primary filegroup is where the database's MDF file will be present 
                        
                        if (fileDecl.IsPrimary)
                        {
                            NameFileDeclarationOption nameOption = fileDecl.Options.SingleOrDefault(
                                opt => opt.OptionKind == FileDeclarationOptionKind.Name) as NameFileDeclarationOption;
                            if (nameOption == null)
                            {
                                continue;
                            }

                            // Verify that the filename has the pattern "$(DatabaseName)", and overwrite
                            if (string.Compare(nameOption.LogicalFileName.Identifier.Value,
                                                DatabaseNameVariable,
                                                StringComparison.OrdinalIgnoreCase) == 0)
                            {
                                FileNameFileDeclarationOption fileNameOption = fileDecl.Options.SingleOrDefault(
                                    opt => opt.OptionKind == FileDeclarationOptionKind.FileName) as FileNameFileDeclarationOption;
                                if (fileNameOption != null)
                                {
                                    fileNameOption.OSFileName = new StringLiteral { Value = _databaseFileName, IsNational = false };
                                }
                            }

                        }
                    }
                }

                foreach (FileDeclaration logFile in node.LogOn)
                {
                    NameFileDeclarationOption nameOption = logFile.Options.SingleOrDefault(
                               opt => opt.OptionKind == FileDeclarationOptionKind.Name) as NameFileDeclarationOption;
                    if (nameOption == null)
                    {
                        continue;
                    }

                    if (string.Compare(nameOption.LogicalFileName.Identifier.Value,
                                                DatabaseLogNameVariable,
                                                StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        FileNameFileDeclarationOption fileNameOption = logFile.Options.SingleOrDefault(
                            opt => opt.OptionKind == FileDeclarationOptionKind.FileName) as FileNameFileDeclarationOption;
                        if (fileNameOption != null)
                        {
                            fileNameOption.OSFileName = new StringLiteral { Value = _logFileName, IsNational = false };
                        }
                    }
                }
            }

        }
    }
}
