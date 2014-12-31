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

        public DataTable getGiaoVienByAccount(UserVO user)
        {
            return _GiaoVienDAO.getGiaoVienByAccount(user);
        }
        public GiaoVienVO getGiaoVienByName(GiaoVienVO gv)
        {
            GiaoVienVO giaoVienVO = new GiaoVienVO();
            DataTable dataTable = new DataTable();
            dataTable= _GiaoVienDAO.getGiaoVienByName(gv);
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    giaoVienVO.MaGV = dr[0].ToString();
                    giaoVienVO.TenGV = dr[1].ToString();
                }
            }

            return giaoVienVO;
        }
        public bool themGiaoVien(GiaoVienVO gV)
        {
       
            bool a= _GiaoVienDAO.InsertGiaoVien(gV);
            if (a == true)
                return true;
            return false;
        }
        public bool themGiaoVienTheoTen(GiaoVienVO gV)
        {
            
            String[] ma = gV.TenGV.Split(' ');
            int i=ma.Count();
            gV.MaGV=ma[i-1].ToLower();
            return _GiaoVienDAO.InsertGiaoVienTheoTen(gV);
        }
        public bool CapNhatGiaoVien(GiaoVienVO gV)
        {
            return _GiaoVienDAO.UpdateGiaoVien(gV);
        }
        public bool XoaGiaoVien(GiaoVienVO gV)
        {
            return _GiaoVienDAO.DeleteGiaoVien(gV);
        }
        

    }
}
