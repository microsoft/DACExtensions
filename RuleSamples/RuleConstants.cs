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
        /// The design category (should not be localized)
        /// </summary>
        public const string CategoryDesign = "Design";

        /// <summary>
        /// The performance category (should not be localized)
        /// </summary>
        public const string CategoryPerformance = "Design";

        /// <summary>
        /// SQL Server 2014 and future releases have features that older versions do not. Some rules may only
        /// wish to target the latest versions of SQL Server to minimize the performance impace when building 
        /// projects targeting older versions. Using this compatability setting the rule will not appear in the UI
        /// or be supported during analysis for SQL Server 2012 and lower.
        /// Note: TSqlPlatformCompatibility.Sql120 refers to SQL Server 2014 (Version 12.0 of SQL Server).
        /// Also note that since we do not know what features SQL Databases in Azure may provide in the future, we
        /// choose to be safe and not exclude it here
        /// </summary>
        public const TSqlPlatformCompatibility Sql12OrGreaterCompatibility = TSqlPlatformCompatibility.All
                                                                             & ~TSqlPlatformCompatibility.Sql90
                                                                             & ~TSqlPlatformCompatibility.Sql100
                                                                             & ~TSqlPlatformCompatibility.Sql110;
    }
}
