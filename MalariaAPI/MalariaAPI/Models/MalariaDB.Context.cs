﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DiseaseDBEntities : DbContext
    {
        public DiseaseDBEntities()
            : base("name=DiseaseDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ActiveArea> ActiveAreas { get; set; }
        public virtual DbSet<Cause> Causes { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Outbreak> Outbreaks { get; set; }
        public virtual DbSet<Prevention> Preventions { get; set; }
        public virtual DbSet<Specialist> Specialists { get; set; }
        public virtual DbSet<Subtype> Subtypes { get; set; }
        public virtual DbSet<SuppliesList> SuppliesLists { get; set; }
        public virtual DbSet<Symptom> Symptoms { get; set; }
        public virtual DbSet<Treatment> Treatments { get; set; }
    }
}
