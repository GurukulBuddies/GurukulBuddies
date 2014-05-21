
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Event
    {
        public int EventsId { get; set; }
        public string EventsName { get; set; }
        public string Description { get; set; }
        public Nullable<int> EventDataId { get; set; }
        public Nullable<System.DateTime> EventStartDate { get; set; }
        public Nullable<System.DateTime> EventEndDate { get; set; }
        public int ContactPersonId { get; set; }
    
        public virtual Collage_Profile Collage_Profile { get; set; }
        public virtual StaticData StaticData { get; set; }
    }
}
