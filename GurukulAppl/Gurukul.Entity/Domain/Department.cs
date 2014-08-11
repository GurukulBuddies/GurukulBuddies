
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptHead { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        //public virtual ICollection<ELibrary> ELibraries { get; set; }
        //public virtual ICollection<Employee> Employees { get; set; }
        //public virtual ICollection<ExamTimeTable> ExamTimeTables { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
        //public virtual ICollection<Subject> Subjects { get; set; }
    }
}
