using Microsoft.EntityFrameworkCore;

namespace davesPub.Models
{
    public class ApplicationContext:DbContext
    {
        public DbSet<mainPageItem> MainPageItems { get; set; }
        public DbSet<strongAlchogol> StrongAlchogols { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {
            Database.EnsureCreated();
        }

    }
}
 