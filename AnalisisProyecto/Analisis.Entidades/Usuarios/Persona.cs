using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Usuarios
{
    public class Persona
    {

        public int idPersona { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "El nombre debe de contener mínimo 8 y un máximo de 100 carácteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El nombre debe de contener mínimo 3 y un máximo de 100 carácteres")]
        public string apellido { get; set; }

        public int tipoDocumento { get; set; }

        public int numDocumento { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Debe de ingresar por lo menos 5 carácteres")]
        public string calle { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Debe de ingresar por lo menos 5 carácteres")]
        public string avenida { get; set; }

        public int zona { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Debe de ingresar por lo menos 5 carácteres")]
        public string colonia { get; set; }
       
        [Required]
        [StringLength(11, ErrorMessage = "Telefono debe de tener 11 dígitos")]
        public string telefono { get; set; }

        [Required(ErrorMessage = "Email es obligatorio")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(50)]
        [RegularExpression(@"[a-z0-9._-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Email no valido")]
        public string email { get; set; }

        public List<TipoPersona> TipoPersonas { get; set; }
    }
}
