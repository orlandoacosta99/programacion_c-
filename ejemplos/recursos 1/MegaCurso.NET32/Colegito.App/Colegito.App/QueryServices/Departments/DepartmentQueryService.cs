using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Colegito.Domain;

namespace Colegito.App
{

    public interface IDepartmentQueryService
    {
        List<Department> GetDepartments();
    }


    /// <summary>
    /// We use this class to query departments for user interface
    /// </summary>
    public class DepartmentQueryService : IDepartmentQueryService
    {
        private IDbContext _context;

        /// <summary>
        /// Constructor with dependency injection
        /// </summary>
        public DepartmentQueryService(IDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Retrieve list of departments
        /// </summary>
        public List<Department> GetDepartments()
        {
            return _context.Departments().ToList();
        }
    }
}
