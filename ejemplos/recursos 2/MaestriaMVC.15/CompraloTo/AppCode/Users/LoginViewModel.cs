using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CompraloTo.ViewModels
{
    public sealed class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email es requerido")]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Email no válido")]
        public string email { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Password es requerido")]
        [Display(Name = "Password")]
        public string password { get; set; }


        [Display(Name = "Recordame")]
        public bool persist { get; set; }


        public string errorMessage { get; set; }
        public bool showCaptcha { get; set; }

    }
}