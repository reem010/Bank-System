//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Log_in
{
    using System;
    using System.Collections.Generic;
    
    public partial class CUSTOMER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CUSTOMER()
        {
            this.ACCOUNTs = new HashSet<ACCOUNT>();
            this.CUTOMER_PHONE = new HashSet<CUTOMER_PHONE>();
            this.LOANs = new HashSet<LOAN>();
        }
    
        public string FNAME { get; set; }
        public string MIDDLENAME { get; set; }
        public string LNAME { get; set; }
        public long SSN { get; set; }
        public string CITY_CUSTOMER { get; set; }
        public string STREET_CUSTOMER { get; set; }
        public string USERNAME_ADMIN { get; set; }
        public string PASSWORD_ADMIN { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACCOUNT> ACCOUNTs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CUTOMER_PHONE> CUTOMER_PHONE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOAN> LOANs { get; set; }
    }
}
