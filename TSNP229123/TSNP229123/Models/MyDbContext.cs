using Microsoft.EntityFrameworkCore;
namespace TSNP229123.Models
{
    public class MyDbContext : DbContext
    {
        public  MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { }
        public DbSet<PELICULAS> PELICULAS { get; set; }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PELICULAS>().HasKey(c => c.IdPeliculas);
        }
    }
}
