using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using Battlefield_NS;
using Wargame.Forms;

namespace Wargame
{
    public partial class MainForm : Form
    {
        //static Battlefield battlefieldInstance = new Battlefield();

        private Form activeForm;
        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;

        public MainForm()
        {
            InitializeComponent();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.PanelMiniDesktop.Controls.Add(childForm);
            this.PanelMiniDesktop.Tag = childForm;
            //childForm.SuspendLayout();
            childForm.BringToFront();
            childForm.Show();
            //this.ResumeLayout();
        }
        private void BtnCloseApp(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void BtnBattlefieldConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.BattleConfigurationForm(), sender);
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.OptionsForm(), sender);
        }

        private void BtnAtkConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AttackerForm(), sender);
        }

        private void BtnDefConfig_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.DefenderForm(), sender);
            //this.Hide();
            //DefenderForm defForm = new Forms.DefenderForm();
            //defForm.Show();
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PlayForm(), sender);
        }
    }
}
