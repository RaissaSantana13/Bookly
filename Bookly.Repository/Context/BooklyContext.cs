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
            Database.EnsureCreated(); // Cria o banco caso não exista
        }

        public DbSet<Achivement> Achivements { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ReadingProcess> ReadingProcesses { get; set; }
        public DbSet<ReadingSession> ReadingSessions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAchivement> UsersAchivements { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Achivement>(new AchivementMap().Configure);
            modelBuilder.Entity<Author>(new AuthorMap().Configure);
            modelBuilder.Entity<Book>(new BookMap().Configure);
            modelBuilder.Entity<Genre>(new GenreMap().Configure);
            modelBuilder.Entity<ReadingProcess>(new ReadingProcessMap().Configure);
            modelBuilder.Entity<ReadingSession>(new ReadingSessionMap().Configure);
            modelBuilder.Entity<User>(new UserMap().Configure);
            modelBuilder.Entity<UserAchivement>(new UserAchivementMap().Configure);
        }
    }
}
