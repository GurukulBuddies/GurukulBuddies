
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Semester
    {
        public int SemId { get; set; }
        public string SemName { get; set; }
    
        //public virtual ICollection<ExamTimeTable> ExamTimeTables { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
        //public virtual ICollection<Subject> Subjects { get; set; }
    }
}
