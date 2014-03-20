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

using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// A TSqlConcreteFragmentVisitor allows us to examine an AST (abstract syntax tree) representation of a 
    /// TSql object such as a Function, Procedure or Trigger. The implementation uses a visitor pattern, which traverses
    /// the logical tree structure of the object. For any type in the tree, the default unless you override it is to
    /// do nothing except examine its children. If you override one of the ExplicitVisit methods it'll just let you examine 
    /// objects of the type passes in as a parameter, and the visitor class will still automatically examine any children
    /// for that object. The Visit methods control whether children are also visited so if you want to stop that from
    /// happening, you should override that method instead.
    /// 
    /// Using a visitor can sometimes be much simpler than querying the object model, especially in the case where the concept
    /// you are trying to find isn't specifically related to a property or relationship in the model. That is true
    /// in this case, since we are looking to find any "WAITFOR" clause inside a Procedure, Function or Trigger and 
    /// this isn't something you could query the Model API to find. As such it's a perfect example of when to examine the
    /// underlying structure of the object, rather than its basic set of properties and relationships.
    ///
    /// Side Note:
    /// Also note that the "WAITFOR" statement will be found inside the body script of a procedure/function/trigger.
    /// The body script is something of a special case in the model API since it's not queryable directly from the public model,
    /// and it can contain "dynamic" objects that aren't a part of the full model. What this means is that you can define temporary
    /// variables and objects in a procedure body, but these won't be queryable using the public model. If you wanted to identify problems
    /// with these dynamic objects you'd again have to check for them using a TSqlFragmentVisitor / TSqlConcreteFragmentVisitor since there's
    /// no way to find them using the Model APIs. However for objects that are defined elsewhere in the model you could check the 
    /// Procedure.BodyDependencies relationship to see what the procedure's body references, and run some analysis based on this.
    ///  
    /// </summary>
    internal class WaitForDelayVisitor : TSqlConcreteFragmentVisitor
    {
        public IList<WaitForStatement> WaitForDelayStatements { get; private set; }

        public WaitForDelayVisitor()
        {
            WaitForDelayStatements = new List<WaitForStatement>();
        }

        public override void ExplicitVisit(WaitForStatement node)
        {
            // We are only interested in WAITFOR DELAY occurrences
            if (node.WaitForOption == WaitForOption.Delay)
            {
                WaitForDelayStatements.Add(node);
            }
        }
    }
}