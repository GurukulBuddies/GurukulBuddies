
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Profile
    {
        public int ProfileId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int UserCategoryId { get; set; }
        public int UserRoleId { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual ICollection<ELibrary> ELibraries { get; set; }
        public virtual User_Category User_Category { get; set; }
        public virtual User_Role User_Role { get; set; }
    }
}
