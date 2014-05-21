
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
    
    internal partial class NewsLetter_Configuration : EntityTypeConfiguration<NewsLetter>
    {
        public NewsLetter_Configuration()
        {                        
              this.HasKey(t => t.LetterId);        
              this.ToTable("NewsLetter");
              this.Property(t => t.LetterId).HasColumnName("LetterId");
              this.Property(t => t.RoleId).HasColumnName("RoleId");
              this.Property(t => t.Letter).HasColumnName("Letter").IsRequired();
              this.Property(t => t.Description).HasColumnName("Description");
              this.Property(t => t.TimePeriod).HasColumnName("TimePeriod");
              this.Property(t => t.CreateDate).HasColumnName("CreateDate");
              this.HasRequired(t => t.User_Role).WithMany(t => t.NewsLetters).HasForeignKey(d => d.RoleId);
         }
    }
}
