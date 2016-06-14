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
    public class OperatingSystemStatistic
    {
        public OperatingSystemStatistic(Site site, string name, string version, int visits)
        {
            Site = site;
            Name = name;
            Version = version;
            Visits = visits;
        }

        [JsonProperty("site")]
        public Site Site { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("version")]
        public string Version { get; private set; }

        [JsonProperty("visits")]
        public int Visits { get; private set; }
    }
}
