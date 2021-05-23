﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Analisis.Entidades.Condicion
{
   public class condicion
    {

        public int idCondicion { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "Maximo 100 caràcteres")]
        public string descripcion { get; set; }
    }
}
