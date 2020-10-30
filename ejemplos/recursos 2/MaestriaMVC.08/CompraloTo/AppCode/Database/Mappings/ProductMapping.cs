using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

using CompraloTo.Domain;

namespace CompraloTo.DB
{
    /// <summary>
    /// Configure product mappings to database
    /// </summary>
    public sealed class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {

            this.HasKey(c => c.ID);

            this.Property(c => c.createDate).IsRequired();
            this.Property(c => c.name).HasMaxLength(100).IsRequired();
            this.Property(c => c.description).IsRequired();
            this.Property(c => c.price).HasPrecision(10, 2).IsRequired();

            //product - category
            this.HasRequired(c => c.category).WithMany().Map(m => m.MapKey("categoryID"));

            this.ToTable("products");

        }

    }


    /// <summary>
    /// Configure product category mappings to database
    /// </summary>
    public sealed class ProductCategoryMapping : EntityTypeConfiguration<ProductCategory>
    {
        public ProductCategoryMapping()
        {

            this.HasKey(c => c.ID);
            this.Property(c => c.name).HasMaxLength(100).IsRequired();
            this.ToTable("products_category");

        }

    }
}