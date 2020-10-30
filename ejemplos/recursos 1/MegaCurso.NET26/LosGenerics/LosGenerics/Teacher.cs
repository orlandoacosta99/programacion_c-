using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosGenerics
{
    public class Teacher : Person
    {

        public Teacher()
        {

        }


        public Teacher(string number)
        {
            this.TeacherNumber = number;
        }


        public string TeacherNumber { get; set; }
    }
}
