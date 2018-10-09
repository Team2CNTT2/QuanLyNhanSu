using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhanSu.GUI;

namespace QuanLyNhanSu.GUI
{
    public partial class Main : Form
    {
        bool b = false;
        public Main(bool a)
        {
            InitializeComponent();
            b = a;
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {
                if (b == true)
                {
                FormQl.Enabled = true;
                btnDangxuat.Enabled = true;
                btnLogin.Enabled = false;
                 }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Acount login = new Acount();
            login.ShowDialog();
            this.Hide();
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Bạn muốn đăng xuất", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult.Yes == dr)
            {
                this.Hide();

            }
            else { return; }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
