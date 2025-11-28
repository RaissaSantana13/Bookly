

using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookly.Repository.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Email).IsFixedLength().HasColumnType("varchar(100)");
            builder.Property(prop => prop.Password).IsFixedLength().HasColumnType("varchar(100)");
            builder.Property(prop => prop.RegistrationDate).HasDefaultValueSql("CURRENT_TIMESTAMP").IsRequired();
        }
    }
}
