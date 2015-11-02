namespace JohannesQvarford.Website
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Projects",
                url: "Projects/{title}",
                defaults: new { controller = "Projects", action = "GetProject" });

            routes.MapRoute(
                name: "Default",
                url: "{action}",
                defaults: new { controller = "Home", action = "Index" }
            );

            
        }
    }
}