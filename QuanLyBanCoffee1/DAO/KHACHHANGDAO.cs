using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyBanCoffee1.DAO
{
    class KHACHHANGDAO
    {
        DATAConnection dtc;
        SqlCommand cmd;
        SqlDataAdapter da;
        public KHACHHANGDAO()
        {
            dtc = new DATAConnection();
        }
        public DataTable getdsKh()
        {
            string sql = "SELECT * FROM KhachHang";
            SqlConnection con = dtc.getconnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool ThemKH(DTO.KHACHHANGDTO kh)
        {
          
            string sql = "INSERT INTO dbo.KhachHang(IDKH,tenKH,NgaySinh,DiaChi,Phone,GioiTinh) VALUES(@IDKH,@tenKH,@NgaySinh,@DiaChi,@Phone,@GioiTinh)";
           
            SqlConnection con = dtc.getconnect();
            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDKH", SqlDbType.VarChar).Value = kh.IDKH;
                cmd.Parameters.Add("@tenKH", SqlDbType.VarChar).Value = kh.tenKH;
                cmd.Parameters.Add("@NgaySinh", SqlDbType.VarChar).Value = kh.NgaySinh.ToShortDateString();
                cmd.Parameters.Add("@DiaChi", SqlDbType.VarChar).Value = kh.DiaChi;
                cmd.Parameters.Add("@Phone", SqlDbType.VarChar).Value = kh.Phone;
                cmd.Parameters.Add("@GioiTinh", SqlDbType.VarChar).Value = kh.GioiTinh;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception )

            {
                return false;
            }
            return true;
            }
        public bool xoaKH(DTO.KHACHHANGDTO kh)
        {
            string sql = "DELETE dbo.KhachHang where IDKH=@IDKH";
           
            SqlConnection con = dtc.getconnect();
            try {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@IDKH", SqlDbType.VarChar).Value = kh.IDKH;
                cmd.ExecuteNonQuery();
                con.Close();
            }catch(Exception)
            {
                return false;
            }
            return true;
        }
        }
    }
