using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.Domain
{
    public class Aggregate
    {
        /// <summary>
        /// The unique identifier for the aggregate
        /// </summary>
        public int ID { get; protected set; }

        /// <summary>
        /// Constructor for EF
        /// </summary>
        protected Aggregate() { }
    }
}