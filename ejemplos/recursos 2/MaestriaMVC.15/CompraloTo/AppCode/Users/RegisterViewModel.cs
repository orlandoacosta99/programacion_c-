using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;


namespace CompraloTo.ViewModels
{
    public class RegisterViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email es requerido")]
        [System.Web.Mvc.Remote("CheckUserNameExists", ErrorMessage = "Ya existe un usuario con ese email")]
        [Display(Name = "Nombre de usuario/Email")]
        [EmailAddress(ErrorMessage = "Email no válido")]
        public string email { get; set; }

        [Required(AllowEmptyStrings =false, ErrorMessage = "Password es requerido")]
        [Display(Name = "Password")]
        public string password { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Password de confirmación es requerido")]
        [Display(Name = "Confirme password")]
        [Compare("password", ErrorMessage = "Los passwords no coinciden")]
        public string confirm { get; set; }




        public string errorMessage { get; set; }
    }
}