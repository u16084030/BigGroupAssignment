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
    
    public partial class Specialist
    {
        public int SpecialistID { get; set; }
        public Nullable<int> DiseaseID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserPassword { get; set; }
        public string UserGUID { get; set; }
        public Nullable<System.DateTime> GUIDExpiry { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Qualification { get; set; }
        public string Hospital { get; set; }
    
        public virtual Disease Disease { get; set; }
    }
}
