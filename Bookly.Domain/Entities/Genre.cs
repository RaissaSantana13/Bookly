using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Genre : BaseEntity<int>
    {
        public Genre()
        {
        }

        public Genre(int id, string name, List<Book> books) : base(id)
        {
            Name = name;
            Books = new List<Book>();
        }
        public string Name { get; set; }
        public List<Book> Books { get; set;} = [];
    }
}