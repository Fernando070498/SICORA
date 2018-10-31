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
    }
}