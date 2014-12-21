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



            for (int i = 0; i < soPhong; i++)
            {
                dgvTuan1.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];
            }

            dgvTuan1.Rows[soPhong].Cells[1].Value = "";
            dgvTuan1.Rows[soPhong+1].Cells[0].Value = "Chiều";
            int j = 0;
            for (int i = soPhong +1; i < soPhong*2+1; i++)
            {                
                dgvTuan1.Rows[i].Cells[1].Value = dtPhong.Rows[j++][1];
            }

            dt = lapLichBUS.getLichByMaGVAndWeek(Utils.Acount, 1);
            String t = dt.Rows[0][1] + "";

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

           



            

            }
    }
}
