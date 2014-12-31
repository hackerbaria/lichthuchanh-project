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

        private List<LichDayVO> lichThucHanhNonPhong ;


        
        public LapLichBUS()
        {
            lapLichDAO = new LapLichDAO();
        }
        public  bool insertLichDayThucHanh()
        {
            lichThucHanhNonPhong = new List<LichDayVO>();
            DataTable dataTable = new DataTable();
            dataTable = lapLichDAO.GetAllLichDayLyThuyet();
            
            if (dataTable != null)
            {
                List<LichDayVO> dsLichDay = new List<LichDayVO>();
                foreach (DataRow dr in dataTable.Rows)
                {  
                    LichDayVO lichDayVO = new LichDayVO();
                    lichDayVO.MaGV=dr[0].ToString();
                    lichDayVO.MaMH = dr[1].ToString();
                    lichDayVO.MaLop=dr[2].ToString();
                    lichDayVO.MaPhong = dr[3].ToString();
                    //if (dr[4] != null)
                    //    lichDayVO.Ngay = Convert.ToDateTime(dr[4]);
                    //else
                    //    lichDayVO.Ngay =DateTime.MinValue;
                    lichDayVO.Tuan =Convert.ToInt32(dr[5]);
                    lichDayVO.Thu = dr[6].ToString();
                    lichDayVO.Tiet = dr[7].ToString();

                    dsLichDay.Add(lichDayVO);
                }
                
                LichDayVO lichTam = new LichDayVO();
                

                List<LichDayVO> dsLichDayNho = new List<LichDayVO>();

                

                while (dsLichDay.Count > 0)
                {
                    dsLichDayNho.Clear();
                    // add first element of list into dsLichDayNho
                    // and remove it from dsLichDay
                    lichTam = dsLichDay[0];
                    dsLichDayNho.Add(lichTam);
                    dsLichDay.Remove(lichTam);
                    for (int i = dsLichDay.Count - 1; i >= 0; i--)
                    {
                        if (compareDailySchedule(dsLichDay[i], lichTam))
                        {
                            dsLichDayNho.Add(dsLichDay[i]);
                            dsLichDay.RemoveAt(i);
                        }
                    }
                    convertToTuanThucHanh(dsLichDayNho);
                }

                lichThucHanhNonPhong.Count();
                
                return true;
               
            }
            return false;
        }

        // compare 2 dailySchedules
        //if 2 dailySchedules are same  (only different week)
        //return true, otherwise return false
        private bool compareDailySchedule(LichDayVO a, LichDayVO b)
        {
            if(a.MaGV.Equals(b.MaGV) && a.MaLop.Equals(b.MaLop)
                && a.MaMH.Equals(b.MaMH) && a.Thu.Equals(b.Thu) && a.Tiet.Equals(b.Tiet) && !(a.Tuan.Equals(b.Tuan)))
            {
                return true;
            } else
            {
                return false;
            }
            
        }

        //convert from weeks of concept schedule to weeks of practice schedule.
        private void convertToTuanThucHanh(List<LichDayVO> inputList)
        {
            if(inputList.Count > 0)
            {
                LichDayVO a = inputList[0];
                List<Int32> arrayWeek = new List<Int32>();

                // arrayweek: mang luu cac tuan cua ly thuyet.
                foreach(LichDayVO lichDay in inputList){
                    arrayWeek.Add(lichDay.Tuan);
                }
                for(int i = 1; i <=15; i++)
                {
                    if(!arrayWeek.Contains(i))
                    {
                        lichThucHanhNonPhong.Add(new LichDayVO(a.MaGV, a.MaMH, a.MaLop, a.MaPhong, i, a.Thu, a.Tiet));
                        
                    }
                }
            }
        }
        public bool themLapLich(LichDayVO LL)
        {


            if (lapLichDAO.insertLapLich(LL)==true)
                return true;
            else
                return false;

        }
        public bool themLapLichBoPhong(LichDayVO LL)
        {


            if (lapLichDAO.insertLapLichBoPhong(LL) == true)
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


        public void createSchedule()
        {

        }
    }
}
