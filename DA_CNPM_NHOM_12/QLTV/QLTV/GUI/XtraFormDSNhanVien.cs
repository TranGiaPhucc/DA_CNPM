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
using DTO;

namespace GUI
{
    public partial class XtraFormDSNhanVien : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormDSNhanVien()
        {
            InitializeComponent();
        }

        private void reload()
        {
            textEditUsername.Text = "";
            textEditPassword.Text = "";
            textEditTim.Text = "";

            textEditUsername.Enabled = false;
            comboBoxPhanQuyen.DataSource = new string[] {"user", "admin"};

            var ds = db.TAIKHOANs.Select(t => t);
            dataGridViewDSNhanVien.DataSource = ds;
        }

        private void XtraFormDSMuon_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void comboBoxGioiTinhDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewDSNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditUsername.Text = dataGridViewDSNhanVien.CurrentRow.Cells[0].Value.ToString();
            textEditPassword.Text = dataGridViewDSNhanVien.CurrentRow.Cells[1].Value.ToString();
            comboBoxPhanQuyen.Text = dataGridViewDSNhanVien.CurrentRow.Cells[3].Value.ToString();
        }

        private void simpleButtonDoiMK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEditUsername.Text) == true || string.IsNullOrWhiteSpace(textEditPassword.Text) == true)
            {
                MessageBox.Show("Chưa có đầy đủ thông tin.");
            }
            else 
            {
                var z = db.TAIKHOANs.Where(t => t.USERNAME == textEditUsername.Text);
                if (z == null)
                {
                    MessageBox.Show("Không có tài khoản này.");
                }
                else
                {
                    TAIKHOAN tk = db.TAIKHOANs.Where(t => t.USERNAME == textEditUsername.Text).FirstOrDefault();
                    tk.MATKHAU = textEditPassword.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Đã đổi mật khẩu.");
                    reload();
                }
            }
        }

        private void simpleButtonPhanQuyen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEditUsername.Text) == true)
            {
                MessageBox.Show("Chưa có đầy đủ thông tin.");
            }
            else
            {
                var z = db.TAIKHOANs.Where(t => t.USERNAME == textEditUsername.Text);
                if (z == null)
                {
                    MessageBox.Show("Không có tài khoản này.");
                }
                else
                {
                    TAIKHOAN tk = db.TAIKHOANs.Where(t => t.USERNAME == textEditUsername.Text).FirstOrDefault();
                    tk.QUYEN = comboBoxPhanQuyen.Text;
                    db.SubmitChanges();
                    MessageBox.Show("Đã đổi quyền.");
                    reload();
                }
            }
        }

        private void simpleButtonTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textEditTim.Text) == true)
            {
                reload();
            }
            else
            {
                var z = db.TAIKHOANs.Where(t => t.USERNAME == textEditTim.Text);
                if (z == null)
                {
                    MessageBox.Show("Không có tài khoản này.");
                    reload();
                }
                else
                {
                    var ds = db.TAIKHOANs.Where(t => t.USERNAME == textEditTim.Text);
                    dataGridViewDSNhanVien.DataSource = ds;

                    textEditUsername.Text = dataGridViewDSNhanVien.CurrentRow.Cells[0].Value.ToString();
                    textEditPassword.Text = dataGridViewDSNhanVien.CurrentRow.Cells[1].Value.ToString();
                    comboBoxPhanQuyen.Text = dataGridViewDSNhanVien.CurrentRow.Cells[3].Value.ToString();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}