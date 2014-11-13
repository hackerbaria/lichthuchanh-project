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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            FormGiaoVien fgv = new FormGiaoVien();
            fgv.ShowDialog();
        }
        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            FormLopHoc flh = new FormLopHoc();
            flh.ShowDialog();
        }

        private void btnPhongHoc_Click(object sender, EventArgs e)
        {
            FormPhongHoc fph = new FormPhongHoc();
            fph.ShowDialog();
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            FormMonHoc fmh = new FormMonHoc();
            fmh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Thoát khỏi Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)  
                Application.Exit();
        }

        private void btnQuayLaiDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Trở Lại màn Hình Đăng Nhập?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
                this.Close();
                
        }

        private void btnLapLich_Click(object sender, EventArgs e)
        {
            FormLapLich fll = new FormLapLich();
            fll.ShowDialog();
        }

        private void btnXemLich_Click(object sender, EventArgs e)
        {
            FormXemLich fxl = new FormXemLich();
            fxl.ShowDialog();
        }
    }
}
