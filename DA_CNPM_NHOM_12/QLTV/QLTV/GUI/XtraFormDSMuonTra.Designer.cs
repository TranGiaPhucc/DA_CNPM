namespace GUI
{
    partial class XtraFormDSMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XtraFormDSMuonTra));
            this.dataGridViewDSTra = new System.Windows.Forms.DataGridView();
            this.DOCGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHANVIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewDSMuon = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textEditPhieuMuon = new DevExpress.XtraEditors.TextEdit();
            this.textEditPhieuTra = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSMuon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhieuMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhieuTra.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDSTra
            // 
            this.dataGridViewDSTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCGIA,
            this.NHANVIEN});
            this.dataGridViewDSTra.Location = new System.Drawing.Point(430, 142);
            this.dataGridViewDSTra.Name = "dataGridViewDSTra";
            this.dataGridViewDSTra.Size = new System.Drawing.Size(335, 339);
            this.dataGridViewDSTra.TabIndex = 1;
            this.dataGridViewDSTra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DOCGIA
            // 
            this.DOCGIA.DataPropertyName = "DOCGIA";
            this.DOCGIA.HeaderText = "DOCGIA";
            this.DOCGIA.Name = "DOCGIA";
            this.DOCGIA.Visible = false;
            // 
            // NHANVIEN
            // 
            this.NHANVIEN.DataPropertyName = "NHANVIEN";
            this.NHANVIEN.HeaderText = "NHANVIEN";
            this.NHANVIEN.Name = "NHANVIEN";
            this.NHANVIEN.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(751, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridViewDSMuon
            // 
            this.dataGridViewDSMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDSMuon.Location = new System.Drawing.Point(36, 142);
            this.dataGridViewDSMuon.Name = "dataGridViewDSMuon";
            this.dataGridViewDSMuon.Size = new System.Drawing.Size(360, 339);
            this.dataGridViewDSMuon.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số phiếu mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(435, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 27);
            this.label1.TabIndex = 37;
            this.label1.Text = "Số phiếu trả";
            // 
            // textEditPhieuMuon
            // 
            this.textEditPhieuMuon.Location = new System.Drawing.Point(218, 73);
            this.textEditPhieuMuon.Name = "textEditPhieuMuon";
            this.textEditPhieuMuon.Size = new System.Drawing.Size(156, 20);
            this.textEditPhieuMuon.TabIndex = 38;
            // 
            // textEditPhieuTra
            // 
            this.textEditPhieuTra.Location = new System.Drawing.Point(583, 73);
            this.textEditPhieuTra.Name = "textEditPhieuTra";
            this.textEditPhieuTra.Size = new System.Drawing.Size(156, 20);
            this.textEditPhieuTra.TabIndex = 39;
            // 
            // XtraFormDSMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(801, 561);
            this.Controls.Add(this.textEditPhieuTra);
            this.Controls.Add(this.textEditPhieuMuon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewDSMuon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridViewDSTra);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "XtraFormDSMuonTra";
            this.Text = "Danh sách phiếu mượn trả";
            this.Load += new System.EventHandler(this.XtraFormDSTra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSTra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDSMuon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhieuMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhieuTra.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDSTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHANVIEN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewDSMuon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEditPhieuMuon;
        private DevExpress.XtraEditors.TextEdit textEditPhieuTra;
    }
}