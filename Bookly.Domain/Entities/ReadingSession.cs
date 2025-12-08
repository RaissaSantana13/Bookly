using Bookly.Domain.Base;

namespace Bookly.Domain.Entities
{
    public class ReadingSession : BaseEntity<int>
    {
        public ReadingSession() { }

        // Adicione os IDs aqui no construtor também, se quiser, ou deixe opcional
        public ReadingSession(int id, DateTime date, int pagesReadToday, int userId, int bookId, int readingProcessId) : base(id)
        {
            Date = date;
            PagesReadToday = pagesReadToday;
            UserId = userId; // Novo
            BookId = bookId; // Novo
            ReadingProcessId = readingProcessId; // Novo
        }

        public DateTime Date { get; set; }
        public int PagesReadToday { get; set; }

        // --- Adicione estes 3 IDs ---
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int ReadingProcessId { get; set; }

        // Mantenha os objetos virtuais (opcional, mas bom para leitura)
        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ReadingProcess ReadingProcess { get; set; }
    }
}