using System.Collections.Generic;
using System.Web.Mvc;
using NetC.JuniorDeveloperExam.Web.Classes;
using NetC.JuniorDeveloperExam.Web.Interfaces;
using NetC.JuniorDeveloperExam.Web.Models;

namespace NetC.JuniorDeveloperExam.Web.Controllers
{
    public class BlogController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            RootObject rootObject = new RootObject();
            IJson json = new Json(rootObject);
            List<BlogPosts> blogPosts = json.GetJsonData();
            return View(blogPosts);
        }

        [HttpPost]
        public ActionResult Index(BlogComments blogComments)
        {
            if (ModelState.IsValid)
            {
            }

            return RedirectToAction("Index");
        }
    }
}