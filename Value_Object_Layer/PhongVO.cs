using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class PhongVO
    {
        private String maPhong;

        public String MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        private String tenPhong;

        public String TenPhong
        {
            get { return tenPhong; }
            set { tenPhong = value; }
        }
        private int soMay;

        public int SoMay
        {
            get { return soMay; }
            set { soMay = value; }
        }

        public PhongVO()
        {

        }
    }
}
