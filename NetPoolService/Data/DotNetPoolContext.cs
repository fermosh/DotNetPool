using NetPoolService.Models.Data;
using Microsoft.EntityFrameworkCore;

namespace NetPoolService.Data
{
    public class DotNetPoolContext : DbContext
    {
        public DotNetPoolContext(DbContextOptions<DotNetPoolContext> options) : base(options)
        {
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Update> Updates { get; set; }
 
    }
}