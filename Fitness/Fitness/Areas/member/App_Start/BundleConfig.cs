using System.Web;
using System.Web.Optimization;

namespace Fitness.Areas.member
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));
            
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/theme/css").Include(
                      "~/Content/theme/freelancer.css",
                      "~/Content/theme/freelancer.min.css"));

            bundles.Add(new StyleBundle("~/Content/font-awesome/css").Include(
                      "~/Content/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/Content/theme/js").Include(
                      "~/Content/theme/js/contact_me.js",
                      "~/Content/theme/js/freelancer.js",
                      "~/Content/theme/js/freelancer.min.js",
                      "~/Content/theme/js/jqBootstrapValidation.js"));
        }
    }
}
