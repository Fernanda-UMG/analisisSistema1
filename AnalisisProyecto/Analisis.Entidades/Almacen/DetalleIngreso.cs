using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
    public class DetalleIngreso
    {

        public int idDetalleIngreso { get; set; }
        
        public int idIngreso { get; set; }
        
        public int idArticulo { get; set; }
      
        [Required (ErrorMessage = "Únicamente números")]
        public int cantidad { get; set; }
       
        public decimal Precio { get; set; }

    }
}
