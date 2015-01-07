using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Presentation_Layer
{
    public partial class FormDangNhapDev : SplashScreen
    {
        public FormDangNhapDev()
        {
            InitializeComponent();
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

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
           
            //int quyen = 1;
            //if(radioGroup2.Click)
            //if (chkAddmin.Checked == true)
            //    quyen = 1;
            //else
            //    quyen = 2;
            //UserVO user = _userBUS.getUserEmailByName(txtTenDangNhap.Text, txtMatKhau.Text, quyen);
            //Utils.Acount = user.TenDangNhap;
            //if (user.Quyen == 1) //(user.TenDangNhap != null)
            //{
            //    //FormMain fm = new FormMain();
            //    FormMainAddmin fm = new FormMainAddmin();
            //    fm.ShowDialog();
            //}
            //else
            //{
            //    if (user.Quyen == 2)
            //    {
            //        FormXemLichGiaoVien fgvDN = new FormXemLichGiaoVien();
            //        fgvDN.ShowDialog();

            //    }
            //    else
            //        MessageBox.Show("Xem lai thong tin dang nhap", "Thong bao");
            //}    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}