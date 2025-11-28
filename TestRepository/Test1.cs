using Bookly.Domain.Entities;
using Bookly.Repository.Context;
using Microsoft.EntityFrameworkCore;
using MySqlX.XDevAPI;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace TestRepository
{
    [TestClass]
    public sealed class TestRepository
    {
        [TestMethod]
        public void TestBook()
        {
            var op = new DbContextOptionsBuilder<BooklyContext>();
            op.UseMySQL("server=localhost;database=BooklyBd;user=root;password=");

            using (var context = new BooklyContext(op.Options))
            {
                Console.WriteLine("Connected!");

                var Book1 = new Book { Id= 1, Title=  "Harry Potter", PublicationYear=  2002, Pages= 120 };
                var Book2 = new Book { Id = 2, Title = "Dom casmurro", PublicationYear = 1989, Pages = 350 };
                var Book3 = new Book { Id = 3, Title = "Lady Killers", PublicationYear = 2015, Pages = 400 };

                context.Books.Add(Book1);
                context.Books.Add(Book2);
                context.Books.Add(Book3);

                context.SaveChanges();

                var genre1 = new Genre { Id = 1, Name = "Suspense", Books = [Book1]};
                var genre2 = new Genre { Id = 2, Name = "Terror" };
                var genre3 = new Genre { Id = 3, Name = "Poesia" };

                context.Genres.Add(genre1);
                context.Genres.Add(genre2);
                context.Genres.Add(genre3);

                context.SaveChanges();

                Console.WriteLine("Inser done!");
                foreach (var cat in context.Books)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }
            
        /*
        [TestMethod]
        public void TestGenre()
        {
            using (var context = BooklyContext())
            {
                Console.WriteLine("Connected!");

                var genre1 = new Genre { Id= 1, Name= "Suspense" };
                var genre2 = new Genre { Id = 2, Name = "Terror" };
                var genre3 = new Genre { Id = 3, Name = "Poesia" };

                context.Genres.Add(genre1);
                context.Genres.Add(genre2);
                context.Genres.Add(genre3);

                context.SaveChanges();
                Console.WriteLine("Inser done!");
            }
            using (var context = new BooklyContext())
            {
                foreach (var cat in context.Genres)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }
        */
    }
}


