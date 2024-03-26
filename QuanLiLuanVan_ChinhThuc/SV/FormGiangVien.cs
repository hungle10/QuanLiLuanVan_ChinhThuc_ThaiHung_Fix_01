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

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormGiangVien : Form
    {
        public FormGiangVien()
        {
            InitializeComponent();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormWatchDetailOfGiangVien frm = new FormWatchDetailOfGiangVien();
            frm.ShowDialog();
        }

        private void FormGiangVien_Load(object sender, EventArgs e)
        {
            GiaoVienDAO gvDAO = new GiaoVienDAO();
            List<GiaoVien> gvs = GiaoVienDAO.getYeuCau();
            foreach (GiaoVien gv in gvs)
            {
                UCRowGiaoVien ucGV = new UCRowGiaoVien();
                ucGV.BunifuCustomLabel3.Text = gv.HoTen;
                ucGV.BunifuCustomLabel4.Text = gv.Khoa;
                this.flowLayoutPanel1.Controls.Add(ucGV);           
            }         
                
        }
    }
}
