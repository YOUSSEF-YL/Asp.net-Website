using System.Web.Optimization;


namespace Formation
{
    public class BundleConfig
    {
        public static void RegisterBundels(BundleCollection bundles)
        {

            bundles.Add(new StyleBundle("~/Conten/css").Include("~/Content/bootstrap_Quartz.css", "~/Content/Site.css"));
        }
    }
}