
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
