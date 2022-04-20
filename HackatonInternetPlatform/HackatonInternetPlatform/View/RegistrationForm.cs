using HackatonInternetPlatform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatonInternetPlatform.View
{
    public partial class RegistrationForm : Form
    {
        public event Action<string, string, string, string, string> AddingPurchaser;
        public event Action<string, string, string, string, string> AddingSupplier;

        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegistrationFormRagistration_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string surname = textBoxSurname.Text;
            string secondName = textBoxSecondName.Text;
            string fullName = textBoxSurname.Text + " " + textBoxName.Text + " " + textBoxSecondName.Text;
            string contactData = textBoxContactData.Text;
            string legalInformation = textBoxLegalInformation.Text;
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string confrimPassword = textBoxConfrimPassword.Text;

            if (string.IsNullOrWhiteSpace(name) == false && string.IsNullOrWhiteSpace(surname) == false
                && string.IsNullOrWhiteSpace(contactData) == false && string.IsNullOrWhiteSpace(secondName) == false
                && string.IsNullOrWhiteSpace(legalInformation) == false && string.IsNullOrWhiteSpace(login) == false
                && string.IsNullOrWhiteSpace(password) == false)
            {
                if (password == confrimPassword)
                {
                    if (radioButtonSupplier.Checked)
                    {
                        AddingSupplier?.Invoke(fullName, contactData, legalInformation, login, password);
                    }
                    else if (radioButtonPurchaser.Checked)
                    {
                        AddingPurchaser?.Invoke(fullName, contactData, legalInformation, login, password);
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            else
            {
                MessageBox.Show("Поля не должны быть пустыми!");
                return;
            }
        }
    }
}
