
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<NewsLetter> NewsLetters { get; set; }
        public virtual ICollection<User_Profile> User_Profile { get; set; }
        public virtual ICollection<User_Task> User_Task { get; set; }
    }
}
