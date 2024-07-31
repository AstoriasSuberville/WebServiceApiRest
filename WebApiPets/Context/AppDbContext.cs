using Microsoft.EntityFrameworkCore;
using WebApiPets.Models;

namespace WebApiPets.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Pets> Pets { get; set; }
    }
}
