using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Condicion
{
    public class estados
    {
        public int idEstado { get; set; }
        public int idVenta { get; set; }
        public int idIngreso { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Maximo 50 caràcteres")]
        public string descripcion { get; set; }

    }
}
