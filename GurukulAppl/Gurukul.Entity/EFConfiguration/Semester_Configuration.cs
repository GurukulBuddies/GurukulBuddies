
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
    
    internal partial class Semester_Configuration : EntityTypeConfiguration<Semester>
    {
        public Semester_Configuration()
        {                        
              this.HasKey(t => t.SemId);        
              this.ToTable("Semester");
              this.Property(t => t.SemId).HasColumnName("SemId");
              this.Property(t => t.SemName).HasColumnName("SemName").IsRequired().HasMaxLength(50);
         }
    }
}
