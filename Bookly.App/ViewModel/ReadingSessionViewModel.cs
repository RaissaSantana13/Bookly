using Bookly.Domain.Entities;

namespace Bookly.App.ViewModel
{
    public class ReadingSessionViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PagesReadToday { get; set; }

        // --- Adicione os IDs aqui também ---
        public int UserId { get; set; }
        public int BookId { get; set; }
        public int ReadingProcessId { get; set; }

        // Pode manter null na hora de salvar, o AutoMapper vai ignorar se o ID estiver preenchido
        public User User { get; set; }
        public Book Book { get; set; }
        public ReadingProcess ReadingProcess { get; set; }
    }
}