
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Collage_Profile
    {
        public int ProfileId { get; set; }
        public string ProfileName { get; set; }
        public int CategoryId { get; set; }
        public string FatherName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public Nullable<bool> StartegicAccount { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        //public virtual User_Category User_Category { get; set; }
        //public virtual ICollection<Contact> Contacts { get; set; }
        //public virtual ICollection<Employee> Employees { get; set; }
        //public virtual ICollection<Event> Events { get; set; }
        //public virtual ICollection<Student> Students { get; set; }
    }
}
