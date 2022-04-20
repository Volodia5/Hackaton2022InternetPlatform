using System;
using System.Windows.Forms;

namespace HackatonInternetPlatform
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonVisiblePassword_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.PasswordChar == default)
            {
                textBoxPassword.PasswordChar = '*';
                return;
            }

            if (textBoxPassword.PasswordChar == '*')
            {
                textBoxPassword.PasswordChar = default;
            }
        }
    }
}