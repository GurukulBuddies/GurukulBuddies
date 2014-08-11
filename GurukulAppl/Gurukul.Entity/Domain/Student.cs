
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentId { get; set; }
        public int ProfileId { get; set; }
        public int DeptId { get; set; }
        public int SemId { get; set; }
        public Nullable<System.DateTime> JoinDate { get; set; }
        public Nullable<System.DateTime> GraduateDate { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    
        //public virtual Collage_Profile Collage_Profile { get; set; }
        //public virtual Department Department { get; set; }
        //public virtual ICollection<ExamResult> ExamResults { get; set; }
        //public virtual Semester Semester { get; set; }
    }
}
