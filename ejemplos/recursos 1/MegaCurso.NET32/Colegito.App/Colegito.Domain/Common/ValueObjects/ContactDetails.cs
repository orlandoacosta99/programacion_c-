using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    public class ContactDetails
    {
        public string Phone { get; protected set; }
        public string Email { get; protected set; }

        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected ContactDetails() { }


        /// <summary>
        /// Static factory constructor
        /// </summary>
        public static ContactDetails CreateNew(string phone, string email)
        {

            return new ContactDetails()
            {
                Phone = phone ?? "",
                Email = email ?? "",
            };
        }



    }
}
