using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Almacen
{
    public class Ingreso
    {

        public int idIngreso { get; set; }
        
        public int idProveedor { get; set; }
        
        public int idUsuario { get; set; }

        public int idEstado { get; set; }

        public string tipoComprobante{ get; set; }
        
        public string serieComprobante { get; set; }
        
        public string numComprobante { get; set; }
       
        [Required]
        public DateTime fechaHora { get; set; }
        
        public decimal impuesto { get; set; }
        
        public decimal totalIngreso { get; set; }

    }
}
