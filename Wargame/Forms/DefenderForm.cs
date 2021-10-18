using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Wargame.Forms
{
    public partial class DefenderForm : Form
    {
        string dirName = Directory.GetCurrentDirectory();

        List<string> legUnitNames = new List<string> { "Inf_Eq", "Art", "L_Art", "H_Art", "AAG", "AT" };
        List<string> mobUnitNames = new List<string> { "Mot","L_Mech", "H_Mech", "MBT", "L_Tank", "SPArt", "SPL_Art", "SPH_Art", "SPAAG", "SPAT", "SPRArt" };
        List<string> airUnitNames = new List<string> { "MultiRole_Jet", "CAS", "Interd", "AtkHeli", "L_AtkHeli" };

        List<string> flagNames = new List<string> { "SUA", "SOV" };

        int flagCounter = 0;
       
        int legGen = 1;
        int mobGen = 1;
        int airGen = 1;
        int legUnitNameCounter = 0;
        int mobUnitNameCounter = 0;
        int airUnitNameCounter = 0;
        public DefenderForm()
        {
            InitializeComponent();
            dirName = dirName.Remove(dirName.Length - 9); // Removes /bin/DEBUG from folder name
        }
        private string GetUnitPicturePath(List<string> unitNames, int unitCounter, ref int gen, bool isAir = false)
        {
            gen++;
            if (gen == 4)
                gen -= 3;
            return UpdateUnitPicture(unitNames, unitCounter, gen, isAir);
        }
        private string GetGenPicturePath(int gen)
        {
            string picName = dirName + "\\Resources\\Icons\\gen_" + Convert.ToString(gen) + ".png";
            return picName;
        }
        private void PictureFlagDefender_Click(object sender, EventArgs e)
        {
            PictureFlagDefender.Image = null;
            if (flagCounter == 0)
            {
                PictureFlagDefender.Image = global::Wargame.Properties.Resources.SOV_flag;
                LblDefArmyStats.Text = "USSR Army Stats:";
                flagCounter++;
            }
            else
            {
                flagCounter--;
                PictureFlagDefender.Image = global::Wargame.Properties.Resources.USA_flag;
                LblDefArmyStats.Text = "USA Army Stats:";
            }

            FlagUnitUpdates();
        }
        private void FlagUnitUpdates()
        {
            PictureLeg.Image = Image.FromFile(UpdateUnitPicture(legUnitNames, legUnitNameCounter, legGen));
            PictureMob.Image = Image.FromFile(UpdateUnitPicture(mobUnitNames, mobUnitNameCounter, mobGen));
            PictureAir.Image = Image.FromFile(UpdateUnitPicture(airUnitNames, airUnitNameCounter, airGen, true));
        }
        private string UpdateUnitPicture(List<string> unitNames, int unitCounter,int gen, bool isAir = false)
        {
            string folderName;
            if (isAir == true)
                folderName = "Air_Units\\";
            else
                folderName = "Ter_Units\\";
            string picName = dirName + "Resources\\Unit_Images\\" + folderName + flagNames[flagCounter] + "_" + unitNames[unitCounter] + "_Gen" + Convert.ToString(gen) + ".png";
            return picName;
        }
        private void BtnLegGen_Click(object sender, EventArgs e)
        {
            PictureLeg.Image = Image.FromFile(GetUnitPicturePath(legUnitNames, legUnitNameCounter, ref legGen));
            PictureLegGen.Image = Image.FromFile(GetGenPicturePath(legGen));
        }
        private void BtnMobGen_Click(object sender, EventArgs e)
        {
            PictureMob.Image = Image.FromFile(GetUnitPicturePath(mobUnitNames, mobUnitNameCounter, ref mobGen));
            PictureMobGen.Image = Image.FromFile(GetGenPicturePath(mobGen));
        }
        private void BtnAirGen_Click(object sender, EventArgs e)
        {
            PictureAir.Image = Image.FromFile(GetUnitPicturePath(airUnitNames, airUnitNameCounter, ref airGen, true));
            PictureAirGen.Image = Image.FromFile(GetGenPicturePath(airGen));
        }
        private void BtnNextLeg_Click(object sender, EventArgs e)
        {
            legUnitNameCounter++;
            legUnitNameCounter = legUnitNameCounter % legUnitNames.Count();  
            PictureLeg.Image = Image.FromFile(UpdateUnitPicture(legUnitNames, legUnitNameCounter, legGen));
        }

        private void BtnNextMob_Click(object sender, EventArgs e)
        {
            mobUnitNameCounter++;
            mobUnitNameCounter = mobUnitNameCounter % mobUnitNames.Count();
            PictureMob.Image = Image.FromFile(UpdateUnitPicture(mobUnitNames, mobUnitNameCounter, mobGen));
        }

        private void BtnNextAir_Click(object sender, EventArgs e)
        {
            airUnitNameCounter++;
            airUnitNameCounter = airUnitNameCounter % airUnitNames.Count();
            PictureAir.Image = Image.FromFile(UpdateUnitPicture(airUnitNames, airUnitNameCounter, airGen, true));
        }
    }
}
