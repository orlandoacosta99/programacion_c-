using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

using CompraloTo.Domain;

namespace CompraloTo.DB
{
    /// <summary>
    /// Configure customers entity mapping to database
    /// </summary>
    public sealed class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            this.HasKey(c => c.ID);

            this.Property(c => c.email).HasMaxLength(200).IsRequired();
            this.Property(c => c.password).HasMaxLength(50).IsRequired();
            this.Property(c => c.token).HasMaxLength(50).IsRequired();
            this.Property(c => c.createDate).IsRequired();
            this.Property(c => c.role).IsRequired();

            this.HasOptional(c => c.customer).WithMany().Map(m => m.MapKey("customerID"));

            this.ToTable("users");
        }

    }
}