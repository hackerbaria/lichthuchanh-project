using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class LopVO
    {
        private String maLop;

        public String MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        private String tenLop;

        public String TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }
        private int soLuongSV;

        public int SoLuongSV
        {
            get { return soLuongSV; }
            set { soLuongSV = value; }
        }

        public LopVO()
        {

        }

    }
}
