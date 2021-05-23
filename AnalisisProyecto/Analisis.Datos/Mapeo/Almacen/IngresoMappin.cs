using Analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Almacen
{
    public class IngresoMappin : IEntityTypeConfiguration<Ingreso>
    {
        public void Configure(EntityTypeBuilder<Ingreso> builder)
        {
            builder.ToTable("tbl_Ingreso")
                .HasKey(I => I.idIngreso);
            builder.Property(I => I.tipoComprobante)
                .HasMaxLength(20);
            builder.Property(I => I.serieComprobante)
                .HasMaxLength(7);
            builder.Property(I => I.numComprobante)
                .HasMaxLength(10);
            builder.Property(I => I.fechaHora)
              .IsRequired();
            builder.Property(I => I.impuesto)
              .IsRequired();
            builder.Property(I => I.totalIngreso)
              .IsRequired();
        }
    }
}
