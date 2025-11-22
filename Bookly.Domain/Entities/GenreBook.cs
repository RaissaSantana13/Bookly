using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class GenreBook : BaseEntity<int>
    {
        public GenreBook()
        {
        }

        public GenreBook(int id, Genre genre, Book book) : base(id)
        {
            Genre = genre;
            Book = book;
        }

        public Genre Genre { get; set; }
        public Book Book { get; set; }

    }
}