using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{
    /// <summary>
    /// Command for create a new teacher in the system
    /// </summary>
    public class CreateTeacherCommand : IMessage
    {
        public string Name { get; protected set; }
        public string LastName { get; protected set; }

        //address
        public string PostalAddress { get; protected set; }
        public string City { get; protected set; }
        public string State { get; protected set; }
        public string PostalCode { get; protected set; }

        public string Phone { get; protected set; }
        public string Email { get; protected set; }

        public int DepartmentID { get; protected set; }

    }


}
