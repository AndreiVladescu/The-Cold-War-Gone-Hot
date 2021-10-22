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
using Battlefield_NS;
using Wargame.User_Defined.Tools;
using Enums_NS;

namespace Wargame.Forms
{
    public partial class DefenderForm : Form
    {
        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;

        List<string> legUnitNames = new List<string> { "Inf_Eq", "Art", "L_Art", "H_Art", "AAG", "AT" };
        List<string> mobUnitNames = new List<string> { "Mot","L_Mech", "H_Mech", "MBT", "L_Tank", "SPArt", "SPL_Art", "SPH_Art", "SPAAG", "SPAT", "SPRArt" };
        List<string> airUnitNames = new List<string> { "MultiRole_Jet", "CAS", "Interd", "AtkHeli", "L_AtkHeli" };

        List<string> expNames = new List<string> { "Green", "Trained", "Experienced", "Veteran", "Elite" };

        List<string> flagNames = new List<string> { "SUA", "SOV" };

        int flagCounter = 0;
       
        int legGen = 1;
        int mobGen = 1;
        int airGen = 1;
        int legUnitNameCounter = 0;
        int mobUnitNameCounter = 0;
        int airUnitNameCounter = 0;

        int legUnitCounter = 0;
        int mobUnitCounter = 0;
        int airUnitCounter = 0;

        int legExp = 1;
        int mobExp = 1;
        int airExp = 1;
        
