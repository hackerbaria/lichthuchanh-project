using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Value_Object_Layer;
using Data_Acccess_Layer;
using System.Data;

namespace Bussiness_Logic_Layer
{
    public class LapLichBUS
    {
        private LapLichDAO lapLichDAO;
        
        public LapLichBUS()
        {
            lapLichDAO = new LapLichDAO();
        }
        public bool themLapLich(LichDayVO LL)
        {


            if (lapLichDAO.insertLapLich(LL)==true)
                return true;
            else
                return false;

        }

        public DataTable getLichByMaGVAndWeek(String maGV, int week)
        {
            return lapLichDAO.getLichByMaGVAndWeek(maGV, week);
        }

        public DataTable getLichByWeek(int week)
        {
            return lapLichDAO.getLichByWeek(week);
        }
    }
}
