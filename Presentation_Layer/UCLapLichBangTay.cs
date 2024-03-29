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
    public partial class UCLapLichBangTay : UserControl
    {
        private GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
        private LopHocBUS lopHocBUS = new LopHocBUS();
        private MonHocBUS monHocBUS = new MonHocBUS();
        private PhongBUS phongBUS = new PhongBUS();
        private LapLichBUS lapLichBUS = new LapLichBUS();


        private GiaoVienVO GV = new GiaoVienVO();
        public UCLapLichBangTay()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt = giaoVienBUS.getAllGiaoVien();

            //set data to ComboBox Giao Vien
            cbbGiaoVien.DataSource = dt;
            cbbGiaoVien.DisplayMember = "tenGV";
            cbbGiaoVien.ValueMember = "maGV";

            //set data to ComboBox Lop Hoc
            dt = lopHocBUS.getAllLopHoc();
            cbbLop.DataSource = dt;
            cbbLop.DisplayMember = "tenLop";
            cbbLop.ValueMember = "maLop";

            //set data to ComboBox Mon Hoc
            dt = monHocBUS.getAllMonHoc();
            cbbMon.DataSource = dt;
            cbbMon.DisplayMember = "tenMonHoc";
            cbbMon.ValueMember = "maMH";

            //set data to ComboBox Phong Hoc
            dt = phongBUS.getAllPhong();
            cbbPhong.DataSource = dt;
            //int soPhong = dt.Rows.Count;
            cbbPhong.DisplayMember = "tenPhong";
            cbbPhong.ValueMember = "maPhong";


            cbbThu.Items.Add(new Item("Thứ Hai", 2));
            cbbThu.Items.Add(new Item("Thứ Ba", 3));
            cbbThu.Items.Add(new Item("Thứ Tư", 4));
            cbbThu.Items.Add(new Item("Thứ Năm", 5));
            cbbThu.Items.Add(new Item("Thứ Sáu", 6));
            cbbThu.Items.Add(new Item("Thứ Bảy", 7));

            cbbTuan.Items.Add(new Item("Tuần 1", 1));
            cbbTuan.Items.Add(new Item("Tuần 2", 2));
            cbbTuan.Items.Add(new Item("Tuần 3", 3));
            cbbTuan.Items.Add(new Item("Tuần 4", 4));
            cbbTuan.Items.Add(new Item("Tuần 5", 5));
            cbbTuan.Items.Add(new Item("Tuần 6", 6));
            cbbTuan.Items.Add(new Item("Tuần 7", 7));
            cbbTuan.Items.Add(new Item("Tuần 8", 8));
            cbbTuan.Items.Add(new Item("Tuần 9", 9));
            cbbTuan.Items.Add(new Item("Tuần 10", 10));
            cbbTuan.Items.Add(new Item("Tuần 11", 11));
            cbbTuan.Items.Add(new Item("Tuần 12", 12));
            cbbTuan.Items.Add(new Item("Tuần 13", 13));
            cbbTuan.Items.Add(new Item("Tuần 14", 14));
            cbbTuan.Items.Add(new Item("Tuần 15", 15));
        }

        private void txtTietStart_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTietEnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnThemLich_Click(object sender, EventArgs e)
        {
            if (txtTietStart.Text == "" || txtTietEnd.Text == "")
                MessageBox.Show("Hãy điền tiết bắt đầu và kết thúc cho đầy đủ", "Thông Báo");
            else
            {
                if (!lapLichBUS.checkSVPhong(cbbLop.SelectedValue + "", cbbPhong.SelectedValue + ""))
                {
                    MessageBox.Show("Số Lượng Máy của Phòng Thực Hành nhỏ hơn Số Lượng Sinh Viên", "Thông Báo Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int start = Convert.ToInt32(txtTietStart.Text);
                    int end = Convert.ToInt32(txtTietEnd.Text);
                    if (start <= end)
                    {
                        LichDayVO oneSchedule = new LichDayVO();
                        oneSchedule.MaGV = cbbGiaoVien.SelectedValue + "";
                        oneSchedule.MaLop = cbbLop.SelectedValue + "";
                        oneSchedule.MaMH = cbbMon.SelectedValue + "";
                        oneSchedule.MaPhong = cbbPhong.SelectedValue + "";

                        oneSchedule.Thu = Convert.ToString(((Item)cbbThu.SelectedItem).Value);
                        oneSchedule.Tuan = ((Item)cbbTuan.SelectedItem).Value;
                        oneSchedule.Tiet = txtTietStart.Text + "-" + txtTietEnd.Text;



                        if (lapLichBUS.themLapLich(oneSchedule))
                            MessageBox.Show("Lập Lịch Thành Công", "Thông Báo Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Lịch Đã Trùng", "Thông Báo Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Nhập sai tiết", "Thông Báo Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }


        

        
    }
}
