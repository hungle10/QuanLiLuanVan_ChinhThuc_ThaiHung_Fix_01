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
    public partial class FormListStudent : Form
    {
        public FormListStudent()
        {
            InitializeComponent();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormWatchDetailOfGiangVien frm = new FormWatchDetailOfGiangVien();
            frm.ShowDialog();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
