
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
    
    internal partial class ELibrary_Configuration : EntityTypeConfiguration<ELibrary>
    {
        public ELibrary_Configuration()
        {                        
              this.HasKey(t => t.ELibraryId);        
              this.ToTable("ELibrary");
              this.Property(t => t.ELibraryId).HasColumnName("ELibraryId");
              this.Property(t => t.DeptId).HasColumnName("DeptId");
              this.Property(t => t.Notes).HasColumnName("Notes");
              this.Property(t => t.Videos).HasColumnName("Videos");
              this.Property(t => t.UploadedUserId).HasColumnName("UploadedUserId");
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              //this.HasRequired(t => t.Department).WithMany(t => t.ELibraries).HasForeignKey(d => d.DeptId);
              //this.HasOptional(t => t.User_Profile).WithMany(t => t.ELibraries).HasForeignKey(d => d.UploadedUserId);
         }
    }
}
