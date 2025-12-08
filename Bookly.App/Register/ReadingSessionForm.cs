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
                if (!int.TryParse(txtPagesRead.Text, out int pagesReadToday)) { /*...*/ return; }
                if (!DateTime.TryParse(txtDate.Text, out DateTime sessionDate)) { /*...*/ return; }

                // Validação lógica
                int totalBookPages = _currentProcess.Book.Pages;
                int alreadyReadPages = _currentProcess.PagesRead;

                if (alreadyReadPages + pagesReadToday > totalBookPages)
                {
                    MessageBox.Show($"Erro: Isso ultrapassa o total de páginas ({totalBookPages}).", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // -------------------------------------------------------
                // PASSO 1: Atualizar o Objeto Processo (Pai) na memória
                // -------------------------------------------------------
                _currentProcess.PagesRead += pagesReadToday;

                if (_currentProcess.PagesRead == totalBookPages)
                {
                    _currentProcess.Status = "Completed";
                    _currentProcess.EndDate = sessionDate;
                    MessageBox.Show("Parabéns! Você concluiu este livro.", "Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // -------------------------------------------------------
                // PASSO 2: Criar a Sessão (Filho) usando IDs
                // -------------------------------------------------------
                var newSession = new ReadingSessionViewModel
                {
                    // Id = 0, // NÃO defina Id, deixe o banco gerar (Auto Increment)
                    Date = sessionDate,
                    PagesReadToday = pagesReadToday,

                    // O PULO DO GATO: Use os IDs do processo atual
                    UserId = _currentProcess.User.Id,
                    BookId = _currentProcess.Book.Id,
                    ReadingProcessId = _currentProcess.Id,

                    // IMPORTANTE: Deixe os objetos complexos como NULL.
                    // Isso impede que o EF tente salvar o Usuário/Livro de novo.
                    User = null,
                    Book = null,
                    ReadingProcess = null
                };

                // -------------------------------------------------------
                // PASSO 3: Salvar no Banco
                // -------------------------------------------------------

                // Salva a sessão nova (o banco vai ver os IDs e fazer o link)
                _readingSessionService.Add<ReadingSessionViewModel, ReadingSessionViewModel, ReadingSessionValidator>(newSession);

                // Atualiza o processo existente (novas páginas lidas)
                _readingProcessService.Update<ReadingProcessViewModel, ReadingProcessViewModel, ReadingProcessValidator>(_currentProcess);

                MessageBox.Show("Sessão de leitura registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar: {ex.Message} \n\nDetalhes: {ex.InnerException?.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

