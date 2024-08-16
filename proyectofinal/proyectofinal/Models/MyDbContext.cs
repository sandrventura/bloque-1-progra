using Microsoft.EntityFrameworkCore;

namespace proyectofinal.Models
{
    public class MyDbContext : DbContext  {
        public MyDbContext() { }
        public MyDbContext(DbContextOptions<MyDbContext> options) : base (options) { }

        public DbSet<Peliculas> Peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Peliculas>().HasKey(c => c.IdPelicula);
        }
    } }
