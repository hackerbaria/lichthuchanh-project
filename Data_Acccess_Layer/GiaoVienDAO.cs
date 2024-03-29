﻿using System;
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
        public bool InsertGiaoVienTheoTen(GiaoVienVO gv)
        {
            try
            {
                string query = string.Format("insert into GiaoVien(MaGV,TenGV) Values(@MaGV,@TenGV)");
                SqlParameter[] sqlParameters = new SqlParameter[2];

                sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
                sqlParameters[0].Value = Convert.ToString(gv.MaGV);

                sqlParameters[1] = new SqlParameter("@TenGV", SqlDbType.NVarChar);
                sqlParameters[1].Value = Convert.ToString(gv.TenGV);

                return conn.executeInsertQuery(query, sqlParameters);
            }
            catch
            {
                return false;
            }
        }
        public DataTable getGiaoVienByName(GiaoVienVO gv)
        {
            string query = string.Format("select * from GiaoVien where TenGV = @TenGV");
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@TenGV", SqlDbType.NVarChar);
            sqlParameters[0].Value = Convert.ToString(gv.TenGV);

            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getGiaoVienByMa(String ma)
        {
            string query = string.Format("select * from GiaoVien where MaGV = @MaGV");
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.NVarChar);
            sqlParameters[0].Value = ma;

            return conn.executeSelectQuery(query, sqlParameters);
        }

        public DataTable getGiaoVienByAccount(UserVO user)
        {
            string query = string.Format("select * from GiaoVien where MaGV = @MaGV");
            SqlParameter[] sqlParameters = new SqlParameter[1];

            sqlParameters[0] = new SqlParameter("@MaGV", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(user.TenDangNhap);

            return conn.executeSelectQuery(query, sqlParameters);
        }
        public bool UpdateGiaoVien(GiaoVienVO gv)
        {
            
            try
            {
                string query = string.Format("UPDATE GiaoVien SET MaGV = @MaGV, TenGV=@TenGV, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai Where MaGV = @MaGV");
                
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
        public bool DeleteGiaoVien(GiaoVienVO gv)
        {

            try
            {
                string query = string.Format("DELETE GiaoVien Where MaGV = @MaGV and TenGV=@TenGV and DiaChi=@DiaChi and SoDienThoai=@SoDienThoai");

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
