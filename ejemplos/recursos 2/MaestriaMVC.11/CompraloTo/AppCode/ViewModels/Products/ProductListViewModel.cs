using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompraloTo.ViewModels
{
    public class ProductListViewModel
    {

        public List<ProductListDTO> Products { get; set; }
        public string sortField { get; set; }
        public string sortDir { get; set; }

        public string searchText { get; set; }

    }
}