
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
    
    internal partial class EmployeeGrade_Configuration : EntityTypeConfiguration<EmployeeGrade>
    {
        public EmployeeGrade_Configuration()
        {                        
              this.HasKey(t => t.GradeId);        
              this.ToTable("EmployeeGrade");
              this.Property(t => t.GradeId).HasColumnName("GradeId");
              this.Property(t => t.GradeName).HasColumnName("GradeName").HasMaxLength(50);
         }
    }
}
