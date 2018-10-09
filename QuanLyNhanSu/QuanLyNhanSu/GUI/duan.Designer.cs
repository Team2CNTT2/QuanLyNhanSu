namespace QuanLyNhanSu
{
    partial class duan
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
            this.lbda = new System.Windows.Forms.ListBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnchapnhan = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMaDA = new System.Windows.Forms.TextBox();
            this.tbTenDA = new System.Windows.Forms.TextBox();
            this.tbMaPB = new System.Windows.Forms.TextBox();
            this.tbDD = new System.Windows.Forms.TextBox();
            this.dtgvda = new System.Windows.Forms.DataGridView();
            this.MaDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvda)).BeginInit();
            this.SuspendLayout();
            // 
            // lbda
            // 
            this.lbda.FormattingEnabled = true;
            this.lbda.Location = new System.Drawing.Point(31, 67);
            this.lbda.Name = "lbda";
            this.lbda.Size = new System.Drawing.Size(213, 134);
            this.lbda.TabIndex = 0;
            this.lbda.SelectedIndexChanged += new System.EventHandler(this.lbda_SelectedIndexChanged);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(489, 236);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 22;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(489, 265);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 21;
            this.btnsua.Text = "Sửa";
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(489, 294);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 20;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnchapnhan
            // 
            this.btnchapnhan.Location = new System.Drawing.Point(489, 323);
            this.btnchapnhan.Name = "btnchapnhan";
            this.btnchapnhan.Size = new System.Drawing.Size(75, 23);
            this.btnchapnhan.TabIndex = 19;
            this.btnchapnhan.Text = "Lưu";
            this.btnchapnhan.Click += new System.EventHandler(this.btnchapnhan_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(489, 352);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(75, 23);
            this.btnhuy.TabIndex = 18;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách phòng ban";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Thông Tin Dự Án";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã Dự Án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên Dự Án";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Phòng Ban";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa Điểm";
            // 
            // tbMaDA
            // 
            this.tbMaDA.Location = new System.Drawing.Point(489, 48);
            this.tbMaDA.Name = "tbMaDA";
            this.tbMaDA.Size = new System.Drawing.Size(100, 20);
            this.tbMaDA.TabIndex = 13;
            // 
            // tbTenDA
            // 
            this.tbTenDA.Location = new System.Drawing.Point(489, 82);
            this.tbTenDA.Name = "tbTenDA";
            this.tbTenDA.Size = new System.Drawing.Size(100, 20);
            this.tbTenDA.TabIndex = 14;
            // 
            // tbMaPB
            // 
            this.tbMaPB.Location = new System.Drawing.Point(489, 111);
            this.tbMaPB.Name = "tbMaPB";
            this.tbMaPB.Size = new System.Drawing.Size(100, 20);
            this.tbMaPB.TabIndex = 15;
            // 
            // tbDD
            // 
            this.tbDD.Location = new System.Drawing.Point(489, 143);
            this.tbDD.Name = "tbDD";
            this.tbDD.Size = new System.Drawing.Size(100, 20);
            this.tbDD.TabIndex = 16;
            // 
            // dtgvda
            // 
            this.dtgvda.AllowUserToAddRows = false;
            this.dtgvda.AllowUserToDeleteRows = false;
            this.dtgvda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDA,
            this.TenDA,
            this.MaPB,
            this.DiaDiem});
            this.dtgvda.Location = new System.Drawing.Point(5, 236);
            this.dtgvda.Name = "dtgvda";
            this.dtgvda.ReadOnly = true;
            this.dtgvda.Size = new System.Drawing.Size(447, 179);
            this.dtgvda.TabIndex = 17;
            this.dtgvda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvda_CellContentClick);
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            this.MaDA.HeaderText = "Mã Dự Án";
            this.MaDA.Name = "MaDA";
            this.MaDA.ReadOnly = true;
            // 
            // TenDA
            // 
            this.TenDA.DataPropertyName = "TenDA";
            this.TenDA.HeaderText = "Tên Dự Án";
            this.TenDA.Name = "TenDA";
            this.TenDA.ReadOnly = true;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.HeaderText = "Mã Phòng Ban";
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            // 
            // duan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 427);
            this.Controls.Add(this.dtgvda);
            this.Controls.Add(this.tbDD);
            this.Controls.Add(this.tbMaPB);
            this.Controls.Add(this.tbTenDA);
            this.Controls.Add(this.tbMaDA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnchapnhan);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.lbda);
            this.Name = "duan";
            this.Text = "duan";
            this.Load += new System.EventHandler(this.duan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbda;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnchapnhan;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMaDA;
        private System.Windows.Forms.TextBox tbTenDA;
        private System.Windows.Forms.TextBox tbMaPB;
        private System.Windows.Forms.TextBox tbDD;
        private System.Windows.Forms.DataGridView dtgvda;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
    }
}