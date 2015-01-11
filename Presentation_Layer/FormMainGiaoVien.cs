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
            UCXemLichGiaoVien xl = new UCXemLichGiaoVien();

            //SuspendLayout();

            //int panelWidth = 1024;
            //int panelHeight = 768;

            //panel1.Size = new Size(panelWidth, panelHeight);

            //panel1.Location = new Point(ClientSize.Width / 2 - panelWidth / 2, ClientSize.Height / 2 - panelHeight / 2);
            //panel1.Anchor = AnchorStyles.None;
            //panel1.Dock = DockStyle.None;

            //panel1.Controls.Add(xl);
            //ResumeLayout();




            panel1.Controls.Clear();
            xl.Dock = System.Windows.Forms.DockStyle.Fill;
            //ql.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Controls.Add(xl);
        }
    }
}