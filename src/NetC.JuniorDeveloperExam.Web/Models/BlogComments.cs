using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace NetC.JuniorDeveloperExam.Web.Models
{
    public class BlogComments
    {
        [Required]
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        [Required]
        [JsonProperty("emailAddress")]
        public string Email { get; set; }

        [Required]
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}