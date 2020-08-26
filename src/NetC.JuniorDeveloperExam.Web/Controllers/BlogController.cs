using System.Web.Mvc;
using NetC.JuniorDeveloperExam.Web.Interfaces;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class BlogController : Controller
    {
        private readonly IJson json;

        public BlogController(IJson json)
        {
            this.json = json;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}