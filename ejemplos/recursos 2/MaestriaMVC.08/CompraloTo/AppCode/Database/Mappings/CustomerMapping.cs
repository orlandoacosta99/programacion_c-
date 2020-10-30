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
    public sealed class CustomerMapping : EntityTypeConfiguration<Customer>
    {
        public CustomerMapping()
        {
            this.HasKey(c => c.ID);

            this.Property(c => c.name).HasMaxLength(100).IsRequired();
            this.Property(c => c.lastName).HasMaxLength(100).IsRequired();
            this.Property(c => c.address).HasMaxLength(200).IsRequired();
            this.Property(c => c.email).HasMaxLength(150).IsRequired();
            this.Property(c => c.phone).HasMaxLength(20).IsRequired();
            this.Property(c => c.invoiceAddress).HasMaxLength(200);
            this.Property(c => c.shippingAddress).HasMaxLength(200);

            this.ToTable("customers");
        }

    }
}