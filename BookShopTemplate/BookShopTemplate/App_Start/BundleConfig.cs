using System.Web;
using System.Web.Optimization;

namespace BookShopTemplate
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            #region Template Design

            bundles.Add(new ScriptBundle("~/template/js").Include(
                        "~/Scripts/js/all.js",
                        "~/ Scripts / js / jquery.mobile.customized.min.js",
                        "~/Scripts/js/jquery.easing.1.3.js",
                        "~/Scripts/js/parallaxie.js",
                        "~/Scripts/js/headline.js",
                        "~/Scripts/js/owl.carousel.js",
                        "~/Scripts/js/jquery.nicescroll.min.js",
                        "~/Scripts/js/jqBootstrapValidation.js",
                        "~/Scripts/js/contact_me.js",
                        "~/Scripts/js/custom.js"
                        ));

            bundles.Add(new StyleBundle("~/template/css").Include(
                      "~/Content/css/bootstrap.min.css",
                      "~/Content/css/responsive.css",
                       "~/Content/css/custom.css",
                      "~/Content/style.css"));


            #endregion
        }
    }
}
