using QuanLiLuanVan_ChinhThuc.GV;
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

namespace QuanLiLuanVan_ChinhThuc
{
    public partial class fMeeting : Form
    {
        private GiaoVien gv;
        private Nhom nhom;
        public GiaoVien Gv
        {
            get { return gv; }      
            set { gv = value; }         
        }
        public Nhom Nhom
        {
            set { nhom = value; }       
            get { return nhom; }        
        }
        public fMeeting(GiaoVien gv,Nhom nhom)
        {
            InitializeComponent();
            this.Gv = gv;
            this.Nhom = nhom;   
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fMeeting_Load(object sender, EventArgs e)
        {
            lblGiaoVien.Text=Gv.HoTen;       
            lblNhom.Text=Nhom.IDGroup.ToString();
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DateTime dt = dtpDate.Value.Date + dtpTime.Value.TimeOfDay;
            Meeting meeting = new Meeting(gv.Id.ToString(), nhom.IDGroup.ToString(), dt, txbChiTiet.Text.ToString());
            MeetingDAO meetingDAO = new MeetingDAO();
            meetingDAO.add(meeting);
            this.Close();
        }
    }
}
