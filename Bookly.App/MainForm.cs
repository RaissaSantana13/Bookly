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

        #region Libary
        protected void PopulateLists()
        {
            var result = _readingProcessService?.Get<ReadingProcessViewModel>(new List<string> { "Book", "Book.Authors" });

            // 2. BLINDAGEM:
            // O operador '??' significa: "Se o que está à esquerda for nulo, use o que está à direita".
            // Ou seja, se vier nulo, criamos uma lista vazia para o código não quebrar.
            var processes = result?.ToList() ?? new List<ReadingProcessViewModel>();

            // Daqui pra baixo o código segue normal. 
            // Se a lista estiver vazia, ele limpa a tela e não entra no foreach.
            lstInProgress.Items.Clear();
            lstCompleted.Items.Clear();

            // 3. Preenche as listas (Adaptação para ListView)
            // Como ListView não tem DataSource, fazemos um loop limpo
            foreach (var process in processes)
            {
                // Prepara os dados de exibição antes de criar o item
                string authorName = GetAuthorName(process);
                bool isCompleted = process.Status == "Concluído" || process.Status == "Completed";

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
            item.Tag = process; // Importante para o clique funcionar
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
            item.Tag = process; // Importante para o clique funcionar
            return item;
        }

        private void AddToCompletedList(ReadingProcessViewModel process, string authorName)
        {
            var item = new ListViewItem(process.Book.Title);
            item.SubItems.Add(authorName);
            string dateText = process.EndDate != DateTime.MinValue
                              ? process.EndDate.ToString("dd/MM/yyyy")
                              : "-";
            item.SubItems.Add(dateText);

            item.ForeColor = Color.DimGray;
            item.Tag = process;

            lstCompleted.Items.Add(item);
        }

        private void AddToInProgressList(ReadingProcessViewModel process, string authorName)
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

            lstInProgress.Items.Add(item);
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
                    
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowForm<BookForm>();
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing book: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        #endregion

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.Show();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

    }
}
