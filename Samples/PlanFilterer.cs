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
