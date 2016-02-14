namespace JohannesQvarford.Website.ViewEngine
{
    using System.Web.Mvc;

    public class LocalizationViewEngine : RazorViewEngine
    {
        public override ViewEngineResult FindView(ControllerContext controllerContext, string viewName, string masterName, bool useCache)
        {
            // Only use a suffix if language is not english.
            var language = (string)controllerContext.RouteData.Values["language"];
            var suffix = language != "en" ? $".{language}" : "";
            var newViewName = $"{viewName}{suffix}";

            return base.FindView(controllerContext, newViewName, masterName, useCache);
        }
    }
}