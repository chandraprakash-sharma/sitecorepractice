﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NexaDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NexaDataDBEntities : DbContext
    {
        public NexaDataDBEntities()
            : base("name=NexaDataDBEntities")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<allState> allStates { get; set; }
        public virtual DbSet<nexaCarColor> nexaCarColors { get; set; }
        public virtual DbSet<nexaCarModel> nexaCarModels { get; set; }
        public virtual DbSet<nexaCarPrice> nexaCarPrices { get; set; }
        public virtual DbSet<nexaCarVarient> nexaCarVarients { get; set; }
        public virtual DbSet<nexaVarientColor> nexaVarientColors { get; set; }
        public virtual DbSet<AllCity> AllCities { get; set; }
    }
}