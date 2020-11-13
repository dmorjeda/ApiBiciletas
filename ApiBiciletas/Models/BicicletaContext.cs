using ApiBiciletas.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBiciletas.Models
{
    public class BicicletaContext : DbContext
    {
        public BicicletaContext(DbContextOptions<BicicletaContext> options)
            : base(options)
        {
        }

        public DbSet<Bicicleta> Bicicletas { get; set; }
    }
}