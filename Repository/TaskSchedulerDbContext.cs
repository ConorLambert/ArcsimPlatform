using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;
using ArcsimPlatform.Repository.Configurations.TaskScheduler;
using Microsoft.EntityFrameworkCore;

namespace ArcsimPlatform.Repository
{
    public class TaskSchedulerDbContext : DbContext 
    {
        // CONFIG
        public DbSet<Product> Product {get; set;}
        public DbSet<Source> Source {get; set;}
        public DbSet<Currency> Currency {get; set;}
        public DbSet<RunType> RunType {get; set;}
        public DbSet<User> User { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        public TaskSchedulerDbContext(DbContextOptions<TaskSchedulerDbContext> options) : base(options) {}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.ApplyAllConfigurations(typeof(TaskSchedulerDbContext));
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CONFIG
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
        }
    }
}