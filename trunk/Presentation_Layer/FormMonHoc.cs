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
    public partial class FormMonHoc : Form
    {
        
        MonHocBUS monHocBUS;
        MonHocVO MH = new MonHocVO();

        bool them = false;
        bool sua = false;
        //bool xoa = false;
        bool biSuaThongTin = false;
        public FormMonHoc()
        {
            InitializeComponent();
        }
        public void loadMH()
        {
            DataTable dt = new DataTable();
            dt = monHocBUS.getAllMonHoc();
            DGVMonHoc.DataSource = dt;
        }
        public void suaThongTinMH()
        {
            /*if (biSuaThongTin == false)
                MessageBox.Show("Thông Tin Giáo Viên Không Thay Đổi", "Thông Báo");
            else
            {*/

            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Giáo Viên Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
               
                MH.MaMH = txtMaMH.Text;
                MH.TenMonHoc = txtTenMH.Text;
                MH.SoChi = Convert.ToInt32(txtTenMH.Text);
                MH.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                MH.Khoa = txtKhoa.Text;
                if (monHocBUS.CapNhatMonHoc(MH) == true)
                {
                    biSuaThongTin = false;
                    MessageBox.Show("Sửa Thông Tin Môn Học Thành Công", "Thông Báo");
                    loadMH();
                }
            }

        }

        private void btnThemMH_Click(object sender, EventArgs e)
        {
            them = true;
           
            txtMaMH.ResetText();
            txtTenMH.ResetText();
            txtSoChi.ResetText();
            txtSoTiet.ResetText();

            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;
            txtSoTiet.Enabled = true;
            txtSoChi.Enabled = true;

            txtMaMH.Focus();
       
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Xóa Môn Học Này Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
                
                MH.MaMH = txtMaMH.Text;
                MH.TenMonHoc = txtTenMH.Text;
                MH.SoChi = Convert.ToInt32(txtSoChi.Text);
                MH.SoTiet =Convert.ToInt32( txtSoTiet.Text);
                MH.Khoa = txtKhoa.Text;
                
                if (monHocBUS.XoaMonHoc(MH) == true)
                {
                    biSuaThongTin = false;
                    MessageBox.Show("Xóa Mon Hoc Thành Công", "Thông Báo");
                    loadMH();
                }
                else
                    MessageBox.Show("Không Thể Xóa Mon Hoc", "Thông Báo");
            }
            
        }

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            sua = true;
            
            txtMaMH.Enabled = true;
            txtTenMH.Enabled = true;
            txtSoChi.Enabled = true;
            txtSoTiet.Enabled = true;
            txtKhoa.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                
                MH.MaMH = txtMaMH.Text;
                MH.TenMonHoc = txtTenMH.Text;
                MH.SoChi = Convert.ToInt32(txtSoChi.Text);
                MH.SoTiet = Convert.ToInt32(txtSoTiet.Text);
                MH.Khoa = txtKhoa.Text;
                if (monHocBUS.themMonHoc(MH)== true)
                {
                    MessageBox.Show("Thêm Thành Công Môn Học", "Thông Báo");
                    loadMH();
                    txtMaMH.Enabled = false;
                    txtTenMH.Enabled = false;
                    txtSoChi.Enabled = false;
                    txtSoTiet.Enabled = false;
                    txtKhoa.Enabled = false;
                    them = false;
                }
                else
                    MessageBox.Show("Không Thêm Được Môn Học", "Thông Báo");
            }
            else
            {
                if (sua == true)
                {
                    suaThongTinMH();
                    sua = false;
                }

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
        }
    }
}
