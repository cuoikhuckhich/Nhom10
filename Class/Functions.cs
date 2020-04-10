using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLyBanHangQuanAo.Class

{
    class Functions
    {

        public static SqlConnection con;
        public static string stringcon;

        public static void ketnoi()
        {
            stringcon = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=QlyBanHangQuanAo;Integrated Security=True";
            con = new SqlConnection();
            con.ConnectionString = stringcon;
            con.Open();
        }
        public static void Dungketnoi()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
                con = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql,con);
            DataTable table = new DataTable();
            adp.Fill(table);
            return table;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter adp = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            adp.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;

        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql,con);//  khởi tạo khai báo đối tượng sqlcommand;

              try
              {
                  cmd.ExecuteNonQuery();
              }
              catch (System.Exception ex)
              {
                  MessageBox.Show("Đã xảy ra xung đột dữ liệu đang được dùng không thể xóa,sửa...", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
              }
            
            cmd.Dispose();
            cmd = null;

        }
      public static string Duongdananh(string sql)
       {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql,con);
           SqlDataReader reader;
           reader = cmd.ExecuteReader();
           while (reader.Read())
                ma = reader.GetValue(0).ToString();
           reader.Close();
           return ma;
       }


    }
}
