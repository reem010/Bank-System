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
    
    public partial class BANK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANK()
        {
            this.BRANCHes = new HashSet<BRANCH>();
        }
    
        public long CODE { get; set; }
        public string USERNAMEADMIN { get; set; }
        public string NAMEBANK { get; set; }
        public string STREETBANK { get; set; }
        public string CITYBANK { get; set; }
        public string COUNTRYBANK { get; set; }
    
        public virtual ADMIN ADMIN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BRANCH> BRANCHes { get; set; }
    }
}
