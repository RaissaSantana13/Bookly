using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.Repository.Mapping
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("Book");
            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Title)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.PublicationYear).IsRequired();
            builder.Property(prop => prop.Pages).IsRequired();
            builder.HasMany(prop => prop.Authors).WithMany(prop => prop.Books).UsingEntity("AuthorBook");
            builder.HasMany(prop => prop.Genres).WithMany(prop => prop.Books).UsingEntity("GenreBook");
        }
    }
}
