using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bussiness_Logic_Layer;
using Value_Object_Layer;

namespace Presentation_Layer
{
    public partial class FormAutoSchedule : Form
    {
        public FormAutoSchedule()
        {
            InitializeComponent();
            
        }
        LapLichBUS lapLichBUS = new LapLichBUS();
        GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
        MonHocBUS monHocBUS = new MonHocBUS();
        LopHocBUS lopHocBUS = new LopHocBUS();

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        static DataTable GetSchemaTable(string connectionString)
        {
            using (OleDbConnection connection = new
                       OleDbConnection(connectionString))
            {
                connection.Open();
                DataTable schemaTable = connection.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });
                return schemaTable;
            }
        }


        private void btnLoadData_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txtPath.Text))
            {
                DataSet ds = new DataSet();
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", txtPath.Text);
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;
                //string query = String.Format("select * from [{0}$]", "T06");
                //OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connectionString);
                //DataSet dataSet = new DataSet();
                //dataAdapter.Fill(dataSet);
                ////dataGridView1.DataSource = dataSet.Tables[0];
                //DataTable dt = new DataTable();
                //dt = dataSet.Tables[0];
                //dataGridView1.DataSource = dt;


                DataTable sheets = GetSchemaTable(connectionString);

                foreach (DataRow r in sheets.Rows)
                {
                    string query = "SELECT * FROM [" + r.ItemArray[2].ToString() + "]";
                    ds.Clear();
                    OleDbDataAdapter data = new OleDbDataAdapter(query, connection);
                    data.Fill(ds);
                    DataTable dt = new DataTable();
                    dt = ds.Tables[0];
                    importExelToSQL(dt);

                }
                if (lapLichBUS.insertLichDayThucHanh())
                    MessageBox.Show("Da Them Vao Lich Thuc Hanh");
                else
                    MessageBox.Show("ko them dc");
            }
            else
            {
                MessageBox.Show("No File is Selected");
            }
        }

        private void importExelToSQL(DataTable dt)
        {
            if (dt != null)
            {
                
                for (int i = 3; i < dt.Rows.Count; i++)
                {
                    for (int j = 3; j < dt.Columns.Count; j++)
                    {
                        string str = dt.Rows[i].ItemArray[j].ToString();
                        if (str !="")
                        {
                            if (str !=" "||str!="\n"||str!=" "||str!="  ")
                            {
                                String[] mang = str.Split('(');

                                String[]ten = mang[0].Split('-');
                                string tenGV = ten[0];
                                string tenMH = ten[1];
                                string tenLop = ten[2];

                                string tiet = mang[1].Split(')')[0];

                                GiaoVienVO GV = new GiaoVienVO();
                                MonHocVO MH = new MonHocVO();
                                LopVO LH = new LopVO();
                                //lay ma GV thong qua TenGV
                                GV.TenGV = tenGV;
                                //tao maGV dua vao ten
                                //GV.TenGV=tenGV.Split(' ')ơ
                                GiaoVienVO gv = giaoVienBUS.getGiaoVienByName(GV);


                                //lay maMH thong qua TenMH

                                MH.TenMonHoc = tenMH;
                                MonHocVO mh = monHocBUS.getMonHocByName(MH);

                                //Lay MaLop Thong Qua Ten
                                LH.TenLop = tenLop;
                                LopVO lh = lopHocBUS.getLopHocByName(LH);

                                LichDayVO LD = new LichDayVO();
                                LD.MaGV = gv.MaGV;
                                LD.MaMH = mh.MaMH;
                                LD.MaLop = lh.MaLop;
                                //LD.Thu = dt.Rows[1].ItemArray[3].ToString();             
                                LD.Thu = j - 1 + "";
                                LD.Tiet = tiet;

                                //cat chuoi lay tuan
                                string chuoi = dt.Rows[2].ItemArray[0].ToString();
                                string layChuoiCoTuan = (chuoi.Split('\n')[0]).Trim();
                                string tuanDangString = (layChuoiCoTuan.Split(' ')[1]).Trim();
                                int tuan = Convert.ToInt32(tuanDangString);
                                LD.Tuan = tuan;
                                lapLichBUS.themLapLichBoPhong(LD);
                                //LD.MaPhong = "P001"; ->khoi truyen
                                //if (lapLichBUS.themLapLichBoPhong(LD))
                                //    MessageBox.Show("Da Them Vao CSDL");
                                //else
                                //    MessageBox.Show("ko them vao CSDL duoc");
                            }
                        }
                    }
                }
            }
        }

       
        private void sinhMa()
        {
            //GiaoVienVO GV = new GiaoVienVO();
            //GV.TenGV= "Nguyen Van Binh";
            //if (giaoVienBUS.themGiaoVienTheoTen(GV))
            //    MessageBox.Show("them thanh cong GV");
            //else
            //    MessageBox.Show("ko them dc GV");

            MonHocVO MH = new MonHocVO();
            MH.TenMonHoc = "Nhap mon lap trinh";
            if(monHocBUS.themMonHocTheoTen(MH)==1)
                MessageBox.Show("them thanh cong MH");
            else
                if (monHocBUS.themMonHocTheoTen(MH) ==0)
                    MessageBox.Show("ko them dc MH");
                else
                    if(monHocBUS.themMonHocTheoTen(MH) ==2)
                        MessageBox.Show("Da Co Mon Hoc Nay");
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Bussiness_Logic_Layer.ExportScheduleToExcel excell_app = new Bussiness_Logic_Layer.ExportScheduleToExcel();

            ////creates the main header
            //excell_app.createHeaders(5, 2, "Total of Products", "B5", "D5", 2, "YELLOW", true, 10, "n");
            ////creates subheaders
            //excell_app.createHeaders(6, 2, "Sold Product", "B6", "B6", 0, "GRAY", true, 10, "");
            //excell_app.createHeaders(6, 3, "", "C6", "C6", 0, "GRAY", true, 10, "");
            //excell_app.createHeaders(6, 4, "Initial Total", "D6", "D6", 0, "GRAY", true, 10, "");

            ////add Data to to cells
            //excell_app.addData(7, 2, "114287", "B7", "B7", "#,##0");
            //excell_app.addData(7, 3, "", "C7", "C7", "");
            //excell_app.addData(7, 4, "129121", "D7", "D7", "#,##0");
            ////add percentage row
            //excell_app.addData(8, 2, "", "B8", "B8", "");
            //excell_app.addData(8, 3, "=B7/D7", "C8", "C8", "0.0%");
            //excell_app.addData(8, 4, "", "D8", "D8", "");
            ////add empty divider
            //excell_app.createHeaders(9, 2, "", "B9", "D9", 2, "GAINSBORO", true, 10, "");
        }

        

    }
}

