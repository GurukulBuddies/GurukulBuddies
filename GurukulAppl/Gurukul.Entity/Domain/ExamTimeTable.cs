
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamTimeTable
    {
        public int TimeTableId { get; set; }
        public int ExamId { get; set; }
        public int SemId { get; set; }
        public int DeptId { get; set; }
        public int SubjectId { get; set; }
        public Nullable<System.DateTime> ExamDate { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual ICollection<ExamResult> ExamResults { get; set; }
        public virtual Semester Semester { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
