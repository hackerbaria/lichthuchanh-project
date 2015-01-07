using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Office.Interop.Excel;
using Value_Object_Layer;
using System.Data;

namespace Bussiness_Logic_Layer
{
    public class ExportScheduleToExcel
    {
        private int numberPhong;

        private Range workSheet_range = null;

        object missing = Type.Missing;


        private Data_Acccess_Layer.PhongDAO phongDao = new Data_Acccess_Layer.PhongDAO();

        List<PhongVO> listPhong = null;

        private MonHocBUS monHocBUS = new MonHocBUS();

        private GiaoVienBUS giaoVienBUS = new GiaoVienBUS();

        private LopHocBUS lopHocBUS = new LopHocBUS();

        private List<LichDayVO> listResult = new List<LichDayVO>();
        LapLichBUS lapLichBUS = new LapLichBUS();

        public const int columnPhong = 3;

        public ExportScheduleToExcel()
        {
            createDoc();
        }


        public void createDoc()
        {
            try
            {
                listResult = lapLichBUS.layLichDayThucHanhDaCoPhong();

                listPhong = getListPhong();
                Console.Write(listPhong.Count);

                Application oXL = new Application();
                oXL.Visible = false;
                oXL.StandardFont = "Times New Roman";
                oXL.StandardFontSize = 12;
                Workbook oWB = oXL.Workbooks.Add(missing);


                Worksheet oSheet15 = oWB.ActiveSheet as Worksheet
                                as Worksheet;
                oSheet15.Name = "T15";

                Worksheet oSheet14 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet14.Name = "T14";

                Worksheet oSheet13 = oWB.Sheets.Add(missing, missing, 1, missing)
                               as Worksheet;
                oSheet13.Name = "T13";

                Worksheet oSheet12 = oWB.Sheets.Add(missing, missing, 1, missing)
                               as Worksheet;
                oSheet12.Name = "T12";

                Worksheet oSheet11 = oWB.Sheets.Add(missing, missing, 1, missing)
                             as Worksheet;
                oSheet11.Name = "T11";

                Worksheet oSheet10 = oWB.Sheets.Add(missing, missing, 1, missing)
                              as Worksheet;
                oSheet10.Name = "T10";

                Worksheet oSheet9 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet9.Name = "T09";

                Worksheet oSheet8 = oWB.Sheets.Add(missing, missing, 1, missing)
                               as Worksheet;
                oSheet8.Name = "T08";

                Worksheet oSheet7 = oWB.Sheets.Add(missing, missing, 1, missing)
                              as Worksheet;
                oSheet7.Name = "T07";

                Worksheet oSheet6 = oWB.Sheets.Add(missing, missing, 1, missing)
                              as Worksheet;
                oSheet6.Name = "T06";

                Worksheet oSheet5 = oWB.Sheets.Add(missing, missing, 1, missing)
                               as Worksheet;
                oSheet5.Name = "T05";

                Worksheet oSheet4 = oWB.Sheets.Add(missing, missing, 1, missing)
                              as Worksheet;
                oSheet4.Name = "T04";

                Worksheet oSheet3 = oWB.Sheets.Add(missing, missing, 1, missing)
                              as Worksheet;
                oSheet3.Name = "T03";

                Worksheet oSheet2 = oWB.Sheets.Add(missing, missing, 1, missing)
                               as Worksheet;
                oSheet2.Name = "T02";

                Worksheet oSheet1 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet1.Name = "T01";
                List<Worksheet> listWorksheet = new List<Worksheet>();

                createSheet(oSheet1);
                createSheet(oSheet2);
                createSheet(oSheet3);
                createSheet(oSheet4);
                createSheet(oSheet5);
                createSheet(oSheet6);
                createSheet(oSheet7);
                createSheet(oSheet8);
                createSheet(oSheet9);
                createSheet(oSheet10);
                createSheet(oSheet11);
                createSheet(oSheet12);
                createSheet(oSheet13);
                createSheet(oSheet14);
                createSheet(oSheet15);

                listWorksheet.Add(oSheet1);
                listWorksheet.Add(oSheet2);
                listWorksheet.Add(oSheet3);
                listWorksheet.Add(oSheet4);
                listWorksheet.Add(oSheet5);
                listWorksheet.Add(oSheet6);
                listWorksheet.Add(oSheet7);
                listWorksheet.Add(oSheet8);
                listWorksheet.Add(oSheet9);
                listWorksheet.Add(oSheet10);
                listWorksheet.Add(oSheet11);
                listWorksheet.Add(oSheet12);
                listWorksheet.Add(oSheet13);
                listWorksheet.Add(oSheet14);
                listWorksheet.Add(oSheet15);

                // add add to each sheet. 
                List<LichDayVO> temp = new List<LichDayVO>();
                foreach (Worksheet workSheet in listWorksheet)
                {
                    int week = Int32.Parse(workSheet.Name.Substring(1));
                    temp.Clear();
                    temp = getLichDayByWeek(week);

                    addDataToExcel(workSheet, temp);
                }

                string fileName = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                                        + "\\LichThucHanhKhoaCNTT.xlsx";
                oWB.SaveAs(fileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook,
                    missing, missing, missing, missing,
                    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                    missing, missing, missing, missing, missing);
                oWB.Close(missing, missing, missing);
                oXL.UserControl = true;
                oXL.Quit();


                
            }
            catch (Exception e)
            {
                Console.Write("Error");
            }
            finally
            {

            }
        }


