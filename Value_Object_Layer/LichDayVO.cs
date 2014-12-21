using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class LichDayVO
    {
        private String maGV;
        private String maMH;
        private String maLop;
        private String maPhong;
        private DateTime ngay;
        private int tuan;
        private String thu;
        private String tiet;


        public String MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        

        public String MaMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        

        public String MaLop
        {
            get { return maLop; }
            set { maLop = value; }
        }
        

        public String MaPhong
        {
            get { return maPhong; }
            set { maPhong = value; }
        }
        

        public DateTime Ngay
        {
            get { return ngay; }
            set { ngay = value; }
        }
        

        public int Tuan
        {
            get { return tuan; }
            set { tuan = value; }
        }
       

        public String Thu
        {
            get { return thu; }
            set { thu = value; }
        }
        
        public String Tiet
        {
            get { return tiet; }
            set { tiet = value; }
        }

        public LichDayVO()
        {

        }


    }
}
