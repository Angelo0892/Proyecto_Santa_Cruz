using ACTIVOS_FIJOS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace ACTIVOS_FIJOS.Data
{ 
    /*
    public class ActivosFijosContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Unidad> Unidades { get; set; }
        public DbSet<NombreActivo> NombreActivos { get; set; }
        public DbSet<CategoriaNombreActivo> CategoriaNombreActivos { get; set; }
        public DbSet<ActivoFijo> ActivosFijos { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Personal> Personales { get; set; }
        public DbSet<Asignacion> Asignaciones { get; set; }
        public DbSet<Retorno> Retornos { get; set; }
        public DbSet<Depreciacion> Depreciaciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CategoriaNombreActivo>()
                .HasKey(cna => new { cna.CategoriaID, cna.NombreActivoID });

            modelBuilder.Entity<CategoriaNombreActivo>()
                .HasOne(cna => cna.Categoria)
                .WithMany(c => c.CategoriaNombreActivos)
                .HasForeignKey(cna => cna.CategoriaID);

            modelBuilder.Entity<CategoriaNombreActivo>()
                .HasOne(cna => cna.NombreActivo)
                .WithMany(na => na.CategoriaNombreActivos)
                .HasForeignKey(cna => cna.NombreActivoID);
        }
    }*/
}
