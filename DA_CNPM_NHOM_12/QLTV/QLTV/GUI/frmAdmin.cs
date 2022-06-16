using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class frmAdmin : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public static String userName;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void simpleButtonQuanLySachAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            XtraFormQuanLySach m = new XtraFormQuanLySach();
            m.ShowDialog();
            this.Show();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }

        private void simpleButtonMuonSachAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            XtraFormDSNhanVien m = new XtraFormDSNhanVien();
            m.ShowDialog();
            this.Show();
        }

        private void simpleButtonTraSachAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            XtraFormDSMuonTra m = new XtraFormDSMuonTra();
            m.ShowDialog();
            this.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void simpleButtonDangXuatAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonTheThuVienAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            XtraFormTheThuVien m = new XtraFormTheThuVien();
            m.ShowDialog();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
