﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.SV;
using QuanLiLuanVan_ChinhThuc.ChatBox;

namespace QuanLiLuanVan_ChinhThuc
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new fLogin());
        }
    }
}
