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
    public partial class DIEM2 : Form
    {
        public DIEM2()
        {
            InitializeComponent();
        }
        //tạo một kết nối
        SqlConnection con = ConnectDataBase.sqlConnect();
        //viết hàm kết nối
        private void ketnoiDIEM()
        {
            //mở kết nối
            con.Open();
            //tạo chuỗi kết nối
            string sql = "select * from DIEM2";//lấy dữ liệu trong bảng DIEM2
            SqlCommand com = new SqlCommand(sql, con);//truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//vận chuyển dữ liệu về
            DataTable dt = new DataTable();//tạo 1 kho ảo để lưu trữ dữ liệu
            da.Fill(dt);//đỗ dữ liệu vào kho

            //đóng kết nối
            con.Close();
            //đỗ dữ liệu vào DataGridview
            dataGridView1.DataSource = dt;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DIEM2_Load(object sender, EventArgs e)
        {
            //gọi hàm ketnoiDIEM() ở trên xuống
            ketnoiDIEM();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
