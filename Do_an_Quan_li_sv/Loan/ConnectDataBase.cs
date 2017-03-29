using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Loan
{
    class ConnectDataBase
    {

        public static SqlConnection sqlConnect()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RE9N901\SQLEXPRESS;Integrated Security=True");
            return con;

        }
    }

}
