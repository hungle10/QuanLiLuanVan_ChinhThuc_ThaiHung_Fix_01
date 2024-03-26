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

namespace QuanLiLuanVan_ChinhThuc.SV
{
    public partial class FormAddDeTaiDuyet : Form
    {
        DangKyDao dkd = new DangKyDao();
        LuanVanDao lvd = new LuanVanDao();
        public FormAddDeTaiDuyet()
        {
            InitializeComponent();
        }

        public LuanVan getLuanVan()
        {
            LuanVan lv = new LuanVan();
            lv.TenLuanVan = t1.Text;
            lv.NenTang = t2.Text;
            lv.LinhVuc = t3.Text;
            lv.CongNghe = t4.Text;
            lv.ChiTiet = t5.Text;
            lv.GiangVien = tbTenGiaoVien.Text;
            return lv;
        }

        public bool isEmptyNhom()
        {
            return tnhom.Text.Length == 0;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (isEmptyNhom())
            {
                MessageBox.Show("Vui lòng điền thành viên nhóm");
                return;
            }
            LuanVan lv = getLuanVan();
            lvd.add(lv);
            lv = lvd.getLastestLuanVan();
            DangKy dk = new DangKy(UserInfo.sinhVien.Id.ToString(), lv.IDLuanVan, tbTenGiaoVien.Text);
            dkd.add(dk);
            dkd.addMemberNhom(tnhom.Lines, dk.IDSinhVien);
            dkd.addDuyet(dk);
            this.Close();
        }

        private void FormAddDeTaiDuyet_Load(object sender, EventArgs e)
        {

        }
    }
}
