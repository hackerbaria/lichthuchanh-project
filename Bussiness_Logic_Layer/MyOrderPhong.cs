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
            int compareSoMay = x.SoMay.CompareTo(y.SoMay);
            if (compareSoMay == 0)
            {
                return x.MaPhong.CompareTo(y.MaPhong);
            }
            return compareSoMay;
        }
    }
}
