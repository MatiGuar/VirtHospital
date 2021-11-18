using Microsoft.EntityFrameworkCore;
using VirtualHosp.Clases;
using VirtualHosp.Enums;
using VirtualHosp.Models;

namespace VirtualHosp.Context
{
    public class HospitalDbContext : DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
            .Entity<Usuario>()
            .Property(e => e.TipoDocumento)
            .HasConversion<int>();
        }
        //entities
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }

    }
}
