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
    public partial class XtraFormMuonSach : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public XtraFormMuonSach()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void XtraFormMuonSach_Load(object sender, EventArgs e)
        {
            reload();
        }

        private void reload()
        {
            textBoxMaDocGiaMuon.Enabled = false;
            textBoxThuThuMuon.Enabled = false;
            dateTimePickerNgayMuon.Enabled = false;
            dateTimePickerNgayTra.Enabled = false;

            var datasource = from h in db.SACHes select h;
            dataGridViewDSSach.DataSource = datasource;

            String username = XtraFormMainThuThu.userName;
            NHANVIEN nv = db.NHANVIENs.Where(t => t.USERNAME == username).FirstOrDefault();
            textBoxThuThuMuon.Text = nv.HOTEN;
            dateTimePickerNgayMuon.Value = DateTime.Today;
            dateTimePickerNgayTra.Value = DateTime.Today.AddDays(14);
        }

        private void dataGridViewDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePickerNgayMuon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButtonKiemTraDocGia_Click(object sender, EventArgs e)
        {
            string s = textBoxTenDocGiaMuon.Text;
            var dg = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxTenDocGiaMuon.Text) == true)
            {
                MessageBox.Show("Trường nhập không được để trống.");
            }
            else if (dg == null)
            {
                MessageBox.Show("Độc giả không tồn tại.");
            }
            else
            {
                var pm = db.PHIEUMUONs.Where(t => t.TENDOCGIA == s).FirstOrDefault();
                if (pm != null)
                {
                    MessageBox.Show("Độc giả này vẫn đang mượn sách nên không thể cho mượn thêm.");
                }
                else
                {
                    DOCGIA docgia = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();
                    DateTime hanSuDung = docgia.HANSUDUNG.Value;
                    DateTime ngayMuon = DateTime.Now;
                    TimeSpan span = ngayMuon.Subtract(hanSuDung);
                    if (span.Days <= 0)
                    {
                        textBoxMaDocGiaMuon.Text = docgia.IDMASOTHE.ToString();
                    }
                    else
                        MessageBox.Show("Thẻ thư viện này đã hết hạn.");
                    
                }
            }
        }

        private void simpleButtonThemMuonSach_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSSachChon.Rows.Count > 1)
            {
                for (int i = 0; i < dataGridViewDSSachChon.Rows.Count-1; i++)
                {
                    string dataDSChon = dataGridViewDSSachChon.Rows[i].Cells[2].Value.ToString();
                    string dataSach = dataGridViewDSSach.CurrentRow.Cells[1].Value.ToString();
                    if (dataDSChon.Equals(dataSach))
                    {
                        MessageBox.Show("Đã thêm sách này.");
                        return;
                    }
                }
            }
            string idSach = dataGridViewDSSach.CurrentRow.Cells[0].Value.ToString();
            string tenSach = dataGridViewDSSach.CurrentRow.Cells[1].Value.ToString();
            SACH s = db.SACHes.Where(t => t.TENSACH == tenSach).FirstOrDefault();
            if (s.SOLUONGTON <= 0)
            {
                MessageBox.Show("Số lượng sách này đã hết.");
            }
            else 
            {
                int index = dataGridViewDSSachChon.Rows.Add();
                dataGridViewDSSachChon.Rows[index].Cells[1].Value = idSach;
                dataGridViewDSSachChon.Rows[index].Cells[2].Value = tenSach;
            }
        }

        private void simpleButtonXoaMuonSach_Click(object sender, EventArgs e)
        {
            if (dataGridViewDSSachChon.Rows.Count > 1)
            {
                dataGridViewDSSachChon.Rows.RemoveAt(dataGridViewDSSachChon.CurrentRow.Index);
            }
        }

        private void simpleButtonXacNhanMuon_Click(object sender, EventArgs e)
        {
            string s = textBoxTenDocGiaMuon.Text;
            var dg = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxTenDocGiaMuon.Text) == true)
            {
                MessageBox.Show("Trường nhập không được để trống.");
            }
            else if (dg == null)
            {
                MessageBox.Show("Độc giả không tồn tại.");
            }
            else
            {
                var p = db.PHIEUMUONs.Where(t => t.TENDOCGIA == s).FirstOrDefault();
                if (p != null)
                {
                    MessageBox.Show("Độc giả này vẫn đang mượn sách nên không thể cho mượn thêm.");
                }
                else if (dataGridViewDSSachChon.Rows.Count == 1)
                {
                    MessageBox.Show("Chưa có sách.");
                }
                else
                {
                    DOCGIA docgia = db.DOCGIAs.Where(t => t.HOTEN == s).FirstOrDefault();
                    DateTime hanSuDung = docgia.HANSUDUNG.Value;
                    DateTime ngayMuon = DateTime.Now;
                    TimeSpan span = ngayMuon.Subtract(hanSuDung);
                    if (span.Days <= 0)
                    {
                        textBoxMaDocGiaMuon.Text = docgia.IDMASOTHE.ToString();
                    }
                    else
                        MessageBox.Show("Thẻ thư viện này đã hết hạn.");

                    PHIEUMUON pm = new PHIEUMUON();
                    NHANVIEN nv = db.NHANVIENs.Where(t => t.USERNAME == XtraFormMainThuThu.userName).FirstOrDefault();

                    pm.IDMATHEDOCGIA = int.Parse(textBoxMaDocGiaMuon.Text);
                    pm.TENDOCGIA = textBoxTenDocGiaMuon.Text;
                    pm.IDTHUTHU = nv.ID;
                    pm.HOTENTHUTHU = textBoxThuThuMuon.Text;
                    pm.NGAYMUON = dateTimePickerNgayMuon.Value;
                    pm.NGAYTRA = dateTimePickerNgayTra.Value;
                    db.PHIEUMUONs.InsertOnSubmit(pm);
                    db.SubmitChanges();

                    PHIEUMUON pmid = db.PHIEUMUONs.Where(t => t.IDMATHEDOCGIA == int.Parse(textBoxMaDocGiaMuon.Text)).FirstOrDefault();
                    int id = pmid.ID;

                    for (int i = 0; i < dataGridViewDSSachChon.Rows.Count-1; i++)
                    {
                        CHITIETPHIEUMUON ct = new CHITIETPHIEUMUON();
                        string tenSach = dataGridViewDSSachChon.Rows[i].Cells[2].Value.ToString();
                        ct.IDSACH = int.Parse(dataGridViewDSSachChon.Rows[i].Cells[1].Value.ToString());
                        ct.TENSACH = tenSach;
                        ct.IDPHIEUMUON = id;
                        db.CHITIETPHIEUMUONs.InsertOnSubmit(ct);
                        db.SubmitChanges();

                        SACH sach = db.SACHes.Where(t => t.TENSACH == tenSach).FirstOrDefault();
                        sach.SOLUONGTON--;
                        sach.SOLUONGMUON++;
                        db.SubmitChanges();
                    }

                    WordExport w = new WordExport();
                    w.Muon(id.ToString(), pm.TENDOCGIA, pm.HOTENTHUTHU, pm.NGAYMUON.ToShortDateString(), pm.NGAYTRA.ToShortDateString());

                    MessageBox.Show("Đã mượn sách.");
                    reload();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}