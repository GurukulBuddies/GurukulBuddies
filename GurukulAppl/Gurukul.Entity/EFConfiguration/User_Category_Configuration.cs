
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
    
    internal partial class User_Category_Configuration : EntityTypeConfiguration<User_Category>
    {
        public User_Category_Configuration()
        {                        
              this.HasKey(t => t.CategoryId);        
              this.ToTable("User_Category");
              this.Property(t => t.CategoryId).HasColumnName("CategoryId");
              this.Property(t => t.Name).HasColumnName("Name").HasMaxLength(100);
         }
    }
}
