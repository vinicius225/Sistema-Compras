using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Sistema.Compras.Repository; // Suponho que a classe Usuario esteja neste namespace

namespace Sistema.Compras.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions optionsBuilder) :base(optionsBuilder)
        {
            
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Perfil> Perfis { get; set; } // Adicionei esta linha assumindo que você tem uma classe Perfil

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>()
                .HasOne(u => u.Perfil)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(u => u.IdPerfil);
        }
    }
}
