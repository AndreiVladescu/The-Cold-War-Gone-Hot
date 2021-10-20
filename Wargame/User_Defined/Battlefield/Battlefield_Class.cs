using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Enums_NS;
using Front_NS;

namespace Battlefield_NS
{
    public class Battlefield
    {
        public static Battlefield battlefieldInstance = new Battlefield();
        public int _time { get; set; }
        public int _fort_level { get; set; }
        public Weather_Enum _weather { get; set; }
        public River_Enum _river { get; set; }
        public Terrain_Enum _terrain { get; set; }
        public Season_Enum _season { get; set; }

        Front _atk = new Front(), 
            _def = new Front();

        // Image to_do for 
        // Weather - a little indicator 
        // Terrain - like  hoi4 background image
        // River - maybe a little identifier https://duckduckgo.com/?q=river+icon&t=ffab&iar=images&iax=images&ia=images&iai=https%3A%2F%2Fbanner2.kisspng.com%2F20180331%2Ffcw%2Fkisspng-river-computer-icons-symbol-clip-art-river-5abf53bacbfbb3.0075292915224882508355.jpg
        // Season - like https://duckduckgo.com/?q=snowflake+icon&t=ffab&iar=images&iax=images&ia=images&iai=https%3A%2F%2Fwww.clipartmax.com%2Fpng%2Fmiddle%2F156-1563013_snowflake-icon.png

        private Battlefield()
        {

        }
        private Battlefield(int time, 
            int fort_level,
            Weather_Enum weather,
            River_Enum river, 
            Terrain_Enum terrain, 
            Season_Enum season)
        {
            _time = time;
            _fort_level = fort_level;
            _weather = weather;
            _river = river;
            _terrain = terrain;
            _season = season;
        }
        public int ComputeTurn()
        {
            _time++;
            if (_time > 23)
                _time = 0;
            _atk.DamageHp(_def.GetBaseStats()[1]);
            _def.DamageHp(_atk.GetBaseStats()[1]);
            if (_atk.GetBaseStats()[0] <= 0)
                return 1; // Defender team won
            else if (_def.GetBaseStats()[0] <= 0)
                return 2; // Attacker team won
            else
                return 0; // The battle continues
        }
        public List<float> ReturnAttackerStats()
        {
            List<float> attackerList = new List<float> {1, 2};
            return attackerList;
        }
        public List<float> ReturnDefenderStats()
        {
            List<float> defenderList = new List<float> { 1, 2 };
            return defenderList;
        }
        public void AddDefTerUnit(float[] unitStats)
        {
            if (unitStats.Length < 3)
                return;
            List<float> stats = new List<float> { unitStats[0], unitStats[1], unitStats[2] };
            _def.AddTerUnit(stats);
        }
        public void AddAtkTerUnit(float[] unitStats)
        {
            if (unitStats.Length < 3)
                return;
            List<float> stats = new List<float> { unitStats[0], unitStats[1], unitStats[2] };
            _atk.AddAirUnit(stats);
        }
        public void SubDefTerUnit()
        {
            if (_def.ReturnNumbers() != 0)
            {
                _def.SubTerUnit();
            }
        }
        public int DefReturnNumbers()
        {
            return _def.ReturnNumbers();
        }
    }
}
