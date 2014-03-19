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
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Public.Dac.Samples.Rules.Tests
{
    /// <summary>
    /// Basic test cases to validate the rule samples.
    /// These could (and should) be extended to use baselines as this will make validation easier.
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
        /// This test uses input scripts saved in the "TestScripts\AvoidWaitForDelayRule" folder and compares the
        /// results to the "AvoidWaitForDelayRule-Baseline.txt file in that directory. If you wanted to add extra test cases
        /// just add in new sql files and run the test. The failure message will include links to the output file - if all
        /// the problems look correct there, then you can simply copy its contents into the baseline file and rerun the test.
        /// 
        /// This is a standard approach used inside the team and is very useful for testing rules since all you need is a tiny
        /// amount of test code and some good examples that show where your rule should/should not highlight a problem
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
    }
}
