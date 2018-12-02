using System.Text.RegularExpressions;
using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configuration.TaskScheduler
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // configure table to model relationship
            builder.HasKey(o => o.Id);
            builder.ToTable("Product", schema: "dbo");
        }
    }
}