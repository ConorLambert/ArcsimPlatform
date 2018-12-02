using System.Text.RegularExpressions;
using ArcsimPlatform.ComponentModels.Entities.ArcSim;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configurations.ArcSim
{
    public class ModelParamConfiguration<T> : IEntityTypeConfiguration<T> where T : ModelParam
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            string schema = "ModelParam";
            
            // remove ModelParam
            var regex = new Regex(Regex.Escape(schema));
            var configType = regex.Replace(typeof(T).Name, "", 1);

            // configure table to model relationship
            builder.HasKey(o => new {o.Id});
            builder.Property(t => t.ModelParamId)
                   .HasColumnName(configType + "Id");
            builder.ToTable(configType, schema: schema);
        }
    }
}