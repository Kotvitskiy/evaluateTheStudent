using System.Web;
using System.Web.Optimization;

namespace TheBest
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Content/js/foundation.js",
                      "~/Content/js/app.js",
                      "~/Scripts/respond.js",
                      "~/Scripts/knockout-3.4.0.js",
                      "~/Scripts/Students/list.js"));

            bundles.Add(new StyleBundle("~/bundles/Semanticcss").Include(
                      "~/Content/semantic.css",
                      "~/Content/components/*.css"
                      
                ));

            bundles.Add(new ScriptBundle("~/bundles/Semanticjs").Include(
                    "~/Scripts/semantic.js",
                    "~/Content/components/*.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/foundation.css",
                      "~/Content/css/app.css",
                      "~/Content/site.css"));
        }
    }
}
