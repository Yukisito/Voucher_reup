using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SqlConnectionData
    {
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=YUU;Initial Catalog=QuantiteaDB;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon); // Khởi tạo connect
            return conn;
        }
    }
    
    public class DatabaseAccess
    {
        
    }
}
