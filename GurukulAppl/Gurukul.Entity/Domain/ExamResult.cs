
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ExamResult
    {
        public int ResultId { get; set; }
        public int TimeTableId { get; set; }
        public int StudentId { get; set; }
        public Nullable<int> Marks { get; set; }
        public Nullable<bool> Result { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        //public virtual Student Student { get; set; }
        //public virtual ExamTimeTable ExamTimeTable { get; set; }
    }
}
