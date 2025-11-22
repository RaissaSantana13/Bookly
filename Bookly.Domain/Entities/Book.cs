using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Book : BaseEntity<int>
    {
        public Book()
        {
            
        }

        public Book(int id, string title, int publicationYear, int pages, string synopsys, string isbn, string cover)
        {
            Title= title;
            PublicationYear= publicationYear;
            Pages= pages;
            Synopsys= synopsys;
            ISBN= isbn;
            Cover= cover;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int Pages { get; set; }
        public string Synopsys { get; set; }
        public string Cover { get; set; }
        public string ISBN { get; set; }
    }
}