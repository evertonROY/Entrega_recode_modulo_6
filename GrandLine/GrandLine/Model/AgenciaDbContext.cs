using Microsoft.EntityFrameworkCore;

namespace Agencia_viajar.Model
{
    public class AgenciaDbContext : DbContext
    {

        public AgenciaDbContext(DbContextOptions<AgenciaDbContext> options)
         : base(options)
        { }

        public DbSet<Passagem> Passagens { get; set; }

        public DbSet<Passageiro> Passageiros { get; set; }
    }
}
