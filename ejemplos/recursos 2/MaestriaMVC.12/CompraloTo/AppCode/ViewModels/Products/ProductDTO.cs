using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;


namespace CompraloTo.ViewModels
{
    public class ProductDTO
    {
        public int ID { get; set;}

        [Display(Name = "Categoría")]
        [Required]
        public int categoryID { get; set; }

        [Display(Name = "Nombre")]
        [Required]
        public string name { get; set; }

        [Display(Name="Fecha de creación")]
        public DateTime createDate { get; set; }

        [Display(Name = "Descripción")]
        [Required]
        public string description { get; set; }

        [Display(Name = "Precio")]
        [Required]
        public decimal price { get; set; }

        [Display(Name = "Destacado")]
        public bool hightlighted { get; set; }
    }
}