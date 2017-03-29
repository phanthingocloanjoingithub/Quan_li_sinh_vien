using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Loan
{
    public partial class LOP : Form
    {
        public LOP()
        {
            InitializeComponent();
        }
        //tạo kết nối
        SqlConnection con = ConnectDataBase.sqlConnect();
        //chúng ta viết hàm kết nối
        private void ketnoiLOP()
        {
            //chúng ta mở kết nối
            con.Open();
            //tạo 1 chuỗi kết nối
            string sql= "select * from LOP2";//lấy hết dữ liệu trong bảng LOP2
            SqlCommand com = new SqlCommand(sql, con);//chúng ta bắtđầu truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//vạn chuyển dữ liệu về
            DataTable dt = new DataTable();
            //tạo 1 kho ảo để lưu trữ dữ liệu
            da.Fill(dt);//đỗ dữ liệu vào kho

            //đóng kết nối
            con.Close();
            //ta đỗ dữ liệu vào DataGridview
            dataGridView1.DataSource = dt;
        }

      

        private void btnxoa_Click(object sender, EventArgs e)
        {

        }

        private void LOP_Load(object sender, EventArgs e)
        {
            //gọi hàm ketnoiLOP() ở trên xuống
            ketnoiLOP();
        }
    }
}
