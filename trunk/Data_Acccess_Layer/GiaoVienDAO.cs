using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;

namespace Data_Acccess_Layer
{
    public class GiaoVienDAO
    {
        private DBConnection conn;
        
        public GiaoVienDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllGiaoVien()
        {
            string query = string.Format("select * from GiaoVien");
           
            return conn.executeSelectQueryNoParam(query);
        }
        public bool InsertGiaoVien(GiaoVienVO gv)
        {
            try
            {
                string query = string.Format("insert into GiaoVien(MaGV,TenGV,DiaChi,SoDienThoai) Values(@MaGV,@TenGV,@DiaChi,@SoDienThoai)");
                SqlParameter[] sqlParameters = new SqlParameter[4];

                sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(gv.MaGV);

                sqlParameters[1] = new SqlParameter("@TenGV", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(gv.TenGV);

                sqlParameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
                sqlParameters[2].Value = Convert.ToString(gv.DiaChi);

                sqlParameters[3] = new SqlParameter("@SoDienThoai", SqlDbType.VarChar);
                sqlParameters[3].Value = Convert.ToString(gv.SoDienThoai);

                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
    }
}
