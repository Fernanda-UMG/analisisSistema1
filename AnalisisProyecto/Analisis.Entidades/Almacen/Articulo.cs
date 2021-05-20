using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
    public class Articulo
    {
        public int idArticulo { get; set; }

        public string codigoArticulo { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "El nombre del articulo debe contener por lo menos 5 caracteres")]
        public string nombreArticulo { get; set; }

        public decimal precioVenta { get; set; }

        public int stock { get; set; }

        [StringLength(256)]
        public string descripcion { get; set; }
    }
}
