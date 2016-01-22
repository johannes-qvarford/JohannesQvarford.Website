namespace JohannesQvarford.Website.Models
{
    using System.Linq;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;

    public static class RouteUtility
    {
        public static MvcHtmlString ProjectActionLink(this HtmlHelper helper, string projectName, string linkText = null, object htmlAttributes = null)
        {
            return helper.ActionLink(linkText: linkText ?? projectName, actionName: "GetProject", controllerName: "Projects", routeValues: new { title = TitleToUrlSegment(projectName) }, htmlAttributes: htmlAttributes);
        }

        public static string TitleToUrlSegment(string title)
        {
            return title
                .Replace(' ', '-')
                .Replace('å', 'a')
                .Replace('ä', 'a')
                .Replace('ö', 'o')
                .Replace(":", "")
                .Replace("--", "-")
                .ToLower();
        }
        
        public static string UrlSegmentToViewName(string urlSegment)
        {
            // converting a title to a url segment is lossy, so we can't go back.
            // Converting between url segments and view names is not.
            // The conversion resembles hyphen-seperated to PascalCase.
            return string.Join("", urlSegment.Split('-').Select(s => s.First().ToString().ToUpper() + s.Substring(1)));
        }
    }
}