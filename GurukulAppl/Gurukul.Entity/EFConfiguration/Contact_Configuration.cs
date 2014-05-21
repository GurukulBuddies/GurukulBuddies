
namespace Gurukul.Entity.Configuration
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    using Gurukul.Entity.Domain;
    
    internal partial class Contact_Configuration : EntityTypeConfiguration<Contact>
    {
        public Contact_Configuration()
        {                        
              this.HasKey(t => t.ContactId);        
              this.ToTable("Contact");
              this.Property(t => t.ContactId).HasColumnName("ContactId");
              this.Property(t => t.ProfileId).HasColumnName("ProfileId");
              this.Property(t => t.ContactName).HasColumnName("ContactName").HasMaxLength(50);
              this.Property(t => t.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(50);
              this.Property(t => t.PhoneExt).HasColumnName("PhoneExt").HasMaxLength(50);
              this.Property(t => t.FaxNumber).HasColumnName("FaxNumber").HasMaxLength(50);
              this.Property(t => t.EmailAddress).HasColumnName("EmailAddress").HasMaxLength(500);
              this.Property(t => t.PreferredContact).HasColumnName("PreferredContact").HasMaxLength(50);
              this.Property(t => t.Address1).HasColumnName("Address1").HasMaxLength(50);
              this.Property(t => t.Address2).HasColumnName("Address2").HasMaxLength(50);
              this.Property(t => t.City).HasColumnName("City").HasMaxLength(50);
              this.Property(t => t.StateOrProvince).HasColumnName("StateOrProvince").HasMaxLength(50);
              this.Property(t => t.CountryCode).HasColumnName("CountryCode").HasMaxLength(50);
              this.Property(t => t.ZipCode).HasColumnName("ZipCode").HasMaxLength(10);
              this.Property(t => t.CreateUser).HasColumnName("CreateUser").HasMaxLength(50);
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.Property(t => t.UpdateUser).HasColumnName("UpdateUser").HasMaxLength(50);
              this.Property(t => t.UpdateDate).HasColumnName("UpdateDate");
              this.HasRequired(t => t.Collage_Profile).WithMany(t => t.Contacts).HasForeignKey(d => d.ProfileId);
         }
    }
}
