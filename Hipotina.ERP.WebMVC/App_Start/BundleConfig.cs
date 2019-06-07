using System.Web;
using System.Web.Optimization;

namespace Hipotina_GECN
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
            
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));
            
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",                      
                      "~/Content/site.css"));
            

            /* --- Boostrap GECN - Gentelella --- */
            /*
            bundles.Add(new ScriptBundle("~/Content/css").Include(
                      "~/Content/vendors/bootstrap/dist/css/bootstrap.min.css",
                      "~/Content/vendors/font-awesome/css/font-awesome.min.css",
                      "~/Content/vendors/nprogress/nprogress.css",
                      "~/Content/vendors/bootstrap-progressbar/css/bootstrap-progressbar-3.3.4.min.css",
                      "~/Content/build/css/custom.min.css"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include( 
                      "~/Content/vendors/jquery/dist/jquery.min.js",
                      "~/Content/vendors/bootstrap/dist/js/bootstrap.min.js",
                      "~/Content/vendors/fastclick/lib/fastclick.js",
                      "~/Content/vendors/nprogress/nprogress.js",
                      "~/Content/vendors/Chart.js/dist/Chart.min.js",
                      "~/Content/vendors/jquery-sparkline/dist/jquery.sparkline.min.js",
                      "~/Content/vendors/raphael/raphael.min.js",
                      "~/Content/vendors/morris.js/morris.min.js",
                      "~/Content/vendors/gauge.js/dist/gauge.min.js",
                      "~/Content/vendors/bootstrap-progressbar/bootstrap-progressbar.min.js",
                      "~/Content/vendors/skycons/skycons.js",
                      "~/Content/vendors/DateJS/build/date.js",
                      "~/Content/vendors/moment/min/moment.min.js",
                      "~/build/js/custom.min.js",
                      "~/Scripts/respond.js"));

            BundleTable.EnableOptimizations = false;
            */
        

    }
    }
}
