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
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void buttonRegistrationFormRagistration_Click(object sender, EventArgs e)
        {
            if (radioButtonPurchaser.Checked)
            {
                if (textBoxPassword.Text == textBoxConfrimPassword.Text)
                {
                    List<Purchaser> purchasers = new List<Purchaser>();
                    //purchasers.Add(new Purchaser(textBoxSurname.Text + " " + textBoxName.Text + " " + textBoxSecondName.Text,
                    //   textBoxContactData.Text, textBoxLegalInformation.Text, textBoxLogin.Text, textBoxPassword.Text, new List<Request>()));
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
            if (radioButtonSupplier.Checked)
            {
                if (textBoxPassword.Text == textBoxConfrimPassword.Text)
                {
                    List<Supplier> suppliers = new List<Supplier>();
                    suppliers.Add(new Supplier(textBoxSurname.Text + " " + textBoxName.Text + " " + textBoxSecondName.Text,
                        textBoxContactData.Text, textBoxLegalInformation.Text, textBoxLogin.Text, textBoxPassword.Text, new List<SupplyOffer>()));
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!");
                }
            }
        }
    }
}
