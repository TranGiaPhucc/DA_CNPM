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
    public partial class XtraFormThemTheLoai : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormThemTheLoai()
        {
            InitializeComponent();
        }

        private void dataGridViewTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditTheLoaiTim.Text = dataGridViewTheLoai.CurrentRow.Cells[0].Value.ToString();
        }

        private void XtraFormThemTheLoai_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            var datasource = from h in db.THELOAIs select h;
            dataGridViewTheLoai.DataSource = datasource;
        }

        private void simpleButtonThemTheLoai_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTheLoaiTim.Text) == true)
                MessageBox.Show("Trường nhập không được để trống.");
            else
            {
                var z = (from u in db.THELOAIs where u.TENTHELOAI.Equals(textEditTheLoaiTim.Text) select u).FirstOrDefault();
                if (z != null)
                {
                    MessageBox.Show("Thể loại này đã tồn tại.");
                }
                else
                {
                    THELOAI tl = new THELOAI();
                    tl.TENTHELOAI = textEditTheLoaiTim.Text;
                    db.THELOAIs.InsertOnSubmit(tl);
                    db.SubmitChanges();
                    reload();
                }
            }
        }
        /*
        private void simpleButtonTheLoaiSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTheLoaiTim.Text) == true)
                MessageBox.Show("Trường nhập không được để trống.");
            else
            {
                string s = dataGridViewTheLoai.CurrentRow.Cells[0].Value.ToString();
                THELOAI tl = db.THELOAIs.Where(t => t.TENTHELOAI == s).FirstOrDefault();
                tl.TENTHELOAI = textEditTheLoaiTim.Text;
                db.SubmitChanges();
                reload();
            }
        }
        */
        private void simpleButtonTheLoaiXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTheLoaiTim.Text) == true)
                MessageBox.Show("Trường nhập không được để trống.");
            else
            {
                string s = dataGridViewTheLoai.CurrentRow.Cells[0].Value.ToString();
                THELOAI tl = db.THELOAIs.Where(t => t.TENTHELOAI == s).FirstOrDefault();
                db.THELOAIs.DeleteOnSubmit(tl);
                db.SubmitChanges();
                reload();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}