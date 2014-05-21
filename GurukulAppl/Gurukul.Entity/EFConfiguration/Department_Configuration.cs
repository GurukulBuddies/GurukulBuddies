
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
    
    internal partial class Department_Configuration : EntityTypeConfiguration<Department>
    {
        public Department_Configuration()
        {                        
              this.HasKey(t => t.DeptId);        
              this.ToTable("Department");
              this.Property(t => t.DeptId).HasColumnName("DeptId");
              this.Property(t => t.DeptName).HasColumnName("DeptName").HasMaxLength(50);
              this.Property(t => t.DeptHead).HasColumnName("DeptHead").HasMaxLength(50);
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
         }
    }
}
