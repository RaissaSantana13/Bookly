using Bookly.Domain.Base;
using Bookly.Domain.Entities;
using Bookly.Service.Validators;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace Bookly.App.Register
{
    public partial class RegisterUserForm : LostForm
    {
        private readonly IBaseService<User> _userService;

        public RegisterUserForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var user = new User();
                FormToObject(user);
                _userService.Add<User, User, UserValidator>(user);
                ClearFields();
                MessageBox.Show("Usuário registado com sucesso! Faça login para continuar.", "Bookly", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Bookly", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormToObject(User user)
        {
            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Password = txtPassword.Text;
            user.RegistrationDate = DateTime.Now;
        }

        private void ClearFields()
        {
            foreach (var control in this.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                {
                    textBox.Clear();
                }
            }
        }
    }
}
