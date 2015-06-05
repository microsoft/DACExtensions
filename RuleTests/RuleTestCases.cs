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
using System.IO;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Public.Dac.Samples.Rules.Tests
{
    /// <summary>
    /// Basic test cases to validate the rule samples.
    /// Many test cases have be extended to use baselines as this can make validation easier - baselined rule tests
    /// support converting a set of input TSQL scripts into a model, running analysis against this and then comparing the
    /// results to an expected baseline. The first time you add a test and run analysis you would verify the output created
    /// looks correct, and if this is true you would update your baseline file to match this.
    /// </summary>
    [TestClass]
    public class RuleTestCases
    {
        /// <summary>
        /// TestContext for a test is automatically inserted by the unit test framework
        /// </summary>
        public TestContext TestContext
        {
            get;
            set;
        }

        /// <summary>
        /// Tests our "Hello world" rule called TableNameEndingInViewRule. When we pass in a set of tables
        /// we expect any table ending in "View" to cause a problem. 
        /// 
        /// This test simulates project analysis by creating a script-backd model with file names for all our 
        /// objects. See <see cref="TestTableNameEndingInViewForDacpac"/> for an example of how to test against
        /// code in a dacpac
        /// </summary>
        [TestMethod]
        public void TestTableNameEndingInView()
        {
            const string expectedProblemFile = "OneProblem.sql";
            var testScripts = new Tuple<string, string>[]
            {
                Tuple.Create("CREATE TABLE t1 (c1 int)", "NoProblems.sql"),
                Tuple.Create(@"CREATE TABLE [dbo].[NotAProblem] (c2 int)
GO
CREATE TABLE [dbo].[NotAView] (c3 int)", expectedProblemFile)
            };

            using(RuleTest test = new RuleTest(testScripts, new TSqlModelOptions(), SqlServerVersion.Sql120))
            {
                test.RunTest(TableNameEndingInViewRule.RuleId, (result, problemsString) =>
                {
                    var problems = result.Problems;
                    Assert.AreEqual(1, problems.Count, "Expect 1 problem to have been found");
                    Assert.AreEqual(expectedProblemFile, problems[0].SourceName, "Expect the source name to match where the problem was found");
                    Assert.AreEqual(3, problems[0].StartLine, "Expect the line to match where the problem was found");
                    Assert.AreEqual(1, problems[0].StartColumn, "Expect the column to match where the problem was found");
                });
            }
        }

        /// <summary>
        /// Tests our "Hello world" rule called TableNameEndingInViewRule. When we pass in a set of tables
        /// we expect any table ending in "View" to cause a problem. 
        /// 
        /// This test is run against a dacpac rather than a set of source scripts. If you look at the
        /// <see cref="RuleTest.CreateDacpacModel"/> method you'll see the crucial code to run analysis on a dacpac
        /// while getting useful source information is:
        /// TSqlModel.LoadFromDacpac(dacpacPath, new ModelLoadOptions(DacSchemaModelStorageType.Memory, loadAsScriptBackedModel: true));
        /// 
        /// It is highly recommended you use this call to load a dacpac for code analysis use.
        /// Without this there model will not be source-backed and no source position information will be available. 
        /// Some rules, including built-in rules, will not function correctly without a source-backed model.
        /// While some rules will work OK, this is definitely not recommended.
        /// 
        /// Note that when loading from a dacpac the source names are inferred based on the name of the top-level object,
        /// and each top-level object will be placed in its own source file. You can see the difference in the
        /// problem's SourceName and StartLine for this test versus the <see cref="TestTableNameEndingInView"/> test for an
        /// example of this.
        /// 
        /// </summary>
        [TestMethod]
        public void TestTableNameEndingInViewForDacpac()
        {
            RunTableNameEndingInViewTest(test =>
            {
                test.Target = RuleTest.AnalysisTarget.DacpacModel;
                test.DacpacPath = Path.Combine(TestContext.TestResultsDirectory, "TestTableNameEndingInViewForDacpac.dacpac");
            });
        }
        
        /// <summary>
        /// Tests our "Hello world" rule called TableNameEndingInViewRule. When we pass in a set of tables
        /// we expect any table ending in "View" to cause a problem. 
        /// 
        /// This test is run against a database rather than a set of source scripts. If you look at the
        /// <see cref="RuleTest.CreateDacpacModel"/> method you'll see the crucial code to run analysis on a dacpac
        /// while getting useful source information is:
        /// TSqlModel.LoadFromDacpac(dacpacPath, new ModelLoadOptions(DacSchemaModelStorageType.Memory, loadAsScriptBackedModel: true));
        /// 
        /// It is highly recommended you use this call to load a dacpac for code analysis use.
        /// Without this there model will not be source-backed and no source position information will be available. 
        /// Some rules, including built-in rules, will not function correctly without a source-backed model.
        /// While some rules will work OK, this is definitely not recommended.
        /// 
        /// Note that when loading from a dacpac the source names are inferred based on the name of the top-level object,
        /// and each top-level object will be placed in its own source file. You can see the difference in the
        /// problem's SourceName and StartLine for this test versus the <see cref="TestTableNameEndingInView"/> test for an
        /// example of this.
        /// 
        /// </summary>
        [TestMethod]
        public void TestTableNameEndingInViewForDatabase()
        {
            RunTableNameEndingInViewTest(test =>
            {
                test.Target = RuleTest.AnalysisTarget.Database;
                test.DatabaseName = TestContext.TestName;
            });
        }

        private void RunTableNameEndingInViewTest(Action<RuleTest> configureTest)
        {
            var testScripts = new Tuple<string, string>[]
                        {
                Tuple.Create("CREATE TABLE t1 (c1 int)", "NoProblems.sql"),
                Tuple.Create(@"CREATE TABLE [dbo].[NotAProblem] (c2 int)
GO
CREATE TABLE [dbo].[NotAView] (c3 int)", "OneProblem.sql")
                        };

            // When loading from a Dacpac the top-level object's name will be the source
            const string expectedProblemSource = "[dbo].[NotAView]";
            using (RuleTest test = new RuleTest(testScripts, new TSqlModelOptions(), SqlServerVersion.Sql120))
            {
                if(configureTest != null)
                {
                    configureTest(test);
                }
                test.RunTest(TableNameEndingInViewRule.RuleId, (result, problemsString) =>
                {
                    var problems = result.Problems;
                    Assert.AreEqual(1, problems.Count, "Expect 1 problem to have been found");
                    Assert.AreEqual(expectedProblemSource, problems[0].SourceName,
                        "Expect the source name to match the top-level object's name when analysing a dacpac source");
                    Assert.AreEqual(1, problems[0].StartLine,
                        "Expect the top-level object to start at line 1 since it has been loaded in its own source script");
                    Assert.AreEqual(1, problems[0].StartColumn, "Expect the column to match where the problem was found");
                });
            }
        }


        /// <summary>
        /// This test uses input scripts saved in the "TestScripts\AvoidWaitForDelayRule" folder and compares the
        /// results to the "AvoidWaitForDelayRule-Baseline.txt file in that directory. If you wanted to add extra test cases
        /// just add in new sql files and run the test. The failure message will include links to the output file - if all
        /// the problems look correct there, then you can simply copy its contents into the baseline file and rerun the test.
        /// 
        /// This is a standard approach used inside the team and is very useful for testing rules since all you need is a tiny
        /// amount of test code and some good examples that show where your rule should/should not highlight a problem.
        /// </summary>
        [TestMethod]
        public void TestAvoidWaitForDelay()
        {
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                TestContext,
                "AvoidWaitForDelayRule", 
                new TSqlModelOptions(), 
                SqlServerVersion.Sql120))
            {
                // Since this test verifies results against a baseline file, we don't need to do any extra verification
                test.RunTest(AvoidWaitForDelayRule.RuleId);
            }
        }

        /// <summary>
        /// Baselined test verifying InMemoryTableBin2CollationRule, where the project collation is not
        /// a BIN2 collation. Default collation is used
        /// </summary>
        [TestMethod]
        public void TestNonBin2CollationOnProjectRule()
        {
            // Test with the default (non-BIN2) collation
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                TestContext,
                "TestNonBin2CollationOnProjectRule",
                new TSqlModelOptions(),
                SqlServerVersion.Sql120))
            {
                // Since this test verifies results against a baseline file, we don't need to do any extra verification
                test.RunTest(InMemoryTableBin2CollationRule.RuleId);
            }
        }

        /// <summary>
        /// Baselined test verifying InMemoryTableBin2CollationRule, where the project collation is not
        /// a BIN2 collation. Default collation is used
        /// </summary>
        [TestMethod]
        public void TestBin2CollationOnProjectRule()
        {
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                TestContext,
                "TestBin2CollationOnProjectRule",
                new TSqlModelOptions(),
                SqlServerVersion.Sql120))
            {
                test.DatabaseOptions.Collation = "SQL_Latin1_General_CP437_BIN2";
                test.RunTest(InMemoryTableBin2CollationRule.RuleId);
            }
        }


        /// <summary>
        /// Baselined test verifying ViewOnMemoryOptimizedTableRule
        /// </summary>
        [TestMethod]
        public void TestViewOnMemoryOptimizedTableRule()
        {
            // Test with a BIN2 collation to ensure character indexes work successfully
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                TestContext,
                "TestViewOnMemoryOptimizedTableRule",
                new TSqlModelOptions() { Collation = "SQL_Latin1_General_CP437_BIN2" },
                SqlServerVersion.Sql120))
            {
                test.RunTest(ViewsOnMemoryOptimizedTableRule.RuleId);
            }
        }

        /// <summary>
        /// Baselined test verifying TestCapitalizedNameRule
        /// </summary>
        [TestMethod]
        public void TestCapitalizedNamesRule()
        {
            // Test with a BIN2 collation to ensure character indexes work successfully
            using (BaselinedRuleTest test = new BaselinedRuleTest(
                TestContext,
                "TestCapitalizedNamesRule",
                new TSqlModelOptions() { Collation = "SQL_Latin1_General_CP437_BIN2" },
                SqlServerVersion.Sql120))
            {
                test.RunTest(CapitalizedNamesRule.RuleId);
            }
        }
    }
}
