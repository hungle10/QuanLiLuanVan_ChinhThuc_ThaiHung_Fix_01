﻿namespace QuanLiLuanVan_ChinhThuc.GV
{
    partial class FormListStudent
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.siticoneTextBox1 = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.siticoneComboBox2 = new Siticone.Desktop.UI.WinForms.SiticoneComboBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.loadingbtn = new FontAwesome.Sharp.IconButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ucFixStudent1 = new QuanLiLuanVan_ChinhThuc.UCRowStudent("1");
            this.ucFixStudent2 = new QuanLiLuanVan_ChinhThuc.UCRowStudent("2");
            this.ucFixStudent3 = new QuanLiLuanVan_ChinhThuc.UCRowStudent("3");
            this.ucFixStudent4 = new QuanLiLuanVan_ChinhThuc.UCRowStudent("4");
            this.ucFixStudent5 = new QuanLiLuanVan_ChinhThuc.UCRowStudent("5");
            this.ucFixStudent6 = new QuanLiLuanVan_ChinhThuc.UCRowStudent("6");
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1275, 72);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(90)))), ((int)(((byte)(95)))));
            this.label1.Location = new System.Drawing.Point(70, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sinh viên nộp đồ án ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 72);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1275, 518);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.ucFixStudent1);
            this.flowLayoutPanel1.Controls.Add(this.ucFixStudent2);
            this.flowLayoutPanel1.Controls.Add(this.ucFixStudent3);
            this.flowLayoutPanel1.Controls.Add(this.ucFixStudent4);
            this.flowLayoutPanel1.Controls.Add(this.ucFixStudent5);
            this.flowLayoutPanel1.Controls.Add(this.ucFixStudent6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 109);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1275, 409);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Controls.Add(this.siticoneTextBox1);
            this.panel3.Controls.Add(this.siticoneComboBox2);
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.loadingbtn);
            this.panel3.Controls.Add(this.bunifuCustomLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1275, 109);
            this.panel3.TabIndex = 0;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(521, 2);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(51, 20);
            this.bunifuCustomLabel3.TabIndex = 27;
            this.bunifuCustomLabel3.Text = "Khoa";
            // 
            // siticoneTextBox1
            // 
            this.siticoneTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.siticoneTextBox1.DefaultText = "";
            this.siticoneTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.siticoneTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.siticoneTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.siticoneTextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneTextBox1.Location = new System.Drawing.Point(31, 36);
            this.siticoneTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneTextBox1.Name = "siticoneTextBox1";
            this.siticoneTextBox1.PasswordChar = '\0';
            this.siticoneTextBox1.PlaceholderText = "";
            this.siticoneTextBox1.SelectedText = "";
            this.siticoneTextBox1.Size = new System.Drawing.Size(340, 29);
            this.siticoneTextBox1.TabIndex = 20;
            // 
            // siticoneComboBox2
            // 
            this.siticoneComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.siticoneComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.siticoneComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.siticoneComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.siticoneComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.siticoneComboBox2.ItemHeight = 30;
            this.siticoneComboBox2.Location = new System.Drawing.Point(525, 36);
            this.siticoneComboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.siticoneComboBox2.Name = "siticoneComboBox2";
            this.siticoneComboBox2.Size = new System.Drawing.Size(261, 36);
            this.siticoneComboBox2.TabIndex = 26;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(393, 24);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(57, 41);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // loadingbtn
            // 
            this.loadingbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.loadingbtn.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.loadingbtn.IconColor = System.Drawing.Color.White;
            this.loadingbtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loadingbtn.Location = new System.Drawing.Point(455, 24);
            this.loadingbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loadingbtn.Name = "loadingbtn";
            this.loadingbtn.Size = new System.Drawing.Size(57, 41);
            this.loadingbtn.TabIndex = 22;
            this.loadingbtn.UseVisualStyleBackColor = false;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(31, 2);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(91, 20);
            this.bunifuCustomLabel1.TabIndex = 24;
            this.bunifuCustomLabel1.Text = "Tìm kiếm ";
            // 
            // ucFixStudent1
            // 
            this.ucFixStudent1.Location = new System.Drawing.Point(3, 2);
            this.ucFixStudent1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucFixStudent1.Name = "ucFixStudent1";
            this.ucFixStudent1.Size = new System.Drawing.Size(1239, 90);
            this.ucFixStudent1.TabIndex = 0;
            // 
            // ucFixStudent2
            // 
            this.ucFixStudent2.Location = new System.Drawing.Point(3, 96);
            this.ucFixStudent2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucFixStudent2.Name = "ucFixStudent2";
            this.ucFixStudent2.Size = new System.Drawing.Size(1239, 90);
            this.ucFixStudent2.TabIndex = 1;
            // 
            // ucFixStudent3
            // 
            this.ucFixStudent3.Location = new System.Drawing.Point(3, 190);
            this.ucFixStudent3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucFixStudent3.Name = "ucFixStudent3";
            this.ucFixStudent3.Size = new System.Drawing.Size(1239, 90);
            this.ucFixStudent3.TabIndex = 2;
            // 
            // ucFixStudent4
            // 
            this.ucFixStudent4.Location = new System.Drawing.Point(3, 284);
            this.ucFixStudent4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucFixStudent4.Name = "ucFixStudent4";
            this.ucFixStudent4.Size = new System.Drawing.Size(1239, 90);
            this.ucFixStudent4.TabIndex = 3;
            // 
            // ucFixStudent5
            // 
            this.ucFixStudent5.Location = new System.Drawing.Point(3, 378);
            this.ucFixStudent5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucFixStudent5.Name = "ucFixStudent5";
            this.ucFixStudent5.Size = new System.Drawing.Size(1239, 90);
            this.ucFixStudent5.TabIndex = 4;
            // 
            // ucFixStudent6
            // 
            this.ucFixStudent6.Location = new System.Drawing.Point(3, 472);
            this.ucFixStudent6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucFixStudent6.Name = "ucFixStudent6";
            this.ucFixStudent6.Size = new System.Drawing.Size(1239, 90);
            this.ucFixStudent6.TabIndex = 5;
            // 
            // FormListStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 590);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormListStudent";
            this.Text = "FormGiangVien";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox siticoneTextBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneComboBox siticoneComboBox2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton loadingbtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UCRowStudent ucFixStudent1;
        private UCRowStudent ucFixStudent2;
        private UCRowStudent ucFixStudent3;
        private UCRowStudent ucFixStudent4;
        private UCRowStudent ucFixStudent5;
        private UCRowStudent ucFixStudent6;
    }
}