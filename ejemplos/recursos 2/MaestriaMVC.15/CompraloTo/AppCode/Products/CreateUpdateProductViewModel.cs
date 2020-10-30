using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompraloTo.ViewModels
{
    public class CreateUpdateProductViewModel
    {
        public ProductDTO product { get; set; }
        public string fileServer { get; set; }
        public string errorMessage { get; set; }

        public IEnumerable<SelectListItem> categories { get; set; }
    }
}