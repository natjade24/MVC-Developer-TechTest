using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web.UI;
using NetC.JuniorDeveloperExam.Web.Interfaces;
using NetC.JuniorDeveloperExam.Web.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

            string blogPosts =
                File.ReadAllText(
                    @"C:\source\repos\MVC-Developer-TechTest\src\NetC.JuniorDeveloperExam.Web\App_Data\Blog-Posts.json");

            List<BlogPosts> deserializeObject = JsonConvert.DeserializeObject<RootObject>(blogPosts).BlogPosts.Where(x => x.Id == id).ToList();

            return deserializeObject;
        }

        public void SaveJsonData(BlogComments blogComments)
        {
            int id = 1;

            string blogPosts =
                File.ReadAllText(
                    @"C:\source\repos\MVC-Developer-TechTest\src\NetC.JuniorDeveloperExam.Web\App_Data\Blog-Posts.json");

            List<BlogPosts> deserializeObjects = JsonConvert.DeserializeObject<RootObject>(blogPosts).BlogPosts.ToList();

            foreach (BlogPosts deserializeObject in deserializeObjects)
            {
                if (deserializeObject.Id == id)
                {
                    deserializeObject.BlogComments = new[]
                    {
                        new BlogComments
                        {
                            Name = deserializeObject.BlogComments[0].Name,
                            DateTime = deserializeObject.BlogComments[0].DateTime,
                            Email = deserializeObject.BlogComments[0].Email,
                            Message = deserializeObject.BlogComments[0].Message
                        }, 
                        new BlogComments
                        {
                            Name = deserializeObject.BlogComments[1].Name,
                            DateTime = deserializeObject.BlogComments[1].DateTime,
                            Email = deserializeObject.BlogComments[1].Email,
                            Message = deserializeObject.BlogComments[1].Message
                        }, 
                        new BlogComments
                        {
                            Name = deserializeObject.BlogComments[2].Name,
                            DateTime = deserializeObject.BlogComments[2].DateTime,
                            Email = deserializeObject.BlogComments[2].Email,
                            Message = deserializeObject.BlogComments[2].Message
                        }, 
                        new BlogComments
                        {
                            Name = blogComments.Name,
                            DateTime = blogComments.DateTime,
                            Email = blogComments.Email,
                            Message = blogComments.Message
                        }, 
                    };
                }
            }

            rootObject = new RootObject
            {
                BlogPosts = new[]
                {
                    new BlogPosts
                    {
                        Id = deserializeObjects[0].Id,
                        Title = deserializeObjects[0].Title,
                        Image = deserializeObjects[0].Image,
                        DateTime = deserializeObjects[0].DateTime,
                        BlogComments = deserializeObjects[0].BlogComments,
                        HtmlContent = deserializeObjects[0].HtmlContent

                    }, 
                    new BlogPosts
                    {
                        Id = deserializeObjects[1].Id,
                        Title = deserializeObjects[1].Title,
                        Image = deserializeObjects[1].Image,
                        DateTime = deserializeObjects[1].DateTime,
                        BlogComments = deserializeObjects[1].BlogComments,
                        HtmlContent = deserializeObjects[1].HtmlContent
                    }, 
                    new BlogPosts
                    {
                        Id = deserializeObjects[2].Id,
                        Title = deserializeObjects[2].Title,
                        Image = deserializeObjects[2].Image,
                        DateTime = deserializeObjects[2].DateTime,
                        BlogComments = deserializeObjects[2].BlogComments,
                        HtmlContent = deserializeObjects[2].HtmlContent
                    }, 
                }

            };

            string serializeObject = JsonConvert.SerializeObject(rootObject, Formatting.Indented);

            File.WriteAllText(
               @"C:\source\repos\MVC-Developer-TechTest\src\NetC.JuniorDeveloperExam.Web\App_Data\Blog-Posts.json",
               serializeObject);
        }
    }
}