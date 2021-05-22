using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Usuarios
{
   public class Rol
    {

        public int idRol { get; set; }

        public int idCondicion { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "El nombre del rol debe de tener como mìnimo 5 caracteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "La descripción debe de tener como mìnimo 5 caracteres")]
        public string descripcionRol { get; set; }
}
}
