﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.ViewModels
{
    public class ProductListDTO
    {
        public int ID { get; set; }
        public string name { get; set; }

        public DateTime createDate { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public bool hightlighted { get; set; }
    }
}