//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MalariaAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Prevention
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Prevention()
        {
            this.SuppliesLists = new HashSet<SuppliesList>();
        }
    
        public int PreventID { get; set; }
        public Nullable<int> CauseID { get; set; }
        public string PreventDescription { get; set; }
        public string PreventEffective { get; set; }
    
        public virtual Cause Cause { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SuppliesList> SuppliesLists { get; set; }
    }
}
