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
    public partial class FormMainGiaoVien : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FormMainGiaoVien()
        {
            InitializeComponent();
        }
        private void btnXemLichDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            UCXemLich xl = new UCXemLich();
            panel1.Controls.Clear();
            xl.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(xl);
        }
    }
}