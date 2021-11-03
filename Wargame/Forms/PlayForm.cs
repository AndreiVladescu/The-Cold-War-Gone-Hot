using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Doctrine_NS;
using Battlefield_NS;
using Enums_NS;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class PlayForm : Form
    {
        int countHoursPassed = 0;

        List<string> atkDoctrineNames = new List<string> { "Breakthrough", "Well Planned Attack", "Relentless Assault" };
        List<string> defDoctrineNames = new List<string> { "Elastic Defense", "Overwhelming Fire", "Backhand Blow" };

        int atkDoctrineCount = 0;
        int defDoctrineCount = 0;

        Doctrine_Enum atkDoctrine = Doctrine_Enum.Breakthrough;
        Doctrine_Enum defDoctrine = Doctrine_Enum.Elastic_Defense;

        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;
        public PlayForm()
        {
            InitializeComponent();
            UpdateGndStats();
            UpdateAirStats();
            UpdateCommanders();
        }
        private void UpdateDoctrinePictures()
        {

        }
        private void UpdateAirStats()
        {
            // Def
            Front_NS.AirStruct airStruct = battlefieldInstance.GetDefAirStats();
            LblDefAirStats.Text = "Airforce Stats:\n" +
                "Integrity: " + airStruct._hp + "\n" +
                "Air Attack: " + airStruct._air_atk + "\n" +
                "Ground Attack: " + airStruct._gnd_atk + "\n" +
                "Air Superiority: " + airStruct._air_sup + "\n" +
                "Strategic Bombing: " + airStruct._strat_bmb;
            // Atk
            Front_NS.AirStruct airStructAtk = battlefieldInstance.GetAtkAirStats();
            LblAtkAirStats.Text = "Airforce Stats:\n" +
                "Integrity: " + airStructAtk._hp + "\n" +
                "Air Attack: " + airStructAtk._air_atk + "\n" +
                "Ground Attack: " + airStructAtk._gnd_atk + "\n" +
                "Air Superiority: " + airStructAtk._air_sup + "\n" +
                "Strategic Bombing: " + airStructAtk._strat_bmb;

        }
        private void UpdateGndStats()
        {
            Front_NS.TerStruct terStructAtk = battlefieldInstance.GetAtkTerStats();
            this.LblAtkTerStats.Text = "Ground Army Stats:\n" +
                "Manpower: " + terStructAtk._hp + "\nBreakthrough: " + terStructAtk._breakt + "\nCombat Width: " + terStructAtk._combat_width + "\n" +
                "Soft Attack: " + terStructAtk._s_atk + "\nFuel Consumption: " + terStructAtk._fuel + "\nAverage Hardness: " + terStructAtk._hardness / (battlefieldInstance.GetAtkUnitNumber()) + "\n" +
                "Hard Attack: " + terStructAtk._h_atk + "\nAverage Reliability: " + terStructAtk._reliab / battlefieldInstance.GetAtkUnitNumber() + "\nAir Attack: " + terStructAtk._air_atk + "\n" +
                "Defence: " + terStructAtk._def + "\nOrganization: " + terStructAtk._organ + "\nAverage Piercing: " + terStructAtk._pierce / battlefieldInstance.GetAtkUnitNumber() + "\n" +
                "Average Armor: " + terStructAtk._armor / battlefieldInstance.GetAtkUnitNumber() + "\nEntrenchment: " + terStructAtk._entrench;

            Front_NS.TerStruct terStructDef = battlefieldInstance.GetDefTerStats();
            this.LblDefTerStats.Text = "Ground Army Stats:\n" +
                "Manpower: " + terStructDef._hp + "\nBreakthrough: " + terStructDef._breakt + "\nCombat Width: " + terStructDef._combat_width + "\n" +
                "Soft Attack: " + terStructDef._s_atk + "\nFuel Consumption: " + terStructDef._fuel + "\nAverage Hardness: " + terStructDef._hardness / (battlefieldInstance.GetDefUnitNumber()) + "\n" +
                "Hard Attack: " + terStructDef._h_atk + "\nAverage Reliability: " + terStructDef._reliab / battlefieldInstance.GetDefUnitNumber() + "\nAir Attack: " + terStructDef._air_atk + "\n" +
                "Defence: " + terStructDef._def + "\nOrganization: " + terStructDef._organ + "\nAverage Piercing: " + terStructDef._pierce / battlefieldInstance.GetDefUnitNumber() + "\n" +
                "Average Armor: " + terStructDef._armor / battlefieldInstance.GetDefUnitNumber() + "\nEntrenchment: " + terStructDef._entrench;
        }
        private void UpdateCommanders()
        {
            string commander_name = battlefieldInstance.GetCommanderNameAtk();
            if (commander_name == "Zhukov")
            {
                PictureAtkCommander.BackgroundImage = Image.FromFile(Tools.dirPath + "\\Resources\\Commanders\\zhukov.jpg");
            }
            else if (commander_name == "MacArthur")
            {
                PictureAtkCommander.BackgroundImage = Image.FromFile(Tools.dirPath + "\\Resources\\Commanders\\macarthur.jpg");
            }

            commander_name = battlefieldInstance.GetCommanderNameDef();
            if (commander_name == "Zhukov")
            {
                PictureDefCommander.BackgroundImage = Image.FromFile(Tools.dirPath + "\\Resources\\Commanders\\zhukov.jpg");
            }
            else if (commander_name == "MacArthur")
            {
                PictureDefCommander.BackgroundImage = Image.FromFile(Tools.dirPath + "\\Resources\\Commanders\\macarthur.jpg");
            }

        }
        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            countHoursPassed++;
            BtnSimulate.Text = "Hours Passed: " + countHoursPassed.ToString();

            int result = battlefieldInstance.ComputeTurn();

            UpdateGndStats();
            UpdateAirStats();

            if (result == 3)
                LblStatus.Text = "Defenders Won";
            else if (result == -3)
                LblStatus.Text = "Attackers Won";
        }
        private void PictureAtkDoctrine_Click(object sender, EventArgs e)
        {
            atkDoctrineCount++;
            atkDoctrineCount %= 3;
            switch (atkDoctrineCount)
            {
                case 0:
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\breakthrough.jpg");
                    LblDoctrineAtkShow.Text = "Breakthrough";
                    break;
                case 1:
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\planned_attack.jpg");
                    LblDoctrineAtkShow.Text = "Well Planned Attack";
                    break;
                case 2:
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\relentless_assault.jpg");
                    LblDoctrineAtkShow.Text = "Relentless Assault";
                    break;
                default:
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\breakthrough.jpg");
                    break;
            }

            atkDoctrine = (Doctrine_Enum)(atkDoctrineCount + 1);

        }
        private void PictureDefDoctrine_Click(object sender, EventArgs e)
        {
            defDoctrineCount++;
            defDoctrineCount %= 3;
            switch (defDoctrineCount)
            {
                case 0:
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\elastic_defence.jpg");
                    LblDoctrineDefShow.Text = "Elastic Defence";
                    break;
                case 1:
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\overwhelming_fire.jpg");
                    LblDoctrineDefShow.Text = "Overwhelming Fire";
                    break;
                case 2:
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\backhand_blow.jpg");
                    LblDoctrineDefShow.Text = "Backhand Blow";
                    break;
                default:
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\elastic_defence.jpg");
                    break;
            }

            defDoctrine = (Doctrine_Enum)(defDoctrineCount + 11);
        }
        private void ChBoxAtkAir_CheckedChanged(object sender, EventArgs e)
        {
            this.battlefieldInstance._atk_air_attacks = !this.battlefieldInstance._atk_air_attacks;
        }

        private void ChBoxAtkArmy_CheckedChanged(object sender, EventArgs e)
        {
            this.battlefieldInstance._atk_ter_attacks = !this.battlefieldInstance._atk_ter_attacks;
        }

        private void ChBoxDefAir_CheckedChanged(object sender, EventArgs e)
        {
            this.battlefieldInstance._def_air_attacks = !this.battlefieldInstance._def_air_attacks;
        }
    }
}
