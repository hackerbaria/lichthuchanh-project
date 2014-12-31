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
        public int themMonHocTheoTen(MonHocVO MH)
        {
            
            for (int i = 1; i < 1000; i++)
            {
                string monHoc = "MH";
                if (i < 10)
                    monHoc = monHoc + "00";
                else
                {
                    if (i < 100)
                        monHoc = monHoc + "0";
                }
                monHoc = monHoc + i;
                DataTable dt = new DataTable();
                DataTable dt2 = new DataTable();
                MH.MaMH = monHoc;
                dt= _MonHocDAO.searchMaMonHoc(MH);
                dt2 = _MonHocDAO.searchTenMonHoc(MH);
                string maMH="",tenMH="";
                if (dt2 != null)
                {
                    foreach (DataRow dr in dt2.Rows)
                    {
                        tenMH = dr[1].ToString();
                    }
                }
                if (tenMH != "")
                    return 2;
                if(dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        maMH=dr[0].ToString();
                    }
                }
                
                if ( maMH=="")
                {
                    MH.MaMH = monHoc;
                    if (_MonHocDAO.InsertMonHocTheoTen(MH))
                        return 1;
                }
                
            }
            return 0;
           
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
