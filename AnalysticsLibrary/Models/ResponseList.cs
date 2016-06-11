using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class Response<T>
    {
        [JsonProperty("error")]
        public Error Error { get; set; }
        [JsonProperty("items")]
        public List<T> Items { get; set; }


    }

}