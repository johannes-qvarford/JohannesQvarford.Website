namespace JohannesQvarford.Website.Models
{
    using System;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class RouteUtility
    {
        public static MvcHtmlString ProjectActionLink(this HtmlHelper helper, string projectName, string linkText = null, object htmlAttributes = null)
        {
            return helper.ActionLink(linkText: linkText ?? projectName, actionName: "Index", controllerName: "Projects", routeValues: new { id = TitleToUrlSegment(projectName) }, htmlAttributes: htmlAttributes);
        }

        public static string TitleToUrlSegment(string title)
        {
            return title
                .Replace(' ', '-')
                .Replace('å', 'a')
                .Replace('ä', 'a')
                .Replace('ö', 'o')
                .Replace(":", "")
                .Replace("--", "-");
        }
    }
}