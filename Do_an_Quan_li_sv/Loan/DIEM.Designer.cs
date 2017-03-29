namespace Loan
{
    partial class DIEM2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DIEM2));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmasv = new System.Windows.Forms.TextBox();
            this.txtmamh = new System.Windows.Forms.TextBox();
            this.txtdiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã sinh viên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã môn học:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm:";
            // 
            // txtmasv
            // 
            this.txtmasv.Location = new System.Drawing.Point(112, 24);
            this.txtmasv.Name = "txtmasv";
            this.txtmasv.Size = new System.Drawing.Size(196, 26);
            this.txtmasv.TabIndex = 4;
            // 
            // txtmamh
            // 
            this.txtmamh.Location = new System.Drawing.Point(112, 65);
            this.txtmamh.Name = "txtmamh";
            this.txtmamh.Size = new System.Drawing.Size(196, 26);
            this.txtmamh.TabIndex = 5;
            // 
            // txtdiem
            // 
            this.txtdiem.Location = new System.Drawing.Point(112, 106);
            this.txtdiem.Name = "txtdiem";
            this.txtdiem.Size = new System.Drawing.Size(196, 26);
            this.txtdiem.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdiem);
            this.groupBox1.Controls.Add(this.txtmamh);
            this.groupBox1.Controls.Add(this.txtmasv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(42, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 154);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thêm";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 96);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 45);
            this.button2.TabIndex = 9;
            this.button2.Text = "Sửa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(238, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 45);
            this.button3.TabIndex = 10;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(238, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(67, 45);
            this.button4.TabIndex = 11;
            this.button4.Text = "Thoát";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(121, 79);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(103, 44);
            this.button5.TabIndex = 12;
            this.button5.Text = "Tìm kiếm";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(381, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 175);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASV,
            this.MAMH,
            this.DIEM});
            this.dataGridView1.Location = new System.Drawing.Point(164, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(452, 169);
            this.dataGridView1.TabIndex = 14;
            // 
            // MASV
            // 
            this.MASV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "MASV";
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // MAMH
            // 
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "MAMH";
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            // 
            // DIEM
            // 
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "DIEM";
            this.DIEM.Name = "DIEM";
            this.DIEM.ReadOnly = true;
            // 
            // DIEM2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 462);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DIEM2";
            this.Text = "Điểm Sinh Viên";
            this.Load += new System.EventHandler(this.DIEM2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmasv;
        private System.Windows.Forms.TextBox txtmamh;
        private System.Windows.Forms.TextBox txtdiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
    }
}