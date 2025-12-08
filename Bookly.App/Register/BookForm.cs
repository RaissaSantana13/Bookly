using Bookly.App.Base;
using Bookly.App.Infra;
using Bookly.App.Others;
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
    public partial class BookForm : BaseForm
    {
        private readonly IBaseService<Book> _bookService;
        private readonly IBaseService<Author> _authorService;
        private readonly IBaseService<Genre> _genreService;
        private readonly IBaseService<ReadingProcess> _processService;
        public BookForm()
        {
            _bookService = ConfigureDI.serviceProvider.GetService<IBaseService<Book>>();
            _authorService = ConfigureDI.serviceProvider.GetService<IBaseService<Author>>();
            _genreService = ConfigureDI.serviceProvider.GetService<IBaseService<Genre>>();
            _processService = ConfigureDI.serviceProvider.GetService<IBaseService<ReadingProcess>>();

            InitializeComponent();
            LoadData();
        }

        public BookForm(Book book) : this()
        {
            IsEditMode = true;
            FillFields(book);
        }

        private void LoadData()
        {
            var genres = _genreService.Get<Genre>().ToList();
            clbGenres.DataSource = null;
            clbGenres.DataSource = genres;
            clbGenres.DisplayMember = "Name";
            clbGenres.ValueMember = "Id";


            var authors = _authorService.Get<Author>().OrderBy(a => a.Name).ToList();
            clbAuthors.DataSource = authors;
            clbAuthors.DisplayMember = "Name";
            clbAuthors.ValueMember = "Id";


            cbStatus.Items.Clear();
            cbStatus.Items.Add("Reading");
            cbStatus.Items.Add("Completed");
            cbStatus.SelectedIndex = 0;
        }

        private void FillFields(Book book)
        {

            txtId.Text = book.Id.ToString();
            txtTitle.Text = book.Title;
            txtPages.Text = book.Pages.ToString();
            txtYear.Text = book.PublicationYear.ToString();
            if (book.Authors != null)
            {
                for (int i = 0; i < clbAuthors.Items.Count; i++)
                {
                    var autorDaLista = (Author)clbAuthors.Items[i];
                    if (book.Authors.Any(a => a.Id == autorDaLista.Id))
                    {
                        clbAuthors.SetItemChecked(i, true);
                    }
                }
            }

            if (book.Genres != null)
            {
                for (int i = 0; i < clbGenres.Items.Count; i++)
                {
                    var generoDaLista = (Genre)clbGenres.Items[i];
                    if (book.Genres.Any(g => g.Id == generoDaLista.Id))
                    {
                        clbGenres.SetItemChecked(i, true);
                    }
                }
            }
            cbStatus.Enabled = false;
        }

        private void btnNewAuthor_Click(object sender, EventArgs e)
        {
            var form = new AuthorForm(_authorService);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
                var authors = (List<Author>)clbAuthors.DataSource;
                var newAuthor = authors.OrderByDescending(a => a.Id).FirstOrDefault();
                if (newAuthor != null)
                {
                    int index = clbAuthors.Items.IndexOf(newAuthor);
                    if (index >= 0) clbAuthors.SetItemChecked(index, true);
                }
            }
        }

        private void FormToObject(Book book)
        {
            book.Title = txtTitle.Text;

            if (int.TryParse(txtPages.Text, out int pages))
                book.Pages = pages;

            if (int.TryParse(txtYear.Text, out int year))
                book.PublicationYear = year;

            book.Genres = new List<Genre>();
            book.Authors = new List<Author>();
            foreach (Genre item in clbGenres.CheckedItems)
            {
                book.Genres.Add(item);
            }

            foreach (Author item in clbAuthors.CheckedItems)
            {
                book.Authors.Add(item);
            }
        }

        protected override void Save()
        {
            try
            {
                if (UserSession.CurrentUser == null)
                {
                    MessageBox.Show("You need to be logged in to save a book.");
                    return;
                }

                Book book;
                bool isNewBook = false;

                if (IsEditMode)
                {
                    int id = int.Parse(txtId.Text);
                    // Busca o livro usando o serviço atual
                    book = _bookService.GetById<Book>(id);
                }
                else
                {
                    book = new Book();
                    isNewBook = true;
                }

                // Preenche o objeto com os dados da tela (incluindo as listas de Autor/Gênero)
                FormToObject(book);

                // --- CORREÇÃO OBRIGATÓRIA ---
                // Isso avisa ao Serviço que esses Autores/Gêneros JÁ EXISTEM no banco.
                // Sem isso, o sistema tenta criar um novo "Machado de Assis" e dá erro.
                if (book.Authors != null)
                {
                    foreach (var author in book.Authors)
                    {
                        _bookService.AttachObject(author);
                    }
                }

                if (book.Genres != null)
                {
                    foreach (var genre in book.Genres)
                    {
                        _bookService.AttachObject(genre);
                    }
                }
     

                if (IsEditMode)
                    _bookService.Update<Book, Book, BookValidator>(book);
                else
                    _bookService.Add<Book, Book, BookValidator>(book);

                if (isNewBook)
                {
                    var readingProcess = new ReadingProcess
                    {
                        User = UserSession.CurrentUser,
                        Book = book,
                        Status = cbStatus.Text,
                        StartDate = DateTime.Now
                    };

                    if (cbStatus.Text == "Completed")
                    {
                        readingProcess.PagesRead = book.Pages;
                        readingProcess.EndDate = DateTime.Now;
                    }
                    else
                    {
                        readingProcess.PagesRead = 0;
                        readingProcess.EndDate = DateTime.MinValue;
                    }

                    _processService.Add<ReadingProcess, ReadingProcess, ReadingProcessValidator>(readingProcess);
                }

                MessageBox.Show("Book saved successfully!", "Bookly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                // Exibe o erro interno para sabermos a causa exata se falhar de novo
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Error: {msg}", "Bookly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

