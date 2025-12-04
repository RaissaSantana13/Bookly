using ReaLTaiizor.Forms;
using ReaLTaiizor.Controls; 
using System;
using System.Windows.Forms;

namespace Bookly.App.Base
{
    public partial class BaseForm : LostForm
    {
        protected bool IsEditMode = false;

        public BaseForm()
        {
            InitializeComponent();
        }

        #region Events

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar?", "Bookly", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearFields();
                this.Close();
            }
        }
        #endregion

        #region Vitual Methods
        protected virtual void Save()
        {
           
        }

        protected virtual void ClearFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
        }

        #endregion
    }
}