using System.Linq;
using System.Web.Mvc;
using Sitecore.Feature.Media.Model;
using Sitecore.Feature.Media.Models;
using Sitecore.Feature.Media.Models.Concrete;

namespace Sitecore.Feature.Media.Controllers
{
    public class SynthesisMediaController : Controller
    {
        public ActionResult Carousel()
        {
            var model = new CarouselRenderingModel();
            model.Slides = model.RenderingItem.Children.OfType<CarouselSlide>();
            return this.View(model);
        }

        public ActionResult ItemListing()
        {
            var model = new ItemListingRenderingModel();
            model.ListingItems = model.RenderingItem.Children.OfType<IItemListingItemItem>();
            return this.View(model);
        }
    }
}
