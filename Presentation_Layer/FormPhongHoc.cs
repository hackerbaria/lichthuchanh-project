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
        
        public FormPhongHoc()
        {
            InitializeComponent();
            phongBUS = new PhongBUS();
        }
        public void loadPhong()
        {
            DataTable dt = new DataTable();
            dt = phongBUS.getAllPhong();
            DGVPhong.DataSource = dt;
        }
        public void suaThongTinPhong()
        {
           

            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Phòng Học Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
          
                P.MaPhong = txtMaPhong.Text;
                P.TenPhong = txtTenPhong.Text;
                try
                {
                    P.SoMay = Convert.ToInt32(txtSoMay.Text);
                    if (phongBUS.CapNhatPhong(P) == true)
                    {

                        MessageBox.Show("Sửa Thông Tin Phòng Học Thành Công", "Thông Báo");
                        loadPhong();
                        sua = false;
                    }
                    else
                        MessageBox.Show("Không Thể Sửa Thông Tin Phòng Học", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xem Lại Thông Tin mới sửa", "Thông Báo");
                }

            }

        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaPhong.ResetText();
            txtTenPhong.ResetText();
            txtSoMay.ResetText();

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
                if (txtSoMay.Text != "")
                {
                    P.SoMay = Convert.ToInt32(txtSoMay.Text);
                }
                else
                    P.SoMay =-1;
                if (phongBUS.XoaPhong(P)== true)
                {
                   
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
            
            txtTenPhong.Enabled = true;
            txtSoMay.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                P.MaPhong = txtMaPhong.Text;
                P.TenPhong = txtTenPhong.Text;
                try
                {   
                    P.SoMay = Convert.ToInt32(txtSoMay.Text);
                    if (phongBUS.themPhong(P) == true)
                    {
                        them = false;
                        MessageBox.Show("Thêm Thành Công Phòng Học", "Thông Báo");
                        loadPhong();
                  
                        txtMaPhong.Enabled = false;
                        txtTenPhong.Enabled = false;
                        txtSoMay.Enabled = false;
                    }
                    else
                        MessageBox.Show("Không Thêm Được Phòng", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Kiểm Tra Số Lượng Máy vừa nhập", "Thông Báo");
                    txtSoMay.Focus();
                }
            }   
            else
            {
                if (sua == true)
                {
                    suaThongTinPhong();

                    
                }

            }
        }

        private void FormPhongHoc_Load(object sender, EventArgs e)
        {
            loadPhong();
        }

        private void DGVPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = DGVPhong.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaPhong.Text = DGVPhong.Rows[r].Cells[0].Value.ToString();
            this.txtTenPhong.Text = DGVPhong.Rows[r].Cells[1].Value.ToString();
            this.txtSoMay.Text = DGVPhong.Rows[r].Cells[2].Value.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaPhong.ResetText();
            txtTenPhong.ResetText();
            txtSoMay.ResetText();

            txtMaPhong.Enabled = false;
            txtTenPhong.Enabled = false;
            txtSoMay.Enabled = false;
        }
    }
}
