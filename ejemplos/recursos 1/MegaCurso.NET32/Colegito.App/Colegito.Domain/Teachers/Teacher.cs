using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    /// <summary>
    /// We use this class to define a teacher on our college
    /// </summary>
    public class Teacher : AggregateRoot
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }

        public Address Address { get; protected set; }
        public ContactDetails Contact { get; protected set; }

        public Department Department { get; protected set; }


        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected Teacher() { }

        

        /// <summary>
        /// Static factory constructor
        /// </summary>
        public static Teacher CreateNew(string name, string lastName, Address address, ContactDetails contact, 
            Department department)
        {
            Validate.NotNullEmpty(name, "Teacher.Name is required");
            Validate.NotNullEmpty(lastName, "Teacher.LastName is required");
            Validate.NotNull(address, "Teacher.Address is required");
            Validate.NotNull(contact, "Student.Contact details is required");
            Validate.NotNull(department, "Teacher.Department is required");

            return new Teacher()
            {

                Name = name,
                LastName = lastName,

                Address = address,
                Contact = contact,

                Department = department,


            };

        }

    }
}
