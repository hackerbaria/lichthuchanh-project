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
    public class PhongBUS
    {
        private PhongDAO _PhongDAO;
        public PhongBUS()
        {
            _PhongDAO = new PhongDAO();
        }

        public DataTable getAllPhong()
        {
          
            return _PhongDAO.GetAllPhong();
        }
        public bool themPhong(PhongVO P)
        {
       
           
            bool a = _PhongDAO.InsertPhong(P);
            if (a == true)
                return true;
            return false;
        }
        public bool CapNhatPhong(PhongVO P)
        {
            
            return _PhongDAO.UpdatePhong(P);
        }
        public bool XoaPhong(PhongVO P)
        {
            return _PhongDAO.DeleteGiaoVien(P);
        }
    }
}
