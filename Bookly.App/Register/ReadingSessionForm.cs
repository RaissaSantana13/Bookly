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
        private ReadingProcessViewModel _processoAtual;

        public ReadingSessionForm()
        {
            InitializeComponent();
            _readingSessionService = ConfigureDI.serviceProvider.GetService<IBaseService<ReadingSession>>();
            _readingProcessService = ConfigureDI.serviceProvider.GetService<IBaseService<ReadingProcess>>();
        }

        public ReadingSessionForm(ReadingProcessViewModel readingProcess) : this()
        {
            _processoAtual = readingProcess;
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Save()
        {
            try
            {
                if (!int.TryParse(txtPagesRead.Text, out int paginasLidasHoje))
                {
                    MessageBox.Show("Por favor, insira um número válido de páginas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!DateTime.TryParse(txtData.Text, out DateTime dataSessao))
                {
                    MessageBox.Show("Por favor, insira uma data válida (dd/MM/yyyy).", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (paginasLidasHoje <= 0)
                {
                    MessageBox.Show("O número de páginas lidas deve ser maior que zero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int totalPaginasLivro = _processoAtual.Book.Pages; 
                int paginasJaLidas = _processoAtual.PagesRead; 

                if (paginasJaLidas + paginasLidasHoje > totalPaginasLivro)
                {
                    MessageBox.Show($"Você não pode registrar mais páginas do que o livro possui.\nPáginas restantes para ler: {totalPaginasLivro - paginasJaLidas}", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                _processoAtual.PagesRead += paginasLidasHoje;
                if (_processoAtual.PagesRead == totalPaginasLivro)
                {
                    _processoAtual.Status = "Concluído";
                    _processoAtual.EndDate = dataSessao;
                    MessageBox.Show("Parabéns! Você concluiu a leitura deste livro.", "Livro Concluído", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                var novaSessao = new ReadingSessionViewModel
                {
                    Date = dataSessao,
                    PagesReadToday = paginasLidasHoje,
                    User = _processoAtual.User,
                    Book = _processoAtual.Book,
                    ReadingProcess = new ReadingProcess
                    {
                        Id = _processoAtual.Id,
                        Status = _processoAtual.Status,
                        StartDate = _processoAtual.StartDate,
                        EndDate = _processoAtual.EndDate,
                        PagesRead = _processoAtual.PagesRead
                    }
                };
                _readingSessionService.Add<ReadingSessionViewModel, ReadingSessionViewModel, ReadingSessionValidator>(novaSessao);
                _readingProcessService.Update<ReadingProcessViewModel, ReadingProcessViewModel, ReadingProcessValidator>(_processoAtual);

                MessageBox.Show("Sessão de leitura registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

