using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Bookly.Repository.Mapping
{
    public class ReadingSessionMap : IEntityTypeConfiguration<ReadingSession>
    {
        public void Configure(EntityTypeBuilder<ReadingSession> builder)
        {
            builder.ToTable("ReadingSession");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Date).HasDefaultValueSql("CURRENT_TIMESTAMP").IsRequired();
            builder.Property(prop => prop.PagesReadToday).IsRequired();
            builder.HasOne(prop => prop.Book);
            builder.HasOne(prop => prop.User);
            builder.HasOne(prop => prop.ReadingProcess);
        }
    }
}
