using Analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Usuarios
{
    public class RolMappin : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.ToTable("tbl_Rol")
              .HasKey(R => R.idRol);
            builder.Property(R => R.nombre)
                .HasMaxLength(30);
            builder.Property(R => R.descripcionRol)
                .HasMaxLength(100);
        }
    }
}
