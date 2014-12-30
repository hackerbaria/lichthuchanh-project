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
    public class MonHocBUS
    {
         
        private MonHocDAO _MonHocDAO;
        public MonHocBUS()
        {
            
            _MonHocDAO = new MonHocDAO();
        }

        public DataTable getAllMonHoc()
        {
            
            return _MonHocDAO.GetAllMonHoc();
        }
        public MonHocVO getMonHocByName(MonHocVO mh)
        {
            MonHocVO monHocVO = new MonHocVO();
            DataTable dataTable = new DataTable();
            dataTable =_MonHocDAO.getMonHocByName(mh);
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    monHocVO.MaMH = dr[0].ToString();
                    monHocVO.TenMonHoc = dr[1].ToString();
                }
            }

            return monHocVO;
        }
        public bool themMonHoc(MonHocVO MH)
        {    
            bool a = _MonHocDAO.InsertMonHoc(MH);
            if (a == true)
                return true;
            return false;
        }
        public bool CapNhatMonHoc(MonHocVO MH)
        {
            return _MonHocDAO.UpdateMonHoc(MH);
        }
        public bool XoaMonHoc(MonHocVO MH)
        {
            return _MonHocDAO.DeleteMonHoc(MH);
        }

        public DataTable getMonHocByMa(String ma)
        {

            return _MonHocDAO.getMonHocByMa( ma);
        }
    }
}
