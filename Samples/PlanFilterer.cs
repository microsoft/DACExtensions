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
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Public.Dac.Samples
{
    /// <summary>
    /// A Deployment plan modifier that filters "Create Element" steps from a deployment plan.
    /// This stops elements from being created. This is a simple example. A more advanced
    /// version of this would probably check any SqlRenameSteps in the plan, but for this
    /// sample we're assuming that this isn't something the developer would have done. 
    /// </summary>
    [ExportDeploymentPlanModifier(PlanFilterer.PlanFiltererContributorId, "1.0.0.0")]
    public class PlanFilterer : DeploymentPlanModifier
    {
        public const string PlanFiltererContributorId = "Public.Dac.Samples.PlanFilterer";
        public const string FilterNameArg = "FilterName";

        private static Dictionary<string, Lazy<IFilter>> _filterMap = new Dictionary<string, Lazy<IFilter>>()
        {
            {"SchemaBasedFilter", new Lazy<IFilter>(() => new SchemaBasedFilter())}
        }; 

        private IFilter _filter;

        protected override void OnExecute(DeploymentPlanContributorContext context)
        {
            InitializeFilter(context.Arguments);
            DeploymentStep next = context.PlanHandle.Head;
            while (next != null)
            {
                DeploymentStep current = next;
                next = current.Next;

                CreateElementStep createStep = current as CreateElementStep;
                if (createStep != null && ShouldFilter(createStep))
                {
                    base.Remove(context.PlanHandle, createStep);
                }
            }
        }

        /// <summary>
        /// We should filter the step if the source element for the step
        /// doesn't pass the filter
        /// </summary>
        private bool ShouldFilter(CreateElementStep createStep)
        {
           TSqlObject createdObject = createStep.SourceElement;
            return !_filter.Filter(new[] {createdObject}).Any();
        }

        private void InitializeFilter(Dictionary<string, string> arguments)
        {
            string filterName;
            if (arguments.TryGetValue(FilterNameArg, out filterName)
                && _filterMap.ContainsKey(filterName))
            {
                // Note: could use MEF or some other lookup technique to find a specific filter. If you
                // just have a few known filters, a map like this might be a good idea
                _filter = _filterMap[filterName].Value;
                _filter.Initialize(arguments);
            }
        }

        /// <summary>
        /// Builds the arguments string to be passed to the DacServices API when running the contributor
        /// </summary>
        public static string BuildPlanFiltererArgumentString(string filterName,
            Dictionary<string, string> filterArguments)
        {
            filterArguments[FilterNameArg] = filterName;
            return Utils.BuildContributorArguments(filterArguments);
        }
    }
}
