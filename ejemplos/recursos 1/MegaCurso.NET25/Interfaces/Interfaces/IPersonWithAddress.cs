using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IPersonWithAddress : IPerson
    {
        string Address { get; set; }
        string PostalCode { get; set; }
    }
}
