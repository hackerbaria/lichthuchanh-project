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
        public UserVO getUserEmailByName(string name)
        {
            UserVO userVO = new UserVO();
            DataTable dataTable = new DataTable();

            dataTable = _userDAO.searchByName(name);

            foreach (DataRow dr in dataTable.Rows)
            {
                userVO.Username = dr[0].ToString();
                userVO.Password = dr[1].ToString();
                userVO.Role = int.Parse(dr[2].ToString());
               
            }
            return userVO;
        }

        
    }
    
}
