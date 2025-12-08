using Bookly.App.Infra;
using Bookly.App.Register;
using Bookly.App.ViewModel;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;


namespace Bookly.App
{
    public partial class MainForm : LostForm
    {
        private readonly IBaseService<ReadingProcess> _readingProcessService;
        public MainForm()
        {
            InitializeComponent();
            _readingProcessService = ConfigureDI.serviceProvider.GetService<IBaseService<ReadingProcess>>();
            AdjustColumnWidths();
            PopulateLists();
        }

        #region Home
        private void LoadDashboard(List<ReadingProcessViewModel> allProcesses)
        {
            CalculateBooksReadThisYear(allProcesses);
            var allReadingDates = allProcesses
                .Where(p => p.ReadingSessions != null)
                .SelectMany(p => p.ReadingSessions)
                .Select(s => s.Date.Date)
                .Distinct() 
                .OrderByDescending(d => d)
                .ToList();

            CalculateDailyStreak(allReadingDates);
            CalculateWeeklyStreak(allReadingDates);
            UpdateBarGraph(allReadingDates);
        }

        private void CalculateBooksReadThisYear(List<ReadingProcessViewModel> processes)
        {
            int count = processes.Count(p =>
                p.Status == "Completed" &&
                p.EndDate != DateTime.MinValue &&
                p.EndDate.Year == DateTime.Now.Year);

            lblBookYear.Text = $"You read {count} books this year.";
        }

        private void CalculateDailyStreak(List<DateTime> sortedDates)
        {
            int streak = 0;
            var checkDate = DateTime.Today;
            if (!sortedDates.Contains(checkDate))
            {
                checkDate = checkDate.AddDays(-1);
                if (!sortedDates.Contains(checkDate))
                {
                    lblDays.Text = "0";
                    return;
                }
            }
            while (sortedDates.Contains(checkDate))
            {
                streak++;
                checkDate = checkDate.AddDays(-1);
            }

            lblDays.Text = streak.ToString();
        }

        private void CalculateWeeklyStreak(List<DateTime> sortedDates)
        {

            if (!sortedDates.Any())
            {
                lblWeek.Text = "0";
                return;
            }

            int streakWeeks = 0;
            var currentCheck = DateTime.Today;

            bool hasReadingInBlock = true;

            while (hasReadingInBlock)
            {
                var startOfWeek = currentCheck.AddDays(-6);
                bool readThisWeek = sortedDates.Any(d => d <= currentCheck && d >= startOfWeek);

                if (readThisWeek)
                {
                    streakWeeks++;
                    currentCheck = currentCheck.AddDays(-7); 
                }
                else
                {
                    hasReadingInBlock = false;
                }
            }

            lblWeek.Text = streakWeeks.ToString();
        }

        private void UpdateBarGraph(List<DateTime> allDates)
        {
            double[] values = new double[12];
            double[] positions = new double[12];

            string[] labels = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

            for (int i = 0; i < 12; i++)
            {
                int count = allDates.Count(d => d.Month == i + 1 && d.Year == DateTime.Now.Year);
                values[i] = count;
                positions[i] = i;
            }

            plotDaysMonth.Plot.Clear();
            var bars = plotDaysMonth.Plot.Add.Bars(positions, values);
            bars.Color = ScottPlot.Color.FromHex("#9C85C3"); 
            foreach (var bar in bars.Bars)
            {
                bar.Label = bar.Value.ToString();
            }
            bars.ValueLabelStyle.ForeColor = ScottPlot.Color.FromHex("#483D8B");
            bars.ValueLabelStyle.FontSize = 14;
            bars.ValueLabelStyle.Bold = true;
            plotDaysMonth.Plot.Axes.Bottom.TickGenerator = new ScottPlot.TickGenerators.NumericManual(positions, labels);
            plotDaysMonth.Plot.Grid.MajorLineColor = ScottPlot.Color.FromHex("#00000000");
            plotDaysMonth.Plot.Axes.Margins(bottom: 0);
            plotDaysMonth.Refresh();
        }


        #endregion

        #region Libary
        protected void PopulateLists()
        {
            var result = _readingProcessService?.Get<ReadingProcessViewModel>(
        new List<string> { "Book", "Book.Authors", "ReadingSessions" });

            var processes = result?.ToList() ?? new List<ReadingProcessViewModel>();

            lstInProgress.Items.Clear();
            lstCompleted.Items.Clear();
            foreach (var process in processes)
            {
                string authorName = GetAuthorName(process);
                bool isCompleted = process.Status == "Completed";

                if (isCompleted)
                {
                    var item = CreateCompletedItem(process, authorName);
                    lstCompleted.Items.Add(item);
                }
                else
                {
                    var item = CreateInProgressItem(process, authorName);
                    lstInProgress.Items.Add(item);
                }
            }

            LoadDashboard(processes);
        }

