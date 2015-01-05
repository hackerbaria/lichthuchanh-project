using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using Bussiness_Logic_Layer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Value_Object_Layer;

namespace Presentation_Layer
{
    public partial class UCXemLich : UserControl
    {
        private PhongBUS phongBUS = new PhongBUS();
        private GiaoVienBUS giaovienBUS = new GiaoVienBUS();
        private LapLichBUS lapLichBUS = new LapLichBUS();
        private MonHocBUS monHocBUS = new MonHocBUS();
        public UCXemLich()
        {
            InitializeComponent();
        }

        private void UCXemLich_Load(object sender, System.EventArgs e)
        {

        }
    }
}
