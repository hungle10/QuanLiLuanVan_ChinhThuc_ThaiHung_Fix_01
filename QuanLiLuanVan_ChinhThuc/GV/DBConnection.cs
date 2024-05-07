using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiLuanVan_ChinhThuc.Object;
using System.Net.Mail;


namespace QuanLiLuanVan_ChinhThuc.GV
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-T2D8QL38\SQLSV2;Initial Catalog=QLLUANVAN;Integrated Security=true");
        private static DBConnection instance;
        
        public void runSql(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                // cmd.Parameters.Add(new SqlParameter("@ngaysinh", per.NgaySinh));
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thuc thi thanh cong");
            }
            catch (Exception ex)
            {
               MessageBox.Show("Thuc thi that bai" + ex);
            }
            finally
            {
                conn.Close();
            }

        }
        public static bool IsEmail(string email)
        {
            try
            {
                MailAddress m = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public SqlDataReader runSqlReturn(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    return reader;

                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Thuc thi that bai");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable update(string tableName)
        {
            try
            {
                string sqlStr = string.Format("SELECT * FROM " + tableName);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Excute(string Str)
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Str, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex+"");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        //dhoa
       /* public DataTable LoadDgv(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien = new DataTable();
                adapter.Fill(dtSinhVien);
                return dtSinhVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }

        }*/
        public DataTable ExcuteQuery(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thuc thi that bai");
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


    }

}

