using System.Collections.Generic;
using NetC.JuniorDeveloperExam.Web.Models;

namespace NetC.JuniorDeveloperExam.Web.Interfaces
{
    public interface IJson
    {
        List<BlogPosts> GetJsonData();
    }
}
