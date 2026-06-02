using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCoreSolution.Models
{
    public class Categoria
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(60)]
        [Display(Name = "Nombre de categoria")]
        public string? Nombre { get; set; }


        [Display(Name = "Orden de Visualizacion")]
        [Range(1, 10, ErrorMessage = "El valor debe estar entre 1 - 100")]
        public int Orden { get; set; }
        public DateTime FechaCreacion { get; set; }


    }
}
