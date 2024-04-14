namespace QuanLiLuanVan_ChinhThuc.UC
{
    partial class UCmeeting
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.ckbMeeting = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbIDgroup = new System.Windows.Forms.Label();
            this.lbLichHen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(235)))));
            this.guna2Button1.Location = new System.Drawing.Point(31, 16);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(148)))), ((int)(((byte)(235)))));
            this.guna2Button1.Size = new System.Drawing.Size(916, 108);
            this.guna2Button1.TabIndex = 7;
            // 
            // ckbMeeting
            // 
            this.ckbMeeting.AutoSize = true;
            this.ckbMeeting.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbMeeting.CheckedState.BorderRadius = 0;
            this.ckbMeeting.CheckedState.BorderThickness = 0;
            this.ckbMeeting.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ckbMeeting.Location = new System.Drawing.Point(996, 59);
            this.ckbMeeting.Name = "ckbMeeting";
            this.ckbMeeting.Size = new System.Drawing.Size(22, 21);
            this.ckbMeeting.TabIndex = 8;
            this.ckbMeeting.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ckbMeeting.UncheckedState.BorderRadius = 0;
            this.ckbMeeting.UncheckedState.BorderThickness = 0;
            this.ckbMeeting.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(94, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Group :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Thời gian hẹn :";
            // 
            // lbIDgroup
            // 
            this.lbIDgroup.AutoSize = true;
            this.lbIDgroup.BackColor = System.Drawing.Color.Transparent;
            this.lbIDgroup.Location = new System.Drawing.Point(222, 34);
            this.lbIDgroup.Name = "lbIDgroup";
            this.lbIDgroup.Size = new System.Drawing.Size(51, 20);
            this.lbIDgroup.TabIndex = 11;
            this.lbIDgroup.Text = "label3";
            // 
            // lbLichHen
            // 
            this.lbLichHen.AutoSize = true;
            this.lbLichHen.Location = new System.Drawing.Point(247, 82);
            this.lbLichHen.Name = "lbLichHen";
            this.lbLichHen.Size = new System.Drawing.Size(51, 20);
            this.lbLichHen.TabIndex = 12;
            this.lbLichHen.Text = "label4";
            // 
            // UCmeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbLichHen);
            this.Controls.Add(this.lbIDgroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckbMeeting);
            this.Controls.Add(this.guna2Button1);
            this.Name = "UCmeeting";
            this.Size = new System.Drawing.Size(1087, 148);
            this.Load += new System.EventHandler(this.UCmeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox ckbMeeting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbIDgroup;
        private System.Windows.Forms.Label lbLichHen;
    }
}
