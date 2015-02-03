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
using Microsoft.SqlServer.Dac;
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace Public.Dac.Samples
{
    /// <summary>
    /// Our filtering engine - takes in a bunch of filters, and 
    /// supports creating a new model with only the objects that pass these filters. 
    /// As with most samples this could be extended and improved, keeping it minimal for now
    /// </summary>
    public class ModelFilterer
    {
        private IList<IFilter> _filters;

        public ModelFilterer(params IFilter[] filters)
            : this((IList<IFilter>)filters) 
        {
        }

        public ModelFilterer(IList<IFilter> filters)
        {
            if (filters == null 
                || filters.Count == 0)
            {
                throw new ArgumentException("At least one filter must be specified", "filters");
            }
            _filters = new List<IFilter>(filters);
            QueryScopes = DacQueryScopes.UserDefined;
        }

        /// <summary>
        /// The scope of objects to be copied. Defaults to <see cref="DacQueryScopes.UserDefined"/> which just includes elements defined by the
        /// user in this package, but this could be combined with <see cref="DacQueryScopes.SameDatabase"/> to include composite references. 
        /// 
        /// This is really a choice between just copying objects 
        /// defined in the current model source (for example a dac package) or also including "Same Database" 
        /// objects that come from any referenced dacpacs that are marked as composite references. 
        /// 
        /// There are 2 important things to note:
        /// 1. When loading a model from a dacpac, the contents of any composited references dacpacs (where you marked the relationship
        /// as being "same database") will also be loaded into the model.
        /// They are returned if you query using <see cref="DacQueryScopes.SameDatabase"/>, but if you serialize the model using
        /// <see cref="DacPackageExtensions.BuildPackage(string,TSqlModel,PackageMetadata)"/>
        /// or <see cref="DacPackageExtensions.UpdateModel"/> they don't get saved.
        /// 
        /// 2. The filter works by copying from one model to another. If you choose to copy "Same Database" referenced objects then you
        /// will end up copying them into a new model, but they'll be treated as part of that model. That means they'll be saved if you 
        /// build a package. That's great if you're building a new package (since you won't have any references in the new package),
        /// but if you're updating an existing dac package it could cause errors - you essentially have the same elements saved in the package
        /// and listed in the referenced package. 
        /// </summary>
        public DacQueryScopes QueryScopes
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new filtered model by copying elements from an existing model
        /// </summary>
        public TSqlModel CreateFilteredModel(TSqlModel model)
        {
            // CloneModelOptions copies the database options of the existing model so that it can be used during
            // model creation
            TSqlModelOptions options = model.CloneModelOptions();

            TSqlModel filteredModel = new TSqlModel(model.Version, options);

            // A call to GetObjects with no ModelTypeClasses specified returns all top-level objects.
            // These are objects such as Tables, Views, Indexes - anything that can be defined by itself in TSQL.
            // Examples of non-top level objects are Columns.
            IEnumerable<TSqlObject> allObjects = model.GetObjects(QueryScopes);

            // Filter the objects and copy them to the new model.
            // Note that some objects such as DatabaseOptions, and any inlined constraints, will
            // not support being scripted out. DatabaseOptions don't get a TSQL representation (hence the clone method),
            // and inline constraints get scripted out with table/view definitions so to avoid duplication errors they
            // can't be scripted
            IFilter allFilters = new CompositeFilter(_filters);
            foreach (TSqlObject tsqlObject in allFilters.Filter(allObjects))
            {
                string script;
                if (tsqlObject.TryGetScript(out script))
                {
                    // Some objects such as the DatabaseOptions can't be scripted out.
                    filteredModel.AddObjects(script);
                }
            }

            return filteredModel;
        }

        /// <summary>
        /// Creates a new dacpac based on the filtered model. This implementation loads from and saves to
        /// disk, but the API supports loading from and saving to a memory stream. This can be useful if you
        /// want to support a scenario where you load a dacpac, filter its model, then immediately deploy the filtered
        /// model to a database. 
        /// </summary>
        public void CreateFilteredDacpac(string dacpacPath, string filteredDacpacPath)
        {
            DisposableList disposables = new DisposableList();
            try
            {
                TSqlModel model = disposables.Add(new TSqlModel(dacpacPath, DacSchemaModelStorageType.Memory));
                TSqlModel filteredModel = disposables.Add(CreateFilteredModel(model));

                DacPackageExtensions.BuildPackage(
                    filteredDacpacPath, 
                    filteredModel, 
                    new PackageMetadata(), // Describes the dacpac. 
                    new PackageOptions());  // Use this to specify the deployment contributors, refactor log to include in package
                
            }
            finally
            {
                // Models and DacPackage objects are disposable - either use a "using" statement or dispose of them in a finally block.
                // In these examples we'd end up with a large amount of indentation and to avoid that I'm using a try/finally block.
                disposables.Dispose();
            }
        }

        /// <summary>
        /// Updates the model inside an existing dacpac. All other parts of the package (the refactor log, pre/post deployment scripts,
        /// contributors to use etc) stay the same. 
        /// </summary>
        /// <param name="dacpacPath"></param>
        public void UpdateDacpacModelWithFilter(string dacpacPath)
        {
            DisposableList disposables = new DisposableList();

            try
            {
                TSqlModel model = disposables.Add(new TSqlModel(dacpacPath, DacSchemaModelStorageType.Memory));
                TSqlModel filteredModel = disposables.Add(CreateFilteredModel(model));

                // Note that the package must be opened in ReadWrite mode - this will fail if this isn't specified
                DacPackage package = disposables.Add(DacPackage.Load(dacpacPath, DacSchemaModelStorageType.Memory, FileAccess.ReadWrite));
                package.UpdateModel(filteredModel, new PackageMetadata());
            }
            finally
            {
                disposables.Dispose();
            }
        }
    }
}
