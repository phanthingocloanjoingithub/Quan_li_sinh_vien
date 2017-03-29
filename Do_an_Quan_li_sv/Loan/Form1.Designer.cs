namespace Loan
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMAMH = new System.Windows.Forms.TextBox();
            this.txtTENMH = new System.Windows.Forms.TextBox();
            this.txtTENGV = new System.Windows.Forms.TextBox();
            this.cboSOTC = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdthem = new System.Windows.Forms.Button();
            this.cmdxoa = new System.Windows.Forms.Button();
            this.cmdsua = new System.Windows.Forms.Button();
            this.cmdthoat = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAMH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "TENMH";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOTC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "TENGV";
            // 
            // txtMAMH
            // 
            this.txtMAMH.Location = new System.Drawing.Point(138, 52);
            this.txtMAMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtMAMH.Name = "txtMAMH";
            this.txtMAMH.Size = new System.Drawing.Size(180, 26);
            this.txtMAMH.TabIndex = 4;
            // 
            // txtTENMH
            // 
            this.txtTENMH.Location = new System.Drawing.Point(138, 97);
            this.txtTENMH.Margin = new System.Windows.Forms.Padding(4);
            this.txtTENMH.Name = "txtTENMH";
            this.txtTENMH.Size = new System.Drawing.Size(180, 26);
            this.txtTENMH.TabIndex = 5;
            // 
            // txtTENGV
            // 
            this.txtTENGV.Location = new System.Drawing.Point(138, 166);
            this.txtTENGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtTENGV.Name = "txtTENGV";
            this.txtTENGV.Size = new System.Drawing.Size(180, 26);
            this.txtTENGV.TabIndex = 6;
            // 
            // cboSOTC
            // 
            this.cboSOTC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSOTC.FormattingEnabled = true;
            this.cboSOTC.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboSOTC.Location = new System.Drawing.Point(138, 131);
            this.cboSOTC.Margin = new System.Windows.Forms.Padding(4);
            this.cboSOTC.Name = "cboSOTC";
            this.cboSOTC.Size = new System.Drawing.Size(180, 27);
            this.cboSOTC.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMH,
            this.TENMH,
            this.SOTC,
            this.TENGV});
            this.dataGridView1.Location = new System.Drawing.Point(33, 290);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(930, 164);
            this.dataGridView1.TabIndex = 8;
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "TENMH";
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // SOTC
            // 
            this.SOTC.DataPropertyName = "SOTC";
            this.SOTC.HeaderText = "SOTC";
            this.SOTC.Name = "SOTC";
            this.SOTC.ReadOnly = true;
            // 
            // TENGV
            // 
            this.TENGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENGV.DataPropertyName = "TENGV";
            this.TENGV.HeaderText = "TENGV";
            this.TENGV.Name = "TENGV";
            this.TENGV.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSOTC);
            this.groupBox1.Controls.Add(this.txtTENGV);
            this.groupBox1.Controls.Add(this.txtTENMH);
            this.groupBox1.Controls.Add(this.txtMAMH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(58, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 208);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // cmdthem
            // 
            this.cmdthem.Location = new System.Drawing.Point(16, 42);
            this.cmdthem.Name = "cmdthem";
            this.cmdthem.Size = new System.Drawing.Size(75, 36);
            this.cmdthem.TabIndex = 10;
            this.cmdthem.Text = "Thêm";
            this.cmdthem.UseVisualStyleBackColor = true;
            // 
            // cmdxoa
            // 
            this.cmdxoa.Location = new System.Drawing.Point(148, 42);
            this.cmdxoa.Name = "cmdxoa";
            this.cmdxoa.Size = new System.Drawing.Size(75, 34);
            this.cmdxoa.TabIndex = 11;
            this.cmdxoa.Text = "Xóa";
            this.cmdxoa.UseVisualStyleBackColor = true;
            // 
            // cmdsua
            // 
            this.cmdsua.Location = new System.Drawing.Point(16, 109);
            this.cmdsua.Name = "cmdsua";
            this.cmdsua.Size = new System.Drawing.Size(75, 35);
            this.cmdsua.TabIndex = 12;
            this.cmdsua.Text = "Sửa";
            this.cmdsua.UseVisualStyleBackColor = true;
            this.cmdsua.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdthoat
            // 
            this.cmdthoat.Location = new System.Drawing.Point(148, 109);
            this.cmdthoat.Name = "cmdthoat";
            this.cmdthoat.Size = new System.Drawing.Size(75, 36);
            this.cmdthoat.TabIndex = 13;
            this.cmdthoat.Text = "Thoát";
            this.cmdthoat.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdthoat);
            this.groupBox2.Controls.Add(this.cmdsua);
            this.groupBox2.Controls.Add(this.cmdxoa);
            this.groupBox2.Controls.Add(this.cmdthem);
            this.groupBox2.Location = new System.Drawing.Point(455, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 173);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(235, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cập Nhật Sinh Viên";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Nhập Danh Sách Các Môn Học";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMAMH;
        private System.Windows.Forms.TextBox txtTENMH;
        private System.Windows.Forms.TextBox txtTENGV;
        private System.Windows.Forms.ComboBox cboSOTC;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOTC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENGV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdthem;
        private System.Windows.Forms.Button cmdxoa;
        private System.Windows.Forms.Button cmdsua;
        private System.Windows.Forms.Button cmdthoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
    }
}

