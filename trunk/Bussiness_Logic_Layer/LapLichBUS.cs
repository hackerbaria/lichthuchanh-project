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
        private PhongDAO phongDao;


        private List<LichDayVO> lichThucHanhNonPhong;

        private LopHocDAO lopHocDAO;
        List<LichDayVO> listLichDayCoPhong = new List<LichDayVO>();
        
        public LapLichBUS()
        {
            lapLichDAO = new LapLichDAO();
            phongDao = new PhongDAO();
            lopHocDAO = new LopHocDAO();
        }
        public int insertLichDayThucHanh()
        {
            int dem = 0,soLuongLTH=0;
            DataTable dataTable = new DataTable();
            dataTable = lapLichDAO.GetAllLichDayLyThuyet();
            if (dataTable != null)
            {
                List<LichDayVO> dsLichDay = new List<LichDayVO>();
                foreach (DataRow dr in dataTable.Rows)
                {
                    LichDayVO lichDayVO = new LichDayVO();
                    lichDayVO.MaGV = dr[0].ToString();
                    lichDayVO.MaMH = dr[1].ToString();
                    lichDayVO.MaLop = dr[2].ToString();
                    lichDayVO.MaPhong = dr[3].ToString();
                    //if (dr[4] != null)
                    //    lichDayVO.Ngay = Convert.ToDateTime(dr[4]);
                    //else
                    //    lichDayVO.Ngay =DateTime.MinValue;
                    lichDayVO.Tuan = Convert.ToInt32(dr[5]);
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

                soLuongLTH = lichThucHanhNonPhong.Count;
                lichThucHanhNonPhong.Count();
                //dem la so luong lichThucHanhNonPhong da duoc xep phong
                dem = arrangePhong(lichThucHanhNonPhong);


            }
            if (dem == 0)
                return 0;
            else
                if (dem ==soLuongLTH)
                    return 1;
                else
                    return 2;
        }
        //sap xep phong trong list lichThucHanhNonPhong
        private int arrangePhong(List<LichDayVO> lichThucHanhNonPhong)
        {
            int dem = 0;
            
            List<PhongVO> listPhong = new List<PhongVO>();
            List<LopVO> listLopHoc = new List<LopVO>();
            listPhong = getListPhong();
            listLopHoc = getListLopHoc();
            while (lichThucHanhNonPhong.Count > 0)
            {
                List<LichDayVO> listLichDayNho = new List<LichDayVO>();

                LichDayVO lichDayTam = new LichDayVO();
                lichDayTam = lichThucHanhNonPhong[0];
                listLichDayNho.Add(lichDayTam);
                lichThucHanhNonPhong.Remove(lichDayTam);


                //list phong tam dung de luu danh sach phong tam thoi cua listPhong
                List<PhongVO> listPhongTam = new List<PhongVO>();
                for (int q = 0; q < listPhong.Count; q++)
                {
                    listPhongTam.Add(listPhong[q]);
                }

                for (int j = lichThucHanhNonPhong.Count - 1; j > 0; j--)
                {
                    if (cungNhom(lichThucHanhNonPhong[j], lichDayTam))
                    {
                        listLichDayNho.Add(lichThucHanhNonPhong[j]);
                        lichThucHanhNonPhong.RemoveAt(j);
                    }
                }

                //
                //tinhSoLuongPhongCanSapXep       
                //sapXepSLPhongHocGiamDan(listLopHoc);
                //gom nhom nho cho Lich Thu Hanh giong nhau-> chung tuan, thu, buoi(sang hoac chieu)
                gomNhom(lichThucHanhNonPhong, listLichDayNho);

                //gan phong cho nhom nho
                ganPhongChoNhom(listLichDayNho, listPhongTam,listLichDayCoPhong);
                List<LichDayVO> taoLichDay = new List<LichDayVO>();
                //insert Lich Day Nho Vao Lich Thuc Hanh trong CSDL
                dem = insertToSQLLichThucHanh(listLichDayNho, dem);

            }
            List<LichDayVO> listAA = new List<LichDayVO>();
            listAA = lichDayThucHanhDaCoPhong();
            return dem;
            

        }
        public List<LichDayVO> lichDayThucHanhDaCoPhong()
        {
            return listLichDayCoPhong;
        }
        //void sapXepSLPhongHocGiamDan(List<LopVO> listLopHoc)
        //{
        //    if(listLopHoc.Count>1)
        //    {
        //        for(int i=0;i<listLopHoc.Count;i++)
        //            for(int j=1;j<listLopHoc.Count;i++)
        //                if(listLopHoc[])
        //    }
        //}
        //gom nhom nho cho nhung Lich Thu Hanh giong nhau-> chung tuan, thu, buoi(sang hoac chieu)
        private void gomNhom(List<LichDayVO> lichThucHanhNonPhong, List<LichDayVO> listLichDayNho)
        {
            int dem = 0;
            LichDayVO lichDayTam = new LichDayVO();
            lichDayTam = lichThucHanhNonPhong[0];
            listLichDayNho.Add(lichDayTam);
            lichThucHanhNonPhong.Remove(lichDayTam);

            for (int j = lichThucHanhNonPhong.Count - 1; j > 0; j--)
            {
                if (cungNhom(lichThucHanhNonPhong[j], lichDayTam))
                {
                    listLichDayNho.Add(lichThucHanhNonPhong[j]);
                    lichThucHanhNonPhong.RemoveAt(j);
                }

                for (int i = 0; i < listLichDayNho.Count; i++)
                {
                    if (lapLichDAO.insertLapLichThucHanh(listLichDayNho[i]))
                        dem++;
                }


            }
        }
        //gan phong cho nhom nho
        private void ganPhongChoNhom(List<LichDayVO> listLichDayNho, List<PhongVO> listPhongTam, List<LichDayVO> lichDayThucHanhCoPhong)
        {
            int h = 0;// listLichDayNho.Count - 1;
            for (int k = listPhongTam.Count - 1; k > 0 && h < listLichDayNho.Count; k--)
            {
                listLichDayNho[h].MaPhong = listPhongTam[k].MaPhong;
                lichDayThucHanhCoPhong.Add(listLichDayNho[h]);
                h++;
                listPhongTam.RemoveAt(k);
            }
        }
        private int insertToSQLLichThucHanh(List<LichDayVO> listLichDayNho, int dem)
        {
            for (int i = 0; i < listLichDayNho.Count; i++)
            {
                if (lapLichDAO.insertLapLichThucHanh(listLichDayNho[i]))
                    dem++;
            }
            return dem;
        }
        private bool cungNhom(LichDayVO a, LichDayVO b)
        {
            //neu a va b cung sang hoac chieu thì chúng chung nhóm
            if (a.Tuan == b.Tuan && a.Thu == b.Thu && (isBuoiSang(a) && isBuoiSang(b)) || (!isBuoiSang(a) && !isBuoiSang(b)))
                return true;
            return false;
        }
        private bool isBuoiSang(LichDayVO LD)
        {
            string a = LD.Tiet.Split('-')[0];
            if (Convert.ToInt32(a) < 6)
                return true;
            return false;
        }
        private List<PhongVO> getListPhong()
        {
            List<PhongVO> lPhong = new List<PhongVO>();
            DataTable dt = new DataTable();
            dt = phongDao.GetAllPhong();
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    PhongVO phongVO = new PhongVO();
                    phongVO.MaPhong = r[0].ToString();
                    phongVO.TenPhong = r[1].ToString();
                    phongVO.SoMay = Convert.ToInt32(r[2]);

                    lPhong.Add(phongVO);
                }
            }
            return lPhong;
        }
        private List<LopVO> getListLopHoc()
        {
            List<LopVO> lLopHoc = new List<LopVO>();
            DataTable dt = new DataTable();
            dt = lopHocDAO.GetAllLopHoc();
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    LopVO lopHocVO = new LopVO();
                    
                    lopHocVO.MaLop = r[0].ToString();
                    lopHocVO.TenLop = r[1].ToString();
                    lopHocVO.SoLuongSV=Convert.ToInt32(r[2]);
                    lLopHoc.Add(lopHocVO);
                }
            }
            return lLopHoc;
        }
        // compare 2 dailySchedules
        //if 2 dailySchedules are same  (only different week)
        //return true, otherwise return false
        private bool compareDailySchedule(LichDayVO a, LichDayVO b)
        {
            if (a.MaGV.Equals(b.MaGV) && a.MaLop.Equals(b.MaLop)
                && a.MaMH.Equals(b.MaMH) && a.Thu.Equals(b.Thu) && a.Tiet.Equals(b.Tiet) && !(a.Tuan.Equals(b.Tuan)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //convert from weeks of concept schedule to weeks of practice schedule.
        private void convertToTuanThucHanh(List<LichDayVO> inputList)
        {
            if (inputList.Count > 0)
            {
                LichDayVO a = inputList[0];
                List<Int32> arrayWeek = new List<Int32>();

                // arrayweek: mang luu cac tuan cua ly thuyet.
                foreach (LichDayVO lichDay in inputList)
                {
                    arrayWeek.Add(lichDay.Tuan);
                }
                for (int i = 1; i <= 15; i++)
                {
                    if (!arrayWeek.Contains(i))
                    {
                        lichThucHanhNonPhong.Add(new LichDayVO(a.MaGV, a.MaMH, a.MaLop, a.MaPhong, i, a.Thu, a.Tiet));

                    }
                }
            }
        }
        public bool themLapLich(LichDayVO LL)
        {


            if (lapLichDAO.insertLapLich(LL) == true)
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
