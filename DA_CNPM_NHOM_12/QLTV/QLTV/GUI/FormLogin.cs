using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace GUI
{
    public partial class FormLogin : DevExpress.XtraEditors.XtraForm
    {
        DatabaseDataContext db;
        public static String userName;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonDangKyForm_Click(object sender, EventArgs e)
        {
            FormRegister dk = new FormRegister();
            dk.ShowDialog();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {

            /*Con = new SqlConnection();
            Con.ConnectionString = @"Data Source=LAPTOP-96MF1DFE;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            SqlDataAdapter da = new SqlDataAdapter("Select count(*) From TAIKHOAN where USERNAME=N'" + txtuser.Text + "' and MatKhau='" + txtmk.Text + "'", Con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Con.Open();
                string select = "Select * From taikhoan where USERNAME='" + txtuser.Text + "' and MATKHAU='" + txtmk.Text + "' and Quyen='Admin'";
                SqlCommand cmd = new SqlCommand(select, Con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    reader.Read();
                    MessageBox.Show("Đăng nhập vào hệ thống (Quyền Admin) !", "Thông báo !");
                    XtraFormMain frm = new XtraFormMain();
                    this.Hide();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Đăng nhập vào hệ thống (Quyền user) !", "Thông báo !");
                    frmuser frm = new frmuser();
                    this.Hide();
                    frm.Show();
                }


            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu k đúng!", "Thông báo !");
            }*/


            String username = textBoxUsername.Text;
            String password = textBoxPassword.Text;

            var user = (from u in db.TAIKHOANs where u.USERNAME.Equals(username) select u).FirstOrDefault();

            if (string.IsNullOrWhiteSpace(textBoxUsername.Text) == true || string.IsNullOrWhiteSpace(textBoxPassword.Text) == true)
            {
                MessageBox.Show("Các trường nhập không được để trống.");
            }
            else if (user == null)
            {
                MessageBox.Show("Tài khoản không tồn tại.");
            }
            else if (!user.MATKHAU.Equals(password))
            {
                MessageBox.Show("Sai mật khẩu.");
            }
            else
            {
                userName = username;
                if (!user.QUYEN.Equals("admin"))
                {
                    this.Hide();
                    XtraFormMainThuThu m = new XtraFormMainThuThu();
                    m.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    frmAdmin m = new frmAdmin();
                    m.ShowDialog();
                    this.Show();
                }
                
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            db = new DatabaseDataContext();
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
