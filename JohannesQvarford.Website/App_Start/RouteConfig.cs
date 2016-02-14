namespace JohannesQvarford.Website
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.LowercaseUrls = true;
            routes.MapRoute(
                name: "Projects",
                url: "{language}/projects/{title}",
                defaults: new { language = "en", controller = "Projects", action = "GetProject" });
            routes.MapRoute(
                name: "Default",
                url: "{language}/{action}",
                defaults: new { language = "en", controller = "Home", action = "Index" }
            );
        }
    }
}