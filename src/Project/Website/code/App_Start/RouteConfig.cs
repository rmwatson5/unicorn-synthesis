using System.Web.Mvc;
using System.Web.Routing;
using Sitecore.Foundation.Helpers;
using Sitecore.Project.Website;

[assembly: WebActivatorEx.PostApplicationStartMethod(typeof(RouteConfig), "Initialize")]
namespace Sitecore.Project.Website
{
    public class RouteConfig
    {
        public static void Initialize()
        {
            RegisterRoutes(RouteTable.Routes);
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: MvcHelpers.RouteNames.Default,
                url: "api/{controller}/{action}/{id}",
                defaults: new { id = UrlParameter.Optional }
            );
        }
    }
}
