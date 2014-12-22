using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Bussiness_Logic_Layer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Value_Object_Layer;

namespace Presentation_Layer
{
    public partial class FormXemLichGiaoVien : Form
    {
        private PhongBUS phongBUS = new PhongBUS();
        private GiaoVienBUS giaovienBUS = new GiaoVienBUS();
        private LapLichBUS lapLichBUS = new LapLichBUS();
        public FormXemLichGiaoVien()
        {
            InitializeComponent();
        }

        private void FormXemLichGiaoVien_Load(object sender, EventArgs e)
        {
            
           
            DataTable dt = new DataTable();

            UserVO user = new UserVO();
            user.TenDangNhap = Utils.Acount;

            dt = giaovienBUS.getGiaoVienByAccount(user);
            lblMa.Text = dt.Rows[0][0] + "";
            lblName.Text = dt.Rows[0][1] + "";
            //set data to ComboBox Phong Hoc
            DataTable dtPhong = new DataTable();
            dtPhong = phongBUS.getAllPhong();

            

            int soPhong = dtPhong.Rows.Count;
            dgvTuan1.RowCount = soPhong * 2 +1;
            dgvTuan1.Rows[0].Cells[0].Value= "Sáng";

            dgvTuan2.RowCount = soPhong * 2 + 1;
            dgvTuan2.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan3.RowCount = soPhong * 2 + 1;
            dgvTuan3.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan4.RowCount = soPhong * 2 + 1;
            dgvTuan4.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan5.RowCount = soPhong * 2 + 1;
            dgvTuan5.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan6.RowCount = soPhong * 2 + 1;
            dgvTuan6.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan7.RowCount = soPhong * 2 + 1;
            dgvTuan7.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan8.RowCount = soPhong * 2 + 1;
            dgvTuan8.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan9.RowCount = soPhong * 2 + 1;
            dgvTuan9.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan10.RowCount = soPhong * 2 + 1;
            dgvTuan10.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan11.RowCount = soPhong * 2 + 1;
            dgvTuan11.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan12.RowCount = soPhong * 2 + 1;
            dgvTuan12.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan13.RowCount = soPhong * 2 + 1;
            dgvTuan13.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan14.RowCount = soPhong * 2 + 1;
            dgvTuan14.Rows[0].Cells[0].Value = "Sáng";

            dgvTuan15.RowCount = soPhong * 2 + 1;
            dgvTuan15.Rows[0].Cells[0].Value = "Sáng";



            for (int i = 0; i < soPhong; i++)
            {
                dgvTuan1.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan2.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan3.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan4.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan5.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan6.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan7.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan8.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan9.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan10.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan11.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan12.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan13.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan14.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
                dgvTuan15.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
            }

            
            dgvTuan1.Rows[soPhong+1].Cells[0].Value = "Chiều";
            dgvTuan2.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan3.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan4.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan5.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan6.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan7.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan8.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan9.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan10.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan11.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan12.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan13.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan14.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            dgvTuan15.Rows[soPhong + 1].Cells[0].Value = "Chiều";
            int j = 0;
            for (int i = soPhong +1; i < soPhong*2+1; i++)
            {                
                dgvTuan1.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan2.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan3.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan4.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan5.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan6.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];

                dgvTuan7.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan8.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan9.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan10.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan11.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan12.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan13.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan14.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                dgvTuan15.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];
                ++j;
            }

