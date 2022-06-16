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
    public partial class XtraFormThemNXB : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormThemNXB()
        {
            InitializeComponent();
        }
        private void reload()
        {
            var datasource = from h in db.NHAXUATBANs select h;
            dataGridViewNXB.DataSource = datasource;
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNXB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textEditTenNXBTim.Text = dataGridViewNXB.CurrentRow.Cells[0].Value.ToString();
            textEditSDTNXB.Text = dataGridViewNXB.CurrentRow.Cells[1].Value.ToString();
            textEditDiaChiNXB.Text = dataGridViewNXB.CurrentRow.Cells[2].Value.ToString();
            textEditEmailNXB.Text = dataGridViewNXB.CurrentRow.Cells[3].Value.ToString();
            textEditWebsiteNXB.Text = dataGridViewNXB.CurrentRow.Cells[4].Value.ToString();
        }

        private void XtraFormThemNXB_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void simpleButtonNXBThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenNXBTim.Text) == true)
                MessageBox.Show("Tên NXB không được để trống.");
            else
            {
                var z = (from u in db.NHAXUATBANs where u.TENNXB.Equals(textEditTenNXBTim.Text) select u).FirstOrDefault();
                if (z != null)
                {
                    MessageBox.Show("Nhà xuất bản này đã tồn tại.");
                }
                else
                {
                    NHAXUATBAN nxb = new NHAXUATBAN();
                    nxb.TENNXB = textEditTenNXBTim.Text;
                    nxb.SODT = textEditSDTNXB.Text;
                    nxb.DIACHI = textEditDiaChiNXB.Text;
                    nxb.EMAIL = textEditEmailNXB.Text;
                    nxb.WEBSITE = textEditWebsiteNXB.Text;
                    db.NHAXUATBANs.InsertOnSubmit(nxb);
                    db.SubmitChanges();
                    reload();
                }
            }
        }

        private void simpleButtonNXBSua_Click(object sender, EventArgs e)
        {
            string s = dataGridViewNXB.CurrentRow.Cells[0].Value.ToString();
            NHAXUATBAN nxb = db.NHAXUATBANs.Where(t => t.TENNXB == s).FirstOrDefault();
            //nxb.TENNXB = textEditTenNXBTim.Text;
            nxb.SODT = textEditSDTNXB.Text;
            nxb.DIACHI = textEditDiaChiNXB.Text;
            nxb.EMAIL = textEditEmailNXB.Text;
            nxb.WEBSITE = textEditWebsiteNXB.Text;
            db.SubmitChanges();
            reload();
        }
        
        private void simpleButtonNXBXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textEditTenNXBTim.Text) == true || string.IsNullOrEmpty(textEditSDTNXB.Text) == true || string.IsNullOrEmpty(textEditDiaChiNXB.Text) == true || string.IsNullOrEmpty(textEditEmailNXB.Text) == true || string.IsNullOrEmpty(textEditWebsiteNXB.Text) == true)
                MessageBox.Show("Các trường nhập không được để trống.");
            else
            {
                string s = dataGridViewNXB.CurrentRow.Cells[0].Value.ToString();
                NHAXUATBAN nxb = db.NHAXUATBANs.Where(t => t.TENNXB == s).FirstOrDefault();
                db.NHAXUATBANs.DeleteOnSubmit(nxb);
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