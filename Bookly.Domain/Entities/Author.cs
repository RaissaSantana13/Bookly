using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Author : BaseEntity<int>
    {
        public Author()
        {
        }

        public Author(int id, string name)
        {
            Name=name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}