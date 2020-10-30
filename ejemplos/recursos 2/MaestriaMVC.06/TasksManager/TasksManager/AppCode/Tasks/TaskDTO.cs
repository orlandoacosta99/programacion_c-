using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TasksManager
{
    public class TaskDTO
    {
        public int ID { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "Nombre es requerido")]
        [StringLength(100, ErrorMessage = "La longitud máxima es 100")]
        [System.Web.Mvc.Remote("CheckTaskNameExists", "Tasks", ErrorMessage = "Ya existe una tarea con ese nombre")]
        public string Name { get; set; }


        public DateTime CreateDate { get; set; }


        [Required(ErrorMessage = "La fecha de vencimiento es requerida")]
        public DateTime DueDate { get; set; }

    }


    public class TaskDeleteDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime DueDate { get; set; }


        [Compare("ID", ErrorMessage = "El ID de la tarea no coincide")]
        [Display(Name="Escriba el ID de la tarea para confirmar la eliminación")]
        public int ConfirmID { get; set; }

    }
}