using Bussiness_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Value_Object_Layer;

namespace Presentation_Layer
{
    public partial class FormLapLich : Form
    {

        private GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
        private LopHocBUS lopHocBUS = new LopHocBUS();
        private MonHocBUS monHocBUS = new MonHocBUS();
        private PhongBUS phongBUS = new PhongBUS(); 
        //private GiaoVienVO GV = new GiaoVienVO();

        
        private GiaoVienVO GV = new GiaoVienVO();
        public FormLapLich()
        { 
            
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = giaoVienBUS.getAllGiaoVien();

            //set data to ComboBox Giao Vien
            cbbGiaoVien.DataSource = dt;
            cbbGiaoVien.DisplayMember = "tenGV";
            cbbGiaoVien.ValueMember = "maGV";

            //set data to ComboBox Lop Hoc
            dt = lopHocBUS.getAllLopHoc();
            cbbLop.DataSource = dt;
            cbbLop.DisplayMember = "tenLop";
            cbbLop.ValueMember = "maLop";

            //set data to ComboBox Mon Hoc
            dt = monHocBUS.getAllMonHoc();
            cbbMon.DataSource = dt;
            cbbMon.DisplayMember = "tenMonHoc";
            cbbMon.ValueMember = "maMH";

            //set data to ComboBox Phong Hoc
            dt = phongBUS.getAllPhong();
            cbbPhong.DataSource = dt;
            cbbPhong.DisplayMember = "tenPhong";
            cbbPhong.ValueMember = "maPhong";


            cbbThu.Items.Add(new Item("Thứ Hai", 2));
            cbbThu.Items.Add(new Item("Thứ Ba", 3));
            cbbThu.Items.Add(new Item("Thứ Tư", 4));
            cbbThu.Items.Add(new Item("Thứ Năm", 5));
            cbbThu.Items.Add(new Item("Thứ Sáu", 6));
            cbbThu.Items.Add(new Item("Thứ Bảy", 7));
            
            cbbTuan.Items.Add(new Item("Tuần 1", 1));
            cbbTuan.Items.Add(new Item("Tuần 2", 2));
            cbbTuan.Items.Add(new Item("Tuần 3", 3));
            cbbTuan.Items.Add(new Item("Tuần 4", 4));
            cbbTuan.Items.Add(new Item("Tuần 5", 5));
            cbbTuan.Items.Add(new Item("Tuần 6", 6));
            cbbTuan.Items.Add(new Item("Tuần 7", 7));
            cbbTuan.Items.Add(new Item("Tuần 8", 8));
            cbbTuan.Items.Add(new Item("Tuần 9", 9));
            cbbTuan.Items.Add(new Item("Tuần 10", 10));
            cbbTuan.Items.Add(new Item("Tuần 11", 11));
            cbbTuan.Items.Add(new Item("Tuần 12", 12));
            cbbTuan.Items.Add(new Item("Tuần 13", 13));
            cbbTuan.Items.Add(new Item("Tuần 14", 14));
            cbbTuan.Items.Add(new Item("Tuần 15", 15));



            
            
        }

        private void btnQuayLaiDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Đóng Lập Lịch?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
                this.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormLapLich_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            LichDayVO oneSchedule = new LichDayVO();
           String a = cbbGiaoVien.SelectedValue+"";
        }
    }
}
