﻿using Analisis.Entidades.Condicion;
using Analisis.Entidades.Usuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Ventas
{
    public class Venta
    {

        public int idVenta { get; set; }

        public string tipoComprobante { get; set; }

        public string serieComprobante { get; set; }

        public string numComprobante { get; set; }

        [Required]
        public DateTime fechaHora { get; set; }

        public decimal impuesto { get; set; }

        public decimal total { get; set; }

        public List<Persona> personas { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public List<estados> estados { get; set; }
    }
}
