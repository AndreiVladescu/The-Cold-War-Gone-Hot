using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Collections;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class MusicPlayerForm : Form
    {
        String[] paths, files;
        public bool True { get; private set; }
        string propertyList = "";
        List<int> melodii = new List<int>();

        public MusicPlayerForm()
        {
            InitializeComponent();
            string[] files = System.IO.Directory.GetFiles(Tools.dirPath + "Resources\\Music\\");

            List<string> pathsList = new List<string> { };

            for (int i = 0; i < files.Count(); i++)
            {
                pathsList.Add(files[i]);
            }
            this.paths = pathsList.ToArray();

            for (int i = 0; i < files.Length; i++)
            {
                listBoxSongs.Items.Add(Tools.GetFileName(files[i]));
                propertyList = propertyList + listBoxSongs.Items[i] + "\n";
                melodii.Add(i);
            }
            listBoxSongs.SelectedIndex = melodii[0];
            WindowsMediaPlayer.Ctlcontrols.play();
            timer1.Start();
            trackBar1.Value = 30;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";
            
        }
        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
        private void MusicPlayerForm_Load(object sender, EventArgs e)
        {

        }
        private void WindowsMediaPlayer_Enter(object sender, EventArgs e)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (WindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)WindowsMediaPlayer.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)WindowsMediaPlayer.Ctlcontrols.currentPosition;
            }
            lbl_track_start.Text = WindowsMediaPlayer.Ctlcontrols.currentPositionString;
            lbl_track_end.Text = WindowsMediaPlayer.Ctlcontrols.currentItem.durationString.ToString();

            if (progressBar1.Maximum - 1 == progressBar1.Value)
            {
                if (listBoxSongs.SelectedIndex < listBoxSongs.Items.Count - 1)
                {
                    listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex + 1;
                }
                else
                {
                    listBoxSongs.SelectedIndex = melodii[0];
                }
                WindowsMediaPlayer.Ctlcontrols.play();
            }
        }
        private void btn_play_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.play();
            timer1.Start();
            trackBar1.Value = 30;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";
        }
        private void btn_pause_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.pause();
        }
        private void btn_stop_Click(object sender, EventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.stop();
        }
        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex > 0)
            {
                listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex - 1;
            }
        }
        private void btn_next_Click(object sender, EventArgs e)
        {
            if (listBoxSongs.SelectedIndex < listBoxSongs.Items.Count - 1)
            {
                listBoxSongs.SelectedIndex = listBoxSongs.SelectedIndex + 1;
            }
        }
        private void btn_sunet_Click(object sender, EventArgs e)
        {
            string sfxPath = Tools.dirPath + "Resources\\SFX\\DaVasile.mp3";
            WindowsMediaPlayer2.URL = @sfxPath;
            WindowsMediaPlayer2.Ctlcontrols.play();
        }
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";
        }
        private void progressBar1_MouseDown(object sender, MouseEventArgs e)
        {
            WindowsMediaPlayer.Ctlcontrols.currentPosition = WindowsMediaPlayer.currentMedia.duration * e.X / progressBar1.Width;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void WindowsMediaPlayer_Enter_1(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void lbl_track_start_Click(object sender, EventArgs e)
        {

        }
        private void lbl_track_end_Click(object sender, EventArgs e)
        {

        }
        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            WindowsMediaPlayer.settings.volume = trackBar1.Value;
            lbl_volume.Text = trackBar1.Value.ToString() + "%";
        }
        private void listBoxSongs_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            WindowsMediaPlayer.URL = paths[listBoxSongs.SelectedIndex];
        }
        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);
                }
            }
        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}
