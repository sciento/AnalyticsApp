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
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Users()
        {
            this.Sites = new HashSet<Sites>();
        }

        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "user_id")]
        public System.Guid Id { get; set; }
        [IgnoreDataMember]
        public string Password { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "email")]
        public string Email { get; set; }
        [DataMember(EmitDefaultValue = false, IsRequired = false, Name = "display_name")]
        public string Username { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sites> Sites { get; set; }
    }
}