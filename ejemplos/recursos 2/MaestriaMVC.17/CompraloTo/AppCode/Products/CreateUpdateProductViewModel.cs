using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CompraloTo.ViewModels
{
    public class CreateUpdateProductViewModel
    {
        [Required]
        public ProductDTO product { get; set; }

        [Required]
        public string fileServer { get; set; }

        public string errorMessage { get; set; }

        public IEnumerable<SelectListItem> categories { get; set; }
    }
}