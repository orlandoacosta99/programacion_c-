using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Colegito.Domain;


namespace Colegito.App
{

    public interface ITeacherQueryService
    {
        List<Teacher> GetTeachers(string searchText, int? departmentID);
    }


    /// <summary>
    /// We use this class to query teachers for the user interface
    /// </summary>
    public class TeacherQueryService : ITeacherQueryService
    {
        private IDbContext _context;
        public TeacherQueryService(IDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Retrieve list of teachers, filtered by search text and/or department
        /// </summary>
        public List<Teacher> GetTeachers(string searchText, int? departmentID)
        {

            IQueryable<Teacher> query = _context
                .Teachers()
                .IncludeDepartment();


            //filter by department?
            if(departmentID.HasValue)
            {
                query = query.FromDepartment(departmentID.Value);
            }

            //filter by search text
            if(!string.IsNullOrEmpty(searchText))
            {
                query = query.Where(t =>
                    t.Name.Contains(searchText) ||
                    t.LastName.Contains(searchText)
                );
            }

            //execute query
            return query.ToList();
        }
    }
}
