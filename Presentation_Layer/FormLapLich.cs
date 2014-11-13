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
    public partial class FormLapLich : Form
    {
        public FormLapLich()
        {
            InitializeComponent();
        }

        private void btnQuayLaiDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult traLoi;
            traLoi = MessageBox.Show("Đóng Lập Lịch?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traLoi == DialogResult.OK)
                this.Close();
        }
    }
}
