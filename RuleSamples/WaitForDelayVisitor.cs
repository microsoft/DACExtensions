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

using System.Collections.Generic;
using Microsoft.SqlServer.TransactSql.ScriptDom;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// A TSqlConcreteFragmentVisitor allows us to examine an AST (abstract syntax tree) representation of a 
    /// TSql object such as a Function, Procedure or Trigger. The implementation uses a visitor pattern, which traverses
    /// the logical tree structure of the object. For any type in the tree, the default unless you override it is to
    /// do nothing except examine its children. If you override one of the Visit methods it'll just let you examine 
    /// objects of the type passes in as a parameter, and the visitor class will still automatically examine any children
    /// for that object. The ExplicitVisit methods control whether children are also visited so if you want to stop that from
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
