using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class UserVO
    {
        private String username;

        public String Username
        {
            get { return username; }
            set { username = value; }
        }
        private String password;

        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        private int role;

        public int Role
        {
            get { return role; }
            set { role = value; }
        }
        public UserVO()
        {

        }


    }
}
