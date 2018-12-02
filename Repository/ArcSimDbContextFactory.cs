using ArcsimPlatform.Repository;
using Microsoft.EntityFrameworkCore;
using ArcsimPlatform.Repository.Infrastructure;

namespace ArcsimPlatform.Repository
{
    public class ArcsimDbContextFactory : DesignTimeDbContextFactoryBase<ArcSimDbContext>
    {
        protected override ArcSimDbContext CreateNewInstance(DbContextOptions<ArcSimDbContext> options)
        {
            return new ArcSimDbContext(options);
        }
    }
}