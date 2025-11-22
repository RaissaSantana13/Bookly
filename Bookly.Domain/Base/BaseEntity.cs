namespace Bookly.Domain.Base
{
    public abstract class BaseEntity<TID>
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
