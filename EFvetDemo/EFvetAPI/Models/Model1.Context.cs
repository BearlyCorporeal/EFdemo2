﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFvetAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DADEntities1 : DbContext
    {
        public DADEntities1()
            : base("name=DADEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C102107602Author> C102107602Author { get; set; }
        public virtual DbSet<C102107602Book> C102107602Book { get; set; }
        public virtual DbSet<C102107602Student> C102107602Student { get; set; }
        public virtual DbSet<C7602Owner> C7602Owner { get; set; }
        public virtual DbSet<C7602Pet> C7602Pet { get; set; }
        public virtual DbSet<C7602Procedure> C7602Procedure { get; set; }
        public virtual DbSet<C7602Treatment> C7602Treatment { get; set; }
        public virtual DbSet<ASSIGNMENT> ASSIGNMENTs { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Author0136> Author0136 { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Book0136> Book0136 { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public virtual DbSet<Office> Offices { get; set; }
        public virtual DbSet<Pet0136> Pet0136 { get; set; }
        public virtual DbSet<PetOwner0136> PetOwner0136 { get; set; }
        public virtual DbSet<Procedure0136> Procedure0136 { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<student0136> student0136 { get; set; }
        public virtual DbSet<Treatment0136> Treatment0136 { get; set; }
    }
}
