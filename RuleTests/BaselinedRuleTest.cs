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

using Microsoft.SqlServer.Dac.CodeAnalysis;
using Microsoft.SqlServer.Dac.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace Public.Dac.Samples.Rules.Tests
{
    /// <summary>
    /// A baselined rule test reads input scripts from a folder, and verifies the output of the test against
    /// 
    /// </summary>
    public class BaselinedRuleTest : RuleTest
    {
        private const string TestScriptsFolder = "TestScripts";
        private const string Output = "Output";
        private const string Baseline = "Baseline";
        private const string DacpacBaseline = "DacpacBaseline";
        private const string SqlExt = ".sql";

        /// <summary>
        /// Creates a new baselined test. The input files and baseline file will be loaded from 
        /// the 
        /// </summary>
        public BaselinedRuleTest(
            TestContext testContext, 
            string testName, 
            TSqlModelOptions databaseOptions,
            SqlServerVersion sqlVersion)
            : base(new List<Tuple<string, string>>(), databaseOptions, sqlVersion)
        {
            ScriptsFolder = GetScriptsFolder(testName);
            Assert.IsTrue(Directory.Exists(ScriptsFolder), "Expected the test folder '{0}' to exist", ScriptsFolder);

            string outputDir = testContext.TestResultsDirectory;
            string outputFilename = String.Format("{0}-{1}.txt", testName, Output);
            OutputFilePath = Path.Combine(outputDir, testName, outputFilename);

            string baselineFilename = String.Format("{0}-{1}.txt", testName, Baseline);
            BaselineFilePath = Path.Combine(ScriptsFolder, baselineFilename);
        }

        private string GetScriptsFolder(string testName)
        {
            var testAssembly = this.GetType().Assembly;
            string baseFolder = Path.GetDirectoryName(testAssembly.Location);
            return Path.Combine(baseFolder, TestScriptsFolder, testName);
        }

        protected string ScriptsFolder
        {
            get;
            private set;
        }

        protected string OutputFilePath
        {
            get;
            private set;
        }

        protected string BaselineFilePath
        {
            get;
            private set;
        }

        public override void RunTest(string fullId, Action<CodeAnalysisResult, string> verify)
        {
            RunTest(fullId);
        }

        public void RunTest(string fullId)
        {
            // Load our test scripts and when running the test, use the "RunVerification" method
            // to validate the results.
            LoadTestScripts();
            base.RunTest(fullId, RunVerification);
        }

        private void LoadTestScripts()
        {
            // Load all files ending in ".sql". Note that due to strange Win32 behavior we need to double check the
            // file name actually ends in ".sql" since suffixes like ".sqlOther" would also be included in the results
            DirectoryInfo di = new DirectoryInfo(ScriptsFolder);
            var scriptFilepaths = from file in di.GetFiles("*" + SqlExt)
                                  where SqlExt.Equals(file.Extension, StringComparison.OrdinalIgnoreCase)
                                  select file.FullName;               
                
            foreach(string scriptFile in scriptFilepaths)
            {
                try
                {
                    string contents = RuleTestUtils.ReadFileToString(scriptFile);
                    TestScripts.Add(Tuple.Create(contents, scriptFile));
                    Console.WriteLine("Test script file '{0}' loaded", scriptFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(
                        "Error reading from file '{0}', message is '{1}'. Continuing processing since missing files treated as warning for test",
                        scriptFile, 
                        ex.Message);
                }                
            }
        }

        private void RunVerification(CodeAnalysisResult result, string resultsString)
        {
            // Check if the resultsString matches our baseline. If not, output the test files that
            // were loaded, and some commands to easily overwrite the existing baseline with the output.
            // once you've overwritten it you can compare the new and old baselines using the Diff tools
            // in Team Explorer
            string baseline = RuleTestUtils.ReadFileToString(BaselineFilePath);
            RuleTestUtils.SaveStringToFile(resultsString, OutputFilePath);

            string loadedTestScriptFiles = ListScriptFilenames();

            if (string.Compare(resultsString, baseline, false, CultureInfo.CurrentCulture) != 0)
            {
                Assert.Fail(String.Format(
                    "The result is not the same as expected. It's recommended you compare the actual output " +
                    "to the baseline. If the output matches your expectations, update the baseline file inside " +
                    "the project.\r\n\r\n" +
                    "################## loaded test script files ################## \r\n" +
                    loadedTestScriptFiles + "\r\n" +
                    "rem ################## View Baseline: ##################\r\n" +
                    "Notepad \"{0}\" \r\n\r\n" +
                    "rem ################## View Actual Output: ##################\r\n" +
                    "Notepad \"{1}\" \r\n\r\n" +
                    "################## cd test folder command ##################\r\n" +
                    "cd \"{2}\"\r\n",
                    BaselineFilePath, OutputFilePath, ScriptsFolder));
            }
        }

        private string ListScriptFilenames()
        {
            StringBuilder loadedTestScriptFilesStringBuilder = new StringBuilder();
            foreach (var scriptInfo in TestScripts)
            {
                string scriptFilepath = scriptInfo.Item2;
                loadedTestScriptFilesStringBuilder.AppendLine(scriptFilepath);
            }
            return loadedTestScriptFilesStringBuilder.ToString();
        }

    }
}
