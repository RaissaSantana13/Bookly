using Bookly.Domain.Entities;

namespace Bookly.App.ViewModel
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public int Pages { get; set; }
        public List<Author> Authors { get; set; } = [];
        public List<Genre> Genres { get; set; } = [];
    }
}
