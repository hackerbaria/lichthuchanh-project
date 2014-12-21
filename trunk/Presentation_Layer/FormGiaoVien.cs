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

      
        public void suaThongTinGV()
        {
           

                DialogResult traLoi;
                traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Giáo Viên Không?","Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(traLoi==DialogResult.Yes)
                {
                    GV.MaGV = txtMaGV.Text;
                    GV.TenGV = txtTenGV.Text;
                    GV.DiaChi = txtDiaChi.Text;
                    GV.SoDienThoai = txtSoDienThoai.Text;
                    if (giaoVienBUS.CapNhatGiaoVien(GV) == true)
                    {
                       
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
            this.Close();
        }

        private void btnXoaGV_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Xóa Giáo Viên Này Không?","Thông Báo", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(traLoi==DialogResult.Yes)
            {
                    GV.MaGV = txtMaGV.Text;
                    GV.TenGV = txtTenGV.Text;
                    GV.DiaChi = txtDiaChi.Text;
                    GV.SoDienThoai = txtSoDienThoai.Text;
                    if (giaoVienBUS.XoaGiaoVien(GV) == true)
                    {
                     
                        MessageBox.Show("Xóa Giáo Viên Thành Công", "Thông Báo");
                        loadGV();
                    }
                    else
                        MessageBox.Show("Không Thể Xóa Giáo Viên", "Thông Báo");
            }
            


        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            GV.SoDienThoai = txtSoDienThoai.Text;
            if (them == true)
            {
                GV.MaGV = txtMaGV.Text;
                GV.TenGV = txtTenGV.Text;
                GV.DiaChi = txtDiaChi.Text;
    
                try
                {
                    double sdt = Convert.ToInt32(txtSoDienThoai.Text);
                    if (giaoVienBUS.themGiaoVien(GV) == true)
                    {
                        MessageBox.Show("Thêm Thành Công Giáo Viên", "Thông Báo");
                        loadGV();
                        txtMaGV.Enabled = false;
                        txtTenGV.Enabled = false;
                        txtDiaChi.Enabled = false;
                        txtSoDienThoai.Enabled = false;
                        them = false;
                    }
                    else
                        MessageBox.Show("Không Thêm Được Giáo Viên", "Thông Báo");
                }
                catch
                {
                    if (txtSoDienThoai.Text == "")
                    {
                        MessageBox.Show("Thêm Thành Công Giáo Viên", "Thông Báo");
                        loadGV();
                        txtMaGV.Enabled = false;
                        txtTenGV.Enabled = false;
                        txtDiaChi.Enabled = false;
                        txtSoDienThoai.Enabled = false;
                        them = false;
                    }
                    else
                    {
                        MessageBox.Show("Hãy nhập lại số điện thoại cho hợp lý", "Thông Báo");
                        txtSoDienThoai.Focus();
                        GV.SoDienThoai = txtSoDienThoai.Text;
                    }
                }

                
            }
            else
            {
                if (sua == true)
                {
                    try
                    {
                        double sdt = Convert.ToInt32(txtSoDienThoai.Text);
                        suaThongTinGV();
                        sua = false;
                    }
                    catch
                    {
                        MessageBox.Show("Hãy sửa lại số điện thoại cho hợp lý", "Thông Báo");
                        txtSoDienThoai.Focus();
                    }
                    
                }

            }
        }

        private void DGVGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            
            int r = DGVGiaoVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaGV.Text = DGVGiaoVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenGV.Text = DGVGiaoVien.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = DGVGiaoVien.Rows[r].Cells[2].Value.ToString();
            this.txtSoDienThoai.Text = DGVGiaoVien.Rows[r].Cells[3].Value.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaGV.ResetText();
            txtTenGV.ResetText();
            txtDiaChi.ResetText();
            txtSoDienThoai.ResetText();

            txtMaGV.Enabled = false;
            txtTenGV.Enabled = false;
            txtDiaChi.Enabled = false;
            txtSoDienThoai.Enabled = false;
        }




        
    }
}
