using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        string SayHello();
    }


    public class Student : IPersonWithAddress
    {
        public string Address
        {
            get;set;
        }

        public string PostalCode
        {
            get;set;
        }

        public string Name
        {
            get; set;
        }

        public string SayHello()
        {
            return "Hola, soy un estudiante";
        }
    }


    public class Teacher : IPersonWithAddress
    {
        public string Address
        {
            get; set;
        }

        public string PostalCode
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public string SayHello()
        {
            return "Hola, soy un profesor";
        }
    }



}
