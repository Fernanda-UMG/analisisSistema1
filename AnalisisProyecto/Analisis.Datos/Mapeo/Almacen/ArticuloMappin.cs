using Analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Almacen
{
    public class ArticuloMappin : IEntityTypeConfiguration<Articulo>
    {
        public void Configure(EntityTypeBuilder<Articulo> builder)
        {
            builder.ToTable("tbl_articulo")
               .HasKey(A => A.idArticulo);
            builder.Property(A => A.codigoArticulo)
                .HasMaxLength(50);
            builder.Property(A => A.nombreArticulo)
                .HasMaxLength(100);
            builder.Property(A => A.precioVenta)
                .IsRequired();
            builder.Property(A => A.stock)
                .IsRequired();
            builder.Property(A => A.descripcion)
                .HasMaxLength(256);
        }
    }
}
