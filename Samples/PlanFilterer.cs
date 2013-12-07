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
        /// Builds the arguments string to be used when 
        /// </summary>
        public static string BuildPlanFiltererArgumentString(string filterName,
            Dictionary<string, string> filterArguments)
        {
            StringBuilder args = new StringBuilder();
            AddArgument(args, FilterNameArg, filterName);

            foreach (var entry in filterArguments)
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
    }
}
