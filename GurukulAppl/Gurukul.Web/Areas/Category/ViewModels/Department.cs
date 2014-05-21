
namespace Gurukul.Web.Areas.Category.ViewModels
{
    using System;
    using System.Collections.Generic;

    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public string DeptHead { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
