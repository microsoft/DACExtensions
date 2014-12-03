//------------------------------------------------------------------------------
// <copyright company="Microsoft">
//   Copyright 2014 Microsoft
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{   
    public partial class TSqlTable
    {
        public IEnumerable<ISqlIndex> Indexes
        {
            get 
            {
                foreach (var element in Element.GetReferencing(Index.IndexedObject))
                {
                    yield return (ISqlIndex)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public IEnumerable<TSqlForeignKeyConstraint> ForeignKeyConstraints
        {
            get
            {
                foreach (var element in Element.GetReferencing(ForeignKeyConstraint.Host))
                {
                    yield return (TSqlForeignKeyConstraint)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public IEnumerable<TSqlPrimaryKeyConstraint> PrimaryKeyConstraints
        {
            get 
            {
                foreach (var element in Element.GetReferencing(PrimaryKeyConstraint.Host))
                {
                    yield return (TSqlPrimaryKeyConstraint)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public IEnumerable<TSqlDefaultConstraint> DefaultConstraints
        {
            get
            {
                foreach (var element in Element.GetReferencing(DefaultConstraint.Host))
                {
                    yield return (TSqlDefaultConstraint)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public IEnumerable<TSqlCheckConstraint> CheckConstraints
        {
            get
            {
                foreach (var element in Element.GetReferencing(CheckConstraint.Host))
                {
                    yield return (TSqlCheckConstraint)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        /// <summary>
        /// Returns all constraints for the table
        /// </summary>
        public IEnumerable<ISqlModelElement> AllConstraints
        {
            get
            {
                foreach(var constraint in ForeignKeyConstraints)
                {
                    yield return constraint;
                }
                foreach (var constraint in PrimaryKeyConstraints)
                {
                    yield return constraint;
                }
                foreach (var constraint in CheckConstraints)
                {
                    yield return constraint;
                }
                foreach (var constraint in DefaultConstraints)
                {
                    yield return constraint;
                }
            }
        }
        public IEnumerable<TSqlDmlTrigger> Triggers
        {
            get
            {
                foreach(var element in Element.GetReferencing(DmlTrigger.TriggerObject))
                {
                    yield return (TSqlDmlTrigger)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

    }
    public partial class TSqlFileTable
    {
        public IEnumerable<ISqlIndex> Indexes
        {
            get
            {
                foreach (var element in Element.GetReferencing(Index.IndexedObject))
                {
                    yield return (ISqlIndex)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public IEnumerable<TSqlDmlTrigger> Triggers
        {
            get
            {
                foreach (var element in Element.GetReferencing(DmlTrigger.TriggerObject))
                {
                    yield return (TSqlDmlTrigger)TSqlModelElement.AdaptInstance(element);
                }
            }

        }
    }

    public partial class TSqlTableValuedFunction
    {
        public IEnumerable<ISqlIndex> Indexes
        {
            get
            {
                foreach (var element in Element.GetReferencing(Index.IndexedObject))
                {
                    yield return (ISqlIndex)TSqlModelElement.AdaptInstance(element);
                }
            }
        }
    }

    public partial class TSqlView
    {
        public IEnumerable<ISqlIndex> Indexes
        {
            get
            {
                foreach (var element in Element.GetReferencing(Index.IndexedObject))
                {
                    yield return (ISqlIndex)TSqlModelElement.AdaptInstance(element);
                }
            }
        }

        public IEnumerable<TSqlDmlTrigger> Triggers
        {
            get
            {
                foreach (var element in Element.GetReferencing(DmlTrigger.TriggerObject))
                {
                    yield return (TSqlDmlTrigger)TSqlModelElement.AdaptInstance(element);
                }
            }

        }
    }
}
