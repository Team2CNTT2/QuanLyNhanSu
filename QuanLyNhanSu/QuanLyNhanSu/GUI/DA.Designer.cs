namespace QuanLyNhanSu.GUI
{
    partial class DA
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvda = new System.Windows.Forms.DataGridView();
            this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbDD = new System.Windows.Forms.TextBox();
            this.tbMaPB = new System.Windows.Forms.TextBox();
            this.tbTenDA = new System.Windows.Forms.TextBox();
            this.tbMaDA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnchapnhan = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.lbda = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvda)).BeginInit();
            this.SuspendLayout();
            // 
            // DiaDiem
            // 
            this.DiaDiem.DataPropertyName = "DiaDiem";
            this.DiaDiem.HeaderText = "Địa Điểm";
            this.DiaDiem.Name = "DiaDiem";
            this.DiaDiem.ReadOnly = true;
            // 
            // TenDA
            // 
            this.TenDA.DataPropertyName = "TenDA";
            this.TenDA.HeaderText = "Tên Dự Án";
            this.TenDA.Name = "TenDA";
            this.TenDA.ReadOnly = true;
            // 
            // MaDA
            // 
            this.MaDA.DataPropertyName = "MaDA";
            this.MaDA.HeaderText = "Mã Dự Án";
            this.MaDA.Name = "MaDA";
            this.MaDA.ReadOnly = true;
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
            this.dtgvda.Location = new System.Drawing.Point(150, 328);
            this.dtgvda.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvda.Name = "dtgvda";
            this.dtgvda.ReadOnly = true;
            this.dtgvda.Size = new System.Drawing.Size(596, 220);
            this.dtgvda.TabIndex = 34;
            // 
            // MaPB
            // 
            this.MaPB.DataPropertyName = "MaPB";
            this.MaPB.HeaderText = "Mã Phòng Ban";
            this.MaPB.Name = "MaPB";
            this.MaPB.ReadOnly = true;
            // 
            // tbDD
            // 
            this.tbDD.Location = new System.Drawing.Point(795, 214);
            this.tbDD.Margin = new System.Windows.Forms.Padding(4);
            this.tbDD.Name = "tbDD";
            this.tbDD.Size = new System.Drawing.Size(132, 22);
            this.tbDD.TabIndex = 33;
            // 
            // tbMaPB
            // 
            this.tbMaPB.Location = new System.Drawing.Point(795, 175);
            this.tbMaPB.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaPB.Name = "tbMaPB";
            this.tbMaPB.Size = new System.Drawing.Size(132, 22);
            this.tbMaPB.TabIndex = 32;
            // 
            // tbTenDA
            // 
            this.tbTenDA.Location = new System.Drawing.Point(795, 139);
            this.tbTenDA.Margin = new System.Windows.Forms.Padding(4);
            this.tbTenDA.Name = "tbTenDA";
            this.tbTenDA.Size = new System.Drawing.Size(132, 22);
            this.tbTenDA.TabIndex = 31;
            // 
            // tbMaDA
            // 
            this.tbMaDA.Location = new System.Drawing.Point(795, 97);
            this.tbMaDA.Margin = new System.Windows.Forms.Padding(4);
            this.tbMaDA.Name = "tbMaDA";
            this.tbMaDA.Size = new System.Drawing.Size(132, 22);
            this.tbMaDA.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(643, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 29;
            this.label6.Text = "Địa Điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(642, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã Phòng Ban";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tên Dự Án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã Dự Án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(642, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 26);
            this.label2.TabIndex = 25;
            this.label2.Text = "Thông Tin Dự Án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 29);
            this.label1.TabIndex = 24;
            this.label1.Text = "Danh sách phòng ban";
            // 
            // btnhuy
            // 
            this.btnhuy.Location = new System.Drawing.Point(795, 471);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(4);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(100, 28);
            this.btnhuy.TabIndex = 35;
            this.btnhuy.Text = "Hủy";
            // 
            // btnchapnhan
            // 
            this.btnchapnhan.Location = new System.Drawing.Point(795, 436);
            this.btnchapnhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnchapnhan.Name = "btnchapnhan";
            this.btnchapnhan.Size = new System.Drawing.Size(100, 28);
            this.btnchapnhan.TabIndex = 36;
            this.btnchapnhan.Text = "Lưu";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(795, 400);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(100, 28);
            this.btnxoa.TabIndex = 37;
            this.btnxoa.Text = "Xóa";
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(795, 364);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(100, 28);
            this.btnsua.TabIndex = 38;
            this.btnsua.Text = "Sửa";
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(795, 328);
            this.btnthem.Margin = new System.Windows.Forms.Padding(4);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(100, 28);
            this.btnthem.TabIndex = 39;
            this.btnthem.Text = "Thêm";
            // 
            // lbda
            // 
            this.lbda.FormattingEnabled = true;
            this.lbda.ItemHeight = 16;
            this.lbda.Location = new System.Drawing.Point(184, 120);
            this.lbda.Margin = new System.Windows.Forms.Padding(4);
            this.lbda.Name = "lbda";
            this.lbda.Size = new System.Drawing.Size(283, 164);
            this.lbda.TabIndex = 23;
            // 
            // DA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "DA";
            this.Size = new System.Drawing.Size(1077, 613);
            this.Load += new System.EventHandler(this.DA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDA;
        private System.Windows.Forms.DataGridView dtgvda;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
        private System.Windows.Forms.TextBox tbDD;
        private System.Windows.Forms.TextBox tbMaPB;
        private System.Windows.Forms.TextBox tbTenDA;
        private System.Windows.Forms.TextBox tbMaDA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnchapnhan;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.ListBox lbda;
    }
}
