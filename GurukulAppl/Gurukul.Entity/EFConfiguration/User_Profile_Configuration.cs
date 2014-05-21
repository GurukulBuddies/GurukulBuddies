
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
    
    internal partial class User_Profile_Configuration : EntityTypeConfiguration<User_Profile>
    {
        public User_Profile_Configuration()
        {                        
              this.HasKey(t => t.ProfileId);        
              this.ToTable("User_Profile");
              this.Property(t => t.ProfileId).HasColumnName("ProfileId");
              this.Property(t => t.UserName).HasColumnName("UserName").IsRequired().HasMaxLength(100);
              this.Property(t => t.Password).HasColumnName("Password").HasMaxLength(255);
              this.Property(t => t.FirstName).HasColumnName("FirstName").HasMaxLength(100);
              this.Property(t => t.LastName).HasColumnName("LastName").HasMaxLength(100);
              this.Property(t => t.EmailAddress).HasColumnName("EmailAddress").HasMaxLength(255);
              this.Property(t => t.UserCategoryId).HasColumnName("UserCategoryId");
              this.Property(t => t.UserRoleId).HasColumnName("UserRoleId");
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
              this.HasRequired(t => t.User_Category).WithMany(t => t.User_Profile).HasForeignKey(d => d.UserCategoryId);
              this.HasRequired(t => t.User_Role).WithMany(t => t.User_Profile).HasForeignKey(d => d.UserRoleId);
         }
    }
}
