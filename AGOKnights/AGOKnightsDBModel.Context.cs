﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AGOKnights
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AGOKnightsDBModelContainer : DbContext
    {
        public AGOKnightsDBModelContainer()
            : base("name=AGOKnightsDBModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Calendar> Calendars { get; set; }
        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<ShirtSize> ShirtSizes { get; set; }
        public virtual DbSet<Budget> Budgets { get; set; }
    }
}
