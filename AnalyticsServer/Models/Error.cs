using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsServer.Models
{
    [DataContract]
    public class Error
    {

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "name")]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "message")]
        public string Message { get; set; }  
    }
}