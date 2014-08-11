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

    internal partial class Collage_Profile_Configuration : EntityTypeConfiguration<Collage_Profile>
    {
        public Collage_Profile_Configuration()
        {                        
              this.HasKey(t => t.ProfileId);        
              this.ToTable("Collage_Profile");
              this.Property(t => t.ProfileId).HasColumnName("ProfileId");
              this.Property(t => t.ProfileName).HasColumnName("ProfileName").IsRequired().HasMaxLength(50);
              this.Property(t => t.CategoryId).HasColumnName("CategoryId");
              this.Property(t => t.FatherName).HasColumnName("FatherName").HasMaxLength(50);
              this.Property(t => t.Age).HasColumnName("Age");
              this.Property(t => t.Gender).HasColumnName("Gender").HasMaxLength(10);
              this.Property(t => t.Status).HasColumnName("Status").HasMaxLength(20);
              this.Property(t => t.StartegicAccount).HasColumnName("StartegicAccount");
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
              //this.HasRequired(t => t.User_Category).WithMany(t => t.Collage_Profile).HasForeignKey(d => d.CategoryId);
         }
    }
}
