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
    public partial class FormGiaoVien : Form
    {
        GiaoVienBUS giaoVienBUS;
        GiaoVienVO GV = new GiaoVienVO();
        bool them = false;
        bool sua = false;
        //bool xoa = false;
        bool biSuaThongTin = false;
        public FormGiaoVien()
        {
            InitializeComponent();
            giaoVienBUS = new GiaoVienBUS();
        }

    
        public void loadGV()
        {
            DataTable dt = new DataTable();
            dt = giaoVienBUS.getAllGiaoVien();
            DGVGiaoVien.DataSource = dt;
        }
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            loadGV();
            biSuaThongTin = false;
        }

        
        private void btnThemGV_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();

            txtMaGV.Enabled = true;
            txtTenGV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;

            txtMaGV.Focus();
       
        }

        private void DGVGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            if (biSuaThongTin == true)
            {
                suaThongTinGV();
                biSuaThongTin = false;
            }
            int r = DGVGiaoVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaGV.Text = DGVGiaoVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenGV.Text = DGVGiaoVien.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = DGVGiaoVien.Rows[r].Cells[2].Value.ToString();
            this.txtSoDienThoai.Text = DGVGiaoVien.Rows[r].Cells[3].Value.ToString();
       
        }
        
        private void txtMaGV_TextChanged(object sender, EventArgs e)
        {
            
            //biSuaThongTin = true;
            
        }

        private void txtTenGV_TextChanged(object sender, EventArgs e)
        {
            //biSuaThongTin = true;
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            //biSuaThongTin = true;
        }

        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            //biSuaThongTin = true;
        }
        public void suaThongTinGV()
        {
            /*if (biSuaThongTin == false)
                MessageBox.Show("Thông Tin Giáo Viên Không Thay Đổi", "Thông Báo");
            else
            {*/

                DialogResult traLoi;
                traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Giáo Viên Không?","Thông Báo", MessageBoxButtons.YesNo);
                if(traLoi==DialogResult.Yes)
                {
                    GV.MaGV = txtMaGV.Text;
                    GV.TenGV = txtTenGV.Text;
                    GV.DiaChi = txtDiaChi.Text;
                    GV.SoDienThoai = txtSoDienThoai.Text;
                    if (giaoVienBUS.CapNhatGiaoVien(GV) == true)
                    {
                        biSuaThongTin = false;
                        MessageBox.Show("Sửa Thông Tin Giáo Viên Thành Công", "Thông Báo");
                        loadGV();
                    }
                }
            
        }
        private void btnSuaGV_Click(object sender, EventArgs e)
        {
            sua = true;
            txtTenGV.Enabled = true;
            txtDiaChi.Enabled = true;
            txtSoDienThoai.Enabled = true;
            
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            if (biSuaThongTin == true)
                suaThongTinGV();
            this.Close();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Xóa Giáo Viên Này Không?","Thông Báo", MessageBoxButtons.YesNo);
            if(traLoi==DialogResult.Yes)
            {
                    GV.MaGV = txtMaGV.Text;
                    GV.TenGV = txtTenGV.Text;
                    GV.DiaChi = txtDiaChi.Text;
                    GV.SoDienThoai = txtSoDienThoai.Text;
                    if (giaoVienBUS.XoaGiaoVien(GV) == true)
                    {
                        biSuaThongTin = false;
                        MessageBox.Show("Xóa Giáo Viên Thành Công", "Thông Báo");
                        loadGV();
                    }
                    else
                        MessageBox.Show("Không Thể Xóa Giáo Viên", "Thông Báo");
            }
            


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(them==true)
            {
                GV.MaGV = txtMaGV.Text;
                GV.TenGV = txtTenGV.Text;
                GV.DiaChi = txtDiaChi.Text;
                GV.SoDienThoai = txtSoDienThoai.Text;
                if (giaoVienBUS.themGiaoVien(GV) == true)
                {
                    MessageBox.Show("Thêm Thành Công Giáo Viên", "Thông Báo");
                    loadGV();
                    txtTenGV.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtSoDienThoai.Enabled = false;
                    them = false;
                }
                else
                    MessageBox.Show("Không Thêm Được Giáo Viên", "Thông Báo");
            }
            else
            {
                if(sua==true)
                {
                    suaThongTinGV();
                    sua = false;
                }
             
            }
        }




        
    }
}
