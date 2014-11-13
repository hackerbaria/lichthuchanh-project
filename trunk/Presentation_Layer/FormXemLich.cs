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
    public partial class FormXemLich : Form
    {
        public FormXemLich()
        {
            InitializeComponent();
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
    }
}
