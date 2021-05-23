using Analisis.Entidades.Condicion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Condicion
{
    public class estadoMappin : IEntityTypeConfiguration<estados>
    {
        public void Configure(EntityTypeBuilder<estados> builder)
        {
            builder.ToTable("tbl_estado")
               .HasKey(E => E.idEstado);
            builder.Property(E => E.descripcion)
                .HasMaxLength(50);
        }
    }
}
