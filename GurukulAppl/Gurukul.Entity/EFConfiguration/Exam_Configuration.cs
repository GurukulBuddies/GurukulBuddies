
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
    
    internal partial class Exam_Configuration : EntityTypeConfiguration<Exam>
    {
        public Exam_Configuration()
        {                        
              this.HasKey(t => t.ExamId);        
              this.ToTable("Exam");
              this.Property(t => t.ExamId).HasColumnName("ExamId");
              this.Property(t => t.ExamName).HasColumnName("ExamName").IsRequired().HasMaxLength(50);
         }
    }
}
