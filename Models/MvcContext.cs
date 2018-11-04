using Microsoft.EntityFrameworkCore;

namespace SICORA.Models
{
    public class MvcContext : DbContext
    {
        public MvcContext (DbContextOptions<MvcContext> options)
            : base(options)
        {
        }

        public DbSet<SICORA.Models.Prueba_bd> Prueba_bd { get; set; }
        public DbSet<SICORA.Models.Juegos> Juegos { get; set; }
        public DbSet<SICORA.Models.Perifericos> Perifericos { get; set; }
        public DbSet<SICORA.Models.Programas> Programas { get; set; }
    }
}