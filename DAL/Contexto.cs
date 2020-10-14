using Microsoft.EntityFrameworkCore;
using RegistroDetalle_AP1.Entidades;

namespace RegistroDetalle_AP1.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Articulos> Articulos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlite(@"Data Source=DATA\RegistroDetalle.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Articulos>().HasData(new Articulos() { ArticuloId = 1, Descripcion = "Libra Arroz", Precio = 50 });

            modelBuilder.Entity<Articulos>().HasData(new Articulos() { ArticuloId = 2, Descripcion = "Jabón", Precio = 170 });

            modelBuilder.Entity<Articulos>().HasData(new Articulos() { ArticuloId = 3, Descripcion = "Salami", Precio = 100 });

        }

    }
}