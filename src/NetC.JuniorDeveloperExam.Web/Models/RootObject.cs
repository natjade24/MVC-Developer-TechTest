using Newtonsoft.Json;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class RootObject
    {
        [JsonProperty("blogPosts")]
        public BlogPosts[] BlogPosts { get; set; }
    }
}