using System.Collections.Generic;
using Sitecore.Feature.Media.Models;
using Sitecore.Foundation.BaseSite.Models;
using Sitecore.Foundation.DataAccess.Models;

namespace Sitecore.Feature.Media.Model
{
    public class CarouselRenderingModel : SynthesisRenderingModel<I_BaseWebPageItem, ICarouselSettingsItem>
    {
        public IEnumerable<ICarouselSlideItem> Slides { get; set; }
    }
}
