using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_Object_Layer
{
    public class GiaoVienVO
    {
        private String maGV;

        public String MaGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        private String tenGV;

        public String TenGV
        {
            get { return tenGV; }
            set { tenGV = value; }
        }
        private String diaChi;

        public String DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        private String soDienThoai;

        public String SoDienThoai
        {
            get { return soDienThoai; }
            set { soDienThoai = value; }
        }

        public GiaoVienVO()
        {

        }


    }
}
