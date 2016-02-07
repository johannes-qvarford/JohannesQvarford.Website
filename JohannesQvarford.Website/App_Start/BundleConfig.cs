namespace JohannesQvarford.Website
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Optimization;

    using Models;

    public static class BundleConfig
    {
        private static readonly string[] SingleStyles = { "project", "about", "cv" };

        private static readonly IList<string> ProjectStyles = 
            ProjectUtility.Projects.Select(RouteUtility.TitleToUrlSegment).ToArray();

        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            foreach (var style in SingleStyles.Concat(ProjectStyles))
            {
                bundles.Add(new StyleBundle("~/Content/" + style).Include("~/Content/" + style + ".css"));
            }
        }
    }
}