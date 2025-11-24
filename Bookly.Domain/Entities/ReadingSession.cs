using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class ReadingSession : BaseEntity<int>
    {
        public ReadingSession()
        {
        }

        public ReadingSession(int id, DateTime date, int pagesReadToday, User user, Book book, ReadingProcess readingProcess) : base(id)
        {
            Date=date;
            PagesReadToday = pagesReadToday;
            User = user;
            Book = book;
            ReadingProcess=readingProcess;
        }
        public DateTime Date { get; set; }
        public int PagesReadToday { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public ReadingProcess ReadingProcess { get; set; }
    }
}