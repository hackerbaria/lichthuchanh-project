using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.Office.Interop.Excel;

namespace Bussiness_Logic_Layer
{
    public class ExportScheduleToExcel
    {

        private Application app = null;
        private Workbook workbook = null;

        private Range workSheet_range = null;

        object missing = Type.Missing;

        public ExportScheduleToExcel()
        {
            createDoc();
        }


        public void createDoc()
        {
            try
            {

                Application oXL = new Application();
                oXL.Visible = false;
                oXL.StandardFont = "Times New Roman";
                oXL.StandardFontSize = 12;
                Workbook oWB = oXL.Workbooks.Add(missing);
                Worksheet oSheet = oWB.ActiveSheet as Worksheet;
                oSheet.Name = "T01";

                Worksheet oSheet2 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet2.Name = "T02";

                Worksheet oSheet3 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet3.Name = "T03";

                Worksheet oSheet4 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet4.Name = "T04";

                Worksheet oSheet5 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet5.Name = "T05";

                Worksheet oSheet6 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet6.Name = "T06";

                Worksheet oSheet7 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet7.Name = "T07";

                Worksheet oSheet8 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet8.Name = "T08";

                Worksheet oSheet9 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet9.Name = "T09";

                Worksheet oSheet10 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet10.Name = "T10";

                Worksheet oSheet11 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet11.Name = "T11";

                Worksheet oSheet12 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet12.Name = "T12";

                Worksheet oSheet13 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet13.Name = "T13";

                Worksheet oSheet14 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet14.Name = "T14";

                Worksheet oSheet15 = oWB.Sheets.Add(missing, missing, 1, missing)
                                as Worksheet;
                oSheet15.Name = "T15";

                createSheet(oSheet);
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


        private void createSheet(Worksheet sheet)
        {
            createHeaders(sheet, 1, 1, "LỊCH THỰC HÀNH PHÒNG MÁY - KHOA CNTT - HỌC KỲ I NĂM HỌC 2013 - 2014", "A1", "J1", 10, "TRANS", true, 18, 15, "n", "center");
            createHeaderThu(sheet, "THỨ 2", 3, 4, "D3");
            createHeaderThu(sheet, "THỨ 3", 3, 5, "E3");
            createHeaderThu(sheet, "THỨ 4", 3, 6, "F3");
            createHeaderThu(sheet, "THỨ 5", 3, 7, "G3");
            createHeaderThu(sheet, "THỨ 6", 3, 8, "H3");
            createHeaderThu(sheet, "THỨ 7", 3, 9, "I3");
            createHeaderThu(sheet, "CHỦ NHẬT", 3, 10, "J3");
            

            createTitleBuoi(sheet, "SÁNG", 5, 2, "B5");
            createTitleBuoi(sheet, "TUẦN "+sheet.Name, 4, 1, "A4");
            createTitle(sheet, "BUỔI", 4, 2, "B4");
            createTitle(sheet, "PHÒNG", 4, 3, "C4");
        }


        public void createHeaderThu(Worksheet worksheet, string content, int row, int col, string cell)
        {
            worksheet.Cells[row, col] = content;
            workSheet_range = worksheet.get_Range(cell, cell);
            workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet_range.Font.Bold = true;
            workSheet_range.ColumnWidth = 15;
            workSheet_range.Interior.Color = System.Drawing.Color.Gainsboro.ToArgb();
            workSheet_range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
           
        }

        public void createTitle(Worksheet worksheet, string content, int row, int col, string cell)
        {
            worksheet.Cells[row, col] = content;
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

        public void createTitleBuoi(Worksheet worksheet, string content, int row, int col, string cell)
        {
            worksheet.Cells[row, col] = content;
            workSheet_range = worksheet.get_Range(cell, cell);
            workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
            workSheet_range.Font.Bold = true;
            workSheet_range.ColumnWidth = 15;
            workSheet_range.Borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            workSheet_range.Borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;

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
            workSheet_range.HorizontalAlignment = XlHAlign.xlHAlignCenter;
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
