using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Battlefield_NS;

namespace Wargame.Forms
{
    public partial class PlayForm : Form
    {
        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;
        public PlayForm()
        {
            InitializeComponent();
        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            int result = battlefieldInstance.ComputeTurn();
            if (result == 2)
                LblStatus.Text = "Defenders Won";
            else if (result == -2)
                LblStatus.Text = "Attackers Won";
        }
    }
}
