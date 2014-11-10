using Data_Acccess_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;

namespace Bussiness_Logic_Layer
{
    public  class UserBUS
    {
        private UserDAO _userDAO;

        public UserBUS()
        {
            _userDAO = new UserDAO();
        }

        /// <method>
        /// Get User Email By Firstname or Lastname and return VO
        /// </method>
        public UserVO getUserEmailByName(string tenDangNhap, string matKhau, int quyen)
        {
            UserVO userVO = new UserVO();
            DataTable dataTable = new DataTable();

            dataTable = _userDAO.searchByName(tenDangNhap,matKhau,quyen);
            if(dataTable != null)
            {
                foreach (DataRow dr in dataTable.Rows)
                {
                    userVO.TenDangNhap = dr[0].ToString();
                    userVO.MatKhau = dr[1].ToString();
                    userVO.Quyen = int.Parse(dr[2].ToString());

                }
            }
                
            return userVO;
        }

        
    }
    
}
