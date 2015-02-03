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
using Microsoft.SqlServer.Dac.Model;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using Microsoft.SqlServer.Dac;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// Utility class for TransactSql.ScriptDom functionality. 
    /// 
    /// These functions are useful examples of how to make use of the ScriptDom APIs
    /// when running code analysis. 
    /// 
    /// For instance they show how to use TSqlModelUtils.TryGetFragmentForAnalysis to 
    /// get the ScriptDom for analysis, rather than using TSqlObject.TryGetScript. This is because 
    /// during analysis we want the original source script, not a recreated script that's based
    /// off the model contents.
    /// - The original source script contains the correct source position info (start line and column)
    /// and helps provide the most accurate error information to the user. 
    /// - Using TSqlObject.TryGetScript or TSqlObject.GetScript creates a new script each time,
    /// which affects performance and can be costly. The preference is to use the original fragment from
    /// the model if at all possible. 
    /// 
    /// The class also shows how to write custom fragment visitors to identify object names. When examining
    /// the script dom, visitors are an efficient and useful way to interact with them. 
    /// </summary>
    internal static class TsqlScriptDomUtils
    {
        /// <summary>
        /// Checks if a fragment represents the body of a subroutine, a view, 
        /// or a trigger. These have similar characteristics, for instance the ability to
        /// include select statements against tables. 
        /// </summary>
        /// <param name="fragment">
        /// <see cref="TSqlFragment"/> representing part of a TSQL object definition
        /// </param>
        /// <returns>true if this is a subroutine, a view or a trigger body</returns>
        public static bool IsSubroutineViewOrTrigger(TSqlFragment fragment)
        {
            return fragment is ProcedureStatementBodyBase ||
                fragment is ViewStatementBody || 
                fragment is TriggerStatementBody;
        }

        /// <summary>
        /// Looks up the fragment representing the name of a <see cref="TSqlObject"/>. 
        /// Only some common object types are supported - more can be added as needed.
        /// 
        /// Searches for the precise TSqlFragment representing the name of the view. 
        /// If it's possible to find this it can provide the most accurate source 
        /// position information to support clicking on the error in the errors list
        /// and navigating to that precise view definition in a project file 
        /// </summary>
        /// <param name="tSqlObject">The object whose name is requested</param>
        /// <returns><see cref="TSqlFragment"/> or null if no name is found</returns>
        public static TSqlFragment LookupSchemaObjectName(TSqlObject tSqlObject)
        {
            TSqlFragment fragment;
            if (TSqlModelUtils.TryGetFragmentForAnalysis(tSqlObject, out fragment))
            {
                NameFindingVisitor visitor = new NameFindingVisitor(tSqlObject);
                fragment.Accept(visitor);
                return visitor.Name;
            }
            return null;
        }

        /// <summary>
        /// A Visitor that knows how to extract the names for some common objects by searching for matching fragments in the script dom
        /// </summary>
        private class NameFindingVisitor : TSqlConcreteFragmentVisitor
        {
            /// <summary>
            /// Mapping from object types to known TSqlFragment types that define those objects in AST form.
            /// For each fragment type mapped in this dictionary, an ExplicitVisit override must be added that
            /// handles that fragment type and queries the correct sub-fragment representing the name
            /// </summary>
            private static Dictionary<ModelTypeClass, IList<Type>> _typeClassToFragmentType = new Dictionary<ModelTypeClass, IList<Type>>()
            {
                {Table.TypeClass, new [] { typeof(CreateTableStatement)}},  // Alter table visit is not supported
                {View.TypeClass, new [] { typeof(CreateViewStatement), typeof(AlterViewStatement)}},
                {Index.TypeClass, new [] { typeof(CreateIndexStatement), typeof(AlterIndexStatement)}},
                {Procedure.TypeClass, new [] { typeof(CreateProcedureStatement), typeof(AlterProcedureStatement)}},
                {ScalarFunction.TypeClass, new [] { typeof(CreateFunctionStatement), typeof(AlterFunctionStatement)}},
                {TableValuedFunction.TypeClass, new [] { typeof(CreateFunctionStatement), typeof(AlterFunctionStatement)}},
            };

            private ModelTypeClass _currentTypeClass;
            private IList<Type> _validTypes;
            public NameFindingVisitor(TSqlObject owningObject)
            {
                _currentTypeClass = owningObject.ObjectType;
                _typeClassToFragmentType.TryGetValue(_currentTypeClass, out _validTypes);
            }

            public TSqlFragment Name { get; private set; }

            public override void ExplicitVisit(CreateViewStatement view)
            {
                if (IsSupportedForCurrentType(view.GetType()))
                {
                    Name = view.SchemaObjectName;
                }
            }

            public override void ExplicitVisit(AlterViewStatement view)
            {
                if (IsSupportedForCurrentType(view.GetType()))
                {
                    Name = view.SchemaObjectName;
                }
            }

            public override void ExplicitVisit(CreateIndexStatement index)
            {
                
                if (IsSupportedForCurrentType(index.GetType()))
                {
                    Name = index.Name;
                }
            }

            public override void ExplicitVisit(AlterIndexStatement index)
            {
                if (IsSupportedForCurrentType(index.GetType()))
                {
                    Name = index.Name;
                }
            }

            public override void ExplicitVisit(CreateTableStatement table)
            {
                if (IsSupportedForCurrentType(table.GetType()))
                {
                    Name = table.SchemaObjectName;
                }
            }

            public override void ExplicitVisit(CreateProcedureStatement proc)
            {
                if (IsSupportedForCurrentType(proc.GetType())
                    && proc.ProcedureReference != null)
                {
                    Name = proc.ProcedureReference.Name;
                }
            }

            public override void ExplicitVisit(AlterProcedureStatement proc)
            {
                if (IsSupportedForCurrentType(proc.GetType())
                    && proc.ProcedureReference != null)
                {
                    Name = proc.ProcedureReference.Name;
                }
            }

            public override void ExplicitVisit(AlterFunctionStatement func)
            {
                if (IsSupportedForCurrentType(func.GetType()))
                {
                    Name = func.Name;
                }
            }

            public override void ExplicitVisit(CreateFunctionStatement func)
            {
                if (IsSupportedForCurrentType(func.GetType()))
                {
                    Name = func.Name;
                }
            }

            
            private bool IsSupportedForCurrentType(Type fragmentType)
            {
                if (_validTypes == null)
                {
                    return false;
                }

                foreach (Type type in _validTypes)
                {
                    if (fragmentType.IsAssignableFrom(type))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}
