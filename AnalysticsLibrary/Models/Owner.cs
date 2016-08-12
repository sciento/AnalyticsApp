using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Models
{
    [Serializable]
    public class Owner
    {
        public Owner(Guid userId, string displayName)
        {
            UserId = userId;
            DisplayName = displayName;
        }

        [JsonProperty("userId")]
        public Guid UserId { get; private set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; private set; }
    }
}
