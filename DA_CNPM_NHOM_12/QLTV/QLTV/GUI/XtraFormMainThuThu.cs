using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace GUI
{
    public partial class XtraFormMainThuThu : DevExpress.XtraEditors.XtraForm
    {
        public static String userName;
        public XtraFormMainThuThu()
        {
            InitializeComponent();
        }

        private void XtraFormMain_Load(object sender, EventArgs e)
        {

        }

        private void si_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButtonQuanLySach_Click(object sender, EventArgs e)
        {
            this.Hide();
            XtraFormQuanLySach m = new XtraFormQuanLySach();
            m.ShowDialog();
            this.Show();
        }

        private void simpleButtonTheThuVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            XtraFormTheThuVien m = new XtraFormTheThuVien();
            m.ShowDialog();
            this.Show();
        }

        private void simpleButtonMuonTraSach_Click(object sender, EventArgs e)
        {
            userName = FormLogin.userName;

            this.Hide();
            XtraFormMuonSach m = new XtraFormMuonSach();
            m.ShowDialog();
            this.Show();
        }

        private void simpleButtonTraSach_Click(object sender, EventArgs e)
        {
            userName = FormLogin.userName;

            this.Hide();
            XtraFormTraSach m = new XtraFormTraSach();
            m.ShowDialog();
            this.Show();
        }

        private void simpleButtonThongTinCaNhan_Click(object sender, EventArgs e)
        {
            userName = FormLogin.userName;

            XtraFormThongTinCaNhan m = new XtraFormThongTinCaNhan();
            m.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}