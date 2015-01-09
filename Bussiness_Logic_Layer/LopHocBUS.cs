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
        private LopHocDAO _LopHocDAO = new LopHocDAO();
        
        public LopHocBUS()
        {
            
        }

        public DataTable getAllLopHoc()
        {
            return _LopHocDAO.GetAllLopHoc();
        }
        public LopVO getLopHocByName(LopVO lh)
        {
            LopVO lopHocVO = new LopVO();
            DataTable dataTable = new DataTable();
            dataTable = _LopHocDAO.getLopByName(lh);
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    lopHocVO.MaLop = dr[0].ToString();
                    lopHocVO.TenLop = dr[1].ToString();
                }
            }

            return lopHocVO;
        }

        public LopVO getLopHocByMa(String ma)
        {
            LopVO lopHocVO = new LopVO();
            DataTable dataTable = new DataTable();
            dataTable = _LopHocDAO.getLopByMa(ma);
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    lopHocVO.MaLop = dr[0].ToString();
                    lopHocVO.TenLop = dr[1].ToString();
                    lopHocVO.SoLuongSV = Int32.Parse(dr[2].ToString());
                }
            }

            return lopHocVO;
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

        public String getTenLopHocByMa(String maLH)
        {
            String tenLop = "";
            DataTable dataTable = new DataTable();
            dataTable = _LopHocDAO.getLopByMa(maLH);
            if (dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {                   
                    tenLop = dr[1].ToString();
                }
            }

            return tenLop;
        }
    }
}
