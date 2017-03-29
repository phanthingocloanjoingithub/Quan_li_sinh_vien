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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //tạo một kết nối
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RE9N901\SQLEXPRESS;Integrated Security=True");
        //chúng ta viết hàm kết nối
        
        private void ketnoiCSDL()
        {
            //chúng ta mở kết nối
            con.Open();
            //tạo chuối kết  nối
            string sql = "select * from MONHOC2";//lấy hết dữ liệu trong bảng MONHOC2
            SqlCommand com = new SqlCommand(sql, con);//chúng ta bắt đầu truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//vận chuyển dữ liệu về
            DataTable dt = new DataTable();
            //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);//đổ dữ liệu vào kho

            //đóng kết nối
            con.Close();
            //ta đổ dữ liệu vào DataGridView
            dataGridView1.DataSource = dt;
            //chúng ta xem
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gọi hàm ketnoi() ở trên xuống
            ketnoiCSDL();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
