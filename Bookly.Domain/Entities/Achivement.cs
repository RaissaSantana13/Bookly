using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Achivement : BaseEntity<int>
    {
        public Achivement()
        {
        }

        public Achivement(int id, string name, string description)
        {
            Name= name;
            Description= description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}