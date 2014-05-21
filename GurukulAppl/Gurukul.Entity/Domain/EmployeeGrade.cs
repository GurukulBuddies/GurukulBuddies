
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeGrade
    {
        public int GradeId { get; set; }
        public string GradeName { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
