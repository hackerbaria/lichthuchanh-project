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
    public partial class FormXemLichGiaoVien : Form
    {
        private PhongBUS phongBUS = new PhongBUS();
        public FormXemLichGiaoVien()
        {
            InitializeComponent();
        }

        private void FormXemLichGiaoVien_Load(object sender, EventArgs e)
        {
            
           
            DataTable dt = new DataTable();
            //set data to ComboBox Phong Hoc
            dt = phongBUS.getAllPhong();
            
            int soPhong = dt.Rows.Count;
            dgvTuan1.RowCount = soPhong * 2 +1;
            dgvTuan1.Rows[0].Cells[0].Value= "Sáng";



            for (int i = 0; i < soPhong; i++)
            {
                dgvTuan1.Rows[i].Cells[1].Value = dt.Rows[i][1];
            }

            dgvTuan1.Rows[soPhong].Cells[1].Value = "";
            dgvTuan1.Rows[soPhong+1].Cells[0].Value = "Chiều";
            int j = 0;
            for (int i = soPhong +1; i < soPhong*2+1; i++)
            {                
                dgvTuan1.Rows[i].Cells[1].Value = dt.Rows[j++][1];
            }



            

        }
    }
}
