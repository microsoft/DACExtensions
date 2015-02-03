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

using Microsoft.SqlServer.Dac.CodeAnalysis;
using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

namespace Public.Dac.Samples.Rules
{
    /// <summary>
    /// This is an example of a localized export attribute. These can be very useful in the case where
    /// you need localized resource strings for things like the display name and description of a rule.
    /// 
    /// All of the export attributes provided by the DAC API can be localized, and internally a very
    /// similar structure is used. If you do not need to perform localization of any resources it's easier to use the
    /// <see cref="ExportCodeAnalysisRuleAttribute"/> directly.
    /// 
    /// </summary>
    internal class LocalizedExportCodeAnalysisRuleAttribute : ExportCodeAnalysisRuleAttribute
    {
        private readonly string _resourceBaseName;
        private readonly string _displayNameResourceId;
        private readonly string _descriptionResourceId;

        private ResourceManager _resourceManager;
        private string _displayName;
        private string _descriptionValue;

        /// <summary>
        /// Creates the attribute, with the specified rule ID, the fully qualified
        /// name of the resource file that will be used for looking up display name
        /// and description, and the Ids of those resources inside the resource file.
        /// </summary>
        public LocalizedExportCodeAnalysisRuleAttribute(
            string id,
            string resourceBaseName,
            string displayNameResourceId,
            string descriptionResourceId)
            : base(id, null)
        {
            _resourceBaseName = resourceBaseName;
            _displayNameResourceId = displayNameResourceId;
            _descriptionResourceId = descriptionResourceId;
        }

        /// <summary>
        /// Rules in a different assembly would need to overwrite this
        /// </summary>
        /// <returns></returns>
        protected virtual Assembly GetAssembly()
        {
            return GetType().Assembly;
        }

        private void EnsureResourceManagerInitialized()
        {
            var resourceAssembly = GetAssembly();

            try
            {
                _resourceManager = new ResourceManager(_resourceBaseName, resourceAssembly);
            }
            catch (Exception ex)
            {
                var msg = String.Format(CultureInfo.CurrentCulture, RuleResources.CannotCreateResourceManager, _resourceBaseName, resourceAssembly);
                throw new RuleException(msg, ex);
            }
        }

        private string GetResourceString(string resourceId)
        {
            if (string.IsNullOrWhiteSpace(resourceId))
            {
                return string.Empty;
            }
            EnsureResourceManagerInitialized();
            return _resourceManager.GetString(resourceId, CultureInfo.CurrentUICulture);
        }

        /// <summary>
        /// Overrides the standard DisplayName and looks up its value inside a resources file
        /// </summary>
        public override string DisplayName
        {
            get
            {
                if (_displayName == null)
                {
                    _displayName = GetResourceString(_displayNameResourceId);
                }
                return _displayName;
            }
        }

        /// <summary>
        /// Overrides the standard Description and looks up its value inside a resources file
        /// </summary>
        public override string Description
        {
            get
            {
                if (_descriptionValue == null)
                {
                    // Using the descriptionResourceId as the key for looking up the description in the resources file. 
                    _descriptionValue = GetResourceString(_descriptionResourceId);
                }
                return _descriptionValue;
            }
        }
    }
}
