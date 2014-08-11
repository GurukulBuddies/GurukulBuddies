
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
    
    internal partial class ExamTimeTable_Configuration : EntityTypeConfiguration<ExamTimeTable>
    {
        public ExamTimeTable_Configuration()
        {                        
              this.HasKey(t => t.TimeTableId);        
              this.ToTable("ExamTimeTable");
              this.Property(t => t.TimeTableId).HasColumnName("TimeTableId");
              this.Property(t => t.ExamId).HasColumnName("ExamId");
              this.Property(t => t.SemId).HasColumnName("SemId");
              this.Property(t => t.DeptId).HasColumnName("DeptId");
              this.Property(t => t.SubjectId).HasColumnName("SubjectId");
              this.Property(t => t.ExamDate).HasColumnName("ExamDate");
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
              //this.HasRequired(t => t.Department).WithMany(t => t.ExamTimeTables).HasForeignKey(d => d.DeptId);
              //this.HasRequired(t => t.Exam).WithMany(t => t.ExamTimeTables).HasForeignKey(d => d.ExamId);
              //this.HasRequired(t => t.Semester).WithMany(t => t.ExamTimeTables).HasForeignKey(d => d.SemId);
              //this.HasRequired(t => t.Subject).WithMany(t => t.ExamTimeTables).HasForeignKey(d => d.SubjectId);
         }
    }
}
