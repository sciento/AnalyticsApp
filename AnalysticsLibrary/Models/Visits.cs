using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class Visits
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }

        [JsonProperty("ip")]
        public string Ip { get; set; }

        [JsonProperty("browser")]
        public string Browser { get; set; }

        [JsonProperty("page_url")]
        public string PageUrl { get; set; }

        [JsonProperty("call_time")]
        public string CallTime { get; set; }

        [JsonProperty("exit_time")]
        public string ExitTime { get; set; }

        [JsonProperty("referral")]
        public string Referral { get; set; }

        [JsonProperty("os")]
        public string Os { get; set; }

        [JsonProperty("site_id")]
        public System.Guid SiteId { get; set; }

        [JsonProperty("site")]
        public virtual Site Site { get; set; }
    }
}
