using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    /// <summary>
    /// We use this class to define a course in our college
    /// </summary>
    public class Course : AggregateRoot
    {
        public string Name { get; protected set; }


        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected Course() { }


        /// <summary>
        /// Static factory constructor
        /// </summary>
        public static Course CreateNew(string name)
        {
            Validate.NotNullEmpty(name, "Course.Name is required");
            return new Course()
            {
                Name = name
            };
        }


        public override string ToString()
        {
            return Name;
        }

    }
}
