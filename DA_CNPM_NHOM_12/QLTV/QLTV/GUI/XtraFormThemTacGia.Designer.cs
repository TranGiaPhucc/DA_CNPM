namespace GUI
{
    partial class XtraFormThemTacGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormThemTacGia));
            this.simpleButtonTacGiaThem = new DevExpress.XtraEditors.SimpleButton();
            this.textEditTacGiaTim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridViewTacGia = new System.Windows.Forms.DataGridView();
            this.simpleButtonTacGiaXoa = new DevExpress.XtraEditors.SimpleButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEditTacGiaTim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButtonTacGiaThem
            // 
            this.simpleButtonTacGiaThem.Location = new System.Drawing.Point(39, 128);
            this.simpleButtonTacGiaThem.Name = "simpleButtonTacGiaThem";
            this.simpleButtonTacGiaThem.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonTacGiaThem.TabIndex = 9;
            this.simpleButtonTacGiaThem.Text = "Thêm";
            this.simpleButtonTacGiaThem.Click += new System.EventHandler(this.simpleButtonTacGiaThem_Click);
            // 
            // textEditTacGiaTim
            // 
            this.textEditTacGiaTim.Location = new System.Drawing.Point(85, 80);
            this.textEditTacGiaTim.Name = "textEditTacGiaTim";
            this.textEditTacGiaTim.Size = new System.Drawing.Size(143, 20);
            this.textEditTacGiaTim.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Location = new System.Drawing.Point(36, 81);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 17);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Tác giả";
            // 
            // dataGridViewTacGia
            // 
            this.dataGridViewTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTacGia.Location = new System.Drawing.Point(39, 174);
            this.dataGridViewTacGia.Name = "dataGridViewTacGia";
            this.dataGridViewTacGia.Size = new System.Drawing.Size(240, 296);
            this.dataGridViewTacGia.TabIndex = 6;
            this.dataGridViewTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTacGia_CellContentClick);
            // 
            // simpleButtonTacGiaXoa
            // 
            this.simpleButtonTacGiaXoa.Location = new System.Drawing.Point(180, 128);
            this.simpleButtonTacGiaXoa.Name = "simpleButtonTacGiaXoa";
            this.simpleButtonTacGiaXoa.Size = new System.Drawing.Size(75, 23);
            this.simpleButtonTacGiaXoa.TabIndex = 10;
            this.simpleButtonTacGiaXoa.Text = "Xoá";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(261, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // XtraFormThemTacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(312, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.simpleButtonTacGiaXoa);
            this.Controls.Add(this.simpleButtonTacGiaThem);
            this.Controls.Add(this.textEditTacGiaTim);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataGridViewTacGia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XtraFormThemTacGia";
            this.Text = "Tác giả";
            this.Load += new System.EventHandler(this.XtraFormThemTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEditTacGiaTim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTacGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButtonTacGiaThem;
        private DevExpress.XtraEditors.TextEdit textEditTacGiaTim;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridViewTacGia;
        private DevExpress.XtraEditors.SimpleButton simpleButtonTacGiaXoa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}