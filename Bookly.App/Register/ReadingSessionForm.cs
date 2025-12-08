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
                if (!int.TryParse(txtPagesRead.Text, out int pagesReadToday))
                {
                    MessageBox.Show("Please enter a valid number of pages.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!DateTime.TryParse(txtDate.Text, out DateTime sessionDate))
                {
                    MessageBox.Show("Please enter a valid date (dd/MM/yyyy).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (pagesReadToday <= 0)
                {
                    MessageBox.Show("The number of pages read must be greater than zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalBookPages = _currentProcess.Book.Pages;
                int alreadyReadPages = _currentProcess.PagesRead;

                if (alreadyReadPages + pagesReadToday > totalBookPages)
                {
                    MessageBox.Show(
                        $"You cannot register more pages than the book has.\nPages remaining: {totalBookPages - alreadyReadPages}",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                _currentProcess.PagesRead += pagesReadToday;

                if (_currentProcess.PagesRead == totalBookPages)
                {
                    _currentProcess.Status = "Completed";
                    _currentProcess.EndDate = sessionDate;

                    MessageBox.Show("Congratulations! You have finished this book.",
                        "Book Completed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                var newSession = new ReadingSessionViewModel
                {
                    Date = sessionDate,
                    PagesReadToday = pagesReadToday,
                    Id = _currentProcess.Id,
                    User = _currentProcess.User,
                    Book = _currentProcess.Book
                };

                _readingSessionService.Add
                    <ReadingSessionViewModel,
                     ReadingSessionViewModel,
                     ReadingSessionValidator>(newSession);

                _readingProcessService.Update
                    <ReadingProcessViewModel,
                     ReadingProcessViewModel,
                     ReadingProcessValidator>(_currentProcess);

                MessageBox.Show(
                    "Reading session registered successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"An error occurred while saving: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

    }
}

