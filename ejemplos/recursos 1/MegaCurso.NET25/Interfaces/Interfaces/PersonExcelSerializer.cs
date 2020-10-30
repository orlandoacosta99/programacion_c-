using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;


namespace Interfaces
{
    public class PersonExcelSerializer : IPersonSerializer
    {
        private FileStream fs;
        private StreamWriter sw;

        public PersonExcelSerializer()
        {
            fs = new FileStream("test.xls", FileMode.Create);
            sw = new StreamWriter(fs);

        }


        public void WritePersons(List<IPersonWithAddress> persons)
        {
            foreach (IPersonWithAddress person in persons)
            {
                sw.WriteLine(person.Name + ";" + person.Address + ";" + person.PostalCode);
            }
                        
        }



        public void Dispose()
        {
            if (sw != null)
            {
                sw.Dispose();
                sw = null;
            }

            if (fs != null)
            {
                fs.Dispose();
                fs = null;
            }
        }


    }
}
