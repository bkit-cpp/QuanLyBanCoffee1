using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;
namespace QuanLyBanCoffee1
{
    public partial class KHACHHANG : Form
    {
        BUS.KhachHangBUS khbus;
    
        public KHACHHANG()
        {
            InitializeComponent();
            khbus = new BUS.KhachHangBUS();
        }
        public void showallKH()
        {
            System.Data.DataTable dt = khbus.getdsKh();
            dtgvKhachhang.DataSource = dt;
        
            
               
                FileStream filestream = new FileStream("BK.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(filestream);
                for (int i = 0; i < dtgvKhachhang.Rows.Count-1; i++)
                {
                    for (int j = 0; j < dtgvKhachhang.Columns.Count; j++)
                    {
                        sw.Write(dtgvKhachhang.Rows[i].Cells[j].Value);
                    }
                    sw.WriteLine();
                }
                sw.Close();
                filestream.Close();
            
           
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        /* public bool checkdata()
         {

             if (string.IsNullOrEmpty(txtTenKH.Text))
             {
                 MessageBox.Show("Du lieu khong duoc de trong", "NoTice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return false;
             }
             else if (string.IsNullOrEmpty(txtIDKH.Text))
             {
                 MessageBox.Show("Du lieu khong duoc de trong", "NoTice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return false;
             }
             else if (string.IsNullOrEmpty(txtDiaChi.Text))
             {
                 MessageBox.Show("Du lieu khong duoc de trong", "NoTice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 return false;
             }
             else if (string.IsNullOrEmpty(txtPhone.Text))
             {
                 MessageBox.Show("Du lieu khong duoc de trong", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     return false;
             }

             return true;
         }
        */
        public void Reset()
        {
            txtIDKH.Texts = "";
            txtTenKH.Texts = "";
            txtDiaChi.Texts = "";
            txtPhone.Texts = "";
           
            
        }
        private void vbButton1_Click(object sender, EventArgs e)
        {
            DTO.KHACHHANGDTO kh = new DTO.KHACHHANGDTO();
            if (txtIDKH.Texts == "" || txtTenKH.Texts == "" || dtpBirth.Value.ToShortDateString()== "" || txtDiaChi.Texts == "" || txtPhone.Texts == "")
            {
                btnADD.Enabled = false;
                btnADD.Enabled = true;
            }
            else
            {
                kh.IDKH = txtIDKH.Texts;
                kh.tenKH = txtTenKH.Texts;
                kh.NgaySinh = dtpBirth.Value;
                kh.DiaChi = txtDiaChi.Texts;
                kh.Phone = txtPhone.Texts;
                kh.GioiTinh = (radNam.Checked ? radNam.Text : radNu.Text);
                if (khbus.ThemKH(kh))
                {
                    showallKH();

                    Reset();
                }
                else
                {
                    MessageBox.Show("Da Co Loi Xay Ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
              
            }
        }

        

        private void dtgvKhachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KHACHHANG_Load(object sender, EventArgs e)
        {
            showallKH();
        }

        private void cusTomTextBox1__TextChanged(object sender, EventArgs e)
        {
            
        }

        private void vbButton1_Click_1(object sender, EventArgs e)
        {
            TrangChu tc = new TrangChu();
            tc.Show();
            
            this.Hide();
        }

        private void btnDELETE_Click(object sender, EventArgs e)
        {
            
            DTO.KHACHHANGDTO KH = new DTO.KHACHHANGDTO();
            KH.IDKH = txtIDKH.Texts;
            if(khbus.XoaKH(KH))
            {
                showallKH();
            }
            else
            {
                MessageBox.Show("Da co loi xay ra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
