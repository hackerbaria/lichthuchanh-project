using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;
using Data_Acccess_Layer;
using System.Data;

namespace Bussiness_Logic_Layer
{
    public class GiaoVienBUS
    {
        private GiaoVienDAO _GiaoVienDAO;
        
        public GiaoVienBUS()
        {
            _GiaoVienDAO = new GiaoVienDAO();
        }

        public DataTable getAllGiaoVien()
        {
            return _GiaoVienDAO.GetAllGiaoVien();
        }
        public bool themGiaoVien(GiaoVienVO gV)
        {
       
            bool a= _GiaoVienDAO.InsertGiaoVien(gV);
            if (a == true)
                return true;
            return false;
        }
        /*public GiaoVienVO getGiaoVien(string maGV, string tenGV, string diaChi,string sdt)
        {
            GiaoVienVO GvVO = new GiaoVienVO();
            DataTable dataTable = new DataTable();

            dataTable = _GiaoVienDAO.GetAllGiaoVien();
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    GiaoVienVO. = dr[0].ToString();
                    userVO.MatKhau = dr[1].ToString();
                    userVO.Quyen = int.Parse(dr[2].ToString());

                }
            }

            //return userVO;
        }*/

    }
}
