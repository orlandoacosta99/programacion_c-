using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



using InyeccionDependencia.Domain;


namespace InyeccionDependencia.Services
{
    /// <summary>
    /// Implementation of Domain IDbContext
    /// </summary>
    public class GlobalDbContext : DbContext, IDbContext
    {

        /// <summary>
        /// Constructor which sets connection string name for use
        /// </summary>
        public GlobalDbContext() : base("mgcDB")
        {
            //Disable initializer
            Database.SetInitializer<GlobalDbContext>(null);

            //disable lazy loading of properties and proxy creation (enable eager loading)
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }


        /// <summary>
        /// Add model mappings entity-to-table
        /// </summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DepartmentModel());
            modelBuilder.Configurations.Add(new TeacherModel());
        }


        /// <summary>
        /// Create new record in DB
        /// </summary>
        public void Add<T>(T element) where T : Aggregate
        {
            this.Set<T>().Add(element);
        }

        

        /// <summary>
        /// Access to departments table
        /// </summary>
        public IQueryable<Department> Departments(bool trackChanges = false)
        {
            IQueryable<Department> query = this.Set<Department>();
            if (!trackChanges)
                query = query.AsNoTracking();
            return query;
        }


        /// <summary>
        /// Access to teachers table
        /// </summary>
        public IQueryable<Teacher> Teachers(bool trackChanges = false)
        {
            IQueryable<Teacher> query = this.Set<Teacher>();
            if (!trackChanges)
                query = query.AsNoTracking();
            return query;
        }



    }
}
