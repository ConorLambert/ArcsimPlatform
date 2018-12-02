using ArcsimPlatform.ComponentModels.Entities.ArcSim;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configurations.ArcSim
{
    public class ConfigAssumptionsConfigSetConfiguration : IEntityTypeConfiguration<ConfigAssumptionsConfigSet>
    {
        public void Configure(EntityTypeBuilder<ConfigAssumptionsConfigSet> builder)
        {
            // configure table to model relationship
            builder.HasKey(x => x.AssumptionsConfigSetId);
            builder.ToTable("Config", "AssumptionsConfigSet");
        }
    }
}