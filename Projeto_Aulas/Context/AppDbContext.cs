using Microsoft.EntityFrameworkCore;
using App.Models;

namespace App.Context
{
    public class AppDbContext : DbContext{
        public AppDbContext (DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Continente> Continentes { get; set;}
        public DbSet<Usuario> Usuarios { get; set;}
        public DbSet<Banner> Banners { get; set;}
        public DbSet<Cliente> Clientes { get; set; }        
    }
}