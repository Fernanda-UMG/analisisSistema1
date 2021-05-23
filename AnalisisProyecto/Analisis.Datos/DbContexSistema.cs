using Analisis.Datos.Mapeo.Almacen;
using Analisis.Datos.Mapeo.Condicion;
using Analisis.Datos.Mapeo.Usuarios;
using Analisis.Datos.Mapeo.Ventas;
using Analisis.Entidades.Condicion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos
{
    public class DbContexSistema : DbContext
    
    {

        public DbContexSistema(DbContextOptions<DbContexSistema>options) : base(options)
        {

        }

        protected   override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMappin());
            modelBuilder.ApplyConfiguration(new ArticuloMappin());
            modelBuilder.ApplyConfiguration(new DetalleInngresoMappin());
            modelBuilder.ApplyConfiguration(new IngresoMappin());
            modelBuilder.ApplyConfiguration(new condicionMappin());
            modelBuilder.ApplyConfiguration(new estadoMappin());
            modelBuilder.ApplyConfiguration(new PersonaMappin());
            modelBuilder.ApplyConfiguration(new RolMappin());
            modelBuilder.ApplyConfiguration(new TipoPersonaMappin());
            modelBuilder.ApplyConfiguration(new UsuarioMappin());
            modelBuilder.ApplyConfiguration(new DetalleVentaMappin());
            modelBuilder.ApplyConfiguration(new VentaMappin());


        }

       
    }
}
