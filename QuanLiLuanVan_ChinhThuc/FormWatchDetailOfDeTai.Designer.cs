namespace QuanLiLuanVan_ChinhThuc
{
    partial class FormWatchDetailOfDeTai
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTienDo = new System.Windows.Forms.Label();
            this.lbDesTienDo = new System.Windows.Forms.Label();
            this.btnLoadTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemTask = new Guna.UI2.WinForms.Guna2Button();
            this.flpTask = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTenGiangVien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbLuanVan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(248)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.lbTienDo);
            this.panel1.Controls.Add(this.lbDesTienDo);
            this.panel1.Controls.Add(this.btnLoadTask);
            this.panel1.Controls.Add(this.btnThemTask);
            this.panel1.Controls.Add(this.flpTask);
            this.panel1.Controls.Add(this.lbTenGiangVien);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1325, 558);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbTienDo
            // 
            this.lbTienDo.AutoSize = true;
            this.lbTienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTienDo.Location = new System.Drawing.Point(641, 99);
            this.lbTienDo.Name = "lbTienDo";
            this.lbTienDo.Size = new System.Drawing.Size(37, 24);
            this.lbTienDo.TabIndex = 44;
            this.lbTienDo.Text = "0%";
            // 
            // lbDesTienDo
            // 
            this.lbDesTienDo.AutoSize = true;
            this.lbDesTienDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesTienDo.Location = new System.Drawing.Point(528, 99);
            this.lbDesTienDo.Name = "lbDesTienDo";
            this.lbDesTienDo.Size = new System.Drawing.Size(89, 24);
            this.lbDesTienDo.TabIndex = 43;
            this.lbDesTienDo.Text = "Tiến độ:";
            // 
            // btnLoadTask
            // 
            this.btnLoadTask.BorderRadius = 10;
            this.btnLoadTask.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTask.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLoadTask.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLoadTask.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLoadTask.FillColor = System.Drawing.Color.LimeGreen;
            this.btnLoadTask.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLoadTask.ForeColor = System.Drawing.Color.White;
            this.btnLoadTask.Location = new System.Drawing.Point(993, 88);
            this.btnLoadTask.Name = "btnLoadTask";
            this.btnLoadTask.Size = new System.Drawing.Size(125, 46);
            this.btnLoadTask.TabIndex = 42;
            this.btnLoadTask.Text = "Load task";
            this.btnLoadTask.Click += new System.EventHandler(this.btnLoadTask_Click);
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
            this.btnThemTask.Location = new System.Drawing.Point(1156, 88);
            this.btnThemTask.Name = "btnThemTask";
            this.btnThemTask.Size = new System.Drawing.Size(146, 46);
            this.btnThemTask.TabIndex = 41;
            this.btnThemTask.Text = "Thêm task";
            this.btnThemTask.Click += new System.EventHandler(this.btnThemTask_Click);
            // 
            // flpTask
            // 
            this.flpTask.AutoScroll = true;
            this.flpTask.Location = new System.Drawing.Point(3, 148);
            this.flpTask.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTask.Name = "flpTask";
            this.flpTask.Size = new System.Drawing.Size(1322, 410);
            this.flpTask.TabIndex = 6;
            // 
            // lbTenGiangVien
            // 
            this.lbTenGiangVien.AutoSize = true;
            this.lbTenGiangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenGiangVien.Location = new System.Drawing.Point(256, 99);
            this.lbTenGiangVien.Name = "lbTenGiangVien";
            this.lbTenGiangVien.Size = new System.Drawing.Size(168, 24);
            this.lbTenGiangVien.TabIndex = 5;
            this.lbTenGiangVien.Text = "Nguyễn Thụy An";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giáo viên phụ trách :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(242)))), ((int)(((byte)(254)))));
            this.panel2.Controls.Add(this.lbLuanVan);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1325, 72);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // lbLuanVan
            // 
            this.lbLuanVan.AutoSize = true;
            this.lbLuanVan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLuanVan.Location = new System.Drawing.Point(308, 30);
            this.lbLuanVan.Name = "lbLuanVan";
            this.lbLuanVan.Size = new System.Drawing.Size(226, 29);
            this.lbLuanVan.TabIndex = 1;
            this.lbLuanVan.Text = "E-Commerce Web";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đề tài :";
            // 
            // FormWatchDetailOfDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 557);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormWatchDetailOfDeTai";
            this.Text = "FormWatchDetailOfDeTai";
            this.Load += new System.EventHandler(this.FormWatchDetailOfDeTai_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbLuanVan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenGiangVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flpTask;
        private Guna.UI2.WinForms.Guna2Button btnThemTask;
        private Guna.UI2.WinForms.Guna2Button btnLoadTask;
        private System.Windows.Forms.Label lbDesTienDo;
        private System.Windows.Forms.Label lbTienDo;
    }
}