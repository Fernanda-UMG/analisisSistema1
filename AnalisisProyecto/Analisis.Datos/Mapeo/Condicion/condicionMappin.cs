using Analisis.Entidades.Condicion;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Condicion
{
    public class condicionMappin : IEntityTypeConfiguration<condicion>
    {
        public void Configure(EntityTypeBuilder<condicion> builder)
        {
            builder.ToTable("tbl_condicion")
               .HasKey(C => C.idCondicion;
            builder.Property(C => C.descripcion)
                .HasMaxLength(100);
        }
    }
}
