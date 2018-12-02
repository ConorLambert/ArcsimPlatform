using System.Text.RegularExpressions;
using ArcsimPlatform.ComponentModels.Entities.ArcSim;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configurations.ArcSim
{
    public class ConfigConfiguration<T> : IEntityTypeConfiguration<T> where T : ConfigSet
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            string schema = "Config";

            // remove the first occurence of Config (need only first occurence for cases of ConfigKernelConfig)
            var regex = new Regex(Regex.Escape(schema));
            var configType = regex.Replace(typeof(T).Name, "", 1);

            // configure table to model relationship
            builder.HasKey(o => new {o.ConfigSetId, o.ProductId, o.RunTypeId});
            builder.Property(t => t.ConfigSetId)
                   .HasColumnName(configType + "ConfigSetId");
            builder.Property(t => t.ProductId)
                   .HasColumnName("ProductId");
            builder.Property(t => t.RunTypeId)
                   .HasColumnName("RunTypeId");
            builder.Property(t => t.ModelParamId)
                   .HasColumnName(configType + "Id");
            builder.ToTable(configType, schema: schema);
        }
    }
}