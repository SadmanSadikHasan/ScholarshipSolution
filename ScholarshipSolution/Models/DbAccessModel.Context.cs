﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScholarshipSolution.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class final_32_dbEntities : DbContext
    {
        public final_32_dbEntities()
            : base("name=final_32_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Expertise> Expertises { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<Professor> Professors { get; set; }
        public virtual DbSet<ProfessorResearchPaper> ProfessorResearchPapers { get; set; }
        public virtual DbSet<Scholarship> Scholarships { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentCourseResult> StudentCourseResults { get; set; }
        public virtual DbSet<StudentExpertise> StudentExpertises { get; set; }
        public virtual DbSet<StudentInterest> StudentInterests { get; set; }
        public virtual DbSet<StudentMessage> StudentMessages { get; set; }
        public virtual DbSet<StudentResearchPaper> StudentResearchPapers { get; set; }
        public virtual DbSet<University> Universities { get; set; }
        public virtual DbSet<StudentScholarship> StudentScholarships { get; set; }
    }
}
