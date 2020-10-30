using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    /// <summary>
    /// We use this class to define an association between student and course
    /// </summary>
    public class StudentCourse : Aggregate
    {
        public Student Student { get; protected set; }
        public Course Course { get; protected set; }

        /// <summary>
        /// Static factory constructor
        /// </summary>
        public static StudentCourse CreateNew(Student student, Course course)
        {
            Validate.NotNull(student, "StudentCourse.Student is required");
            Validate.NotNull(course, "StudentCourse.Course details is required");

            return new StudentCourse()
            {
                Student = student,
                Course = course,
            };

        }



    }
}
