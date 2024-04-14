using QuanLiLuanVan_ChinhThuc.Object;
using QuanLiLuanVan_ChinhThuc.UC;
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
    public partial class fListLichHen : Form
    {
        public fListLichHen()
        {
            InitializeComponent();
        }

        private void fListLichHen_Load(object sender, EventArgs e)
        {
            MeetingDAO meetingDAO = new MeetingDAO();       
            List<Meeting> mts= meetingDAO.getListMeeting(UserInfo.giaoVien.Id.ToString());
            if (mts != null)
            {
                foreach (Meeting meeting in mts)
                {
                    UCmeeting uCmeeting = new UCmeeting(meeting);
                    uCmeeting.lbGroup.Text = meeting.IdGroup.ToString();
                    uCmeeting.lbThoiGian.Text = meeting.ThoiGian.ToString();
                    flpMeeting.Controls.Add(uCmeeting);
                }
            }  
        }

        private void btnXoaLichHen_Click(object sender, EventArgs e)
        {
            MeetingDAO meetingDAO = new MeetingDAO();
            foreach (UCmeeting uCmeeting in flpMeeting.Controls) 
            {
                if(uCmeeting.checkbox.Checked)
                {
                    meetingDAO.delete(uCmeeting.Mt);
                    flpMeeting.Controls.Remove(uCmeeting);
                }
            }    
        }
    }
}
