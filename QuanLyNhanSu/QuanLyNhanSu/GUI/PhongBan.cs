using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class PhongBan : Form
    {
        string strConn = @"Server=DESKTOP-8N0O4EO; Database=QL_NHANSU; Integrated Security=True";
        SqlConnection conn;
        public PhongBan()
        {
            InitializeComponent();
        }

        private void PhongBan_Load_1(object sender, EventArgs e)
        {
            loadData();
        }

            public void loadData()
            {
                conn = new SqlConnection(strConn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhongBan", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        private void dataGridView1_RowPrePaint_1(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtmapb.DataBindings.Clear();
            txtmapb.DataBindings.Add("Text", dataGridView1.DataSource, "MaPB");
            txtpb.DataBindings.Clear();
            txtpb.DataBindings.Add("Text", dataGridView1.DataSource, "TenPB");
            txttp.DataBindings.Clear();
            txttp.DataBindings.Add("Text", dataGridView1.DataSource, "MaTP");
            txtnnc.DataBindings.Clear();
            txtnnc.DataBindings.Add("Text", dataGridView1.DataSource, "Ng_NC");
            txtsonv.DataBindings.Clear();
            txtsonv.DataBindings.Add("Text", dataGridView1.DataSource, "SoNV");
        }
        private void btnxoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muôn xóa bản ghi đang chọn không?",
                      "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("delete from PhongBan where MaPB='" + txtmapb.Text + "'", conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Xóa thành công!");
                    loadData();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa bản ghi hiện thời!");
                }
                loadData();
            }
        }
        private void btnsua_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("updatepb", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@MaPB", txtmapb.Text));
            cmd.Parameters.Add(new SqlParameter("@TenPB", txtpb.Text));
            cmd.Parameters.Add(new SqlParameter("@MaTP", txttp.Text));
            cmd.Parameters.Add(new SqlParameter("@NNC", dtnnc.Value.ToString("yyyyMMdd")));
            cmd.Parameters.Add(new SqlParameter("@SoNV", Convert.ToInt32(txtsonv.Text)));
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("Sửa thành công!");
                loadData();
            }

            else MessageBox.Show("Không sửa được!");
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            try
            {
                // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
                SqlCommand cmd = new SqlCommand("INSERT INTO PhongBan VALUES ('" + txtmapb.Text + "',N'" + txtpb.Text + "',N'" + txttp.Text + "','" + Convert.ToString(dtnnc.Text) + "','" + Convert.ToInt32(txtsonv.Text) + "')", conn);

                string sqlINSERT = "INSERT INTO PhongBan VALUES (@MaPB,@TenPb,@mapb,@Nnc,@sonv)";
                SqlCommand da = new SqlCommand(sqlINSERT, conn);
                cmd.Parameters.AddWithValue("MaNV", txtmapb.Text);
                cmd.Parameters.AddWithValue("TenNV", txtpb.Text);
                cmd.Parameters.AddWithValue("HoNV", txttp.Text);
                cmd.Parameters.AddWithValue("Ng_NC", dtnnc.Value.ToString("yyyyMMdd"));
                cmd.Parameters.AddWithValue("SoNV", Convert.ToInt32(txtsonv.Text));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Thêm mới thành công");
                loadData();
            }
            catch
            {
                MessageBox.Show("Không thể thêm mới");
            }
        }

      
    }

}

