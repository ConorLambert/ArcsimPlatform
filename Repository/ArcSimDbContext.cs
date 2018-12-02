using Microsoft.EntityFrameworkCore;
using ArcsimPlatform.ComponentModels.Entities;
using System.Linq;
using ArcsimPlatform.ComponentModels.Entities.ArcSim;
using ArcsimPlatform.Repository.Extensions;
using ArcsimPlatform.Repository.Configurations.ArcSim;

namespace ArcsimPlatform.Repository
{
    public class ArcSimDbContext : DbContext 
    {
        // public ArcSimDbContext(DbContextOptions<ArcSimDbContext> options)
        //     : base(options)
        // {
        // }

        // CONFIG
        public DbSet<ConfigAssumptionsConfigSet> ConfigAssumptionsConfigSet { get; set; }
        public DbSet<ConfigKernelConfig> ConfigKernelConfig {get; set;}
        public DbSet<ConfigCalculationExecution> ConfigCalculationExecution {get; set;}
        public DbSet<ConfigRunDefinition> ConfigRunDefinition {get; set;}
        public DbSet<ConfigEconomic> ConfigEconomic {get; set;}
        public DbSet<ConfigExpenses> ConfigExpenses {get; set;}
        public DbSet<ConfigDemographicSettings> ConfigDemographicSettings {get; set;}
        
        // MODEL PARAM
        public DbSet<ModelParamKernelConfig> ModelParamKernelConfig {get; set;}
        public DbSet<ModelParamCalculationExecution> ModelParamCalculationExecution {get; set;}
        public DbSet<ModelParamRunDefinition> ModelParamRunDefinition {get; set;}
        public DbSet<ModelParamExpenses> ModelParamExpenses {get; set;}
        public DbSet<ModelParamEconomic> ModelParamEconomic {get; set;}
        public DbSet<ModelParamDemographicSettings> ModelParamDemographicSettings {get; set;}

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.ApplyAllConfigurations(typeof(ArcSimDbContext));
        // }

        public ArcSimDbContext(DbContextOptions<ArcSimDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // CONFIG
            modelBuilder.ApplyConfiguration(new ConfigAssumptionsConfigSetConfiguration());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration<ConfigKernelConfig>());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration<ConfigCalculationExecution>());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration<ConfigRunDefinition>());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration<ConfigExpenses>());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration<ConfigEconomic>());
            modelBuilder.ApplyConfiguration(new ConfigConfiguration<ConfigDemographicSettings>());

            // MODEL PARAM
            modelBuilder.ApplyConfiguration(new ModelParamConfiguration<ModelParamKernelConfig>());
            modelBuilder.ApplyConfiguration(new ModelParamConfiguration<ModelParamCalculationExecution>());
            modelBuilder.ApplyConfiguration(new ModelParamConfiguration<ModelParamRunDefinition>());
            modelBuilder.ApplyConfiguration(new ModelParamConfiguration<ModelParamExpenses>());
            modelBuilder.ApplyConfiguration(new ModelParamConfiguration<ModelParamEconomic>());
            modelBuilder.ApplyConfiguration(new ModelParamConfiguration<ModelParamDemographicSettings>());
        }
    }
}