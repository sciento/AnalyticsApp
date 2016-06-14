using AnalyticsLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Models
{
    [Serializable]
    public class BrowserStatistic
    {
        public BrowserStatistic(Site site, string name, string version, string userAgent, string language, int visits)
        {
            Site = site;
            Name = name;
            Version = version;
            UserAgent = userAgent;
            Language = language;
            Visits = visits;
        }

        [JsonProperty("site")]
        public Site Site { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("version")]
        public string Version { get; private set; }

        [JsonProperty("user_agent")]
        public string UserAgent { get; private set; }

        [JsonProperty("language")]
        public string Language { get; private set; }

        [JsonProperty("visits")]
        public int Visits { get; private set; }
    }
}
