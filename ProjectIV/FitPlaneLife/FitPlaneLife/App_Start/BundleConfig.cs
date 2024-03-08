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
            
               bundles.Add(new ScriptBundle("~/js").Include(
                    "~/js/jquery-1.11.0.min.js",
                    "~/js/bootstrap.min.js",
                    "~/js/jquery.appear.js",
                    "~/js/jquery.prettyPhoto.js",
                    "~/js/modernizr-latest.js",
                    "~/js/SmoothScroll.js",
                    "~/js/jquery.parallax-1.1.3.js",
                    "~/js/jquery.easing.1.3.js",
                    "~/js/jquery.superslides.js",
                    "~/js/jquery.flexslider.js",
                    "~/js/jquery.mb.YTPlayer.js",
                    "~/js/jquery.fitvids.js",
                    "~/js/jquery.slabtext.js",
                    "~/js/plugins.js"));

               bundles.Add(new StyleBundle("~/css").Include(
                    "~/css/reset.css",
                    "~/css/animate.min.css",
                    "~/css/bootstrap.min.css",
                    "~/css/style.css",
                    "~/css/font-awesome.css",
                    "~/css/owl.carousel.css",
                    "~/css/responsive.css",
                    "~/css/player/YTPlayer.css",
                    "~/css/pro-bars.css"));
        }
    }
}