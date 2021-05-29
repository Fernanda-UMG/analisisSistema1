using Analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Ventas
{
    public class VentaMappin : IEntityTypeConfiguration<Venta>
    {
        public void Configure(EntityTypeBuilder<Venta> builder)
        {
            builder.ToTable("tbl_Venta")
                .HasKey(V => V.idVenta);
            builder.Property(V => V.tipoComprobante)
                .HasMaxLength(20);
            builder.Property(V => V.serieComprobante)
                .HasMaxLength(7);
            builder.Property(V => V.numComprobante)
                .HasMaxLength(10);
            builder.Property(V => V.fechaHora)
              .IsRequired();
            builder.Property(V => V.impuesto)
              .IsRequired();
            builder.Property(V => V.total)
              .IsRequired();

        }
    }
}
