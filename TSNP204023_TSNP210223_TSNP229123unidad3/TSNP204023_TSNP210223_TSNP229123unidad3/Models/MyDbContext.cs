using Microsoft.EntityFrameworkCore;
using TSNP204023_TSNP210223_TSNP229123unidad3.Models;
namespace TSNP204023_TSNP210223_TSNP229123UNIDAD3.Models
{
    public class MyDbContext : DbContext{
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<Peliculas> peliculas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Peliculas>().HasKey(c => c.IdPelicula);
        }




    }
}
