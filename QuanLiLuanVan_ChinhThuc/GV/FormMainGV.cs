using Guna.UI2.WinForms;
using QuanLiLuanVan_ChinhThuc.GV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class FormMainGV : Form
    {

        private Form currentChildFrom;

        public FormMainGV()
        {
            InitializeComponent();
        }
        private void OpenChildFrom(Form childform)
        {
            if (currentChildFrom != null && currentChildFrom.Name == childform.Name)
            {
                return;
            }
            if (currentChildFrom != null) 
                currentChildFrom.Close();
            currentChildFrom = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        public void loadingStatusButton(Guna2Button button)
        {
            btnHome.FillColor = System.Drawing.Color.Teal;
            btnUser.FillColor = System.Drawing.Color.Teal;
            btnDeTai.FillColor = System.Drawing.Color.Teal;
            btnNhomSV.FillColor = System.Drawing.Color.Teal;
            btnLogOut.FillColor = System.Drawing.Color.Teal;
            btnDuyet.FillColor = System.Drawing.Color.Teal;
            button.FillColor = System.Drawing.Color.FromArgb(1, 90, 95);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new HomePage());
            loadingStatusButton(btnHome);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormInfoGV());
            loadingStatusButton(btnUser);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormQuanLyDeTai());
            loadingStatusButton(btnDeTai);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormListStudent());
            loadingStatusButton(btnNhomSV);

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormQuanLyDuyet());
            loadingStatusButton(btnDuyet);
        }   
    }
}
