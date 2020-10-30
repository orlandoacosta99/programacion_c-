using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosGenerics
{
    public class CustomerManager<TKey, TValue>
    {

        private List<TKey> listOfKeys;
        private List<TValue> listOfValues;


        public CustomerManager()
        {
            listOfKeys = new List<TKey>();
            listOfValues = new List<TValue>();
        }

    }
}
