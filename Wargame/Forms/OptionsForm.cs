using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class OptionsForm : Form
    {
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
