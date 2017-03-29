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
    public partial class SINHVIEN : Form
    {
        public SINHVIEN()
        {
            InitializeComponent();
        }
        //tạo một kết nối
        SqlConnection con = ConnectDataBase.sqlConnect();
        //viết hàm kết nối
        private void ketnoiSINHVIEN()
        {
            //chúng ta mở kết nối
            
            //tạo chuỗi kết nối
            string sql = "select MASV, MALP,TENSV, DIACHI,GIOITINH,NGAYSINH,SDT FROM SV2";
            SqlCommand com = new SqlCommand(sql, con);//bắt đầu truy vấn
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com);//vận chuyển dữ liệu về
            DataTable dt = new DataTable();
            //tạo kho ảo để lưu trữ dữ liệu
            da.Fill(dt);//đỗ dữ liệu vào kho

            //đóng kết nối
            
            //ta đỗ dữ liệu vào DataGridview
            dsSinhVien.DataSource = dt;
            //xem

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SINHVIEN_Load(object sender, EventArgs e)
        {
            con.Open();
            //gọi hàm kết nối ở trên xuống
            ketnoiSINHVIEN();
        }
        public void loadToTextBox()
        {
            txtMaSV.DataBindings.Clear();
            txtMaSV.DataBindings.Add("Text", dsSinhVien.DataSource, "MASV");
            txtMaLp.DataBindings.Clear();
            txtMaLp.DataBindings.Add("Text", dsSinhVien.DataSource, "MALP");
            txtTenSv.DataBindings.Clear();
            txtTenSv.DataBindings.Add("Text", dsSinhVien.DataSource, "TENSV");
            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", dsSinhVien.DataSource, "DIACHI");
            cbogioitinh.DataBindings.Clear();
            cbogioitinh.DataBindings.Add("Text", dsSinhVien.DataSource, "GIOITINH");
            dtmNgaySinh.DataBindings.Clear();
            dtmNgaySinh.DataBindings.Add("Text", dsSinhVien.DataSource, "NGAYSINH");
            txtSDT.DataBindings.Clear();
            txtSDT.DataBindings.Add("Text", dsSinhVien.DataSource, "SDT");
            //ketnoiSINHVIEN();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO SV2 values (@MASV, @MALP, @TENSV, @DIACHI, @GIOITINH, @NGAYSINH, @SDT)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MASV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("MALP", txtMaLp.Text);
                cmd.Parameters.AddWithValue("TENSV", txtTenSv.Text);
                cmd.Parameters.AddWithValue("DIACHI", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("GIOITINH", cbogioitinh.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", dtmNgaySinh.Value);
                cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
                cmd.ExecuteNonQuery();//
                ketnoiSINHVIEN();
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SINHVIEN_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update SV2 set MALP=@MALP, TENSV=@TENSV,DIACHI=@DIACHI ,GIOITINH=@GIOITINH, NGAYSINH=@NGAYSINH,SDT=@SDT where MASV=@MASV";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MASV", txtMaSV.Text);
                cmd.Parameters.AddWithValue("MALP", txtMaLp.Text);
                cmd.Parameters.AddWithValue("TENSV", txtTenSv.Text);
                cmd.Parameters.AddWithValue("DIACHI", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("GIOITINH", cbogioitinh.Text);
                cmd.Parameters.AddWithValue("NGAYSINH", dtmNgaySinh.Value);
                cmd.Parameters.AddWithValue("SDT", txtSDT.Text);
                cmd.ExecuteNonQuery();
                ketnoiSINHVIEN();
                MessageBox.Show("Sửa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from SV2 where MASV=@MASV";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("MASV", txtMaSV.Text);
                cmd.ExecuteNonQuery();
                ketnoiSINHVIEN();
                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dsSinhVien_SelectionChanged(object sender, EventArgs e)
        {
            loadToTextBox();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
            QUANLY ql = new QUANLY();
            
        }

       

     
    }
}
