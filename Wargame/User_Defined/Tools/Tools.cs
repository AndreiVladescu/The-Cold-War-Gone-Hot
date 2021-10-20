using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wargame.User_Defined.Tools
{
    public class Tools
    {
        public static string dirPath = GetTrueDirectory(Directory.GetCurrentDirectory());
        public static string GetTrueDirectory(string dir)
        {
            string newDir = "";
            string lastWord = "";

            for (int i = 0; i < dir.Length - 1; i++)
            {
                if (lastWord == "\\bin")
                    return newDir + "\\";

                if (dir[i] == '\\')
                {
                    newDir += lastWord;
                    lastWord = "";
                }


                lastWord += dir[i];
            }


            return newDir;
        }
        public static float ReturnCombatWidthEffectiveness(int combatWidth)
        {
            float effectiveness = new float();

            if (combatWidth <= 90)
            {
                effectiveness = (float)1;
            }
            else if (combatWidth <= 120)
            {
                effectiveness = (float)(-2 / 3 * combatWidth + 160) / 100;
            }
            else if (combatWidth <= 140)
            {
                effectiveness = (float)(-3 / 2 * combatWidth + 260) / 100;
            }
            else if (combatWidth <= 160)
            {
                effectiveness = (float)(-2 * combatWidth + 330) / 100;
            }
            else
                effectiveness = (float)0.1;

            return effectiveness;
        }
    }
    //public class Parser
    //{
    //    public struct Unit
    //    {
    //        public Unit(string name,
    //            float hp,)
    //    }
    //}
}
