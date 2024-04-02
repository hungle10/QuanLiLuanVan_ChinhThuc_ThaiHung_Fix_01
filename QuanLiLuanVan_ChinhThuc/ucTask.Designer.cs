namespace QuanLiLuanVan_ChinhThuc
{
    partial class ucTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbDesThoiHan = new System.Windows.Forms.Label();
            this.lbDesHoTen = new System.Windows.Forms.Label();
            this.ucLbThoiHan = new System.Windows.Forms.Label();
            this.ucTbNoiDung = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucLbId = new System.Windows.Forms.Label();
            this.ucBtnXoaTask = new Guna.UI2.WinForms.Guna2Button();
            this.ucPgTienDo = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.ucLbTienDo = new System.Windows.Forms.Label();
            this.btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThaoLuan = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lbDesThoiHan
            // 
            this.lbDesThoiHan.AutoSize = true;
            this.lbDesThoiHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDesThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesThoiHan.Location = new System.Drawing.Point(409, 16);
            this.lbDesThoiHan.Name = "lbDesThoiHan";
            this.lbDesThoiHan.Size = new System.Drawing.Size(78, 20);
            this.lbDesThoiHan.TabIndex = 24;
            this.lbDesThoiHan.Text = "Thời hạn:";
            // 
            // lbDesHoTen
            // 
            this.lbDesHoTen.AutoSize = true;
            this.lbDesHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDesHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesHoTen.Location = new System.Drawing.Point(42, 53);
            this.lbDesHoTen.Name = "lbDesHoTen";
            this.lbDesHoTen.Size = new System.Drawing.Size(80, 20);
            this.lbDesHoTen.TabIndex = 22;
            this.lbDesHoTen.Text = "Nội dung:";
            // 
            // ucLbThoiHan
            // 
            this.ucLbThoiHan.AutoSize = true;
            this.ucLbThoiHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucLbThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ucLbThoiHan.Location = new System.Drawing.Point(514, 16);
            this.ucLbThoiHan.Name = "ucLbThoiHan";
            this.ucLbThoiHan.Size = new System.Drawing.Size(80, 20);
            this.ucLbThoiHan.TabIndex = 21;
            this.ucLbThoiHan.Text = "@thoihan";
            // 
            // ucTbNoiDung
            // 
            this.ucTbNoiDung.AutoScroll = true;
            this.ucTbNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTbNoiDung.DefaultText = "";
            this.ucTbNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ucTbNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ucTbNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ucTbNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ucTbNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucTbNoiDung.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTbNoiDung.ForeColor = System.Drawing.Color.Black;
            this.ucTbNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucTbNoiDung.Location = new System.Drawing.Point(46, 82);
            this.ucTbNoiDung.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucTbNoiDung.MaxLength = 327670;
            this.ucTbNoiDung.Multiline = true;
            this.ucTbNoiDung.Name = "ucTbNoiDung";
            this.ucTbNoiDung.PasswordChar = '\0';
            this.ucTbNoiDung.PlaceholderText = "";
            this.ucTbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ucTbNoiDung.SelectedText = "";
            this.ucTbNoiDung.Size = new System.Drawing.Size(996, 79);
            this.ucTbNoiDung.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Id Task:";
            // 
            // ucLbId
            // 
            this.ucLbId.AutoSize = true;
            this.ucLbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucLbId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ucLbId.Location = new System.Drawing.Point(124, 16);
            this.ucLbId.Name = "ucLbId";
            this.ucLbId.Size = new System.Drawing.Size(39, 20);
            this.ucLbId.TabIndex = 74;
            this.ucLbId.Text = "@id";
            // 
            // ucBtnXoaTask
            // 
            this.ucBtnXoaTask.BorderRadius = 10;
            this.ucBtnXoaTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ucBtnXoaTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ucBtnXoaTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ucBtnXoaTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ucBtnXoaTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ucBtnXoaTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ucBtnXoaTask.ForeColor = System.Drawing.Color.White;
            this.ucBtnXoaTask.Location = new System.Drawing.Point(888, 13);
            this.ucBtnXoaTask.Name = "ucBtnXoaTask";
            this.ucBtnXoaTask.Size = new System.Drawing.Size(138, 27);
            this.ucBtnXoaTask.TabIndex = 76;
            this.ucBtnXoaTask.Text = "Xóa task";
            this.ucBtnXoaTask.Click += new System.EventHandler(this.ucBtnXoaTask_Click);
            // 
            // ucPgTienDo
            // 
            this.ucPgTienDo.Location = new System.Drawing.Point(603, 50);
            this.ucPgTienDo.Name = "ucPgTienDo";
            this.ucPgTienDo.Size = new System.Drawing.Size(230, 23);
            this.ucPgTienDo.TabIndex = 77;
            this.ucPgTienDo.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.ucPgTienDo.ValueChanged += new System.EventHandler(this.pgTienDo_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(409, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 78;
            this.label2.Text = "Tiến độ:";
            // 
            // ucLbTienDo
            // 
            this.ucLbTienDo.AutoSize = true;
            this.ucLbTienDo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ucLbTienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ucLbTienDo.Location = new System.Drawing.Point(514, 50);
            this.ucLbTienDo.Name = "ucLbTienDo";
            this.ucLbTienDo.Size = new System.Drawing.Size(33, 20);
            this.ucLbTienDo.TabIndex = 79;
            this.ucLbTienDo.Text = "0%";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BorderRadius = 10;
            this.btnCapNhat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCapNhat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCapNhat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCapNhat.FillColor = System.Drawing.Color.Green;
            this.btnCapNhat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Location = new System.Drawing.Point(888, 46);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(138, 27);
            this.btnCapNhat.TabIndex = 80;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThaoLuan
            // 
            this.btnThaoLuan.BorderRadius = 10;
            this.btnThaoLuan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThaoLuan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThaoLuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThaoLuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThaoLuan.FillColor = System.Drawing.Color.Green;
            this.btnThaoLuan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThaoLuan.ForeColor = System.Drawing.Color.White;
            this.btnThaoLuan.Location = new System.Drawing.Point(888, 167);
            this.btnThaoLuan.Name = "btnThaoLuan";
            this.btnThaoLuan.Size = new System.Drawing.Size(138, 39);
            this.btnThaoLuan.TabIndex = 81;
            this.btnThaoLuan.Text = "Thảo luận";
            // 
            // ucTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnThaoLuan);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.ucLbTienDo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ucPgTienDo);
            this.Controls.Add(this.ucBtnXoaTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucLbId);
            this.Controls.Add(this.ucTbNoiDung);
            this.Controls.Add(this.lbDesThoiHan);
            this.Controls.Add(this.lbDesHoTen);
            this.Controls.Add(this.ucLbThoiHan);
            this.Name = "ucTask";
            this.Size = new System.Drawing.Size(1074, 221);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDesThoiHan;
        private System.Windows.Forms.Label lbDesHoTen;
        private System.Windows.Forms.Label ucLbThoiHan;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ucTbNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ucLbId;
        private Guna.UI2.WinForms.Guna2Button ucBtnXoaTask;
        private Guna.UI2.WinForms.Guna2TrackBar ucPgTienDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ucLbTienDo;
        private Guna.UI2.WinForms.Guna2Button btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button btnThaoLuan;
    }
}
