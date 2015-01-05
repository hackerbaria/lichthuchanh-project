﻿using Bussiness_Logic_Layer;
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
    public partial class FormLogin : Form
    {
        private UserBUS _userBUS;
        public FormLogin()
        {
            InitializeComponent();
            _userBUS = new UserBUS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Thoát khỏi Chương Trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traLoi==DialogResult.OK)
                this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int quyen = 1;
            if (chkAddmin.Checked == true)
                quyen = 1;
            else
                quyen = 2;
            UserVO user = _userBUS.getUserEmailByName(txtTenDangNhap.Text, txtMatKhau.Text, quyen);
            Utils.Acount = user.TenDangNhap;
            if(user.Quyen==1) //(user.TenDangNhap != null)
            {
                //FormMain fm = new FormMain();
                FormMainAddmin fm = new FormMainAddmin();
                fm.ShowDialog();
            }
            else
            { 
                if(user.Quyen==2)
                {
                    FormXemLichGiaoVien fgvDN = new FormXemLichGiaoVien();
                    fgvDN.ShowDialog();
                    
                }
                else
                    MessageBox.Show("Xem lai thong tin dang nhap", "Thong bao");
            }    
        }

        private void chkAddmin_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAddmin.Checked == true)
                chkGiaoVien.Checked = false;
        }

        private void chkGiaoVien_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGiaoVien.Checked == true)
                chkAddmin.Checked = false;
        }

        private void txtTenDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                txtMatKhau.Focus();
        }

        private void txtMatKhau_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnDangNhap.Focus();
        }
    }
}
