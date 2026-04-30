using System.ComponentModel.DataAnnotations;

namespace CrudContactosMVC.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El Formato de correo electrónico no es válido.")]
        [StringLength(100)]
        public string Correo { get; set; }


        [Required(ErrorMessage = "El teléfono es obligatorio.")]
        [Phone(ErrorMessage = "El número de teléfono no es válido.")]
        [StringLength(20)]
        public string Telefono { get; set; }


        [StringLength(200, ErrorMessage = "La dirección no puede tener más de 200 caracteres.")]
        public string Direccion { get; set; }
    }
}
