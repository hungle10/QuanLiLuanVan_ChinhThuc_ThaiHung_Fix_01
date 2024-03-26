using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormMainSV : Form
    {
        private Form currentChildFrom;
        public FormMainSV()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            OpenChildFrom(new HomePage());
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void OpenChildFrom(Form childform)
        {
            if (currentChildFrom != null)
            {
                currentChildFrom.Close();

            }
            currentChildFrom = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            panel1.Controls.Add(childform);
            panel1.Tag = childform;
            childform.BringToFront();
            childform.Show();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new HomePage());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormInforStudent());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormDangKyDeTai());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenChildFrom(new FormGiangVien());
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
