
namespace Gurukul.Entity.Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class ELibrary
    {
        public int ELibraryId { get; set; }
        public int DeptId { get; set; }
        public byte[] Notes { get; set; }
        public byte[] Videos { get; set; }
        public Nullable<int> UploadedUserId { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual User_Profile User_Profile { get; set; }
    }
}
