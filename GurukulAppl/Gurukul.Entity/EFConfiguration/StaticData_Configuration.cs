
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
    
    internal partial class StaticData_Configuration : EntityTypeConfiguration<StaticData>
    {
        public StaticData_Configuration()
        {                        
              this.HasKey(t => t.StaticId);        
              this.ToTable("StaticData");
              this.Property(t => t.StaticId).HasColumnName("StaticId");
              this.Property(t => t.StaticName).HasColumnName("StaticName");
              this.Property(t => t.Description).HasColumnName("Description").HasMaxLength(50);
              this.Property(t => t.File).HasColumnName("File");
              this.Property(t => t.Image).HasColumnName("Image");
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
         }
    }
}
