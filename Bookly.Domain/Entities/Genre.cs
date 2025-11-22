using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Genre : BaseEntity<int>
    {
        public Genre()
        {
        }

        public Genre(int id, string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}