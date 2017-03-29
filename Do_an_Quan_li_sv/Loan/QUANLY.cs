using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan
{
    public partial class QUANLY : Form
    {
        public QUANLY()
        {
            InitializeComponent();
        }

        private void QUANLY_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            SINHVIEN sv = new SINHVIEN();
            sv.Show();
            
        }
    }
}
