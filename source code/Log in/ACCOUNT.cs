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
    
    public partial class ACCOUNT
    {
        public long ACCOUNTNUMBER { get; set; }
        public long BRANCH_ID { get; set; }
        public long SSN { get; set; }
        public bool BALANCE { get; set; }
        public string ACCOUNTTYPE { get; set; }
    
        public virtual CUSTOMER CUSTOMER { get; set; }
        public virtual BRANCH BRANCH { get; set; }
    }
}