        private string GetAuthorName(ReadingProcessViewModel process)
        {
            if (process.Book.Authors != null && process.Book.Authors.Any())
            {
                return string.Join(", ", process.Book.Authors.Select(a => a.Name));
            }
            return "Unknown";
        }

        private ListViewItem CreateCompletedItem(ReadingProcessViewModel process, string authorName)
        {
            var item = new ListViewItem(process.Book.Title);
            item.SubItems.Add(authorName);

            string dateText = process.EndDate != DateTime.MinValue
                              ? process.EndDate.ToString("dd/MM/yyyy")
                              : "-";
            item.SubItems.Add(dateText);

            item.ForeColor = Color.DimGray;
            item.Tag = process; 
            return item;
        }

        private ListViewItem CreateInProgressItem(ReadingProcessViewModel process, string authorName)
        {
            var item = new ListViewItem(process.Book.Title);
            item.SubItems.Add(authorName);
            item.SubItems.Add($"{process.PagesRead} / {process.Book.Pages}");

            int percentage = process.Book.Pages > 0
                             ? (process.PagesRead * 100) / process.Book.Pages
                             : 0;
            item.SubItems.Add($"{percentage}%");

            item.ForeColor = Color.Black;
            item.Tag = process; 
            return item;
        }

        private void AdjustColumnWidths()
        {
            int fixedSpaceInProgress = 150 + 100 + 50 + 25;
            if (lstInProgress.Columns.Count >= 4)
            {
                lstInProgress.Columns[1].Width = 150;
                lstInProgress.Columns[2].Width = 100;
                lstInProgress.Columns[3].Width = 50;
                lstInProgress.Columns[0].Width = Math.Max(100, lstInProgress.ClientSize.Width - fixedSpaceInProgress);
            }

            int fixedSpaceCompleted = 150 + 100 + 25;
            if (lstCompleted.Columns.Count >= 3)
            {
                lstCompleted.Columns[1].Width = 150;
                lstCompleted.Columns[2].Width = 100;
                lstCompleted.Columns[0].Width = Math.Max(100, lstCompleted.ClientSize.Width - fixedSpaceCompleted);
            }
        }

        private void lstInProgress_DoubleClick(object sender, EventArgs e)
        {
            OpenBookDetails(lstInProgress);
        }

        private void lstCompleted_DoubleClick(object sender, EventArgs e)
        {
            OpenBookDetails(lstCompleted);
        }

        private void OpenBookDetails(ListView sourceList)
        {
            if (sourceList.SelectedItems.Count == 0) return;

            ListViewItem selectedItem = sourceList.SelectedItems[0];
            var process = (ReadingProcessViewModel)selectedItem.Tag;
            using (var form = new ReadingSessionForm(process))
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK)
                {
                    PopulateLists();
                }
            }
        }

        private ReadingProcessViewModel GetSelectedProcess()
        {
            if (lstInProgress.SelectedItems.Count > 0)
            {
                return (ReadingProcessViewModel)lstInProgress.SelectedItems[0].Tag;
            }
            if (lstCompleted.SelectedItems.Count > 0)
            {
                return (ReadingProcessViewModel)lstCompleted.SelectedItems[0].Tag;
            }

            return null;
        }

        private void btnReadingSession_Click(object sender, EventArgs e)
        {
            var selectedProcess = GetSelectedProcess();

            if (selectedProcess == null)
            {
                MessageBox.Show("Please select a book to register a reading session.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var form = new ReadingSessionForm(selectedProcess))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    PopulateLists();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = ConfigureDI.serviceProvider.GetService<BookForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                PopulateLists();
            }
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var selectedProcess = GetSelectedProcess();

            if (selectedProcess == null)
            {
                MessageBox.Show("Please select a book to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show(
                $"Are you sure you want to remove '{selectedProcess.Book.Title}' from your list?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _readingProcessService.Delete(selectedProcess.Id);
                    MessageBox.Show("Book removed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PopulateLists();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        #endregion

        #region Close
        private void tabPageMain_Click(object sender, EventArgs e)
        {
            if (tabPageMain.SelectedTab == tabHome)
            {
                PopulateLists(); 
            }
            if (tabPageMain.SelectedTab == tabClose)
            {
                this.Close();
            }
        }
        #endregion
    }
}
