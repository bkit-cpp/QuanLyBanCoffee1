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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }
        int x;
        private void timer1_Tick(object sender, EventArgs e)
        {
            x = label1.Location.X;
            x--;
            label1.Location = new Point(x, label1.Location.Y);

            if (x == 0)
            {
                NhanVien nv = new NhanVien();
                x = nv.Size.Width;
                label1.Location = new Point(nv.Size.Width, label1.Location.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        int k;
        private void timer2_Tick(object sender, EventArgs e)
        {
            k= pictureBox1.Location.X;
            k--;
            pictureBox1.Location = new Point(k, label1.Location.Y);

            if (k== 0)
            {
                NhanVien nv = new NhanVien();
                k= nv.Size.Width;
                pictureBox1.Location = new Point(nv.Size.Width, pictureBox1.Location.Y);
            }
        }
    }
}
