
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class NewsLetter
    {
        public int LetterId { get; set; }
        public int RoleId { get; set; }
        public byte[] Letter { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> TimePeriod { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual User_Role User_Role { get; set; }
    }
}
