using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Presentation_Layer
{
    public partial class FormMainAdmin : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLyGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCGiaoVien gv = new UCGiaoVien();
            panel1.Controls.Clear();
            gv.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(gv);
        }

        private void btnQuanLyLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCLopHoc lh = new UCLopHoc();
            panel1.Controls.Clear();
            lh.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(lh);
        }

        private void btnQuanLyPhongHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCPhongHoc ph = new UCPhongHoc();
            panel1.Controls.Clear();
            ph.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(ph);
        }

        private void btnQuanLyMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCMonHoc mh = new UCMonHoc();
            panel1.Controls.Clear();
            mh.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(mh);
        }

        private void btnLapLichBangTay_ItemClick(object sender, ItemClickEventArgs e)
        {

            UCGiaoVien gv = new UCGiaoVien();
            UCLapLichBangTay llbt = new UCLapLichBangTay();
            panel1.Controls.Clear();
            llbt.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(llbt);
        }

        private void btnLapLichTuDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCLapLichTuDong lltd = new UCLapLichTuDong();
            panel1.Controls.Clear();
            lltd.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(lltd);
        }

        private void btnXemLich_ItemClick(object sender, ItemClickEventArgs e)
        {

            UCXemLich xl = new UCXemLich();
            panel1.Controls.Clear();
            xl.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(xl);
        }

        private void btnGioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCGioiThieu gt = new UCGioiThieu();
            panel1.Controls.Clear();
            gt.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(gt);
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }
    }
}