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
    
    public partial class MOTOR
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOTOR()
        {
            this.INSURANCEs = new HashSet<INSURANCE>();
        }
    
        public int MotorId { get; set; }
        public Nullable<int> ManufactureYear { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> RegNo { get; set; }
        public Nullable<int> EngineNo { get; set; }
        public Nullable<int> ChasisNo { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<long> CC { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public ICollection<INSURANCE> INSURANCEs { get; set; }
        public  USER USER { get; set; }
    }
}
