using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCoffee1.BUS
{
    class KhachHangBUS
    {
        DAO.KHACHHANGDAO khdao;
        public KhachHangBUS()
        {
            khdao = new DAO.KHACHHANGDAO();
        }
        public DataTable getdsKh()
        {
            return khdao.getdsKh();
        }
        public bool ThemKH(DTO.KHACHHANGDTO kh)
        {
            return khdao.ThemKH(kh);
        }
        public bool XoaKH(DTO.KHACHHANGDTO kh)
        {
            return khdao.xoaKH(kh);
        }
        
    }
}
