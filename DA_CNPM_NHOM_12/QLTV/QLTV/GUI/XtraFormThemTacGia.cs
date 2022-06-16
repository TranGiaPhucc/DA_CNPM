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
    public partial class XtraFormThemTacGia : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormThemTacGia()
        {
            InitializeComponent();
        }

        private void XtraFormThemTacGia_Load(object sender, EventArgs e)
        {
            reload();
        }
        private void reload()
        {
            var datasource = from h in db.TACGIAs select h;
            dataGridViewTacGia.DataSource = datasource;
        }

        private void simpleButtonTacGiaThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTacGiaTim.Text) == true)
                MessageBox.Show("Trường nhập không được để trống.");
            else
            {
                var z = (from u in db.TACGIAs where u.TENTACGIA.Equals(textEditTacGiaTim.Text) select u).FirstOrDefault();
                if (z != null)
                {
                    MessageBox.Show("Tác giả này đã tồn tại.");
                }
                else
                {
                    TACGIA tg = new TACGIA();
                    tg.TENTACGIA = textEditTacGiaTim.Text;
                    db.TACGIAs.InsertOnSubmit(tg);
                    db.SubmitChanges();
                    reload();
                }
            }
        }
        /*
        private void simpleButtonTacGiaSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTacGiaTim.Text) == true)
                MessageBox.Show("Trường nhập không được để trống.");
            else
            {
                string s = dataGridViewTacGia.CurrentRow.Cells[0].Value.ToString();
                TACGIA tg = db.TACGIAs.Where(t => t.TENTACGIA == s).FirstOrDefault();
                tg.TENTACGIA = textEditTacGiaTim.Text;
                db.SubmitChanges();
                reload();
            }
        }
        */
        private void simpleButtonTacGiaXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTacGiaTim.Text) == true)
                MessageBox.Show("Trường nhập không được để trống.");
            else
            {
                string s = dataGridViewTacGia.CurrentRow.Cells[0].Value.ToString();
                TACGIA tg = db.TACGIAs.Where(t => t.TENTACGIA == s).FirstOrDefault();
                db.TACGIAs.DeleteOnSubmit(tg);
                db.SubmitChanges();
                reload();
            }
        }

        private void dataGridViewTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditTacGiaTim.Text = dataGridViewTacGia.CurrentRow.Cells[0].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}