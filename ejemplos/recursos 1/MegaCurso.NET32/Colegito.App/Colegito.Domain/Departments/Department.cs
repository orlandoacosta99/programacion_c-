using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegito.Domain
{

    public class Department : AggregateRoot
    {
        public string Name { get; protected set; }

        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected Department() { }

    }
}
