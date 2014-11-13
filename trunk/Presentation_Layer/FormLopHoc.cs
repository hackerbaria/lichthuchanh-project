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
    public partial class FormLopHoc : Form
    {
        LopHocBUS lopHocBUS;
        LopVO LH = new LopVO();
       
        bool them = false;
        bool sua = false;
        //bool xoa = false;
        bool biSuaThongTin = false;
        public FormLopHoc()
        {
            InitializeComponent();
        }

        public void loadLH()
        {
            DataTable dt = new DataTable();
            dt = lopHocBUS.getAllLopHoc();
            DGVPhong.DataSource = dt; 
            DGVPhong.DataSource = dt;
        }
        public void suaThongTinLopHoc()
        {
            /*if (biSuaThongTin == false)
                MessageBox.Show("Thông Tin Giáo Viên Không Thay Đổi", "Thông Báo");
            else
            {*/

            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Lớp Học Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
                LH.MaLop = txtSoSV.Text;
                LH.TenLop = txtTenLop.Text;
                LH.SoLuongSV = Convert.ToInt32(txtSoSV.Text);
               if(lopHocBUS.CapNhatLopHoc(LH)==true)
               {
                   biSuaThongTin = false;
                   MessageBox.Show("Sửa Thông Tin Lớp Học Thành Công", "Thông Báo");
                   loadLH();
               }
              
            }

        }
    

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            txtSoSV.Enabled = true;

            txtMaLop.Focus();
        }

        private void btnXoaLopHoc_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Xoa Lớp Học Này Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
                LH.MaLop = txtMaLop.Text;
                LH.TenLop = txtTenLop.Text;
                LH.SoLuongSV =Convert.ToInt32(txtSoSV.Text);
                if(lopHocBUS.XoaLopHoc(LH)==true)
                {
                    biSuaThongTin = false;
                    MessageBox.Show("Xóa Lớp Học Thành Công", "Thông Báo");
                    loadLH();
                }
          
                else
                    MessageBox.Show("Không Thể Xóa Lớp Học", "Thông Báo");
            }
        }

        private void btnSuaLopHoc_Click(object sender, EventArgs e)
        {
            sua = true;
            txtMaLop.Enabled = true;
            txtTenLop.Enabled = true;
            txtSoSV.Enabled = true;
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                LH.MaLop = txtMaLop.Text;
                LH.TenLop = txtTenLop.Text;
                LH.SoLuongSV = Convert.ToInt32(txtSoSV.Text);
                if(lopHocBUS.themLopHoc(LH)==true)
                {
                    MessageBox.Show("Thêm Thành Công Lớp Học", "Thông Báo");
                    loadLH();
                    txtMaLop.Enabled = false;
                    txtTenLop.Enabled = false;
                    txtSoSV.Enabled = false;
                }
               
                else
                    MessageBox.Show("Không Thêm Được Giáo Viên", "Thông Báo");
            }
            else
            {
                if (sua == true)
                {
                    suaThongTinLopHoc();

                    sua = false;
                }

            }
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            loadLH();
            biSuaThongTin = false;
        }

        private void DGVLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {

        }
    }
}
