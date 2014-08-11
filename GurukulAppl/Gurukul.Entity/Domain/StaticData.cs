
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class StaticData
    {
        public int StaticId { get; set; }
        public int StaticName { get; set; }
        public string Description { get; set; }
        public byte[] File { get; set; }
        public byte[] Image { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        //public virtual ICollection<Event> Events { get; set; }
    }
}
