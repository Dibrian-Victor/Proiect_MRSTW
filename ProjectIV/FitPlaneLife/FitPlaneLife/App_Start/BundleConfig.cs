using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FitPlaneLife.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
               bundles.Add(new ScriptBundle("~/lib").Include(
                    "~/lib/easing/easing.min.js",
                    "~/lib/waypoints/waypoints.min.js",
                    "~/lib/owlcarousel/owl.carousel.min.js",
                    "~/lib/counterup/counterup.min.js"));

               bundles.Add(new ScriptBundle("~/js").Include(
                   "~/js/main.js"));

               bundles.Add(new StyleBundle("~/img").Include(
                    "~/img/favicon.ico"));

               bundles.Add(new StyleBundle("~/css").Include(
                    "~/css/bootstrap.min.css",
                    "~/css/style.css"));

               bundles.Add(new StyleBundle("~/lib").Include(
                    "~/lib/owlcarousel/assets/owl.carousel.min.css",
                    "~/lib/flaticon/font/flaticon.css"));

        }
    }
}