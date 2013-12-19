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
using System;

namespace Public.Dac.Samples.App
{
    class Program
    {
        internal enum Behavior
        {
            Usage,
            RunEndToEnd,
            FilterModel
        }

        static void Main(string[] args)
        {

            switch (GetBehavior(args))
            {
                case Behavior.Usage:
                    Console.WriteLine(@"Specify the action you wish to perform, for example 'ModelBuilderApp.exe RunEndToEnd'
Current actions:
[RunEndToEnd] - Runs the end to end demo that creates a model, copies to another model, and saves the model to a dacpac
[FilterModel] - Runs the end to end demo that creates a model, copies to another model, and saves the model to a dacpac
[Usage] - Print this usage message
");
                    break;
                case Behavior.RunEndToEnd:
                    ModelEndToEnd.Run();
                    break;
                case Behavior.FilterModel:
                    ModelFilterExample.RunFilteringExample();
                    break;
                // To test deployment plan-based filtering see the TestFiltering.TestFilterPlanWhenPublishing() unit test
            }

            Console.WriteLine("Press any key to finish");
            Console.ReadKey();
        }

        private static Behavior GetBehavior(string[] args)
        {
            Behavior behavior = Behavior.Usage;
            if (args.Length > 0)
            {
                if (MatchesBehavior(args[0], Behavior.RunEndToEnd))
                {
                    behavior = Behavior.RunEndToEnd;
                }
                if (MatchesBehavior(args[0], Behavior.FilterModel))
                {
                    behavior = Behavior.FilterModel;
                }
            }
            return behavior;
        }

        private static bool MatchesBehavior(string name, Behavior behavior)
        {
            return string.Compare(name, behavior.ToString(), StringComparison.OrdinalIgnoreCase) == 0;
        }
    }
}
