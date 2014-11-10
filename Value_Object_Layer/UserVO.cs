using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class UserVO
    {
        private String tenDangNhap;

        public String TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }
        private String matKhau;

        public String MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private int quyen;

        public int Quyen
        {
            get { return quyen; }
            set { quyen = value; }
        }
        
        public UserVO()
        {

        }


    }
}
