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
namespace Microsoft.SqlServer.Dac.Extensions.Prototype
{
    using System;
    using Microsoft.SqlServer.TransactSql.ScriptDom;
    using Microsoft.SqlServer.Dac.Model;
    using System.Collections.Generic;
    public interface ISqlModelElement
    {
        TSqlObject Element { get; }
        TSqlScript GetAst();
        IEnumerable<TSqlObject> GetChildren();
        IEnumerable<TSqlObject> GetChildren(DacQueryScopes queryScopes);
        object GetMetadata(ModelMetadataClass metadata);
        T GetMetadata<T>(ModelMetadataClass metadata);
        TSqlObject GetParent();
        TSqlObject GetParent(DacQueryScopes queryScopes);
        object GetProperty(ModelPropertyClass property);
        T GetProperty<T>(ModelPropertyClass property);
        IEnumerable<TSqlObject> GetReferenced();
        IEnumerable<TSqlObject> GetReferenced(DacQueryScopes queryScopes);
        IEnumerable<TSqlObject> GetReferenced(ModelRelationshipClass relationshipType);
        IEnumerable<TSqlObject> GetReferenced(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes);
        IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances();
        IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(DacExternalQueryScopes queryScopes);
        IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(DacQueryScopes queryScopes);
        IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(ModelRelationshipClass relationshipType);
        IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(ModelRelationshipClass relationshipType, DacExternalQueryScopes queryScopes);
        IEnumerable<ModelRelationshipInstance> GetReferencedRelationshipInstances(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes);
        IEnumerable<TSqlObject> GetReferencing();
        IEnumerable<TSqlObject> GetReferencing(DacQueryScopes queryScopes);
        IEnumerable<TSqlObject> GetReferencing(ModelRelationshipClass relationshipType);
        IEnumerable<TSqlObject> GetReferencing(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes);
        IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances();
        IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances(DacQueryScopes queryScopes);
        IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances(ModelRelationshipClass relationshipType);
        IEnumerable<ModelRelationshipInstance> GetReferencingRelationshipInstances(ModelRelationshipClass relationshipType, DacQueryScopes queryScopes);
        string GetScript();
        SourceInformation GetSourceInformation();
        ModelTypeClass ObjectType { get; }
        object this[ModelPropertyClass property] { get; }
        bool TryGetAst(out TSqlScript objectAst);
        bool TryGetScript(out string objectScript);
    }
}
