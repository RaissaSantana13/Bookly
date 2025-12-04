using Bookly.Domain.Base;
using Bookly.Domain.Entities;
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
    public partial class LoginForm : LostForm
    {
        private readonly IBaseService<User> _userService;
        public LoginForm(IBaseService<User> userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? user = GetUser(txtEmail.Text, txtPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Email e/ou senha inválida!", "Bookly", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private User? GetUser(string email, string password)
        {

            var user = _userService.Get<User>().FirstOrDefault(x => x.Email == email);

            if (user == null)
                return null;

            return user.Password != password ? null : user;
        }
    }
}
