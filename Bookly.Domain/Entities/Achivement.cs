using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Achivement : BaseEntity<int>
    {
        public Achivement()
        {
        }

        public Achivement(int id, string name, string description) : base(id)
        {
            Name= name;
            Description= description;
        }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}