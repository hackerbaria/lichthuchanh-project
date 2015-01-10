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
    public class LapLichDAO
    {
        private DBConnection conn;
        public LapLichDAO()
        {
            conn = new DBConnection();
        }
        public DataTable GetAllLichDayLyThuyet()
        {
            string query = string.Format("select * from LichDayLyThuyet");

            return conn.executeSelectQueryNoParam(query);
        }
        
        public bool insertLapLich(LichDayVO ld)
        {
            try
            {
                string query = string.Format("insert into LichDayLyThuyet(MaGV,MaMH,MaLop,MaPhong,Tuan,Thu,Tiet) Values(@MaGV,@MaMH,@MaLop,@MaPhong,@Tuan,@Thu,@Tiet)");
                SqlParameter[] sqlParameters = new SqlParameter[7];

                sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(ld.MaGV);

                sqlParameters[1] = new SqlParameter("@MaMH", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(ld.MaMH);

                sqlParameters[2] = new SqlParameter("@MaLop", SqlDbType.NVarChar);
                sqlParameters[2].Value = Convert.ToString(ld.MaLop);

                sqlParameters[3] = new SqlParameter("@MaPhong", SqlDbType.VarChar);
                sqlParameters[3].Value = Convert.ToString(ld.MaPhong);

                sqlParameters[4] = new SqlParameter("@Tuan", SqlDbType.VarChar);
                sqlParameters[4].Value = Convert.ToString(ld.Tuan);

                sqlParameters[5] = new SqlParameter("@Thu", SqlDbType.VarChar);
                sqlParameters[5].Value = Convert.ToString(ld.Thu);

                sqlParameters[6] = new SqlParameter("@Tiet", SqlDbType.VarChar);
                sqlParameters[6].Value = Convert.ToString(ld.Tiet);


                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
        public bool insertLapLichThucHanh(LichDayVO ld)
        {
            try
            {
                string query = string.Format("insert into LichDayThucHanh(MaGV,MaMH,MaLop,MaPhong,Tuan,Thu,Tiet) Values(@MaGV,@MaMH,@MaLop,@MaPhong,@Tuan,@Thu,@Tiet)");
                SqlParameter[] sqlParameters = new SqlParameter[7];

                sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(ld.MaGV);

                sqlParameters[1] = new SqlParameter("@MaMH", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(ld.MaMH);

                sqlParameters[2] = new SqlParameter("@MaLop", SqlDbType.NVarChar);
                sqlParameters[2].Value = Convert.ToString(ld.MaLop);

                sqlParameters[3] = new SqlParameter("@MaPhong", SqlDbType.VarChar);
                sqlParameters[3].Value = Convert.ToString(ld.MaPhong);

                sqlParameters[4] = new SqlParameter("@Tuan", SqlDbType.VarChar);
                sqlParameters[4].Value = Convert.ToString(ld.Tuan);

                sqlParameters[5] = new SqlParameter("@Thu", SqlDbType.VarChar);
                sqlParameters[5].Value = Convert.ToString(ld.Thu);

                sqlParameters[6] = new SqlParameter("@Tiet", SqlDbType.VarChar);
                sqlParameters[6].Value = Convert.ToString(ld.Tiet);


                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
        public bool insertLapLichBoPhong(LichDayVO ld)
        {
            try
            {
                string query = string.Format("insert into LichDayLyThuyet(MaGV,MaMH,MaLop,Tuan,Thu,Tiet) Values(@MaGV,@MaMH,@MaLop,@Tuan,@Thu,@Tiet)");
                SqlParameter[] sqlParameters = new SqlParameter[6];

                sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(ld.MaGV);

                sqlParameters[1] = new SqlParameter("@MaMH", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(ld.MaMH);

                sqlParameters[2] = new SqlParameter("@MaLop", SqlDbType.NVarChar);
                sqlParameters[2].Value = Convert.ToString(ld.MaLop);

                sqlParameters[3] = new SqlParameter("@Tuan", SqlDbType.VarChar);
                sqlParameters[3].Value = Convert.ToString(ld.Tuan);

                sqlParameters[4] = new SqlParameter("@Thu", SqlDbType.VarChar);
                sqlParameters[4].Value = Convert.ToString(ld.Thu);

                sqlParameters[5] = new SqlParameter("@Tiet", SqlDbType.VarChar);
                sqlParameters[5].Value = Convert.ToString(ld.Tiet);


                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }

        public DataTable getLichByMaGVAndWeek(String maGV, int week)
        {
            string query = string.Format("select * from LichDayThucHanh where MaGV = @MaGV and Tuan = @Tuan");
            SqlParameter[] sqlParameters = new SqlParameter[2];

            sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
            sqlParameters[0].Value = maGV;

            sqlParameters[1] = new SqlParameter("@Tuan", SqlDbType.Int);
            sqlParameters[1].Value = week;

            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getLichByWeek(int week)
        {
            string query = string.Format("select * from LichDayThucHanh where Tuan = @Tuan");
            SqlParameter[] sqlParameters = new SqlParameter[1];


            sqlParameters[0] = new SqlParameter("@Tuan", SqlDbType.Int);
            sqlParameters[0].Value = week;

            return conn.executeSelectQuery(query, sqlParameters);
        }
    }
}
