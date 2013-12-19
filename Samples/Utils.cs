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
using Microsoft.SqlServer.Dac;
using System.Collections.Generic;
using System.Text;

namespace Public.Dac.Samples
{
    /// <summary>
    /// Useful utility methods that the samples can use
    /// </summary>
    public static class Utils
    {

        /// <summary>
        /// Builds the arguments string to be used when running contributors. This should be
        /// set as the <see cref="DacDeployOptions.AdditionalDeploymentContributorArguments"/> when
        /// running deployment via the <see cref="DacServices"/> API.
        /// </summary>
        public static string BuildContributorArguments(Dictionary<string, string> arguments)
        {
            StringBuilder args = new StringBuilder();

            foreach (var entry in arguments)
            {
                AddArgument(args, entry.Key, entry.Value);
            }
            return args.ToString();
        }

        /// <summary>
        /// Adds an argument into the string. Args are name-value pairs separated by the "=" sign, with
        /// each argument in the list semicolon delimited. Hence and arg string might look like
        /// "FilterName=SchemaBasedFilter;Schema1=dev;Schema2=test"
        /// </summary>
        private static void AddArgument(StringBuilder args, string key, string value)
        {
            if (args.Length > 0)
            {
                args.Append(";");
            }
            args.Append(key).Append("=").Append(value);
        }
        
        /// <summary>
        /// Builds the string describing the contributors to be run - this should be
        /// set as the <see cref="DacDeployOptions.AdditionalDeploymentContributors"/> when
        /// running deployment via the <see cref="DacServices"/> API.
        /// </summary>
        /// <param name="contributors">Names of the contributors to be run</param>
        /// <returns>semi-colon delimited string describing the contributors to be run</returns>
        public static string BuildContributorsList(IList<string> contributors)
        {
            StringBuilder args = new StringBuilder();

            foreach (var contributor in contributors)
            {
                AddContributor(args, contributor);
            }
            return args.ToString();
        }

        private static void AddContributor(StringBuilder args, string contributor)
        {
            if (args.Length > 0)
            {
                args.Append(";");
            }
            args.Append(contributor);
        }

    }
}
