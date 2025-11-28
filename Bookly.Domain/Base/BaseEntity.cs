using Bookly.Domain.Base;

namespace Bookly.Domain.Base
{
    public abstract class BaseEntity<TID> : IBaseEntity
    {
        protected BaseEntity(){
        
        }

        protected BaseEntity(TID Id)
        {
            Id = Id; 
        }

        public TID? Id {  get; set; }
    }
}
