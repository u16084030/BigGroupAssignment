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
    
    public partial class Subtype
    {
        public int SubtypeID { get; set; }
        public Nullable<int> DiseaseID { get; set; }
        public string SubtypeName { get; set; }
        public string Strain { get; set; }
        public string SubtypeDescription { get; set; }
    
        public virtual Disease Disease { get; set; }
    }
}
