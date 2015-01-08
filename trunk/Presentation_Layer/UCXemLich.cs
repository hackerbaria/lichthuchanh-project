using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class UCXemLich : UserControl
    {
        private PhongBUS phongBUS = new PhongBUS();
        private GiaoVienBUS giaovienBUS = new GiaoVienBUS();
        private LapLichBUS lapLichBUS = new LapLichBUS();
        private MonHocBUS monHocBUS = new MonHocBUS();
        private LopHocBUS lopHocBUS = new LopHocBUS();
        public UCXemLich()
        {
            InitializeComponent();
        }

        private void UCXemLich_Load(object sender, System.EventArgs e)
        {
            DataTable dt = new DataTable();


            //set data to ComboBox Phong Hoc
            DataTable dtPhong = new DataTable();
            dtPhong = phongBUS.getAllPhong();
            int soPhong = dtPhong.Rows.Count;

            // so dong cua 1 datagridview
            int soDongDGV = soPhong * 2 + 1;
            List<DataGridView> listDGV = new List<DataGridView>();

            listDGV.Add(dgvTuan1);
            listDGV.Add(dgvTuan2);
            listDGV.Add(dgvTuan3);
            listDGV.Add(dgvTuan4);
            listDGV.Add(dgvTuan5);
            listDGV.Add(dgvTuan6);
            listDGV.Add(dgvTuan7);
            listDGV.Add(dgvTuan8);
            listDGV.Add(dgvTuan9);
            listDGV.Add(dgvTuan10);
            listDGV.Add(dgvTuan11);
            listDGV.Add(dgvTuan12);
            listDGV.Add(dgvTuan13);
            listDGV.Add(dgvTuan14);
            listDGV.Add(dgvTuan15);
            foreach (DataGridView dgv in listDGV)
            {

                dgv.RowCount = soDongDGV;
                dgv.Rows[0].Cells[0].Value = "Sáng";

                // in danh sach phong buoi sang.
                for (int i = 0; i < soPhong; i++)
                {
                    dgv.Rows[i].Cells[1].Value = dtPhong.Rows[i][1];

                }
                dgv.Rows[soPhong + 1].Cells[0].Value = "Chiều";

                // in danh sach phong buoi chieu
                int j = 0;
                for (int i = soPhong + 1; i < soDongDGV; i++)
                {
                    dgv.Rows[i].Cells[1].Value = dtPhong.Rows[j][1];

                    ++j;
                }

                // lay tuan tuong ung dua vao ten cua datagridview
                int week = Int32.Parse(dgv.Name.Substring(7));
                dt = lapLichBUS.getLichByWeek(week);

                DataTable dtMon = new DataTable();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    // lay ten giao vien cua lich day dua vao MaGV
                    String tenGV = giaovienBUS.getNameGiaoVienByMa(dt.Rows[i][0].ToString());

                    // lay ten mon hoc cua lich day dua vao MaMH
                    String tenMH = monHocBUS.getNameMonHocByMa(dt.Rows[i][1].ToString());

                    String tenlop = lopHocBUS.getTenLopHocByMa(dt.Rows[i][2].ToString());

                    // dinh dang cua dau ra: TenGiaoVien-TenMonHoc-TenLop (tietbatdau-tietketthuc)
                    String Value = tenGV + "-" + tenMH + "-" + tenlop + " (" + dt.Rows[i][7] + ")";

                    // Lay Thu cua lich day
                    String thu = dt.Rows[i][6].ToString();

                    for (int k = 0; k < dtPhong.Rows.Count; k++)
                    {
                        if ((dt.Rows[i][3] + "").Equals(dtPhong.Rows[k][0] + ""))
                        {
                            String tiet = dt.Rows[i][7] + "";
                            int TietEnd = Int32.Parse(tiet.Split('-')[1]);
                            if (TietEnd < 7)
                            {
                                dgv.Rows[k].Cells[Int32.Parse(thu)].Value = Value;
                            }
                            else
                            {
                                dgv.Rows[k + dtPhong.Rows.Count + 1].Cells[Int32.Parse(thu)].Value = Value;
                            }

                        }

                    }


                }
            }
        }
    }
}

