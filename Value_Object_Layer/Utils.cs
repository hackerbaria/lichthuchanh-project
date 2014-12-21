using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class Utils
    {
        private static String acount;

        public static String Acount
        {
            get { return Utils.acount; }
            set { Utils.acount = value; }
        }


    }
}
