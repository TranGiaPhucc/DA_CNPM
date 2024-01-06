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
    public partial class XtraFormTraSach : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormTraSach()
        {
            InitializeComponent();
        }

        private void reload()
        {
            textBoxMaPhieuMuon.Enabled = false;
            textBoxMaDocGiaTra.Enabled = false;
            textBoxThuThuMuonTra.Enabled = false;
            textBoxThuThuTraTra.Enabled = false;
            dateTimePickerNgayMuonTra.Enabled = false;
            dateTimePickerNgayTraTra.Enabled = false;
            textBoxPhatTienTra.Enabled = false;

            String username = XtraFormMainThuThu.userName;
            NHANVIEN nv = db.NHANVIENs.Where(t => t.USERNAME == username).FirstOrDefault();
            textBoxThuThuTraTra.Text = nv.HOTEN;

            var ds = db.PHIEUMUONs.Select(t => t);
            dataGridViewDSMuon.DataSource = ds;

            dataGridViewSachTra.DataSource = "";
        }

        private void XtraFormTraSach_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void simpleButtonKiemTraDocGia_Click(object sender, EventArgs e)
        {
            string s = textBoxTenDocGiaTra.Text;
            var dg = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();
            var p = db.PHIEUMUONs.Where(t => t.TENDOCGIA == s).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxTenDocGiaTra.Text) == true)
            {
                MessageBox.Show("Trường nhập không được để trống.");
            }
            else if (dg == null)
            {
                MessageBox.Show("Độc giả này không tồn tại.");
            }
            else if (p == null)
            {
                MessageBox.Show("Độc giả này chưa mượn sách.");
            }
            else
            {
                PHIEUMUON pm = db.PHIEUMUONs.Where(t => t.TENDOCGIA == s).FirstOrDefault();
                textBoxMaPhieuMuon.Text = pm.ID.ToString();
                textBoxMaDocGiaTra.Text = pm.IDMATHEDOCGIA.ToString();
                textBoxTenDocGiaTra.Text = pm.TENDOCGIA;
                textBoxThuThuMuonTra.Text = pm.HOTENTHUTHU;
                dateTimePickerNgayMuonTra.Value = pm.NGAYMUON;
                dateTimePickerNgayTraTra.Value = pm.NGAYTRA;

                var ct = db.CHITIETPHIEUMUONs.Where(t => t.IDPHIEUMUON == pm.ID);
                dataGridViewSachTra.DataSource = ct;

                DateTime hanTra = pm.NGAYTRA;
                DateTime ngayTra = DateTime.Now;
                TimeSpan span = ngayTra.Subtract(hanTra);
                if (span.Days > 0)
                {
                    int phatTien = 10000 * span.Days;
                    textBoxPhatTienTra.Text = phatTien.ToString();
                }
                else
                    textBoxPhatTienTra.Text = "0";
            }
        }

        private void simpleButtonXacNhanTra_Click(object sender, EventArgs e)
        {
            string s = textBoxTenDocGiaTra.Text;
            var dg = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();
            var p = db.PHIEUMUONs.Where(t => t.TENDOCGIA == s).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxTenDocGiaTra.Text) == true)
            {
                MessageBox.Show("Trường nhập không được để trống.");
            }
            else if (dg == null)
            {
                MessageBox.Show("Độc giả này không tồn tại.");
            }
            else if (p == null)
            {
                MessageBox.Show("Độc giả này chưa mượn sách.");
            }
            else
            {
                PHIEUMUON pm = db.PHIEUMUONs.Where(t => t.TENDOCGIA == s).FirstOrDefault();
                textBoxMaPhieuMuon.Text = pm.ID.ToString();
                textBoxMaDocGiaTra.Text = pm.IDMATHEDOCGIA.ToString();
                textBoxTenDocGiaTra.Text = pm.TENDOCGIA;
                textBoxThuThuMuonTra.Text = pm.HOTENTHUTHU;
                dateTimePickerNgayMuonTra.Value = pm.NGAYMUON;
                dateTimePickerNgayTraTra.Value = pm.NGAYTRA;

                var ct = db.CHITIETPHIEUMUONs.Where(t => t.IDPHIEUMUON == pm.ID);
                dataGridViewSachTra.DataSource = ct;

                DateTime hanTra = pm.NGAYTRA;
                DateTime ngayTra = DateTime.Now;
                TimeSpan span = ngayTra.Subtract(hanTra);
                if (span.Days > 0)
                {
                    float phatTien = 10000 * span.Days;
                    textBoxPhatTienTra.Text = phatTien.ToString();
                }
                else
                {
                    textBoxPhatTienTra.Text = "0";
                }
                    
                for (int i = 0; i < dataGridViewSachTra.Rows.Count - 1; i++)
                {
                    string tenSach = dataGridViewSachTra.Rows[i].Cells[2].Value.ToString();
                    SACH sach = db.SACHes.Where(t => t.TENSACH == tenSach).FirstOrDefault();
                    sach.SOLUONGTON++;
                    sach.SOLUONGMUON--;
                    db.SubmitChanges();

                    CHITIETPHIEUMUON ctpm = db.CHITIETPHIEUMUONs.Where(t => t.TENSACH == tenSach).FirstOrDefault();
                    db.CHITIETPHIEUMUONs.DeleteOnSubmit(ctpm);
                    db.SubmitChanges();
                }
                

                PHIEUTRA pt = new PHIEUTRA();
                pt.IDDOCGIA = int.Parse(textBoxMaDocGiaTra.Text);
                pt.TENDOCGIA = textBoxTenDocGiaTra.Text;

                NHANVIEN nv = db.NHANVIENs.Where(t => t.HOTEN == textBoxThuThuTraTra.Text).FirstOrDefault();
                pt.IDTHUTHU = nv.ID;
                pt.HOTENTHUTHU = textBoxThuThuTraTra.Text;
                pt.NGAYLAPPHIEU = DateTime.Now;
                if (span.Days > 0)
                    pt.SONGAYQUAHAN = span.Days;
                else
                    pt.SONGAYQUAHAN = 0;
                pt.TIENPHAT = float.Parse(textBoxPhatTienTra.Text);
                db.PHIEUTRAs.InsertOnSubmit(pt);
                db.SubmitChanges();

                WordExport w = new WordExport();
                w.Tra(pt.TENDOCGIA, pt.HOTENTHUTHU, pm.NGAYMUON.ToShortDateString(), pm.NGAYTRA.ToShortDateString(), DateTime.Now.ToShortDateString(), pt.TIENPHAT.ToString());

                db.PHIEUMUONs.DeleteOnSubmit(pm);
                db.SubmitChanges();

                MessageBox.Show("Đã trả sách.");
                reload();
            } 
        }

        private void dataGridViewSachTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewDSMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxMaPhieuMuon.Text = dataGridViewDSMuon.CurrentRow.Cells[0].Value.ToString();
            textBoxMaDocGiaTra.Text = dataGridViewDSMuon.CurrentRow.Cells[1].Value.ToString();
            textBoxTenDocGiaTra.Text = dataGridViewDSMuon.CurrentRow.Cells[2].Value.ToString();
            textBoxThuThuMuonTra.Text = dataGridViewDSMuon.CurrentRow.Cells[4].Value.ToString();
            
            dateTimePickerNgayMuonTra.Text = dataGridViewDSMuon.CurrentRow.Cells[5].Value.ToString();
            dateTimePickerNgayTraTra.Text = dataGridViewDSMuon.CurrentRow.Cells[6].Value.ToString();

            var ds = db.CHITIETPHIEUMUONs.Where(t => t.IDPHIEUMUON == int.Parse(textBoxMaPhieuMuon.Text));
            dataGridViewSachTra.DataSource = ds;
        }

        private void textBoxPhatTienTra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}