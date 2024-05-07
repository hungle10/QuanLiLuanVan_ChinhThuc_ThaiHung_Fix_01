namespace QuanLiLuanVan_ChinhThuc
{
    partial class FChatBoxTask
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
            this.txtChat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.btnPicture = new Guna.UI2.WinForms.Guna2Button();
            this.chatBoxPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // txtChat
            // 
            this.txtChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChat.DefaultText = "";
            this.txtChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChat.Location = new System.Drawing.Point(12, 532);
            this.txtChat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.PasswordChar = '\0';
            this.txtChat.PlaceholderText = "Gửi tin nhắn ở đây...";
            this.txtChat.SelectedText = "";
            this.txtChat.Size = new System.Drawing.Size(610, 48);
            this.txtChat.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.ForestGreen;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(644, 532);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(92, 45);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPicture.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPicture.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPicture.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPicture.FillColor = System.Drawing.Color.ForestGreen;
            this.btnPicture.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPicture.ForeColor = System.Drawing.Color.White;
            this.btnPicture.Location = new System.Drawing.Point(762, 532);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(92, 45);
            this.btnPicture.TabIndex = 2;
            this.btnPicture.Text = "Ảnh";
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // chatBoxPanel
            // 
            this.chatBoxPanel.AutoScroll = true;
            this.chatBoxPanel.Location = new System.Drawing.Point(1, 3);
            this.chatBoxPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chatBoxPanel.Name = "chatBoxPanel";
            this.chatBoxPanel.Size = new System.Drawing.Size(862, 508);
            this.chatBoxPanel.TabIndex = 7;
            // 
            // FChatBoxTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 593);
            this.Controls.Add(this.chatBoxPanel);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtChat);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FChatBoxTask";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChatBoxTask";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtChat;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2Button btnPicture;
        private System.Windows.Forms.FlowLayoutPanel chatBoxPanel;
    }
}