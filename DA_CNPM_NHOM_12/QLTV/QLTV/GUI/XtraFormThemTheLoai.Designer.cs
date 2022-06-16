namespace GUI
{
    partial class XtraFormThemTheLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormThemTheLoai));
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.simpleButtonTheLoaiThem = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonTheLoaiXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEditTheLoaiTim = new DevExpress.XtraEditors.TextEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTheLoaiTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(468, 227);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTheLoai.TabIndex = 0;
            this.dataGridViewTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTheLoai_CellContentClick);
            // 
            // simpleButtonTheLoaiThem
            // 
            this.simpleButtonTheLoaiThem.Location = new System.Drawing.Point(468, 178);
            this.simpleButtonTheLoaiThem.Name = "simpleButtonTheLoaiThem";
            this.simpleButtonTheLoaiThem.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonTheLoaiThem.TabIndex = 3;
            this.simpleButtonTheLoaiThem.Text = "Thêm";
            this.simpleButtonTheLoaiThem.Click += new System.EventHandler(this.simpleButtonThemTheLoai_Click);
            // 
            // simpleButtonTheLoaiXoa
            // 
            this.simpleButtonTheLoaiXoa.Location = new System.Drawing.Point(610, 178);
            this.simpleButtonTheLoaiXoa.Name = "simpleButtonTheLoaiXoa";
            this.simpleButtonTheLoaiXoa.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonTheLoaiXoa.TabIndex = 5;
            this.simpleButtonTheLoaiXoa.Text = "Xoá";
            this.simpleButtonTheLoaiXoa.Click += new System.EventHandler(this.simpleButtonTheLoaiXoa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(399, 85);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 17);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Thể loại";
            // 
            // textEditTheLoaiTim
            // 
            this.textEditTheLoaiTim.Location = new System.Drawing.Point(468, 82);
            this.textEditTheLoaiTim.Name = "textEditTheLoaiTim";
            this.textEditTheLoaiTim.Size = new System.Drawing.Size(143, 20);
            this.textEditTheLoaiTim.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(671, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XtraFormThemTheLoai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(720, 451);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButtonTheLoaiXoa);
            this.Controls.Add(this.simpleButtonTheLoaiThem);
            this.Controls.Add(this.textEditTheLoaiTim);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataGridViewTheLoai);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XtraFormThemTheLoai";
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.XtraFormThemTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTheLoaiTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTheLoaiThem;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTheLoaiXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditTheLoaiTim;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}