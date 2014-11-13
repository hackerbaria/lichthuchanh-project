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
    public class LopHocBUS
    {
        private LopHocDAO _LopHocDAO;
        
        public LopHocBUS()
        {
            _LopHocDAO = new LopHocDAO();
        }

        public DataTable getAllLopHoc()
        {
            return _LopHocDAO.GetAllLopHoc();
        }
        public bool themLopHoc(LopVO LH)
        {
       
        
            if(_LopHocDAO.InsertLopHoc(LH)==true)
                return true;
            else
                return false;
           
        }
        public bool CapNhatLopHoc(LopVO LH)
        {
            
            return _LopHocDAO.UpdateLopHoc(LH);
        }
        public bool XoaLopHoc(LopVO LH)
        {
          
            return _LopHocDAO.DeleteLopHoc(LH);
        }
    }
}
