using QuanLiLuanVan_ChinhThuc.GV;
using QuanLiLuanVan_ChinhThuc.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLiLuanVan_ChinhThuc
{
    internal class TaskDAO
    {
        public TaskDAO() { }
        public void add(TaskLV task) 
        {
            string query = string.Format("insert into Task(IDGroup,IDLuanVan,NoiDung,ThoiHan,TienDo) values ({0},{1},'{2}','{3}',{4})", task.IDGroup, task.IdLuanVan, task.NoiDung, task.FormatNgay(),task.TienDo);
            int result=DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
                MessageBox.Show("Them that bai!");
            else
                MessageBox.Show("Them thanh cong!");
        }
        public int GetTienDoSV(SinhVien sv,Nhom n)
        {
            string query = string.Format("select SUM(TienDo) from Task Where IDSinhVien ={0}", sv.Id);
            object ob1=DataProvider.Instance.ExecuteScalar(query);
            int t1;
            if(int.TryParse(ob1.ToString(),out t1)==false)
                return 0;
            t1=int.Parse(ob1.ToString());
            query = string.Format("select COUNT(TienDo) from Task Where IDGroup = {0}", n.IDGroup);
            object ob2=DataProvider.Instance.ExecuteScalar(query);
            int t0;
            if (int.TryParse(ob1.ToString(), out t0) == false)
                return 0;
            t0 =int.Parse(ob2.ToString());
            return (int)((float)t1/t0);
        }
        public void Update(TaskLV task) 
        {
            string query = string.Format("Update Task set TienDo={0},IDSinhVien={1} where MaTask={2}",task.TienDo,task.MaTask,task.IDSinhVien);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
                MessageBox.Show("Cap nhat that bai!");
            else
                MessageBox.Show("Cap nhat thanh cong!");
        }
        public void Delete(TaskLV task)
        {
            string query = string.Format("Delete Task where MaTask={0}",task.MaTask);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            if (result == 0)
                MessageBox.Show("Xoa that bai!");
            else
                MessageBox.Show("Xoa thanh cong!");
        }
    }
}
