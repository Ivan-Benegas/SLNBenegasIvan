using Microsoft.EntityFrameworkCore;
using SistemaWebMisRecetas.Models;

namespace SistemaWebMisRecetas.Data
{
    public class DBRecetaContext : DbContext
    {
        public DBRecetaContext(DbContextOptions<DBRecetaContext> options) : base(options) { }

        public DbSet<Receta> Recetas { get; set; }

    }
}
