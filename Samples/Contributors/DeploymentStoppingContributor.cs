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
using Microsoft.SqlServer.Dac.Deployment;
using Microsoft.SqlServer.Dac.Extensibility;

namespace Public.Dac.Samples.Contributors
{
    /// <summary>
    /// This is a sample contributor that blocks deployment. Clearly this isn't something that would be
    /// used in a real environment, but it shows how you go about blocking deployment from happening.
    /// A realistic use of this it to check for certain preconditions and block deployment if these are
    /// not met.
    /// </summary>
    [ExportDeploymentPlanModifier(ContributorId, "1.0.0.0")]
    public class DeploymentStoppingContributor : DeploymentPlanModifier
    {
        public const string ContributorId = "Public.Dac.Samples.Contributors.DeploymentStoppingContributor";
        public const string ErrorViaPublishMessage = "Canceling deployment 1!";
        public const string ErrorViaThrownException = "Canceling deployment 2!";

        /// <summary>
        /// Iterates over the deployment plan to find the definition for 
        /// </summary>
        /// <param name="context"></param>
        protected override void OnExecute(DeploymentPlanContributorContext context)
        {
            // Publishing Severity.Error message blocks deployment
            base.PublishMessage(new ExtensibilityError(ErrorViaPublishMessage, Severity.Error));

            // Alternatively throwing an exception will also block deployment
            throw new DeploymentFailedException(ErrorViaThrownException);
        }
    }
}
