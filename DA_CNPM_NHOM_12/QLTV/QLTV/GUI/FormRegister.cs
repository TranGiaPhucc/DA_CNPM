using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class FormRegister : Form
    {
        DatabaseDataContext db = new DatabaseDataContext();
        public FormRegister()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTenDangKy_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {  
            String username = textBoxUsernameReg.Text;
            String password = textBoxPasswordReg.Text;
            String hoten = textBoxTenHienThi.Text;

            var user = (from u in db.TAIKHOANs where u.USERNAME.Equals(username) select u).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxUsernameReg.Text) == true || string.IsNullOrWhiteSpace(textBoxPasswordReg.Text) == true || string.IsNullOrWhiteSpace(textBoxConfirmPasswordReg.Text) == true)
            {
                MessageBox.Show("Các trường nhập không được để trống.");
            }
            else if (user != null)
            {
                MessageBox.Show("Tài khoản đã tồn tại.");
            }
            else if (textBoxConfirmPasswordReg.ToString().Equals(textBoxPasswordReg.ToString()) == false)
            {
                MessageBox.Show("Xác nhận mật khẩu không trùng khớp.");
            }
            else
            {
                TAIKHOAN dn = new TAIKHOAN();
                NHANVIEN nv = new NHANVIEN();
                dn.USERNAME = username;
                dn.MATKHAU = password;
                dn.HOTEN = hoten;
                nv.HOTEN = hoten;
                nv.USERNAME = username;
                nv.NGAYVAOLAM = DateTime.Today;
                db.TAIKHOANs.InsertOnSubmit(dn);
                db.NHANVIENs.InsertOnSubmit(nv);
                db.SubmitChanges();
                MessageBox.Show("Đăng ký mới thành công.");
                this.Close();
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
