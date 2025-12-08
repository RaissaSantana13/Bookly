using Bookly.App.Infra;
using Bookly.App.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;


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
            var form = ConfigureDI.serviceProvider!.GetService<RegisterUserForm>();
            form.ShowDialog();
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            var loginForm = ConfigureDI.serviceProvider!.GetService<LoginForm>();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