            dt = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 1);

            DataTable dt2 = new DataTable();
            dt2 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 2);

            DataTable dt3 = new DataTable();
            dt3 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 3);

            DataTable dt4 = new DataTable();
            dt4 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 4);

            DataTable dt5 = new DataTable();
            dt5 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 5);

            DataTable dt6 = new DataTable();
            dt6 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 6);

            DataTable dt7 = new DataTable();
            dt7 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 7);

            DataTable dt8 = new DataTable();
            dt8 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 8);

            DataTable dt9 = new DataTable();
            dt9 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 9);

            DataTable dt10 = new DataTable();
            dt10 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 10);

            DataTable dt11 = new DataTable();
            dt11 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 11);

            DataTable dt12 = new DataTable();
            dt12 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 12);

            DataTable dt13 = new DataTable();
            dt13 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 13);

            DataTable dt14 = new DataTable();
            dt14 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 14);

            DataTable dt15 = new DataTable();
            dt15 = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 15);

            // tuan 1
            for (int i = 0; i < dt.Rows.Count; i++ )
            {
                String Value = dt.Rows[i][1] + " " + dt.Rows[i][2] + " " + dt.Rows[i][7] + "";
                String number = dt.Rows[i][6].ToString();
                
                for (int k = 0; k< dtPhong.Rows.Count; k++)
                {
                    String a = dt.Rows[i][3] + "";
                    String b = dtPhong.Rows[k][0]+"";
                    if ((dt.Rows[i][3] + "").Equals(dtPhong.Rows[k][0]+""))
                    {
                        String tiet = dt.Rows[i][7]+"";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan1.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan1.Rows[k + dtPhong.Rows.Count +1].Cells[Int32.Parse(number)].Value = Value;
                        }
                       
                    }

                }

               
            }

            // tuan 2
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                String Value = dt2.Rows[i][1] + " " + dt2.Rows[i][2] + " " + dt2.Rows[i][7] + "";
                String number = dt2.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    
                    if ((dt2.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt2.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan2.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan2.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 3
            for (int i = 0; i < dt3.Rows.Count; i++)
            {
                String Value = dt3.Rows[i][1] + " " + dt3.Rows[i][2] + " " + dt3.Rows[i][7] + "";
                String number = dt3.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    if ((dt3.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt3.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan3.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan3.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 4
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                String Value = dt4.Rows[i][1] + " " + dt4.Rows[i][2] + " " + dt4.Rows[i][7] + "";
                String number = dt4.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                   
                    if ((dt4.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt4.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan4.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan4.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 5
            for (int i = 0; i < dt5.Rows.Count; i++)
            {
                String Value = dt5.Rows[i][1] + " " + dt5.Rows[i][2] + " " + dt5.Rows[i][7] + "";
                String number = dt5.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    if ((dt5.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt5.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan5.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan5.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 6
            for (int i = 0; i < dt6.Rows.Count; i++)
            {
                String Value = dt6.Rows[i][1] + " " + dt6.Rows[i][2] + " " + dt6.Rows[i][7] + "";
                String number = dt6.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    
                    if ((dt6.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt6.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan6.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan6.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 7
            for (int i = 0; i < dt7.Rows.Count; i++)
            {
                String Value = dt7.Rows[i][1] + " " + dt7.Rows[i][2] + " " + dt7.Rows[i][7] + "";
                String number = dt7.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                   
                    if ((dt7.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt7.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan7.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan7.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 8

            for (int i = 0; i < dt8.Rows.Count; i++)
            {
                String Value = dt8.Rows[i][1] + " " + dt8.Rows[i][2] + " " + dt8.Rows[i][7] + "";
                String number = dt8.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    if ((dt8.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt8.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan8.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan8.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            for (int i = 0; i < dt9.Rows.Count; i++)
            {
                String Value = dt9.Rows[i][1] + " " + dt9.Rows[i][2] + " " + dt9.Rows[i][7] + "";
                String number = dt9.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    String a = dt9.Rows[i][3] + "";
                    String b = dtPhong.Rows[k][0] + "";
                    if ((dt9.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt9.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan9.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan9.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 10
            for (int i = 0; i < dt10.Rows.Count; i++)
            {
                String Value = dt10.Rows[i][1] + " " + dt10.Rows[i][2] + " " + dt10.Rows[i][7] + "";
                String number = dt10.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    if ((dt10.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt10.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan10.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan10.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 11
            for (int i = 0; i < dt11.Rows.Count; i++)
            {
                String Value = dt11.Rows[i][1] + " " + dt11.Rows[i][2] + " " + dt11.Rows[i][7] + "";
                String number = dt11.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    String a = dt11.Rows[i][3] + "";
                    String b = dtPhong.Rows[k][0] + "";
                    if ((dt11.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt11.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan11.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan11.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }
            // tuan 12
            for (int i = 0; i < dt12.Rows.Count; i++)
            {
                String Value = dt12.Rows[i][1] + " " + dt12.Rows[i][2] + " " + dt12.Rows[i][7] + "";
                String number = dt12.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                   
                    if ((dt12.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt12.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan12.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan12.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 13
            for (int i = 0; i < dt13.Rows.Count; i++)
            {
                String Value = dt13.Rows[i][1] + " " + dt13.Rows[i][2] + " " + dt13.Rows[i][7] + "";
                String number = dt13.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    if ((dt13.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt13.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan13.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan13.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 14
            for (int i = 0; i < dt14.Rows.Count; i++)
            {
                String Value = dt14.Rows[i][1] + " " + dt14.Rows[i][2] + " " + dt14.Rows[i][7] + "";
                String number = dt.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    
                    if ((dt14.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt14.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan14.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan14.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

            // tuan 15
            for (int i = 0; i < dt15.Rows.Count; i++)
            {
                String Value = dt15.Rows[i][1] + " " + dt15.Rows[i][2] + " " + dt15.Rows[i][7] + "";
                String number = dt15.Rows[i][6].ToString();

                for (int k = 0; k < dtPhong.Rows.Count; k++)
                {
                    if ((dt15.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                    {
                        String tiet = dt15.Rows[i][7] + "";
                        int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                        if (TietEnd < 7)
                        {
                            dgvTuan15.Rows[k].Cells[Int32.Parse(number)].Value = Value;
                        }
                        else
                        {
                            dgvTuan15.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(number)].Value = Value;
                        }

                    }

                }


            }

           



            

            }
    }
}
