namespace GUI
{
    partial class XtraFormDSNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDSNhanVien));
            this.dataGridViewDSNhanVien = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxPhanQuyen = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControlHoTenNV = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditUsername = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonTim = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTim = new DevExpress.XtraEditors.TextEdit();
            this.simpleButtonDoiMK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonPhanQuyen = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSNhanVien
            // 
            this.dataGridViewDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSNhanVien.Location = new System.Drawing.Point(82, 224);
            this.dataGridViewDSNhanVien.Name = "dataGridViewDSNhanVien";
            this.dataGridViewDSNhanVien.Size = new System.Drawing.Size(360, 198);
            this.dataGridViewDSNhanVien.TabIndex = 3;
            this.dataGridViewDSNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSNhanVien_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(458, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // comboBoxPhanQuyen
            // 
            this.comboBoxPhanQuyen.FormattingEnabled = true;
            this.comboBoxPhanQuyen.Location = new System.Drawing.Point(188, 103);
            this.comboBoxPhanQuyen.Name = "comboBoxPhanQuyen";
            this.comboBoxPhanQuyen.Size = new System.Drawing.Size(118, 21);
            this.comboBoxPhanQuyen.TabIndex = 48;
            this.comboBoxPhanQuyen.SelectedIndexChanged += new System.EventHandler(this.comboBoxGioiTinhDocGia_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(91, 107);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Phân quyền:";
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(189, 65);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Size = new System.Drawing.Size(156, 20);
            this.textEditPassword.TabIndex = 51;
            // 
            // labelControlHoTenNV
            // 
            this.labelControlHoTenNV.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControlHoTenNV.Location = new System.Drawing.Point(189, 68);
            this.labelControlHoTenNV.Name = "labelControlHoTenNV";
            this.labelControlHoTenNV.Size = new System.Drawing.Size(0, 13);
            this.labelControlHoTenNV.TabIndex = 50;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(91, 66);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 17);
            this.labelControl1.TabIndex = 49;
            this.labelControl1.Text = "Mật khẩu";
            // 
            // textEditUsername
            // 
            this.textEditUsername.Location = new System.Drawing.Point(189, 28);
            this.textEditUsername.Name = "textEditUsername";
            this.textEditUsername.Size = new System.Drawing.Size(156, 20);
            this.textEditUsername.TabIndex = 54;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(189, 31);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(0, 13);
            this.labelControl2.TabIndex = 53;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(91, 29);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 16);
            this.labelControl4.TabIndex = 52;
            this.labelControl4.Text = "Username:";
            // 
            // simpleButtonTim
            // 
            this.simpleButtonTim.Location = new System.Drawing.Point(221, 170);
            this.simpleButtonTim.Name = "simpleButtonTim";
            this.simpleButtonTim.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonTim.TabIndex = 57;
            this.simpleButtonTim.Text = "Tìm";
            this.simpleButtonTim.Click += new System.EventHandler(this.simpleButtonTim_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Location = new System.Drawing.Point(55, 173);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(38, 16);
            this.labelControl8.TabIndex = 56;
            this.labelControl8.Text = "Tìm ID";
            // 
            // textEditTim
            // 
            this.textEditTim.Location = new System.Drawing.Point(102, 172);
            this.textEditTim.Name = "textEditTim";
            this.textEditTim.Size = new System.Drawing.Size(113, 20);
            this.textEditTim.TabIndex = 55;
            // 
            // simpleButtonDoiMK
            // 
            this.simpleButtonDoiMK.Location = new System.Drawing.Point(302, 170);
            this.simpleButtonDoiMK.Name = "simpleButtonDoiMK";
            this.simpleButtonDoiMK.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonDoiMK.TabIndex = 58;
            this.simpleButtonDoiMK.Text = "Đổi MK";
            this.simpleButtonDoiMK.Click += new System.EventHandler(this.simpleButtonDoiMK_Click);
            // 
            // simpleButtonPhanQuyen
            // 
            this.simpleButtonPhanQuyen.Location = new System.Drawing.Point(383, 170);
            this.simpleButtonPhanQuyen.Name = "simpleButtonPhanQuyen";
            this.simpleButtonPhanQuyen.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonPhanQuyen.TabIndex = 59;
            this.simpleButtonPhanQuyen.Text = "Phân quyền";
            this.simpleButtonPhanQuyen.Click += new System.EventHandler(this.simpleButtonPhanQuyen_Click);
            // 
            // XtraFormDSNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(520, 472);
            this.Controls.Add(this.simpleButtonPhanQuyen);
            this.Controls.Add(this.simpleButtonDoiMK);
            this.Controls.Add(this.simpleButtonTim);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEditTim);
            this.Controls.Add(this.textEditUsername);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditPassword);
            this.Controls.Add(this.labelControlHoTenNV);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.comboBoxPhanQuyen);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewDSNhanVien);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XtraFormDSNhanVien";
            this.Text = "Danh sách nhân viên và phân quyền";
            this.Load += new System.EventHandler(this.XtraFormDSMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTim.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxPhanQuyen;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditPassword;
        private DevExpress.XtraEditors.LabelControl labelControlHoTenNV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditUsername;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTim;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEditTim;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDoiMK;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPhanQuyen;
    }
}