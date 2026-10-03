
using Microsoft.EntityFrameworkCore;
using SistemaLogistica.Infraesctrutura.Models;


namespace SistemaLogistica.Infraesctrutura.Data
{
    public class InventarioDbContext : DbContext
    {
        public InventarioDbContext(DbContextOptions<InventarioDbContext> options) : base(options)
        {
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Movimiento> Movimientos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>()
               .ToTable("Productos");

            modelBuilder.Entity<Movimiento>()
                .ToTable("Movimientos");

            modelBuilder.Entity<Movimiento>()
                .HasOne(m => m.Producto)
                .WithMany()
                .HasForeignKey(m => m.ProductoId);
        }
    }
}
