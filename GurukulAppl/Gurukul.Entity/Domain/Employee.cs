
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmpId { get; set; }
        public int ProfileId { get; set; }
        public int DeptId { get; set; }
        public int GradeId { get; set; }
        public int ReportingManagerId { get; set; }
    
        //public virtual Collage_Profile Collage_Profile { get; set; }
        //public virtual Department Department { get; set; }
        //public virtual Employee Employee1 { get; set; }
        //public virtual Employee Employee2 { get; set; }
        //public virtual EmployeeGrade EmployeeGrade { get; set; }
    }
}
