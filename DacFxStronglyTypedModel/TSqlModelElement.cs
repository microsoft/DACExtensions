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
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.TransactSql.ScriptDom;
using Microsoft.SqlServer.Dac;
using DacFxStronglyTypedModel;
using System.Globalization;

namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
    public abstract partial class TSqlModelElement : ISqlModelElement
    {
        public TSqlModelElement(TSqlObject obj, ModelTypeClass typeClass)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("obj");
            }
            else if (obj.ObjectType != typeClass)
            {
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture,
                    Messages.InvalidObjecType, obj.ObjectType.Name, typeClass.Name),
                    "typeClass");
            }
            Element = obj; 
        }

        public TSqlObject Element
        {
            get;
            private set;
        }

        public ModelTypeClass ObjectType { get { return Element.ObjectType; } }

        public object this[ModelPropertyClass property] { get { return Element[property]; } }

        public override bool Equals(object obj)
        {
            return Element.Equals(obj);
        }
        
        public TSqlScript GetAst()
        {
            return Element.GetAst();
        }

        public IEnumerable<TSqlObject> GetChildren()
        {
            return Element.GetChildren();
        }
        public IEnumerable<TSqlObject> GetChildren(DacQueryScopes queryScopes)
        {
            return Element.GetChildren(queryScopes);
        }
        public override int GetHashCode()
        {
            return Element.GetHashCode();
        }

        public T GetMetadata<T>(ModelMetadataClass metadata)
        {
            return Element.GetMetadata<T>(metadata);
        }
        public object GetMetadata(ModelMetadataClass metadata)
        {
            return Element.GetMetadata(metadata);
        }
        public TSqlObject GetParent()
        {
            return Element.GetParent();
        }
        public TSqlObject GetParent(DacQueryScopes queryScopes)
        {
            return Element.GetParent(queryScopes);
        }
        public T GetProperty<T>(ModelPropertyClass property)
        {
            return Element.GetProperty<T>(property);
        }
        public object GetProperty(ModelPropertyClass property)
        {
            return Element.GetProperty(property);
        }
        public IEnumerable<TSqlObject> GetReferenced()
        {
            return Element.GetReferenced();
        }
        public IEnumerable<TSqlObject> GetReferenced(DacQueryScopes queryScopes)
        {
            return Element.GetReferenced(queryScopes);
        }
        public IEnumerable<TSqlObject> GetReferenced(ModelRelationshipClass relationshipType)
        {
            return Element.GetReferenced(relationshipType);
        }

        public IEnumerable<TSqlObject> GetReferenced(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes)
        {
            return Element.GetReferenced(relationshipType, queryScopes);

        }
        public IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances()
        {
            return Element.GetReferencedRelationshipInstances();
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(DacExternalQueryScopes queryScopes)
        {
            return Element.GetReferencedRelationshipInstances(queryScopes);
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(DacQueryScopes queryScopes)
        {
            return Element.GetReferencedRelationshipInstances(queryScopes);

        }
        public IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(ModelRelationshipClass relationshipType)
        {
            return Element.GetReferencedRelationshipInstances(relationshipType);
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(ModelRelationshipClass relationshipType, DacExternalQueryScopes queryScopes)
        {
            return Element.GetReferencedRelationshipInstances(relationshipType, queryScopes);
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes)
        {
            return Element.GetReferencedRelationshipInstances(relationshipType, queryScopes);
        }
        public IEnumerable<TSqlObject> GetReferencing()
        {
            return Element.GetReferencing();
        }
        public IEnumerable<TSqlObject> GetReferencing(DacQueryScopes queryScopes)
        {
            return Element.GetReferencing(queryScopes);
        }
        public IEnumerable<TSqlObject> GetReferencing(ModelRelationshipClass relationshipType)
        {
            return Element.GetReferencing(relationshipType);
        }
        public IEnumerable<TSqlObject> GetReferencing(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes)
        {
            return Element.GetReferencing(relationshipType, queryScopes);
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances()
        {
            return Element.GetReferencingRelationshipInstances();
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances(DacQueryScopes queryScopes)
        {
            return Element.GetReferencingRelationshipInstances(queryScopes);
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances(ModelRelationshipClass relationshipType)
        {
            return Element.GetReferencingRelationshipInstances(relationshipType);
        }
        public IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes)
        {
            return Element.GetReferencingRelationshipInstances(relationshipType, queryScopes);
        }
        public string GetScript()
        {
            return Element.GetScript();
        }
        public SourceInformation GetSourceInformation()
        {
            return Element.GetSourceInformation();
        }
        public bool TryGetAst(out TSqlScript objectAst)
        {
            return Element.TryGetAst(out objectAst);
        }
        public bool TryGetScript(out string objectScript)
        {
            return Element.TryGetScript(out objectScript);
        }
    }
}
