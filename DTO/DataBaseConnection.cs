using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DataBaseConnection
    {
        public static SqlConnection Connect()
        {
            string strconn = "Data Source=PHUC\\SQLEXPRESS;Initial Catalog=QLTV_C#;User ID=sa;Password=1;";
            SqlConnection conn = new SqlConnection(strconn);
            return conn;
        }
    }
}
