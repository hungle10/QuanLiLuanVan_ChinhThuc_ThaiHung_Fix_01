using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class UCRowStudent : UserControl
    {
        public UCRowStudent(string mssv)
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_MouseHover(object sender, EventArgs e)
        {
        }

        private void guna2Button1_MouseEnter(object sender, EventArgs e)
        {
            changeColorTextBox(148, 148, 235);
        }

        private void guna2Button1_MouseLeave(object sender, EventArgs e)
        {
            changeColorTextBox(192, 192, 255);
        }

        public void changeColorTextBox(int r, int g, int b)
        {
            bunifuCustomLabel1.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(r, g, b);
            bunifuCustomLabel4.BackColor = System.Drawing.Color.FromArgb(r, g, b);
        }
        
    }
}
