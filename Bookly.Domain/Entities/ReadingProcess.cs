using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class ReadingProcess : BaseEntity<int>
    {
        public ReadingProcess()
        {
        }

        public ReadingProcess(int id , DateTime startDate, string status, DateTime endDate, int pagesRead, User user, Book book) :base(id)
        {
            StartDate=startDate;
            Status=status;  
            EndDate=endDate;
            PagesRead=pagesRead;
            User = user;
            Book=book;
        }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int PagesRead { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
    }
}