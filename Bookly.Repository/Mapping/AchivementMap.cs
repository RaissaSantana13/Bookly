using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookly.Repository.Mapping
{
    public class AchivementMap : IEntityTypeConfiguration<Achivement>
    {
        public void Configure(EntityTypeBuilder<Achivement> builder)
        {
            builder.ToTable("Achivement");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Description)
                .IsRequired()
                .HasColumnType("varchar(200)");
        }
    }
}
