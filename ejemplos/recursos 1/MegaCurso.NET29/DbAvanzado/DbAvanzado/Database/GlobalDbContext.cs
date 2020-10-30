using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DbAvanzado
{
    public class GlobalDbContext : DbContext
    {

        public GlobalDbContext() : base("mgcDB")
        {

        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentModel());
            //modelBuilder.Configurations.Add(new TeacherModel());

            
        }



        public void Add<T>(T theElement) where T : class
        {
            this.Set<T>().Add(theElement);
        }


        public void Remove<T>(T theElement) where T : class
        {
            this.Set<T>().Remove(theElement);
        }



        public IQueryable<Student> Students(bool trackChanges = false)
        {
            IQueryable<Student> query = this.Set<Student>();

            if(!trackChanges)
            {
                query = query.AsNoTracking();
            }

            return query;
        }


    }
}
