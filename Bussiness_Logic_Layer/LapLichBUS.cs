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
        int demSoLichDayDcXep=0;
        int demSoLichDayTaoThem = 0;
        private LapLichDAO lapLichDAO;
        private PhongDAO phongDao;
        private LopHocDAO lopHocDAO;
        List<LichDayVO> listLichDayCoPhong = new List<LichDayVO>();
        private List<LichDayVO> lichThucHanhNonPhong;

        IComparer<PhongVO> comparerPhong = new MyOrderPhong();
        public LapLichBUS()
        {
            lapLichDAO = new LapLichDAO();
            phongDao = new PhongDAO();
            lopHocDAO = new LopHocDAO();
        }

        public List<LichDayVO> layLichDayThucHanhDaCoPhong()
        {
            return listLichDayCoPhong;
        }


        public int taoLichThucHanh()
        {
            int dem = 0, soLuongLTH = 0;
            lichThucHanhNonPhong = new List<LichDayVO>();
            DataTable dataTable = new DataTable();

            // lay lich ly thuyet tu database len va map tao thanh List<LichDay> lythuyet
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
                        // cung giao vien, cung mon hoc, cung lop, cung thu, cung tiet, KHAC TUAN
                        if (compareDailySchedule(dsLichDay[i], lichTam))
                        {
                            dsLichDayNho.Add(dsLichDay[i]);
                            dsLichDay.RemoveAt(i);
                        }
                    }
                    // chuyen sang Tuan Thuc Hanh
                    // vi du ly thuyet mon a, giao vien b, lop c, hoc thứ 2, tiet (1- 5) tuần 2, 3, 4, 6
                    // -> tuan 1,5,7,8,9,10,11,12,13,14,15 (tuong ung tuan thuc hanh)
                    convertToTuanThucHanh(dsLichDayNho);
                }

                // so luong lich thuc hanh
                soLuongLTH = lichThucHanhNonPhong.Count;
                lichThucHanhNonPhong.Count();
                //dem la so luong lichThucHanhNonPhong da duoc xep phong
                dem = xepPhong(lichThucHanhNonPhong);

            }
            if (dem == 0)
                return 0;
            else
                if (dem == soLuongLTH)
                    return 1;
                else
                    return 2;
        }

        //sap xep phong trong list lichThucHanhNonPhong
        //int chiSoLTH = 0;
        private int xepPhong(List<LichDayVO> lichThucHanhNonPhong)
        {
            int soLichThucHanhNonPhong= lichThucHanhNonPhong.Count;
            List<PhongVO> listPhong = new List<PhongVO>();
            List<LopVO> listLopHoc = new List<LopVO>();
            listPhong = getListPhong();
            listLopHoc = getListLopHoc();



            listPhong.Sort(comparerPhong);

            sapXepSLCuaLopHocGiamDan(listLopHoc);
            sapXepSoMayCuaPhongTangDan(listPhong);

            List<PhongVO> listPhongTam = new List<PhongVO>();
            while (lichThucHanhNonPhong.Count > 0)
            {
                List<LichDayVO> listLichDayNho = new List<LichDayVO>();

                //list phong tam dung de luu danh sach phong tam thoi cua listPhong
                
                listPhongTam= listPhong;

                //
                //tinhSoLuongPhongCanSapXep       

                //sapXepLichDayGiamDanTheoSL(list)

                //gom nhom nho cho Lich Thu Hanh giong nhau-> chung tuan, thu, buoi(sang hoac chieu)
                gomNhom(lichThucHanhNonPhong, listLichDayNho);

                //gan phong cho nhom nho
                ganPhongChoNhom(listLichDayNho, listPhongTam, listLopHoc);
                //insert Lich Day Nho Vao Lich Thuc Hanh trong CSDL
                //dem = insertToSQLLichThucHanh(listLichDayNho, dem);

            }

            //List<LichDayVO> listAA = new List<LichDayVO>();
            //listAA = layLichDayThucHanhDaCoPhong();

            if (demSoLichDayDcXep == soLichThucHanhNonPhong + demSoLichDayTaoThem)
            {
                if (insertToSQLLichThucHanh())
                {
                    return soLichThucHanhNonPhong;
                }
            }
            return demSoLichDayDcXep;


        }
        List<PhongVO> layListPhongTam(List<PhongVO> listPhong)
        {
            List<PhongVO> pt = new List<PhongVO>();
            for (int i = 0; i < listPhong.Count; i++)
                pt.Add(listPhong[i]);
            return pt;
        }
       
        void sapXepSLCuaLopHocGiamDan(List<LopVO> listLopHoc)
        {
            if (listLopHoc.Count > 1)
            {
                for (int i = 0; i < listLopHoc.Count; i++)
                    for (int j = 1; j < listLopHoc.Count; j++)
                        if (listLopHoc[i].SoLuongSV < listLopHoc[j].SoLuongSV)
                        {
                            LopVO lh = new LopVO();
                            lh = listLopHoc[i];
                            listLopHoc[i] = listLopHoc[j];
                            listLopHoc[j] = lh;
                            //listLopHoc.Sort()
                        }
            }
        }
        void sapXepSoMayCuaPhongTangDan(List<PhongVO> listPhong)
        {
            if(listPhong.Count>1)
            {
                for (int i = 0; i <listPhong.Count; i++)
                    for (int j = 1; j <listPhong.Count; j++)
                        if (listPhong[i].SoMay > listPhong[j].SoMay)
                        {
                            PhongVO p = new PhongVO();
                            p = listPhong[i];
                            listPhong[i] = listPhong[j];
                            listPhong[j] = p;
                        }
            }
        }
        //gom nhom nho cho nhung Lich Thu Hanh giong nhau-> chung tuan, thu, buoi(sang hoac chieu)
        private void gomNhom(List<LichDayVO> lichThucHanhNonPhong, List<LichDayVO> listLichDayNho)
        {
            LichDayVO lichDayTam = new LichDayVO();
            lichDayTam = lichThucHanhNonPhong[0];
            listLichDayNho.Add(lichDayTam);
            lichThucHanhNonPhong.Remove(lichDayTam);

            for (int j = lichThucHanhNonPhong.Count - 1; j >= 0; j--)
            {
                if (cungNhom(lichThucHanhNonPhong[j], lichDayTam))
                {
                    listLichDayNho.Add(lichThucHanhNonPhong[j]);
                    lichThucHanhNonPhong.RemoveAt(j);
                }
            }
        }
        //gan phong cho nhom nho
        private void ganPhongChoNhom(List<LichDayVO> listLichDayNho, List<PhongVO> listPhongTam, List<LopVO> listLopHoc)
        {
            for (int i = 0; i < listLopHoc.Count; i++)
            {
                if (listPhongTam.Count <= 0)
                    break;
                for (int j = 0; j < listLichDayNho.Count; j++)
                    if (listLichDayNho[j].MaLop == listLopHoc[i].MaLop)
                    {
                        PhongVO phongDuSoMay = new PhongVO();
                        phongDuSoMay = kiemPhongDuSoMay(listLopHoc[i], listPhongTam, listLichDayNho[j]);
                        //kiem dc phong du so may
                        if (phongDuSoMay != null)//?
                        {
                            //
                            listLichDayNho[j].MaPhong = phongDuSoMay.MaPhong;
                            listPhongTam.Remove(phongDuSoMay);                   
                            listLichDayCoPhong.Add(listLichDayNho[j]);
                            lichThucHanhNonPhong.Remove(listLichDayNho[j]);
                            //so lich day da dc xep phong tang len
                            demSoLichDayDcXep++;

                            //if(lapLichDAO.insertLapLichThucHanh(listLichDayNho[j]))
                            //    demSoLanInsertLTH++;
                        }
                        //ko kiem dc phong du so may nen phai ghep phong cho du
                        else
                        {
                            //tao 1 list bao gom cac phong duoc ghep
                            List<PhongVO> listCacPhongDanhCho1LTH = new List<PhongVO>();
                            listCacPhongDanhCho1LTH = kiemThemPhongDuSoMay(listLopHoc[i], listPhongTam);
                            //demSoLichDayTaoThem = demSoLichDayTaoThem + (SoPhongGhep-1:lich day co san trong listLichDayNonPhong) 
                            demSoLichDayTaoThem = demSoLichDayTaoThem + listCacPhongDanhCho1LTH.Count - 1;
                            if (listCacPhongDanhCho1LTH.Count > 1)
                            {
                                //gan nhieu phong cho 1 lichthucHanh
                                addLichThucHanhCungThay(listLichDayNho[j], listCacPhongDanhCho1LTH);
                                removeInListPhongTam(listPhongTam,listCacPhongDanhCho1LTH);
                            }
                        }
                    }
            }
        }
        private void removeInListPhongTam(List<PhongVO> listPhongTam,List<PhongVO> listCacPhongDanhCho1LTH)
        {
            int j=0;
            for(int i=listPhongTam.Count-1;i>=0&&j<listCacPhongDanhCho1LTH.Count;i--)
            {
                if(listPhongTam[i].MaPhong==listCacPhongDanhCho1LTH[j].MaPhong)
                {
                    listPhongTam.Remove(listCacPhongDanhCho1LTH[j]);
                    j++;
                }
            }
        }
        private void addLichThucHanhCungThay(LichDayVO lichCungThay, List<PhongVO> listCacPhongDanhCho1LTH)
        {

            for (int i = 0; i < listCacPhongDanhCho1LTH.Count; i++)
            {
                LichDayVO lichDayTam = new LichDayVO();
                lichDayTam.MaLop = lichCungThay.MaLop;
                lichDayTam.MaMH = lichCungThay.MaMH;
                lichDayTam.MaPhong = listCacPhongDanhCho1LTH[i].MaPhong;
                //lichDayTam.Ngay = lichCungThay.Ngay;
                lichDayTam.Thu = lichCungThay.Thu;
                lichDayTam.Tiet = lichCungThay.Tiet;
                lichDayTam.Tuan = lichCungThay.Tuan;
                //
                listLichDayCoPhong.Add(lichDayTam);
                demSoLichDayDcXep++;
            }
            lichThucHanhNonPhong.Remove(lichCungThay);
        }
        private List<PhongVO> kiemThemPhongDuSoMay(LopVO lopHocVO, List<PhongVO> listPhongTam)
        {
            int soMayNhieuPhong = 0;
            List<PhongVO> listCacPhongDanhCho1LTH = new List<PhongVO>();
            int j = listPhongTam.Count - 1;
            while (j >= 0 && soMayNhieuPhong <= lopHocVO.SoLuongSV)
            {
                soMayNhieuPhong = soMayNhieuPhong + listPhongTam[j].SoMay;
                listCacPhongDanhCho1LTH.Add(listPhongTam[j]);
                j--;
            }
            return listCacPhongDanhCho1LTH;
        }
        private PhongVO kiemPhongDuSoMay(LopVO lopHocVO, List<PhongVO> listPhongTam, LichDayVO lichDayNho)
        {
            for (int k = 0; k < listPhongTam.Count; k++)
            {
                if (listPhongTam[k].SoMay >= lopHocVO.SoLuongSV)
                {
                    return listPhongTam[k];
                }
            }
            //return false;
            return null;
        }


        //sapxep ,insert thong thuong
        //private int insertToSQLLichThucHanh(List<LichDayVO> listLichDayNho, int dem)
        //{
        //    for (int i = 0; i < listLichDayNho.Count; i++)
        //    {
        //        if (lapLichDAO.insertLapLichThucHanh(listLichDayNho[i]))
        //            dem++;
        //    }
        //    return dem;
        //}

        //insert cai tien: vd 1 lop hoc nhieu se dc xep nhieu phong
        private bool insertToSQLLichThucHanh()
        {
            int thanhCong=0;
            for (int i = 0; i <listLichDayCoPhong.Count; i++)
            {
                if (lapLichDAO.insertLapLichThucHanh(listLichDayCoPhong[i]))
                    thanhCong++;
            }
            if (thanhCong == listLichDayCoPhong.Count)
                return true;
            return false;
        }
        private bool cungNhom(LichDayVO a, LichDayVO b)
        {
            //neu a va b cung TUAN, THU, BUOI(cung sang hoac cung chieu) thì chúng chung nhóm
            if (a.Tuan == b.Tuan && a.Thu == b.Thu)
                if ((isBuoiSang(a) && isBuoiSang(b)) || ((!isBuoiSang(a)) && (!isBuoiSang(b))))
                    return true;
            return false;
        }

        // kiem tra xem lich day la sang hay chieu
        private bool isBuoiSang(LichDayVO LD)
        {
            string a = LD.Tiet.Split('-')[0];
            if (Convert.ToInt32(a) < 6)
                return true;
            return false;
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
                    phongVO.GanNhau = Convert.ToInt32(r[3]);

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
                    lopHocVO.SoLuongSV = Convert.ToInt32(r[2]);
                    lLopHoc.Add(lopHocVO);
                }
            }
            return lLopHoc;
        }
    }
}