using System.Web;
using System.Web.Optimization;

namespace BenimZamanlarim
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.unobtrusive"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                       "~/Content/bootstrap.css",
                       "~/Content/magnific-popup.css",
                       "~/Content/owl.carousel.css",
                       "~/Content/styles/style.css",
                       "~/Content/styles/skin-lblue.css",
                       "~/Content/custom.css"));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
           "~/Scripts/jquery.js",
           "~/Scripts/jquery.validate*",
           "~/Scripts/bootstrap.js",
           "~/Scripts/respond.js",
           "~/Scripts/placeholders.js",
           "~/Scripts/jquery.magnific-popup.min.js",
           "~/Scripts/owl.carousel.min.js",
           "~/Scripts/html5shiv.js",
           "~/Scripts/main.js",
           "~/Scripts/modernizr-2.6.2.js",
           "~/Scripts/jquery.unobtrusive-ajax.min.js",
           "~/Scripts/custom.js",
           "~/Scripts/fontawesome-all.js"
           ));
        }
    }
}
