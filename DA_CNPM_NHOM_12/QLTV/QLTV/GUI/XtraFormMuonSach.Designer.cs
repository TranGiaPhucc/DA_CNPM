namespace GUI
{
    partial class XtraFormMuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormMuonSach));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerNgayTra = new System.Windows.Forms.DateTimePicker();
            this.textBoxMaDocGiaMuon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThuThuMuon = new System.Windows.Forms.TextBox();
            this.textBoxTenDocGiaMuon = new System.Windows.Forms.TextBox();
            this.dataGridViewDSSach = new System.Windows.Forms.DataGridView();
            this.dataGridViewDSSachChon = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENSACH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPHIEUMUON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.simpleButtonThemMuonSach = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXoaMuonSach = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonXacNhanMuon = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonKiemTraDocGia = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSachChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã độc giả";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(40, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(40, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày trả";
            // 
            // dateTimePickerNgayMuon
            // 
            this.dateTimePickerNgayMuon.Location = new System.Drawing.Point(127, 170);
            this.dateTimePickerNgayMuon.Name = "dateTimePickerNgayMuon";
            this.dateTimePickerNgayMuon.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerNgayMuon.TabIndex = 5;
            this.dateTimePickerNgayMuon.ValueChanged += new System.EventHandler(this.dateTimePickerNgayMuon_ValueChanged);
            // 
            // dateTimePickerNgayTra
            // 
            this.dateTimePickerNgayTra.Location = new System.Drawing.Point(127, 222);
            this.dateTimePickerNgayTra.Name = "dateTimePickerNgayTra";
            this.dateTimePickerNgayTra.Size = new System.Drawing.Size(200, 21);
            this.dateTimePickerNgayTra.TabIndex = 6;
            // 
            // textBoxMaDocGiaMuon
            // 
            this.textBoxMaDocGiaMuon.Location = new System.Drawing.Point(127, 42);
            this.textBoxMaDocGiaMuon.Name = "textBoxMaDocGiaMuon";
            this.textBoxMaDocGiaMuon.Size = new System.Drawing.Size(100, 21);
            this.textBoxMaDocGiaMuon.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(40, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Thủ thư";
            // 
            // textBoxThuThuMuon
            // 
            this.textBoxThuThuMuon.Location = new System.Drawing.Point(127, 129);
            this.textBoxThuThuMuon.Name = "textBoxThuThuMuon";
            this.textBoxThuThuMuon.Size = new System.Drawing.Size(162, 21);
            this.textBoxThuThuMuon.TabIndex = 9;
            // 
            // textBoxTenDocGiaMuon
            // 
            this.textBoxTenDocGiaMuon.Location = new System.Drawing.Point(127, 85);
            this.textBoxTenDocGiaMuon.Name = "textBoxTenDocGiaMuon";
            this.textBoxTenDocGiaMuon.Size = new System.Drawing.Size(162, 21);
            this.textBoxTenDocGiaMuon.TabIndex = 10;
            // 
            // dataGridViewDSSach
            // 
            this.dataGridViewDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSach.Location = new System.Drawing.Point(80, 287);
            this.dataGridViewDSSach.Name = "dataGridViewDSSach";
            this.dataGridViewDSSach.Size = new System.Drawing.Size(771, 195);
            this.dataGridViewDSSach.TabIndex = 11;
            this.dataGridViewDSSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDSSach_CellContentClick);
            // 
            // dataGridViewDSSachChon
            // 
            this.dataGridViewDSSachChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSSachChon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.IDSACH,
            this.TENSACH,
            this.IDPHIEUMUON});
            this.dataGridViewDSSachChon.Location = new System.Drawing.Point(641, 72);
            this.dataGridViewDSSachChon.Name = "dataGridViewDSSachChon";
            this.dataGridViewDSSachChon.Size = new System.Drawing.Size(222, 181);
            this.dataGridViewDSSachChon.TabIndex = 12;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // IDSACH
            // 
            this.IDSACH.HeaderText = "IDSACH";
            this.IDSACH.Name = "IDSACH";
            this.IDSACH.Visible = false;
            // 
            // TENSACH
            // 
            this.TENSACH.HeaderText = "TENSACH";
            this.TENSACH.Name = "TENSACH";
            // 
            // IDPHIEUMUON
            // 
            this.IDPHIEUMUON.HeaderText = "IDPHIEUMUON";
            this.IDPHIEUMUON.Name = "IDPHIEUMUON";
            this.IDPHIEUMUON.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(637, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sách được chọn";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // simpleButtonThemMuonSach
            // 
            this.simpleButtonThemMuonSach.Location = new System.Drawing.Point(417, 220);
            this.simpleButtonThemMuonSach.Name = "simpleButtonThemMuonSach";
            this.simpleButtonThemMuonSach.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonThemMuonSach.TabIndex = 14;
            this.simpleButtonThemMuonSach.Text = "Thêm";
            this.simpleButtonThemMuonSach.Click += new System.EventHandler(this.simpleButtonThemMuonSach_Click);
            // 
            // simpleButtonXoaMuonSach
            // 
            this.simpleButtonXoaMuonSach.Location = new System.Drawing.Point(519, 220);
            this.simpleButtonXoaMuonSach.Name = "simpleButtonXoaMuonSach";
            this.simpleButtonXoaMuonSach.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonXoaMuonSach.TabIndex = 15;
            this.simpleButtonXoaMuonSach.Text = "Xoá";
            this.simpleButtonXoaMuonSach.Click += new System.EventHandler(this.simpleButtonXoaMuonSach_Click);
            // 
            // simpleButtonXacNhanMuon
            // 
            this.simpleButtonXacNhanMuon.Location = new System.Drawing.Point(657, 507);
            this.simpleButtonXacNhanMuon.Name = "simpleButtonXacNhanMuon";
            this.simpleButtonXacNhanMuon.Size = new System.Drawing.Size(174, 23);
            this.simpleButtonXacNhanMuon.TabIndex = 16;
            this.simpleButtonXacNhanMuon.Text = "Xác nhận mượn và in phiếu";
            this.simpleButtonXacNhanMuon.Click += new System.EventHandler(this.simpleButtonXacNhanMuon_Click);
            // 
            // simpleButtonKiemTraDocGia
            // 
            this.simpleButtonKiemTraDocGia.Location = new System.Drawing.Point(355, 220);
            this.simpleButtonKiemTraDocGia.Name = "simpleButtonKiemTraDocGia";
            this.simpleButtonKiemTraDocGia.Size = new System.Drawing.Size(32, 23);
            this.simpleButtonKiemTraDocGia.TabIndex = 17;
            this.simpleButtonKiemTraDocGia.Text = "KT";
            this.simpleButtonKiemTraDocGia.Click += new System.EventHandler(this.simpleButtonKiemTraDocGia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(884, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XtraFormMuonSach
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(934, 569);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButtonKiemTraDocGia);
            this.Controls.Add(this.simpleButtonXacNhanMuon);
            this.Controls.Add(this.simpleButtonXoaMuonSach);
            this.Controls.Add(this.simpleButtonThemMuonSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewDSSachChon);
            this.Controls.Add(this.dataGridViewDSSach);
            this.Controls.Add(this.textBoxTenDocGiaMuon);
            this.Controls.Add(this.textBoxThuThuMuon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxMaDocGiaMuon);
            this.Controls.Add(this.dateTimePickerNgayTra);
            this.Controls.Add(this.dateTimePickerNgayMuon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XtraFormMuonSach";
            this.Text = "Mượn sách";
            this.Load += new System.EventHandler(this.XtraFormMuonSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSSachChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayMuon;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgayTra;
        private System.Windows.Forms.TextBox textBoxMaDocGiaMuon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxThuThuMuon;
        private System.Windows.Forms.TextBox textBoxTenDocGiaMuon;
        private System.Windows.Forms.DataGridView dataGridViewDSSach;
        private System.Windows.Forms.DataGridView dataGridViewDSSachChon;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonThemMuonSach;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXoaMuonSach;
        private DevExpress.XtraEditors.SimpleButton simpleButtonXacNhanMuon;
        private DevExpress.XtraEditors.SimpleButton simpleButtonKiemTraDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENSACH;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPHIEUMUON;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}