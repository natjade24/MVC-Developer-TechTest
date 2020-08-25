using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class BlogComments
    {
        public string Name { get; set; }
        public DateTime DateTime { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}