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
    }
}
