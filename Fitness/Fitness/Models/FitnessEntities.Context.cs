﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Fitness.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FitnessTrialEntities : DbContext
    {
        public FitnessTrialEntities()
            : base("name=FitnessTrialEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FitnessClubOwners> FitnessClubOwners { get; set; }
        public virtual DbSet<FitnessClubs> FitnessClubs { get; set; }
        public virtual DbSet<PersonelTrainers> PersonelTrainers { get; set; }
        public virtual DbSet<UserDetails> UserDetails { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
