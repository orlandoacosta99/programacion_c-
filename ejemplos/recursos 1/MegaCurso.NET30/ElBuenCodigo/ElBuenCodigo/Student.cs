using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElBuenCodigo
{

    public interface IPerson
    {
        string Name { get; }
        string LastName { get; }
        string Address { get; }
        string Phone { get; }
        string Email { get; }

        void SayHello();

    }


    public class Person
    {

        public void GiveMeYourAddress()
        {

        }

    }


    public class Teacher : IPerson
    {
        
        public string Name { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set;}
        public string LastName { get;private set; }

        public DateTime CreateDate { get; private set; }


        public void SayHello()
        {
            throw new NotImplementedException();
        }


        public Teacher(string name, string address, string phone)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException("La propiedad name es requerida");

            if (string.IsNullOrEmpty(address))
                throw new InvalidOperationException("La propiedad dirección es requerida");

            if (string.IsNullOrEmpty(phone))
                throw new InvalidOperationException("La propiedad teléfono es requerida");

            this.CreateDate = DateTime.Now;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;


        }

        public void SetName(string name)
        {
            //validate is a valid name
        }


        public void SetEmail(string email)
        {

        }


    }


    public interface IDbContext
    {
        void WritePerson(IPerson person);
    }





    public class PersonManager
    {

        private IDbContext _context;

        public PersonManager(IDbContext context)
        {
            
        }


        public IPerson CreateTeacher()
        {
            Teacher teacher = new Teacher("Juan Martínez", "C/Buen día 24", "711616252");

            return teacher;
        }


    }



    /// <summary>
    /// Student class
    /// </summary>
    public class Student : Person
    {

        private string _Department;



        public string Department
        {
            get { return _Department; }
            set { _Department = value; }
        }


        public string Name { get; set; }


        /// <summary>
        /// Student says hello and send an email
        /// </summary>
        public void SayHello(string name, string lastName)
        {

        }



        public void SayHello(string name, string lastName, string address)
        {

        }



    }
}
