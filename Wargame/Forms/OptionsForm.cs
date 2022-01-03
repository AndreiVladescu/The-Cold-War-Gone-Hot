using System;
using System.Windows.Forms;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class OptionsForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public OptionsForm()
        {
            InitializeComponent();
        }

        private void TrackBarSensitivity_Scroll(object sender, EventArgs e)
        {
            Tools.UpdateMouseValue(Convert.ToUInt32(TrackBarSensitivity.Value));
        }

        private void TrackBarSensitivity_MouseHover(object sender, EventArgs e)
        {
            ToolTip mouseSensitivityToolTip = new ToolTip();
            mouseSensitivityToolTip.SetToolTip(TrackBarSensitivity, "Change Mouse Sensitivity");
        }
    }
}
