using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanCoffee1.DAO
{
    class DATAConnection
    {
        string conn = null;
        public DATAConnection()
        {
            conn = "Data Source=DESKTOP-UOLK6O3\\SQLEXPRESS01;Initial Catalog=QuanLyCoffee;Integrated Security=True";
        }
        public SqlConnection getconnect()
        {
            return new SqlConnection(conn);
        }
    }
}
