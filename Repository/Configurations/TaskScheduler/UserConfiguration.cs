using ArcsimPlatform.ComponentModels.Entities.TaskScheduler;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ArcsimPlatform.Repository.Configurations.TaskScheduler
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // configure table to model relationship
            builder.HasKey(o => o.Id);
            builder.Ignore(p => p.OriginalIdentity);
            builder.ToTable("User", schema: "dbo");
        }
    }
}
