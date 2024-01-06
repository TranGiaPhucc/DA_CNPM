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
    public partial class XtraFormTheThuVien : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormTheThuVien()
        {
            InitializeComponent();
        }

        private void XtraFormTheThuVien_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            textEditMaSoThe.Enabled = false;
            dateTimePickerNgayLap.Enabled = false;
            dateTimePickerHanSuDung.Enabled = false;

            var datasource = from h in db.DOCGIAs select h;
            dataGridViewDocGia.DataSource = datasource;

            var gt = from x in db.GIOITINHs select x;
            comboBoxGioiTinhDocGia.DataSource = gt;
            comboBoxGioiTinhDocGia.ValueMember = "GIOITINH1";

            dateTimePickerHanSuDung.Text = DateTime.Today.AddDays(365).ToString();
        }

        private void labelControl7_Click(object sender, EventArgs e)
        {

        }

        private void labelControl10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButtonThemDocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenDocGia.Text) == true || string.IsNullOrEmpty(textEditSDTDocGia.Text) == true || string.IsNullOrEmpty(textEditCMNDDocGia.Text) == true || string.IsNullOrEmpty(textEditDiaChiDocGia.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                DOCGIA dg = new DOCGIA();
                dg.HOTEN = textEditTenDocGia.Text;
                dg.GIOITINH = comboBoxGioiTinhDocGia.Text;
                dg.NGAYSINH = dateTimePickerNgaySinhDocGia.Value.Date;
                dg.SODT = textEditSDTDocGia.Text;
                dg.CMND = textEditCMNDDocGia.Text;
                dg.DIACHI = textEditDiaChiDocGia.Text;
                dg.NGAYLAP = DateTime.Today;
                dg.HANSUDUNG = DateTime.Today.AddDays(365);
                db.DOCGIAs.InsertOnSubmit(dg);
                db.SubmitChanges();
                reload();
            }
        }

        private void simpleButtonCapNhatDocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenDocGia.Text) == true || string.IsNullOrEmpty(textEditSDTDocGia.Text) == true || string.IsNullOrEmpty(textEditCMNDDocGia.Text) == true || string.IsNullOrEmpty(textEditDiaChiDocGia.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                string s = dataGridViewDocGia.CurrentRow.Cells[1].Value.ToString();
                DOCGIA dg = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();
                dg.HOTEN = textEditTenDocGia.Text;
                dg.GIOITINH = comboBoxGioiTinhDocGia.Text;
                dg.NGAYSINH = dateTimePickerNgaySinhDocGia.Value.Date;
                dg.SODT = textEditSDTDocGia.Text;
                dg.CMND = textEditCMNDDocGia.Text;
                dg.DIACHI = textEditDiaChiDocGia.Text;
                dg.NGAYLAP = DateTime.Today;
                dg.HANSUDUNG = DateTime.Today.AddDays(365);
                db.SubmitChanges();
                reload();
            }
        }

        private void simpleButtonXoaDocGia_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenDocGia.Text) == true || string.IsNullOrEmpty(textEditSDTDocGia.Text) == true || string.IsNullOrEmpty(textEditCMNDDocGia.Text) == true || string.IsNullOrEmpty(textEditDiaChiDocGia.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                string s = dataGridViewDocGia.CurrentRow.Cells[1].Value.ToString();
                DOCGIA dg = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();
                db.DOCGIAs.DeleteOnSubmit(dg);
                db.SubmitChanges();
                reload();
            }
        }

        private void dateTimePickerNgayLap_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDocGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditMaSoThe.Text = dataGridViewDocGia.CurrentRow.Cells[0].Value.ToString();
            textEditTenDocGia.Text = dataGridViewDocGia.CurrentRow.Cells[1].Value.ToString();
            comboBoxGioiTinhDocGia.Text = dataGridViewDocGia.CurrentRow.Cells[2].Value.ToString();

            dateTimePickerNgaySinhDocGia.Text = dataGridViewDocGia.CurrentRow.Cells[3].Value.ToString();

            textEditSDTDocGia.Text = dataGridViewDocGia.CurrentRow.Cells[4].Value.ToString();
            textEditCMNDDocGia.Text = dataGridViewDocGia.CurrentRow.Cells[5].Value.ToString();
            textEditDiaChiDocGia.Text = dataGridViewDocGia.CurrentRow.Cells[6].Value.ToString();

            dateTimePickerNgayLap.Text = dataGridViewDocGia.CurrentRow.Cells[7].Value.ToString();
            dateTimePickerHanSuDung.Text = dataGridViewDocGia.CurrentRow.Cells[8].Value.ToString();
        }

        private void textEditTimDocGia_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTimDocGia.Text) == true)
            {
                var datasource = from h in db.DOCGIAs select h;
                dataGridViewDocGia.DataSource = datasource;
            }
            else
            {
                string s = textEditTimDocGia.Text;
                var z = from u in db.DOCGIAs where u.HOTEN.Contains(s) select u;
                if (z != null)
                    dataGridViewDocGia.DataSource = z;
            }
        }
    }
}