        public DefenderForm()
        {
            InitializeComponent();
            UpdateStatPanelTer();
            UpdateStatPanelAir();
        }
        private void UpdateStatPanelTer()
        {
            Front_NS.TerStruct terStruct = battlefieldInstance.GetDefTerStats();
            Front_NS.AirStruct airStruct = battlefieldInstance.GetDefAirStats();
            this.LblTerStats.Text = "Ground Army Stats:\n" +
                "Manpower: " + terStruct._hp + "           Breakthrough: " + terStruct._breakt + "           Combat Width: " + terStruct._combat_width + "\n" +
                "Soft Attack: " + terStruct._s_atk + "          Fuel Consumption: " + terStruct._fuel + "   Average Hardness: " + terStruct._hardness / (battlefieldInstance.GetDefUnitNumber()) + "\n" +
                "Hard Attack: " + terStruct._h_atk + "        Average Reliability: " + terStruct._reliab / battlefieldInstance.GetDefUnitNumber() + "    Air Attack: " + terStruct._air_atk + "\n" +
                "Defence: " + terStruct._def + "              Organization: " + terStruct._organ + "              Average Piercing: " + terStruct._pierce / battlefieldInstance.GetDefUnitNumber() + "\n" +
                "Average Armor: " + terStruct._armor / battlefieldInstance.GetDefUnitNumber() + "   Entrenchment: " + terStruct._entrench;
        }
        private void UpdateStatPanelAir()
        {
            Front_NS.AirStruct airStruct = battlefieldInstance.GetDefAirStats();
            LblAirStats.Text = "Airfoce Stats:\n" +
                "Integrity: " + airStruct._hp + "\n" +
                "Air Attack: " + airStruct._air_atk + "\n" +
                "Ground Attack: " + airStruct._gnd_atk + "\n" +
                "Air Superiority: " + airStruct._air_sup + "\n" +
                "Strategic Bombing: " + airStruct._strat_bmb;
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
            string picName = Tools.dirPath + "\\Resources\\Icons\\gen_" + Convert.ToString(gen) + ".png";
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
            string picName = Tools.dirPath + "Resources\\Unit_Images\\" + folderName + flagNames[flagCounter] + "_" + unitNames[unitCounter] + "_Gen" + Convert.ToString(gen) + ".png";
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
        private void BtnPrevLeg_Click(object sender, EventArgs e)
        {
            legUnitNameCounter--;
            if (legUnitNameCounter < 0)
                legUnitNameCounter = legUnitNames.Count() - 1;
            PictureLeg.Image = Image.FromFile(UpdateUnitPicture(legUnitNames, legUnitNameCounter, legGen));
        }

        private void BtnPrevMob_Click(object sender, EventArgs e)
        {
            mobUnitNameCounter--;
            if (mobUnitNameCounter < 0)
                mobUnitNameCounter = mobUnitNames.Count() - 1;
            PictureMob.Image = Image.FromFile(UpdateUnitPicture(mobUnitNames, mobUnitNameCounter, mobGen));
        }

        private void BtnPrevAir_Click(object sender, EventArgs e)
        {
            airUnitNameCounter--;
            if (airUnitNameCounter < 0)
                airUnitNameCounter = airUnitNames.Count() - 1;
            PictureAir.Image = Image.FromFile(UpdateUnitPicture(airUnitNames, airUnitNameCounter, airGen, true));
        }

        private void BtnAddLeg_Click(object sender, EventArgs e)
        {
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(legUnitNameCounter + 201);
            Gen_Enum unit_gen = (Gen_Enum)(legGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(legExp - 1);
            battlefieldInstance.AddDefTerUnit(unit_gen, unit_type, unit_xp);
            legUnitCounter = battlefieldInstance.GetDefLegUnitNumber();
            LblLegCounter.Text = "Units: " + Convert.ToString(legUnitCounter);

            UpdateStatPanelTer();
        }

        private void BtnSubLeg_Click(object sender, EventArgs e)
        {
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(legUnitNameCounter + 201);
            Gen_Enum unit_gen = (Gen_Enum)(legGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(legExp - 1);
            battlefieldInstance.SubDefTerUnit(unit_gen, unit_type, unit_xp);
            legUnitCounter = battlefieldInstance.GetDefLegUnitNumber();
            LblLegCounter.Text = "Units: " + Convert.ToString(legUnitCounter);

            UpdateStatPanelTer();
        }

        private void BtnAddMob_Click(object sender, EventArgs e)
        {
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(mobUnitNameCounter + 101);
            Gen_Enum unit_gen = (Gen_Enum)(mobGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(mobExp - 1);
            battlefieldInstance.AddDefTerUnit(unit_gen, unit_type, unit_xp);
            mobUnitCounter = battlefieldInstance.GetDefMobUnitNumber();
            LblMobCounter.Text = "Units: " + Convert.ToString(mobUnitCounter);

            UpdateStatPanelTer();
        }

        private void BtnSubMob_Click(object sender, EventArgs e)
        {
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(mobUnitNameCounter + 101);
            Gen_Enum unit_gen = (Gen_Enum)(mobGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(mobExp - 1);
            battlefieldInstance.SubDefTerUnit(unit_gen, unit_type, unit_xp);
            mobUnitCounter = battlefieldInstance.GetDefMobUnitNumber();
            LblMobCounter.Text = "Units: " + Convert.ToString(mobUnitCounter);

            UpdateStatPanelTer();
        }

        private void BtnSubAir_Click(object sender, EventArgs e)
        {
            Air_Units_Enum unit_type = (Air_Units_Enum)(airUnitNameCounter + 301);
            if (airUnitNameCounter == 4 || airUnitNameCounter == 3)
                unit_type += 97;
            Gen_Enum unit_gen = (Gen_Enum)(airGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(airExp - 1);
            battlefieldInstance.SubDefAirUnit(unit_gen, unit_type, unit_xp);
            airUnitCounter = battlefieldInstance.GetDefAirUnitNumber();
            LblAirCounter.Text = "Units: " + Convert.ToString(airUnitCounter);

            UpdateStatPanelAir();
        }

        private void BtnAddAir_Click(object sender, EventArgs e)
        {
            Air_Units_Enum unit_type = (Air_Units_Enum)(airUnitNameCounter + 301);
            if (airUnitNameCounter == 4 || airUnitNameCounter == 3)
                unit_type += 97;
            Gen_Enum unit_gen = (Gen_Enum)(airGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(airExp - 1);
            battlefieldInstance.AddDefAirUnit(unit_gen, unit_type, unit_xp);
            airUnitCounter = battlefieldInstance.GetDefAirUnitNumber();
            LblAirCounter.Text = "Units: " + Convert.ToString(airUnitCounter);

            UpdateStatPanelAir();
        }

        private void PictureLegExp_Click(object sender, EventArgs e)
        {
            legExp++;
            legExp %= 5;
            PictureLegExp.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Icons\\unit_level_" + Convert.ToString(legExp + 1) + ".jpg");
            LblLegExp.Text = expNames[legExp];
        }
        private void PictureMobExp_Click(object sender, EventArgs e)
        {
            mobExp++;
            mobExp %= 5;
            PictureMobExp.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Icons\\unit_level_" + Convert.ToString(mobExp + 1) + ".jpg");
            LblMobExp.Text = expNames[mobExp];
        }
        private void PictureAirExp_Click(object sender, EventArgs e)
        {
            airExp++;
            airExp %= 5;
            PictureAirExp.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Icons\\unit_level_" + Convert.ToString(airExp + 1) + ".jpg");
            LblAirExp.Text = expNames[airExp];
        }

    }
}
