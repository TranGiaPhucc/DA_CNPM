namespace GUI
{
    partial class FormRegister
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
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.textBoxPasswordReg = new System.Windows.Forms.TextBox();
            this.textBoxUsernameReg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConfirmPasswordReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDangKy = new System.Windows.Forms.Button();
            this.textBoxTenHienThi = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = System.Drawing.Color.Transparent;
            label5.ForeColor = System.Drawing.Color.Transparent;
            label5.Location = new System.Drawing.Point(155, 570);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 13);
            label5.TabIndex = 19;
            label5.Text = "Tên hiển thị";
            // 
            // textBoxPasswordReg
            // 
            this.textBoxPasswordReg.Location = new System.Drawing.Point(158, 421);
            this.textBoxPasswordReg.Name = "textBoxPasswordReg";
            this.textBoxPasswordReg.Size = new System.Drawing.Size(349, 20);
            this.textBoxPasswordReg.TabIndex = 12;
            this.textBoxPasswordReg.UseSystemPasswordChar = true;
            this.textBoxPasswordReg.TextChanged += new System.EventHandler(this.textBoxMatKhau_TextChanged);
            // 
            // textBoxUsernameReg
            // 
            this.textBoxUsernameReg.Location = new System.Drawing.Point(158, 331);
            this.textBoxUsernameReg.Name = "textBoxUsernameReg";
            this.textBoxUsernameReg.Size = new System.Drawing.Size(349, 20);
            this.textBoxUsernameReg.TabIndex = 11;
            this.textBoxUsernameReg.TextChanged += new System.EventHandler(this.textBoxTenDangKy_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(155, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(155, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên đăng nhập";
            // 
            // textBoxConfirmPasswordReg
            // 
            this.textBoxConfirmPasswordReg.Location = new System.Drawing.Point(158, 509);
            this.textBoxConfirmPasswordReg.Name = "textBoxConfirmPasswordReg";
            this.textBoxConfirmPasswordReg.Size = new System.Drawing.Size(349, 20);
            this.textBoxConfirmPasswordReg.TabIndex = 17;
            this.textBoxConfirmPasswordReg.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(155, 473);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Xác nhận mật khẩu";
            // 
            // buttonDangKy
            // 
            this.buttonDangKy.Location = new System.Drawing.Point(158, 722);
            this.buttonDangKy.Name = "buttonDangKy";
            this.buttonDangKy.Size = new System.Drawing.Size(337, 45);
            this.buttonDangKy.TabIndex = 18;
            this.buttonDangKy.Text = "Đăng ký";
            this.buttonDangKy.UseVisualStyleBackColor = true;
            this.buttonDangKy.Click += new System.EventHandler(this.buttonDangKy_Click);
            // 
            // textBoxTenHienThi
            // 
            this.textBoxTenHienThi.Location = new System.Drawing.Point(158, 609);
            this.textBoxTenHienThi.Name = "textBoxTenHienThi";
            this.textBoxTenHienThi.Size = new System.Drawing.Size(347, 20);
            this.textBoxTenHienThi.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1152, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1202, 899);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxTenHienThi);
            this.Controls.Add(label5);
            this.Controls.Add(this.buttonDangKy);
            this.Controls.Add(this.textBoxConfirmPasswordReg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPasswordReg);
            this.Controls.Add(this.textBoxUsernameReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormRegister";
            this.Text = "Đăng ký";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPasswordReg;
        private System.Windows.Forms.TextBox textBoxUsernameReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConfirmPasswordReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDangKy;
        private System.Windows.Forms.TextBox textBoxTenHienThi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}