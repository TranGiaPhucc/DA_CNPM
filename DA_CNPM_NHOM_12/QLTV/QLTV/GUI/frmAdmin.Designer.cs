namespace GUI
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.simpleButtonTraSachAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonMuonSachAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonTheThuVienAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonQuanLySachAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonDangXuatAdmin = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonTraSachAdmin
            // 
            this.simpleButtonTraSachAdmin.Location = new System.Drawing.Point(753, 30);
            this.simpleButtonTraSachAdmin.Name = "simpleButtonTraSachAdmin";
            this.simpleButtonTraSachAdmin.Size = new System.Drawing.Size(120, 23);
            this.simpleButtonTraSachAdmin.TabIndex = 9;
            this.simpleButtonTraSachAdmin.Text = "Danh sách mượn trả";
            this.simpleButtonTraSachAdmin.Click += new System.EventHandler(this.simpleButtonTraSachAdmin_Click);
            // 
            // simpleButtonMuonSachAdmin
            // 
            this.simpleButtonMuonSachAdmin.Location = new System.Drawing.Point(538, 30);
            this.simpleButtonMuonSachAdmin.Name = "simpleButtonMuonSachAdmin";
            this.simpleButtonMuonSachAdmin.Size = new System.Drawing.Size(120, 23);
            this.simpleButtonMuonSachAdmin.TabIndex = 8;
            this.simpleButtonMuonSachAdmin.Text = "Phân quyền nhân viên";
            this.simpleButtonMuonSachAdmin.Click += new System.EventHandler(this.simpleButtonMuonSachAdmin_Click);
            // 
            // simpleButtonTheThuVienAdmin
            // 
            this.simpleButtonTheThuVienAdmin.Location = new System.Drawing.Point(313, 30);
            this.simpleButtonTheThuVienAdmin.Name = "simpleButtonTheThuVienAdmin";
            this.simpleButtonTheThuVienAdmin.Size = new System.Drawing.Size(120, 23);
            this.simpleButtonTheThuVienAdmin.TabIndex = 7;
            this.simpleButtonTheThuVienAdmin.Text = "Thẻ thư viện";
            this.simpleButtonTheThuVienAdmin.Click += new System.EventHandler(this.simpleButtonTheThuVienAdmin_Click);
            // 
            // simpleButtonQuanLySachAdmin
            // 
            this.simpleButtonQuanLySachAdmin.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButtonQuanLySachAdmin.Appearance.Options.UseForeColor = true;
            this.simpleButtonQuanLySachAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButtonQuanLySachAdmin.Location = new System.Drawing.Point(90, 30);
            this.simpleButtonQuanLySachAdmin.Name = "simpleButtonQuanLySachAdmin";
            this.simpleButtonQuanLySachAdmin.Size = new System.Drawing.Size(120, 23);
            this.simpleButtonQuanLySachAdmin.TabIndex = 6;
            this.simpleButtonQuanLySachAdmin.Text = "Quản lý sách";
            this.simpleButtonQuanLySachAdmin.Click += new System.EventHandler(this.simpleButtonQuanLySachAdmin_Click);
            // 
            // simpleButtonDangXuatAdmin
            // 
            this.simpleButtonDangXuatAdmin.Location = new System.Drawing.Point(838, 419);
            this.simpleButtonDangXuatAdmin.Name = "simpleButtonDangXuatAdmin";
            this.simpleButtonDangXuatAdmin.Size = new System.Drawing.Size(118, 18);
            this.simpleButtonDangXuatAdmin.TabIndex = 3;
            this.simpleButtonDangXuatAdmin.Text = "Đăng xuất";
            this.simpleButtonDangXuatAdmin.Click += new System.EventHandler(this.simpleButtonDangXuatAdmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(981, 452);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.simpleButtonDangXuatAdmin);
            this.Controls.Add(this.simpleButtonTraSachAdmin);
            this.Controls.Add(this.simpleButtonMuonSachAdmin);
            this.Controls.Add(this.simpleButtonTheThuVienAdmin);
            this.Controls.Add(this.simpleButtonQuanLySachAdmin);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAdmin";
            this.Text = "Quản lý thư viện (Admin)";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton simpleButtonTraSachAdmin;
        private DevExpress.XtraEditors.SimpleButton simpleButtonMuonSachAdmin;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTheThuVienAdmin;
        private DevExpress.XtraEditors.SimpleButton simpleButtonQuanLySachAdmin;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDangXuatAdmin;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}