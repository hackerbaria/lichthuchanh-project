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
    public partial class UCLapLichTuDong : UserControl
    {
        public UCLapLichTuDong()
        {
            InitializeComponent();
        }
        LapLichBUS lapLichBUS = new LapLichBUS();
        GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
        MonHocBUS monHocBUS = new MonHocBUS();
        LopHocBUS lopHocBUS = new LopHocBUS();
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
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                txtPath.Text = dlg.FileName;
            }
        }

        private void btnXuLi_Click(object sender, EventArgs e)
        {
            lapLichBUS.xoaLich();

            if (System.IO.File.Exists(txtPath.Text))
            {
                DataSet ds = new DataSet();
                string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.15.0;Data Source={0};Extended Properties=""Excel 8.0;HDR=YES;IMEX=1;""", txtPath.Text);
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = connectionString;

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
                int lapLich = lapLichBUS.taoLichThucHanh();
                MessageBox.Show("Đã Xếp Lịch Thực Hành Thành Công", "Successful",MessageBoxButtons.OK, MessageBoxIcon.Information);

                //if (lapLich == 0)
                //    MessageBox.Show("khong them duoc");
                //else
                //    if (lapLich == 1)
                //        MessageBox.Show("Da Them Vao Lich Thuc Hanh");
                //    else
                //        MessageBox.Show("Them Chua Het");
            }
            else
            {
                MessageBox.Show("Không có File Excel thích hợp", "Fail", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
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
                        if (str != "")
                        {
                            if (str != " " || str != "\n" || str != " " || str != "  ")
                            {
                                String[] mang = str.Split('(');

                                String[] ten = mang[0].Split('-');
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
                                //GV.TenGV=tenGV.Split(' ')o
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            Bussiness_Logic_Layer.ExportScheduleToExcel excell_app = new Bussiness_Logic_Layer.ExportScheduleToExcel();
        }

       
    }
}
