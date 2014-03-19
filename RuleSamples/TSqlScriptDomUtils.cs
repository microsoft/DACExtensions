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
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// Utility class for TransactSql.ScriptDom functionality. These functions are not be
    /// part of the public API, but are included in the public samples project so that users can
    /// understand how we use the ScriptDom APIs for writing rules.
    /// </summary>
    internal static class TsqlScriptDomUtils
    {
        /// <summary>
        /// Checks if a fragment represents the body of a subroutine, a view, 
        /// or a trigger. These have similar characteristics, for instance the ability to
        /// include select statements against tables. 
        /// </summary>
        /// <param name="fragment"><see cref="TSqlFragment"/> representing part of a TSQL object definition</param>
        /// <returns>true if this is a subroutine, a view or a trigger body</returns>
        public static bool IsSubroutineViewOrTrigger(TSqlFragment fragment)
        {
            return fragment is ProcedureStatementBodyBase ||
                fragment is ViewStatementBody ||
                fragment is TriggerStatementBody;
        }
    }
}
