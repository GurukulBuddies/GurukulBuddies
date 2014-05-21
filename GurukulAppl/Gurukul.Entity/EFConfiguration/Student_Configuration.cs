
namespace Gurukul.Entity.Configuration
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    using Gurukul.Entity.Domain;
    
    internal partial class Student_Configuration : EntityTypeConfiguration<Student>
    {
        public Student_Configuration()
        {                        
              this.HasKey(t => t.StudentId);        
              this.ToTable("Student");
              this.Property(t => t.StudentId).HasColumnName("StudentId");
              this.Property(t => t.ProfileId).HasColumnName("ProfileId");
              this.Property(t => t.DeptId).HasColumnName("DeptId");
              this.Property(t => t.SemId).HasColumnName("SemId");
              this.Property(t => t.JoinDate).HasColumnName("JoinDate");
              this.Property(t => t.GraduateDate).HasColumnName("GraduateDate");
              this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
              this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
              this.HasRequired(t => t.Collage_Profile).WithMany(t => t.Students).HasForeignKey(d => d.ProfileId);
              this.HasRequired(t => t.Department).WithMany(t => t.Students).HasForeignKey(d => d.DeptId);
              this.HasRequired(t => t.Semester).WithMany(t => t.Students).HasForeignKey(d => d.SemId);
         }
    }
}
