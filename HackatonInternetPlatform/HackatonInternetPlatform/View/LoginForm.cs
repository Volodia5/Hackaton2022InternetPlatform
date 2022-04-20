using HackatonInternetPlatform.View;

namespace HackatonInternetPlatform
{
    public partial class LoginForm : Form
    {
        public event Action OpeningRegisterForm;
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

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            OpeningRegisterForm?.Invoke();
        }
    }
}