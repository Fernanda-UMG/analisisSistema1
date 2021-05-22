using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
    public class Categoria
    {
        public int idCategoria { get; set; }

        public int idCondicion { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Maximo 50 caràcteres")]
        public string nombre { get; set; }
        
        [StringLength(256)]
        public string descripcion { get; set; }
    }
}
