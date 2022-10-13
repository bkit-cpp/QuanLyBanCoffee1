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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
        }

        private void btnaccount_Click(object sender, EventArgs e)
        {
            Account ac = new Account();
            ac.Show();
            this.Hide();
        }

        private void btnNV_Click(object sender, EventArgs e)
        {
            NhanVien NV = new NhanVien();
            NV.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NhaCC ncc = new NhaCC();
                ncc.Show();
            this.Hide();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            SANPHAM sp = new SANPHAM();
            sp.Show();
            this.Hide();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            DONHANG dh = new DONHANG();
            dh.Show();
            this.Hide();
        }

        private void btnStatiistic_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KHACHHANG kh = new KHACHHANG();
            kh.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }
    }
}
