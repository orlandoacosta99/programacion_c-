using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.Domain
{
    /// <summary>
    /// We use this class to describe a product that can be sold in the system
    /// </summary>
    public class Product : Aggregate
    {
        public ProductCategory category { get; set; }

        public DateTime createDate { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public bool highlighted { get; set; }
    }
}