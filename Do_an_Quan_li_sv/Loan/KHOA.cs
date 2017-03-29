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
    public partial class KHOA : Form
    {
        public KHOA()
        {
            InitializeComponent();
        }
        //tạo một kết nối
        SqlConnection con = ConnectDataBase.sqlConnect();
        //chúng ta viết hàm kết nối
        private void ketnoiKHOA()
        {
            //mở kết nối
            con.Open();
            //tạo chuỗi kết nối
            string sql = "select * from KHOA2";//lấy dữ liệu trog bảng KHOA
            SqlCommand com = new SqlCommand(sql, con);//truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//vận chuyển dữ liệu về
            DataTable dt = new DataTable();//tạo 1 kho ảo để lưu trữ dữ liệu
            da.Fill(dt);//đỗ dữ liệu vào kho

            //đóng kết nối
            con.Close();
            //đỗ dữ liệu vào DataGridview
            dataGridView1.DataSource = dt;
            //xem

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ketnoiKHOA();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
