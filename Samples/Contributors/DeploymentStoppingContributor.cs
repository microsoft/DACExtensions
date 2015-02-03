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
