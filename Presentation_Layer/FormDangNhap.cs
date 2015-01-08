using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using Value_Object_Layer;
using Bussiness_Logic_Layer;

namespace Presentation_Layer
{
    public partial class FormDangNhap : SplashScreen
    {
        private UserBUS _userBUS;
        public FormDangNhap()
        {
            InitializeComponent();
            _userBUS = new UserBUS();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            int quyen = 1;
            if (rbQuanTri.Checked){
                quyen = 1;
            } else {
                 quyen = 2;
            }
           
            UserVO user = _userBUS.getUserEmailByName(txtTenDangNhap.Text, txtMatKhau.Text, quyen);
            Utils.Acount = user.TenDangNhap;
            if (user.Quyen == 1) 
            {
                FormMainAddmin fm = new FormMainAddmin();
                fm.ShowDialog();
            }
            else
            {
                if (user.Quyen == 2)
                {
                    FormMainGiaoVien fgvDN = new FormMainGiaoVien();
                    fgvDN.ShowDialog();

                }
                else
                    MessageBox.Show("Xem lại thông tin đăng nhập", "Thông Báo");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Thoát khỏi Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
                this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormDangNhapDev_Load(object sender, EventArgs e)
        {
            rbGiaoVien.Checked = true;
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txtMatKhau.Focus();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
                
        }
    }
}