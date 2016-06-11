using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    public class Response<T>
    {
        public Error error { get; set; }

        public List<T> items { get; set; }


    }

}