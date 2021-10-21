using Enums_NS;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wargame.Forms;
using Wargame.User_Defined.Tools;
using System.Runtime.InteropServices;

namespace Wargame
{
    static class Program
    {
        static public List<Parser.Units.Ter_Unit> allTerUnits = new List<Parser.Units.Ter_Unit>();
        static public List<Parser.Units.Air_Unit> allAirUnits = new List<Parser.Units.Air_Unit>();

        [STAThread]
        static void Main(string[] args)
        {
            Parser.Init.TerUnits();
            Parser.Init.AirUnits();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreenForm());
        }
    }
}
