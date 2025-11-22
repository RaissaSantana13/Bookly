using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class AuthorBook : BaseEntity<int>
    {
        public AuthorBook()
        {
        }

        public AuthorBook(int id, Author author, Book book) :base(id)
        {
            Author=author;
            Book=book;
        }

        public Author Author { get; set; }
        public Book Book { get; set; }

    }
}