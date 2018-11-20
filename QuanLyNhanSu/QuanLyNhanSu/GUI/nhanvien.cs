using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.Data;

namespace QuanLyNhanSu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load();
        }

        private void lbdspb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ma = lbdspb.SelectedValue.ToString();
            dtgvpb.DataSource = ketnoi.gettable("select *from nhanvien where nhanvien.mapb='" + ma + "'");
        }
        public void load()
        {
            ketnoi.openketnoi();
            //load listBox
            lbdspb.DataSource = ketnoi.gettable("select *from phongban");
            lbdspb.DisplayMember = "tenpb";
            lbdspb.ValueMember = "mapb";

            //Load DataGridView
            dtgvpb.DataSource = ketnoi.gettable("select MaNV,TenNV,NgaySinh,SDT,MaPB from nhanvien");

            bntChapNhan.Enabled = false;
            bntHuy.Enabled = false;
            ketnoi.dongketnoi();
        }

        private void dtgvpb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtgvpb.CurrentCell.RowIndex;
            tbMaNV.Text = dtgvpb.Rows[t].Cells[0].Value.ToString();
            tbTenNV.Text = dtgvpb.Rows[t].Cells[1].Value.ToString();
            tbNgaySinh.Text = dtgvpb.Rows[t].Cells[2].Value.ToString();
            tbDT.Text = dtgvpb.Rows[t].Cells[3].Value.ToString();
            tbMaPB.Text = dtgvpb.Rows[t].Cells[4].Value.ToString();
        }
        private int chon = 0;

        private void bntSua_Click(object sender, EventArgs e)
        {
            chon = 2;
            bntChapNhan.Enabled = true;
            bntHuy.Enabled = true;

        }

        private void bntThem_Click(object sender, EventArgs e)
        {
            chon = 1;
            bntChapNhan.Enabled = true;
            bntHuy.Enabled = true;
        }

        private void bntThoat_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bntXoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("delete from nhanvien where manv='" + dtgvpb.Rows[dtgvpb.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                load();
                ketnoi.dongketnoi();
            }
        }

        private void bntChapNhan_Click(object sender, EventArgs e)
        {
            if (chon == 1) // gọi Button Thêm-kenhdaihoc.com
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("insert into nhanvien values('" + tbMaNV.Text + "','" + tbTenNV.Text + "','" + DateTime.Parse(tbNgaySinh.Text) + "','" + int.Parse(tbDT.Text) + "','" + tbMaPB.Text + "')");
                load();
                bntChapNhan.Enabled = true;
                bntHuy.Enabled = true;
            }
            else if (chon == 2)// gọi Button Sửa -kenhdaihoc.com
            {
                ketnoi.openketnoi();
                ketnoi.executeQuery("update nhanvien set manv='" + tbMaNV.Text + "',tennv='" + tbTenNV.Text + "',ngaysinh='" + DateTime.Parse(tbNgaySinh.Text) + "',sdt='" + int.Parse(tbDT.Text) + "',mapb='" + tbMaPB.Text + "' where manv='" + dtgvpb.Rows[dtgvpb.CurrentCell.RowIndex].Cells[0].Value.ToString() + "'");
                load();
                bntChapNhan.Enabled = true;
                bntHuy.Enabled = true;
            }
            else
            {
                chon = 0;
            }
        }

        private void bntHuy_Click(object sender, EventArgs e)
        {
            chon = 0;
        }
    }
}
