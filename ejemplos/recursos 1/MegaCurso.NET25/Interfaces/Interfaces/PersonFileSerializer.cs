using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class PersonFileSerializer : IPersonSerializer
    {
        private FileStream fs;
        private StreamWriter sw;

        public PersonFileSerializer()
        {
            fs = new FileStream("test.txt", FileMode.Create);
            sw = new StreamWriter(fs);

        }

        public void WritePersons(List<IPersonWithAddress> persons)
        {
            foreach (IPersonWithAddress person in persons)
            {
                sw.WriteLine(person.Name + "*" + person.Address);
            }
        }


        //public void WritePersons(List<IPersonWithAddress> persons)
        //{
        //
        //    using (FileStream fs = new FileStream("test.txt", FileMode.Create))
        //    {
        //        using (StreamWriter sw = new StreamWriter(fs))
        //        {
        //            foreach (IPersonWithAddress person in persons)
        //            {
        //                sw.WriteLine(person.Name + "*" + person.Address);
        //            }
        //        }
        //    }
        //}


        public void Dispose()
        {
            if(sw != null)
            {
                sw.Dispose();
                sw = null;
            }

            if(fs != null)
            {
                fs.Dispose();
                fs = null;
            }
        }


    }
}
