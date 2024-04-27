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

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class UCRowStudent : UserControl
    {
        public UCRowStudent(string mssv="")
        {
            InitializeComponent();
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbHoTen
        {
            get { return ucLbHoTen; }
            set { lbHoTen = value; }
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbTaskDone
        {
            get { return ucLbTaskDone; }
            set { ucLbTaskDone = value; }
        }
        public Bunifu.Framework.UI.BunifuCustomLabel lbDiem
        {
            get { return ucLbDiem; }
            set { ucLbDiem = value; }
        }
        public Guna2Button btnChamDiem
        {
            get { return ucBtnChamDiem; }
            set { ucBtnChamDiem = value; }
        }
        private void ucBtnChamDiem_Click(object sender, EventArgs e)
        {
            if(lbDiem.Text!="Chua co")
            {
                MessageBox.Show("Sinh vien nay da duoc cham diem !");
                return;
            }

            SinhVienDao dao=new SinhVienDao();
            SinhVien sv = dao.GetSinhVienByName(lbHoTen.Text);
            DataStorage.diemLV = new DiemLV(sv.Id);
            fChamDiem f = new fChamDiem();
            f.ShowDialog();
            DataStorage.fDSNhom.LoadMember();
        }
    }
}
