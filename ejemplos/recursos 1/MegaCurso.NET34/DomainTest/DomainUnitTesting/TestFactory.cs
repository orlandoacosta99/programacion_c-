using DomainTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainUnitTesting
{
    public static class TestFactory
    {
        private static Random random = new Random();


        public static string GetRandomString(int length = 10)
        {
            //return new string('t', length);

            string retValue = Guid.NewGuid().ToString();

            if (retValue.Length > length)
                retValue = retValue.Substring(0, length);

            return retValue;
        }


        public static int GetRandomInt(int minValue = 0, int maxValue = int.MaxValue)
        {
            return random.Next(minValue, maxValue);
        }


        /// <summary>
        /// Factory method to construct a new customer
        /// </summary>
        public static Customer CreateCustomer(string name, string lastName, string phone = "phonetest")
        {
            return new Customer(name, lastName, phone);
        }


    }
}
