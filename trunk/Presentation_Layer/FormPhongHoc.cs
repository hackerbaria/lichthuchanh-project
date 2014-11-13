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
    public partial class FormPhongHoc : Form
    {
        
        PhongBUS phongBUS;
        PhongVO P = new PhongVO();
        bool them = false;
        bool sua = false;
        //bool xoa = false;
        bool biSuaThongTin = false;
        public FormPhongHoc()
        {
            InitializeComponent();
        }
        public void loadPhong()
        {
            DataTable dt = new DataTable();
            dt = phongBUS.getAllPhong();
            DGVPhong.DataSource = dt;
        }
        public void suaThongTinPhong()
        {
            /*if (biSuaThongTin == false)
                MessageBox.Show("Thông Tin Giáo Viên Không Thay Đổi", "Thông Báo");
            else
            {*/

            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Phòng Học Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
          
                P.MaPhong = txtMaPhong.Text;
                P.TenPhong = txtTenPhong.Text;
                P.SoMay = Convert.ToInt32(txtSoMay.Text);
                if (phongBUS.CapNhatPhong(P) == true)
                {
                    biSuaThongTin = false;
                    MessageBox.Show("Sửa Thông Tin Phòng Học Thành Công", "Thông Báo");
                    loadPhong();
                }

            }

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            them = true;

            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtSoMay.Enabled = true;

            txtMaPhong.Focus();       
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Xóa Phòng Học Này Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
                P.MaPhong = txtMaPhong.Text;
                P.TenPhong = txtTenPhong.Text;
                P.SoMay =Convert.ToInt32( txtSoMay.Text);
             
                if (phongBUS.XoaPhong(P)== true)
                {
                    biSuaThongTin = false;
                    MessageBox.Show("Xóa Phòng Học Thành Công", "Thông Báo");
                    loadPhong();
                }

                else
                    MessageBox.Show("Không Thể Xóa Phòng Học", "Thông Báo");
            }
        }

        private void btnSuaPhong_Click(object sender, EventArgs e)
        {
            sua = true;
            
            txtMaPhong.Enabled = true;
            txtTenPhong.Enabled = true;
            txtSoMay.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                
                P.MaPhong = txtMaPhong.Text;
                P.TenPhong = txtTenPhong.Text;
                P.SoMay = Convert.ToInt32(txtSoMay.Text);
                if (phongBUS.themPhong(P) == true)
                {
                    MessageBox.Show("Thêm Thành Công Phòng Học", "Thông Báo");
                    loadPhong();
                  
                    txtMaPhong.Enabled = false;
                    txtTenPhong.Enabled = false;
                    txtSoMay.Enabled = false;
                }

                else
                    MessageBox.Show("Không Thêm Được Phòng", "Thông Báo");
            }
            else
            {
                if (sua == true)
                {
                    suaThongTinPhong();

                    sua = false;
                }

            }
        }
    }
}
