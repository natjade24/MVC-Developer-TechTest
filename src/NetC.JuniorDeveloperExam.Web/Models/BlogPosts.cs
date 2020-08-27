using System;
using Newtonsoft.Json;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class BlogPosts
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("htmlContent")]
        public string HtmlContent { get; set; }

        [JsonProperty("comments")]
        public BlogComments[] BlogComments { get; set; }
    }
}