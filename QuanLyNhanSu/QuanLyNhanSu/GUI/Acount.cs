using System;
using System.Collections;
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
    public partial class Acount : Form
    {
        dataDataContext data = new dataDataContext();
        public Acount()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //NguoiDung acount = new NguoiDung();
            if (USER.Text == "" || PASS.Text == "")
            {
                MessageBox.Show("Tên tài khoản và mật khẩu còn trống");
                return;
            }

            else
            {
                var a = data.dangnhap(USER.Text, PASS.Text).SingleOrDefault();
                if(a==null)
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                    PASS.Clear(); USER.Clear();
                }
                else
                {
                    DialogResult = MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OKCancel);
                    this.Hide();
                    Main ql = new Main(true);
                    ql.ShowDialog();
                }
            }
        }

        private void Acount_Load(object sender, EventArgs e)
        {

        }
    }
}
