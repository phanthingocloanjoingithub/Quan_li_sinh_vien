namespace Loan
{
    partial class SINHVIEN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SINHVIEN));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtMaLp = new System.Windows.Forms.TextBox();
            this.txtTenSv = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbogioitinh = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dsSinhVien = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(119, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(547, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT DANH SÁCH SINH VIÊN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(23, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "MALP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "TENSV";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "DIACHI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "GIOITINH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "NGAYSINH";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "SDT";
            // 
            // txtMaSV
            // 
            this.txtMaSV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaSV.Location = new System.Drawing.Point(126, 21);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(200, 26);
            this.txtMaSV.TabIndex = 8;
            this.txtMaSV.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMaLp
            // 
            this.txtMaLp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMaLp.Location = new System.Drawing.Point(126, 53);
            this.txtMaLp.Name = "txtMaLp";
            this.txtMaLp.Size = new System.Drawing.Size(200, 26);
            this.txtMaLp.TabIndex = 9;
            // 
            // txtTenSv
            // 
            this.txtTenSv.Location = new System.Drawing.Point(126, 85);
            this.txtTenSv.Name = "txtTenSv";
            this.txtTenSv.Size = new System.Drawing.Size(200, 26);
            this.txtTenSv.TabIndex = 10;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(126, 117);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(200, 26);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(126, 217);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(200, 26);
            this.txtSDT.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmNgaySinh);
            this.groupBox1.Controls.Add(this.cbogioitinh);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenSv);
            this.groupBox1.Controls.Add(this.txtMaLp);
            this.groupBox1.Controls.Add(this.txtMaSV);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 254);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.Location = new System.Drawing.Point(126, 182);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(200, 26);
            this.dtmNgaySinh.TabIndex = 16;
            // 
            // cbogioitinh
            // 
            this.cbogioitinh.FormattingEnabled = true;
            this.cbogioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbogioitinh.Location = new System.Drawing.Point(126, 149);
            this.cbogioitinh.Name = "cbogioitinh";
            this.cbogioitinh.Size = new System.Drawing.Size(200, 27);
            this.cbogioitinh.TabIndex = 15;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(9, 31);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 34);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(9, 127);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 50);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(100, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 49);
            this.button3.TabIndex = 18;
            this.button3.Text = "Tìm kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(236, 31);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 50);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(236, 128);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 50);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(420, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 196);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // dsSinhVien
            // 
            this.dsSinhVien.AllowUserToAddRows = false;
            this.dsSinhVien.AllowUserToDeleteRows = false;
            this.dsSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.MALP,
            this.TENSV,
            this.DIACHI,
            this.GIOITINH,
            this.NGAYSINH,
            this.SDT});
            this.dsSinhVien.Location = new System.Drawing.Point(-1, 317);
            this.dsSinhVien.Name = "dsSinhVien";
            this.dsSinhVien.ReadOnly = true;
            this.dsSinhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dsSinhVien.Size = new System.Drawing.Size(905, 195);
            this.dsSinhVien.TabIndex = 22;
            this.dsSinhVien.SelectionChanged += new System.EventHandler(this.dsSinhVien_SelectionChanged);
            // 
            // MASV
            // 
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "MASV";
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // MALP
            // 
            this.MALP.DataPropertyName = "MALP";
            this.MALP.HeaderText = "MALP";
            this.MALP.Name = "MALP";
            this.MALP.ReadOnly = true;
            // 
            // TENSV
            // 
            this.TENSV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENSV.DataPropertyName = "TENSV";
            this.TENSV.HeaderText = "TENSV";
            this.TENSV.Name = "TENSV";
            this.TENSV.ReadOnly = true;
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "DIACHI";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "GIOITINH";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "NGAYSINH";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SDT";
            this.SDT.Name = "SDT";
            this.SDT.ReadOnly = true;
            // 
            // SINHVIEN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 497);
            this.Controls.Add(this.dsSinhVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SINHVIEN";
            this.Text = "Danh sách sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SINHVIEN_FormClosing);
            this.Load += new System.EventHandler(this.SINHVIEN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dsSinhVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TextBox txtMaLp;
        private System.Windows.Forms.TextBox txtTenSv;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.ComboBox cbogioitinh;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dsSinhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}