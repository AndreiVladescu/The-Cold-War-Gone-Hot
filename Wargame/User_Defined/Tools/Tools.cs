using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace Wargame.User_Defined.Tools
{
    static public class Tools
    {

        public static string dirPath = GetTrueDirectory(Directory.GetCurrentDirectory());
        public const UInt32 SPI_SETMOUSESPEED = 0x0071;
        public const UInt32 SPI_GETMOUSESPEED = 0x0070;
        public static UInt32 systemMouseSpeed = 10;
        public static UInt32 pvParam = 10;

        [DllImport("User32.dll")]
        public static extern Boolean SystemParametersInfo(
           UInt32 uiAction,
           UInt32 uiParam,
           UInt32 pvParam,
           UInt32 fWinIni);
        
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
        public static string GetFileName(string filePath)
        {
            int slash1 = 0, slash2 = 0;
            string fileName = filePath;

            for (int i = 0; i < fileName.Length; i++)
            {
                Console.WriteLine(fileName[i]);
                char ch = fileName[i];
                if (ch == '\\')
                {
                    if (slash1 == slash2) // Start of function
                    {
                        slash2 = i;
                    }
                    else
                    {
                        slash1 = slash2;
                        slash2 = i;
                    }
                }
            }

            fileName = fileName.Remove(0, slash2 + 1);
            fileName = fileName.Remove(fileName.Length - 4, 4);
            return fileName;
        }
        public static float ReturnCombatWidthEffectiveness(int combatWidth)
        {
            float effectiveness;

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
        public static float ReturnArmorPiercingEffectiveness(float armor, float piercing)
        {
            float effectiveness;
            float rate = piercing / armor;
            if (rate < 0.2)
            {
                effectiveness = (float)0.2;
            }
            else if (rate <= 1)
            {
                effectiveness = rate;
            }
            else 
            {
                effectiveness = (float)1.1;
            }
            return effectiveness;
        }
        public static float ReturnAirSuperiorityEffectiveness(float airAtk, float airDef, float AABattery)
        {
            float effectiveness;
            float rate = airAtk / (airDef + AABattery);
            if (rate < 0.2)
            {
                effectiveness = (float)0.2;
            }
            else if (rate <= 1)
            {
                effectiveness = rate;
            }
            else
            {
                effectiveness = (float)1.2;
            }
            return effectiveness;
        }
        public static float ReturnDefenseBreakthroughEffectiveness(float defence, float breakthrough)
        {
            float effectiveness;
            float rate = breakthrough / defence;
            if (rate < 0.5)
            {
                effectiveness = (float)0.5;
            }
            else if (rate <= 1)
            {
                effectiveness = rate;
            }
            else
            {
                effectiveness = (float)1.2;
            }
            return effectiveness;
        }
        public static float ReturnCombatLossesThroughReliability(float average_reliability, float manpower)
        {
            float losses;
            Random rand = new Random();

            losses = (rand.Next(100, 102) / 100) * (average_reliability / 100) * (manpower / 100);

            return losses;
        }
        public static void UpdateMouseValue(UInt32 mouseSpeed)
        {
           SystemParametersInfo(
           SPI_SETMOUSESPEED,
           0,
           mouseSpeed,
           0);
        }
        public static void SaveMouseValue()
        {
            SystemParametersInfo(
           SPI_GETMOUSESPEED,
           0,
           pvParam,
           0);
        }
    }
}
