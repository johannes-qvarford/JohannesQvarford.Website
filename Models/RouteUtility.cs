namespace JohannesQvarford.Website.Models
{
    using System.Linq;
    using Microsoft.AspNetCore.Html;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;

    public static class RouteUtility
    {
        public static IHtmlContent ProjectActionLink<T>(this IHtmlHelper<T> helper, string projectName, string linkText = null, object htmlAttributes = null)
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

        public static void RenderCulturePage<T>(this IHtmlHelper<T> helper, string path = null)
        {
            path = path ?? helper.ViewContext.ExecutingFilePath;
            var language = (string)helper.ViewContext.RouteData.Values["language"];
            var newPath = path.Replace(".cshtml", $".{language}.cshtml");
            helper.RenderPartial(newPath);
        }

        public static string ViewStartPage<T>(this IHtmlHelper<T> helper) 
        {
            var language = (string)helper.ViewContext.RouteData.Values["language"];
            return $"~/Shared/_Layout.{language}.cshtml";
        }
    }
}