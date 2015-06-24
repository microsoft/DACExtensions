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
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using Public.Dac.Samples.TestUtilities;

namespace Public.Dac.Samples.App
{
    public class RunValidateQuerySemanticallyExample
    {

        private static readonly string[] SampleScripts = new string[]
            {
                "CREATE TABLE T1 (c1 int)",
                @"CREATE VIEW [dbo].[View1] AS SELECT * FROM [dbo].[T1]",                
            };

        /// <summary>
        /// DacFx is smart enough to realize there's a column c1 projected through View1 from T1
        /// </summary>
        private const string GoodQuery = "SELECT c1 from View1";
        /// <summary>
        /// DacFx will complain since the relevant column does not exist
        /// </summary>
        private const string BadQuery = @"SELECT c2 from View1";

        private const string ProcTemplate = @"CREATE PROCEDURE [NameThatNeverExistsInDb] AS BEGIN {0} END";
        public static void Run()
        {
            Console.WriteLine("Publishing scripts to DB");
            using (SqlTestDB db = TestUtils.CreateTestDatabase(TestUtils.DefaultInstanceInfo, "MyQueryExample"))
            {
                // set up the database with your scripts
                TestUtils.ExecuteNonQuery(db, SampleScripts);
                
                ValidateQuery(BadQuery, db, false);

                // BUG: Normally AddOrUpdateObjects will replace the contents of a file so we could just update the contents of our "Query File" 
                // and re-run validation. This simulates live validation of a query in SSMS/SSDT. 
                // Somehow when loading model directly from Database this isn't working. We will resolve this issue in a future DacFx update.
                // For now we create a new model for each query which is inefficient but relatively effective.
                ValidateQuery(GoodQuery, db, true);
            }            
        }

        public static void ValidateQuery(string query, SqlTestDB db, bool expectQueryToPass)
        {
            Console.WriteLine("Testing query '{0}'", query);
            Console.WriteLine("Loading model from DB");
            using (TSqlModel model = TSqlModel.LoadFromDatabase(db.BuildConnectionString()))
            {
                // Currently we just give a message but no source information. Will work around this for now by ensuring the model is fully valid before proceeding
                bool modelInitiallyValid = PrintModelState(model, true);
                if (!modelInitiallyValid)
                {
                    Console.WriteLine("Quitting due to invalid model");
                    return;
                }
                AssertModelHasNProcedures(model, 0);

                string myFileName = "QueryFile.sql";

                // validate bad query fails validation
                model.AddOrUpdateObjects(CreateQueryAsProc(query), myFileName, null);
                PrintModelState(model, expectQueryToPass);

                AssertModelHasNProcedures(model, 1);                
            }
        }


        private static void AssertModelHasNProcedures(TSqlModel model, int numProcs)
        {
            IEnumerable<TSqlObject> procs = model.GetObjects(DacQueryScopes.UserDefined, ModelSchema.Procedure);
            if(numProcs != procs.Count())
            {
                throw new Exception("Incorrect number of elements. Expected " + numProcs + " proc(s)");
            }
        }


        private static string CreateQueryAsProc(string query)
        {
            return string.Format(CultureInfo.CurrentCulture, ProcTemplate, query);
        }

        private static bool PrintModelState(TSqlModel model, bool expectQueryToPass)
        {

            string errorMessage = expectQueryToPass ? "Fail: Expected no issues but got the following:" : "Pass: expected issues found during validation:";
            string passMessage = expectQueryToPass ? "Pass: No problems found during validation" : "Fail: expected issues but none were found";
            bool breakingIssuesFound = false;
            var validationMessages = model.Validate();
            if (validationMessages.Count > 0)
            {
                Console.WriteLine(errorMessage);
                foreach (var message in validationMessages)
                {
                    Console.WriteLine("\t" + message.Message);
                    breakingIssuesFound = breakingIssuesFound || message.MessageType == DacMessageType.Error;
                }
                return false;
            }
            else
            {
                Console.WriteLine(passMessage);
                return true;
            }
            
        }
    }
}
