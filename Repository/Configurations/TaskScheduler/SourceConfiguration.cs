using System.Text.RegularExpressions;
using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configuration.TaskScheduler
{
    public class SourceConfiguration : IEntityTypeConfiguration<Source>
    {
        public void Configure(EntityTypeBuilder<Source> builder)
        {
            // configure table to model relationship
            builder.HasKey(o => o.Id);
            builder.ToTable("Source", schema: "dbo");
        }
    }
}