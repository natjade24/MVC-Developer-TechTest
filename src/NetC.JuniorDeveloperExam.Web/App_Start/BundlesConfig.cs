using System.Web.Optimization;

namespace NetC.JuniorDeveloperExam.Web
{
    public class BundlesConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Scripts/unobtrusive-bootstrap.js"));
            bundles.Add(new ScriptBundle("~/Scripts/bootstrap.bundle.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jquery-3.3.1.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jquery.validate.min.js"));
            bundles.Add(new ScriptBundle("~/Scripts/jquery.validate.unobtrusive.min.js"));
        }
    }
}