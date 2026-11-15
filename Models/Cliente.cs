using System.ComponentModel.DataAnnotations;

namespace tarea_semana_3.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "El nombre y el apellido deben tener máximo 100 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es requerido")]
        [StringLength(100, ErrorMessage = "El nombre y el apellido deben tener máximo 100 caracteres")]
        public string Apellido { get; set; }

        [Display(Name = "Cédula")]
        [Required(ErrorMessage = "La cédula es requerida")]
        [StringLength(10, ErrorMessage = "La cédula debe tener 10 números")]
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "La cédula debe tener 10 números")]
        public string Cedula { get; set; }

        [Required(ErrorMessage = "El correo es requerido")]
        [StringLength(150, ErrorMessage = "El correo no es válido")]
        [EmailAddress(ErrorMessage = "El correo no es válido")]
        public string Correo { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El teléfono es requerido")]
        [StringLength(10, ErrorMessage = "El teléfono debe tener entre 7 y 10 números")]
        [RegularExpression("^[0-9]{7,10}$", ErrorMessage = "El teléfono debe tener entre 7 y 10 números")]
        public string Telefono { get; set; }
    }
}
