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
    public partial class PurchaserForm : Form
    {
        public PurchaserForm()
        {
            InitializeComponent();
        }

        private void buttonPurchaserNextPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonPurchaserPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            RequestEditForm view = new RequestEditForm();
            view.ShowDialog();
        }
    }
}
