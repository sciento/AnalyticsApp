﻿using System.Web;
using System.Web.Optimization;

namespace AnalyticsApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/dashboard").Include(
                "~/Scripts/Chart.js",
                "~/Scripts/rx.all.js",
                "~/Scripts/App/statisticsservice.js",
                "~/Scripts/App/dashboard.js"));

            bundles.Add(new ScriptBundle("~/bundles/rxjs").Include(
                "~/Scripts/rx.all.js"));

            bundles.Add(new ScriptBundle("~/bundles/common").Include(
            "~/Scripts/App/Common/models.js",
            "~/Scripts/App/Common/notification.js",
            "~/Scripts/App/Common/request.js",
            "~/Scripts/App/Common/Routes.js"
            ));

            bundles.Add(new ScriptBundle("~/bundles/public").Include(
                "~/Scripts/App/Public/public.js"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/jquery-{version}.js",
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
