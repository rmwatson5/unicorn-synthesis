//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Project.Website.Models {
    
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Home Page template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{36FA138C-0BA5-4599-9FA9-8DEA3E4E5F30}", "Lzm+MPZ7apOBG7zM+EPgiKxgCM4=", "Sitecore.Project.Website")]
    public partial interface IHomePageItem : global::Sitecore.Foundation.BaseSite.Models.I_BaseStandardTemplateItem, global::Sitecore.Foundation.BaseSite.Models.I_BaseWebPageItem, global::Sitecore.Project.Website.Models.IWebPageItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Local Content template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{4E19F038-F2AC-4E13-B504-61726778A4CB}", "WxYHLJrGfBg0kAm1Urow48Kt/HY=", "Sitecore.Project.Website")]
    public partial interface ILocalContentItem : global::Sitecore.Foundation.BaseSite.Models.I_BaseStandardTemplateItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Site Root template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{DD785895-FA3B-4FC0-BD37-EE060B271089}", "bqLzvFlNT/7tCAXECPeOrGqj7JE=", "Sitecore.Project.Website")]
    public partial interface ISiteRootItem : global::Sitecore.Foundation.BaseSite.Models.I_BaseStandardTemplateItem, global::Sitecore.Foundation.BaseSite.Models.I_BaseSiteRootItem {
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Web Page template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    [Synthesis.Synchronization.RepresentsSitecoreTemplateAttribute("{98EFFD1C-DF69-4A82-A882-E649873260A1}", "SvWp1XHj+ZldY+5fBXXj7LIS1TQ=", "Sitecore.Project.Website")]
    public partial interface IWebPageItem : global::Sitecore.Foundation.BaseSite.Models.I_BaseStandardTemplateItem, global::Sitecore.Foundation.BaseSite.Models.I_BaseWebPageItem {
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sitecore.Project.Website.Models.Concrete {
    
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Home Page template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public partial class HomePage : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.IHomePageItem {
        
        public HomePage(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public HomePage(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Home Page";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{36FA138C-0BA5-4599-9FA9-8DEA3E4E5F30}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public class HomePageInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{36FA138C-0BA5-4599-9FA9-8DEA3E4E5F30}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new HomePage(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new HomePage(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Local Content template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public partial class LocalContent : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.ILocalContentItem {
        
        public LocalContent(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public LocalContent(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Local Content";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{4E19F038-F2AC-4E13-B504-61726778A4CB}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public class LocalContentInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{4E19F038-F2AC-4E13-B504-61726778A4CB}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new LocalContent(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new LocalContent(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Site Root template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public partial class SiteRoot : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.ISiteRootItem {
        
        public SiteRoot(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public SiteRoot(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Site Root";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{DD785895-FA3B-4FC0-BD37-EE060B271089}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public class SiteRootInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{DD785895-FA3B-4FC0-BD37-EE060B271089}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new SiteRoot(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new SiteRoot(searchFields);
        }
    }
    
    /// <summary>Represents the /sitecore/templates/Project/Website/Web Page template</summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public partial class WebPage : global::Synthesis.StandardTemplateItem, global::Sitecore.Project.Website.Models.IWebPageItem {
        
        public WebPage(Sitecore.Data.Items.Item innerItem) : 
                base(innerItem) {
        }
        
        public WebPage(global::System.Collections.Generic.IDictionary<string, string> searchFields) : 
                base(searchFields) {
        }
        
        /// <summary>The name of the Sitecore Template that this class represents</summary>
        public static string TemplateName {
            get {
                return "Web Page";
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public static Sitecore.Data.ID ItemTemplateId {
            get {
                return new Sitecore.Data.ID("{98EFFD1C-DF69-4A82-A882-E649873260A1}");
            }
        }
        
        /// <summary>The ID of the Sitecore Template that this class represents</summary>
        public override Sitecore.Data.ID TemplateId {
            get {
                return ItemTemplateId;
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Synthesis", "9.1")]
    public class WebPageInitializer : Synthesis.Initializers.ITemplateInitializer {
        
        public Sitecore.Data.ID InitializesTemplateId {
            get {
                return new Sitecore.Data.ID("{98EFFD1C-DF69-4A82-A882-E649873260A1}");
            }
        }
        
        public Synthesis.IStandardTemplateItem CreateInstance(Sitecore.Data.Items.Item innerItem) {
            return new WebPage(innerItem);
        }
        
        public Synthesis.IStandardTemplateItem CreateInstanceFromSearch(global::System.Collections.Generic.IDictionary<string, string> searchFields) {
            return new WebPage(searchFields);
        }
    }
}
