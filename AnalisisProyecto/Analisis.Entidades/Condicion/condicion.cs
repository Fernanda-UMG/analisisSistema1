using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Condicion
{
   public class condicion
    {

        public int idCondicion { get; set; }
        public int idUsuario { get; set; }
        public int idRol { get; set; }
        public int idCategoria { get; set; }
        public int idArticulo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Maximo 100 caràcteres")]
        public string descricion { get; set; }
    }
}
