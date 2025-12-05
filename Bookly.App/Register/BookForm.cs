using Bookly.App.Base;
using Bookly.App.Others;
using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Service.Validators;
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
        public BookForm(IBaseService<Book> bookService,
            IBaseService<Author> authorService,
            IBaseService<Genre> genreService,
            IBaseService<ReadingProcess> processService)
        {
            _bookService = bookService;
            _authorService = authorService;
            _genreService = genreService;
            _processService = processService;
            
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Carrega Gêneros
            var genres = _genreService.Get<Genre>().ToList();
            clbGenres.DataSource = genres;
            clbGenres.DisplayMember = "Name";
            clbGenres.ValueMember = "Id";

            // Carrega Autores
            var authors = _authorService.Get<Author>().OrderBy(a => a.Name).ToList();
            clbAuthors.DataSource = authors;
            clbAuthors.DisplayMember = "Name";
            clbAuthors.ValueMember = "Id";

            // Configura o ComboBox de Status
            cbStatus.Items.Clear();
            cbStatus.Items.Add("Lendo");
            cbStatus.Items.Add("Concluído");
            cbStatus.SelectedIndex = 0; 
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
            foreach (Genre item in clbGenres.CheckedItems) book.Genres.Add(item);

            book.Authors = new List<Author>();
            foreach (Author item in clbAuthors.CheckedItems) book.Authors.Add(item);
        }

        protected override void Save()
        {
            try
            {
                if (UserSession.CurrentUser == null)
                {
                    MessageBox.Show("Você precisa estar logado para salvar um livro.");
                    return;
                }

                Book book;
                bool isNewBook = false;

                if (IsEditMode)
                {
                    int id = int.Parse(txtId.Text);
                    book = _bookService.GetById<Book>(id);
                }
                else
                {
                    book = new Book();
                    isNewBook = true;
                }

                FormToObject(book);

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

                    if (cbStatus.Text == "Concluído")
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

                MessageBox.Show("Livro salvo com sucesso!", "Bookly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Bookly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}

