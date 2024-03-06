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
               // Bootstrap style
               bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include(
                    "~/Content/bootstrap.min.css", new CssRewriteUrlTransform()));

               // Bootstrap
               bundles.Add(new StyleBundle("~/bundles/bootstrap/js").Include(
                   "~/Scripts/bootstrap.min.js"));
          }
    }
}