﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity.SQL.ProjectTracker.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectTrackerContainer : DbContext
    {
        public ProjectTrackerContainer()
            : base("name=ProjectTrackerContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<dProject> dProjects { get; set; }
        public virtual DbSet<dTask> dTasks { get; set; }
        public virtual DbSet<dComponent> dComponents { get; set; }
    }
}
