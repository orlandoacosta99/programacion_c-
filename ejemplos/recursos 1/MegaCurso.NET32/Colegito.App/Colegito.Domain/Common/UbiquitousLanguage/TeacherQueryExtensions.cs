using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace Colegito.Domain
{
    public static class TeacherQueryExtensions
    {
        /// <summary>
        /// Instruct EntityFramework to load department relationship
        /// </summary>
        public static IQueryable<Teacher> IncludeDepartment(this IQueryable<Teacher> query)
        {
            return query.Include(t => t.Department);
        }


        /// <summary>
        /// Filter teachers from a given deparment
        /// </summary>
        public static IQueryable<Teacher> FromDepartment(this IQueryable<Teacher> query, int departmentID)
        {
            return query.Where(t => t.Department.ID == departmentID);
        }
    }
}
