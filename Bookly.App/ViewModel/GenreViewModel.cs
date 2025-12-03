using Bookly.Domain.Entities;

namespace Bookly.App.ViewModel
{
    public class GenreViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = [];
    }
}
