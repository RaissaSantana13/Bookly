using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class UserAchivement : BaseEntity<int>
    {
        public UserAchivement()
        {
        }

        public UserAchivement(int id, DateTime unlockDate, Achivement achivement, User user) :base(id)
        {
            UnlockDate= unlockDate;
            Achivement= achivement;
            User= user;
        }
        public DateTime UnlockDate { get; set; }
        public Achivement Achivement { get; set; }
        public User User { get; set; }
    }
}