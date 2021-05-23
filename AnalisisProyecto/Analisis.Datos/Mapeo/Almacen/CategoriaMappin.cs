using Analisis.Entidades.Almacen;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Almacen
{
    public class CategoriaMappin : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("tbl_categoria")
                .HasKey(cat => cat.idCategoria);
            builder.Property(cat => cat.nombre)
                .HasMaxLength(50);
            builder.Property(cat => cat.descripcion)
                .HasMaxLength(256);
        }
    }
}
