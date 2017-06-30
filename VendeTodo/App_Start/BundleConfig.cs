using System.Web;
using System.Web.Optimization;

namespace VendeTodo
{
    public class BundleConfig
    {
        // Para obtener más información sobre las uniones, visite http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Content/js/jquery.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Content/js/bootstrap.min.js"));
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                     "~/Content/css/bootstrap.min.css"));

            // Login
            bundles.Add(new ScriptBundle("~/login/scripts").Include(
                      "~/Content/js/sidebar-nav.min.js",
                      "~/Content/js/jquery.slimscroll.js",
                      "~/Content/js/waves.js",
                      "~/Content/js/custom.min.js",
                      "~/Content/js/jQuery.style.switcher.js"));
            bundles.Add(new StyleBundle("~/login/css").Include(
                      "~/Content/css/animate.css",
                      "~/Content/css/style.css",
                      "~/Content/css/blue.css",
                      "~/Content/css/spinners.css"));
            // _Layout
            bundles.Add(new ScriptBundle("~/_layout/scripts").Include(
                      "~/Content/js/sidebar-nav.min.js",
                      "~/Content/js/jquery.slimscroll.js",
                      "~/Content/js/waves.js",
                      "~/Content/js/custom.min.js"));
            bundles.Add(new StyleBundle("~/_layout/css").Include(
                      "~/Content/css/sidebar-nav.min.css",
                      "~/Content/css/animate.css",
                      "~/Content/css/style.css",
                      "~/Content/css/default-dark.css"));
            // Cuentas y Compras
            bundles.Add(new ScriptBundle("~/cuenta/scripts").Include(
                      "~/Content/js/tablesaw.js",
                      "~/Content/js/tablesaw-init.js",
                      "~/Content/js/jQuery.style.switcher.js"));
            bundles.Add(new ScriptBundle("~/detalleCompra/scripts").Include(
                      "~/Content/js/jquery.dataTables.min.js",
                      "~/Content/js/dataTables.buttons.min.js",
                      "~/Content/js/buttons.flash.min.js",
                      "~/Content/js/jszip.min.js",
                      "~/Content/js/pdfmake.min.js",
                      "~/Content/js/vfs_fonts.js",
                      "~/Content/js/buttons.html5.min.js",
                      "~/Content/js/buttons.print.min.js",
                      "~/Content/js/datatableDetalleCompra.js",
                      "~/Content/js/jQuery.style.switcher.js"));
            bundles.Add(new StyleBundle("~/cuenta/css").Include(
                      "~/Content/css/tablesaw.css"));
            bundles.Add(new StyleBundle("~/detalleCompra/css").Include(
                      "~/Content/css/jquery.dataTables.min.css",
                      "~/Content/css/buttons.dataTables.min.css"));
            // Productos


        }
    }
}
