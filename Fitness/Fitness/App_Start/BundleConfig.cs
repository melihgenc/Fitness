using System.Web;
using System.Web.Optimization;

namespace Fitness
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/Areas/member/bundles/jquery").Include(
                        "~/Areas/member/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/Areas/member/bundles/jqueryval").Include(
                        "~/Areas/member/Scripts/jquery.validate*"));
            
            bundles.Add(new ScriptBundle("~/Areas/member/bundles/modernizr").Include(
                        "~/Areas/member/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/Areas/member/bundles/bootstrap").Include(
                      "~/Areas/member/Scripts/bootstrap.js",
                      "~/Areas/member/Scripts/bootstrap.min.js",
                      "~/Areas/member/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Areas/member/Content/css").Include(
                      "~/Areas/member/Content/bootstrap.css",
                      "~/Areas/member/Content/bootstrap.min.css",
                      "~/Areas/member/Content/site.css"));

            bundles.Add(new StyleBundle("~/Areas/member/Content/theme/css").Include(
                      "~/Areas/member/Content/theme/freelancer.css",
                      "~/Areas/member/Content/theme/freelancer.min.css"));

            bundles.Add(new StyleBundle("~/Areas/member/Content/font-awesome/css").Include(
                      "~/Areas/member/Content/font-awesome/css/font-awesome.min.css"));

            bundles.Add(new ScriptBundle("~/Areas/member/Content/theme/js").Include(
                      "~/Areas/member/Content/theme/js/contact_me.js",
                      "~/Areas/member/Content/theme/js/freelancer.js",
                      "~/Areas/member/Content/theme/js/freelancer.min.js",
                      "~/Areas/member/Content/theme/js/jqBootstrapValidation.js"));
        }
    }
}
