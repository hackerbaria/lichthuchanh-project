using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;
using System.Data;

namespace Data_Acccess_Layer
{
    public class LopHocDAO
    {
        private DBConnection conn;
        
        public LopHocDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllLopHoc()
        {
            string query = string.Format("select * from Lop");
           
            return conn.executeSelectQueryNoParam(query);
        }
        public DataTable getLopByName(LopVO L)
        {
            string query = string.Format("select * from Lop where TenLop = @TenLop");
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@TenLop", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(L.TenLop);

            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getLopByMa(String maLH)
        {
            string query = string.Format("select * from Lop where @MaLop = @MaLop");
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.NVarChar);
            sqlParameters[0].Value = maLH;

            return conn.executeSelectQuery(query, sqlParameters);
        }
        public bool InsertLopHoc(LopVO LH)
        {
            try
            {
                string query = string.Format("insert into Lop(MaLop,TenLop,SoLuongSV) Values(@MaLop,@TenLop,@SoLuongSV)");
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(LH.MaLop);

                sqlParameters[1] = new SqlParameter("@TenLop", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(LH.TenLop);

                sqlParameters[2] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(LH.SoLuongSV);

                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateLopHoc(LopVO LH)
        {
            
            try
            {
                string query = string.Format("UPDATE Lop SET MaLop = @MaLop, TenLop=@TenLop, SoLuongSV= @SoLuongSV Where MaLop = @MaLop");
                
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(LH.MaLop);

                sqlParameters[1] = new SqlParameter("@TenLop", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(LH.TenLop);

                sqlParameters[2] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(LH.SoLuongSV);

                return conn.executeInsertQuery(query, sqlParameters);
            
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteLopHoc(LopVO LH)
        {

            try
            {
                string query = string.Format("DELETE from Lop Where MaLop = @MaLop and TenLop=@TenLop and SoLuongSV=@SoLuongSV");

                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(LH.MaLop);

                sqlParameters[1] = new SqlParameter("@TenLop", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(LH.TenLop);

                sqlParameters[2] = new SqlParameter("@SoLuongSV", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(LH.SoLuongSV);


                return conn.executeInsertQuery(query, sqlParameters);

            }
            catch
            {
                return false;
            }
        }
    }
}
