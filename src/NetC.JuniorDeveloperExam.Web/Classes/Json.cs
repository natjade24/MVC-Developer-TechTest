using System.Collections.Generic;
using System.IO;
using System.Linq;
using NetC.JuniorDeveloperExam.Web.Interfaces;
using NetC.JuniorDeveloperExam.Web.Models;
using Newtonsoft.Json;

namespace NetC.JuniorDeveloperExam.Web.Classes
{
    public class Json : IJson
    {
        private RootObject rootObject;

        public Json(RootObject rootObject)
        {
            this.rootObject = rootObject;
        }

        public List<BlogPosts> GetJsonData()
        {
            int id = 1;
            List<BlogPosts> rootObjects = new List<BlogPosts>();

            string blogPosts =
                File.ReadAllText(
                    @"C:\source\repos\MVC-Developer-TechTest\src\NetC.JuniorDeveloperExam.Web\App_Data\Blog-Posts.json");

            RootObject deserializeObject = JsonConvert.DeserializeObject<RootObject>(blogPosts);

            rootObjects = deserializeObject.BlogPosts.Where(x => x.Id == id).ToList();

            return rootObjects;
        }
    }
}