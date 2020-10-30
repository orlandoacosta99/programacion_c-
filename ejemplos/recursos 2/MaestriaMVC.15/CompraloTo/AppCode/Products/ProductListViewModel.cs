using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace CompraloTo.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<SelectListItem> categories { get; set; }
        public List<ProductListDTO> products { get; set; }

        [Display(Name = "Categoría")]
        public int categoryID { get; set; }

        public string sortField { get; set; }
        public string sortDir { get; set; }
        public string searchText { get; set; }

    }
}