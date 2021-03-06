using Analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Ventas
{
    public class DetalleVentaMappin : IEntityTypeConfiguration<DetalleVenta>
    {
        public void Configure(EntityTypeBuilder<DetalleVenta> builder)
        {

            builder.ToTable("tbl_DetalleVenta")
                .HasKey(DV => DV.idDetalleVenta);
            builder.Property(DV => DV.cantidad)
                .IsRequired();
            builder.Property(DV => DV.PrecioVenta)
                .IsRequired();
            builder.Property(DV => DV.descuento)
                .IsRequired();

        }
    }
}
