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

        private void FormMainGV_Load(object sender, EventArgs e)
        {
            OpenChildFrom(new HomePage());
            loadingStatusButton(guna2Button1);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

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
            guna2Button1.FillColor = System.Drawing.Color.Teal;
            guna2Button3.FillColor = System.Drawing.Color.Teal;

            guna2Button4.FillColor = System.Drawing.Color.Teal;
            guna2Button5.FillColor = System.Drawing.Color.Teal;
            guna2Button6.FillColor = System.Drawing.Color.Teal;
            guna2Button7.FillColor = System.Drawing.Color.Teal;
            button.FillColor = System.Drawing.Color.FromArgb(1, 90, 95);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new HomePage());
            loadingStatusButton(guna2Button1);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormInfoGV());
            loadingStatusButton(guna2Button3);

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormQuanLyDeTai());
            loadingStatusButton(guna2Button4);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormListStudent());
            loadingStatusButton(guna2Button5);

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormQuanLyDuyet());
            loadingStatusButton(guna2Button7);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        
    }
}