        private List<LichDayVO> getLichDayByWeek(int week)
        {
            List<LichDayVO> listOutput = new List<LichDayVO>();
            for (int j = listResult.Count - 1; j >= 0; j--)
            {
                if (listResult[j].Tuan == week)
                {
                    listOutput.Add(listResult[j]);
                    listResult.RemoveAt(j);
                }
            }
            return listOutput;
            
        }

        // get all Phong from database.
        private List<PhongVO> getListPhong()
        {
            List<PhongVO> listPhong = new List<PhongVO>();
            System.Data.DataTable dt = new System.Data.DataTable();
            dt = phongDao.GetAllPhong();
            if (dt != null)
            {
                foreach (DataRow r in dt.Rows)
                {
                    PhongVO phongVO = new PhongVO();
                    phongVO.MaPhong = r[0].ToString();
                    phongVO.TenPhong = r[1].ToString();
                    phongVO.SoMay = Convert.ToInt32(r[2]);

                    listPhong.Add(phongVO);
                }
            }
            return listPhong;
        }

        // add data to each Sheet.
        private void addDataToExcel(Worksheet workSheet, List<LichDayVO> listLichDay)
        {
            for (int i = 0; i < listLichDay.Count; i++)
            {
                MonHocVO subject = monHocBUS.getObjectMonHocByMa(listLichDay[i].MaMH);
                String tenGV = giaoVienBUS.getNameGiaoVienByMa(listLichDay[i].MaGV);
                String tenLop = lopHocBUS.getTenLopHocByMa(listLichDay[i].MaLop);
                // content format : TenGiaoVien-TenMonHoc-TenLop(tietBatDau-tietKetThuc).
                String content = tenGV + "-" + subject.TenMonHoc + "-" + tenLop + "(" + listLichDay[i].Tiet + ")";

                // Lay Thu

                String number = listLichDay[i].Thu;

                for (int k = 0; k < numberPhong; k++)
                {
                    if ((listLichDay[i].MaPhong).Equals(listPhong[k].MaPhong))
                    {
                        String tiet = listLichDay[i].Tiet;
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            workSheet.Cells[5 + k, 2 + Int32.Parse(number)] = content;                            
                        }
                        else
                        {
                            workSheet.Cells[5 + k +numberPhong+ 1, 2 + Int32.Parse(number)] = content;                        
                        }
                    }
                }
            }
        }


        private void createSheet(Worksheet workSheet)
        {
            // number of Phong
            numberPhong = listPhong.Count;
            borderAllSheet(workSheet, 4, 2, 5 + numberPhong * 2, 10);
            createHeaders(workSheet, 1, 1, "LỊCH THỰC HÀNH PHÒNG MÁY - KHOA CNTT - HỌC KỲ I NĂM HỌC 2013 - 2014", "A1", "J1", 10, "TRANS", true, 18, 15, "n", "center");
            createHeaderThu(workSheet, "THỨ 2", 3, 4);
            createHeaderThu(workSheet, "THỨ 3", 3, 5);
            createHeaderThu(workSheet, "THỨ 4", 3, 6);
            createHeaderThu(workSheet, "THỨ 5", 3, 7);
            createHeaderThu(workSheet, "THỨ 6", 3, 8);
            createHeaderThu(workSheet, "THỨ 7", 3, 9);
            createHeaderThu(workSheet, "CHỦ NHẬT", 3, 10);
            

            createTitleBuoi(workSheet, "SÁNG", 5, 2);
            createTitleBuoi(workSheet, "CHIỀU", 5+ numberPhong +1, 2);
            createTitleBuoi(workSheet, "TUẦN " + Int32.Parse(workSheet.Name.Substring(1)), 4, 1);
            createTitle(workSheet, "BUỔI", 4, 2);
            createTitle(workSheet, "PHÒNG", 4, 3);


            
           
            for (int i = 0; i < numberPhong; i++)
            {
                String contentPhong = listPhong[i].TenPhong + "(" + listPhong[i].SoMay + ")";
                workSheet.Cells[5 + i, columnPhong] = contentPhong;
                workSheet.Cells[5 + i + numberPhong + 1, columnPhong] = contentPhong;
            }



            // line to distinct Sang or Chieu
            int rowYellow = 5 + numberPhong;
            String startColumn = "B" + rowYellow;
            String endColumn = "J" + rowYellow;
            createHeaders(workSheet, rowYellow, 2, "", startColumn, endColumn, 9, "YELLOW", true, 10, 15, "", "center");

           
            
        }

