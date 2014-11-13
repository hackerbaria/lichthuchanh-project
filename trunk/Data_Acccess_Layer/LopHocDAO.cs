﻿using System;
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
        public bool InsertLopHoc(LopVO LH)
        {
            try
            {
                string query = string.Format("insert into GiaoVien(MaLop,TenLop,SoLuongSV) Values(@MaLop,@TenLop,@SoLuongSV)");
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
                string query = string.Format("UPDATE GiaoVien SET MaLop = @MaLop, TenLop=@TenLop, SoLuongSV=@SoLuongSV Where MaLop = @MaLop");
                
                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(LH.MaLop);

                sqlParameters[1] = new SqlParameter("@TenLop", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(LH.TenLop);

                sqlParameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
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
                string query = string.Format("DELETE LopHoc Where MaLop = @MaLop and TenLop=@TenLop and SoLuongSV=@SoLuongSV");

                SqlParameter[] sqlParameters = new SqlParameter[3];

                sqlParameters[0] = new SqlParameter("@MaLop", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(LH.MaLop);

                sqlParameters[1] = new SqlParameter("@TenLop", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(LH.TenLop);

                sqlParameters[2] = new SqlParameter("@DiaChi", SqlDbType.NVarChar);
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