
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
    
    internal partial class User_Role_Configuration : EntityTypeConfiguration<User_Role>
    {
        public User_Role_Configuration()
        {                        
              this.HasKey(t => t.RoleId);        
              this.ToTable("User_Role");
              this.Property(t => t.RoleId).HasColumnName("RoleId");
              this.Property(t => t.Name).HasColumnName("Name").HasMaxLength(100);
              this.Property(t => t.Description).HasColumnName("Description").IsFixedLength().HasMaxLength(255);
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
         }
    }
}
