using System.Linq;
using Sitecore.Feature.Scaffolding.Model;
using System.Web.Mvc;
using Sitecore.Foundation.BaseSite.Models;

namespace Sitecore.Feature.Scaffolding.Controllers
{
    public class HeaderController : Controller
    {
        public ActionResult MainNavigation()
        {
            var model = new MainNavigationRenderingModel();
            model.NavigationItems = model.RenderingItem.Children.OfType<INavigationItemItem>();

            return this.View(model);
        }
    }
}
