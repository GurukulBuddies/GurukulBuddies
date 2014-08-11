
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
    
    internal partial class Employee_Configuration : EntityTypeConfiguration<Employee>
    {
        public Employee_Configuration()
        {                        
              this.HasKey(t => t.EmpId);        
              this.ToTable("Employee");
              this.Property(t => t.EmpId).HasColumnName("EmpId");
              this.Property(t => t.ProfileId).HasColumnName("ProfileId");
              this.Property(t => t.DeptId).HasColumnName("DeptId");
              this.Property(t => t.GradeId).HasColumnName("GradeId");
              this.Property(t => t.ReportingManagerId).HasColumnName("ReportingManagerId");
              //this.HasRequired(t => t.Collage_Profile).WithMany(t => t.Employees).HasForeignKey(d => d.ProfileId);
              //this.HasRequired(t => t.Department).WithMany(t => t.Employees).HasForeignKey(d => d.DeptId);
              //this.HasRequired(t => t.Employee2).WithOptional(t => t.Employee1);
              //this.HasRequired(t => t.EmployeeGrade).WithMany(t => t.Employees).HasForeignKey(d => d.GradeId);
         }
    }
}
