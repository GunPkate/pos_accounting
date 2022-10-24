using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSAccount
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            tssDate.Text = DateTime.Now.ToString("dddd MMMM yyyy hh:mm:tt");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelLogout.Top = btnLogout.Top;
            panelLogout.Height= btnLogout.Height;
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {

        }

        private void btnSalePay_Click(object sender, EventArgs e)
        {

        }

        private void btnPurchasePay_Click(object sender, EventArgs e)
        {

        }
    }
}
