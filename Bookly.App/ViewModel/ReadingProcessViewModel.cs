using Bookly.Domain.Entities;


namespace Bookly.App.ViewModel
{
    public class ReadingProcessViewModel
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Status { get; set; }
        public int PagesRead { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public List<ReadingSession> ReadingSessions { get; set; } = [];

    }
}
