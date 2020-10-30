using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainTest
{
    public class Customer
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }

        public DateTime CreateDate { get; private set; }

        public string FullName
        {
            get
            {
                return Name + " " + LastName;
            }
        }



        public Customer(string name, string lastName, string phone)
        {
            if (string.IsNullOrEmpty(name))
                throw new InvalidOperationException("Name is required");

            if (string.IsNullOrEmpty(lastName))
                throw new InvalidOperationException("Lastname is required");

            this.Name = name;
            this.LastName = lastName;

            this.CreateDate = DateTime.Now;

        }


        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

    }
}
