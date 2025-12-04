using Bookly.App.Infra;
using Bookly.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bookly.App.Others
{
    public partial class InitialForm : LostForm
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            ShowForm<RegisterUserForm>();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            ShowForm<LoginForm>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var form = ConfigureDI.serviceProvider!.GetService<TFormulario>();

            if (form != null && !form.IsDisposed)
            {
                this.Hide();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
            }
        }
    }
}
