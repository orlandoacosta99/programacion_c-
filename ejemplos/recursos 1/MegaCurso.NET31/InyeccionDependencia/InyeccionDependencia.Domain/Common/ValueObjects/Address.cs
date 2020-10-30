using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia.Domain
{
    public class Address
    {
        public string PostalAddress { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string PostalCode { get; protected set; }

        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected Address() { }


        /// <summary>
        /// Static factory constructor
        /// </summary>
        public static Address CreateNew(string address, string city, string state, string postalCode)
        {

            return new Address()
            {
                PostalAddress = address ?? "",
                City = city ?? "",
                PostalCode = postalCode ?? "",
                State = state ?? ""
            };
        }



    }
}
