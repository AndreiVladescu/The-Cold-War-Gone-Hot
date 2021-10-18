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
        int _time,
            _fort_level;
        Weather_Enum _weather;
        River_Enum _river;
        Terrain_Enum _terrain;
        Season_Enum _season;

        Front _atk, _def;

        // Image to_do for 
        // Weather - a little indicator 
        // Terrain - like  hoi4 background image
        // River - maybe a little identifier https://duckduckgo.com/?q=river+icon&t=ffab&iar=images&iax=images&ia=images&iai=https%3A%2F%2Fbanner2.kisspng.com%2F20180331%2Ffcw%2Fkisspng-river-computer-icons-symbol-clip-art-river-5abf53bacbfbb3.0075292915224882508355.jpg
        // Season - like https://duckduckgo.com/?q=snowflake+icon&t=ffab&iar=images&iax=images&ia=images&iai=https%3A%2F%2Fwww.clipartmax.com%2Fpng%2Fmiddle%2F156-1563013_snowflake-icon.png

        public Battlefield() //for testing reasons
        {

        }
        public Battlefield(int time, 
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

        public int GetTime()
        {
            return _time;
        }
        public int GetFortLevel()
        {
            return _fort_level;
        }
        public Weather_Enum GetWeather()
        {
            return _weather;
        }
        public River_Enum GetRiver()
        {
            return _river;
        }
        public Terrain_Enum GetTerrain()
        {
            return _terrain;
        }
        public Season_Enum GetSeason()
        {
            return _season;
        }
        public void SetTime(int time)
        {
            _time = time;
        }
        public void SetFortLevel(int fort_level)
        {
            _fort_level = fort_level;
        }
        public void SetRiver(River_Enum river)
        {
            _river = river;
        }
        public void SetSeason(Season_Enum season)
        {
            _season = season;
        }
        public void SetTerrain(Terrain_Enum terrain)
        {
            _terrain = terrain;
        }
        public void SetWeather(Weather_Enum weather)
        {
            _weather = weather;
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
    }
}
