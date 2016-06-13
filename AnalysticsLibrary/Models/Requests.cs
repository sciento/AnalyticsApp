using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Models
{
    [Serializable]
    public class Request<T>
    {
        [JsonProperty("data")]
        public T Data { get; set; }

    }

    [Serializable]
    public class AuthRequest
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("secret")]
        public string Secret { get; set; }
    }

}
