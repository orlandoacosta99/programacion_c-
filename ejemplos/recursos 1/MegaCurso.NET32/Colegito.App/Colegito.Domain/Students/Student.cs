using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    /// <summary>
    /// We use this class to define a student in our college
    /// </summary>
    public class Student : AggregateRoot
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }

        public Address Address { get; protected set; }
        public ContactDetails Contact { get; protected set; }

        public List<StudentCourse> Courses { get; protected set; }


        /// <summary>
        /// Static factory constructor
        /// </summary>
        public static Student CreateNew(string name, string lastName, Address address, ContactDetails contact)
        {
            Validate.NotNullEmpty(name, "Student.Name is required");
            Validate.NotNullEmpty(lastName, "Student.LastName is required");
            Validate.NotNull(address, "Student.Address is required");
            Validate.NotNull(contact, "Student.Contact details is required");

            return new Student()
            {

                Name = name,
                LastName = lastName,

                Address = address,
                Contact = contact, 

                Courses = new List<StudentCourse>()

            };

        }


        /// <summary>
        /// Enroll student to the selected course
        /// </summary>
        public void EnrollCourse(Course course)
        {
            Validate.NotNull(course, "Student.EnrollCourse course cannot be null");
            Validate.IsTrue(Courses.Where(c => c.ID == course.ID).Count() == 0, "Student.EnrollCourse student already enrolled to course");


            this.Courses.Add(StudentCourse.CreateNew(this, course));
        }


    }
}
