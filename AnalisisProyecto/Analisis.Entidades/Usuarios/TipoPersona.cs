using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Usuarios
{
    public class TipoPersona
    {
        public int idTipoPersona { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "La descripcion debe de contener mínimo 5 y un máximo de 50 carácteres")]
        public string descripcion { get; set; }

    }
}
