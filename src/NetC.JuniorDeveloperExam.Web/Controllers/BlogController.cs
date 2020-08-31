using System;
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
            IJsonDataReader json = new JsonDataReader(rootObject);
            List<BlogPosts> blogPosts = new List<BlogPosts>();

            if (ModelState.IsValid)
            {
                blogPosts = json.GetJsonData();
            }

            return View(blogPosts);
        }

        [HttpPost]
        public ActionResult Index(BlogComments blogComments)
        {
            if (ModelState.IsValid)
            {
                RootObject rootObject = new RootObject();
                IJsonDataReader json = new JsonDataReader(rootObject);
                blogComments.DateTime = DateTime.UtcNow;
                json.SaveJsonData(blogComments);
            }

            return RedirectToAction("Index");
        }
    }
}