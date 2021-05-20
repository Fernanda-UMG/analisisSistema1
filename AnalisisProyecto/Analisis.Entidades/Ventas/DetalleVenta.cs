using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Ventas
{
    public class DetalleVenta
    {
        public int idDetalleVenta { get; set; }

        public int idVenta { get; set; }

        public int idArticulo { get; set; }

        [Required (ErrorMessage = "Unicamente digitos enteros")]
        public int cantidad { get; set; }

        public decimal PrecioVenta { get; set; }

        public decimal descuento { get; set; }
    }
}
