using Analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Usuarios
{
    public class TipoPersonaMappin : IEntityTypeConfiguration<TipoPersona>
    {
        public void Configure(EntityTypeBuilder<TipoPersona> builder)
        {
            builder.ToTable("tbl_TipoPersona")
              .HasKey(TP => TP.idTipoPersona);
            builder.Property(TP => TP.descripcion)
                .HasMaxLength(50);
        }
    }
}
