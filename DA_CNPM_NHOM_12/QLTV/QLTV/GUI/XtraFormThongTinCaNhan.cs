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
    public partial class XtraFormThongTinCaNhan : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db = new DatabaseDataContext();
        bool chinhSua = false;

        public XtraFormThongTinCaNhan()
        {
            InitializeComponent();
        }

        private void simpleButtonQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reload()
        {
            controlEditInvisible();
            chinhSua = false;

            var gt = from x in db.GIOITINHs select x;
            comboBoxGioiTinhNV.DataSource = gt;
            comboBoxGioiTinhNV.ValueMember = "GIOITINH1";

            String username = XtraFormMainThuThu.userName;

            NHANVIEN nv = db.NHANVIENs.Where(t => t.USERNAME == username).FirstOrDefault();
            labelControlHoTenNV.Text = nv.HOTEN;
            labelControlNgaySinhNV.Text = nv.NGAYSINH.Value.ToShortDateString();
            labelControlGioiTinhNV.Text = nv.GIOITINH;
            labelControlSDTNV.Text = nv.SODT;
            labelControlCMNDNV.Text = nv.CMND;
            labelControlNgayVaoLam.Text = nv.NGAYVAOLAM.Value.ToShortDateString();
        }

        private void XtraFormThongTinCaNhan_Load(object sender, EventArgs e)
        {
            reload();
        }
        
        private void controlEditVisible()
        {
            textEditHoTenNV.Visible = true;
            dateTimePickerNgaySinhNV.Visible = true;
            comboBoxGioiTinhNV.Visible = true;
            textEditSDTNV.Visible = true;
            textEditCMNDNV.Visible = true;
        }

        private void controlEditInvisible()
        {
            textEditHoTenNV.Visible = false;
            dateTimePickerNgaySinhNV.Visible = false;
            comboBoxGioiTinhNV.Visible = false;
            textEditSDTNV.Visible = false;
            textEditCMNDNV.Visible = false;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!chinhSua)
            {
                controlEditVisible();
                chinhSua = true;
                simpleButton1.Text = "Xác nhận cập nhật";

                String username = XtraFormMainThuThu.userName;

                NHANVIEN nv = db.NHANVIENs.Where(t => t.USERNAME == username).FirstOrDefault();
                textEditHoTenNV.Text = nv.HOTEN;
                dateTimePickerNgaySinhNV.Text = nv.NGAYSINH.ToString();
                comboBoxGioiTinhNV.Text = nv.GIOITINH;
                textEditSDTNV.Text = nv.SODT;
                textEditCMNDNV.Text = nv.CMND;
            }
            else
            {
                if (string.IsNullOrEmpty(textEditHoTenNV.Text) == true || string.IsNullOrEmpty(textEditSDTNV.Text) == true || string.IsNullOrEmpty(textEditCMNDNV.Text) == true)
                    MessageBox.Show("Các trường nhập không được để trống.");
                else
                {
                    String username = XtraFormMainThuThu.userName;
                    NHANVIEN nv = db.NHANVIENs.Where(t => t.USERNAME == username).FirstOrDefault();

                    nv.HOTEN = textEditHoTenNV.Text;
                    nv.GIOITINH = comboBoxGioiTinhNV.Text;
                    nv.NGAYSINH = dateTimePickerNgaySinhNV.Value.Date;
                    nv.SODT = textEditSDTNV.Text;
                    nv.CMND = textEditCMNDNV.Text;

                    db.SubmitChanges();

                    controlEditInvisible();
                    chinhSua = false;
                    simpleButton1.Text = "Chỉnh sửa thông tin";
                    reload();
                }
                
            }
        }

        private void textEditHoTenNV_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGioiTinhNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}