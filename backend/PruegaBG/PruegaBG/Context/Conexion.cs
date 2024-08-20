using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PruegaBG.Models;
namespace PruegaBG.Context
{
    public class Conexion: IdentityDbContext
    {
        public Conexion(DbContextOptions<Conexion> options) : base(options)
        {

        }
        public DbSet<PruegaBG.Models.Persona> Persona { get; set; } = default!;
        public DbSet<PruegaBG.Models.Mascota> Mascota { get; set; } = default!;
    }
}
