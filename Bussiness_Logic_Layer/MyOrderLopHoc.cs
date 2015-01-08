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
            int compareSoSV = x.SoLuongSV.CompareTo(y.SoLuongSV);
            if (compareSoSV == 0)
            {
                return x.MaLop.CompareTo(y.MaLop);
            }
            return compareSoSV;
        }
    }
}
