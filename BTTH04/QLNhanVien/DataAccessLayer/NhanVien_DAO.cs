using DataTransferObject;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhanVien_DAO
    {
        static SqlConnection con;

        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = "SELECT * FROM nhanvien";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
                return null;

            List<NhanVien_DTO> lstNV = new List<NhanVien_DTO>();
            foreach (DataRow row in dt.Rows)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = row["manv"].ToString();
                nv.STenNV = row["tennv"].ToString();
                nv.DNgaySinh = DateTime.Parse(row["ngaysinh"].ToString());
                nv.SMaCV = row["macv"].ToString();

                lstNV.Add(nv);
            }
            return lstNV;
        }
    }
}
