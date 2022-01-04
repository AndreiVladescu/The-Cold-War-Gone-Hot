using Battlefield_NS;
using System;
using System.Windows.Forms;
using Wargame.Forms;
using Wargame.User_Defined.Tools;
using System.Media;
using System.Drawing;

namespace Wargame
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;
        public MusicPlayerForm playerForm = new MusicPlayerForm();
        private SoundPlayer buttonSound = new SoundPlayer(Tools.dirPath + "Resources\\SFX\\button6.wav");
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            this.Icon = new Icon(Tools.dirPath + "\\Resources\\ColdWar_icon.ico");
            playerForm.Visible = false;
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
            childForm.BringToFront();
            childForm.Show();
        }
        private void BtnCloseApp(object sender, EventArgs e)
        {
            buttonSound.Play();
            Tools.UpdateMouseValue(Tools.pvParam);
            System.Environment.Exit(1);
        }

        private void BtnBattlefieldConfig_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            OpenChildForm(new Forms.BattleConfigurationForm(), sender);
        }

        private void BtnOptions_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            OpenChildForm(new Forms.OptionsForm(), sender);
        }

        private void BtnAtkConfig_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            OpenChildForm(new Forms.AttackerForm(), sender);
        }

        private void BtnDefConfig_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            OpenChildForm(new Forms.DefenderForm(), sender);
        }

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            OpenChildForm(new Forms.PlayForm(), sender);
        }


        private void BtnMusicPlayer_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            if (playerForm.Visible == false)
                playerForm.Visible = true;
            else
                playerForm.Visible = false;
        }
    }
}
