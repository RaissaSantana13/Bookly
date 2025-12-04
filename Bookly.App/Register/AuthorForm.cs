using Bookly.App.Base;
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
    public partial class AuthorForm : BaseForm
    {
        private readonly IBaseService<Author> _authorService;

        public AuthorForm(IBaseService<Author> authorService)
        {
            _authorService = authorService;
            InitializeComponent();
        }

        private void FormToObject(Author author)
        {
            author.Name = txtName.Text;
        }

        protected override void Save()
        {
            try
            {
                if (IsEditMode)
                {
                    int id = int.Parse(txtId.Text);
                    var author = _authorService.GetById<Author>(id);
                    FormToObject(author);
                    _authorService.Update<Author, Author, AuthorValidator>(author);
                }
                else
                {
                    var author = new Author();
                    FormToObject(author);
                    _authorService.Add<Author, Author, AuthorValidator>(author);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Bookly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
