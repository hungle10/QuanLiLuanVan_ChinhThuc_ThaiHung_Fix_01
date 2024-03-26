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
    public partial class ucTaiKhoan : UserControl
    {
        public ucTaiKhoan()
        {
            InitializeComponent();
        }
        public Label lbTen
        {
            get { return ucLbTen; }
            set { ucLbTen = value; }
        }
        public Label lbEmail
        {
            get { return ucLbEmail; }
            set { ucLbEmail = value; }
        }
        public Label lbChucVu
        {
            get { return ucLbChucVu; }
            set { ucLbChucVu = value; }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
