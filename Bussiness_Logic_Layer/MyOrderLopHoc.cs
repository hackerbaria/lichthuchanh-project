using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;

namespace Bussiness_Logic_Layer
{
    public class MyOrderLopHoc : IComparer<LopVO>
    {
        public int Compare(LopVO x, LopVO y)
        {
            int compareSoSV = y.SoLuongSV.CompareTo(x.SoLuongSV);
            if (compareSoSV == 0)
            {
                return y.MaLop.CompareTo(x.MaLop);
            }
            return compareSoSV;
        }
    }
}
