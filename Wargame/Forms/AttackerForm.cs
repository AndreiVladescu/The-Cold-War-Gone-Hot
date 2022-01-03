using Air_Units_NS;
using Battlefield_NS;
using Enums_NS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using Ter_Units_NS;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class AttackerForm : Form
    {
        private SoundPlayer buttonSound = new SoundPlayer(Tools.dirPath + "Resources\\SFX\\button0.wav");

        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;

        List<string> legUnitNames = new List<string> { "Inf_Eq", "Art", "L_Art", "H_Art", "AAG", "AT" };
        List<string> mobUnitNames = new List<string> { "MBT", "L_Tank", "L_Mech", "H_Mech", "Mot", "SPAAG", "SPL_Art", "SPArt", "SPH_Art", "SPAT", "SPRArt" };
        List<string> airUnitNames = new List<string> { "MultiRole_Jet", "CAS", "Interd", "AtkHeli", "L_AtkHeli" };

        List<string> expNames = new List<string> { "Green", "Trained", "Experienced", "Veteran", "Elite" };

        List<string> flagNames = new List<string> { "SOV", "SUA" };

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
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
        public AttackerForm()
        {
            InitializeComponent();
            UpdateStatPanelTer();
            UpdateStatPanelAir();
            UpdateUnitCounters();
            UpdateArmyComposition();
            UpdateAirforceComposition();
            UpdateCommander();
            UpdateStatsLeg();
            UpdateStatsMob();
            UpdateStatsAir();
            UpdateMiscGUI();
        }
        private void UpdateMiscGUI()
        {
            //TrackBarFuel.BackgroundImage = Image.FromFile(Tools.dirPath + "\\Resources\\Panels\\main_frame_bg.png");
            TrackBarFuel.Value = (int)battlefieldInstance._atk._fuel_left;
            LblFuel.Text = "Fuel available: " +
                battlefieldInstance._atk._fuel_left.ToString();
        }
        private void UpdateArmyComposition()
        {
            LblArmyComposition.Text = "Ground Army Composition\n" +
                "Number of units: " + battlefieldInstance.GetAtkUnitNumber();

        }
        private void UpdateAirforceComposition()
        {
            LblAirforceComposition.Text = "Airforce Composition\n" +
                "Number of units: " + battlefieldInstance.GetAtkAirUnitNumber();
        }
        private void UpdateUnitCounters()
        {
            string buff = "Units: ";
            LblLegCounter.Text = buff + battlefieldInstance.GetAtkLegUnitNumber().ToString();
            LblMobCounter.Text = buff + battlefieldInstance.GetAtkMobUnitNumber().ToString();
            LblAirCounter.Text = buff + battlefieldInstance.GetAtkAirUnitNumber().ToString();
        }
        private void UpdateStatPanelTer()
        {
            Front_NS.TerStruct terStruct = battlefieldInstance.GetAtkTerStats();

            this.LblTerStats.Text = "Ground Army Stats:\n" +
                "Manpower: " + terStruct._hp + "           Breakthrough: " + terStruct._breakt + "           Combat Width: " + terStruct._combat_width + "\n" +
                "Soft Attack: " + terStruct._s_atk + "          Fuel Consumption: " + terStruct._fuel + "   Average Hardness: " + terStruct._hardness / (battlefieldInstance.GetAtkUnitNumber()) + "\n" +
                "Hard Attack: " + terStruct._h_atk + "        Average Reliability: " + terStruct._reliab / battlefieldInstance.GetAtkUnitNumber() + "    Air Attack: " + terStruct._air_atk + "\n" +
                "Defence: " + terStruct._def + "              Organization: " + terStruct._organ + "              Average Piercing: " + terStruct._pierce / battlefieldInstance.GetAtkUnitNumber() + "\n" +
                "Average Armor: " + terStruct._armor / battlefieldInstance.GetAtkUnitNumber() + "   Entrenchment: " + terStruct._entrench;
        }
        private void UpdateStatPanelAir()
        {
            Front_NS.AirStruct airStruct = battlefieldInstance.GetAtkAirStats();
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
        private void PictureFlagAttacker_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureFlagAttacker.Image = null;
            if (flagCounter == 0)
            {
                PictureFlagAttacker.Image = global::Wargame.Properties.Resources.USA_flag;
                LblAtkArmyStats.Text = "USA Army Stats:";
                flagCounter++;
            }
            else
            {
                flagCounter--;
                PictureFlagAttacker.Image = global::Wargame.Properties.Resources.SOV_flag;
                LblAtkArmyStats.Text = "USSR Army Stats:";
            }

            FlagUnitUpdates();
            ChangeCommander();
        }
        private void FlagUnitUpdates()
        {
            PictureLeg.Image = Image.FromFile(UpdateUnitPicture(legUnitNames, legUnitNameCounter, legGen));
            PictureMob.Image = Image.FromFile(UpdateUnitPicture(mobUnitNames, mobUnitNameCounter, mobGen));
            PictureAir.Image = Image.FromFile(UpdateUnitPicture(airUnitNames, airUnitNameCounter, airGen, true));
        }
        private string UpdateUnitPicture(List<string> unitNames, int unitCounter, int gen, bool isAir = false)
        {
            string folderName;
            if (isAir == true)
                folderName = "Air_Units\\";
            else
                folderName = "Ter_Units\\";
            string picName = Tools.dirPath + "Resources\\Unit_Images\\" + folderName + flagNames[flagCounter] + "_" + unitNames[unitCounter] + "_Gen" + Convert.ToString(gen) + ".png";
            return picName;
        }
        private void UpdateStatsLeg()
        {
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(legUnitNameCounter + 201);
            Gen_Enum unit_gen = (Gen_Enum)(legGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(legExp - 1);

            Ter_Unit ter_Unit = new Ter_Unit(unit_gen, unit_type, unit_xp);

            LblLegStats1Values.Text = ter_Unit._hp.ToString() + "\n" +
                ter_Unit._s_atk.ToString() + "\n" +
                ter_Unit._h_atk.ToString() + "\n" +
                ter_Unit._def.ToString() + "\n" +
                ter_Unit._armor.ToString();

            LblLegStats2Values.Text = ter_Unit._breakt.ToString() + "\n" +
                ter_Unit._fuel.ToString() + "\n" +
                ter_Unit._reliab.ToString() + "\n" +
                ter_Unit._organ.ToString() + "\n" +
                ter_Unit._entrench.ToString();

            LblLegStats3Values.Text = ter_Unit._combat_width.ToString() + "\n" +
                ter_Unit._hardness.ToString() + "\n" +
                ter_Unit._air_atk.ToString() + "\n" +
                ter_Unit._pierce.ToString();
        }
        private void UpdateStatsMob()
        {
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(mobUnitNameCounter + 101);
            Gen_Enum unit_gen = (Gen_Enum)(mobGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(mobExp - 1);

            Ter_Unit ter_Unit = new Ter_Unit(unit_gen, unit_type, unit_xp);

            LblMobStats1Values.Text = ter_Unit._hp.ToString() + "\n" +
                ter_Unit._s_atk.ToString() + "\n" +
                ter_Unit._h_atk.ToString() + "\n" +
                ter_Unit._def.ToString() + "\n" +
                ter_Unit._armor.ToString();

            LblMobStats2Values.Text = ter_Unit._breakt.ToString() + "\n" +
                ter_Unit._fuel.ToString() + "\n" +
                ter_Unit._reliab.ToString() + "\n" +
                ter_Unit._organ.ToString() + "\n" +
                ter_Unit._entrench.ToString();

            LblMobStats3Values.Text = ter_Unit._combat_width.ToString() + "\n" +
                ter_Unit._hardness.ToString() + "\n" +
                ter_Unit._air_atk.ToString() + "\n" +
                ter_Unit._pierce.ToString();
        }
        private void UpdateStatsAir()
        {
            Air_Units_Enum unit_type = (Air_Units_Enum)(airUnitNameCounter + 301);
            if (airUnitNameCounter == 4 || airUnitNameCounter == 3)
                unit_type += 97;
            Gen_Enum unit_gen = (Gen_Enum)(airGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(airExp - 1);

            Air_Unit air_Unit = new Air_Unit(unit_gen, unit_type, unit_xp);

            LblAirStats1Values.Text = air_Unit._hp.ToString() + "\n" +
                air_Unit._air_atk.ToString() + "\n" +
                air_Unit._gnd_atk.ToString() + "\n" +
                air_Unit._air_sup.ToString() + "\n" +
                air_Unit._strat_bmb.ToString();

        }
        private void BtnLegGen_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureLeg.Image = Image.FromFile(GetUnitPicturePath(legUnitNames, legUnitNameCounter, ref legGen));
            PictureLegGen.Image = Image.FromFile(GetGenPicturePath(legGen));

            UpdateStatsLeg();
        }
        private void BtnMobGen_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureMob.Image = Image.FromFile(GetUnitPicturePath(mobUnitNames, mobUnitNameCounter, ref mobGen));
            PictureMobGen.Image = Image.FromFile(GetGenPicturePath(mobGen));

            UpdateStatsMob();
        }
        private void BtnAirGen_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            PictureAir.Image = Image.FromFile(GetUnitPicturePath(airUnitNames, airUnitNameCounter, ref airGen, true));
            PictureAirGen.Image = Image.FromFile(GetGenPicturePath(airGen));

            UpdateStatsAir();
        }
        private void BtnNextLeg_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            legUnitNameCounter++;
            legUnitNameCounter = legUnitNameCounter % legUnitNames.Count();
            PictureLeg.Image = Image.FromFile(UpdateUnitPicture(legUnitNames, legUnitNameCounter, legGen));

            UpdateStatsLeg();
        }

        private void BtnNextMob_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            mobUnitNameCounter++;
            mobUnitNameCounter = mobUnitNameCounter % mobUnitNames.Count();
            PictureMob.Image = Image.FromFile(UpdateUnitPicture(mobUnitNames, mobUnitNameCounter, mobGen));

            UpdateStatsMob();
        }

        private void BtnNextAir_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            airUnitNameCounter++;
            airUnitNameCounter = airUnitNameCounter % airUnitNames.Count();
            PictureAir.Image = Image.FromFile(UpdateUnitPicture(airUnitNames, airUnitNameCounter, airGen, true));

            UpdateStatsAir();
        }
        private void BtnPrevLeg_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            legUnitNameCounter--;
            if (legUnitNameCounter < 0)
                legUnitNameCounter = legUnitNames.Count() - 1;
            PictureLeg.Image = Image.FromFile(UpdateUnitPicture(legUnitNames, legUnitNameCounter, legGen));

            UpdateStatsLeg();
        }

        private void BtnPrevMob_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            mobUnitNameCounter--;
            if (mobUnitNameCounter < 0)
                mobUnitNameCounter = mobUnitNames.Count() - 1;
            PictureMob.Image = Image.FromFile(UpdateUnitPicture(mobUnitNames, mobUnitNameCounter, mobGen));

            UpdateStatsMob();
        }

        private void BtnPrevAir_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            airUnitNameCounter--;
            if (airUnitNameCounter < 0)
                airUnitNameCounter = airUnitNames.Count() - 1;
            PictureAir.Image = Image.FromFile(UpdateUnitPicture(airUnitNames, airUnitNameCounter, airGen, true));

            UpdateStatsAir();
        }

        private void BtnAddLeg_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(legUnitNameCounter + 201);
            Gen_Enum unit_gen = (Gen_Enum)(legGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(legExp - 1);
            battlefieldInstance.AddAtkTerUnit(unit_gen, unit_type, unit_xp);
            legUnitCounter = battlefieldInstance.GetAtkLegUnitNumber();
            LblLegCounter.Text = "Units: " + Convert.ToString(legUnitCounter);

            UpdateStatPanelTer();
            UpdateArmyComposition();
        }

        private void BtnSubLeg_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(legUnitNameCounter + 201);
            Gen_Enum unit_gen = (Gen_Enum)(legGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(legExp - 1);
            battlefieldInstance.SubAtkTerUnit(unit_gen, unit_type, unit_xp);
            legUnitCounter = battlefieldInstance.GetAtkLegUnitNumber();
            LblLegCounter.Text = "Units: " + Convert.ToString(legUnitCounter);

            UpdateStatPanelTer();
            UpdateArmyComposition();
        }

        private void BtnAddMob_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(mobUnitNameCounter + 101);
            Gen_Enum unit_gen = (Gen_Enum)(mobGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(mobExp - 1);
            battlefieldInstance.AddAtkTerUnit(unit_gen, unit_type, unit_xp);
            mobUnitCounter = battlefieldInstance.GetAtkMobUnitNumber();
            LblMobCounter.Text = "Units: " + Convert.ToString(mobUnitCounter);

            UpdateStatPanelTer();
            UpdateArmyComposition();
        }

        private void BtnSubMob_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            Ter_Units_Enum unit_type = (Ter_Units_Enum)(mobUnitNameCounter + 101);
            Gen_Enum unit_gen = (Gen_Enum)(mobGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(mobExp - 1);
            battlefieldInstance.SubAtkTerUnit(unit_gen, unit_type, unit_xp);
            mobUnitCounter = battlefieldInstance.GetAtkMobUnitNumber();
            LblMobCounter.Text = "Units: " + Convert.ToString(mobUnitCounter);

            UpdateStatPanelTer();
            UpdateArmyComposition();
        }

        private void BtnSubAir_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            Air_Units_Enum unit_type = (Air_Units_Enum)(airUnitNameCounter + 301);
            if (airUnitNameCounter == 4 || airUnitNameCounter == 3)
                unit_type += 97;
            Gen_Enum unit_gen = (Gen_Enum)(airGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(airExp - 1);
            battlefieldInstance.SubAtkAirUnit(unit_gen, unit_type, unit_xp);
            airUnitCounter = battlefieldInstance.GetAtkAirUnitNumber();
            LblAirCounter.Text = "Units: " + Convert.ToString(airUnitCounter);

            UpdateStatPanelAir();
            UpdateAirforceComposition();
        }

        private void BtnAddAir_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            Air_Units_Enum unit_type = (Air_Units_Enum)(airUnitNameCounter + 301);
            if (airUnitNameCounter == 4 || airUnitNameCounter == 3)
                unit_type += 97;
            Gen_Enum unit_gen = (Gen_Enum)(airGen - 1);
            Regiment_Exp_Enum unit_xp = (Regiment_Exp_Enum)(airExp - 1);
            battlefieldInstance.AddAtkAirUnit(unit_gen, unit_type, unit_xp);
            airUnitCounter = battlefieldInstance.GetAtkAirUnitNumber();
            LblAirCounter.Text = "Units: " + Convert.ToString(airUnitCounter);

            UpdateStatPanelAir();
            UpdateAirforceComposition();
        }

        private void PictureLegExp_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            legExp++;
            legExp %= 5;
            PictureLegExp.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Icons\\unit_level_" + Convert.ToString(legExp + 1) + ".jpg");
            LblLegExp.Text = expNames[legExp];

            UpdateStatsLeg();
        }
        private void PictureMobExp_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            mobExp++;
            mobExp %= 5;
            PictureMobExp.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Icons\\unit_level_" + Convert.ToString(mobExp + 1) + ".jpg");
            LblMobExp.Text = expNames[mobExp];

            UpdateStatsMob();
        }
        private void PictureAirExp_Click(object sender, EventArgs e)
        {
            buttonSound.Play();
            airExp++;
            airExp %= 5;
            PictureAirExp.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Icons\\unit_level_" + Convert.ToString(airExp + 1) + ".jpg");
            LblAirExp.Text = expNames[airExp];

            UpdateStatsAir();
        }
        private void ChangeCommander()
        {
            buttonSound.Play();
            string commander_name = battlefieldInstance.GetCommanderNameAtk();

            if (commander_name == "Zhukov")
            {
                battlefieldInstance.SetCommanderNameAtk("MacArthur");
            }
            else if (commander_name == "MacArthur")
            {
                battlefieldInstance.SetCommanderNameAtk("Zhukov");
            }

            UpdateCommander();
        }
        private void UpdateCommander()
        {
            string commander_name = battlefieldInstance.GetCommanderNameAtk();
            if (commander_name == "Zhukov")
            {
                PictureCommander.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Commanders\\zhukov.jpg");
            }
            else if (commander_name == "MacArthur")
            {
                PictureCommander.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Commanders\\macarthur.jpg");
            }
        }

        private void TrackBarFuel_Scroll(object sender, EventArgs e)
        {
            battlefieldInstance.SetFuelAtk(TrackBarFuel.Value);
            LblFuel.Text = "Fuel Available: " + TrackBarFuel.Value.ToString();
        }
    }
}
