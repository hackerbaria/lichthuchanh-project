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
        
        public FormLopHoc()
        {
            InitializeComponent();
            lopHocBUS = new LopHocBUS();
        }

        public void loadLH()
        {
            DataTable dt = new DataTable();
            dt = lopHocBUS.getAllLopHoc();
            DGVLopHoc.DataSource = dt;
        }
        public void suaThongTinLopHoc()
        {
          

            DialogResult traLoi;
            traLoi = MessageBox.Show("Bạn Có Muốn Thay Đổi Thông Tin Lớp Học Không?", "Thông Báo", MessageBoxButtons.YesNo);
            if (traLoi == DialogResult.Yes)
            {
                LH.MaLop = txtMaLop.Text;
                LH.TenLop = txtTenLop.Text;
                LH.SoLuongSV = Convert.ToInt32(txtSoSV.Text);
               if(lopHocBUS.CapNhatLopHoc(LH)==true)
               {
                  
                   MessageBox.Show("Sửa Thông Tin Lớp Học Thành Công", "Thông Báo");
                   loadLH();
               }
              
            }

        }
    

        private void btnThemLopHoc_Click(object sender, EventArgs e)
        {
            them = true;
            txtMaLop.ResetText();
            txtSoSV.ResetText();
            txtTenLop.ResetText();

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
            txtTenLop.Enabled = true;
            txtSoSV.Enabled = true;
           
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (them == true)
            {
                LH.MaLop = txtMaLop.Text;
                LH.TenLop = txtTenLop.Text;
                try
                {
                    LH.SoLuongSV = Convert.ToInt32(txtSoSV.Text);
                    if (lopHocBUS.themLopHoc(LH) == true)
                    {
                        them = false;
                        MessageBox.Show("Thêm Thành Công Lớp Học", "Thông Báo");
                        loadLH();
                        txtMaLop.Enabled = false;
                        txtTenLop.Enabled = false;
                        txtSoSV.Enabled = false;
                    }

                    else
                        MessageBox.Show("Không Thêm Được Lớp Học", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xem Lại số Lượng Sinh Viên Vừa Nhập", "Thông Báo");
                }
                
            }
            else
            {
                if (sua == true)
                {
                    try
                    {
                        LH.SoLuongSV = Convert.ToInt32(txtSoSV.Text);
                        if (lopHocBUS.CapNhatLopHoc(LH) == true)
                        {
                            
                            suaThongTinLopHoc();
                            sua = false;
                            MessageBox.Show("Thêm Thành Công Lớp Học", "Thông Báo");
                            loadLH();
                            txtMaLop.Enabled = false;
                            txtTenLop.Enabled = false;
                            txtSoSV.Enabled = false;
                        }

                        else
                            MessageBox.Show("Không Sửa  Được Lớp Học", "Thông Báo");
                    }
                    catch
                    {
                        MessageBox.Show("Xem Lại số Lượng Sinh Viên Vừa Nhập", "Thông Báo");
                        txtSoSV.Focus();

                    }
            
                }

            }
        }

        private void FormLopHoc_Load(object sender, EventArgs e)
        {
            loadLH();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaLop.ResetText();
            txtSoSV.ResetText();
            txtTenLop.ResetText();

            txtSoSV.Enabled = false;
            txtTenLop.Enabled = false;
            txtMaLop.Enabled = false;
        }

        private void DGVLopHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = DGVLopHoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            
            this.txtMaLop.Text = DGVLopHoc.Rows[r].Cells[0].Value.ToString();
            this.txtTenLop.Text = DGVLopHoc.Rows[r].Cells[1].Value.ToString();
            this.txtSoSV.Text = DGVLopHoc.Rows[r].Cells[2].Value.ToString();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
