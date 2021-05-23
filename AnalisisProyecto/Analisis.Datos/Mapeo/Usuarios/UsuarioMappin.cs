using Analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Usuarios
{
    public class UsuarioMappin : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("tbl_usuario")
               .HasKey(U => U.idUsuario);
            builder.Property(U => U.nombre)
                .HasMaxLength(100);
            builder.Property(U => U.apellido)
                .HasMaxLength(100);
            builder.Property(U => U.tipoDocumento)
                .HasMaxLength(30);
            builder.Property(U => U.numDocumento)
                .IsRequired();
            builder.Property(U => U.calle)
                .HasMaxLength(20);
            builder.Property(U => U.avenida)
                .HasMaxLength(30);
            builder.Property(U => U.zona)
                .IsRequired();
            builder.Property(U => U.colonia)
                .HasMaxLength(30);
            builder.Property(U => U.telefono)
                .HasMaxLength(11);
            builder.Property(U => U.email)
                .HasMaxLength(50);
            builder.Property(U => U.passwordHash)
                .IsRequired();
            builder.Property(U => U.passwordSalt)
                .IsRequired();
        }
    }
}
