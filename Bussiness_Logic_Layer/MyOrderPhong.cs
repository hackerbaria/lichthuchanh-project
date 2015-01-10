using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;

namespace Bussiness_Logic_Layer
{
    public class MyOrderPhong : IComparer<PhongVO>
    {
        public int Compare(PhongVO x, PhongVO y)
        {
            int compareSoMay = y.SoMay.CompareTo(x.SoMay);
            if (compareSoMay == 0)
            {
                return y.MaPhong.CompareTo(x.MaPhong);
            }
            return compareSoMay;
        }
    }
}
