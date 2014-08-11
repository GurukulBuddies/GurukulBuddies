
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
    
    internal partial class ExamResult_Configuration : EntityTypeConfiguration<ExamResult>
    {
        public ExamResult_Configuration()
        {                        
              this.HasKey(t => t.ResultId);        
              this.ToTable("ExamResult");
              this.Property(t => t.ResultId).HasColumnName("ResultId");
              this.Property(t => t.TimeTableId).HasColumnName("TimeTableId");
              this.Property(t => t.StudentId).HasColumnName("StudentId");
              this.Property(t => t.Marks).HasColumnName("Marks");
              this.Property(t => t.Result).HasColumnName("Result");
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
              //this.HasRequired(t => t.Student).WithMany(t => t.ExamResults).HasForeignKey(d => d.StudentId);
              //this.HasRequired(t => t.ExamTimeTable).WithMany(t => t.ExamResults).HasForeignKey(d => d.TimeTableId);
         }
    }
}
