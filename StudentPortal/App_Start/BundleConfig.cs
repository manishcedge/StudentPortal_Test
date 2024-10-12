using System.Web;
using System.Web.Optimization;

namespace StudentPortal
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                    "~/Content/js/bootstrap.bootstrap.min.js",
                     "~/Content/js/bootstrap.bootstrap.js"
                     )); 

            bundles.Add(new StyleBundle("~/Content/css").Include(

                      "~/Content/css/bootstrap.css",
                      "~/Content/css/bootstrap.min.css"
                      )); 
        }
    }
}
