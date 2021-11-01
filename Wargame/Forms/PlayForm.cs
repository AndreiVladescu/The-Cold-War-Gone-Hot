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
            
        }
        private void UpdateDoctrinePictures()
        {

        }

        private void BtnSimulate_Click(object sender, EventArgs e)
        {
            countHoursPassed++;
            BtnSimulate.Text = "Hours Passed: " + countHoursPassed.ToString();

            int result = battlefieldInstance.ComputeTurn();
            if (result == 2)
                LblStatus.Text = "Defenders Won";
            else if (result == -2)
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

        private void ChBoxAtkAir_CheckedChanged(object sender, EventArgs e)
        {
            this.battlefieldInstance._atk_air_attacks = !this.battlefieldInstance._atk_air_attacks;
        }

        private void ChBoxAtkArmy_CheckedChanged(object sender, EventArgs e)
        {
            this.battlefieldInstance._atk_ter_attacks = !this.battlefieldInstance._atk_ter_attacks;
        }
    }
}
