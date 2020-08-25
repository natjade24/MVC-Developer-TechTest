using System.Web.Mvc;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}