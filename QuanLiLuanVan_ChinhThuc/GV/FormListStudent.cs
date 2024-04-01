using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace QuanLiLuanVan_ChinhThuc.GV
{
    public partial class FormListStudent : Form
    {
        public FormListStudent()
        {
            InitializeComponent();
            LoadSV();
        }
        public void LoadSV(string key="")
        {
            flpSV.Controls.Clear();
            DangKyDao dao= new DangKyDao();
            DataTable dt = dao.GetDKByGV(UserInfo.giaoVien);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                DangKy dk=new DangKy(row["IDSinhVien"].ToString(), int.Parse(row["IDLuanVan"].ToString()), row["IDGiangVien"].ToString(), int.Parse(row["IDGroup"].ToString()));
                LuanVanDao lvDao = new LuanVanDao();
                LuanVan lv= lvDao.GetLVByIDLV(row["IDLuanVan"].ToString());
                ucNhomLV uc=new ucNhomLV();
                uc.lbNhom.Text = dk.IDGroup.ToString();
                uc.lbIdDangKi.Text = lv.IDLuanVan.ToString();
                uc.lbTenDeTai.Text = lv.TenLuanVan;
                flpSV.Controls.Add(uc);
                //uc.Click += new EventHandler(ucTK_Click);
            }
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
