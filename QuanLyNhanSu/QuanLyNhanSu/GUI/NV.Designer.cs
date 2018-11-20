namespace QuanLyNhanSu.GUI
{
    partial class NV
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
            this.label6 = new System.Windows.Forms.Label();
            this.bntThoat = new System.Windows.Forms.Button();
            this.bntHuy = new System.Windows.Forms.Button();
            this.bntChapNhan = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaPB = new System.Windows.Forms.TextBox();
            this.bntXoa = new System.Windows.Forms.Button();
            this.dtgvpb = new System.Windows.Forms.DataGridView();
            this.tbDT = new System.Windows.Forms.TextBox();
            this.tbNgaySinh = new System.Windows.Forms.TextBox();
            this.tbTenNV = new System.Windows.Forms.TextBox();
            this.tbMaNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdspb = new System.Windows.Forms.ListBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvpb)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label6.Location = new System.Drawing.Point(432, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "Mã PB";
            // 
            // bntThoat
            // 
            this.bntThoat.Location = new System.Drawing.Point(656, 187);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 21);
            this.bntThoat.TabIndex = 37;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // bntHuy
            // 
            this.bntHuy.Location = new System.Drawing.Point(453, 187);
            this.bntHuy.Name = "bntHuy";
            this.bntHuy.Size = new System.Drawing.Size(75, 21);
            this.bntHuy.TabIndex = 35;
            this.bntHuy.Text = "Hủy";
            this.bntHuy.UseVisualStyleBackColor = true;
            this.bntHuy.Click += new System.EventHandler(this.bntHuy_Click);
            // 
            // bntChapNhan
            // 
            this.bntChapNhan.Location = new System.Drawing.Point(352, 187);
            this.bntChapNhan.Name = "bntChapNhan";
            this.bntChapNhan.Size = new System.Drawing.Size(75, 21);
            this.bntChapNhan.TabIndex = 34;
            this.bntChapNhan.Text = "Chấp nhận";
            this.bntChapNhan.UseVisualStyleBackColor = true;
            this.bntChapNhan.Click += new System.EventHandler(this.bntChapNhan_Click);
            // 
            // bntSua
            // 
            this.bntSua.Location = new System.Drawing.Point(247, 187);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 21);
            this.bntSua.TabIndex = 33;
            this.bntSua.Text = "Sửa";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.Location = new System.Drawing.Point(143, 187);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 21);
            this.bntThem.TabIndex = 32;
            this.bntThem.Text = "Thêm";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 13.25F);
            this.label2.Location = new System.Drawing.Point(138, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 21);
            this.label2.TabIndex = 31;
            this.label2.Text = "Danh sách nhân viên";
            // 
            // tbMaPB
            // 
            this.tbMaPB.Location = new System.Drawing.Point(551, 155);
            this.tbMaPB.Name = "tbMaPB";
            this.tbMaPB.Size = new System.Drawing.Size(180, 20);
            this.tbMaPB.TabIndex = 39;
            // 
            // bntXoa
            // 
            this.bntXoa.Location = new System.Drawing.Point(551, 187);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 21);
            this.bntXoa.TabIndex = 36;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // dtgvpb
            // 
            this.dtgvpb.AllowUserToAddRows = false;
            this.dtgvpb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvpb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvpb.Location = new System.Drawing.Point(142, 246);
            this.dtgvpb.Name = "dtgvpb";
            this.dtgvpb.ReadOnly = true;
            this.dtgvpb.Size = new System.Drawing.Size(589, 119);
            this.dtgvpb.TabIndex = 30;
            this.dtgvpb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvpb_CellContentClick);
            // 
            // tbDT
            // 
            this.tbDT.Location = new System.Drawing.Point(551, 127);
            this.tbDT.Name = "tbDT";
            this.tbDT.Size = new System.Drawing.Size(180, 20);
            this.tbDT.TabIndex = 29;
            // 
            // tbNgaySinh
            // 
            this.tbNgaySinh.Location = new System.Drawing.Point(551, 97);
            this.tbNgaySinh.Name = "tbNgaySinh";
            this.tbNgaySinh.Size = new System.Drawing.Size(180, 20);
            this.tbNgaySinh.TabIndex = 28;
            // 
            // tbTenNV
            // 
            this.tbTenNV.Location = new System.Drawing.Point(551, 67);
            this.tbTenNV.Name = "tbTenNV";
            this.tbTenNV.Size = new System.Drawing.Size(180, 20);
            this.tbTenNV.TabIndex = 27;
            // 
            // tbMaNV
            // 
            this.tbMaNV.Location = new System.Drawing.Point(551, 40);
            this.tbMaNV.Name = "tbMaNV";
            this.tbMaNV.Size = new System.Drawing.Size(180, 20);
            this.tbMaNV.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label5.Location = new System.Drawing.Point(432, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label4.Location = new System.Drawing.Point(432, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ngày Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12.25F);
            this.label3.Location = new System.Drawing.Point(432, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên NV";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Font = new System.Drawing.Font("Arial", 12.25F);
            this.MaNV.Location = new System.Drawing.Point(432, 39);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(58, 19);
            this.MaNV.TabIndex = 22;
            this.MaNV.Text = "Mã NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13F);
            this.label1.Location = new System.Drawing.Point(136, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Danh sách phòng ban";
            // 
            // lbdspb
            // 
            this.lbdspb.FormattingEnabled = true;
            this.lbdspb.Location = new System.Drawing.Point(140, 44);
            this.lbdspb.Name = "lbdspb";
            this.lbdspb.Size = new System.Drawing.Size(199, 121);
            this.lbdspb.TabIndex = 20;
            this.lbdspb.SelectedIndexChanged += new System.EventHandler(this.lbdspb_SelectedIndexChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNV";
            this.Column1.HeaderText = "Mã nhân viên";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNV";
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgaySinh";
            this.Column3.HeaderText = "Ngày sinh";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SDT";
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "MaPB";
            this.Column5.HeaderText = "Mã phòng ban";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 385);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.bntHuy);
            this.Controls.Add(this.bntChapNhan);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaPB);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.dtgvpb);
            this.Controls.Add(this.tbDT);
            this.Controls.Add(this.tbNgaySinh);
            this.Controls.Add(this.tbTenNV);
            this.Controls.Add(this.tbMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MaNV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbdspb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvpb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.Button bntHuy;
        private System.Windows.Forms.Button bntChapNhan;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMaPB;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.DataGridView dtgvpb;
        private System.Windows.Forms.TextBox tbDT;
        private System.Windows.Forms.TextBox tbNgaySinh;
        private System.Windows.Forms.TextBox tbTenNV;
        private System.Windows.Forms.TextBox tbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbdspb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
