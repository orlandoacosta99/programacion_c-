using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PersonManager
    {
        private List<IPersonWithAddress> persons = new List<IPersonWithAddress>();


        public void AddPerson(IPersonWithAddress person)
        {
            persons.Add(person);
        }


        public IPersonWithAddress GetPersonByName(string name)
        {
            return persons.Where(p => p.Name.Contains(name)).FirstOrDefault();
        }


        public void Serialize(IPersonSerializer serializer)
        {
            serializer.WritePersons(persons);
        }


    }
}
