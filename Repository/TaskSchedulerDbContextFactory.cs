using ArcsimPlatform.Repository;
using Microsoft.EntityFrameworkCore;
using ArcsimPlatform.Repository.Infrastructure;

namespace Repository
{
    public class TaskSchedulerDbContextFactory : DesignTimeDbContextFactoryBase<TaskSchedulerDbContext>
    {
        protected override TaskSchedulerDbContext CreateNewInstance(DbContextOptions<TaskSchedulerDbContext> options)
        {
            return new TaskSchedulerDbContext(options);
        }
    }
}
