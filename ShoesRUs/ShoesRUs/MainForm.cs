using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ShoesRUs
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Startup su = new Startup();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            grpLogin.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            grpRegister.Visible = true;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {

        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            grpContact.Visible = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            grpProfile.Visible = true;
        }

        private void btnBasket_Click(object sender, EventArgs e)
        {
            grpBasket.Visible = true;
        }

        

    }
}
