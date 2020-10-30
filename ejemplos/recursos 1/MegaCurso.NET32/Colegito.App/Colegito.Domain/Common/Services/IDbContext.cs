using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    public interface IDbContext
    {
        void Add<T>(T element) where T : AggregateRoot;


        IQueryable<Teacher> Teachers(bool trackChanges = false);
        IQueryable<Department> Departments(bool trackChanges = false);


        int SaveChanges();
    }
}
