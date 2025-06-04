using Microsoft.EntityFrameworkCore;
using ReceitaFederalImport.Models;

namespace ReceitaFederalImport.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Socio> Socios { get; set; }
    }
}
