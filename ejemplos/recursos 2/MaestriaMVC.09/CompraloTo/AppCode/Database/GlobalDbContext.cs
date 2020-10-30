using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

using CompraloTo.Domain;

namespace CompraloTo.DB
{
    /// <summary>
    /// Main DB Context for database interaction
    /// </summary>
    public class GlobalDbContext : DbContext, IDbContext
    {

        /// <summary>
        /// Constructor, configure settings for Entity Framework
        /// </summary>
        public GlobalDbContext() : base("mgcDB")
        {
            Database.SetInitializer<GlobalDbContext>(null);
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        /// <summary>
        /// Add entity model mappings
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CustomerMapping());

            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new OrderDetailMapping());

            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new ProductCategoryMapping());
        }


        /// <summary>
        /// Add new element to database
        /// </summary>
        public void Add<T>(T theElement)where T :Aggregate
        {
            this.Set<T>().Add(theElement);
        }

        /// <summary>
        /// Delete element from database
        /// </summary>
        public void Remove<T>(T theElement) where T : Aggregate
        {
            this.Set<T>().Remove(theElement);
        }


        /// <summary>
        /// Access to customers table
        /// </summary>
        public IQueryable<Customer> Customers(bool trackChanges = false)
        {
            return trackChanges == false ? this.Set<Customer>().AsNoTracking() : this.Set<Customer>();
        }

        /// <summary>
        /// Access to orders table
        /// </summary>
        public IQueryable<Order> Orders(bool trackChanges = false)
        {
            return trackChanges == false ? this.Set<Order>().AsNoTracking() : this.Set<Order>();
        }

        /// <summary>
        /// Access to products table
        /// </summary>
        public IQueryable<Product> Products(bool trackChanges = false)
        {
            return trackChanges == false ? this.Set<Product>().AsNoTracking() : this.Set<Product>();
        }

        /// <summary>
        /// Access to product category table
        /// </summary>
        public IQueryable<ProductCategory> ProductCategories(bool trackChanges = false)
        {
            return trackChanges == false ? this.Set<ProductCategory>().AsNoTracking() : this.Set<ProductCategory>();
        }


        /// <summary>
        /// Save changes in DB
        /// </summary>
        void IDbContext.SaveChanges()
        {
            this.SaveChanges();
        }
    }
}