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
        public FormGiaoVien()
        {
            InitializeComponent();
            giaoVienBUS = new GiaoVienBUS();
        }

    
        public void FormGVload()
        {
            DataTable dt = new DataTable();
            dt = giaoVienBUS.getAllGiaoVien();
            DGVGiaoVien.DataSource = dt;
        }
        private void FormGiaoVien_Load(object sender, EventArgs e)
        {
            FormGVload();       
        }

        
        private void btnThemGV_Click(object sender, EventArgs e)
        {
            GiaoVienVO GV = new GiaoVienVO();
            GV.MaGV=txtMaGV.Text;
            GV.TenGV=txtTenGV.Text;
            GV.DiaChi=txtDiaChi.Text;
            GV.SoDienThoai = txtSoDienThoai.Text;
            if (giaoVienBUS.themGiaoVien(GV) == true)
            {
                MessageBox.Show("Thêm Thành Công Giáo Viên", "Thông Báo");
                FormGVload();
            }
            else
                MessageBox.Show("Không Thêm Được Giáo Viên", "Thông Báo");
            
        }

        private void DGVGiaoVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = DGVGiaoVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaGV.Text = DGVGiaoVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenGV.Text = DGVGiaoVien.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = DGVGiaoVien.Rows[r].Cells[2].Value.ToString();
            this.txtSoDienThoai.Text = DGVGiaoVien.Rows[r].Cells[3].Value.ToString();
            
        }
    }
}
