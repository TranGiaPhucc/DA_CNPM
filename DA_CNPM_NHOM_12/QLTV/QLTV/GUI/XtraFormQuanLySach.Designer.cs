namespace GUI
{
    partial class XtraFormQuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormQuanLySach));
            this.dataGridViewSach = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTenSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEditSoLuongTon = new DevExpress.XtraEditors.TextEdit();
            this.textEditSoLuongMuon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTimSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThemTheLoai = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThemTacGia = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonThemNhaXuatBan = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxTheLoai = new System.Windows.Forms.ComboBox();
            this.comboBoxTacGia = new System.Windows.Forms.ComboBox();
            this.comboBoxNXB = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuongTon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuongMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimSach.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSach
            // 
            this.dataGridViewSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID});
            this.dataGridViewSach.Location = new System.Drawing.Point(231, 380);
            this.dataGridViewSach.Name = "dataGridViewSach";
            this.dataGridViewSach.Size = new System.Drawing.Size(799, 208);
            this.dataGridViewSach.TabIndex = 0;
            this.dataGridViewSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSach_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(135, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Thể loại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl2.Location = new System.Drawing.Point(135, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tên sách";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl3.Location = new System.Drawing.Point(139, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Tác giả";
            // 
            // textEditTenSach
            // 
            this.textEditTenSach.Location = new System.Drawing.Point(231, 88);
            this.textEditTenSach.Name = "textEditTenSach";
            this.textEditTenSach.Size = new System.Drawing.Size(238, 20);
            this.textEditTenSach.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl4.Location = new System.Drawing.Point(822, 47);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(93, 17);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Nhà xuất bản";
            // 
            // textEditSoLuongTon
            // 
            this.textEditSoLuongTon.Location = new System.Drawing.Point(948, 88);
            this.textEditSoLuongTon.Name = "textEditSoLuongTon";
            this.textEditSoLuongTon.Size = new System.Drawing.Size(117, 20);
            this.textEditSoLuongTon.TabIndex = 8;
            // 
            // textEditSoLuongMuon
            // 
            this.textEditSoLuongMuon.Location = new System.Drawing.Point(948, 129);
            this.textEditSoLuongMuon.Name = "textEditSoLuongMuon";
            this.textEditSoLuongMuon.Size = new System.Drawing.Size(117, 20);
            this.textEditSoLuongMuon.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl6.Location = new System.Drawing.Point(822, 91);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 17);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "Số lượng tồn";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl7.Location = new System.Drawing.Point(822, 132);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 17);
            this.labelControl7.TabIndex = 14;
            this.labelControl7.Text = "Số lượng mượn";
            // 
            // textEditTimSach
            // 
            this.textEditTimSach.Location = new System.Drawing.Point(299, 343);
            this.textEditTimSach.Name = "textEditTimSach";
            this.textEditTimSach.Size = new System.Drawing.Size(446, 20);
            this.textEditTimSach.TabIndex = 15;
            this.textEditTimSach.EditValueChanged += new System.EventHandler(this.textEditTimSach_EditValueChanged);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl8.Location = new System.Drawing.Point(231, 344);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(55, 16);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Tìm sách";
            // 
            // simpleButtonThem
            // 
            this.simpleButtonThem.Location = new System.Drawing.Point(594, 252);
            this.simpleButtonThem.Name = "simpleButtonThem";
            this.simpleButtonThem.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonThem.TabIndex = 17;
            this.simpleButtonThem.Text = "Thêm";
            this.simpleButtonThem.Click += new System.EventHandler(this.simpleButtonThem_Click);
            // 
            // simpleButtonCapNhat
            // 
            this.simpleButtonCapNhat.Location = new System.Drawing.Point(405, 252);
            this.simpleButtonCapNhat.Name = "simpleButtonCapNhat";
            this.simpleButtonCapNhat.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonCapNhat.TabIndex = 18;
            this.simpleButtonCapNhat.Text = "Cập nhật";
            this.simpleButtonCapNhat.Click += new System.EventHandler(this.simpleButtonCapNhat_Click);
            // 
            // simpleButtonXoa
            // 
            this.simpleButtonXoa.Location = new System.Drawing.Point(811, 252);
            this.simpleButtonXoa.Name = "simpleButtonXoa";
            this.simpleButtonXoa.Size = new System.Drawing.Size(87, 23);
            this.simpleButtonXoa.TabIndex = 19;
            this.simpleButtonXoa.Text = "Xoá";
            this.simpleButtonXoa.Click += new System.EventHandler(this.simpleButtonXoa_Click);
            // 
            // simpleButtonThemTheLoai
            // 
            this.simpleButtonThemTheLoai.Location = new System.Drawing.Point(435, 40);
            this.simpleButtonThemTheLoai.Name = "simpleButtonThemTheLoai";
            this.simpleButtonThemTheLoai.Size = new System.Drawing.Size(27, 23);
            this.simpleButtonThemTheLoai.TabIndex = 20;
            this.simpleButtonThemTheLoai.Text = "+";
            this.simpleButtonThemTheLoai.Click += new System.EventHandler(this.simpleButtonThemTheLoai_Click);
            // 
            // simpleButtonThemTacGia
            // 
            this.simpleButtonThemTacGia.Location = new System.Drawing.Point(435, 130);
            this.simpleButtonThemTacGia.Name = "simpleButtonThemTacGia";
            this.simpleButtonThemTacGia.Size = new System.Drawing.Size(27, 23);
            this.simpleButtonThemTacGia.TabIndex = 21;
            this.simpleButtonThemTacGia.Text = "+";
            this.simpleButtonThemTacGia.Click += new System.EventHandler(this.simpleButtonThemTacGia_Click);
            // 
            // simpleButtonThemNhaXuatBan
            // 
            this.simpleButtonThemNhaXuatBan.Location = new System.Drawing.Point(1153, 42);
            this.simpleButtonThemNhaXuatBan.Name = "simpleButtonThemNhaXuatBan";
            this.simpleButtonThemNhaXuatBan.Size = new System.Drawing.Size(27, 23);
            this.simpleButtonThemNhaXuatBan.TabIndex = 22;
            this.simpleButtonThemNhaXuatBan.Text = "+";
            this.simpleButtonThemNhaXuatBan.Click += new System.EventHandler(this.simpleButtonThemNhaXuatBan_Click);
            // 
            // comboBoxTheLoai
            // 
            this.comboBoxTheLoai.FormattingEnabled = true;
            this.comboBoxTheLoai.Location = new System.Drawing.Point(231, 42);
            this.comboBoxTheLoai.Name = "comboBoxTheLoai";
            this.comboBoxTheLoai.Size = new System.Drawing.Size(178, 21);
            this.comboBoxTheLoai.TabIndex = 23;
            // 
            // comboBoxTacGia
            // 
            this.comboBoxTacGia.FormattingEnabled = true;
            this.comboBoxTacGia.Location = new System.Drawing.Point(231, 132);
            this.comboBoxTacGia.Name = "comboBoxTacGia";
            this.comboBoxTacGia.Size = new System.Drawing.Size(178, 21);
            this.comboBoxTacGia.TabIndex = 24;
            // 
            // comboBoxNXB
            // 
            this.comboBoxNXB.FormattingEnabled = true;
            this.comboBoxNXB.Location = new System.Drawing.Point(948, 42);
            this.comboBoxNXB.Name = "comboBoxNXB";
            this.comboBoxNXB.Size = new System.Drawing.Size(178, 21);
            this.comboBoxNXB.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1192, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XtraFormQuanLySach
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(1249, 610);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBoxNXB);
            this.Controls.Add(this.comboBoxTacGia);
            this.Controls.Add(this.comboBoxTheLoai);
            this.Controls.Add(this.simpleButtonThemNhaXuatBan);
            this.Controls.Add(this.simpleButtonThemTacGia);
            this.Controls.Add(this.simpleButtonThemTheLoai);
            this.Controls.Add(this.simpleButtonXoa);
            this.Controls.Add(this.simpleButtonCapNhat);
            this.Controls.Add(this.simpleButtonThem);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.textEditTimSach);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.textEditSoLuongMuon);
            this.Controls.Add(this.textEditSoLuongTon);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEditTenSach);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataGridViewSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XtraFormQuanLySach";
            this.Text = "Thông tin sách";
            this.Load += new System.EventHandler(this.XtraFormQuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTenSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuongTon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditSoLuongMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTimSach.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditTenSach;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEditSoLuongTon;
        private DevExpress.XtraEditors.TextEdit textEditSoLuongMuon;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEditTimSach;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCapNhat;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemTheLoai;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemTacGia;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemNhaXuatBan;
        private System.Windows.Forms.ComboBox comboBoxTheLoai;
        private System.Windows.Forms.ComboBox comboBoxTacGia;
        private System.Windows.Forms.ComboBox comboBoxNXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}