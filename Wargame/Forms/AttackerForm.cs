using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wargame.Forms
{
    public partial class AttackerForm : Form
    {
        int flagCounterAtk = 0;
        public AttackerForm()
        {
            InitializeComponent();
        }

        private void PictureFlagAttacker_Click(object sender, EventArgs e)
        {
            PictureFlagAttacker.Image = null;
            if (flagCounterAtk == 0)
            {
                PictureFlagAttacker.Image = global::Wargame.Properties.Resources.USA_flag;
                flagCounterAtk++;
                LblAtkArmyStats.Text = "USA Army Stats:";
            }
            else
            {
                flagCounterAtk--;
                PictureFlagAttacker.Image = global::Wargame.Properties.Resources.SOV_flag;
                LblAtkArmyStats.Text = "USSR Army Stats:";
            }
                
        }
    }
}
