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

using Microsoft.SqlServer.Dac.Extensibility;

namespace Public.Dac.Samples.Rules
{
    internal static class RuleConstants
    {
        /// <summary>
        /// The name of the resources file to use when looking up rule resources
        /// </summary>
        public const string ResourceBaseName = "Public.Dac.Samples.Rules.RuleResources";

        /// <summary>
        /// Lookup name inside the resources file for the rule name
        /// </summary>
        public const string AvoidWaitForDelay_RuleName = "AvoidWaitForDelay_RuleName";
        /// <summary>
        /// Lookup ID inside the resources file for the description
        /// </summary>
        public const string AvoidWaitForDelay_ProblemDescription = "AvoidWaitForDelay_ProblemDescription";

        /// <summary>
        /// Lookup name inside the resources file for the rule name
        /// </summary>
        public const string InMemoryBinCollection_RuleName = "InMemoryBinCollection_RuleName";
        /// <summary>
        /// Lookup ID inside the resources file for the description
        /// </summary>
        public const string InMemoryBinCollection_ProblemDescription = "InMemoryBinCollection_ProblemDescription";

        /// <summary>
        /// Lookup name inside the resources file for the rule name
        /// </summary>
        public const string ViewsOnMemoryOptimizedTable_RuleName = "ViewsOnMemoryOptimizedTable_RuleName";

        public const string CapitalizedNames_RuleName = "CapitalizedNames_RuleName";

        public const string CapitalizedNames_ProblemDescription = "CapitalizedNames_ProblemDescription";

        /// <summary>
        /// The design category (should not be localized)
        /// </summary>
        public const string CategoryDesign = "Design";

        public const string CategoryPerformance = "Performance";

        public const string CategoryNaming = "Naming";
    }
}
