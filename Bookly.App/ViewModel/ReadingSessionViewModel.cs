using Bookly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.App.ViewModel
{
    public class ReadingSessionViewModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int PagesReadToday { get; set; }
        public User User { get; set; }
        public Book Book { get; set; }
        public ReadingProcess ReadingProcess { get; set; }
    }
}
