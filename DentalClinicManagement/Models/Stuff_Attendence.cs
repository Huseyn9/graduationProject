//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DentalClinicManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stuff_Attendence
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Stuff_Attendence()
        {
            this.Stuff_Attendence1 = new HashSet<Stuff_Attendence>();
        }
    
        public int id { get; set; }
        public Nullable<int> stuff_id { get; set; }
        public Nullable<bool> stuff_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Stuff_Attendence> Stuff_Attendence1 { get; set; }
        public virtual Stuff_Attendence Stuff_Attendence2 { get; set; }
    }
}
