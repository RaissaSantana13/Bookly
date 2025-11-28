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
    public class AuthorBookMap : IEntityTypeConfiguration<AuthorBook>
    {
        public void Configure(EntityTypeBuilder<AuthorBook> builder)
        {
            builder.ToTable("AuthorBook");
            builder.HasKey(prop => prop.Id);
            builder.HasOne(prop => prop.Book);
            //builder.HasMany(prop => prop.Author);
        }
    }
}