        private String populateCell(int row, int col)
        {
            String cell = "";
            switch (col)
            {
                case 1:
                    cell = "A" + row;
                    break;
                case 2:
                    cell = "B" + row;
                    break;
                case 3:
                    cell = "C" + row;
                    break;
                case 4:
                    cell = "D" + row;
                    break;
                case 5:
                    cell = "E" + row;
                    break;
                case 6:
                    cell = "F" + row;
                    break;
                case 7:
                    cell = "G" + row;
                    break;
                case 8:
                    cell = "H" + row;
                    break;
                case 9:
                    cell = "I" + row;
                    break;
                case 10:
                    cell = "J" + row;
                    break;
                default:
                    break;

            }
            return cell;
        }


        public void createHeaderThu(Worksheet worksheet, string content, int row, int col)
        {
            worksheet.Cells[row, col] = content;
            String cell = populateCell(row,col);
            
            workSheet_range = worksheet.get_Range(cell, cell);
            workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet_range.Font.Bold = true;
            workSheet_range.ColumnWidth = 15;
            workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb();
            workSheet_range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
           
        }

        public void createTitle(Worksheet worksheet, string content, int row, int col)
        {
            worksheet.Cells[row, col] = content;
            worksheet.Cells[row, col] = content;
            String cell = populateCell(row, col);

            workSheet_range = worksheet.get_Range(cell, cell);            
            workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet_range.Font.Bold = true;
            workSheet_range.ColumnWidth = 15;
            workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb();
            workSheet_range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

        }

        public void createTitleBuoi(Worksheet worksheet, string content, int row, int col)
        {
            worksheet.Cells[row, col] = content;
            String cell = populateCell(row, col);

            workSheet_range = worksheet.get_Range(cell, cell);
            workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet_range.Font.Bold = true;
            workSheet_range.ColumnWidth = 15;
            workSheet_range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

        }

        private void borderAllSheet(Worksheet workSheet, int row1, int col1, int row2, int col2)
        {

            for (int i = row1; i <= row2; i++)
            {
                for (int j = col1; j <= col2; j++)
                {
                    String cell = populateCell(i, j);
                    workSheet_range = workSheet.get_Range(cell, cell);
                    workSheet_range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
                    workSheet_range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
                    workSheet_range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
                    workSheet_range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

                }
            }
        }

        public void createHeaders(Worksheet worksheet, int row, int col, string htext, string cell1, string cell2, int mergeColumns, string b, bool font,int fontSize, int size, string fcolor, string align )
        {
            worksheet.Cells[row, col] = htext;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            workSheet_range.Merge(mergeColumns);
            switch (b)
            {
                case "YELLOW":
                    workSheet_range.Interior.Color = System.Drawing.Color.Yellow.ToArgb();
                    break;
                case "GRAY":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gray.ToArgb();
                    break;
                case "TRANS":
                    workSheet_range.Interior.Color = System.Drawing.Color.Transparent.ToArgb();
                    break;
                case "GAINSBORO":
                    workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb();
                    break;
                case "ABC":
                    workSheet_range.Interior.Color = System.Drawing.Color.Red.ToArgb();
                    break;
                case "Turquoise":
                    workSheet_range.Interior.Color = System.Drawing.Color.Turquoise.ToArgb();
                    break;
                case "PeachPuff":
                    workSheet_range.Interior.Color = System.Drawing.Color.PeachPuff.ToArgb();
                    break;
                default:
                    //  workSheet_range.Interior.Color = System.Drawing.Color..ToArgb();
                    break;

            }

            switch (align)
            {
                case "right":
                    workSheet_range.HorizontalAlignment =  XlHAlign.xlHAlignRight;
                    break;
                case "center":
                    workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                    break;
                default:
                    workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignLeft;
                    break;
            }

            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.Font.Bold = font;
            workSheet_range.ColumnWidth = size;
            workSheet_range.Font.Size = fontSize;
           
            if (fcolor.Equals(""))
            {
                workSheet_range.Font.Color = System.Drawing.Color.White.ToArgb();
            }
            else
            {
                workSheet_range.Font.Color = System.Drawing.Color.Black.ToArgb();
            }

        }
        public void addData(Worksheet worksheet, int row, int col, string data, string cell1, string cell2, string format)
        {
            worksheet.Cells[row, col] = data;
            workSheet_range = worksheet.get_Range(cell1, cell2);
            workSheet_range.Borders.Color = System.Drawing.Color.Black.ToArgb();
            workSheet_range.NumberFormat = format;
        }


    }
}
