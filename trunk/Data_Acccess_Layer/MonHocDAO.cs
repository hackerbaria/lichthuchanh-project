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
    public class MonHocDAO
    {
        private DBConnection conn;
        
        public MonHocDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllMonHoc()
        {
            string query = string.Format("select * from MonHoc");
           
            return conn.executeSelectQueryNoParam(query);
        }

        public DataTable getMonHocByMa(String ma)
        {
            string query = string.Format("select * from MonHoc where MaMH = @MaMH");

            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MaMH", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(ma);


            return conn.executeSelectQuery(query, sqlParameters);
        }
        public bool InsertMonHoc(MonHocVO MH)
        {
            try
            {
                string query = string.Format("insert into MonHoc(MaMH,TenMonHoc,SoChi,SoTiet,Khoa) Values(@MaMH,@TenMonHoc,@SoChi,@SoTiet,@Khoa)");
                SqlParameter[] sqlParameters = new SqlParameter[5];

                sqlParameters[0] = new SqlParameter("@MaMH", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(MH.MaMH);

                sqlParameters[1] = new SqlParameter("@TenMonHoc", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(MH.TenMonHoc);

                sqlParameters[2] = new SqlParameter("@SoChi", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(MH.SoChi);

                sqlParameters[3] = new SqlParameter("@SoTiet", SqlDbType.Int);
                sqlParameters[3].Value = Convert.ToString(MH.SoTiet); 

                sqlParameters[4] = new SqlParameter("@Khoa", SqlDbType.NVarChar);
                sqlParameters[4].Value = Convert.ToString(MH.Khoa);

                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateMonHoc(MonHocVO MH)
        {
            
            try
            {
                string query = string.Format("UPDATE MonHoc SET MaMH = @MaMH, TenMonHoc=@TenMonHoc, SoChi=@SoChi, SoTiet=@SoTiet,Khoa=@Khoa  Where MaMH = @MaMH");
                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@MaMH", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(MH.MaMH);

                sqlParameters[1] = new SqlParameter("@TenMonHoc", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(MH.TenMonHoc);

                sqlParameters[2] = new SqlParameter("@SoChi", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(MH.SoChi);

                sqlParameters[3] = new SqlParameter("@SoTiet", SqlDbType.Int);
                sqlParameters[3].Value = Convert.ToString(MH.SoTiet);

                sqlParameters[4] = new SqlParameter("@Khoa", SqlDbType.NVarChar);
                sqlParameters[4].Value = Convert.ToString(MH.Khoa);

                return conn.executeInsertQuery(query, sqlParameters);
            
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteMonHoc(MonHocVO MH)
        {

            try
            {
                string query = string.Format("DELETE MonHoc Where MaMH = @MaMH and TenMonHoc=@TenMonHoc and SoChi=@SoChi and SoTiet=@SoTiet and Khoa=@Khoa");

                SqlParameter[] sqlParameters = new SqlParameter[4];
                sqlParameters[0] = new SqlParameter("@MaMH", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(MH.MaMH);

                sqlParameters[1] = new SqlParameter("@TenMonHoc", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(MH.TenMonHoc);

                sqlParameters[2] = new SqlParameter("@SoChi", SqlDbType.Int);
                sqlParameters[2].Value = Convert.ToString(MH.SoChi);

                sqlParameters[3] = new SqlParameter("@SoTiet", SqlDbType.Int);
                sqlParameters[3].Value = Convert.ToString(MH.SoTiet);

                sqlParameters[4] = new SqlParameter("@Khoa", SqlDbType.NVarChar);
                sqlParameters[4].Value = Convert.ToString(MH.Khoa);

                return conn.executeInsertQuery(query, sqlParameters);

            }
            catch
            {
                return false;
            }
        }
    }
}
