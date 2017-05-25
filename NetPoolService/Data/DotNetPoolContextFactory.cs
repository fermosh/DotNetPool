using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;
namespace NetPoolService.Data
{
    public class DotNetPoolContextFactory  :IDbContextFactory<DotNetPoolContext>
    {
        public DotNetPoolContext Create(DbContextFactoryOptions options){
            return Create();
        }
        public DotNetPoolContext Create()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DotNetPoolContext>();
            optionsBuilder.UseSqlServer("Server=tcp:dotnetpool.database.windows.net,1433;Initial Catalog=DotNetPool;Persist Security Info=False;User ID=lego;Password=F3rn4nd0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new DotNetPoolContext(optionsBuilder.Options);
        }
    }
}