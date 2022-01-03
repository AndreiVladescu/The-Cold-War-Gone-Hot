using Battlefield_NS;
using Enums_NS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wargame.User_Defined.Tools;

namespace Wargame.Forms
{
    public partial class PlayForm : Form
    {
        int countHoursPassed = 0;
        static bool simulationStarted = false;

        List<string> atkDoctrineNames = new List<string> { "Breakthrough", "Well Planned Attack", "Relentless Assault" };
        List<string> defDoctrineNames = new List<string> { "Elastic Defense", "Overwhelming Fire", "Backhand Blow" };

        int atkDoctrineCount = 0;
        int defDoctrineCount = 0;

        static public Doctrine_Enum atkDoctrine = Doctrine_Enum.Breakthrough;
        static public Doctrine_Enum defDoctrine = Doctrine_Enum.Elastic_Defense;

        Battlefield battlefieldInstance = Battlefield.battlefieldInstance;
        public PlayForm()
        {
            InitializeComponent();
            UpdateGndStats();
            UpdateAirStats();
            UpdateCommanders();
            UpdateFuel();
            UpdateModifiers();
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


            UpdateModifiers();
        }
        private async void BtnSimulate_ClickAsync(object sender, EventArgs e)
        {
            simulationStarted = !simulationStarted;
            if (simulationStarted)
            {
                while (simulationStarted)
                {
                    if (Math.Abs(StartSimulation()) == 3)
                        break;
                    await Task.Delay(1500);
                }
            }
        }
        private int StartSimulation()
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

            UpdateFuel();
            return result;
        }

        private void UpdateFuel()
        {
            LblAtkFuel.Text = "Fuel Left: " + battlefieldInstance._atk._fuel_left.ToString();
            LblDefFuel.Text = "Fuel Left: " + battlefieldInstance._def._fuel_left.ToString();
        }

        private void PictureAtkDoctrine_Click(object sender, EventArgs e)
        {
            atkDoctrineCount++;
            atkDoctrineCount %= 3;
            switch (atkDoctrineCount)
            {
                case 0:
                    battlefieldInstance._atk._doctrine.attackModifier = (float)0.075;
                    battlefieldInstance._atk._doctrine.defendModifier = (float)0.075;
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\breakthrough.jpg");
                    LblDoctrineAtkShow.Text = "Breakthrough";
                    break;
                case 1:
                    battlefieldInstance._atk._doctrine.attackModifier = (float)0.025;
                    battlefieldInstance._atk._doctrine.defendModifier = (float)0.1;
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\planned_attack.jpg");
                    LblDoctrineAtkShow.Text = "Well Planned Attack";
                    break;
                case 2:
                    battlefieldInstance._atk._doctrine.attackModifier = (float)0.15;
                    battlefieldInstance._atk._doctrine.defendModifier = (float)0;
                    PictureAtkDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\relentless_assault.jpg");
                    LblDoctrineAtkShow.Text = "Relentless Assault";
                    break;
                default:
                    throw new Exception("Image not found");
            }

            atkDoctrine = (Doctrine_Enum)(atkDoctrineCount + 1);
            UpdateModifiers();
        }
        private void PictureDefDoctrine_Click(object sender, EventArgs e)
        {
            defDoctrineCount++;
            defDoctrineCount %= 3;
            switch (defDoctrineCount)
            {
                case 0:
                    battlefieldInstance._def._doctrine.attackModifier = (float)0.075;
                    battlefieldInstance._def._doctrine.defendModifier = (float)0.075;
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\elastic_defence.jpg");
                    LblDoctrineDefShow.Text = "Elastic Defence";
                    break;
                case 1:
                    battlefieldInstance._def._doctrine.attackModifier = (float)0;
                    battlefieldInstance._def._doctrine.defendModifier = (float)0.25;
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\overwhelming_fire.jpg");
                    LblDoctrineDefShow.Text = "Overwhelming Fire";
                    break;
                case 2:
                    battlefieldInstance._def._doctrine.attackModifier = (float)0.175;
                    battlefieldInstance._def._doctrine.defendModifier = (float)0.05;
                    PictureDefDoctrine.Image = Image.FromFile(Tools.dirPath + "\\Resources\\Doctrines\\backhand_blow.jpg");
                    LblDoctrineDefShow.Text = "Backhand Blow";
                    break;
                default:
                    throw new Exception("Image not found");
            }

            defDoctrine = (Doctrine_Enum)(defDoctrineCount + 11);
            UpdateModifiers();
        }

        private void UpdateModifiers()
        {
            LblAtkModifierStats.Text = "Modifiers:\n" +
                ((battlefieldInstance._atk._doctrine.attackModifier + battlefieldInstance._atk._commander._level * (float)0.15) * 100).ToString() + 
                "% attack\n" +
                ((battlefieldInstance._atk._doctrine.defendModifier + battlefieldInstance._atk._commander._level * (float)0.15) * 100).ToString() +
                "% defence";

            LblDefModifierStats.Text = "Modifiers:\n" +
                ((battlefieldInstance._def._doctrine.attackModifier + battlefieldInstance._def._commander._level * (float)0.15) * 100).ToString() +
                "% attack\n" +
                ((battlefieldInstance._def._doctrine.defendModifier + battlefieldInstance._def._commander._level * (float)0.15) * 100).ToString() +
                "% defence";
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
