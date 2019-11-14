using System.Collections.Generic;
using Sitecore.Feature.Scaffolding.Models;
using Sitecore.Foundation.BaseSite.Models;
using Sitecore.Foundation.DataAccess.Models;

namespace Sitecore.Feature.Scaffolding.Model
{
    public class MainNavigationRenderingModel : SynthesisRenderingModel<I_BaseWebPageItem, IMainNavigationSettingsItem>
    {
        public IEnumerable<INavigationItemItem> NavigationItems { get; set; }
    }
}
