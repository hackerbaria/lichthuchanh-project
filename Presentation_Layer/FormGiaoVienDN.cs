using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation_Layer
{
    public partial class FormGiaoVienDN : Form
    {
        public FormGiaoVienDN()
        {
            InitializeComponent();
        }

        private void txtTuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnTimTheoGV2_Click(object sender, EventArgs e)
        {
            txtTuanGV.Focus();
        }

        private void btnTimTheoMH_Click(object sender, EventArgs e)
        {
            txtTuanMH.Focus();
        }

        private void btnTimTheoLop_Click(object sender, EventArgs e)
        {
            txtTuanLop.Focus();
        }

        private void btnQuayLaiDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Trở Lại màn Hình Đăng Nhập?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
                this.Close();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Thoát khỏi Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
                Application.Exit();
        }
    }
}
