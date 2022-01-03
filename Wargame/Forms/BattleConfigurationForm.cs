using Battlefield_NS;
using System;
using System.Media;
using System.Windows.Forms;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class BattleConfigurationForm : Form
    {
        private SoundPlayer buttonSound = new SoundPlayer(Tools.dirPath + "Resources\\SFX\\button0.wav");

        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public BattleConfigurationForm()
        {
            InitializeComponent();
        }

        private void TrackBarFortLevel_ValueChanged(object sender, EventArgs e)
        {
            int fortLevel = TrackBarFortLevel.Value;
            this.battlefieldInstance._fort_level = fortLevel;
            LblFortShow.Text = "Level: " + Convert.ToString(fortLevel);
        }
        private void TrackBarTime_ValueChanged(object sender, EventArgs e)
        {
            int time = TrackBarTime.Value;
            LblTimeShow.Text = "Time of Day : " + Convert.ToString(time);
            if (time > 21 || time < 6)
                PictureTime.Show();
            else
                PictureTime.Hide();
            battlefieldInstance._time = time;
        }

        private void plainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureTerrain.Image = global::Wargame.Properties.Resources.terrain_plains;
            LblTerrainShow.Text = "Plains";
            battlefieldInstance._terrain = Enums_NS.Terrain_Enum.Plain;
        }

        private void forestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureTerrain.Image = global::Wargame.Properties.Resources.terrain_forest;
            LblTerrainShow.Text = "Forest";
            battlefieldInstance._terrain = Enums_NS.Terrain_Enum.Forest;
        }

        private void hillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureTerrain.Image = global::Wargame.Properties.Resources.terrain_hills;
            LblTerrainShow.Text = "Hills";
            battlefieldInstance._terrain = Enums_NS.Terrain_Enum.Hill;
        }

        private void mountainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureTerrain.Image = global::Wargame.Properties.Resources.terrain_mountain;
            LblTerrainShow.Text = "Mountains";
            battlefieldInstance._terrain = Enums_NS.Terrain_Enum.Mountain;
        }

        private void cityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureTerrain.Image = global::Wargame.Properties.Resources.terrain_urban;
            LblTerrainShow.Text = "City";
            battlefieldInstance._terrain = Enums_NS.Terrain_Enum.Urban;
        }

        private void noRiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureRiver.Visible = false;
            LblRiverShow.Text = "No river";
            battlefieldInstance._river = Enums_NS.River_Enum.No;
        }

        private void riverToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureRiver.Visible = true;
            LblRiverShow.Text = "River";
            battlefieldInstance._river = Enums_NS.River_Enum.Normal;
        }

        private void largeRiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureRiver.Visible = true;
            LblRiverShow.Text = "Large river";
            battlefieldInstance._river = Enums_NS.River_Enum.Large;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureWeather.Image = global::Wargame.Properties.Resources.weather_clear;
            LblWeatherShow.Text = "Clear";
            battlefieldInstance._weather = Enums_NS.Weather_Enum.Clear;
        }

        private void windyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureWeather.Image = global::Wargame.Properties.Resources.weather_light_rain;
            LblWeatherShow.Text = "Windy";
            battlefieldInstance._weather = Enums_NS.Weather_Enum.Windy;
        }

        private void stormyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureWeather.Image = global::Wargame.Properties.Resources.weather_heavy_rain;
            LblWeatherShow.Text = "Stormy";
            battlefieldInstance._weather = Enums_NS.Weather_Enum.Stormy;
        }

        private void springToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            LblSeasonShow.Text = "Spring";
            PictureSeason.Visible = false;
            battlefieldInstance._season = Enums_NS.Season_Enum.Spring;
        }

        private void summerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            LblSeasonShow.Text = "Summer";
            PictureSeason.Visible = false;
            battlefieldInstance._season = Enums_NS.Season_Enum.Summer;
        }

        private void autumnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            LblSeasonShow.Text = "Autumn";
            PictureSeason.Visible = false;
            battlefieldInstance._season = Enums_NS.Season_Enum.Autumn;
        }

        private void winterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            LblSeasonShow.Text = "Winter";
            PictureSeason.Visible = true;
            battlefieldInstance._season = Enums_NS.Season_Enum.Winter;
        }

        private void TrackbarAALevel_Scroll(object sender, EventArgs e)
        {
            int aaLevel = TrackbarAALevel.Value;
            this.battlefieldInstance._air_gun_level = aaLevel;
            LblAAShow.Text = "Level: " + Convert.ToString(aaLevel);
        }

        private void PanelBattlefield_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
