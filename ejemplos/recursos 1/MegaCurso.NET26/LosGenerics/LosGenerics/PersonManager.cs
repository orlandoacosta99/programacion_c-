using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosGenerics
{
    public class PersonManager<T> where T:Person
    {

        private List<T> persons;


        public PersonManager()
        {
            this.persons = new List<T>();
        }


        public T CreateNew(string number)
        {
            return Activator.CreateInstance(typeof(T), number) as T;
        }


    }
}
