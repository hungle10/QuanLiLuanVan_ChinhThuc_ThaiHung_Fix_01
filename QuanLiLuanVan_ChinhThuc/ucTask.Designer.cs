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
            this.ucChbHoanThanh = new Guna.UI2.WinForms.Guna2CheckBox();
            this.ucTbNoiDung = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ucLbId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDesThoiHan
            // 
            this.lbDesThoiHan.AutoSize = true;
            this.lbDesThoiHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDesThoiHan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesThoiHan.Location = new System.Drawing.Point(491, 16);
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
            this.lbDesHoTen.Location = new System.Drawing.Point(16, 16);
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
            this.ucLbThoiHan.Location = new System.Drawing.Point(631, 16);
            this.ucLbThoiHan.Name = "ucLbThoiHan";
            this.ucLbThoiHan.Size = new System.Drawing.Size(80, 20);
            this.ucLbThoiHan.TabIndex = 21;
            this.ucLbThoiHan.Text = "@thoihan";
            // 
            // ucChbHoanThanh
            // 
            this.ucChbHoanThanh.AutoSize = true;
            this.ucChbHoanThanh.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucChbHoanThanh.CheckedState.BorderRadius = 0;
            this.ucChbHoanThanh.CheckedState.BorderThickness = 0;
            this.ucChbHoanThanh.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucChbHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.ucChbHoanThanh.Location = new System.Drawing.Point(925, 16);
            this.ucChbHoanThanh.Name = "ucChbHoanThanh";
            this.ucChbHoanThanh.Size = new System.Drawing.Size(117, 24);
            this.ucChbHoanThanh.TabIndex = 73;
            this.ucChbHoanThanh.Text = "Hoàn thành";
            this.ucChbHoanThanh.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ucChbHoanThanh.UncheckedState.BorderRadius = 0;
            this.ucChbHoanThanh.UncheckedState.BorderThickness = 0;
            this.ucChbHoanThanh.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ucChbHoanThanh.Click += new System.EventHandler(this.ucChbHoanThanh_Click);
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
            this.ucTbNoiDung.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ucTbNoiDung.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ucTbNoiDung.Location = new System.Drawing.Point(46, 49);
            this.ucTbNoiDung.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ucTbNoiDung.MaxLength = 327670;
            this.ucTbNoiDung.Multiline = true;
            this.ucTbNoiDung.Name = "ucTbNoiDung";
            this.ucTbNoiDung.PasswordChar = '\0';
            this.ucTbNoiDung.PlaceholderText = "";
            this.ucTbNoiDung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ucTbNoiDung.SelectedText = "";
            this.ucTbNoiDung.Size = new System.Drawing.Size(996, 100);
            this.ucTbNoiDung.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 16);
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
            this.ucLbId.Location = new System.Drawing.Point(270, 16);
            this.ucLbId.Name = "ucLbId";
            this.ucLbId.Size = new System.Drawing.Size(39, 20);
            this.ucLbId.TabIndex = 74;
            this.ucLbId.Text = "@id";
            // 
            // ucTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucLbId);
            this.Controls.Add(this.ucChbHoanThanh);
            this.Controls.Add(this.ucTbNoiDung);
            this.Controls.Add(this.lbDesThoiHan);
            this.Controls.Add(this.lbDesHoTen);
            this.Controls.Add(this.ucLbThoiHan);
            this.Name = "ucTask";
            this.Size = new System.Drawing.Size(1074, 175);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbDesThoiHan;
        private System.Windows.Forms.Label lbDesHoTen;
        private System.Windows.Forms.Label ucLbThoiHan;
        private Guna.UI2.WinForms.Guna2CheckBox ucChbHoanThanh;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox ucTbNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ucLbId;
    }
}
