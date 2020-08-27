using System;
using Newtonsoft.Json;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class BlogComments
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        [JsonProperty("emailAddress")]
        public string Email { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}