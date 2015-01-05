using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace Presentation_Layer
{
    public partial class FormDangNhapDev : SplashScreen
    {
        public FormDangNhapDev()
        {
            InitializeComponent();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}