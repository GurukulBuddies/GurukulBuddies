
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
    
    internal partial class Event_Configuration : EntityTypeConfiguration<Event>
    {
        public Event_Configuration()
        {                        
              this.HasKey(t => t.EventsId);        
              this.ToTable("Events");
              this.Property(t => t.EventsId).HasColumnName("EventsId");
              this.Property(t => t.EventsName).HasColumnName("EventsName").IsRequired().HasMaxLength(50);
              this.Property(t => t.Description).HasColumnName("Description");
              this.Property(t => t.EventDataId).HasColumnName("EventDataId");
              this.Property(t => t.EventStartDate).HasColumnName("EventStartDate");
              this.Property(t => t.EventEndDate).HasColumnName("EventEndDate");
              this.Property(t => t.ContactPersonId).HasColumnName("ContactPersonId");
              //this.HasRequired(t => t.Collage_Profile).WithMany(t => t.Events).HasForeignKey(d => d.ContactPersonId);
              //this.HasOptional(t => t.StaticData).WithMany(t => t.Events).HasForeignKey(d => d.EventDataId);
         }
    }
}
