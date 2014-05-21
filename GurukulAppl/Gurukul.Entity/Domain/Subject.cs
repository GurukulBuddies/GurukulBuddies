
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int DeptId { get; set; }
        public int SemId { get; set; }
        public Nullable<int> MinMarks { get; set; }
        public Nullable<int> MaxMarks { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual ICollection<ExamTimeTable> ExamTimeTables { get; set; }
        public virtual Semester Semester { get; set; }
    }
}
