using Microsoft.EntityFrameworkCore;
using VirtualHosp.Clases;
using VirtualHosp.Enums;

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
    }
}
