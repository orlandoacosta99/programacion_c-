using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    public static class QueryExtensions
    {

        /// <summary>
        /// Retrieve aggregate by ID
        /// </summary>
        public static T WithID<T>(this IQueryable<T> query, int ID) where T :AggregateRoot
        {
            return query.Where(c => c.ID == ID).FirstOrDefault();
        }

    }


    

}
