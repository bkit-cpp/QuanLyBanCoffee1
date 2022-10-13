using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanCoffee1
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {

        }

        private void cusTomTextBox1__TextChanged(object sender, EventArgs e)
        {
           

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FormLoading fd = new FormLoading();
            if (cusTomTxtusername.Texts == "admin" && cusTomTxtpass.Texts == "1234")
            {
                btnLogin.Enabled = true;
                fd.Show();
                this.Hide();
               
            }
            else
            {
                btnLogin.Enabled = false;
                btnLogin.Enabled = true;
            }
           
           
        }

        private void Loginexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            btnLogin.Enabled = false;
            btnLogin.Enabled = true;
        }
    }
}
