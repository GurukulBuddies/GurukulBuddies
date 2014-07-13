using System.Web;
using System.Web.Optimization;

namespace Gurukul.Web
{
    public class BundleConfig
    {
        
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery/jquery-1.9.1.intellisense.js", "~/Scripts/jquery/jquery-1.9.1.js",
                        "~/Scripts/jquery/jquery-1.9.1.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery/jquery-ui-1.8.20.js", "~/Scripts/jquery/jquery-ui-1.8.20.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/kendo").Include(
                      "~/Scripts/kendo/knockout-kendo.min.js", "~/Scripts/kendo/knockout-kendo.js",
                      "~/Scripts/kendo/kendo.web.min.js", "~/Scripts/kendo/kendo.culture.en-US.min.js",
                      "~/Scripts/kendo/kendo.culture.en.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                       "~/Scripts/jquery/jquery.unobtrusive-ajax.js", "~/Scripts/jquery/jquery.unobtrusive-ajax.min.js",
                       "~/Scripts/jquery/jquery.validate-vsdoc.js", "~/Scripts/jquery/jquery.validate.js",
                       "~/Scripts/jquery/jquery.validate.min.js", "~/Scripts/jquery/jquery.validate.unobtrusive.js",
                       "~/Scripts/jquery/jquery.validate.unobtrusive.min.js"));

            bundles.Add(new ScriptBundle("~/Scripts/knockout").Include(
                   "~/Scripts/knockout/knockout-2.1.0.debug.js", "~/Scripts/knockout/knockout-2.1.0.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/kendo").Include(
                        "~/Content/kendo/kendo.common.min.css",
                        "~/Content/kendo/kendo.default.min.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}