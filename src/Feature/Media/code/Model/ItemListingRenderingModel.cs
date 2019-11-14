using System.Collections.Generic;
using Sitecore.Feature.Media.Models;
using Sitecore.Foundation.BaseSite.Models;
using Sitecore.Foundation.DataAccess.Models;

namespace Sitecore.Feature.Media.Model
{
    public class ItemListingRenderingModel : SynthesisRenderingModel<I_BaseWebPageItem, IItemListingSettingsItem>
    {
        public IEnumerable<IItemListingItemItem> ListingItems { get; set; }
    }
}
