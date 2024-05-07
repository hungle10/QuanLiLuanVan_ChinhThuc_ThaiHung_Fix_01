﻿using Guna.UI2.WinForms;
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
    public partial class ucTask : UserControl
    {
        public int idSV;
        public ucTask(int idSV)
        {
            InitializeComponent();
            this.idSV = idSV;
        }
        public Guna.UI2.WinForms.Guna2TrackBar pgTienDo
        {
            get { return ucPgTienDo; }
            set { ucPgTienDo = value; }
        }
        public Label lbThoiHan
        {
            get { return ucLbThoiHan; }
            set { ucLbThoiHan = value; }
        }
        public Label lbTenSV
        {
            get { return ucLbTenSV; }
            set { ucLbTenSV = value; }
        }
        public Label lbTienDo
        {
            get { return ucLbTienDo; }
            set { ucLbTienDo = value; }
        }
        public Label lbId
        {
            get { return ucLbId; }
            set { ucLbId = value; }
        }
        public Siticone.Desktop.UI.WinForms.SiticoneTextBox tbNoiDung
        {
            get { return ucTbNoiDung; }
            set { ucTbNoiDung = value; }
        }
        public Guna2Button btnCapNhat
        {
            get { return ucBtnCapNhat;}
            set { ucBtnCapNhat = value;}
        }
        private void ucBtnXoaTask_Click(object sender, EventArgs e)
        {
            FormWatchDetailOfDeTai f=new FormWatchDetailOfDeTai();
            TaskLV t = new TaskLV(int.Parse(ucLbId.Text));
            TaskDAO dao = new TaskDAO();
            dao.Delete(t);
            f.LoadTask();
        }

        private void pgTienDo_ValueChanged(object sender, EventArgs e)
        {
            lbTienDo.Text=ucPgTienDo.Value.ToString()+"%";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            TaskDAO dao=new TaskDAO();
            int a;
            TaskLV t=new TaskLV(int.Parse(ucLbId.Text),pgTienDo.Value,UserInfo.sinhVien.Id);
            dao.Update(t);
            DataStorage.fDetailDeTai.LoadTask();
        }

        private void btnThaoLuan_Click(object sender, EventArgs e)
        {
            if (UserInfo.user=="Hoc Sinh")
            {
                if (UserInfo.sinhVien.Id != idSV)
                {
                    MessageBox.Show("Bạn không làm task này nên không thảo luận task này được");
                    return;
                }
            }
            else
            {
                if (idSV<0)
                {
                    MessageBox.Show("Chưa có sinh viên nhận task này nên chưa thể thảo luận được");
                    return;
                }
            }
            FChatBoxTask f = new FChatBoxTask(idSV, int.Parse(lbId.Text));
            f.ShowDialog();
        }
    }
}
