using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SimuladorSEJU.Models.Entities;

namespace SimuladorSEJU.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Causa> Causas { get; set; }
        public DbSet<TipoCausa> TiposCausa { get; set; }
        public DbSet<EstadoCausa> EstadosCausa { get; set; }
        public DbSet<Juzgado> Juzgados { get; set; }
        public DbSet<Publicacion> Publicaciones { get; set; }
        public DbSet<Notificacion> Notificaciones { get; set; }
        public DbSet<Evento> Eventos { get; set; }
    }
}
