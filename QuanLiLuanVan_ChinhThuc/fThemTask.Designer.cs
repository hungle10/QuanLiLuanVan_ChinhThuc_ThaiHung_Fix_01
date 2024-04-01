namespace QuanLiLuanVan_ChinhThuc
{
    partial class fThemTask
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
            this.tbNoiDung = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.lbDesThoiHan = new System.Windows.Forms.Label();
            this.lbDesHoTen = new System.Windows.Forms.Label();
            this.dtpThoiHan = new Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker();
            this.btnThemTask = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // tbNoiDung
            // 
            this.tbNoiDung.AutoScroll = true;
            this.tbNoiDung.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNoiDung.DefaultText = "";
            this.tbNoiDung.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNoiDung.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNoiDung.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoiDung.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNoiDung.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoiDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNoiDung.Location = new System.Drawing.Point(39, 88);
            this.tbNoiDung.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.tbNoiDung.MaxLength = 327670;
            this.tbNoiDung.Multiline = true;
            this.tbNoiDung.Name = "tbNoiDung";
            this.tbNoiDung.PasswordChar = '\0';
            this.tbNoiDung.PlaceholderText = "";
            this.tbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNoiDung.SelectedText = "";
            this.tbNoiDung.Size = new System.Drawing.Size(756, 145);
            this.tbNoiDung.TabIndex = 77;
            // 
            // lbDesThoiHan
            // 
            this.lbDesThoiHan.AutoSize = true;
            this.lbDesThoiHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDesThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesThoiHan.Location = new System.Drawing.Point(362, 41);
            this.lbDesThoiHan.Name = "lbDesThoiHan";
            this.lbDesThoiHan.Size = new System.Drawing.Size(95, 25);
            this.lbDesThoiHan.TabIndex = 76;
            this.lbDesThoiHan.Text = "Thời hạn:";
            // 
            // lbDesHoTen
            // 
            this.lbDesHoTen.AutoSize = true;
            this.lbDesHoTen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDesHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesHoTen.Location = new System.Drawing.Point(34, 30);
            this.lbDesHoTen.Name = "lbDesHoTen";
            this.lbDesHoTen.Size = new System.Drawing.Size(96, 25);
            this.lbDesHoTen.TabIndex = 75;
            this.lbDesHoTen.Text = "Nội dung:";
            // 
            // dtpThoiHan
            // 
            this.dtpThoiHan.Checked = true;
            this.dtpThoiHan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThoiHan.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpThoiHan.Location = new System.Drawing.Point(492, 30);
            this.dtpThoiHan.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpThoiHan.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpThoiHan.Name = "dtpThoiHan";
            this.dtpThoiHan.Size = new System.Drawing.Size(303, 36);
            this.dtpThoiHan.TabIndex = 78;
            this.dtpThoiHan.Value = new System.DateTime(2024, 3, 28, 21, 6, 45, 422);
            // 
            // btnThemTask
            // 
            this.btnThemTask.BorderRadius = 10;
            this.btnThemTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemTask.FillColor = System.Drawing.Color.LimeGreen;
            this.btnThemTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemTask.ForeColor = System.Drawing.Color.White;
            this.btnThemTask.Location = new System.Drawing.Point(634, 250);
            this.btnThemTask.Name = "btnThemTask";
            this.btnThemTask.Size = new System.Drawing.Size(140, 34);
            this.btnThemTask.TabIndex = 79;
            this.btnThemTask.Text = "Thêm task";
            this.btnThemTask.Click += new System.EventHandler(this.btnThemTask_Click);
            // 
            // fThemTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(874, 296);
            this.Controls.Add(this.btnThemTask);
            this.Controls.Add(this.dtpThoiHan);
            this.Controls.Add(this.tbNoiDung);
            this.Controls.Add(this.lbDesThoiHan);
            this.Controls.Add(this.lbDesHoTen);
            this.Name = "fThemTask";
            this.Text = "fThemTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneTextBox tbNoiDung;
        private System.Windows.Forms.Label lbDesThoiHan;
        private System.Windows.Forms.Label lbDesHoTen;
        private Siticone.Desktop.UI.WinForms.SiticoneDateTimePicker dtpThoiHan;
        private Guna.UI2.WinForms.Guna2Button btnThemTask;
    }
}