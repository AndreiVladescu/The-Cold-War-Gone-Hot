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
