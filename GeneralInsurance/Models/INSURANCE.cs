//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneralInsurance.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class INSURANCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public INSURANCE()
        {
            this.CLAIMs = new HashSet<CLAIM>();
        }
    
        public int InsuranceId { get; set; }
        public string Plans { get; set; }
        public Nullable<int> Duration { get; set; }
        public Nullable<System.DateTime> PolicyStartDate { get; set; }
        public Nullable<System.DateTime> PolicyEndDate { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> MotorId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public  ICollection<CLAIM> CLAIMs { get; set; }
        public MOTOR MOTOR { get; set; }
        public  USER USER { get; set; }
    }
}
