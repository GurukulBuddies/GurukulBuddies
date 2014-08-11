
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int ContactId { get; set; }
        public int ProfileId { get; set; }
        public string ContactName { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneExt { get; set; }
        public string FaxNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PreferredContact { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        //public virtual Collage_Profile Collage_Profile { get; set; }
    }
}
