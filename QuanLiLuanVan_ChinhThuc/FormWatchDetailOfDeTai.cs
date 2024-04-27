﻿using QuanLiLuanVan_ChinhThuc.GV;
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

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class FormWatchDetailOfDeTai : Form
    {
        private string tenDeTai;
        private string tenGiaoVien;
        private string noiDungs;
        private List<string> noiDung;  
        
        public FormWatchDetailOfDeTai(string tenDeTai,string tenGiaoVien,string noiDungs)
        {
            this.tenDeTai = tenDeTai;     
            this.tenGiaoVien = tenGiaoVien;     
            this.noiDungs = noiDungs;
                
            InitializeComponent();  
        }
        public FormWatchDetailOfDeTai()
        {
            InitializeComponent();
        }
        public void LoadTask()
        {
            
            flpTask.Controls.Clear();
            string query = string.Format("Select * from Task where IDGroup ='{0}'", DataStorage.nhom.IDGroup);
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Khong tim thay thong tin !");
                return;
            }
            int d = 0;
            float tiendo = 0;
            foreach (DataRow row in dt.Rows)
            {
                TaskLV task = new TaskLV(int.Parse(row["MaTask"].ToString()), int.Parse(row["IDGroup"].ToString()) ,int.Parse(row["IDLuanVan"].ToString()), row["NoiDung"].ToString(), DateTime.Parse(row["ThoiHan"].ToString()), int.Parse(row["TienDo"].ToString()));
                ucTask uc = new ucTask();
                int b;
                if (int.TryParse(row["IDSinhVien"].ToString(),out b) ==true)
                {
                    task.IDSinhVien = int.Parse(row["IDSinhVien"].ToString());
                    SinhVienDao svdao = new SinhVienDao();
                    SinhVien sv = svdao.GetSinhVienById(task.IDSinhVien.ToString());
                    uc.lbTenSV.Text = sv.HoTen;
                }
                uc.tbNoiDung.Text = task.NoiDung;
                uc.lbThoiHan.Text = task.FormatNgay();
                uc.lbId.Text = task.MaTask.ToString();
                uc.pgTienDo.Value = task.TienDo;
                uc.lbTienDo.Text=task.TienDo.ToString()+"%";
                tiendo += task.TienDo;
                d++;
                flpTask.Controls.Add(uc);
            }
            tiendo = ((float)tiendo / d);
            int k = (int)tiendo;
            lbTienDo.Text = k.ToString() + "%";
        }
            private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uCnoidungBB2_Load(object sender, EventArgs e)
        {

        }

        private void uCnoidungBB1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormWatchDetailOfDeTai_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            DataStorage.fDetailDeTai = this;
            this.tenDeTai = DataStorage.luanVan.TenLuanVan;
            this.tenGiaoVien = DataStorage.luanVan.GiangVien;
            this.lbLuanVan.Text = tenDeTai;
            this.lbTenGiangVien.Text = tenGiaoVien;
            LoadTask();
        }

        private void btnThemTask_Click(object sender, EventArgs e)
        {
            fThemTask f=new fThemTask();
            f.ShowDialog();
            LoadTask();
        }

        private void btnLoadTask_Click(object sender, EventArgs e)
        {
            LoadTask(); 
        }
    }
}
