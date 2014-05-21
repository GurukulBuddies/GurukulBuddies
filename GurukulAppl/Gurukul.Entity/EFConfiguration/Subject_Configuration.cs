
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
    
    internal partial class Subject_Configuration : EntityTypeConfiguration<Subject>
    {
        public Subject_Configuration()
        {                        
              this.HasKey(t => t.SubjectId);        
              this.ToTable("Subject");
              this.Property(t => t.SubjectId).HasColumnName("SubjectId");
              this.Property(t => t.SubjectName).HasColumnName("SubjectName").IsRequired().HasMaxLength(50);
              this.Property(t => t.DeptId).HasColumnName("DeptId");
              this.Property(t => t.SemId).HasColumnName("SemId");
              this.Property(t => t.MinMarks).HasColumnName("MinMarks");
              this.Property(t => t.MaxMarks).HasColumnName("MaxMarks");
              this.HasRequired(t => t.Department).WithMany(t => t.Subjects).HasForeignKey(d => d.DeptId);
              this.HasRequired(t => t.Semester).WithMany(t => t.Subjects).HasForeignKey(d => d.SemId);
         }
    }
}
