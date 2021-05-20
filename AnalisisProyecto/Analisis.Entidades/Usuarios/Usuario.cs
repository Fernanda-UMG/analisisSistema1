using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Usuarios
{
    public class Usuario
    {
        public int idUsuario { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "El nombre de usuario debe de contener mínimo 8 y un máximo de 100 carácteres")]
        public string nombre { get; set; }

        public string apellido { get; set; }

        public int tipoDocumento { get; set; }

        public int numDocumento { get; set; }

        [Required]
        [StringLength (20, MinimumLength = 5, ErrorMessage = "Debe de ingresar por lo menos 5 carácteres")]
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
        public string telenono { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Debe de ingresar por lo menos 5 carácteres")]

        [DataType(DataType.EmailAddress)]
        [RegularExpression("")]

        public string email { get; set; }

        public string passwordHash { get; set; }

        public string passwordSalt { get; set; }
    }

}
