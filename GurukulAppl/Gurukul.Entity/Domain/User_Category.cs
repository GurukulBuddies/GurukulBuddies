
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
    
        //public virtual ICollection<Collage_Profile> Collage_Profile { get; set; }
        //public virtual ICollection<User_Profile> User_Profile { get; set; }
    }
}
