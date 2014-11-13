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
    public class PhongDAO
    {
        private DBConnection conn;

        public PhongDAO()
        {
            conn = new DBConnection();
        }
        
        public DataTable GetAllPhong()
        {
            string query = string.Format("select * from Phong");
           
            return conn.executeSelectQueryNoParam(query);
        }
        public bool InsertPhong(PhongVO P)
        {
            try
            {
                string query = string.Format("insert into GiaoVien(MaPhong,TenPhong,SoMay) Values(@MaPhong,@TenPhong,@SoMay)");
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaPhong", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(P.MaPhong);

                sqlParameters[1] = new SqlParameter("@TenPhong", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(P.TenPhong);

                sqlParameters[2] = new SqlParameter("@SoMay", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(P.SoMay);

                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
        public bool UpdatePhong(PhongVO P)
        {
            
            try
            {
                string query = string.Format("UPDATE Phong SET MaPhong = @MaPhong, TenPhong=@TenPhong, SoMay=@SoMay Where MaPhong = @MaPhong");
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaPhong", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(P.MaPhong);

                sqlParameters[1] = new SqlParameter("@TenPhong", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(P.TenPhong);

                sqlParameters[2] = new SqlParameter("@SoMay", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(P.SoMay);

                return conn.executeInsertQuery(query, sqlParameters);
            
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteGiaoVien(PhongVO P)
        {

            try
            {
                string query = string.Format("DELETE Phong Where MaPhong = @MaPhong and TenPhong=@TenPhong and SoMay=@SoMay");

                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaPhong", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(P.MaPhong);

                sqlParameters[1] = new SqlParameter("@TenPhong", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(P.TenPhong);

                sqlParameters[2] = new SqlParameter("@SoMay", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(P.SoMay);

                return conn.executeInsertQuery(query, sqlParameters);

            }
            catch
            {
                return false;
            }
        }
    }
}
