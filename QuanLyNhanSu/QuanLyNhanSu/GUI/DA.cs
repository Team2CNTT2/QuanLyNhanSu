using QuanLyNhanSu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyNhanSu.GUI
{
    public partial class DA : UserControl
    {
        public DA()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void DA_Load(object sender, EventArgs e)
        {
            Connect.openketnoi();
            lbda.DataSource = Connect.gettable("select *from phongban");
            lbda.DisplayMember = "tenpb";
            lbda.ValueMember = "mapb";
            dtgvda.DataSource = Connect.gettable("select MADA,TENDA,MAPB,DiaDiem from duan");
            btnchapnhan.Enabled = false;
            btnhuy.Enabled = false;
            Connect.dongketnoi();
            tbMaDA.Enabled = false;
            tbMaPB.Enabled = false;
            tbTenDA.Enabled = false;
            tbDD.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgvda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int t = dtgvda.CurrentCell.RowIndex;
            tbMaDA.Text = dtgvda.Rows[t].Cells[0].Value.ToString();

            tbTenDA.Text = dtgvda.Rows[t].Cells[1].Value.ToString();
            tbDD.Text = dtgvda.Rows[t].Cells[3].Value.ToString();
            tbMaPB.Text = dtgvda.Rows[t].Cells[2].Value.ToString();

        }
        private int chon = 0;

        public DialogResult DialogResult { get; private set; }

        private void btnsua_Click(object sender, EventArgs e)
        {
            chon = 2;
            tbMaDA.Enabled = false;
            tbMaPB.Enabled = true;
            tbTenDA.Enabled = true;
            tbDD.Enabled = true;

            btnchapnhan.Enabled = true;
            btnhuy.Enabled = true;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            int t = dtgvda.CurrentCell.RowIndex;
            tbMaDA.Text = dtgvda.Rows[t].Cells[0].Value.ToString();

            tbTenDA.Text = dtgvda.Rows[t].Cells[1].Value.ToString();
            tbDD.Text = dtgvda.Rows[t].Cells[3].Value.ToString();
            tbMaPB.Text = dtgvda.Rows[t].Cells[2].Value.ToString();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            chon = 1;
            tbMaDA.Enabled = true;
            tbMaPB.Enabled = true;
            tbTenDA.Enabled = true;
            tbDD.Enabled = true;
            btnchapnhan.Enabled = true;
            btnhuy.Enabled = true;
            btnsua.Enabled = false;
            btnthem.Enabled = false;
            btnxoa.Enabled = false;

            tbMaDA.Text = null;
            tbMaPB.Text = null;
            tbTenDA.Text = null;
            tbDD.Text = null;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc muốn xóa!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (DialogResult == DialogResult.OK)
            {
                Connect.openketnoi();
                Connect.executeQuery("delete from duan where mada='" + dtgvda.Rows[dtgvda.CurrentCell.RowIndex].Cells[0].Value.ToString() + "' ");
                DA_Load(sender, e);
                Connect.dongketnoi();
            }
        }

        private void btnchapnhan_Click(object sender, EventArgs e)
        {
            if (chon == 1) // gọi Button Thêm
            {
                Connect.openketnoi();
                try
                {
                    Connect.executeQuery("insert into duan values('" + tbMaDA.Text + "',N'" + tbTenDA.Text + "',N'" + tbMaPB.Text + "','" + (tbDD.Text) + "')");
                    DA_Load(sender, e);
                    tbMaDA.Text = null;
                    tbMaPB.Text = null;
                    tbTenDA.Text = null;
                    tbDD.Text = null;

                    tbMaDA.Enabled = false;
                    tbMaPB.Enabled = false;
                    tbTenDA.Enabled = false;
                    tbDD.Enabled = false;

                    btnxoa.Enabled = true;
                    MessageBox.Show("Dự Án đã được thêm mới thành công!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    DA_Load(sender, e);
                }

            }
            else if (chon == 2)// 
            {
                Connect.openketnoi();
                try
                {
                    Connect.executeQuery("update duan set mada='" + tbMaDA.Text + "',N'" + tbTenDA.Text + "',N'" + tbMaPB.Text + "','" + (tbDD.Text) + "')");
                    DA_Load(sender, e);
                    btnchapnhan.Enabled = false;
                    btnhuy.Enabled = false;
                    tbMaDA.Text = null;
                    tbMaPB.Text = null;
                    tbTenDA.Text = null;
                    tbDD.Text = null;

                    tbMaDA.Enabled = false;
                    tbMaPB.Enabled = false;
                    tbTenDA.Enabled = false;
                    tbDD.Enabled = false;

                    MessageBox.Show("Dự án đã được chỉnh sửa thành công!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    DA_Load(sender, e);
                }
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            chon = 0;
            btnsua.Enabled = true;
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnchapnhan.Enabled = false;
            btnhuy.Enabled = false;
            tbMaDA.Enabled = false;
            tbMaPB.Enabled = false;
            tbTenDA.Enabled = false;
            tbDD.Enabled = false;

            int t = dtgvda.CurrentCell.RowIndex;
            tbMaDA.Text = dtgvda.Rows[t].Cells[0].Value.ToString();

            tbTenDA.Text = dtgvda.Rows[t].Cells[1].Value.ToString();
            tbDD.Text = dtgvda.Rows[t].Cells[3].Value.ToString();
            tbMaPB.Text = dtgvda.Rows[t].Cells[2].Value.ToString();
        }

        private void lbda_SelectedIndexChanged(object sender, EventArgs e)
        {
            Connect.openketnoi();
            string ma = lbda.SelectedValue.ToString();
            dtgvda.DataSource = Connect.gettable("select *from duan where duan.mapb='" + ma + "'");
            Connect.dongketnoi();
            tbMaDA.Text = null;
            tbMaPB.Text = null;
            tbTenDA.Text = null;
            tbDD.Text = null;
        }
    }
}

