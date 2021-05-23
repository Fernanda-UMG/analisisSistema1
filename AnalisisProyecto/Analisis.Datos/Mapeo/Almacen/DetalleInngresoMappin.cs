using Analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Almacen
{
    public class DetalleInngresoMappin : IEntityTypeConfiguration<DetalleIngreso>
    {
        public void Configure(EntityTypeBuilder<DetalleIngreso> builder)
        {
            builder.ToTable("tbl_DetalleIngreso")
                .HasKey(DI => DI.idDetalleIngreso);
            builder.Property(DI => DI.cantidad)
                .IsRequired();
            builder.Property(DI => DI.Precio)
                .IsRequired();
;        }
    }
}
