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
    public partial class XtraFormQuanLySach : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormQuanLySach()
        {
            InitializeComponent();
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButtonThemTheLoai_Click(object sender, EventArgs e)
        {
            XtraFormThemTheLoai m = new XtraFormThemTheLoai();
            m.ShowDialog();
            reload();
        }

        private void simpleButtonThemTacGia_Click(object sender, EventArgs e)
        {
            XtraFormThemTacGia m = new XtraFormThemTacGia();
            m.ShowDialog();
            reload();
        }

        private void simpleButtonThemNhaXuatBan_Click(object sender, EventArgs e)
        {
            XtraFormThemNXB m = new XtraFormThemNXB();
            m.ShowDialog();
            reload();
        }

        private void XtraFormQuanLySach_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            var datasource = from h in db.SACHes select h;
            dataGridViewSach.DataSource = datasource;

            var tl = from x in db.THELOAIs select x;
            comboBoxTheLoai.DataSource = tl;
            comboBoxTheLoai.ValueMember = "TENTHELOAI";

            var tg = from x in db.TACGIAs select x;
            comboBoxTacGia.DataSource = tg;
            comboBoxTacGia.ValueMember = "TENTACGIA";

            var nxb = from x in db.NHAXUATBANs select x;
            comboBoxNXB.DataSource = nxb;
            comboBoxNXB.ValueMember = "TENNXB";
        }

        private void dataGridViewSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditTenSach.Text = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
            comboBoxNXB.Text = dataGridViewSach.CurrentRow.Cells[2].Value.ToString();
            comboBoxTheLoai.Text = dataGridViewSach.CurrentRow.Cells[3].Value.ToString();
            comboBoxTacGia.Text = dataGridViewSach.CurrentRow.Cells[4].Value.ToString();
            textEditSoLuongTon.Text = dataGridViewSach.CurrentRow.Cells[5].Value.ToString();
            textEditSoLuongMuon.Text = dataGridViewSach.CurrentRow.Cells[6].Value.ToString();
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenSach.Text) == true || string.IsNullOrEmpty(comboBoxNXB.Text) == true || string.IsNullOrEmpty(comboBoxTacGia.Text) == true || string.IsNullOrEmpty(comboBoxTheLoai.Text) == true || string.IsNullOrEmpty(textEditSoLuongTon.Text) == true || string.IsNullOrEmpty(textEditSoLuongMuon.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                var z = (from u in db.SACHes where u.TENSACH.Equals(textEditTenSach.Text) select u).FirstOrDefault();
                if (z != null)
                {
                    MessageBox.Show("Sách này đã tồn tại.");
                }
                else
                {
                    SACH s = new SACH();
                    s.TENSACH = textEditTenSach.Text;
                    s.TENNXB = comboBoxNXB.Text;
                    s.TENTACGIA = comboBoxTacGia.Text;
                    s.TENTHELOAI = comboBoxTheLoai.Text;
                    s.SOLUONGTON = int.Parse(textEditSoLuongTon.Text);
                    s.SOLUONGMUON = int.Parse(textEditSoLuongMuon.Text);
                    db.SACHes.InsertOnSubmit(s);
                    db.SubmitChanges();
                    reload();
                }
            }
        }

        private void simpleButtonCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenSach.Text) == true || string.IsNullOrEmpty(comboBoxNXB.Text) == true || string.IsNullOrEmpty(comboBoxTacGia.Text) == true || string.IsNullOrEmpty(comboBoxTheLoai.Text) == true || string.IsNullOrEmpty(textEditSoLuongTon.Text) == true || string.IsNullOrEmpty(textEditSoLuongMuon.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                string s = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
                SACH sach = db.SACHes.Where(t => t.TENSACH == s).FirstOrDefault();
                sach.TENSACH = textEditTenSach.Text;
                sach.TENNXB = comboBoxNXB.Text;
                sach.TENTACGIA = comboBoxTacGia.Text;
                sach.TENTHELOAI = comboBoxTheLoai.Text;
                sach.SOLUONGTON = int.Parse(textEditSoLuongTon.Text);
                sach.SOLUONGMUON = int.Parse(textEditSoLuongMuon.Text);
                db.SubmitChanges();
                reload();
            }
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenSach.Text) == true || string.IsNullOrEmpty(comboBoxNXB.Text) == true || string.IsNullOrEmpty(comboBoxTacGia.Text) == true || string.IsNullOrEmpty(comboBoxTheLoai.Text) == true || string.IsNullOrEmpty(textEditSoLuongTon.Text) == true || string.IsNullOrEmpty(textEditSoLuongMuon.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                string s = dataGridViewSach.CurrentRow.Cells[1].Value.ToString();
                SACH sach = db.SACHes.Where(t => t.TENSACH == s).FirstOrDefault();
                db.SACHes.DeleteOnSubmit(sach);
                db.SubmitChanges();
                reload();
            }
        }

        private void simpleButtonTimSach_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTimSach.Text) == true)
                reload();
            else
            {
                string s = textEditTimSach.Text;
                var z = (from u in db.SACHes where u.TENSACH.Equals(s) select u).FirstOrDefault();
                if (z == null)
                {
                    MessageBox.Show("Không có sách này.");
                    reload();
                }
                else
                {
                    dataGridViewSach.DataSource = db.SACHes.Where(t => t.TENSACH == s);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}