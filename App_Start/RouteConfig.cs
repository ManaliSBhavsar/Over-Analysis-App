using System.Web.Mvc;
using System.Web.Routing;

namespace OverAnalysisApp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            // Ignore routes for things like favicon.ico
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // Enable attribute routing (optional, if you use attribute routing in controllers)
            routes.MapMvcAttributeRoutes();

            // Default route configuration
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Overs", action = "AddDetails", id = UrlParameter.Optional }
            );
        }
    }
}
