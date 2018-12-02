using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configuration.TaskScheduler
{
    public class RunTypeConfiguration : IEntityTypeConfiguration<RunType>
    {
        public void Configure(EntityTypeBuilder<RunType> builder)
        {
            // configure table to model relationship
            builder.HasKey(o => o.Id);
            builder.ToTable("RunType", schema: "dbo");
        }
    }
}