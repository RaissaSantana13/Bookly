using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class Goal : BaseEntity<int>
    {
        public Goal()
        {
        }

        public Goal(int id, string goalType, bool isComplete, User user) :base(id)
        {
            GoalType = goalType;
            IsComplete = isComplete;
            User= user;
        }
        public string GoalType { get; set; } 
        public bool IsComplete { get; set;} 
        public User User { get; set; }

    }
}