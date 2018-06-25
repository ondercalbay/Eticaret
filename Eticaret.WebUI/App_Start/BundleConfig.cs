using System.Web.Optimization;

namespace Eticaret.WebUI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            //bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //            "~/Scripts/jquery.validate*"));

            //// Use the development version of Modernizr to develop with and learn from. Then, when you're
            //// ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //            "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
                      //"~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/canvas").Include(
                    "~/Content/Thema/canvas/style.css",
                    "~/Content/Thema/canvas/css/dark.css",
                    "~/Content/Thema/canvas/css/font-icons.css",
                    "~/Content/Thema/canvas/css/animate.css",
                    "~/Content/Thema/canvas/css/magnific-popup.css",
                    "~/Content/Thema/canvas/css/responsive.css"));

            bundles.Add(new StyleBundle("~/Content/admin").Include(
                   "~/Content/Thema/sb/sb-admin.css"));

            bundles.Add(new StyleBundle("~/Content/Slider").Include(
        "~/Content/Thema/canvas//include/rs-plugin/css/settings.css",
        "~/Content/Thema/canvas//include/rs-plugin/css/layers.css",
        "~/Content/Thema/canvas//include/rs-plugin/css/navigation.css"));


 



            //bundles.Add(new StyleBundle("~/Content/admin").Include(            
            //          "~/Content/site.css",                      
            //          "~/Content/themes/sb/sb-admin.css"));
        }
    }
}