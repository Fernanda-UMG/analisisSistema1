using Analisis.Entidades.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos.Mapeo.Usuarios
{
    public class PersonaMappin : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("tbl_Persona")
               .HasKey(P => P.idPersona);
            builder.Property(P => P.nombre)
                .HasMaxLength(100);
            builder.Property(P => P.apellido)
                .HasMaxLength(100);
            builder.Property(P => P.tipoDocumento)
                .HasMaxLength(20);
            builder.Property(P => P.numDocumento)
                .HasMaxLength(20);
            builder.Property(P => P.calle)
                .HasMaxLength(20);
            builder.Property(P => P.avenida)
                .HasMaxLength(30);
            builder.Property(P => P.zona)
                .IsRequired();
            builder.Property(P => P.colonia)
                .HasMaxLength(30);
            builder.Property(P => P.telefono)
                .HasMaxLength(11);
            builder.Property(P => P.email)
                .HasMaxLength(50);
        }
    }
}
