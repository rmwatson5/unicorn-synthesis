using System;
using System.Collections.Generic;
using Synthesis.Configuration.Registration;

namespace Sitecore.Foundation.DataAccess
{
    public abstract class HelixModelRegistration : SynthesisConfigurationRegistration
    {
        protected abstract string HelixModuleType { get; }

        protected override string ConfigurationName => this.GetType().Assembly.GetName().Name;

        protected virtual string HelixModuleName => this.ConfigurationName.Substring(this.ConfigurationName.LastIndexOf(".", StringComparison.Ordinal) + 1);

        protected override IEnumerable<string> IncludedTemplates
        {
            get { yield return $"/sitecore/Templates/{this.HelixModuleType}/{this.HelixModuleName}"; }
        }

        protected override string NamespaceTemplatePathRoot => $"/sitecore/templates";

        protected override string ModelOutputFilePath => $"{this.HelixModuleType}/{this.HelixModuleName}/code/Synthesis.Model.cs";

        protected override string RootGeneratedNamespace => $"{this.ConfigurationName}.Models";
    }
}
