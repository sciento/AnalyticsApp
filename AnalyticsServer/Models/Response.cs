using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsServer.Models
{
    [DataContract]
    public class Response<T>
    {
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "error")]
        public Error Error { get; set; }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "items")]
        public List<T> Items { get; set; }


    }

}