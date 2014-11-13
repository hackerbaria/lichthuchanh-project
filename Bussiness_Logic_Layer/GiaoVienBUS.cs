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
