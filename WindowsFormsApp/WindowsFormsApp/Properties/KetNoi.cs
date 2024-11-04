using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Properties
{
    class KetNoi
    {
        string con_str = @"Data Source=CHYY;Initial Catalog=Quanlytaikhoan;Integrated Security=True";
        public DataSet LayDuLieu(string query, string table_name)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, table_name);
                return ds;
            }
            catch
            {

            }
            return null;
        }
        public bool ThucThi(string query)
        {
            try
            {
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                int soluong = cmd.ExecuteNonQuery();
                conn.Close();
                if (soluong > 0)
                {
                    return true;
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
