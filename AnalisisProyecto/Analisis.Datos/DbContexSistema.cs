using Analisis.Datos.Mapeo.Almacen;
using Analisis.Datos.Mapeo.Condicion;
using Analisis.Datos.Mapeo.Usuarios;
using Analisis.Datos.Mapeo.Ventas;
using Analisis.Entidades.Almacen;
using Analisis.Entidades.Condicion;
using Analisis.Entidades.Usuarios;
using Analisis.Entidades.Ventas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Analisis.Datos
{
    public class DbContexSistema : DbContext
    
    {
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Articulo> Articulo { get; set; }
        public DbSet<DetalleIngreso> DetalleIngreso { get; set; }
        public DbSet<Ingreso> Ingreso { get; set; }
        public DbSet<condicion> Condicion { get; set; }
        public DbSet<estados> estados { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }
        public DbSet<Usuario> usuario { get; set; }
        public DbSet<DetalleVenta> DetalleVenta { get; set; }
        public DbSet<Venta> Venta { get; set; }

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
