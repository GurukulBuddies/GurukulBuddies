
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Exam
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
    
        //public virtual ICollection<ExamTimeTable> ExamTimeTables { get; set; }
    }
}
