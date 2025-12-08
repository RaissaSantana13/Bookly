using Bookly.App.Base;
using Bookly.App.Infra;
using Bookly.App.ViewModel;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Service.Validators;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            txtDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Save()
        {
            try
            {
                if (!int.TryParse(txtPagesRead.Text, out int pagesReadToday)) { return; }
                if (!DateTime.TryParse(txtDate.Text, out DateTime sessionDate)) {return; }
                int totalBookPages = _currentProcess.Book.Pages;
                int alreadyReadPages = _currentProcess.PagesRead;

                if (alreadyReadPages + pagesReadToday > totalBookPages)
                {
                    MessageBox.Show($"Error: This exceeds the total number of pages. ({totalBookPages}).", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _currentProcess.PagesRead += pagesReadToday;

                if (_currentProcess.PagesRead == totalBookPages)
                {
                    _currentProcess.Status = "Completed";
                    _currentProcess.EndDate = sessionDate;
                    MessageBox.Show("Congratulations! You have finished this book.", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                MessageBox.Show("Reading session successfully recorded!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving: {ex.Message} \n Details:{ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

