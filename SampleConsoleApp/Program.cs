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
using System;

namespace Public.Dac.Samples.App
{
    class Program
    {
        internal enum Behavior
        {
            Usage,
            RunEndToEnd,
            FilterModel,
            RunCodeAnalysis,
            ValidateQuerySemantically
        }

        static void Main(string[] args)
        {

            switch (GetBehavior(args))
            {
                case Behavior.Usage:
                    Console.WriteLine(@"Specify the action you wish to perform, for example 'ModelBuilderApp.exe RunEndToEnd'
Current actions:
[RunEndToEnd] - Runs the end to end demo that creates a model, copies to another model, and saves the model to a dacpac
[FilterModel] - Runs a demo that creates a model then creates a filtered copy with some schemas removed.
[RunCodeAnalysis] - Runs a demo of running Static Code Analysis from your code.
[Usage] - Print this usage message
");
                    break;
                case Behavior.RunEndToEnd:
                    ModelEndToEnd.Run();
                    break;
                case Behavior.FilterModel:
                    ModelFilterExample.RunFilteringExample();
                    break;
                case Behavior.RunCodeAnalysis:
                    RunCodeAnalysisExample.RunAnalysisExample();
                    break;
                case Behavior.ValidateQuerySemantically:
                    RunValidateQuerySemanticallyExample.Run();
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
                if (MatchesBehavior(args[0], Behavior.RunCodeAnalysis))
                {
                    behavior = Behavior.RunCodeAnalysis;
                }
                if (MatchesBehavior(args[0], Behavior.ValidateQuerySemantically))
                {
                    behavior = Behavior.ValidateQuerySemantically;
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
