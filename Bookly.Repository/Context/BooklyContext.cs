using Bookly.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Bookly.Repository.Mapping;


namespace Bookly.Repository.Context
{
    public class BooklyContext : DbContext
    {
        public BooklyContext(DbContextOptions<BooklyContext>? options=null) :
           base(options)
        {
            Database.EnsureCreated(); 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=BooklyBd;user=root;password=");
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ReadingProcess> ReadingProcesses { get; set; }
        public DbSet<ReadingSession> ReadingSessions { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>(new AuthorMap().Configure);
            modelBuilder.Entity<Book>(new BookMap().Configure);
            modelBuilder.Entity<Genre>(new GenreMap().Configure);
            modelBuilder.Entity<ReadingProcess>(new ReadingProcessMap().Configure);
            modelBuilder.Entity<ReadingSession>(new ReadingSessionMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);

            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Ficção Científica" },
                new Genre { Id = 2, Name = "Romance" },
                new Genre { Id = 3, Name = "Fantasia" },
                new Genre { Id = 4, Name = "Terror" },
                new Genre { Id = 5, Name = "Biografia" },
                new Genre { Id = 6, Name = "História" },
                new Genre { Id = 7, Name = "Autoajuda" },
                new Genre { Id = 8, Name = "Técnico/Acadêmico" }
    );
        }
    }
}
