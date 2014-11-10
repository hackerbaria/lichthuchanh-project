using Bussiness_Logic_Layer;
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
    public partial class Form1 : Form
    {
        private UserBUS _userBUS;
        public Form1()
        {
            InitializeComponent();
            _userBUS = new UserBUS();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UserVO _userVO = new UserVO();
            _userVO = _userBUS.getUserEmailByName(txtUsername.Text);
            if (_userVO.Password == null)
                MessageBox.Show("No Match Found!", "Not Found",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show(_userVO.Password, "Result",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
