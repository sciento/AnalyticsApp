//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnalyticsServer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    [DataContract]
    public partial class Visits
    {
        public System.Guid Id { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public string PageUrl { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "call_time")]
        public string CallTime { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "exit_time")]
        public string ExitTime { get; set; }
        public string Referral { get; set; }
        public string Os { get; set; }
        public System.Guid SiteId { get; set; }
    
        public virtual Sites Sites { get; set; }
    }
}