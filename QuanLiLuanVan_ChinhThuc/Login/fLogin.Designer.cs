namespace QuanLiLuanVan_ChinhThuc
{
    partial class fLogin
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
            this.chbHocSinh = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbHocSinh = new System.Windows.Forms.Label();
            this.lbGiaoVien = new System.Windows.Forms.Label();
            this.chbGiaoVien = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lbAdmin = new System.Windows.Forms.Label();
            this.chbAdmin = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnLogin = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbHocSinh
            // 
            this.chbHocSinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chbHocSinh.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.chbHocSinh.Checked = true;
            this.chbHocSinh.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chbHocSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHocSinh.ForeColor = System.Drawing.Color.White;
            this.chbHocSinh.Location = new System.Drawing.Point(538, 58);
            this.chbHocSinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbHocSinh.Name = "chbHocSinh";
            this.chbHocSinh.Size = new System.Drawing.Size(20, 20);
            this.chbHocSinh.TabIndex = 3;
            this.chbHocSinh.OnChange += new System.EventHandler(this.chbHocSinh_OnChange);
            // 
            // lbHocSinh
            // 
            this.lbHocSinh.AutoSize = true;
            this.lbHocSinh.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHocSinh.Location = new System.Drawing.Point(564, 58);
            this.lbHocSinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbHocSinh.Name = "lbHocSinh";
            this.lbHocSinh.Size = new System.Drawing.Size(91, 23);
            this.lbHocSinh.TabIndex = 4;
            this.lbHocSinh.Text = "Sinh Viên";
            // 
            // lbGiaoVien
            // 
            this.lbGiaoVien.AutoSize = true;
            this.lbGiaoVien.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbGiaoVien.Location = new System.Drawing.Point(756, 58);
            this.lbGiaoVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGiaoVien.Name = "lbGiaoVien";
            this.lbGiaoVien.Size = new System.Drawing.Size(93, 23);
            this.lbGiaoVien.TabIndex = 6;
            this.lbGiaoVien.Text = "Giáo Viên";
            // 
            // chbGiaoVien
            // 
            this.chbGiaoVien.BackColor = System.Drawing.Color.White;
            this.chbGiaoVien.ChechedOffColor = System.Drawing.Color.White;
            this.chbGiaoVien.Checked = false;
            this.chbGiaoVien.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chbGiaoVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGiaoVien.ForeColor = System.Drawing.Color.White;
            this.chbGiaoVien.Location = new System.Drawing.Point(730, 58);
            this.chbGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbGiaoVien.Name = "chbGiaoVien";
            this.chbGiaoVien.Size = new System.Drawing.Size(20, 20);
            this.chbGiaoVien.TabIndex = 5;
            this.chbGiaoVien.OnChange += new System.EventHandler(this.chbGiaoVien_OnChange);
            // 
            // lbAdmin
            // 
            this.lbAdmin.AutoSize = true;
            this.lbAdmin.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbAdmin.Location = new System.Drawing.Point(966, 58);
            this.lbAdmin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(65, 23);
            this.lbAdmin.TabIndex = 8;
            this.lbAdmin.Text = "Admin";
            // 
            // chbAdmin
            // 
            this.chbAdmin.BackColor = System.Drawing.Color.White;
            this.chbAdmin.ChechedOffColor = System.Drawing.Color.White;
            this.chbAdmin.Checked = false;
            this.chbAdmin.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.chbAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAdmin.ForeColor = System.Drawing.Color.White;
            this.chbAdmin.Location = new System.Drawing.Point(940, 58);
            this.chbAdmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbAdmin.Name = "chbAdmin";
            this.chbAdmin.Size = new System.Drawing.Size(20, 20);
            this.chbAdmin.TabIndex = 7;
            this.chbAdmin.OnChange += new System.EventHandler(this.chbAdmin_OnChange);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 20;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Green;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(839, 303);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(192, 43);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEmail.Location = new System.Drawing.Point(613, 120);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PasswordChar = '\0';
            this.tbEmail.PlaceholderText = "Email";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(418, 45);
            this.tbEmail.TabIndex = 0;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tbMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhau.DefaultText = "";
            this.tbMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhau.Location = new System.Drawing.Point(613, 187);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.PlaceholderText = "Mật khẩu";
            this.tbMatKhau.SelectedText = "";
            this.tbMatKhau.Size = new System.Drawing.Size(418, 45);
            this.tbMatKhau.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::QuanLiLuanVan_ChinhThuc.Properties.Resources.LuanVanImg1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(-59, -27);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(571, 428);
            this.guna2PictureBox1.TabIndex = 20;
            this.guna2PictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(1083, 386);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lbAdmin);
            this.Controls.Add(this.chbAdmin);
            this.Controls.Add(this.lbGiaoVien);
            this.Controls.Add(this.chbGiaoVien);
            this.Controls.Add(this.lbHocSinh);
            this.Controls.Add(this.chbHocSinh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fLogin";
            this.Load += new System.EventHandler(this.fLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCheckbox chbHocSinh;
        private System.Windows.Forms.Label lbHocSinh;
        private System.Windows.Forms.Label lbGiaoVien;
        private Bunifu.Framework.UI.BunifuCheckbox chbGiaoVien;
        private System.Windows.Forms.Label lbAdmin;
        private Bunifu.Framework.UI.BunifuCheckbox chbAdmin;
        private Siticone.Desktop.UI.WinForms.SiticoneButton btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhau;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}