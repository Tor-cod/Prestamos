using Microsoft.EntityFrameworkCore;

namespace Prestamos.Backend.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<DatoPersonal> DatoPersonals { get; set; }
        public DbSet<DatoFiscal> DatoFiscals { get; set; }
        public DbSet<RepresentanteLegal> RepresentanteLegals { get; set; }
    }
}
