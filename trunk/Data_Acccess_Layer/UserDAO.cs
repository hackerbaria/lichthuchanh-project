using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Acccess_Layer
{
    public class UserDAO
    {
        private DBConnection conn;

        /// <constructor>
        /// Constructor UserDAO
        /// </constructor>
        public UserDAO()
        {
            conn = new DBConnection();
        }

        /// <method>
        /// Get User Email By Firstname or Lastname and return DataTable
        /// </method>
        public DataTable searchByName(string tenDangNhap,string matKhau,int quyen)
        {
            string query = string.Format("select * from Account where TenDangNhap = @username and MatKhau=@MatKhau and Quyen=@Quyen");
            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@username", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(tenDangNhap);
            
            sqlParameters[1] = new SqlParameter("@MatKhau", SqlDbType.VarChar);
            sqlParameters[1].Value = Convert.ToString(matKhau);

            sqlParameters[2] = new SqlParameter("@Quyen", SqlDbType.Int);
            sqlParameters[2].Value = quyen;

            return conn.executeSelectQuery(query, sqlParameters);
        }

        /// <method>
        /// Get User Email By Id and return DataTable
        /// </method>
        public DataTable searchById(string _id)
        {
            string query = "select * from [t01_id] where t01_id = @t01_id";
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@t01_id", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_id);
            return conn.executeSelectQuery(query, sqlParameters);
        }
    }
}
