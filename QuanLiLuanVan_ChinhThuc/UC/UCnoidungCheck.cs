using Guna.UI2.WinForms;
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
    public partial class UCnoidungCheck : UserControl
    {
        public string noiDung;
        public int tinhTrang;
        public int idLuanVan;
        public CheckBox checkbox;

   

        public UCnoidungCheck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UCnoidungCheck_Load(object sender, EventArgs e)
        {
            this.label2.Text= noiDung;
            if(tinhTrang==0)
                this.guna2CheckBox1.Checked= false;
            if (tinhTrang == 1)
                this.guna2CheckBox1.Checked = true;
            checkbox = this.guna2CheckBox1;
        }
    }
}
