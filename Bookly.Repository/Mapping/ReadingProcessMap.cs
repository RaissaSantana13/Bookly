using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookly.Repository.Mapping
{
    public class ReadingProcessMap : IEntityTypeConfiguration<ReadingProcess>
    {
        public void Configure(EntityTypeBuilder<ReadingProcess> builder)
        {
            builder.ToTable("ReadingProcess");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.StartDate).HasDefaultValueSql("CURRENT_TIMESTAMP").IsRequired();
            builder.Property(prop => prop.EndDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            builder.Property(prop => prop.Status)
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.PagesRead);
            builder.HasOne(prop => prop.Book);
            builder.HasOne(prop => prop.User);
            builder.HasMany(prop => prop.ReadingSessions)
                .WithOne(prop => prop.ReadingProcess);
        }
    }
}
