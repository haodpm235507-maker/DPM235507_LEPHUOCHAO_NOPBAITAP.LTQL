using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class ChucVu_DAO
    {
        static SqlConnection con;

        public static List<ChucVu_DTO> LayChucVu()
        {
            string sql = "select * from chucvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sql, con);

            if (dt.Rows.Count == 0) return null;

            List<ChucVu_DTO> lst = new List<ChucVu_DTO>();
            foreach (DataRow r in dt.Rows)
            {
                lst.Add(new ChucVu_DTO
                {
                    SMaCV = r["macv"].ToString(),
                    STenCV = r["tencv"].ToString(),
                    FHSPhuCap = float.Parse(r["hsphucap"].ToString())
                });
            }
            return lst;
        }
    }
}
