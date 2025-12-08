using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class ReadingSession : BaseEntity<int>
    {
        public ReadingSession() { }

        public ReadingSession(int id, DateTime date, int pagesReadToday, int userId, int bookId, int readingProcessId) : base(id)
        {
            Date = date;
            PagesReadToday = pagesReadToday;
            UserId = userId;
            BookId = bookId; 
            ReadingProcessId = readingProcessId;
        }
        public DateTime Date { get; set; }
        public int PagesReadToday { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int ReadingProcessId { get; set; }
        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ReadingProcess ReadingProcess { get; set; }
    }
}