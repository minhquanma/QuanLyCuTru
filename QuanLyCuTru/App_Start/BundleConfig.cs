using System.Web;
using System.Web.Optimization;

namespace QuanLyCuTru
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Jquery
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));
            // Jquery val
            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            // Jquery ui
            bundles.Add(new ScriptBundle("~/bundles/jquery-ui").Include(
                        "~/Scripts/jquery-ui*"));

            bundles.Add(new ScriptBundle("~/bundles/popper").Include(
                        "~/Scripts/popper*"));
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            // Bootstrap JS
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/bootbox.min.js",
                      "~/Scripts/respond.js"));

            // Bootstrap CSS
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.pulse.min.css",
                      "~/Content/site.css",
                      "~/Content/PagedList.css"));

            // Jquery ui CSS
            bundles.Add(new StyleBundle("~/Content/jquery-ui/base/css").Include(
              "~/Content/jquery-ui/base/theme.css",
              "~/Content/jquery-ui/base/jquery-ui.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}