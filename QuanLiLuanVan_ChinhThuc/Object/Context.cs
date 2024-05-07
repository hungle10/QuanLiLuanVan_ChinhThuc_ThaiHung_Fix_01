using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.UC;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiLuanVan_ChinhThuc.Object
{
    public class Context : DbContext
    {
        public Context() : base("name=connectionString")
        {
        }
        public DbSet<Chat> chatTable { get; set; }


    }
}
