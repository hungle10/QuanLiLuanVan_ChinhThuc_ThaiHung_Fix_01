﻿using QuanLiLuanVan_ChinhThuc.Object;
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
    public partial class FormAddYeuCau : Form
    {
        private FormWatchDetailLuanVanFix frm;
        private UCluanvan uc;
        public FormAddYeuCau(FormWatchDetailLuanVanFix frm, UCluanvan uc)
        {
            InitializeComponent();
            this.frm = frm;
            this.uc = uc;
        }

        private void FormAddYeuCau_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frm.flp.Controls.Clear();   
                   
            frm.gn2.Minimum = 0;
            frm.gn2.Maximum = 100;
            double tongUC = 0;
            double tongUChoanthanh = 0;
            YeuCauDAO yeucauDAO = new YeuCauDAO();
            //gửi id sinh viên vào đây 
            List<YeuCau> ycs = yeucauDAO.getYeuCau("10000");
            foreach (YeuCau yc in ycs)
            {
                UCnoidungCheck uc = new UCnoidungCheck();
                uc.noiDung = yc.NoiDungYeuCau.ToString();
                uc.tinhTrang = yc.TinhTrang;
                uc.idLuanVan = yc.IdLuanVan;
                frm.flp.Controls.Add(uc); 
                if (uc.tinhTrang == 1)
                    tongUChoanthanh++;
                tongUC++;
            }
            yeucauDAO.add("10000", ycs[0].IdLuanVan, siticoneTextBox1.Text.ToString(), 0);
            UCnoidungCheck ucLast = new UCnoidungCheck();
            ucLast.noiDung = siticoneTextBox1.Text.ToString();
            ucLast.tinhTrang = 0;
            ucLast.idLuanVan = ycs[0].IdLuanVan;
            frm.flp.Controls.Add(ucLast);
            tongUC++;
            double currentValue = (double)tongUChoanthanh * 100 / tongUC;
            int intValue = (int)(currentValue * frm.gn2.Maximum / 100.0);
            frm.gn2.Value = intValue;
            uc.Lable1.Text = intValue.ToString();               
        }
    }
}