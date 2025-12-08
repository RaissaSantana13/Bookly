using Bookly.Domain.Entities;

namespace Bookly.App.ViewModel
{
    public class ReadingSessionViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PagesReadToday { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int ReadingProcessId { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public ReadingProcess ReadingProcess { get; set; }
    }
}