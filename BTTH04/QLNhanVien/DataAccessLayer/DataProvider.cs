using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=.\\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";
            SqlConnection con = new SqlConnection(s);
            con.Open();
            return con;
        }

        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection con)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection con)
        {
            try
            {
                SqlCommand cm = new SqlCommand(sTruyVan, con);
                cm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
