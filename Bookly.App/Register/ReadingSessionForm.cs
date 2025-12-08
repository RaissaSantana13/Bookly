using Bookly.App.Base;
using Bookly.App.Infra;
using Bookly.App.ViewModel;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Bookly.App.Register
{
    public partial class ReadingSessionForm : BaseForm
    {
        private readonly IBaseService<ReadingSession> _readingSessionService;
        private readonly IBaseService<ReadingProcess> _readingProcessService;
        private ReadingProcessViewModel _currentProcess;

        public ReadingSessionForm()
        {
            InitializeComponent();
            _readingSessionService = ConfigureDI.serviceProvider.GetService<IBaseService<ReadingSession>>();
            _readingProcessService = ConfigureDI.serviceProvider.GetService<IBaseService<ReadingProcess>>();
        }

        public ReadingSessionForm(ReadingProcessViewModel readingProcess) : this()
        {
            _currentProcess = readingProcess;
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
        protected override void Save()
        {
            try
            {
                if (_currentProcess.User == null)
                {
                    MessageBox.Show("Critical error: User data could not be loaded. Restart the application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!int.TryParse(txtPagesRead.Text, out int pagesReadToday))
                {
                    MessageBox.Show("Invalid number of pages.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!DateTime.TryParse(txtDate.Text, out DateTime sessionDate))
                {
                    MessageBox.Show("Invalid date. Use the format YYYY-MM-DD or DD/MM/YYYY.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalBookPages = _currentProcess.Book.Pages;
                int alreadyReadPages = _currentProcess.PagesRead;

                if (alreadyReadPages + pagesReadToday > totalBookPages)
                {
                    MessageBox.Show($"Error: Exceeds total number of pages. ({totalBookPages}).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _currentProcess.PagesRead += pagesReadToday;

                if (_currentProcess.PagesRead == totalBookPages)
                {
                    _currentProcess.Status = "Completed";
                    _currentProcess.EndDate = sessionDate;
                    MessageBox.Show("Congratulations! Book completed.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                var newSession = new ReadingSessionViewModel
                {
                    Date = sessionDate,
                    PagesReadToday = pagesReadToday,
                    UserId = _currentProcess.User.Id, 
                    BookId = _currentProcess.Book.Id,
                    ReadingProcessId = _currentProcess.Id,
                    User = null,
                    Book = null,
                    ReadingProcess = null
                };

                _readingSessionService.Add<ReadingSessionViewModel, ReadingSessionViewModel, ReadingSessionValidator>(newSession);
                _readingProcessService.Update<ReadingProcessViewModel, ReadingProcessViewModel, ReadingProcessValidator>(_currentProcess);

                MessageBox.Show("Session successfully registered!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error when saving: {ex.Message}\n{ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}