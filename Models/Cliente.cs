using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Display(Name = "Fecha de nacimiento")]
        [Required(ErrorMessage = "La fecha de nacimiento es requerida")]
        [DataType(DataType.Date)]
        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Display(Name = "Género")]
        [Required(ErrorMessage = "El género es requerido")]
        [StringLength(20, ErrorMessage = "Seleccione un género válido")]
        [RegularExpression("^(Masculino|Femenino|Otro)$", ErrorMessage = "Seleccione un género válido")]
        public string Genero { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "La dirección es requerida")]
        [StringLength(200, MinimumLength = 5, ErrorMessage = "La dirección debe tener entre 5 y 200 caracteres")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "La ciudad es requerida")]
        [StringLength(50, ErrorMessage = "La ciudad debe tener máximo 50 caracteres")]
        [RegularExpression("^[a-zA-ZáéíóúÁÉÍÓÚñÑ ]+$", ErrorMessage = "La ciudad solo puede tener letras")]
        public string Ciudad { get; set; }

        [Display(Name = "Límite de crédito")]
        [Required(ErrorMessage = "El límite de crédito es requerido")]
        [Range(0, 10000, ErrorMessage = "El límite de crédito debe estar entre 0 y 10000")]
        public int LimiteCredito { get; set; }
    }
}
