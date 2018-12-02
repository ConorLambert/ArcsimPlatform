using System.Text.RegularExpressions;
using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configuration.TaskScheduler
{
    public class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
    {
        public void Configure(EntityTypeBuilder<Currency> builder)
        {
            // configure table to model relationship
            builder.HasKey(o => o.Id);
            builder.ToTable("Currency", schema: "dbo");
        }
    }
}