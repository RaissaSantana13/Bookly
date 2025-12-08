using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Book : BaseEntity<int>
    {
        public Book()
        {
            
        }

        public Book(int id, string title, int publicationYear, int pages, List<Author> authors, List<Genre> genres) : base(id)
        {
            Title= title;
            PublicationYear= publicationYear;
            Pages= pages;
            Authors= new List<Author>();
            Genres= new List<Genre>();
        }

        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int Pages { get; set; }
        public List<Author> Authors { get; set; } = [];
        public List<Genre> Genres { get; set; } = [];
    }
}