using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class MonHocVO
    {
        private String maMH;

        public String MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        private String tenMonHoc;

        public String TenMonHoc
        {
            get { return tenMonHoc; }
            set { tenMonHoc = value; }
        }
        private int soChi;

        public int SoChi
        {
            get { return soChi; }
            set { soChi = value; }
        }
        private int soTiet;

        public int SoTiet
        {
            get { return soTiet; }
            set { soTiet = value; }
        }
        private String khoa;

        public String Khoa
        {
            get { return khoa; }
            set { khoa = value; }
        }

        public MonHocVO()
        {

        }
    }
}
