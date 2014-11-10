using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters=null;
            return conn.executeSelectQuery(query, sqlParameters);
        }
    }
}
