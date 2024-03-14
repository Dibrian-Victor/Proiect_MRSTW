using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace FitPlaneLife.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
    
               bundles.Add(new StyleBundle("~/css").Include(
                    "~/Vendors/img/favicon.ico",
                    "~/Vendors/lib/flaticon/font/flaticon.css",
                    "~/Vendors/css/style.min.css"));

               bundles.Add(new ScriptBundle("~/js").Include(
                    "~/Vendors/lib/easing/easing.min.js",
                    "~/Vendors/lib/waypoints/waypoints.min.js",
                    "~/Vendors/mail/jqBootstrapValidation.min.js",
                    "~/Vendors/mail/contact.js",
                    "~/Vendors/js/main.js"));
        }
    }
}

   