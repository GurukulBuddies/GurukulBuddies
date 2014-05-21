
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
    
    internal partial class User_Task_Configuration : EntityTypeConfiguration<User_Task>
    {
        public User_Task_Configuration()
        {                        
              this.HasKey(t => t.TaskId);        
              this.ToTable("User_Task");
              this.Property(t => t.TaskId).HasColumnName("TaskId");
              this.Property(t => t.TaskName).HasColumnName("TaskName").IsRequired().HasMaxLength(100);
              this.Property(t => t.Description).HasColumnName("Description").HasMaxLength(255);
              this.Property(t => t.RoleId).HasColumnName("RoleId");
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
              this.HasRequired(t => t.User_Role).WithMany(t => t.User_Task).HasForeignKey(d => d.RoleId);
         }
    }
}

