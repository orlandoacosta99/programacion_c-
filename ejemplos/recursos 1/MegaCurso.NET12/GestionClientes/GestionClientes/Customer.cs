﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes
{
    public class Customer
    {
        public DateTime CreateDate { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }


        public Customer()
        {
            this.CreateDate = DateTime.Now;
        }

    }
}
