using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class Error
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }  
    }
}