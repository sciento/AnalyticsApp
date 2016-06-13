using Newtonsoft.Json;
using System;

namespace AnalysticsLibrary.Users
{
    [Serializable]
    public class Registration
    {
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }

    }
}
