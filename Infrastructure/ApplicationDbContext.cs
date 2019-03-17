using Core;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    class ApplicationDbContext : DbContext
    {
  
        public DbSet<Fund> Funds { get; set; }
        public DbSet<Management> Managements { get; set; }
 

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

    }
}
