using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookly.Repository.Mapping
{
    public class UserAchivementMap : IEntityTypeConfiguration<UserAchivement>
    {
        public void Configure(EntityTypeBuilder<UserAchivement> builder)
        {
            builder.ToTable("UserAchivement");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.UnlockDate).HasDefaultValueSql("CURRENT_TIMESTAMP").IsRequired();
            builder.HasOne(prop => prop.Achivement);
            builder.HasOne(prop => prop.User);
        }
    }
}
