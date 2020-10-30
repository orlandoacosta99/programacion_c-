using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InyeccionDependencia.Domain
{

    public class Department : Aggregate
    {
        public string Name { get; protected set; }

        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected Department() { }

    }
}
